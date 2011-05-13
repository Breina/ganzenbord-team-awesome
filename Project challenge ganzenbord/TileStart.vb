'Brecht
Public Class TileStart
    Inherits Tile

    Public Sub New(ByVal x As Integer, ByVal y As Integer)
        MyBase.New(x, y)
    End Sub

    Public Sub New()
        MyBase.New()
    End Sub

    Public Overrides Function Type() As TypesEnum
        Return TypesEnum.start
    End Function

    Public Overrides Sub Go(ByRef player As Players)
        'Unless there are fewer than 12 tiles, this Sub shouldn't be called
    End Sub

End Class
