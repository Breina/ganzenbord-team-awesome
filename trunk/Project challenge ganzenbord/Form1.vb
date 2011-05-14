' Brecht en Joeri
Public Class Form1

    Private lvlLength As Integer                ' Length of the level
    Private logColor As List(Of Color)          ' Tracks the colours for log messages
    Private lvlWidth, lvlHeight As Integer      ' Dimentions of the board
    Private lvl As Level                        ' The level
    Private lvlTilePics As List(Of PictureBox)  ' Pictureboxes for each tile

    Private Sub RenderLevel(ByVal name As String)
        lvl = New Level(name, lvlWidth, lvlHeight, lvlLength)

        Dim size As Integer
        size = Convert.ToInt32(Math.Min(Board.Width / lvlWidth, Board.Height / lvlHeight))

        lvlTilePics = New List(Of PictureBox)
        For i As Integer = 0 To lvlLength
            lvlTilePics.Add(New PictureBox())
            lvlTilePics.Item(i).Left = Board.Left + size * lvl.TileIndex(i).X
            lvlTilePics.Item(i).Top = Board.Top + size * lvl.TileIndex(i).Y
            lvlTilePics.Item(i).Width = size
            lvlTilePics.Item(i).Height = size
            lvlTilePics.Item(i).ImageLocation = "C:\Users\CX\Desktop\Project challenge ganzenbord\Project challenge ganzenbord\bin\Debug\images/tile.png"

            'Kristof kijk ns hier joh, wrm kome die ni op me scherm? ;(

            'MessageBox.Show("Coordinates: (" & Convert.ToString(lvlTilePics.Item(i).Left) & "," & Convert.ToString(lvlTilePics.Item(i).Top) & ")")
        Next

        For x As Integer = 0 To lvlWidth
            For y As Integer = 0 To lvlHeight

            Next
        Next

    End Sub

    Private Sub NewGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewGameToolStripMenuItem.Click
        NewGame.Show()
        Me.Hide()       ' Make NewGame have priority over Me, so you can't do anything in Me while NewGame is open, then remove this line
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TestToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestToolStripMenuItem1.Click
        RenderLevel("spiral.txt")

        'lvl.TileIndex(0)   ' Start vakske
        'lvl.TileIndex(1)   ' 1e vakske
        'lvl.TileIndex(length - 1)  ' Finish

        'lvl.TileIndex(2).Go(player1)    ' Na iedere move moet deze aangeroepen worden
        'lvl.TileIndex(2).X
        'lvl.TileIndex(2).Y
        'lvl.TileIndex(2).IsSpecialType
    End Sub

    Private Sub AddToChatLog(ByVal msg As String, ByVal col As Color)
        logColor.Add(col)
        LstChatLog.Items.Add(msg)
        LstChatLog.SelectedIndex = LstChatLog.Items.Count - 1       ' Autoscroll
    End Sub

    Private Sub BtnDice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDice.Click
        Dim dobbel1, dobbel2 As Dice
        Dim player1, player2 As Players
        'om te testen of het werkt 
        player1 = New Players("Joeri", Color.Beige, False, False, 0, False, False)
        player2 = New Players("Joske", Color.LightPink, False, False, 0, False, False)

        dobbel1 = New Dice
        dobbel2 = New Dice

        dobbel1.Roll(PctDice1)
        dobbel2.Roll(PctDice2)

        lbl1.Text = CStr(dobbel1.DiceValue)
        lbl2.Text = CStr(dobbel2.DiceValue)
        AddToChatLog(player1.Naam & " heeft " & (dobbel1.DiceValue + dobbel2.DiceValue).ToString & " gegooid", player1.Kleur)
        AddToChatLog(player2.Naam & " zijne toer!", player2.Kleur)

    End Sub

    ' Overwites the system's drawing function, this draws using chatLogBrush
    Private Sub LstChatLog_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles LstChatLog.DrawItem
        'http://msdn.microsoft.com/en-us/library/system.windows.forms.listbox.drawmode%28v=vs.71%29.aspx

        Dim colorBrush As Brush
        colorBrush = New SolidBrush(logColor.Item(e.Index))

        e.Graphics.FillRectangle(colorBrush, New RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height))
        e.Graphics.DrawString(LstChatLog.Items(e.Index).ToString, e.Font, Brushes.Black, New RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height))
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        logColor = New List(Of Color)
        logColor.Add(Color.LightGray)
    End Sub
End Class
