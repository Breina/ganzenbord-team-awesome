'Brecht
'Gemaakt op: 12/05/2011 om 13.45u + aangepast op 13/05/2011 om 8.01u
'Wanneer men op het plaatje start komt.
Public Class TileStart
    Inherits Tile

    Public Sub New(ByVal x As Integer, ByVal y As Integer)
        MyBase.New(x, y, OrientationEnum.start)
    End Sub

    ' The following shouldn't ever be called, unless the board is shorter than 12 tiles
    Public Overrides Function IsSpecialType() As Boolean
        Return False
    End Function

    Public Overrides Function Go(ByRef player As Players) As String
        Return "ERROR"  ' Throw een exception hier
    End Function

End Class
