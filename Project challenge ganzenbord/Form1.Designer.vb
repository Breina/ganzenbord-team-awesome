<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bord = New System.Windows.Forms.GroupBox()
        Me.PctDice1 = New System.Windows.Forms.PictureBox()
        Me.PctDice2 = New System.Windows.Forms.PictureBox()
        Me.LstChatLog = New System.Windows.Forms.ListBox()
        Me.NewPlayer = New System.Windows.Forms.GroupBox()
        Me.BtnDice = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PctDice1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctDice2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.TestToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
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
        Me.TestToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestToolStripMenuItem1})
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.TestToolStripMenuItem.Text = "Test"
        '
        'TestToolStripMenuItem1
        '
        Me.TestToolStripMenuItem1.Name = "TestToolStripMenuItem1"
        Me.TestToolStripMenuItem1.Size = New System.Drawing.Size(123, 22)
        Me.TestToolStripMenuItem1.Text = "TestLevel"
        '
        'Bord
        '
        Me.Bord.Location = New System.Drawing.Point(12, 27)
        Me.Bord.Name = "Bord"
        Me.Bord.Size = New System.Drawing.Size(623, 380)
        Me.Bord.TabIndex = 1
        Me.Bord.TabStop = False
        '
        'PctDice1
        '
        Me.PctDice1.Location = New System.Drawing.Point(535, 489)
        Me.PctDice1.Name = "PctDice1"
        Me.PctDice1.Size = New System.Drawing.Size(100, 68)
        Me.PctDice1.TabIndex = 2
        Me.PctDice1.TabStop = False
        '
        'PctDice2
        '
        Me.PctDice2.Location = New System.Drawing.Point(535, 413)
        Me.PctDice2.Name = "PctDice2"
        Me.PctDice2.Size = New System.Drawing.Size(100, 68)
        Me.PctDice2.TabIndex = 3
        Me.PctDice2.TabStop = False
        '
        'LstChatLog
        '
        Me.LstChatLog.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.LstChatLog.FormattingEnabled = True
        Me.LstChatLog.Items.AddRange(New Object() {"Started new game"})
        Me.LstChatLog.Location = New System.Drawing.Point(12, 413)
        Me.LstChatLog.Name = "LstChatLog"
        Me.LstChatLog.Size = New System.Drawing.Size(517, 147)
        Me.LstChatLog.TabIndex = 4
        '
        'NewPlayer
        '
        Me.NewPlayer.Location = New System.Drawing.Point(641, 27)
        Me.NewPlayer.Name = "NewPlayer"
        Me.NewPlayer.Size = New System.Drawing.Size(139, 380)
        Me.NewPlayer.TabIndex = 2
        Me.NewPlayer.TabStop = False
        '
        'BtnDice
        '
        Me.BtnDice.Location = New System.Drawing.Point(641, 515)
        Me.BtnDice.Name = "BtnDice"
        Me.BtnDice.Size = New System.Drawing.Size(139, 42)
        Me.BtnDice.TabIndex = 5
        Me.BtnDice.Text = "Gooi"
        Me.BtnDice.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(652, 413)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(39, 13)
        Me.lbl1.TabIndex = 6
        Me.lbl1.Text = "Label1"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(697, 413)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(39, 13)
        Me.lbl2.TabIndex = 7
        Me.lbl2.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.BtnDice)
        Me.Controls.Add(Me.NewPlayer)
        Me.Controls.Add(Me.LstChatLog)
        Me.Controls.Add(Me.PctDice2)
        Me.Controls.Add(Me.PctDice1)
        Me.Controls.Add(Me.Bord)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Gooseboard "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PctDice1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctDice2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TestToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Bord As System.Windows.Forms.GroupBox
    Friend WithEvents PctDice1 As System.Windows.Forms.PictureBox
    Friend WithEvents PctDice2 As System.Windows.Forms.PictureBox
    Friend WithEvents LstChatLog As System.Windows.Forms.ListBox
    Friend WithEvents NewPlayer As System.Windows.Forms.GroupBox
    Friend WithEvents BtnDice As System.Windows.Forms.Button
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label

End Class
