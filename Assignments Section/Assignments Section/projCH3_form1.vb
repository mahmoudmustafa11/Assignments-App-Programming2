Public Class projCH3_form1

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim username, password As String
        username = TextBox1.Text.ToLower
        password = TextBox2.Text.ToLower
        If username = "mahmoudmostafa11199" Then
            If password = "2210" Then
                ErrorProvider1.SetError(TextBox2, "")
                Timer1.Enabled = True
            Else
                ErrorProvider1.SetError(TextBox2, "Password is incorrect    2210")
            End If
            ErrorProvider1.SetError(TextBox1, "")
        Else
            ErrorProvider1.SetError(TextBox1, "Username is incorrect    mahmoudmostafa11199")
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Timer2.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 30
        If ProgressBar1.Value = 1000 Then
            projCH3Bio_form2.Show()
            Me.Hide()
            Timer1.Enabled = False
            ProgressBar1.Value = 10
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar1.Value = ProgressBar1.Value + 30
        If ProgressBar1.Value = 1000 Then
            System.Diagnostics.Process.Start("https://login-mahmoud.netlify.app/signup.html")
            Timer2.Enabled = False
            ProgressBar1.Value = 10
        End If
    End Sub
End Class