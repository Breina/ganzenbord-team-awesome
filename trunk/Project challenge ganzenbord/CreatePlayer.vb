'Kristof
Public Class CreatePlayer
    Dim mtxt As TextBox
    Dim mlbl As Label
    Dim mbtn As Button
    Dim mcheck As CheckBox
    Public Sub New(ByVal txt As TextBox, ByVal lbl As Label, ByVal btn As Button, ByVal i As Integer, ByVal check As CheckBox)
        mtxt = txt
        mlbl = lbl
        mbtn = btn
        mcheck = check
        mbtn.SetBounds(225, 60 + 30 * i, 30, 30)
        mtxt.SetBounds(85, 60 + 30 * i, 140, 25)
        mlbl.SetBounds(5, 60 + 30 * i, 80, 30)
        mcheck.SetBounds(275, 60 + 30 * i, 80, 30)
        mlbl.Text = "Geef de naam speler " & (i + 1).ToString & "."
    End Sub
    Public Property tekst() As TextBox
        Get
            Return Me.mtxt
        End Get
        Set(ByVal value As TextBox)
            Me.mtxt = value
        End Set
    End Property
    Public Property btn() As Button
        Get
            Return Me.mbtn
        End Get
        Set(ByVal value As Button)
            Me.mbtn = value
        End Set
    End Property
    Public Property lbl() As Label
        Get
            Return Me.mlbl
        End Get
        Set(ByVal value As Label)
            Me.mlbl = value
        End Set
    End Property
    Public Property check() As CheckBox
        Get
            Return Me.mcheck
        End Get
        Set(ByVal value As CheckBox)
            Me.mcheck = value
        End Set
    End Property
End Class
