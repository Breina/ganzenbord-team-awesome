'Brecht
'Gemaakt op: 12/05/2011 om 13.31u + aangepast op 13/05/2011 om 7.45u
'Wanneer men op het plaatje herberg komt.

Public Class TileInn
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
        player.SkipTurn = True
        Return "Zatlap " & player.Name & " is ene drinke."
    End Function

End Class
