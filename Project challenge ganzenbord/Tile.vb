'Brecht
Public Class Tile
    Protected _x, _y As Integer  'x en y zijn cordinaten om te tekenen, id is hoe ver het zich bevind in het veld, 0 is de start

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

    Public Sub New(ByVal x As Integer, ByVal y As Integer)
        _x = x
        _y = y
    End Sub

    Public Sub New()

    End Sub

    Public Overridable Function Type() As TypesEnum
        Return TypesEnum.blank
    End Function

    Public Overridable Sub Go(ByRef player As Players)

    End Sub

End Class

Public Enum TypesEnum
    blank   'Normal tile
    jail    'Stuck until another player get's jailed
    maze    'Go back x tiles
    goose   'Go x tiles forward
    inn     'Skip 1 turn
    death   'Start over
    start   'Start here
    finish  'End here
End Enum