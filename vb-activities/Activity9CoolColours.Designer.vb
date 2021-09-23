<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Activity9CoolColours
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
        Me.lblChange = New System.Windows.Forms.Label()
        Me.rdComic = New System.Windows.Forms.RadioButton()
        Me.cbBackground = New System.Windows.Forms.ComboBox()
        Me.lbBackground = New System.Windows.Forms.ListBox()
        Me.rdSansSerif = New System.Windows.Forms.RadioButton()
        Me.rdPapayrus = New System.Windows.Forms.RadioButton()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Location = New System.Drawing.Point(141, 26)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(60, 13)
        Me.lblChange.TabIndex = 0
        Me.lblChange.Text = "Chameleon"
        '
        'rdComic
        '
        Me.rdComic.AutoSize = True
        Me.rdComic.Location = New System.Drawing.Point(12, 84)
        Me.rdComic.Name = "rdComic"
        Me.rdComic.Size = New System.Drawing.Size(81, 17)
        Me.rdComic.TabIndex = 1
        Me.rdComic.TabStop = True
        Me.rdComic.Text = "Comic Sans"
        Me.rdComic.UseVisualStyleBackColor = True
        '
        'cbBackground
        '
        Me.cbBackground.FormattingEnabled = True
        Me.cbBackground.Items.AddRange(New Object() {"White", "Black", "Green", "Blue", "Red"})
        Me.cbBackground.Location = New System.Drawing.Point(220, 84)
        Me.cbBackground.Name = "cbBackground"
        Me.cbBackground.Size = New System.Drawing.Size(121, 21)
        Me.cbBackground.TabIndex = 2
        '
        'lbBackground
        '
        Me.lbBackground.FormattingEnabled = True
        Me.lbBackground.Items.AddRange(New Object() {"White", "Black", "Red", "Green", "Blue"})
        Me.lbBackground.Location = New System.Drawing.Point(224, 111)
        Me.lbBackground.Name = "lbBackground"
        Me.lbBackground.Size = New System.Drawing.Size(117, 95)
        Me.lbBackground.TabIndex = 3
        '
        'rdSansSerif
        '
        Me.rdSansSerif.AutoSize = True
        Me.rdSansSerif.Location = New System.Drawing.Point(12, 107)
        Me.rdSansSerif.Name = "rdSansSerif"
        Me.rdSansSerif.Size = New System.Drawing.Size(73, 17)
        Me.rdSansSerif.TabIndex = 4
        Me.rdSansSerif.TabStop = True
        Me.rdSansSerif.Text = "Sans Serif"
        Me.rdSansSerif.UseVisualStyleBackColor = True
        '
        'rdPapayrus
        '
        Me.rdPapayrus.AutoSize = True
        Me.rdPapayrus.Location = New System.Drawing.Point(12, 130)
        Me.rdPapayrus.Name = "rdPapayrus"
        Me.rdPapayrus.Size = New System.Drawing.Size(69, 17)
        Me.rdPapayrus.TabIndex = 5
        Me.rdPapayrus.TabStop = True
        Me.rdPapayrus.Text = "Papayrus"
        Me.rdPapayrus.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 203)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(338, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Combobox saves space, while the others are the same for functionality"
        '
        'Activity9CoolColours
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 250)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.rdPapayrus)
        Me.Controls.Add(Me.rdSansSerif)
        Me.Controls.Add(Me.lbBackground)
        Me.Controls.Add(Me.cbBackground)
        Me.Controls.Add(Me.rdComic)
        Me.Controls.Add(Me.lblChange)
        Me.Name = "Activity9CoolColours"
        Me.Text = "Activity9CoolColours"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblChange As Label
    Friend WithEvents rdComic As RadioButton
    Friend WithEvents cbBackground As ComboBox
    Friend WithEvents lbBackground As ListBox
    Friend WithEvents rdSansSerif As RadioButton
    Friend WithEvents rdPapayrus As RadioButton
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
End Class
