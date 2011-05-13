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



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
