'Brecht
Imports System.IO

Public Class Level

    Const START = "S"
    Const FINISH = "E"
    Const IGNORE = "O"
    Const PATH = "X"

    Private level As List(Of Tile)  ' Tile objects for level
    Private length As Integer       ' Length of the level

    ' Reads the file and generates Tile objects accordingly
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
        sr = Nothing

        Dim pos As Integer
        pos = s.IndexOf(START)

        level = New List(Of Tile)
        level.Add(New TileStart(pos Mod width, pos \ width))

        Dim directions As List(Of Integer)
        directions = New List(Of Integer)
        directions.Add(-1)      'Left   0
        directions.Add(-width)  'Up     1
        directions.Add(1)       'Right  2
        directions.Add(width)   'Down   3
        directions.Add(-1)      'Left   4
        directions.Add(-width)  'Up     5

        Const FP = FINISH & PATH

        Dim lastDirection As Integer

        ' Finds the first direction from start
        For i As Integer = 1 To 4
            If FP.Contains(s.ElementAt(pos + directions.Item(i))) Then
                lastDirection = i
                i = 4
            End If
        Next

        Dim c As Char

        ' Finds the rest of the path
        Do Until c = FINISH
            c = s.ElementAt(pos + directions.Item(lastDirection))
            If FP.Contains(c) Then                                          ' Check for valid path straight ahead
                pos += directions.Item(lastDirection)
                level.Add(New Tile(pos Mod width, pos \ width))
            Else
                lastDirection += 1
                c = s.ElementAt(pos + directions.Item(lastDirection))
                If FP.Contains(c) Then                                      ' Check for valid path turned right
                    pos += directions.Item(lastDirection)
                    level.Add(New Tile(pos Mod width, pos \ width))
                Else
                    lastDirection -= 2
                    c = s.ElementAt(pos + directions.Item(lastDirection))
                    If FP.Contains(c) Then                                  ' Check for valid path turned left
                        pos += directions.Item(lastDirection)
                        level.Add(New Tile(pos Mod width, pos \ width))
                    Else
                        ' Path break exception
                    End If
                End If
            End If

            If lastDirection = 0 Then
                lastDirection = 4
            ElseIf lastDirection = 5 Then
                lastDirection = 1
            End If
        Loop

        level.Item(level.Count - 1) = New TileFinish(pos Mod width, pos \ width)    ' Finish tile
    End Sub

    ' Generates tile events randomly, may be overlapping (!)
    Public Sub GenerateRandomTileEvents()
        Dim r As Random
        r = New Random()

        level.Item(r.Next * (length - 1) + 1) = New TileDeath()
        level.Item(r.Next * (length - 1) + 1) = New TileInn()
        level.Item(r.Next * (length - 1) + 1) = New TileGoose()
        level.Item(r.Next * (length - 1) + 1) = New TileJail()
        level.Item(r.Next * (length - 1) + 1) = New TileMaze()
    End Sub

    ' Returns the tile at index
    Public ReadOnly Property TileSelect(ByVal index As Integer) As Tile
        Get
            If index > length Then  ' If it's past the finish
                index -= index - length
            End If

            Return level.Item(index)
        End Get
    End Property

End Class
