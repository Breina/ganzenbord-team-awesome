'Brecht
Public Class TileStart
    Inherits Tile

    Public Sub New(ByVal x As Integer, ByVal y As Integer, ByVal orientation As OrientationEnum)
        MyBase.New(x, y, orientation)
    End Sub

    Public Sub New()
        MyBase.New()
    End Sub

    ' The following shouldn't ever be called, unless the board is shorter than 12 tiles
    Public Overrides Function IsSpecialType() As Boolean
        Return False
    End Function

    Public Overrides Sub Go(ByRef player As Players)
    End Sub

End Class
