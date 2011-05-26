'Brecht
'Gemaakt op: 12/05/2011 om 14.32u + aangepast op 13/05/2011 om 7.54u
'Wanneer men op het plaatje doolhof komt.
Public Class TileMaze
    Inherits Tile

    Public Sub New(ByVal x As Integer, ByVal y As Integer)
        MyBase.New(x, y, OrientationEnum.maze)
    End Sub

    Public Overrides Function IsSpecialType() As Boolean
        Return True
    End Function

    Public Overrides Function Go(ByRef player As Players) As String
        player.Position -= player.LastRoll
        Return "Het doolhof was te moeilijk voor " & player.Name & "."
    End Function

End Class
