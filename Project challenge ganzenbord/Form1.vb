Public Class Form1

    Private Sub NewGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewGameToolStripMenuItem.Click
        NewGame.Show()
        Me.Hide()

    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TestToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestToolStripMenuItem1.Click
        Dim testLevel As Level = New Level
        testLevel.DecodeLevelFile("nah")
    End Sub
End Class
