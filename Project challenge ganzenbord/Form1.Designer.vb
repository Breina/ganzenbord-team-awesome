﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FullscreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DebugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableDebugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpelregelsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Board = New System.Windows.Forms.GroupBox()
        Me.PctDice1 = New System.Windows.Forms.PictureBox()
        Me.PctDice2 = New System.Windows.Forms.PictureBox()
        Me.LstChatLog = New System.Windows.Forms.ListBox()
        Me.Players = New System.Windows.Forms.GroupBox()
        Me.LstPlayers = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DragAndDropBox = New System.Windows.Forms.GroupBox()
        Me.ButtonRandomize = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnDeath = New System.Windows.Forms.Button()
        Me.BtnMaze = New System.Windows.Forms.Button()
        Me.BtnGoose = New System.Windows.Forms.Button()
        Me.BtnJail = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnInn = New System.Windows.Forms.Button()
        Me.BtnDice = New System.Windows.Forms.Button()
        Me.TimerDiceTick = New System.Windows.Forms.Timer(Me.components)
        Me.TimerDiceDuration = New System.Windows.Forms.Timer(Me.components)
        Me.BtnReady = New System.Windows.Forms.Button()
        Me.PlayerMoveTick = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PctDice1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctDice2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Players.SuspendLayout()
        Me.DragAndDropBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.WindowToolStripMenuItem, Me.DebugToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(785, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.NewGameToolStripMenuItem.Text = "New Game"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FullscreenToolStripMenuItem})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.WindowToolStripMenuItem.Text = "Venster"
        '
        'FullscreenToolStripMenuItem
        '
        Me.FullscreenToolStripMenuItem.Name = "FullscreenToolStripMenuItem"
        Me.FullscreenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.FullscreenToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.FullscreenToolStripMenuItem.Text = "Volledig scherm"
        '
        'DebugToolStripMenuItem
        '
        Me.DebugToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnableDebugToolStripMenuItem})
        Me.DebugToolStripMenuItem.Name = "DebugToolStripMenuItem"
        Me.DebugToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.DebugToolStripMenuItem.Text = "Debug"
        '
        'EnableDebugToolStripMenuItem
        '
        Me.EnableDebugToolStripMenuItem.Name = "EnableDebugToolStripMenuItem"
        Me.EnableDebugToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EnableDebugToolStripMenuItem.Text = "Enable debug"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.SpelregelsToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'SpelregelsToolStripMenuItem
        '
        Me.SpelregelsToolStripMenuItem.Name = "SpelregelsToolStripMenuItem"
        Me.SpelregelsToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.SpelregelsToolStripMenuItem.Text = "Spelregels"
        '
        'Board
        '
        Me.Board.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Board.BackgroundImage = CType(resources.GetObject("Board.BackgroundImage"), System.Drawing.Image)
        Me.Board.Location = New System.Drawing.Point(12, 27)
        Me.Board.Margin = New System.Windows.Forms.Padding(0)
        Me.Board.Name = "Board"
        Me.Board.Padding = New System.Windows.Forms.Padding(0)
        Me.Board.Size = New System.Drawing.Size(554, 380)
        Me.Board.TabIndex = 1
        Me.Board.TabStop = False
        '
        'PctDice1
        '
        Me.PctDice1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PctDice1.ImageLocation = ""
        Me.PctDice1.Location = New System.Drawing.Point(572, 481)
        Me.PctDice1.Name = "PctDice1"
        Me.PctDice1.Size = New System.Drawing.Size(65, 65)
        Me.PctDice1.TabIndex = 2
        Me.PctDice1.TabStop = False
        '
        'PctDice2
        '
        Me.PctDice2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PctDice2.ImageLocation = ""
        Me.PctDice2.Location = New System.Drawing.Point(572, 413)
        Me.PctDice2.Name = "PctDice2"
        Me.PctDice2.Size = New System.Drawing.Size(65, 65)
        Me.PctDice2.TabIndex = 3
        Me.PctDice2.TabStop = False
        '
        'LstChatLog
        '
        Me.LstChatLog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LstChatLog.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.LstChatLog.FormattingEnabled = True
        Me.LstChatLog.Items.AddRange(New Object() {"Let the Game begin"})
        Me.LstChatLog.Location = New System.Drawing.Point(12, 413)
        Me.LstChatLog.Name = "LstChatLog"
        Me.LstChatLog.ScrollAlwaysVisible = True
        Me.LstChatLog.Size = New System.Drawing.Size(554, 134)
        Me.LstChatLog.TabIndex = 4
        Me.LstChatLog.TabStop = False
        '
        'Players
        '
        Me.Players.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Players.Controls.Add(Me.LstPlayers)
        Me.Players.Controls.Add(Me.Label1)
        Me.Players.Location = New System.Drawing.Point(573, 27)
        Me.Players.Name = "Players"
        Me.Players.Size = New System.Drawing.Size(200, 380)
        Me.Players.TabIndex = 2
        Me.Players.TabStop = False
        Me.Players.Visible = False
        '
        'LstPlayers
        '
        Me.LstPlayers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.LstPlayers.FormattingEnabled = True
        Me.LstPlayers.ItemHeight = 24
        Me.LstPlayers.Location = New System.Drawing.Point(9, 32)
        Me.LstPlayers.Name = "LstPlayers"
        Me.LstPlayers.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.LstPlayers.Size = New System.Drawing.Size(180, 148)
        Me.LstPlayers.TabIndex = 2
        Me.LstPlayers.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Spelers"
        '
        'DragAndDropBox
        '
        Me.DragAndDropBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DragAndDropBox.Controls.Add(Me.ButtonRandomize)
        Me.DragAndDropBox.Controls.Add(Me.Label6)
        Me.DragAndDropBox.Controls.Add(Me.Label5)
        Me.DragAndDropBox.Controls.Add(Me.Label4)
        Me.DragAndDropBox.Controls.Add(Me.Label3)
        Me.DragAndDropBox.Controls.Add(Me.BtnDeath)
        Me.DragAndDropBox.Controls.Add(Me.BtnMaze)
        Me.DragAndDropBox.Controls.Add(Me.BtnGoose)
        Me.DragAndDropBox.Controls.Add(Me.BtnJail)
        Me.DragAndDropBox.Controls.Add(Me.Label2)
        Me.DragAndDropBox.Controls.Add(Me.BtnInn)
        Me.DragAndDropBox.Location = New System.Drawing.Point(573, 27)
        Me.DragAndDropBox.Name = "DragAndDropBox"
        Me.DragAndDropBox.Size = New System.Drawing.Size(201, 379)
        Me.DragAndDropBox.TabIndex = 7
        Me.DragAndDropBox.TabStop = False
        Me.DragAndDropBox.Text = "Vakjes"
        '
        'ButtonRandomize
        '
        Me.ButtonRandomize.Enabled = False
        Me.ButtonRandomize.Location = New System.Drawing.Point(7, 235)
        Me.ButtonRandomize.Name = "ButtonRandomize"
        Me.ButtonRandomize.Size = New System.Drawing.Size(182, 37)
        Me.ButtonRandomize.TabIndex = 10
        Me.ButtonRandomize.Text = "Willekeurig"
        Me.ButtonRandomize.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Vermoord"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Doolhof"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Gans"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Gevangenis"
        '
        'BtnDeath
        '
        Me.BtnDeath.BackgroundImage = CType(resources.GetObject("BtnDeath.BackgroundImage"), System.Drawing.Image)
        Me.BtnDeath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDeath.Enabled = False
        Me.BtnDeath.Location = New System.Drawing.Point(10, 193)
        Me.BtnDeath.Name = "BtnDeath"
        Me.BtnDeath.Size = New System.Drawing.Size(35, 35)
        Me.BtnDeath.TabIndex = 5
        Me.BtnDeath.UseVisualStyleBackColor = True
        '
        'BtnMaze
        '
        Me.BtnMaze.BackgroundImage = CType(resources.GetObject("BtnMaze.BackgroundImage"), System.Drawing.Image)
        Me.BtnMaze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMaze.Enabled = False
        Me.BtnMaze.Location = New System.Drawing.Point(10, 152)
        Me.BtnMaze.Name = "BtnMaze"
        Me.BtnMaze.Size = New System.Drawing.Size(35, 35)
        Me.BtnMaze.TabIndex = 4
        Me.BtnMaze.UseVisualStyleBackColor = True
        '
        'BtnGoose
        '
        Me.BtnGoose.BackgroundImage = CType(resources.GetObject("BtnGoose.BackgroundImage"), System.Drawing.Image)
        Me.BtnGoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGoose.Enabled = False
        Me.BtnGoose.Location = New System.Drawing.Point(10, 110)
        Me.BtnGoose.Name = "BtnGoose"
        Me.BtnGoose.Size = New System.Drawing.Size(35, 35)
        Me.BtnGoose.TabIndex = 3
        Me.BtnGoose.UseVisualStyleBackColor = True
        '
        'BtnJail
        '
        Me.BtnJail.BackgroundImage = CType(resources.GetObject("BtnJail.BackgroundImage"), System.Drawing.Image)
        Me.BtnJail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnJail.Enabled = False
        Me.BtnJail.Location = New System.Drawing.Point(10, 69)
        Me.BtnJail.Name = "BtnJail"
        Me.BtnJail.Size = New System.Drawing.Size(35, 35)
        Me.BtnJail.TabIndex = 2
        Me.BtnJail.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Herberg"
        '
        'BtnInn
        '
        Me.BtnInn.BackgroundImage = CType(resources.GetObject("BtnInn.BackgroundImage"), System.Drawing.Image)
        Me.BtnInn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnInn.Enabled = False
        Me.BtnInn.Location = New System.Drawing.Point(10, 28)
        Me.BtnInn.Name = "BtnInn"
        Me.BtnInn.Size = New System.Drawing.Size(35, 35)
        Me.BtnInn.TabIndex = 0
        Me.BtnInn.UseVisualStyleBackColor = True
        '
        'BtnDice
        '
        Me.BtnDice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDice.Enabled = False
        Me.BtnDice.Location = New System.Drawing.Point(645, 416)
        Me.BtnDice.Name = "BtnDice"
        Me.BtnDice.Size = New System.Drawing.Size(127, 131)
        Me.BtnDice.TabIndex = 5
        Me.BtnDice.Text = "Gooi"
        Me.BtnDice.UseVisualStyleBackColor = True
        '
        'TimerDiceTick
        '
        '
        'TimerDiceDuration
        '
        Me.TimerDiceDuration.Interval = 500
        '
        'BtnReady
        '
        Me.BtnReady.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnReady.Location = New System.Drawing.Point(645, 416)
        Me.BtnReady.Name = "BtnReady"
        Me.BtnReady.Size = New System.Drawing.Size(128, 131)
        Me.BtnReady.TabIndex = 6
        Me.BtnReady.Text = "Start het spel"
        Me.BtnReady.UseVisualStyleBackColor = True
        Me.BtnReady.Visible = False
        '
        'PlayerMoveTick
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 558)
        Me.Controls.Add(Me.DragAndDropBox)
        Me.Controls.Add(Me.BtnReady)
        Me.Controls.Add(Me.BtnDice)
        Me.Controls.Add(Me.Players)
        Me.Controls.Add(Me.LstChatLog)
        Me.Controls.Add(Me.PctDice2)
        Me.Controls.Add(Me.PctDice1)
        Me.Controls.Add(Me.Board)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(400, 400)
        Me.Name = "Form1"
        Me.Text = "Gooseboard "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PctDice1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctDice2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Players.ResumeLayout(False)
        Me.Players.PerformLayout()
        Me.DragAndDropBox.ResumeLayout(False)
        Me.DragAndDropBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PctDice1 As System.Windows.Forms.PictureBox
    Friend WithEvents PctDice2 As System.Windows.Forms.PictureBox
    Friend WithEvents LstChatLog As System.Windows.Forms.ListBox
    Friend WithEvents Players As System.Windows.Forms.GroupBox
    Friend WithEvents BtnDice As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Board As System.Windows.Forms.GroupBox
    Friend WithEvents TimerDiceTick As System.Windows.Forms.Timer
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LstPlayers As System.Windows.Forms.ListBox
    Friend WithEvents TimerDiceDuration As System.Windows.Forms.Timer
    Friend WithEvents BtnReady As System.Windows.Forms.Button
    Friend WithEvents DragAndDropBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnDeath As System.Windows.Forms.Button
    Friend WithEvents BtnMaze As System.Windows.Forms.Button
    Friend WithEvents BtnGoose As System.Windows.Forms.Button
    Friend WithEvents BtnJail As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnInn As System.Windows.Forms.Button
    Friend WithEvents PlayerMoveTick As System.Windows.Forms.Timer
    Friend WithEvents WindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FullscreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpelregelsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DebugToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnableDebugToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonRandomize As System.Windows.Forms.Button

End Class
