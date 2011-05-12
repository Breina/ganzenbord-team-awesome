'Brecht
Imports System.IO
Public Class Level

    Public Sub DecodeLevelFile(ByVal fileName As String)
        Dim sr As StreamReader
        sr = File.OpenText("../../../levels/test.txt") ' From the debug .exe, change this when folder structure is made

        Dim s, line As String
        s = ""
        Dim width As Integer

        line = sr.ReadLine()
        width = line.Length()

        While line <> Nothing
            s &= line
            line = sr.ReadLine()
        End While

        MessageBox.Show(s)

        ' Kzal dit hier wel afmake eh :p

    End Sub
End Class
