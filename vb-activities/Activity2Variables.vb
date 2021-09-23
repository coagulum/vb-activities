Public Class activity2
    Dim username As String
    Dim userplace As String
    Dim userage As String

    Private Sub btnname_Click(sender As Object, e As EventArgs) Handles btnname.Click
        username = txtname.Text
        lblgreeting.Text = "Ciao " + username + ", di dove sei?"
        lblgreeting.Visible = True
        txtplace.Visible = True
        btnplace.Visible = True
    End Sub

    Private Sub btnplace_Click(sender As Object, e As EventArgs) Handles btnplace.Click
        userplace = txtplace.Text
        lblplace.Text = "Io sonno di " + userplace + " pure! Quanti anni hai?"
        lblplace.Visible = True
        txtage.Visible = True
        btnage.Visible = True
    End Sub

    Private Sub btnage_Click(sender As Object, e As EventArgs) Handles btnage.Click
        userage = txtage.Text
        MessageBox.Show("GRANDE " & userage & "!")
    End Sub

    Private Sub btnback1_Click(sender As Object, e As EventArgs) Handles btnback1.Click
        StartPage.Show()
        Me.Hide()
    End Sub
End Class