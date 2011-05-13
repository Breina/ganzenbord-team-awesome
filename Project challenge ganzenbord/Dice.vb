Public Class Dice
    Const ONE = "one.png"
    Const TWO = "two.png"
    Const THREE = "three.png"
    Const FOUR = "four.png"
    Const FIVE = "five.png"
    Const SIX = "six.png"

    Private value As Integer
    Private nums As List(Of String)
    Private random As Random

    Public Sub Roll(ByRef pic As PictureBox)
        value = random.Next * 6
        pic.ImageLocation = nums.Item(value)
    End Sub

    Public ReadOnly Property DiceValue() As Integer
        Get
            Return Value
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
        random = New Random()
    End Sub
End Class
