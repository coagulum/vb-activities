Public Class Activity11Linking

    Public name As String
    Public number As String
    Public cost As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StartPage.Show()
        Me.Hide()
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        cost = 10
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        cost = 30
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        name = tbName.Text
        number = tbNumber.Text

        Receipt.lblName.Text = name
        Receipt.lblNumber.Text = number
        Receipt.lblCost.Text = "$" + cost

        Receipt.Show()
        Me.Hide()
    End Sub
End Class