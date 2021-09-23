Public Class activity1
    Private Sub btnhello_Click(sender As Object, e As EventArgs) Handles btndanger.Click
        MessageBox.Show("CURSED FOR 10 SECONDS!")
    End Sub

    Private Sub btnGood_Click(sender As Object, e As EventArgs) Handles btnGood.Click
        MessageBox.Show("GOOD LUCK FOR 10 SECONDS!")
    End Sub

    Private Sub btnnext1_Click(sender As Object, e As EventArgs) Handles btnnext1.Click
        StartPage.Show()
        Me.Hide()
    End Sub
End Class
