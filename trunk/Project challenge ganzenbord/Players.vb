Public Class Players
    Private mNaam As String
    Private mKleur As Color
    Private mComput As Boolean
    Public Sub New(ByVal Naam As String, ByVal Kleur As Color, ByVal Comput As Boolean)
        mNaam = Naam
        mKleur = Kleur
        mComput = Comput
    End Sub
    Public Property Naam() As String
        Get
            Return Me.mNaam
        End Get
        Set(ByVal value As String)
            Me.mNaam = value
        End Set
    End Property
    Public Property Kleur() As Color
        Get
            Return Me.mKleur
        End Get
        Set(ByVal value As Color)
            Me.mKleur = value
        End Set
    End Property
    Public Property Comput() As Boolean
        Get
            Return Me.mComput
        End Get
        Set(ByVal value As Boolean)
            Me.mComput = value
        End Set
    End Property
End Class

