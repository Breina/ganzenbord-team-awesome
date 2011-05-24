'Ine 
'Gemaakt op: 22/05/2011 om 16:07u
' Inlezen spelregels bestand
Imports System.IO
Imports Microsoft.VisualBasic.ControlChars

Public Class SpelRegels

    Private Sub SpelRegels_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim inputStream As StreamReader = File.OpenText("SpelRegels.txt")
        Dim line As String
        line = inputStream.ReadLine()

        While Not line Is Nothing

            TxtSpelRegels.AppendText(line & NewLine)
            line = inputStream.ReadLine()

        End While

        inputStream.Close()
    End Sub

    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        Me.Hide()
    End Sub
End Class
