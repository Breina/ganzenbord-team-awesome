' Brecht, Joeri, Kristof en Ine
'Gemaakt op: -12/05/2011 om 18.07u (Joeri - basic form)
'            -13/05/2011 om 16.21u (Brecht)
'            -13/05/2011 om 20.10u (Joeri)
'            -14/05/2011 om 13.59u (Brecht)
'            -14/05/2011 om 20.10u (Joeri)
'            -15/05/2011 om 18.36u (Joeri)
'            -15/05/2011 om 22.52u (Brecht)
'            -17/05/2011 om 14.05u (Kristof)
'            -17/05/2011 om 17.24u (Brecht)
'            -17/05/2011 om 20.59u (Joeri)
'            -19/05/2011 om 12.59u (Brecht - Window resize)
'            -19/05/2011 om 18.53u (Joeri)
'            -19/05/2011 om 23.12u (Brecht + Joeri - Pionen)
'            -19/05/2011 om 13.41u (Ine - Drag & Drop)
'            -24/05/2011 om 11.38u (Kristof)


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
    Private dice1, dice2 As Dice                ' The 2 dice
    Private playerTurn As List(Of String)       ' For keeping track of the turn list
    Private diceRolling As Boolean              ' Indicates wether the dice is rolling
    Private tileSize As Integer                 ' The length of the size of each tile
    Private curPlayerPos As Integer             ' Used for tracking where the player is while moving
    Private lastSelectedTile As Integer         ' Used for tracking which tile was last selected for drag and drop
    Private finishTilesBack As Integer          ' Amount of tiles to go back from the finish
    Private hasGameStarted As Boolean           ' Indicates if the game has started already
    Private highestThrowValue As Integer        ' The amount the highest roller has thrown
    Private highestThrowPlayer As Integer       ' The player index if the highest roller
    Private debugMode As Boolean = False        ' If the dice should debug
    Private executedSpecial As Boolean = False  ' Ensures only 1 special tile will be activated each turn
    Private continueGame As Boolean = True      ' To stop the game after someone has finished

    ' Brecht
    Private Sub GetTileCords(ByVal pos As Integer, ByRef x As Integer, ByRef y As Integer)
        x = Board.Left + tileSize * lvl.TileIndex(pos).X
        y = Board.Top + tileSize * lvl.TileIndex(pos).Y
    End Sub

    ' Brecht
    Private Sub RenderTile(ByVal tileIndex As Integer)
        lvlTilePics.Item(tileIndex).Dispose()
        lvlTilePics.Item(tileIndex) = New PictureBox()

        With lvlTilePics.Item(tileIndex)
            GetTileCords(tileIndex, .Left, .Top)
            .Size = New Size(tileSize, tileSize)
            .Name = "p" & Convert.ToString(tileIndex)
            .ImageLocation = "images\tiles\" & lvl.TileIndex(tileIndex).Orientation & ".png"
            .SizeMode = PictureBoxSizeMode.StretchImage
            .AllowDrop() = True
            AddHandler .DragDrop, AddressOf Tile_DragDrop
            AddHandler .DragEnter, AddressOf Tile_DragEnter
        End With
        Board.Controls.Add(lvlTilePics.Item(tileIndex))
    End Sub

    ' Brecht
    Private Sub RenderLevel()
        lvlTilePics = New List(Of PictureBox)

        For i As Integer = 0 To lvlLength
            lvlTilePics.Add(New PictureBox())

            With lvlTilePics.Item(i)            ' Can't use RenderTile for this since then the Picturebox would be constructed twice
                GetTileCords(i, .Left, .Top)
                .Size = New Size(tileSize, tileSize)
                .Name = "p" & Convert.ToString(i)
                .ImageLocation = "images\tiles\" & lvl.TileIndex(i).Orientation & ".png"
                .SizeMode = PictureBoxSizeMode.StretchImage
                .AllowDrop() = True
                AddHandler .DragDrop, AddressOf Tile_DragDrop
                AddHandler .DragEnter, AddressOf Tile_DragEnter
            End With
            Board.Controls.Add(lvlTilePics.Item(i))
        Next
    End Sub

    Private Sub RedrawLevel() Handles MyBase.ResizeEnd
        tileSize = Convert.ToInt32(Math.Min(Board.Width / lvlWidth, Board.Height / lvlHeight))
        For i As Integer = 0 To lvlTilePics.Count - 1
            lvlTilePics(i).Dispose()
        Next
        RenderLevel()

        For i = 0 To player.Count - 1
            With playerPics(i)
                .Size = New Size(tileSize, tileSize)
                GetTileCords(player(i).Position, .Left, .Top)
            End With
        Next
    End Sub

    Private Sub NewGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewGameToolStripMenuItem.Click
        If Not (lvlTilePics Is Nothing) Then
            For Each pic In lvlTilePics
                pic.Dispose()
            Next
        End If

        If Not (playerPics Is Nothing) Then
            For Each pic In playerPics
                pic.Dispose()
            Next
        End If

        BtnInn.Enabled = True
        BtnGoose.Enabled = True
        BtnJail.Enabled = True
        BtnMaze.Enabled = True
        BtnDeath.Enabled = True

        player.Clear()
        LstPlayers.Items.Clear()

        NewGame.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        NewGame.ShowDialog()

        BtnReady.Visible = True
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    ' Brecht
    ' Adds a message with backgroundcolor to the chatlog
    Private Sub AddToChatLog(ByVal msg As String, ByVal col As Color)
        logColor.Add(col)
        LstChatLog.Items.Add(msg)
        LstChatLog.SelectedIndex = LstChatLog.Items.Count - 1
    End Sub

    'Joeri
    '13/05/2011 om 20.10u
    'to make the dice's roll
    Private Sub BtnDice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDice.Click
        BtnDice.Enabled = False
        diceRolling = True
        TimerDiceDuration.Start()
        TimerDiceTick.Start()
    End Sub

    ' Brecht
    ' Finds the next player with turn t, if the status of the jail and inn should be updated, updateStatus should be true
    Private Sub FindNextPlayer(ByRef t As Integer, ByVal updateStatus As Boolean)
        If (updateStatus And dice1.DiceValue = dice2.DiceValue) And hasGameStarted And Not (debugMode) Then
            AddToChatLog(player(t).Name & " heeft dubbel gegooit en mag nog eens gooien.", player(t).Color)
        Else

            Dim found As Boolean

            Do
                found = True
                t += 1
                If t >= player.Count Then t = 0

                With player(t)
                    If .InJail Then
                        found = False
                        If updateStatus Then AddToChatLog(.Name & " zit nog altijd zijn dagen af te tellen in de gevangenis.", .Color)
                    End If
                    If .SkipTurn Then
                        found = False
                        If updateStatus Then
                            .SkipTurn = False ' Shouldn't be called from UpdateNextPlayerList
                            AddToChatLog("Zatlap " & .Name & " werd buitengekegeld uit de herberg en mag volgende beurt terug meedoen.", .Color)
                        End If
                    End If
                End With
            Loop Until found
        End If
    End Sub

    ' Brecht
    ' Recalculates the nextPlayerList
    Private Sub UpdateNextPlayerList()
        Dim t As Integer = turn
        Dim j As Integer = 0

        Do
            playerTurn(t) = Convert.ToString(j)
            j += 1
            FindNextPlayer(t, False)
        Loop Until t = turn

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

    ' Close all forms
    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        NewGame.Close()
        About.Close()
    End Sub

    ' Ine
    'Gemaakt op: 19/05/2011 om 13.41u
    'Drag & drop
    Private Sub BtnTile_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim btnPic As Button = CType(sender, Button)
        btnPic.DoDragDrop(btnPic.BackgroundImage, DragDropEffects.Copy)     ' Copy cursor

        Select Case DirectCast(sender, Button).Name.Substring(3)
            Case "Inn"
                With lvl.TileIndex(lastSelectedTile)
                    lvl.TileIndex(lastSelectedTile) = New TileInn(.X, .Y) ' Der MOET ne manier zyn om de cordinate van het Tile object te 
                End With                                                                       ' houde zonder de parameters opnieuw te moete meegeve. :(
            Case "Goose"
                With lvl.TileIndex(lastSelectedTile)
                    lvl.TileIndex(lastSelectedTile) = New TileGoose(.X, .Y)
                End With
            Case "Maze"
                With lvl.TileIndex(lastSelectedTile)
                    lvl.TileIndex(lastSelectedTile) = New TileMaze(.X, .Y)
                End With
            Case "Jail"
                With lvl.TileIndex(lastSelectedTile)
                    lvl.TileIndex(lastSelectedTile) = New TileJail(.X, .Y)
                End With
            Case "Death"
                With lvl.TileIndex(lastSelectedTile)
                    lvl.TileIndex(lastSelectedTile) = New TileDeath(.X, .Y)
                End With
        End Select

        RenderTile(lastSelectedTile)
    End Sub

    ' Ine
    'Gemaakt op: 19/05/2011 om 13.41u
    'Drag & drop
    Private Sub Tile_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs)
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
        lastSelectedTile = Convert.ToInt32(DirectCast(sender, PictureBox).Name.Substring(1))
    End Sub

    'Ine
    'Gemaakt op: 19/05/2011 om 13.41u
    'Drag & drop
    Private Sub Tile_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
        Dim picbox As PictureBox = CType(sender, PictureBox)
        Dim g As Graphics = picbox.CreateGraphics()
        g.DrawImage(DirectCast(e.Data.GetData(DataFormats.Bitmap), Image), New Point(0, 0))
    End Sub

    'Joeri later adjusted by Brecht
    '14/05/2011 om 20.10u
    'the load of the form
    Public Sub InitialiseGame()
        AddHandler BtnInn.MouseDown, AddressOf BtnTile_MouseDown
        AddHandler BtnGoose.MouseDown, AddressOf BtnTile_MouseDown
        AddHandler BtnJail.MouseDown, AddressOf BtnTile_MouseDown
        AddHandler BtnMaze.MouseDown, AddressOf BtnTile_MouseDown
        AddHandler BtnDeath.MouseDown, AddressOf BtnTile_MouseDown

        Me.Update()
        logColor = New List(Of Color)
        logColor.Add(Color.LightGray)

        lvl = New Level(NewGame.lvl, lvlWidth, lvlHeight, lvlLength)
        tileSize = Convert.ToInt32(Math.Min(Board.Width / lvlWidth, Board.Height / lvlHeight))
        RenderLevel()
        dice1 = New Dice
        dice2 = New Dice
        playerTurn = New List(Of String)

        For i As Integer = 0 To player.Count - 1
            LstPlayers.Items.Add(player(i).Name)
            playerTurn.Add(Convert.ToString(i))
        Next

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

        turn = 0
        UpdateNextPlayerList()
    End Sub

    ' Open about window
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    ' Bring the position back in if it's oob
    Private Sub CheckPos(ByRef pos As Integer)
        If pos > lvlLength Then
            finishTilesBack = pos - lvlLength
            pos = lvlLength
        Else
            If pos < 0 Then pos = 0
            finishTilesBack = 0
        End If
    End Sub

    ' Start a player turn
    Private Sub ProcessTurn()
        With player(turn)
            curPlayerPos = .Position
            lvl.TileIndex(.Position).Occupied = Nothing
            If debugMode Then
                .LastRoll = Convert.ToInt32(ThrowToolStripMenuItem.Text)
            Else
                .LastRoll = dice1.DiceValue + dice2.DiceValue
            End If
            AddToChatLog(.Name & " heeft " & Convert.ToString(.LastRoll) & " gegooid.", .Color)
            .Position += .LastRoll

            CheckPos(.Position)
        End With
        PlayerMoveTick.Start()
    End Sub

    'Joeri + kristof
    '17/05/2011 om 14.05u 
    'Next player and checking for PC
    Private Sub NextPlayer()
        PlayerMoveTick.Stop()
        lvl.TileIndex(player(turn).Position).Occupied = player(turn)
        If continueGame Then
            FindNextPlayer(turn, True)
            UpdateNextPlayerList()
            executedSpecial = False

            With player(turn)
                AddToChatLog(.Name & " zijn/haar beurt.", .Color)

                If .Comput = True Then
                    BtnDice.Enabled = False
                    diceRolling = True
                    TimerDiceDuration.Start()
                    TimerDiceTick.Start()
                Else
                    BtnDice.Enabled = True
                End If
            End With
        End If
    End Sub

    ' All actions for pre-game dice roll
    Private Sub ProcessPreGame()
        If turn = (player.Count - 1) Then
            AddToChatLog(player(turn).Name & " gooide " + Convert.ToString(dice1.DiceValue + dice2.DiceValue) & ".", player(turn).Color)
            hasGameStarted = True
            turn = highestThrowPlayer
            AddToChatLog(player(turn).Name & " gooide het hoogste met " & Convert.ToString(highestThrowValue) & " ogen, en mag beginnen.", player(turn).Color)
            ProcessTurn()
        Else
            Dim s As Integer
            If debugMode Then
                s = Convert.ToInt32(ThrowToolStripMenuItem.Text)
            Else
                s = dice1.DiceValue + dice2.DiceValue
            End If
            AddToChatLog(player(turn).Name & " gooide " + Convert.ToString(s) & ".", player(turn).Color)
            If s > highestThrowValue Then
                highestThrowValue = s
                highestThrowPlayer = turn
            End If

            NextPlayer()
        End If
    End Sub

    ' Brecht
    ' Handles both the player animation, and what it should do when it has reached its destination
    Private Sub PlayerMoveTick_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayerMoveTick.Tick
        With playerPics(turn)
            GetTileCords(curPlayerPos, .Left, .Top)
            .BringToFront()
        End With

        If player(turn).Position > curPlayerPos Then
            curPlayerPos += 1
        ElseIf player(turn).Position < curPlayerPos Then
            curPlayerPos -= 1
        Else
            If finishTilesBack = 0 Then ' If you didn't went past the finish AND
                If lvl.TileIndex(player(turn).Position).Occupied Is Nothing Or player(turn).Position = 0 Or _
                    (TypeOf lvl.TileIndex(player(turn).Position) Is TileJail) Then ' if the tile isn't taken already, except when on the start or a jail AND
                    If Not ((lvl.TileIndex(player(turn).Position).IsSpecialType And Not executedSpecial) Or _
                        player(turn).Position = lvlLength) Then  ' if the tile isn't (a special type AND able to execute one) or if it isn't on the finish

                        NextPlayer()                                                'THEN move on to next player
                    Else ' Handle special tiles
                        AddToChatLog(lvl.TileIndex(player(turn).Position).Go(player(turn)), player(turn).Color)
                        executedSpecial = True
                        If player(turn).Position = curPlayerPos Then
                            If curPlayerPos = lvlLength Then continueGame = False ' Stop the game when this player has finished
                            NextPlayer() ' If the position hasn't changed, like inn, jail and finish
                        Else
                            CheckPos(player(turn).Position)     ' Rechecks the position if it has moved
                        End If
                    End If
                Else ' Handle taken tiles
                    AddToChatLog("Het vakje was bezet door " & lvl.TileIndex(player(turn).Position).Occupied.Name & " dus " & _
                                 player(turn).Name & " moet terug", player(turn).Color)
                    player(turn).Position -= player(turn).LastRoll
                End If
                Else ' Handle finish overflow
                    AddToChatLog(player(turn).Name & " gooide te veel om de finishen, en moet dus " _
                                 & Convert.ToString(finishTilesBack) & " vakjes terug.", player(turn).Color)
                    player(turn).Position -= finishTilesBack
                    finishTilesBack = 0
                End If
        End If
    End Sub
    'Joeri
    '19/05/2011 om 18.53u 
    ' Handles rolling dice
    Private Sub TimerDiceTick_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerDiceTick.Tick
        dice1.Roll(PctDice1)
        dice2.Roll(PctDice2)
    End Sub

    ' Handles when dice have done rolling
    Private Sub TimerDiceDuration_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerDiceDuration.Tick
        TimerDiceTick.Stop()
        TimerDiceDuration.Stop()
        If hasGameStarted Then
            ProcessTurn()
        Else
            ProcessPreGame()
        End If
    End Sub

    ' Kristof
    ' Handles full screen
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

    'Joeri
    '13/05/2011 om 20.10u
    'the start button
    Private Sub BtnReady_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReady.Click
        BtnReady.Visible = False
        BtnDice.Enabled = True
        Players.Visible = True
        DragAndDropBox.Hide()

        hasGameStarted = False
        highestThrowPlayer = 0
        highestThrowValue = 2
        AddToChatLog("Iedere speler mag nu om beurt gooien, wie het hoogste gooit mag beginnen.", Color.LightGray)
    End Sub

    ' Game rules
    Private Sub SpelregelsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpelregelsToolStripMenuItem.Click
        SpelRegels.Show()
    End Sub

    ' DEBUG
    Private Sub EnableDebugToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableDebugToolStripMenuItem.Click
        If EnableDebugToolStripMenuItem.Checked Then
            EnableDebugToolStripMenuItem.Checked = False
            debugMode = False
        Else
            EnableDebugToolStripMenuItem.Checked = True
            debugMode = True
        End If
    End Sub
End Class