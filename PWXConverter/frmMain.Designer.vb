<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.butSelectSource = New System.Windows.Forms.Button()
        Me.ofdBrowse = New System.Windows.Forms.OpenFileDialog()
        Me.rtbSource = New System.Windows.Forms.RichTextBox()
        Me.lblSource = New System.Windows.Forms.Label()
        Me.rtbDestination = New System.Windows.Forms.RichTextBox()
        Me.scMain = New System.Windows.Forms.SplitContainer()
        Me.butSaveTCX = New System.Windows.Forms.Button()
        Me.sfdBrowse = New System.Windows.Forms.SaveFileDialog()
        Me.butUploadToStrava = New System.Windows.Forms.Button()
        Me.lblStravaStatus = New System.Windows.Forms.Label()
        Me.gbStrava = New System.Windows.Forms.GroupBox()
        Me.txtStravaName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboStravaGear = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDestination = New System.Windows.Forms.Label()
        Me.butStravaConnect = New System.Windows.Forms.Button()
        Me.lblStravaConnect = New System.Windows.Forms.Label()
        CType(Me.scMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scMain.Panel1.SuspendLayout()
        Me.scMain.Panel2.SuspendLayout()
        Me.scMain.SuspendLayout()
        Me.gbStrava.SuspendLayout()
        Me.SuspendLayout()
        '
        'butSelectSource
        '
        Me.butSelectSource.Location = New System.Drawing.Point(12, 12)
        Me.butSelectSource.Name = "butSelectSource"
        Me.butSelectSource.Size = New System.Drawing.Size(109, 23)
        Me.butSelectSource.TabIndex = 1
        Me.butSelectSource.Text = "Select File"
        Me.butSelectSource.UseVisualStyleBackColor = True
        '
        'ofdBrowse
        '
        Me.ofdBrowse.FileName = "OpenFileDialog1"
        '
        'rtbSource
        '
        Me.rtbSource.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbSource.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbSource.Location = New System.Drawing.Point(0, 0)
        Me.rtbSource.Name = "rtbSource"
        Me.rtbSource.ReadOnly = True
        Me.rtbSource.Size = New System.Drawing.Size(381, 409)
        Me.rtbSource.TabIndex = 2
        Me.rtbSource.Text = ""
        Me.rtbSource.WordWrap = False
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.Location = New System.Drawing.Point(127, 17)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(51, 13)
        Me.lblSource.TabIndex = 3
        Me.lblSource.Text = "lblSource"
        '
        'rtbDestination
        '
        Me.rtbDestination.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbDestination.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbDestination.Location = New System.Drawing.Point(0, 0)
        Me.rtbDestination.Name = "rtbDestination"
        Me.rtbDestination.ReadOnly = True
        Me.rtbDestination.Size = New System.Drawing.Size(400, 409)
        Me.rtbDestination.TabIndex = 4
        Me.rtbDestination.Text = ""
        Me.rtbDestination.WordWrap = False
        '
        'scMain
        '
        Me.scMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.scMain.Location = New System.Drawing.Point(12, 220)
        Me.scMain.Name = "scMain"
        '
        'scMain.Panel1
        '
        Me.scMain.Panel1.Controls.Add(Me.rtbSource)
        '
        'scMain.Panel2
        '
        Me.scMain.Panel2.Controls.Add(Me.rtbDestination)
        Me.scMain.Size = New System.Drawing.Size(785, 409)
        Me.scMain.SplitterDistance = 381
        Me.scMain.TabIndex = 5
        '
        'butSaveTCX
        '
        Me.butSaveTCX.Enabled = False
        Me.butSaveTCX.Location = New System.Drawing.Point(12, 41)
        Me.butSaveTCX.Name = "butSaveTCX"
        Me.butSaveTCX.Size = New System.Drawing.Size(109, 23)
        Me.butSaveTCX.TabIndex = 6
        Me.butSaveTCX.Text = "Save TCX"
        Me.butSaveTCX.UseVisualStyleBackColor = True
        '
        'butUploadToStrava
        '
        Me.butUploadToStrava.Enabled = False
        Me.butUploadToStrava.Location = New System.Drawing.Point(6, 48)
        Me.butUploadToStrava.Name = "butUploadToStrava"
        Me.butUploadToStrava.Size = New System.Drawing.Size(109, 23)
        Me.butUploadToStrava.TabIndex = 7
        Me.butUploadToStrava.Text = "Upload to Strava"
        Me.butUploadToStrava.UseVisualStyleBackColor = True
        '
        'lblStravaStatus
        '
        Me.lblStravaStatus.AutoSize = True
        Me.lblStravaStatus.Location = New System.Drawing.Point(121, 53)
        Me.lblStravaStatus.Name = "lblStravaStatus"
        Me.lblStravaStatus.Size = New System.Drawing.Size(78, 13)
        Me.lblStravaStatus.TabIndex = 8
        Me.lblStravaStatus.Text = "lblStravaStatus"
        '
        'gbStrava
        '
        Me.gbStrava.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbStrava.Controls.Add(Me.lblStravaConnect)
        Me.gbStrava.Controls.Add(Me.butStravaConnect)
        Me.gbStrava.Controls.Add(Me.cboStravaGear)
        Me.gbStrava.Controls.Add(Me.Label3)
        Me.gbStrava.Controls.Add(Me.Label1)
        Me.gbStrava.Controls.Add(Me.txtStravaName)
        Me.gbStrava.Controls.Add(Me.butUploadToStrava)
        Me.gbStrava.Controls.Add(Me.lblStravaStatus)
        Me.gbStrava.Location = New System.Drawing.Point(12, 70)
        Me.gbStrava.Name = "gbStrava"
        Me.gbStrava.Size = New System.Drawing.Size(785, 144)
        Me.gbStrava.TabIndex = 9
        Me.gbStrava.TabStop = False
        Me.gbStrava.Text = "Strava"
        '
        'txtStravaName
        '
        Me.txtStravaName.Location = New System.Drawing.Point(80, 84)
        Me.txtStravaName.Name = "txtStravaName"
        Me.txtStravaName.Size = New System.Drawing.Size(190, 20)
        Me.txtStravaName.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Name"
        '
        'cboStravaGear
        '
        Me.cboStravaGear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStravaGear.FormattingEnabled = True
        Me.cboStravaGear.Location = New System.Drawing.Point(80, 110)
        Me.cboStravaGear.Name = "cboStravaGear"
        Me.cboStravaGear.Size = New System.Drawing.Size(190, 21)
        Me.cboStravaGear.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Bikes"
        '
        'lblDestination
        '
        Me.lblDestination.AutoSize = True
        Me.lblDestination.Location = New System.Drawing.Point(127, 46)
        Me.lblDestination.Name = "lblDestination"
        Me.lblDestination.Size = New System.Drawing.Size(70, 13)
        Me.lblDestination.TabIndex = 10
        Me.lblDestination.Text = "lblDestination"
        '
        'butStravaConnect
        '
        Me.butStravaConnect.Location = New System.Drawing.Point(6, 19)
        Me.butStravaConnect.Name = "butStravaConnect"
        Me.butStravaConnect.Size = New System.Drawing.Size(109, 23)
        Me.butStravaConnect.TabIndex = 15
        Me.butStravaConnect.Text = "Connect to Strava"
        Me.butStravaConnect.UseVisualStyleBackColor = True
        '
        'lblStravaConnect
        '
        Me.lblStravaConnect.AutoSize = True
        Me.lblStravaConnect.Location = New System.Drawing.Point(121, 24)
        Me.lblStravaConnect.Name = "lblStravaConnect"
        Me.lblStravaConnect.Size = New System.Drawing.Size(88, 13)
        Me.lblStravaConnect.TabIndex = 16
        Me.lblStravaConnect.Text = "lblStravaConnect"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 641)
        Me.Controls.Add(Me.lblDestination)
        Me.Controls.Add(Me.gbStrava)
        Me.Controls.Add(Me.butSaveTCX)
        Me.Controls.Add(Me.scMain)
        Me.Controls.Add(Me.lblSource)
        Me.Controls.Add(Me.butSelectSource)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convert PWX to TCX"
        Me.scMain.Panel1.ResumeLayout(False)
        Me.scMain.Panel2.ResumeLayout(False)
        CType(Me.scMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scMain.ResumeLayout(False)
        Me.gbStrava.ResumeLayout(False)
        Me.gbStrava.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents butSelectSource As System.Windows.Forms.Button
    Friend WithEvents ofdBrowse As System.Windows.Forms.OpenFileDialog
    Friend WithEvents rtbSource As System.Windows.Forms.RichTextBox
    Friend WithEvents lblSource As System.Windows.Forms.Label
    Friend WithEvents rtbDestination As System.Windows.Forms.RichTextBox
    Friend WithEvents scMain As System.Windows.Forms.SplitContainer
    Friend WithEvents butSaveTCX As System.Windows.Forms.Button
    Friend WithEvents sfdBrowse As System.Windows.Forms.SaveFileDialog
    Friend WithEvents butUploadToStrava As System.Windows.Forms.Button
    Friend WithEvents lblStravaStatus As System.Windows.Forms.Label
    Friend WithEvents gbStrava As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtStravaName As System.Windows.Forms.TextBox
    Friend WithEvents cboStravaGear As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblDestination As System.Windows.Forms.Label
    Friend WithEvents lblStravaConnect As System.Windows.Forms.Label
    Friend WithEvents butStravaConnect As System.Windows.Forms.Button

End Class
