﻿'Brecht
'Gemaakt op: 12/05/2011 om 17.12u + 13/05/2011 om 14.08u ( breedte en hoogte )
'levels.
Imports System.IO
Imports System.Text

Public Class Level

    Const START = "S"
    Const FINISH = "E"
    Const PATH = "X"
    Const IGNORE = "O"


    Private level As List(Of Tile)  ' Tile objects for level

    ' Adds a tile to level
    Private Sub AddTile(ByVal pos As Integer, ByVal width As Integer, ByVal orientation As OrientationEnum)
        Dim x, y As Integer
        x = pos Mod width
        y = pos \ width

        level.Add(New Tile(x, y, orientation))
    End Sub

    ' Reads the file and generates Tile objects accordingly
    Public Sub New(ByVal fileName As String, ByRef width As Integer, ByRef height As Integer, ByRef length As Integer)

        Try
            Dim sr As StreamReader
            sr = File.OpenText("levels/" & fileName) ' From the debug .exe, change this when folder structure is made. Also catch errors


            Dim sb As StringBuilder = New StringBuilder()
            Dim line As String

            line = sr.ReadLine()
            width = line.Length()
            height = 0

            While line <> Nothing
                height += 1
                sb.Append(line)
                line = sr.ReadLine()
            End While

            line = Nothing
            sr.Close()
            Dim s As String = Convert.ToString(sb)
            sb = Nothing

            Dim pos As Integer
            pos = s.IndexOf(START)

            level = New List(Of Tile)
            level.Add(New TileStart(pos Mod width, pos \ width)) ' Finish tile

            Dim directions As List(Of Integer)
            directions = New List(Of Integer)

            With directions
                .Add(-1)      'Left   0
                .Add(-width)  'Up     1
                .Add(1)       'Right  2
                .Add(width)   'Down   3
                .Add(-1)      'Left   4
                .Add(-width)  'Up     5
            End With

            Const FP = FINISH & PATH
            Dim lastDirection As Integer

            ' Finds the first direction from start
            For i As Integer = 1 To 4
                If FP.Contains(s.ElementAt(pos + directions.Item(i))) Then
                    lastDirection = i
                    i = 4
                End If
            Next
            pos += directions.Item(lastDirection)

            Dim c As Char
            Dim orientation As OrientationEnum

            ' Finds the rest of the path
            Do Until c = FINISH
                c = s.ElementAt(pos + directions.Item(lastDirection))
                If FP.Contains(c) Then                                          ' Check for valid path straight ahead

                    Select Case lastDirection
                        Case 1, 3
                            orientation = OrientationEnum.ud
                        Case 2, 4
                            orientation = OrientationEnum.lr
                    End Select
                    AddTile(pos, width, orientation)

                    pos += directions.Item(lastDirection)
                Else
                    lastDirection += 1
                    c = s.ElementAt(pos + directions.Item(lastDirection))
                    If FP.Contains(c) Then                                      ' Check for valid path turned right

                        Select Case lastDirection
                            Case 2
                                orientation = OrientationEnum.dr
                            Case 3
                                orientation = OrientationEnum.dl
                            Case 4
                                orientation = OrientationEnum.ul
                            Case 5
                                orientation = OrientationEnum.ur
                        End Select
                        AddTile(pos, width, orientation)

                        pos += directions.Item(lastDirection)
                    Else
                        lastDirection -= 2
                        c = s.ElementAt(pos + directions.Item(lastDirection))
                        If FP.Contains(c) Then                                  ' Check for valid path turned left

                            Select Case lastDirection
                                Case 0
                                    orientation = OrientationEnum.dl
                                Case 1
                                    orientation = OrientationEnum.ul
                                Case 2
                                    orientation = OrientationEnum.ur
                                Case 3
                                    orientation = OrientationEnum.dr
                            End Select
                            AddTile(pos, width, orientation)

                            pos += directions.Item(lastDirection)
                        Else
                            Throw New PathNotFoundException("The level's path wasn't found in " & fileName)
                            Exit Do     ' KRISTOF HIER MOET GE KIJKE!!!!!@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                        End If
                    End If
                End If

                If lastDirection = 0 Then
                    lastDirection = 4
                ElseIf lastDirection = 5 Then
                    lastDirection = 1
                End If
            Loop

            length = level.Count()

            level.Add(New TileFinish(pos Mod width, pos \ width)) ' Finish tile
            Form1.BtnReady.Enabled = True
        Catch ex As PathNotFoundException

        End Try
     

    End Sub

    ' The tile at index
    Public Property TileIndex(ByVal index As Integer) As Tile
        Get
            Return level.Item(index)
        End Get

        Set(ByVal value As Tile)
            level.Item(index) = value
        End Set
    End Property
End Class
