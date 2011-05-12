'Brecht
Imports System.IO
Public Class Level

    Const START = "S"
    Const FINISH = "E"
    Const IGNORE = "O"
    Const PATH = "X"

    'Private Sub FindPath(ByRef pos As Integer, 

    Public Sub DecodeLevelFile(ByVal fileName As String)
        Dim sr As StreamReader
        sr = File.OpenText("../../../levels/test.txt") ' From the debug .exe, change this when folder structure is made. Also catch errors

        Dim s, line As String
        s = ""
        Dim width As Integer

        line = sr.ReadLine()
        width = line.Length()

        While line <> Nothing
            s &= line
            line = sr.ReadLine()
        End While

        line = Nothing
        sr = Nothing    ' Opening up some memory

        Dim pos As Integer
        pos = s.IndexOf(START)





    End Sub
End Class
