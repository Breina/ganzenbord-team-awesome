Public Class Dice
    Const ONE = "oog1c.gif"
    Const TWO = "oog2c.gif"
    Const THREE = "oog3c.gif"
    Const FOUR = "oog4c.gif"
    Const FIVE = "oog5c.gif"
    Const SIX = "oog6c.gif"

    Private value As Integer
    Private nums As List(Of String)
    Private random As Random
    Private Shared seedRand As Random = New Random()

    Public Sub Roll(ByRef pic As PictureBox)
        value = random.Next(6)
        pic.ImageLocation = "images/dice/" & nums.Item(value)
        value += 1
    End Sub

    Public ReadOnly Property DiceValue() As Integer
        Get
            Return value
        End Get
    End Property

    Public Sub New()
        nums = New List(Of String)
        nums.Add(ONE)
        nums.Add(TWO)
        nums.Add(THREE)
        nums.Add(FOUR)
        nums.Add(FIVE)
        nums.Add(SIX)

        random = New Random(seedRand.Next)
    End Sub
End Class
