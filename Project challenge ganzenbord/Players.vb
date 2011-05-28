'Kristof
'Gemaakt op: 12/05/2011 om 14.26u
'Deze klasse behoudt de speler zijn informatie
Public Class Players
    Private mName As String
    Private mColor As Color
    Private mComput As Boolean
    Private mLastRoll As Integer = 0
    Private mSkipTurn As Boolean = False
    Private mInJail As Boolean = False
    Private mPosition As Integer = 0
    Private Shared finishOrder As Integer = 0

    Public Sub New(ByVal name As String, ByVal color As Color, ByVal Comput As Boolean)
        mName = name
        mColor = color
        mComput = Comput
    End Sub

    Public Property Name() As String
        Get
            Return Me.mName
        End Get
        Set(ByVal value As String)
            Me.mName = value
        End Set
    End Property

    Public Property Color() As Color
        Get
            Return Me.mColor
        End Get
        Set(ByVal value As Color)
            Me.mColor = value
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

    Public Property LastRoll() As Integer
        Get
            Return Me.mLastRoll
        End Get
        Set(ByVal value As Integer)
            Me.mLastRoll = value
        End Set
    End Property

    Public Property SkipTurn() As Boolean
        Get
            Return Me.mSkipTurn
        End Get
        Set(ByVal value As Boolean)
            Me.mSkipTurn = value
        End Set
    End Property

    Public Property InJail() As Boolean
        Get
            Return Me.mInJail
        End Get
        Set(ByVal value As Boolean)
            Me.mInJail = value
        End Set
    End Property

    Public Property Position() As Integer
        Get
            Return Me.mPosition
        End Get
        Set(ByVal value As Integer)
            Me.mPosition = value
        End Set
    End Property


End Class

