' Brecht en Joeri
Public Class Form1

    Private length As Integer
    Private chatLogBrush As Brush = New SolidBrush(Color.White)   ' Kweet ni hoe het anders moet :$

    Private Sub NewGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewGameToolStripMenuItem.Click
        NewGame.Show()
        Me.Hide()       ' Make NewGame have priority over Me, so you can't do anything in Me while NewGame is open, then remove this line
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TestToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestToolStripMenuItem1.Click
        Dim lvl As Level
        lvl = New Level("spiral.txt")
        length = lvl.LevelLength

        'lvl.TileIndex(0)   ' Start vakske
        'lvl.TileIndex(1)   ' 1e vakske
        'lvl.TileIndex(length - 1)  ' Finish

        'lvl.TileIndex(2).Go(player1)    ' Na iedere move moet deze aangeroepen worden
        'lvl.TileIndex(2).X
        'lvl.TileIndex(2).Y
        'lvl.TileIndex(2).Type

        'blank()   'Normal tile
        'jail()    'Stuck until another player get's jailed
        'maze()    'Go back x tiles
        'goose()   'Go x tiles forward
        'inn()     'Skip 1 turn
        'death()   'Start over
        'start()   'Start here
        'finish()  'End here
    End Sub

    Private Sub AddToChatLog(ByVal msg As String, ByVal col As Color)
        chatLogBrush = New SolidBrush(col)
        LstChatLog.Items.Add(msg)
    End Sub

    Private Sub BtnDice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDice.Click
        Dim dobbel1, dobbel2 As Dice
        Dim player1, player2 As Players
        'om te testen of het werkt 
        player1 = New Players("Joeri", Color.Beige, False, False, 0, False, False)
        player2 = New Players("Joke", Color.LightPink, False, False, 0, False, False)

        dobbel1 = New Dice
        dobbel2 = New Dice

        dobbel1.Roll(PctDice1)
        dobbel2.Roll(PctDice2)

        lbl1.Text = CStr(dobbel1.DiceValue)
        lbl2.Text = CStr(dobbel2.DiceValue)
        AddToChatLog(player1.Naam & " heeft " & (dobbel1.DiceValue + dobbel2.DiceValue).ToString & " gegooid", player1.Kleur)
        'AddToChatLog(player2.Naam & " zijne toer!", player2.Kleur)

    End Sub

    ' Overwites the system's drawing function, this draws using chatLogBrush
    Private Sub LstChatLog_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles LstChatLog.DrawItem
        'http://msdn.microsoft.com/en-us/library/system.windows.forms.listbox.drawmode%28v=vs.71%29.aspx

        'e.DrawBackground()

        e.Graphics.FillRectangle(chatLogBrush, New RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height))
        e.Graphics.DrawString(LstChatLog.Items(e.Index).ToString, e.Font, Brushes.Black, New RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height))

        'e.DrawFocusRectangle()
    End Sub
End Class
