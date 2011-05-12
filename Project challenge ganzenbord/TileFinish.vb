'Brecht
Public Class TileFinish
    Inherits Tile

    Public Sub New(ByVal x As Integer, ByVal y As Integer)
        MyBase.New(x, y)
    End Sub

    Public Overrides Function Type() As TypesEnum
        Return TypesEnum.finish
    End Function

    Public Overrides Sub Go(ByRef player As Players)
        player.HasFinished = True
    End Sub

End Class
