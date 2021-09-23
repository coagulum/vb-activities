<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class activity2
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
        Me.lblname = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.btnname = New System.Windows.Forms.Button()
        Me.lblgreeting = New System.Windows.Forms.Label()
        Me.txtplace = New System.Windows.Forms.TextBox()
        Me.lblplace = New System.Windows.Forms.Label()
        Me.btnplace = New System.Windows.Forms.Button()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.btnage = New System.Windows.Forms.Button()
        Me.btnback1 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(13, 13)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(81, 13)
        Me.lblname.TabIndex = 0
        Me.lblname.Text = "Come ti chiami?"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(13, 30)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 20)
        Me.txtname.TabIndex = 1
        '
        'btnname
        '
        Me.btnname.Location = New System.Drawing.Point(120, 30)
        Me.btnname.Name = "btnname"
        Me.btnname.Size = New System.Drawing.Size(66, 23)
        Me.btnname.TabIndex = 2
        Me.btnname.Text = "Invio Nome"
        Me.btnname.UseVisualStyleBackColor = True
        '
        'lblgreeting
        '
        Me.lblgreeting.AutoSize = True
        Me.lblgreeting.Location = New System.Drawing.Point(13, 57)
        Me.lblgreeting.Name = "lblgreeting"
        Me.lblgreeting.Size = New System.Drawing.Size(67, 13)
        Me.lblgreeting.TabIndex = 3
        Me.lblgreeting.Text = "Greeting box"
        Me.lblgreeting.Visible = False
        '
        'txtplace
        '
        Me.txtplace.Location = New System.Drawing.Point(13, 74)
        Me.txtplace.Name = "txtplace"
        Me.txtplace.Size = New System.Drawing.Size(100, 20)
        Me.txtplace.TabIndex = 4
        Me.txtplace.Visible = False
        '
        'lblplace
        '
        Me.lblplace.AutoSize = True
        Me.lblplace.Location = New System.Drawing.Point(13, 102)
        Me.lblplace.Name = "lblplace"
        Me.lblplace.Size = New System.Drawing.Size(54, 13)
        Me.lblplace.TabIndex = 5
        Me.lblplace.Text = "Place box"
        Me.lblplace.Visible = False
        '
        'btnplace
        '
        Me.btnplace.Location = New System.Drawing.Point(119, 72)
        Me.btnplace.Name = "btnplace"
        Me.btnplace.Size = New System.Drawing.Size(67, 23)
        Me.btnplace.TabIndex = 6
        Me.btnplace.Text = "Invio"
        Me.btnplace.UseVisualStyleBackColor = True
        Me.btnplace.Visible = False
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(13, 119)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(100, 20)
        Me.txtage.TabIndex = 7
        Me.txtage.Visible = False
        '
        'btnage
        '
        Me.btnage.Location = New System.Drawing.Point(120, 115)
        Me.btnage.Name = "btnage"
        Me.btnage.Size = New System.Drawing.Size(66, 23)
        Me.btnage.TabIndex = 8
        Me.btnage.Text = "Invio"
        Me.btnage.UseVisualStyleBackColor = True
        Me.btnage.Visible = False
        '
        'btnback1
        '
        Me.btnback1.Location = New System.Drawing.Point(195, 92)
        Me.btnback1.Name = "btnback1"
        Me.btnback1.Size = New System.Drawing.Size(117, 23)
        Me.btnback1.TabIndex = 10
        Me.btnback1.Text = "Back"
        Me.btnback1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(192, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "variable is username, user place, userage"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(192, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(232, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "variable declariation happens in the  private sub"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(192, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "assignment statement is the value of the textbox"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(192, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(248, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = ".Text tells the form that the variable is in the textbox"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(192, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(199, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = ".Visible = True will make the label appear"
        '
        'activity2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 159)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnback1)
        Me.Controls.Add(Me.btnage)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.btnplace)
        Me.Controls.Add(Me.lblplace)
        Me.Controls.Add(Me.txtplace)
        Me.Controls.Add(Me.lblgreeting)
        Me.Controls.Add(Me.btnname)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.lblname)
        Me.Name = "activity2"
        Me.Text = "activity2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblname As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents btnname As Button
    Friend WithEvents lblgreeting As Label
    Friend WithEvents txtplace As TextBox
    Friend WithEvents lblplace As Label
    Friend WithEvents btnplace As Button
    Friend WithEvents txtage As TextBox
    Friend WithEvents btnage As Button
    Friend WithEvents btnback1 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
