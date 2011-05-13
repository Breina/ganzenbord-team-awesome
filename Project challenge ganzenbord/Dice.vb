Public Class Dice
    Const ONE = "one.png"
    Const TWO = "two.png"
    Const THREE = "three.png"
    Const FOUR = "four.png"
    Const FIVE = "five.png"
    Const SIX = "six.png"

    Private value1, value2 As Integer
    Private nums As List(Of String)
    Private random As Random

    Public Sub Roll1(ByRef pic As PictureBox)
        value1 = random.Next * 6
        pic.ImageLocation = nums.Item(value1)
    End Sub
    Public Sub Roll2(ByRef pic As PictureBox)
        value2 = random.Next * 6
        pic.ImageLocation = nums.Item(value2)
    End Sub

    Public ReadOnly Property DiceValue1() As Integer
        Get
            Return value1
        End Get
    End Property
    Public ReadOnly Property DiceValue2() As Integer
        Get
            Return value2
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
