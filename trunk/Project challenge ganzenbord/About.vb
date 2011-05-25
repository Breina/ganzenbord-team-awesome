'Ine
'Gemaakt op: 13/05/2011 om 14:11u + 17/05/2011 om 11.33u
'Inlezen bestand about.txt voor 'over ons'
Imports System.IO
Imports Microsoft.VisualBasic.ControlChars


Public Class About

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim inputStream As StreamReader = File.OpenText("About.txt")
        Dim line As String
        line = inputStream.ReadLine()

        While Not line Is Nothing

            TxtAbout.AppendText(line & NewLine)
            line = inputStream.ReadLine()

        End While

        inputStream.Close()
    End Sub

    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        Me.Hide()
    End Sub
End Class