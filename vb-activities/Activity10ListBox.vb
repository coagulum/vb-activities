Public Class Activity10ListBox
    Dim answer
    Dim correct
    Private Sub btnAdd1_Click(sender As Object, e As EventArgs) Handles btnAdd1.Click
        lbValues.Items.Add("1")
    End Sub

    Private Sub btnSub1_Click(sender As Object, e As EventArgs) Handles btnSub1.Click
        lbValues.Items.Remove("1")
    End Sub

    Private Sub btnAdd10_Click(sender As Object, e As EventArgs) Handles btnAdd10.Click
        lbValues.Items.Add("10")
    End Sub

    Private Sub btnRem10_Click(sender As Object, e As EventArgs) Handles btnRem10.Click
        lbValues.Items.Remove("10")
    End Sub

    Private Sub btnAdd100_Click(sender As Object, e As EventArgs) Handles btnAdd100.Click
        lbValues.Items.Add("100")
    End Sub

    Private Sub btnRem100_Click(sender As Object, e As EventArgs) Handles btnRem100.Click
        lbValues.Items.Remove("100")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lbValues.Items.Add("1000")
    End Sub

    Private Sub btnRem1000_Click(sender As Object, e As EventArgs) Handles btnRem1000.Click
        lbValues.Items.Remove("1000")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Total As Integer

        For Each Str As String In lbValues.Items
            Total = Total + CInt(Str)
        Next
        lblTotal.Text = Total
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        StartPage.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim multiTotal As Integer
        For TotalMulti = 0 To lbValues.Items.Count
            multiTotal = lbValues.Items(TotalMulti) * lbValues.Items(TotalMulti + 1)
        Next
    End Sub
End Class