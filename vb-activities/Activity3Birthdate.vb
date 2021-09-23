Public Class activity3
    Private Sub btncalc_Click(sender As Object, e As EventArgs) Handles btncalc.Click
        Dim age
        Dim year
        Dim answer
        year = txtyear.Text
        age = txtage.Text
        answer = year - age
        MessageBox.Show("You were born in " & answer & "!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StartPage.Show()
        Me.Hide()
    End Sub
End Class