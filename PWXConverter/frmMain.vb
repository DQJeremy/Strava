Imports System.Xml
Imports PWXConverter.TCX
Imports System.Xml.Serialization
Imports System.IO
Imports PWXConverter.PWX
Imports System.Text
Imports com.strava.api.Clients
Imports com.strava.api.Authentication
Imports com.strava.api.Upload
Imports com.strava.api
Imports com.strava.api.Gear

Public Class frmMain

    Private m_sSourceDirectory As String = ""
    Private m_sDestDirectory As String = ""
    Private m_sSourceFile As String = ""
    Private m_oDestSB As StringBuilder = Nothing
    Private m_sDestFile As String = ""
    Private m_sStravaToken As String = ""

    Private Delegate Sub m_DelegateSetStravaStatus(ByVal sStatus As String)
    Private Delegate Sub m_DelegateSetStravaConnect(ByVal sToken As String)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'get settings
        m_sSourceDirectory = My.Settings.SourceDirectory
        m_sDestDirectory = My.Settings.DestDirectory
        Me.Size = My.Settings.frmMain_Size
        Me.WindowState = My.Settings.frmMain_WindowState
        m_sStravaToken = My.Settings.StravaToken

    End Sub

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Try
            'intialize form
            lblSource.Text = ""
            lblStravaStatus.Text = ""
            lblDestination.Text = ""
            lblStravaConnect.Text = ""

            'connect to strava if not already connected
            If m_sStravaToken = "" Then
                SetStravaToken()
            Else
                butStravaConnect.Enabled = False
                lblStravaConnect.Text = m_sStravaToken
                InitializeStravaData()
            End If

        Catch ex As Exception
            PushError(ex)
        End Try

    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Try
            'save settings
            My.Settings.SourceDirectory = m_sSourceDirectory
            My.Settings.DestDirectory = m_sDestDirectory
            My.Settings.frmMain_Size = Me.Size
            My.Settings.frmMain_WindowState = Me.WindowState
            My.Settings.StravaToken = m_sStravaToken

        Catch ex As Exception
            PushError(ex)
        End Try

    End Sub

    Private Function ConvertSourceFileToSB(ByVal sSourceFile As String) As StringBuilder

        'convert the source file to dest format
        'return as stringbuilder

        ConvertSourceFileToSB = Nothing

        Try
            If IO.File.Exists(sSourceFile) = False Then
                Throw New Exception("Source file does not exist! File:" & sSourceFile)
            End If

            'deserialize PWX file to class
            Dim oPWX As PWX.pwx = Nothing

            Dim oSerializer As XmlSerializer = New XmlSerializer(GetType(PWX.pwx))

            Using oReader As StreamReader = New StreamReader(sSourceFile)
                oPWX = oSerializer.Deserialize(oReader)
            End Using

            'make sure pwx is deserialized
            If oPWX Is Nothing Then
                Throw New Exception("The source file was not deserialized correctly! File:" & sSourceFile)
            End If

            'create TCX class
            Dim oTCD = New TrainingCenterDatabase

            'TrainingCenterDatabase
            With oTCD
                '.TimeZone = "-05:00"

                'Activities
                .Activities = New ActivityList_t
                With .Activities
                    'Workout=Activity
                    Dim iWorkout As Integer = -1

                    For Each oWorkout In oPWX.workout
                        iWorkout += 1

                        'Activity
                        ReDim Preserve .Activity(iWorkout)
                        .Activity(iWorkout) = New Activity_t
                        With .Activity(iWorkout)
                            'get file time
                            Dim sTime As String = oWorkout.time

                            If IsDate(sTime) Then
                                sTime = Format(CDate(sTime), "yyyy-MM-ddTHH:mm:sszzz")
                            Else
                                Throw New Exception("Time is not valid!")
                            End If

                            .Id = sTime ' "2015-05-01T12:01:43-05:00"

                            'sport type
                            Select Case oWorkout.sportType
                                Case PWX.sportTypes.Bike, PWX.sportTypes.MountainBike
                                    .Sport = Sport_t.Biking
                                Case PWX.sportTypes.Run
                                    .Sport = Sport_t.Running
                                Case Else
                                    .Sport = Sport_t.Other
                            End Select

                            'Segment=Lap
                            Dim iSegment As Integer = -1
                            For Each oSegment As pwxWorkoutSegment In oWorkout.segment
                                iSegment += 1

                                'Laps
                                ReDim Preserve .Lap(iSegment)
                                .Lap(iSegment) = New ActivityLap_t
                                With .Lap(iSegment)
                                    .BeginningOffset = oSegment.summarydata.beginning
                                    .EndOffset = oSegment.summarydata.beginning + oSegment.summarydata.duration
                                    .StartTime = CDate(sTime).AddSeconds(oSegment.summarydata.beginning).ToUniversalTime.ToString("yyyy-MM-ddTHH:mm:ss") ' "2015-05-01T17:01:43.000Z"
                                    .TotalTimeSeconds = oSegment.summarydata.duration
                                    .DistanceMeters = oSegment.summarydata.dist
                                    .MaximumSpeed = 0
                                    .MaximumSpeedSpecified = False
                                    '.MinimumSpeed = 0
                                    '.AverageSpeed = 0
                                    'convert kJ to calories
                                    .Calories = (oSegment.summarydata.work * 0.238845897)
                                    .Intensity = Intensity_t.Active
                                    .Cadence = 0
                                    .CadenceSpecified = False
                                    .TriggerMethod = TriggerMethod_t.Manual

                                    .MaximumHeartRateBpm = New HeartRateInBeatsPerMinute_t
                                    With .MaximumHeartRateBpm
                                        .Value = 0
                                    End With

                                    .AverageHeartRateBpm = New HeartRateInBeatsPerMinute_t
                                    With .AverageHeartRateBpm
                                        .Value = 0
                                    End With

                                End With

                            Next

                        End With

                        Dim oPrevLap As ActivityLap_t = Nothing

                        'sample=track
                        Dim iSample As Integer = -1
                        For Each oSample In oWorkout.sample
                            'make sure lat/long is specified. If not, goto next
                            If oSample.lat = 0 OrElse oSample.lon = 0 Then
                                Continue For
                            End If

                            'find the lap that the current sample falls in
                            Dim oLap As ActivityLap_t = FindLap(.Activity(iWorkout), oSample)

                            If oLap IsNot oPrevLap Then
                                'reset counters
                                iSample = -1

                                'reset Track
                                ReDim Preserve oLap.Track(0)
                                oLap.Track(0) = New Track_t()
                            End If

                            'increment
                            iSample += 1

                            If oLap IsNot Nothing Then
                                With oLap
                                    With .Track(0)
                                        ReDim Preserve .Trackpoint(iSample)
                                        .Trackpoint(iSample) = New Trackpoint_t
                                        With .Trackpoint(iSample)
                                            .Time = CDate(oLap.StartTime).AddSeconds(oSample.timeoffset).AddSeconds(-oLap.BeginningOffset).ToString("yyyy-MM-ddTHH:mm:ss") '2015-04-30T17:01:44.000Z
                                            .AltitudeMeters = oSample.alt
                                            .AltitudeMetersSpecified = True
                                            .DistanceMeters = 0
                                            .DistanceMetersSpecified = False
                                            .HeartRateBpm = New HeartRateInBeatsPerMinute_t
                                            .HeartRateBpm.Value = oSample.hr

                                            .Position = New Position_t
                                            With .Position
                                                .LatitudeDegrees = oSample.lat
                                                .LongitudeDegrees = oSample.lon
                                            End With

                                        End With

                                    End With
                                End With
                            End If

                            'set previous
                            oPrevLap = oLap

                        Next

                    Next

                End With

            End With

            'serialize to tcx file
            Dim oXMLSerializer As System.Xml.Serialization.XmlSerializer = New System.Xml.Serialization.XmlSerializer(oTCD.GetType())

            'Using oStringWriter As New System.IO.StringWriter()
            '    oXMLSerializer.Serialize(oStringWriter, oTCD)
            '    ConvertSourceFileToSB = oStringWriter.GetStringBuilder
            'End Using

            'write to destination
            Using oMemorySteam As New MemoryStream
                Using oTextWriter As New XmlTextWriter(oMemorySteam, Encoding.UTF8) 'make sure utf encoding
                    'set xml formatting
                    oTextWriter.Formatting = Formatting.Indented

                    'serialize to xml writer
                    oXMLSerializer.Serialize(oTextWriter, oTCD)

                    'flush 
                    oTextWriter.Flush()

                    'Use a StreamReader to get the byte order correct
                    Using oStreamReader As New StreamReader(oMemorySteam)
                        oMemorySteam.Seek(0, SeekOrigin.Begin)
                        ConvertSourceFileToSB = New StringBuilder(oStreamReader.ReadToEnd)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            PushError(ex)
        End Try

    End Function

    Private Function FindLap(ByVal oActivity As Activity_t _
                       , ByVal oSample As pwxWorkoutSample) As ActivityLap_t

        'find the lap based on the workout sample time

        FindLap = Nothing

        Try
            For Each oLap In oActivity.Lap
                If oSample.timeoffset >= oLap.BeginningOffset _
                    AndAlso oSample.timeoffset <= oLap.EndOffset Then
                    'found
                    Return oLap
                End If
            Next

        Catch ex As Exception
            PushError(ex)
        End Try

    End Function

    Private Sub butSaveTCX_Click(sender As System.Object, e As System.EventArgs) Handles butSaveTCX.Click
        SaveDestSBToFile()
    End Sub

    Private Sub SaveDestSBToFile()

        'save the destination string to a file

        Try
            'make sure destination is set
            If m_oDestSB Is Nothing OrElse m_oDestSB.Length = 0 Then
                Throw New Exception("The destination string is not set!")
            End If

            'make sure source file is set
            If IO.File.Exists(m_sSourceFile) = False Then
                Throw New Exception("The source file does not exist! Source:" & m_sSourceFile)
            End If

            'get dest filename from source file name
            Dim sDestFileName As String = IO.Path.ChangeExtension(m_sSourceFile, "tcx")

            'select location to save file
            With sfdBrowse
                .Title = "Save file"
                .Filter = "tcx files (*.tcx)|*.tcx|All files (*.*)|*.*"
                .FileName = IO.Path.GetFileName(sDestFileName)
                .CheckPathExists = True

                'set initial directory
                If IO.Directory.Exists(m_sDestDirectory) Then
                    .InitialDirectory = m_sDestDirectory
                Else
                    'set to same as source
                    .InitialDirectory = IO.Directory.GetParent(m_sSourceFile).FullName
                End If

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Cursor = Cursors.WaitCursor

                    'set directory
                    m_sDestDirectory = IO.Directory.GetParent(.FileName).FullName

                    'set file source
                    m_sDestFile = .FileName

                    'save dest string to dest file
                    Using oStreamWriter As New System.IO.StreamWriter(m_sDestFile, False, System.Text.Encoding.UTF8)
                        oStreamWriter.Write(m_oDestSB)
                    End Using

                    'make sure file exists
                    If IO.File.Exists(m_sDestFile) Then
                        butUploadToStrava.Enabled = True
                        'MsgBox("Saved!")
                        lblDestination.Text = m_sDestFile
                    Else
                        MsgBox("File not saved!")
                    End If

                End If

            End With

        Catch ex As Exception
            PushError(ex)
        Finally
            Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub butSelectSource_Click(sender As System.Object, e As System.EventArgs) Handles butSelectSource.Click

        Try
            Dim sSourceFile As String = GetSourceFile()

            If sSourceFile > "" Then
                Cursor = Cursors.WaitCursor

                rtbSource.Text = "loading..."

                'reset when source changes
                butSaveTCX.Enabled = False
                butUploadToStrava.Enabled = False
                rtbDestination.Text = ""
                lblDestination.Text = ""

                'set file source
                m_sSourceFile = sSourceFile
                lblSource.Text = m_sSourceFile

                'read file to string
                Dim sFileString As String = IO.File.ReadAllText(m_sSourceFile)

                'indent xml string
                sFileString = IndentXMLString(sFileString)

                'load string to rtb
                rtbSource.Text = sFileString

                rtbDestination.Text = "converting..."

                'convert pwx file to string
                m_oDestSB = ConvertSourceFileToSB(m_sSourceFile)

                If m_oDestSB IsNot Nothing Then
                    'show in rtb destination
                    rtbDestination.Text = m_oDestSB.ToString
                    butSaveTCX.Enabled = True
                Else
                    rtbDestination.Text = ""
                End If

            End If

        Catch ex As Exception
            PushError(ex)
        Finally
            Cursor = Cursors.Default
        End Try

    End Sub

    Private Function GetSourceFile() As String

        GetSourceFile = ""

        Try
            With ofdBrowse
                .Title = "Select Source file"
                .Filter = "pwx files (*.pwx)|*.pwx|All files (*.*)|*.*"
                .FileName = ""
                .CheckFileExists = True
                .CheckPathExists = True

                If IO.Directory.Exists(m_sSourceDirectory) Then
                    .InitialDirectory = m_sSourceDirectory
                Else
                    .InitialDirectory = g_sAppPath
                End If

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    GetSourceFile = .FileName

                    'set directory
                    m_sSourceDirectory = IO.Directory.GetParent(.FileName).FullName

                End If

            End With

        Catch ex As Exception
            PushError(ex)
        End Try

    End Function

    Private Async Sub butUploadToStrava_Click(sender As System.Object, e As System.EventArgs) Handles butUploadToStrava.Click
        Await UploadToStrava()
    End Sub

    Private Async Function UploadToStrava() As Threading.Tasks.Task

        Try
            Cursor = Cursors.WaitCursor

            If m_sStravaToken = "" Then
                'set the strava token
                SetStravaToken()
            Else
                lblStravaStatus.Text = "Authenticating..."
                Dim oAuth As IAuthentication = New StaticAuthentication(m_sStravaToken)

                Dim oClient As StravaClient = New StravaClient(oAuth)

                lblStravaStatus.Text = "Uploading..."
                Dim oStatus As UploadStatus = Await oClient.Uploads.UploadActivityAsync(m_sDestFile, DataFormat.Tcx, com.strava.api.Activities.ActivityType.Ride)

                Dim oUploadStatus As UploadStatus = Await oClient.Uploads.CheckUploadStatusAsync(oStatus.Id.ToString())

                If oUploadStatus.CurrentStatus = CurrentUploadStatus.Error Then
                    'error
                    lblStravaStatus.Text = "Error: " & oUploadStatus.Error
                Else
                    lblStravaStatus.Text = oUploadStatus.Status

                    Dim oCheck As UploadStatusCheck = New UploadStatusCheck(m_sStravaToken, oStatus.Id.ToString())

                    AddHandler oCheck.UploadChecked, (Sub(o As Object, args As UploadStatusCheckedEventArgs)
                                                          UpdateStravaStatus(args.Status.ToString)
                                                      End Sub)

                    'get selected bike
                    Dim oBike As Bike = Nothing
                    If cboStravaGear.SelectedItem IsNot Nothing Then
                        oBike = CType(cboStravaGear.SelectedItem, AddItem).Value
                    End If

                    AddHandler oCheck.ActivityReady, Sub(sender As Object, e As EventArgs)
                                                         'get the activityId since the activity has now been uploaded
                                                         Dim oActivityStatus = oClient.Uploads.CheckUploadStatus(oStatus.Id.ToString())

                                                         'set activity properties

                                                         'name - only update if something set
                                                         If txtStravaName.Text.Trim > "" Then
                                                             oClient.Activities.UpdateActivity(oActivityStatus.ActivityId, com.strava.api.Activities.ActivityParameter.Name, txtStravaName.Text)
                                                         End If

                                                         'bike
                                                         If oBike IsNot Nothing Then
                                                             oClient.Activities.UpdateActivity(oActivityStatus.ActivityId, com.strava.api.Activities.ActivityParameter.GearId, oBike.Id)
                                                         End If

                                                         'upload is complete
                                                         UpdateStravaStatus("Upload complete!")

                                                         'open strava dashboard
                                                         Dim sWebAddress As String = "https://www.strava.com/dashboard"
                                                         Process.Start(sWebAddress)

                                                     End Sub

                    'AddHandler oCheck.UploadChecked, AddressOf StravaUploadChecked
                    'AddHandler oCheck.ActivityReady, AddressOf StravaActivityReady

                    'Dim m_oUploadChecked As New EventHandler(Sub(o As Object, args As UploadStatusCheckedEventArgs)
                    '                                             'Console.WriteLine(args.Status)
                    '                                             lblStravaStatus.Text = args.Status
                    '                                         End Sub)



                    oCheck.Start()

                End If

            End If

        Catch ex As Exception
            PushError(ex)
        Finally
            Cursor = Cursors.Default
        End Try

    End Function

    Private Sub SetStravaToken()

        Dim oWA As New WebAuthentication()
        oWA.GetTokenAsync("5972", "9bedb2aff45c837cad077e5317e97e161e6a13f6", Scope.Write)

        AddHandler oWA.AccessTokenReceived, AddressOf StravaAccessTokenReceived

    End Sub

    Private Sub StravaAccessTokenReceived(sender As Object, e As TokenReceivedEventArgs)
        UpdateStravaConnect(e.Token)
    End Sub

    Private Sub UpdateStravaConnect(ByVal sToken As String)

        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If butStravaConnect.InvokeRequired OrElse lblStravaConnect.InvokeRequired Then
            Dim d As New m_DelegateSetStravaConnect(AddressOf UpdateStravaConnect)
            Me.Invoke(d, New Object() {sToken})
        Else
            m_sStravaToken = sToken
            butStravaConnect.Enabled = False
            lblStravaConnect.Text = m_sStravaToken
            MsgBox("Connection to Strava has been established!")

            InitializeStravaData()
        End If

    End Sub

    Private Sub StravaUploadChecked(sender As Object, e As UploadStatusCheckedEventArgs)
        UpdateStravaStatus(e.Status.ToString)
    End Sub

    Private Sub UpdateStravaStatus(ByVal sStatus As String)

        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If lblStravaStatus.InvokeRequired Then
            Dim d As New m_DelegateSetStravaStatus(AddressOf UpdateStravaStatus)
            Me.Invoke(d, New Object() {sStatus})
        Else
            lblStravaStatus.Text = sStatus
        End If

    End Sub

    Private Sub InitializeStravaData()

        'connect to strava and download athlete info

        Try
            Dim oAuth As IAuthentication = New StaticAuthentication(m_sStravaToken)

            Dim oClient As StravaClient = New StravaClient(oAuth)

            Dim oAthlete = oClient.Athletes.GetAthlete()

            'bikes
            For Each oBike As com.strava.api.Gear.Bike In oAthlete.Bikes
                cboStravaGear.Items.Add(New AddItem(oBike.Name, oBike))
            Next

            If cboStravaGear.Items.Count > 0 Then
                cboStravaGear.SelectedItem = cboStravaGear.Items(0)

                For Each oItem As AddItem In cboStravaGear.Items
                    If CType(oItem.Value, com.strava.api.Gear.Bike).IsPrimary Then
                        cboStravaGear.SelectedItem = oItem
                    End If
                Next
            End If

        Catch ex As Exception
            PushError(ex)
        End Try

    End Sub

End Class

