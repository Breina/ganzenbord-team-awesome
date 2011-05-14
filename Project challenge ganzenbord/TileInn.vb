﻿'Brecht
Public Class TileInn
    Inherits Tile

    Public Sub New(ByVal x As Integer, ByVal y As Integer)
        MyBase.New(x, y)
    End Sub

    Public Sub New()
        MyBase.New()
    End Sub

    Public Overrides Function Type() As TypesEnum
        Return TypesEnum.inn
    End Function

    Public Overrides Sub Go(ByRef player As Players)
        player.SkipTurn = True
    End Sub

End Class