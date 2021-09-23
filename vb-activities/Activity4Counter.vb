Public Class activity4
    Dim count As Integer
    Private Sub btncount_Click(sender As Object, e As EventArgs) Handles btncount.Click
        count = count + 1
        lblcount.Text = count
    End Sub

    Private Sub btncountminus_Click(sender As Object, e As EventArgs) Handles btncountminus.Click
        count = count - 1
        lblcount.Text = count
    End Sub

    Private Sub btncount2_Click(sender As Object, e As EventArgs) Handles btncount2.Click
        count = count + 2
        lblcount.Text = count
    End Sub

    Private Sub btncount5_Click(sender As Object, e As EventArgs) Handles btncount5.Click
        count = count + 5
        lblcount.Text = count
    End Sub

    Private Sub btncount0_Click(sender As Object, e As EventArgs) Handles btncount0.Click
        count = 0
        lblcount.Text = count
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StartPage.Show()
        Me.Hide()
    End Sub
End Class