'Brecht
Public Class TileFinish
    Inherits Tile

    Public Sub New(ByVal x As Integer, ByVal y As Integer, ByVal orientation As OrientationEnum)
        MyBase.New(x, y, orientation)
    End Sub

    Public Sub New()
        MyBase.New()
    End Sub

    Public Overrides Function IsSpecialType() As Boolean
        Return True
    End Function

    Public Overrides Function Go(ByRef player As Players) As String
        player.HasFinished = True
        Return player.Name & " heeft gewonnen! Proficiat!"
    End Function

End Class
