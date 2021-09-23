Public Class Activity9CoolColours
    Private Sub cbBackground_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBackground.SelectedIndexChanged
        If cbBackground.Text = "Black" Then
            lblChange.ForeColor = Color.Black
        End If
        If cbBackground.Text = "White" Then
            lblChange.ForeColor = Color.White
        End If
        If cbBackground.Text = "Green" Then
            lblChange.ForeColor = Color.Green
        End If
        If cbBackground.Text = "Blue" Then
            lblChange.ForeColor = Color.Blue
        End If
        If cbBackground.Text = "Red" Then
            lblChange.ForeColor = Color.Red
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbBackground.SelectedIndexChanged
        If lbBackground.Text = "Black" Then
            BackColor = Color.Black
        End If
        If lbBackground.Text = "White" Then
            BackColor = Color.White
        End If
        If lbBackground.Text = "Green" Then
            BackColor = Color.Green
        End If
        If lbBackground.Text = "Red" Then
            BackColor = Color.Red
        End If
        If lbBackground.Text = "Blue" Then
            BackColor = Color.Blue
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        StartPage.Show()
        Me.Hide()
    End Sub

    Private Sub rdComic_CheckedChanged(sender As Object, e As EventArgs) Handles rdComic.CheckedChanged
        If rdComic.Checked Then
            lblChange.Font = New Font("Comic Sans", 20)
        End If
    End Sub

    Private Sub rdSansSerif_CheckedChanged(sender As Object, e As EventArgs) Handles rdSansSerif.CheckedChanged
        If rdSansSerif.Checked Then
            lblChange.Font = New Font("Sans Serif", 5)
        End If
    End Sub

    Private Sub rdPapayrus_CheckedChanged(sender As Object, e As EventArgs) Handles rdPapayrus.CheckedChanged
        If rdPapayrus.Checked Then
            lblChange.Font = New Font("Papayrus", 14)
        End If
    End Sub
End Class