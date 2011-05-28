'Brecht
'Gemaakt op: 12/05/2011 om 10.54u
'
Public Class Tile
    Protected _x, _y As Integer         'x en y zijn cordinaten om te tekenen, id is hoe ver het zich bevind in het veld, 0 is de start
    Protected _or As OrientationEnum    ' Tracks the orientation; straight or corner
    Private _occupied As String         ' The player who is on the tile

    Public ReadOnly Property X() As Integer
        Get
            Return _x
        End Get
    End Property

    Public ReadOnly Property Y() As Integer
        Get
            Return _y
        End Get
    End Property

    Public Property Occupied() As String
        Get
            Return _occupied
        End Get

        Set(ByVal player As String)
            _occupied = player
        End Set
    End Property

    'Brecht
    'Gemaakt op: 16/05/2011 om 14.54u
    'Oriëntatie van de vakjes

    Public ReadOnly Property Orientation() As String
        Get
            Select Case _or
                Case OrientationEnum.ur
                    Return "ur"
                Case OrientationEnum.ud
                    Return "ud"
                Case OrientationEnum.ul
                    Return "ul"
                Case OrientationEnum.dr
                    Return "dr"
                Case OrientationEnum.dl
                    Return "dl"
                Case OrientationEnum.lr
                    Return "lr"
                Case OrientationEnum.start
                    Return "start"
                Case OrientationEnum.finish
                    Return "finish"
                Case OrientationEnum.death
                    Return "death"
                Case OrientationEnum.inn
                    Return "inn"
                Case OrientationEnum.maze
                    Return "maze"
                Case OrientationEnum.goose
                    Return "goose"
                Case OrientationEnum.jail
                    Return "jail"
                Case Else
                    Return "error"
            End Select
        End Get
    End Property

    Public Sub New(ByVal x As Integer, ByVal y As Integer, ByVal orientation As OrientationEnum)
        _x = x
        _y = y
        _or = orientation
        _occupied = Nothing
    End Sub

    Public Overridable Function IsSpecialType() As Boolean
        Return False
    End Function

    Public Overridable Function Go(ByRef player As Players) As String
        Return "ERROR: De functie voor een normaal vakje werd aangeroepen"  ' Throw een exception hier
    End Function

End Class

Public Enum OrientationEnum
    ur      ' up right
    ud      ' up down
    ul      ' up left
    dr      ' down right
    dl      ' down left
    lr      ' left right 
    start
    finish
    inn
    jail
    maze
    goose
    death
End Enum