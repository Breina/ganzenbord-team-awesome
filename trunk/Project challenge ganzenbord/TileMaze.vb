'Brecht
Public Class TileMaze
    Inherits Tile

    Public Sub New(ByVal x As Integer, ByVal y As Integer)
        MyBase.New(x, y)
    End Sub

    Public Overrides Function Type() As TypesEnum
        Return TypesEnum.maze
    End Function

    Public Overrides Sub Go(ByRef player As Players)
        player.Move(-player.LastRoll)
    End Sub

End Class
