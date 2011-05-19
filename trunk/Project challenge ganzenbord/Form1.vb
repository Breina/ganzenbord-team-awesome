' Brecht en Joeri en Kristof
Imports VB = Microsoft.VisualBasic
Imports System.Runtime.InteropServices
Imports System.IO

Public Class Form1

    Private lvlLength As Integer                ' Length of the level
    Private logColor As List(Of Color)          ' Tracks the colours for log messages
    Private lvlWidth, lvlHeight As Integer      ' Dimentions of the board
    Private lvl As Level                        ' The level
    Private lvlTilePics As List(Of PictureBox)  ' Pictureboxes for each tile
    Private playerPics As List(Of PictureBox)   ' Pictureboxes for each player
    Private turn As Integer = 0                 ' Keeping track whose turn it is
    Private dobbel1, dobbel2 As Dice            ' The 2 dice
    Private playerTurn As List(Of String)       ' For keeping track of the turn list
    Private diceRolling As Boolean              ' Indicates wether the dice is rolling
    Private tileSize As Integer                 ' The length of the size of each tile
    Private curPlayerPos As Integer             ' Used for tracking where the player is while moving


    ' Brecht
    Private Sub GetTileCords(ByVal pos As Integer, ByRef x As Integer, ByRef y As Integer)
        x = Board.Left + tileSize * lvl.TileIndex(pos).X
        y = Board.Top + tileSize * lvl.TileIndex(pos).Y
    End Sub

    ' Brecht
    Private Sub RenderLevel(ByVal name As String)
        lvlTilePics = New List(Of PictureBox)

        For i As Integer = 0 To lvlLength
            lvlTilePics.Add(New PictureBox())

            With lvlTilePics.Item(i)
                GetTileCords(i, .Left, .Top)
                .Size = New Size(tileSize, tileSize)
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
    ' Brecht
    Private Sub AddToChatLog(ByVal msg As String, ByVal col As Color)
        logColor.Add(col)
        LstChatLog.Items.Add(msg)
        'LstChatLog.SelectionMode() = SelectionMode.One             ' Zoek ne ander manier voor autoscroll
        LstChatLog.SelectedIndex = LstChatLog.Items.Count - 1       ' Autoscroll
    End Sub

    Private Sub BtnDice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDice.Click
        BtnDice.Enabled = False
        diceRolling = True
        TimerDiceDuration.Start()
        TimerDiceTick.Start()
    End Sub

    'Brecht
    Private Sub FindNextPlayer(ByRef t As Integer)
        Dim found As Boolean
        Do
            found = True
            t += 1
            If t >= player.Count Then t = 0

            With player(turn)
                If .InJail Then found = False
                If .SkipTurn Then
                    found = False
                    .SkipTurn = False
                End If
            End With
        Loop Until found
    End Sub

    'Brecht
    Private Sub UpdateNextPlayerList()
        Dim t As Integer = turn
        Dim j As Integer = 0

        For i As Integer = 1 To player.Count
            playerTurn(t) = Convert.ToString(j)
            FindNextPlayer(t)
            j += 1
        Next

        LstPlayers.Refresh()
    End Sub

    ' Brecht
    ' Overwites the system's drawing function for the chatlog, uses logColor
    Private Sub LstChatLog_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles LstChatLog.DrawItem
        'http://msdn.microsoft.com/en-us/library/system.windows.forms.listbox.drawmode%28v=vs.71%29.aspx

        Dim colorBrush As Brush
        colorBrush = New SolidBrush(logColor.Item(e.Index))

        e.Graphics.FillRectangle(colorBrush, New RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height))
        e.Graphics.DrawString(LstChatLog.Items(e.Index).ToString, e.Font, Brushes.Black, New RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height))
    End Sub

    ' Brecht
    ' Draws the player list in the same way
    Private Sub LstPlayersTest_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles LstPlayers.DrawItem
        'http://msdn.microsoft.com/en-us/library/system.windows.forms.listbox.drawmode%28v=vs.71%29.aspx

        Dim colorBrush As Brush
        colorBrush = New SolidBrush(player(e.Index).Color)

        Dim font As Font
        font = New Font("Times New Roman", 12)  ' Verander de font hier maar as ge wilt

        Dim img As Image
        Dim s As String
        s = "images/playerlist/"

        If player(e.Index).InJail Then
            s += "jail"
        ElseIf player(e.Index).SkipTurn Then
            s += "inn"
        Else
            s += playerTurn(e.Index)
        End If
        s += ".png"

        img = Image.FromFile(s)
        s = Nothing

        e.Graphics.FillRectangle(colorBrush, New RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height))
        e.Graphics.DrawString(player(e.Index).Name, font, Brushes.Black, New RectangleF(e.Bounds.X + 24, e.Bounds.Y + 2, e.Bounds.Width, e.Bounds.Height))

        e.Graphics.DrawString(Convert.ToString(player(e.Index).Position), font, Brushes.Black, New RectangleF(e.Bounds.Width - 30, e.Bounds.Y + 2, e.Bounds.Width, e.Bounds.Height))
        e.Graphics.DrawImage(img, New Point(e.Bounds.X + 1, e.Bounds.Y + 1))
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        NewGame.Close()
        About.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Update()
        logColor = New List(Of Color)
        logColor.Add(Color.LightGray)

        lvl = New Level(NewGame.lvl, lvlWidth, lvlHeight, lvlLength)
        tileSize = Convert.ToInt32(Math.Min(Board.Width / lvlWidth, Board.Height / lvlHeight))
        RenderLevel(NewGame.lvl)
        dobbel1 = New Dice
        dobbel2 = New Dice
        playerTurn = New List(Of String)

        For i As Integer = 0 To player.Count - 1
            LstPlayers.Items.Add(player(i).Name)
            playerTurn.Add(Convert.ToString(i))
        Next

        turn = 0
        UpdateNextPlayerList()
    End Sub

    Private Sub RedrawLevel()
        tileSize = Convert.ToInt32(Math.Min(Board.Width / lvlWidth, Board.Height / lvlHeight))
        For i As Integer = 0 To lvlTilePics.Count - 1
            lvlTilePics(i).Dispose()
        Next
        RenderLevel(NewGame.lvl)
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        For i = 0 To player.Count - 1
            With playerPics(i)
                .Size = New Size(tileSize, tileSize)
                GetTileCords(player(i).Position, .Left, .Top)
            End With
        Next
    End Sub

    Private Sub Form1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ResizeEnd
        RedrawLevel()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub ProcessTurn()
        With player(turn)
            curPlayerPos = .Position
            Dim sum As Integer
            sum = dobbel1.DiceValue + dobbel2.DiceValue
            AddToChatLog(.Name & " heeft " & sum.ToString & " gegooid", .Color)
            .Position = .Position + sum
        End With

        PlayerMoveTick.Start()
    End Sub

    Private Sub NextPlayer()
        FindNextPlayer(turn)
        UpdateNextPlayerList()

        With player(turn)
            AddToChatLog(.Name & " zijn/haar beurt!", .Color)

            If .Comput = True Then
                BtnDice.Enabled = False
                diceRolling = True
                TimerDiceDuration.Start()
                TimerDiceTick.Start()
            Else
                BtnDice.Enabled = True
            End If
        End With
    End Sub

    Private Sub PlayerMoveTick_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayerMoveTick.Tick
        If player(turn).Position > curPlayerPos Then
            curPlayerPos += 1
        ElseIf player(turn).Position < curPlayerPos Then
            curPlayerPos -= 1
        Else
            NextPlayer()
            PlayerMoveTick.Stop()
        End If

        With playerPics(turn)
            GetTileCords(curPlayerPos, .Left, .Top)
            .BringToFront()
        End With
    End Sub

    Private Sub TimerDiceTick_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerDiceTick.Tick
        dobbel1.Roll(PctDice1)
        dobbel2.Roll(PctDice2)
    End Sub

    Private Sub TimerDiceDuration_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerDiceDuration.Tick
        TimerDiceTick.Stop()
        TimerDiceDuration.Stop()
        ProcessTurn()
    End Sub

    Private Sub FullscreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullscreenToolStripMenuItem.Click
        With FullscreenToolStripMenuItem
            If .Checked Then
                .Checked = False

                Me.WindowState = FormWindowState.Normal
                Me.FormBorderStyle = FormBorderStyle.Sizable
                Me.TopMost = False
                RedrawLevel()
            Else
                .Checked = True

                Me.WindowState = FormWindowState.Maximized
                Me.FormBorderStyle = FormBorderStyle.None
                Me.TopMost = True
                RedrawLevel()
            End If
        End With
    End Sub

    Private Sub BtnReady_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReady.Click
        BtnReady.Visible = False
        BtnDice.Visible = True
        Players.Visible = True
        DragAndDropBox.Hide()
        playerPics = New List(Of PictureBox)
       
        For i = 0 To player.Count - 1
            playerPics.Add(New PictureBox())
            With playerPics(i)
                .Size = New Size(tileSize, tileSize)
                .BackColor = player(i).Color
                GetTileCords(0, .Left, .Top)
            End With
            Board.Controls.Add(playerPics(i))
        Next
    End Sub

End Class
