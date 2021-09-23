<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class activity1
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
        Me.btndanger = New System.Windows.Forms.Button()
        Me.btnGood = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnnext1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btndanger
        '
        Me.btndanger.BackColor = System.Drawing.Color.Red
        Me.btndanger.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndanger.Location = New System.Drawing.Point(12, 12)
        Me.btndanger.Name = "btndanger"
        Me.btndanger.Size = New System.Drawing.Size(378, 332)
        Me.btndanger.TabIndex = 0
        Me.btndanger.Text = "DO NOT PRESS"
        Me.btndanger.UseVisualStyleBackColor = False
        '
        'btnGood
        '
        Me.btnGood.BackColor = System.Drawing.Color.Lime
        Me.btnGood.Location = New System.Drawing.Point(396, 12)
        Me.btnGood.Name = "btnGood"
        Me.btnGood.Size = New System.Drawing.Size(364, 332)
        Me.btnGood.TabIndex = 1
        Me.btnGood.Text = "PRESS"
        Me.btnGood.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 347)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Button is named btngood because it is the button that gives good luck"
        '
        'btnnext1
        '
        Me.btnnext1.Location = New System.Drawing.Point(637, 368)
        Me.btnnext1.Name = "btnnext1"
        Me.btnnext1.Size = New System.Drawing.Size(131, 23)
        Me.btnnext1.TabIndex = 3
        Me.btnnext1.Text = "Back"
        Me.btnnext1.UseVisualStyleBackColor = True
        '
        'activity1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 403)
        Me.Controls.Add(Me.btnnext1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGood)
        Me.Controls.Add(Me.btndanger)
        Me.Name = "activity1"
        Me.Text = "activity1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btndanger As Button
    Friend WithEvents btnGood As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnnext1 As Button
End Class
