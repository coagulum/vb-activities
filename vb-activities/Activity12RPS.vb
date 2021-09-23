Public Class Activity12RPS

    Private Sub btnBegin_Click(sender As Object, e As EventArgs) Handles btnBegin.Click
        Dim comChoice As Integer
        Dim PScore As Integer
        Dim EScore As Integer
        Dim Rabbit As Integer = 1
        Dim Carrot As Integer = 2
        Dim Gun As Integer = 3

        Randomize()
        comChoice = Int(Rnd() * 4)

        If rdRabbit.Checked And comChoice = Rabbit Then
            lblDraw.Visible = True
            lblWin.Visible = False
            lblLost.Visible = False
            lblEnemy.Text = "Rabbit"
        ElseIf rdRabbit.Checked And comChoice = Carrot Then
            lblDraw.Visible = False
            lblWin.Visible = True
            lblLost.Visible = False
            lblEnemy.Text = "Carrot"
            lblPScore.Text += 1

        ElseIf rdRabbit.Checked And comChoice = Gun Then
            lblDraw.Visible = False
            lblWin.Visible = False
            lblLost.Visible = True
            lblEnemy.Text = "Gun"
            lblEScore.Text += 1

        End If

        If rdCarrot.Checked And comChoice = Rabbit Then
            lblDraw.Visible = False
            lblWin.Visible = False
            lblLost.Visible = True
            lblEnemy.Text = "Rabbit"
            lblEScore.Text += 1

        ElseIf rdCarrot.Checked And comChoice = Carrot Then
            lblDraw.Visible = True
            lblWin.Visible = False
            lblLost.Visible = False
            lblEnemy.Text = "Carrot"
        ElseIf rdCarrot.Checked And comChoice = Gun Then
            lblDraw.Visible = False
            lblWin.Visible = True
            lblLost.Visible = False
            lblEnemy.Text = "Gun"
            lblPScore.Text += 1
        End If

        If rdGun.Checked And comChoice = Rabbit Then
            lblDraw.Visible = False
            lblWin.Visible = True
            lblLost.Visible = False
            lblEnemy.Text = "Rabbit"
            lblPScore.Text += 1
        ElseIf rdGun.Checked And comChoice = Carrot Then
            lblDraw.Visible = False
            lblWin.Visible = False
            lblLost.Visible = True
            lblEnemy.Text = "Carrot"
            lblEScore.Text += 1

        ElseIf rdGun.Checked And comChoice = Gun Then
            lblWin.Visible = False
            lblDraw.Visible = True
            lblLost.Visible = False
            lblEnemy.Text = "Gun"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StartPage.Show()
        Me.Hide()
    End Sub
End Class