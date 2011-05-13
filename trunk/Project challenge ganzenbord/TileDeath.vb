'Brecht
Public Class TileDeath
    Inherits Tile

    Public Sub New(ByVal x As Integer, ByVal y As Integer)
        MyBase.New(x, y)
    End Sub

    Public Sub New()
        MyBase.New()
    End Sub

    Public Overrides Function Type() As TypesEnum
        Return TypesEnum.death
    End Function

    Public Overrides Sub Go(ByRef player As Players)
        player.Move(-player.Position)
    End Sub

End Class