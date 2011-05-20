'Brecht
Public Class TileMaze
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
        player.Position -= player.LastRoll
        Return "Het doolhof was te moeilijk voor " & player.Name & "."
    End Function

End Class
