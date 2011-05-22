<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpelRegels
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
        Me.TxtSpelRegels = New System.Windows.Forms.TextBox()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtSpelRegels
        '
        Me.TxtSpelRegels.Location = New System.Drawing.Point(12, 21)
        Me.TxtSpelRegels.Multiline = True
        Me.TxtSpelRegels.Name = "TxtSpelRegels"
        Me.TxtSpelRegels.Size = New System.Drawing.Size(875, 482)
        Me.TxtSpelRegels.TabIndex = 0
        '
        'BtnOk
        '
        Me.BtnOk.Location = New System.Drawing.Point(378, 536)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(87, 29)
        Me.BtnOk.TabIndex = 1
        Me.BtnOk.Text = "ok"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'SpelRegels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 577)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.TxtSpelRegels)
        Me.Name = "SpelRegels"
        Me.Text = "SpelRegels"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtSpelRegels As System.Windows.Forms.TextBox
    Friend WithEvents BtnOk As System.Windows.Forms.Button
End Class
