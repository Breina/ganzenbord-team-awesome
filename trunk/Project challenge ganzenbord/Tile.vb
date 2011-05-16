'Brecht
Public Class Tile
    Private _x, _y As Integer       'x en y zijn cordinaten om te tekenen, id is hoe ver het zich bevind in het veld, 0 is de start
    Private _or As OrientationEnum  ' Tracks the orientation; straight or corner

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
                Case Else
                    Return "error"
            End Select
        End Get
    End Property

    Public Sub New(ByVal x As Integer, ByVal y As Integer, ByVal orientation As OrientationEnum)
        _x = x
        _y = y
        _or = orientation
    End Sub

    Public Sub New()
    End Sub

    Public Overridable Function IsSpecialType() As Boolean
        Return False
    End Function

    Public Overridable Sub Go(ByRef player As Players)
    End Sub

End Class

Public Enum OrientationEnum
    ur      ' up right
    ud      ' up down
    ul      ' up left
    dr      ' down right
    dl      ' down left
    lr      ' left right 
    start   ' start
    finish  ' finish
End Enum