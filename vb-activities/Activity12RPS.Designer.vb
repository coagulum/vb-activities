<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Activity12RPS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Activity12RPS))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdRabbit = New System.Windows.Forms.RadioButton()
        Me.rdCarrot = New System.Windows.Forms.RadioButton()
        Me.rdGun = New System.Windows.Forms.RadioButton()
        Me.btnBegin = New System.Windows.Forms.Button()
        Me.lblWin = New System.Windows.Forms.Label()
        Me.lblLost = New System.Windows.Forms.Label()
        Me.lblDraw = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblEnemy = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPScore = New System.Windows.Forms.Label()
        Me.lblEScore = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = CType(resources.GetObject("PictureBox2.InitialImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(118, 57)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.vb_activities.My.Resources.Resources.gu
        Me.PictureBox3.InitialImage = CType(resources.GetObject("PictureBox3.InitialImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(224, 57)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Rabbit     Carrot    Gun" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'rdRabbit
        '
        Me.rdRabbit.AutoSize = True
        Me.rdRabbit.Location = New System.Drawing.Point(12, 124)
        Me.rdRabbit.Name = "rdRabbit"
        Me.rdRabbit.Size = New System.Drawing.Size(56, 17)
        Me.rdRabbit.TabIndex = 4
        Me.rdRabbit.TabStop = True
        Me.rdRabbit.Text = "Rabbit"
        Me.rdRabbit.UseVisualStyleBackColor = True
        '
        'rdCarrot
        '
        Me.rdCarrot.AutoSize = True
        Me.rdCarrot.Location = New System.Drawing.Point(118, 124)
        Me.rdCarrot.Name = "rdCarrot"
        Me.rdCarrot.Size = New System.Drawing.Size(53, 17)
        Me.rdCarrot.TabIndex = 5
        Me.rdCarrot.TabStop = True
        Me.rdCarrot.Text = "Carrot"
        Me.rdCarrot.UseVisualStyleBackColor = True
        '
        'rdGun
        '
        Me.rdGun.AutoSize = True
        Me.rdGun.Location = New System.Drawing.Point(224, 124)
        Me.rdGun.Name = "rdGun"
        Me.rdGun.Size = New System.Drawing.Size(45, 17)
        Me.rdGun.TabIndex = 6
        Me.rdGun.TabStop = True
        Me.rdGun.Text = "Gun"
        Me.rdGun.UseVisualStyleBackColor = True
        '
        'btnBegin
        '
        Me.btnBegin.Location = New System.Drawing.Point(12, 179)
        Me.btnBegin.Name = "btnBegin"
        Me.btnBegin.Size = New System.Drawing.Size(308, 23)
        Me.btnBegin.TabIndex = 7
        Me.btnBegin.Text = "Begin"
        Me.btnBegin.UseVisualStyleBackColor = True
        '
        'lblWin
        '
        Me.lblWin.AutoSize = True
        Me.lblWin.Location = New System.Drawing.Point(15, 220)
        Me.lblWin.Name = "lblWin"
        Me.lblWin.Size = New System.Drawing.Size(55, 13)
        Me.lblWin.TabIndex = 8
        Me.lblWin.Text = "YOU WIN"
        Me.lblWin.Visible = False
        '
        'lblLost
        '
        Me.lblLost.AutoSize = True
        Me.lblLost.Location = New System.Drawing.Point(259, 220)
        Me.lblLost.Name = "lblLost"
        Me.lblLost.Size = New System.Drawing.Size(61, 13)
        Me.lblLost.TabIndex = 9
        Me.lblLost.Text = "YOU LOST"
        Me.lblLost.Visible = False
        '
        'lblDraw
        '
        Me.lblDraw.AutoSize = True
        Me.lblDraw.Location = New System.Drawing.Point(146, 220)
        Me.lblDraw.Name = "lblDraw"
        Me.lblDraw.Size = New System.Drawing.Size(41, 13)
        Me.lblDraw.TabIndex = 10
        Me.lblDraw.Text = "DRAW"
        Me.lblDraw.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 297)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Opponent picked: "
        '
        'lblEnemy
        '
        Me.lblEnemy.AutoSize = True
        Me.lblEnemy.Location = New System.Drawing.Point(115, 297)
        Me.lblEnemy.Name = "lblEnemy"
        Me.lblEnemy.Size = New System.Drawing.Size(49, 13)
        Me.lblEnemy.TabIndex = 12
        Me.lblEnemy.Text = "???????"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 346)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(253, 78)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(245, 414)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(199, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Player Score:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(199, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Bot Score: "
        '
        'lblPScore
        '
        Me.lblPScore.AutoSize = True
        Me.lblPScore.Location = New System.Drawing.Point(276, 267)
        Me.lblPScore.Name = "lblPScore"
        Me.lblPScore.Size = New System.Drawing.Size(13, 13)
        Me.lblPScore.TabIndex = 17
        Me.lblPScore.Text = "0"
        '
        'lblEScore
        '
        Me.lblEScore.AutoSize = True
        Me.lblEScore.Location = New System.Drawing.Point(276, 297)
        Me.lblEScore.Name = "lblEScore"
        Me.lblEScore.Size = New System.Drawing.Size(13, 13)
        Me.lblEScore.TabIndex = 18
        Me.lblEScore.Text = "0"
        '
        'Activity12RPS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 450)
        Me.Controls.Add(Me.lblEScore)
        Me.Controls.Add(Me.lblPScore)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblEnemy)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDraw)
        Me.Controls.Add(Me.lblLost)
        Me.Controls.Add(Me.lblWin)
        Me.Controls.Add(Me.btnBegin)
        Me.Controls.Add(Me.rdGun)
        Me.Controls.Add(Me.rdCarrot)
        Me.Controls.Add(Me.rdRabbit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Activity12RPS"
        Me.Text = "Activity12RPS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rdRabbit As RadioButton
    Friend WithEvents rdCarrot As RadioButton
    Friend WithEvents rdGun As RadioButton
    Friend WithEvents btnBegin As Button
    Friend WithEvents lblWin As Label
    Friend WithEvents lblLost As Label
    Friend WithEvents lblDraw As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblEnemy As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPScore As Label
    Friend WithEvents lblEScore As Label
End Class
