'Kristof
'Deze klasse behoudt de speler zijn informatie
Public Class Players
    Private mName As String
    Private mColor As Color
    Private mComput As Boolean
    Private mHasFinished As Boolean
    Private mLastRoll As Integer
    Private mSkipTurn As Boolean
    Private mInJail As Boolean
    Private mPosition As Integer

    Public Sub New(ByVal name As String, ByVal color As Color, ByVal Comput As Boolean, ByVal HasFinished As Boolean, ByVal LastRoll As Integer, ByVal SkipTurn As Boolean, ByVal InJail As Boolean)
        mName = name
        mColor = color
        mComput = Comput
        mHasFinished = HasFinished
        mLastRoll = LastRoll
        mSkipTurn = SkipTurn
        mInJail = InJail
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
    Public Property HasFinished() As Boolean
        Get
            Return Me.mHasFinished
        End Get
        Set(ByVal value As Boolean)
            Me.mHasFinished = value
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
    Public Overridable Sub Move(ByVal LastRoll As Integer)
        mLastRoll = LastRoll
    End Sub
End Class

