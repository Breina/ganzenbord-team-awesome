<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewGame
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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.TxtLevel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Openlvl = New System.Windows.Forms.OpenFileDialog()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.PlayerBox = New System.Windows.Forms.GroupBox()
        Me.NudPlayerCount = New System.Windows.Forms.NumericUpDown()
        Me.LblPlayers = New System.Windows.Forms.Label()
        Me.PanelBottom.SuspendLayout()
        CType(Me.NudPlayerCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(199, 9)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(73, 25)
        Me.btnStart.TabIndex = 40
        Me.btnStart.Text = "Start!"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'TxtLevel
        '
        Me.TxtLevel.Location = New System.Drawing.Point(54, 12)
        Me.TxtLevel.Name = "TxtLevel"
        Me.TxtLevel.ReadOnly = True
        Me.TxtLevel.Size = New System.Drawing.Size(102, 20)
        Me.TxtLevel.TabIndex = 38
        Me.TxtLevel.Text = "spiral.txt"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Level:"
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(162, 9)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(31, 25)
        Me.btnsearch.TabIndex = 39
        Me.btnsearch.Text = "..."
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'PanelBottom
        '
        Me.PanelBottom.Controls.Add(Me.btnStart)
        Me.PanelBottom.Controls.Add(Me.btnsearch)
        Me.PanelBottom.Controls.Add(Me.Label2)
        Me.PanelBottom.Controls.Add(Me.TxtLevel)
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBottom.Location = New System.Drawing.Point(0, 113)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(284, 47)
        Me.PanelBottom.TabIndex = 33
        '
        'PlayerBox
        '
        Me.PlayerBox.Location = New System.Drawing.Point(15, 32)
        Me.PlayerBox.Name = "PlayerBox"
        Me.PlayerBox.Size = New System.Drawing.Size(257, 25)
        Me.PlayerBox.TabIndex = 32
        Me.PlayerBox.TabStop = False
        Me.PlayerBox.Text = "Spelers"
        '
        'NudPlayerCount
        '
        Me.NudPlayerCount.Location = New System.Drawing.Point(94, 6)
        Me.NudPlayerCount.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.NudPlayerCount.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.NudPlayerCount.Name = "NudPlayerCount"
        Me.NudPlayerCount.Size = New System.Drawing.Size(44, 20)
        Me.NudPlayerCount.TabIndex = 31
        Me.NudPlayerCount.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'LblPlayers
        '
        Me.LblPlayers.AutoSize = True
        Me.LblPlayers.Location = New System.Drawing.Point(12, 8)
        Me.LblPlayers.Name = "LblPlayers"
        Me.LblPlayers.Size = New System.Drawing.Size(76, 13)
        Me.LblPlayers.TabIndex = 30
        Me.LblPlayers.Text = "Aantal spelers:"
        '
        'NewGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 160)
        Me.Controls.Add(Me.PanelBottom)
        Me.Controls.Add(Me.PlayerBox)
        Me.Controls.Add(Me.NudPlayerCount)
        Me.Controls.Add(Me.LblPlayers)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewGame"
        Me.Text = "Players"
        Me.TopMost = True
        Me.PanelBottom.ResumeLayout(False)
        Me.PanelBottom.PerformLayout()
        CType(Me.NudPlayerCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents TxtLevel As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Openlvl As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents PanelBottom As System.Windows.Forms.Panel
    Friend WithEvents PlayerBox As System.Windows.Forms.GroupBox
    Friend WithEvents NudPlayerCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblPlayers As System.Windows.Forms.Label
End Class
