' Brecht en Joeri
Public Class Form1

    Private lvlLength As Integer                ' Length of the level
    Private logColor As List(Of Color)          ' Tracks the colours for log messages
    Private lvlWidth, lvlHeight As Integer      ' Dimentions of the board
    Private lvl As Level                        ' The level
    Private lvlTilePics As List(Of PictureBox)  ' Pictureboxes for each tile
    Private turn As Integer = 0
      
    Private Sub RenderLevel(ByVal name As String)
        lvl = New Level(name, lvlWidth, lvlHeight, lvlLength)

        Dim size As Integer
        size = Convert.ToInt32(Math.Min(Board.Width / lvlWidth, Board.Height / lvlHeight))

        lvlTilePics = New List(Of PictureBox)

        For i As Integer = 0 To lvlLength
            lvlTilePics.Add(New PictureBox())

            With lvlTilePics.Item(i)
                .Location = New Point(Board.Left + size * lvl.TileIndex(i).X, Board.Top + size * lvl.TileIndex(i).Y)
                .Size = New Size(size, size)
                .Name = "PicBoxTile" & Convert.ToString(i)
                .ImageLocation = "images\tiles\" & lvl.TileIndex(i).Orientation & ".png"
                .SizeMode = PictureBoxSizeMode.StretchImage
            End With

            Board.Controls.Add(lvlTilePics.Item(i))
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
        RenderLevel(SpiraltxtToolStripMenuItem.Text)

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
        'om te testen of het werkt 
        dobbel1 = New Dice
        dobbel2 = New Dice

        dobbel1.Roll(PctDice1)
        dobbel2.Roll(PctDice2)

        lbl1.Text = CStr(dobbel1.DiceValue)
        lbl2.Text = CStr(dobbel2.DiceValue)
        AddToChatLog(player(turn).Naam & " heeft " & (dobbel1.DiceValue + dobbel2.DiceValue).ToString & " gegooid", player(turn).Kleur)
        player(turn).Position = player(turn).Position + (dobbel1.DiceValue + dobbel2.DiceValue)
        If turn >= player.Count - 1 Then
            AddToChatLog(player(0).Naam & " zijn beurt!", player(0).Kleur)
        Else
            AddToChatLog(player(turn + 1).Naam & " zijn beurt!", player(turn + 1).Kleur)
        End If
        turn += 1
        If turn > player.Count - 1 Then
            turn = 0
        End If

        lstplayers.Items.Clear()
        For i As Integer = 0 To player.Count - 1
            lstplayers.Items.Add(player(i).Naam & " staat op posistie " & player(i).Position)
        Next

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
        For i As Integer = 0 To player.Count
            lstplayers.Items.Add(player(i).Naam & " staat op posistie " & player(i).Position)
        Next

    End Sub

End Class
