'Brecht
'Gemaakt op: 12/05/2011 om 14.02u + aangepast op 13/05/2011 om 7.51u
'Wanneer men op het plaatje gevanenis komt komt.
Public Class TileJail
    Inherits Tile

    Public Sub New(ByVal x As Integer, ByVal y As Integer)
        MyBase.New(x, y, OrientationEnum.jail)
    End Sub

    Public Overrides Function IsSpecialType() As Boolean
        Return True
    End Function

    Public Overrides Function Go(ByRef player As Players) As String
        If Not MyBase.Occupied Is Nothing Then
            MyBase.Occupied.InJail = False
        End If
        player.InJail = True
        Return player.Name & " kwam zichzelf aangeven in de gevangenis."
    End Function

End Class
