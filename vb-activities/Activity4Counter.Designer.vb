<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class activity4
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
        Me.lblcount = New System.Windows.Forms.Label()
        Me.btncount = New System.Windows.Forms.Button()
        Me.btncount0 = New System.Windows.Forms.Button()
        Me.btncount2 = New System.Windows.Forms.Button()
        Me.btncountminus = New System.Windows.Forms.Button()
        Me.btncount5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblcount
        '
        Me.lblcount.AutoSize = True
        Me.lblcount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.lblcount.Location = New System.Drawing.Point(139, 9)
        Me.lblcount.Name = "lblcount"
        Me.lblcount.Size = New System.Drawing.Size(24, 25)
        Me.lblcount.TabIndex = 0
        Me.lblcount.Text = "0"
        '
        'btncount
        '
        Me.btncount.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.btncount.Location = New System.Drawing.Point(99, 37)
        Me.btncount.Name = "btncount"
        Me.btncount.Size = New System.Drawing.Size(24, 23)
        Me.btncount.TabIndex = 1
        Me.btncount.Text = "+1"
        Me.btncount.UseVisualStyleBackColor = True
        '
        'btncount0
        '
        Me.btncount0.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.btncount0.Location = New System.Drawing.Point(129, 37)
        Me.btncount0.Name = "btncount0"
        Me.btncount0.Size = New System.Drawing.Size(48, 23)
        Me.btncount0.TabIndex = 2
        Me.btncount0.Text = "reset"
        Me.btncount0.UseVisualStyleBackColor = True
        '
        'btncount2
        '
        Me.btncount2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.btncount2.Location = New System.Drawing.Point(183, 37)
        Me.btncount2.Name = "btncount2"
        Me.btncount2.Size = New System.Drawing.Size(24, 23)
        Me.btncount2.TabIndex = 3
        Me.btncount2.Text = "+2"
        Me.btncount2.UseVisualStyleBackColor = True
        '
        'btncountminus
        '
        Me.btncountminus.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.btncountminus.Location = New System.Drawing.Point(69, 37)
        Me.btncountminus.Name = "btncountminus"
        Me.btncountminus.Size = New System.Drawing.Size(24, 23)
        Me.btncountminus.TabIndex = 4
        Me.btncountminus.Text = "-1"
        Me.btncountminus.UseVisualStyleBackColor = True
        '
        'btncount5
        '
        Me.btncount5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.btncount5.Location = New System.Drawing.Point(213, 37)
        Me.btncount5.Name = "btncount5"
        Me.btncount5.Size = New System.Drawing.Size(24, 23)
        Me.btncount5.TabIndex = 5
        Me.btncount5.Text = "+5"
        Me.btncount5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "variable is count"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "variable declaration is defined when button is clicked"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "assignment is the value of the counter"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "This could be used as a timer, calculator, or tally"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(163, 176)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'activity4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 219)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btncount5)
        Me.Controls.Add(Me.btncountminus)
        Me.Controls.Add(Me.btncount2)
        Me.Controls.Add(Me.btncount0)
        Me.Controls.Add(Me.btncount)
        Me.Controls.Add(Me.lblcount)
        Me.Name = "activity4"
        Me.Text = "activity4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblcount As Label
    Friend WithEvents btncount As Button
    Friend WithEvents btncount0 As Button
    Friend WithEvents btncount2 As Button
    Friend WithEvents btncountminus As Button
    Friend WithEvents btncount5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
End Class
