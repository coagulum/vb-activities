Public Class activity6
    Dim size As Integer
    Dim age As Integer
    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Size = cmbsize.Text
        age = txtold.Text

        If size = 2 And age < 12 Or size = 3 And age < 12 Or size = 4 And age < 15 Then
            MessageBox.Show("too heavy mate")
        ElseIf size = 0 And age < 10 Then
            MessageBox.Show("play videogames, not work")
        Else
            MessageBox.Show("All good!")
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StartPage.Show()
        Me.Hide()
    End Sub
End Class