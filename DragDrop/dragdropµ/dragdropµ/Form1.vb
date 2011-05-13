Public Class Form1

    Public Sub New()
        InitializeComponent()

        Dim img As Image = Image.FromFile("C:\Users\student\Desktop\html\proefexamenmap\Name\figuren\takkie.gif")
        Me.btnImage.Image = img
        Me.PictureBox1.AllowDrop = True
        Me.PictureBox2.AllowDrop = True
        Me.PictureBox3.AllowDrop = True

        'Dim img1 As Image = Image.FromFile("C:\Users\student\Desktop\html\proefexamenmap\Name\figuren\takkie.gif")
        'Me.BtnImage.Image = img1
        'Me.PictureBox1.AllowDrop = True
        'Me.PictureBox2.AllowDrop = True
        'Me.PictureBox3.AllowDrop = True

        Me.Label1.AllowDrop = True

        AddHandler BtnImage.MouseDown, AddressOf btnImage_MouseDown
        'AddHandler BtnImage.MouseDown, AddressOf Label2_MouseDown

        'zorgt ervoor dat je de image van de button in de pictureboxen kan slepen :)


        AddHandler PictureBox1.DragDrop, AddressOf pictureBox_DragDrop
        AddHandler PictureBox1.DragEnter, AddressOf pictureBox_DragEnter

        AddHandler PictureBox2.DragDrop, AddressOf pictureBox_DragDrop
        AddHandler PictureBox2.DragEnter, AddressOf pictureBox_DragEnter


        AddHandler PictureBox3.DragDrop, AddressOf pictureBox_DragDrop
        AddHandler PictureBox3.DragEnter, AddressOf pictureBox_DragEnter

        AddHandler Label1.DragDrop, AddressOf Label1_DragDrop
        AddHandler Label1.DragEnter, AddressOf Label1_DragEnter


    End Sub


    Private Sub btnImage_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim btnPic As Button = CType(sender, Button)
        btnPic.DoDragDrop(btnPic.Image, DragDropEffects.Copy)
    End Sub

    Private Sub pictureBox_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs)
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pictureBox_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
        Dim picbox As PictureBox = CType(sender, PictureBox)
        Dim g As Graphics = picbox.CreateGraphics()
        g.DrawImage(CType(e.Data.GetData(DataFormats.Bitmap), Image), New Point(0, 0))
    End Sub

    Private Sub Label1_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs)
        Dim lbl As Label = CType(sender, Label)
        Dim g As Graphics = lbl.CreateGraphics()
        g.DrawImage(CType(e.Data.GetData(DataFormats.Bitmap), Image), New Point(0, 0))
    End Sub

    Private Sub Label1_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs)
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    ' Private Sub Label2_MouseDown(ByVal sender As System.Object, ByVal e As MouseEventArgs)
    'Dim lblpic As Label = CType(sender, Label)
    '     lblpic.DoDragDrop(lblpic.Image, DragDropEffects.Copy)
    ' End Sub
End Class