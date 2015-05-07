Imports System.IO
Imports System.Text

Module mGlobal

    Public g_sAppPath As String = System.AppDomain.CurrentDomain.BaseDirectory

    Public Function PushError(ByRef ex As Exception) As String

        Try
            'write the error
            Dim sError As String = _
                "Date/Time: " & DateTime.Now.ToString() & vbCrLf & _
                "Source: " & ex.Source & vbCrLf & _
                "Message: " & ex.Message & vbCrLf & _
                "StackTrace: " & ex.StackTrace

            If ex.InnerException IsNot Nothing Then
                sError &= vbCrLf & _
                    "Inner Exception: " & ex.InnerException.Message
            End If

            MsgBox(sError)

            'return the error string
            PushError = sError

        Catch ex2 As Exception
            PushError = ex2.Message
        End Try

    End Function

    Public Function IndentXMLString(ByVal xml As String) As String

        Dim outXml As String = String.Empty
        Dim ms As New MemoryStream()
        ' Create a XMLTextWriter that will send its output to a memory stream (file)
        Dim xtw As New System.Xml.XmlTextWriter(ms, Encoding.Unicode)
        Dim doc As New System.Xml.XmlDocument()

        'set default
        IndentXMLString = xml

        Try
            ' Load the unformatted XML text string into an instance
            ' of the XML Document Object Model (DOM)
            doc.LoadXml(xml)

            ' Set the formatting property of the XML Text Writer to indented
            ' the text writer is where the indenting will be performed
            xtw.Formatting = System.Xml.Formatting.Indented

            ' write dom xml to the xmltextwriter
            doc.WriteContentTo(xtw)
            ' Flush the contents of the text writer
            ' to the memory stream, which is simply a memory file
            xtw.Flush()

            ' set to start of the memory stream (file)
            ms.Seek(0, SeekOrigin.Begin)
            ' create a reader to read the contents of
            ' the memory stream (file)
            Dim sr As New StreamReader(ms)
            ' return the formatted string to caller
            Return sr.ReadToEnd()

        Catch ex As Exception
            'MessageBox.Show(ex.ToString())
            PushError(ex)
        End Try

    End Function

End Module

Public Class AddItem

    Public Property DisplayText As String = ""
    Public Property Value As Object = Nothing

    Public Sub New()
        'nothing
    End Sub

    Public Sub New(ByVal DisplayText As String _
                 , ByVal Value As Object)
        _DisplayText = DisplayText
        _Value = Value
    End Sub

    Public Overrides Function ToString() As String
        Return _DisplayText
    End Function

End Class
