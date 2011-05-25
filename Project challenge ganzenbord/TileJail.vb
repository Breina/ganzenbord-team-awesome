'Brecht
'Gemaakt op: 12/05/2011 om 14.02u + aangepast op 13/05/2011 om 7.51u
'Wanneer men op het plaatje gevanenis komt komt.
Public Class TileJail
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
        player.InJail = True
        Return player.Name & " kwam zichzelf aangeven in de gevangenis."
    End Function

End Class
