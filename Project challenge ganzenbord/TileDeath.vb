'Brecht
Public Class TileDeath
    Inherits Tile

    Public Sub New(ByVal x As Integer, ByVal y As Integer, ByVal id As Integer)
        MyBase.New(x, y, id)
    End Sub

    Public Overrides Function Type() As TypesEnum
        Return TypesEnum.death
    End Function

    Public Overrides Sub Go(ByRef player As Players)
        'Go to start
    End Sub

End Class