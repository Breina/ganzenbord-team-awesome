'Brecht
'Gemaakt op: 12/05/2011 om 11.32u
'Wanneer men op het plaatje dood komt.
Public Class TileDeath
    Inherits Tile

    Public Sub New(ByVal x As Integer, ByVal y As Integer)
        MyBase.New(x, y, OrientationEnum.death)
    End Sub

    Public Overrides Function IsSpecialType() As Boolean
        Return True
    End Function

    Public Overrides Function Go(ByRef player As Players) As String
        player.Position = 0
        Return player.Name & " mag terug opnieuw beginnen, proficiat!"
    End Function

End Class