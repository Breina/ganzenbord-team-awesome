'Brecht
'Gemaakt op: 12/05/2011 om 13.12u + aangepast op 13/05/2011 om 7.35u
'Wanneer men op het plaatje gansje komt.
Public Class TileGoose
    Inherits Tile

    Public Sub New(ByVal x As Integer, ByVal y As Integer)
        MyBase.New(x, y, OrientationEnum.goose)
    End Sub

    Public Overrides Function IsSpecialType() As Boolean
        Return True
    End Function

    Public Overrides Function Go(ByRef player As Players) As String
        player.Position += player.LastRoll
        Return "Een gans gaf " & player.Name & " een steek in de rug."
    End Function

End Class
