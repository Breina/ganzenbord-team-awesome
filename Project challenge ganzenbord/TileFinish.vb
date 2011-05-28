'Brecht
'Gemaakt op: 12/05/2011 om 11.45u + aangepast op 13/05/2011 om 7.32u
'Wanneer men op het plaatje finish komt.
Public Class TileFinish
    Inherits Tile

    Public Sub New(ByVal x As Integer, ByVal y As Integer)
        MyBase.New(x, y, OrientationEnum.finish)
    End Sub

    Public Overrides Function IsSpecialType() As Boolean
        Return True
    End Function

    Public Overrides Function Go(ByRef player As Players) As String
        Return player.Name & " heeft gewonnen! Proficiat!"
    End Function

End Class
