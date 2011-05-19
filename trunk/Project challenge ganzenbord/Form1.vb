' Brecht en Joeri en Kristof
Imports VB = Microsoft.VisualBasic
Imports System.Runtime.InteropServices
Public Class Form1

    Private lvlLength As Integer                ' Length of the level
    Private logColor As List(Of Color)          ' Tracks the colours for log messages
    Private lvlWidth, lvlHeight As Integer      ' Dimentions of the board
    Private lvl As Level                        ' The level
    Private lvlTilePics As List(Of PictureBox)  ' Pictureboxes for each tile
    Private turn As Integer = 0
    Private dobbel1, dobbel2 As Dice

    ' Brecht
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
    ' Brecht
    Private Sub AddToChatLog(ByVal msg As String, ByVal col As Color)
        logColor.Add(col)
        LstChatLog.Items.Add(msg)
        'LstChatLog.SelectionMode() = SelectionMode.One             ' Zoek ne ander manier voor autoscroll
        LstChatLog.SelectedIndex = LstChatLog.Items.Count - 1       ' Autoscroll
    End Sub

    Private Sub BtnDice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDice.Click
        BtnDice.Text = "Gooi"
        BtnDice.Enabled = False
        ProcessTurn()
        BtnDice.Enabled = True
    End Sub

    'Brecht
    Private Sub FindNextPlayer()
        Dim found As Boolean
        Do
            found = True
            turn += 1
            If turn >= player.Count Then turn = 0

            If player(turn).InJail Then found = False
            If player(turn).SkipTurn Then
                found = False
                player(turn).SkipTurn = False
            End If

        Loop Until found

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
    Private Sub LstPlayersTest_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles LstPlayersTest.DrawItem
        'http://msdn.microsoft.com/en-us/library/system.windows.forms.listbox.drawmode%28v=vs.71%29.aspx

        Dim colorBrush As Brush
        colorBrush = New SolidBrush(player(e.Index).Kleur)

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
            s += "0"
        End If
        s += ".png"

        img = Image.FromFile(s)
        s = Nothing

        e.Graphics.FillRectangle(colorBrush, New RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height))
        e.Graphics.DrawString(player(e.Index).Naam, font, Brushes.Black, New RectangleF(e.Bounds.X + 24, e.Bounds.Y + 2, e.Bounds.Width, e.Bounds.Height))
        e.Graphics.DrawImage(img, New Point(1, 1))
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        NewGame.Close()
        About.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Update()
        logColor = New List(Of Color)
        logColor.Add(Color.LightGray)

        For i As Integer = 0 To player.Count - 1
            LstPlayers.Items.Add(player(i).Naam & " staat op posistie " & player(i).Position)
        Next
        BtnDice.Text = "Start het spel"
        RenderLevel(NewGame.lvl)
        lbllvl.Text = NewGame.lvl
        dobbel1 = New Dice
        dobbel2 = New Dice

        For i As Integer = 0 To player.Count - 1
            LstPlayersTest.Items.Add(player(i).Naam)
        Next


    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub ProcessTurn()
        dobbel1.Roll(PctDice1)
        dobbel2.Roll(PctDice2)

        With player(turn)
            Dim sum As Integer
            sum = dobbel1.DiceValue + dobbel2.DiceValue
            AddToChatLog(.Naam & " heeft " & sum.ToString & " gegooid", .Kleur)
            .Position = .Position + sum
            sum = Nothing

            LstPlayers.Items.Item(turn) = .Naam & " staat op posistie " & .Position
        End With

        FindNextPlayer()

        With player(turn)
            AddToChatLog(.Naam & " zijn/haar beurt!", .Kleur)

            If .Comput = True Then
                ProcessTurn()
            End If
        End With
    End Sub
End Class
