Public Class Form1
    Private length As Integer

    Private Sub NewGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewGameToolStripMenuItem.Click
        NewGame.Show()
        Me.Hide()

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

    Private Sub BtnDice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDice.Click
        Dim dobbel As Dice
        Dim player1 As Players
        'om te testen of het werkt 
        player1 = New Players("joeri", Color.Beige, False, False, 0, False, False)

        dobbel = New Dice
        'dobbel.Roll1(PctDice1)
        'dobbel.Roll2(PctDice2)
        lbl1.Text = CStr(dobbel.DiceValue1)
        lbl2.Text = CStr(dobbel.DiceValue2)
        LstChatLog.Items.Add(player1.Naam & " heeft " & (dobbel.DiceValue1 + dobbel.DiceValue2).ToString & " gegooid")
        LstChatLog.BackColor = player1.Kleur

    End Sub
End Class
