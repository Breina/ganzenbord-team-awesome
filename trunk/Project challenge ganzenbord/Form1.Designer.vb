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
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpiraltxtToolStripMenuItem = New System.Windows.Forms.ToolStripTextBox()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Board = New System.Windows.Forms.GroupBox()
        Me.PctDice1 = New System.Windows.Forms.PictureBox()
        Me.PctDice2 = New System.Windows.Forms.PictureBox()
        Me.LstChatLog = New System.Windows.Forms.ListBox()
        Me.NewPlayer = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LstPlayersTest = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LstPlayers = New System.Windows.Forms.ListBox()
        Me.BtnDice = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.TimerDice = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PctDice1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctDice2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NewPlayer.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.TestToolStripMenuItem, Me.HelpToolStripMenuItem})
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
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.NewGameToolStripMenuItem.Text = "New Game"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestToolStripMenuItem1, Me.SpiraltxtToolStripMenuItem})
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.TestToolStripMenuItem.Text = "Test"
        '
        'TestToolStripMenuItem1
        '
        Me.TestToolStripMenuItem1.Name = "TestToolStripMenuItem1"
        Me.TestToolStripMenuItem1.Size = New System.Drawing.Size(212, 22)
        Me.TestToolStripMenuItem1.Text = "TestLevel"
        '
        'SpiraltxtToolStripMenuItem
        '
        Me.SpiraltxtToolStripMenuItem.Name = "SpiraltxtToolStripMenuItem"
        Me.SpiraltxtToolStripMenuItem.Size = New System.Drawing.Size(152, 23)
        Me.SpiraltxtToolStripMenuItem.Text = "spiral.txt"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Board
        '
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
        Me.PctDice1.Location = New System.Drawing.Point(572, 481)
        Me.PctDice1.Name = "PctDice1"
        Me.PctDice1.Size = New System.Drawing.Size(65, 65)
        Me.PctDice1.TabIndex = 2
        Me.PctDice1.TabStop = False
        '
        'PctDice2
        '
        Me.PctDice2.Location = New System.Drawing.Point(572, 413)
        Me.PctDice2.Name = "PctDice2"
        Me.PctDice2.Size = New System.Drawing.Size(65, 65)
        Me.PctDice2.TabIndex = 3
        Me.PctDice2.TabStop = False
        '
        'LstChatLog
        '
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
        'NewPlayer
        '
        Me.NewPlayer.Controls.Add(Me.Label2)
        Me.NewPlayer.Controls.Add(Me.LstPlayersTest)
        Me.NewPlayer.Controls.Add(Me.Label1)
        Me.NewPlayer.Controls.Add(Me.LstPlayers)
        Me.NewPlayer.Location = New System.Drawing.Point(572, 27)
        Me.NewPlayer.Name = "NewPlayer"
        Me.NewPlayer.Size = New System.Drawing.Size(200, 383)
        Me.NewPlayer.TabIndex = 2
        Me.NewPlayer.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Volgende speler test"
        '
        'LstPlayersTest
        '
        Me.LstPlayersTest.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.LstPlayersTest.FormattingEnabled = True
        Me.LstPlayersTest.ItemHeight = 24
        Me.LstPlayersTest.Items.AddRange(New Object() {"Jos", "Flip", "Jaak", "Tuur"})
        Me.LstPlayersTest.Location = New System.Drawing.Point(14, 217)
        Me.LstPlayersTest.Name = "LstPlayersTest"
        Me.LstPlayersTest.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.LstPlayersTest.Size = New System.Drawing.Size(180, 124)
        Me.LstPlayersTest.TabIndex = 2
        Me.LstPlayersTest.TabStop = False
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
        'LstPlayers
        '
        Me.LstPlayers.FormattingEnabled = True
        Me.LstPlayers.Location = New System.Drawing.Point(14, 32)
        Me.LstPlayers.Name = "LstPlayers"
        Me.LstPlayers.Size = New System.Drawing.Size(180, 134)
        Me.LstPlayers.TabIndex = 0
        Me.LstPlayers.TabStop = False
        '
        'BtnDice
        '
        Me.BtnDice.Location = New System.Drawing.Point(645, 505)
        Me.BtnDice.Name = "BtnDice"
        Me.BtnDice.Size = New System.Drawing.Size(127, 42)
        Me.BtnDice.TabIndex = 5
        Me.BtnDice.Text = "Gooi"
        Me.BtnDice.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(667, 454)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(0, 13)
        Me.lbl1.TabIndex = 6
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(712, 454)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(0, 13)
        Me.lbl2.TabIndex = 7
        '
        'TimerDice
        '
        Me.TimerDice.Interval = 500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 558)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.BtnDice)
        Me.Controls.Add(Me.NewPlayer)
        Me.Controls.Add(Me.LstChatLog)
        Me.Controls.Add(Me.PctDice2)
        Me.Controls.Add(Me.PctDice1)
        Me.Controls.Add(Me.Board)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Gooseboard "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PctDice1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctDice2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NewPlayer.ResumeLayout(False)
        Me.NewPlayer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TestToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PctDice1 As System.Windows.Forms.PictureBox
    Friend WithEvents PctDice2 As System.Windows.Forms.PictureBox
    Friend WithEvents LstChatLog As System.Windows.Forms.ListBox
    Friend WithEvents NewPlayer As System.Windows.Forms.GroupBox
    Friend WithEvents BtnDice As System.Windows.Forms.Button
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LstPlayers As System.Windows.Forms.ListBox
    Friend WithEvents SpiraltxtToolStripMenuItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Board As System.Windows.Forms.GroupBox
    Friend WithEvents TimerDice As System.Windows.Forms.Timer
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LstPlayersTest As System.Windows.Forms.ListBox

End Class
