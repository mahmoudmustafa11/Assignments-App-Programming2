Public Class Form_Main

    Sub MdiContainerInForm()

        Dim frmChild As New ismdicontainer_form
        Dim fc2 As New ismdicontainer_form
        ismdicontainer_form.IsMdiContainer = True
        frmChild.MdiParent = ismdicontainer_form
        fc2.MdiParent = ismdicontainer_form
        frmChild.Text = "Child Form"
        fc2.Text = "Child Form"
        frmChild.Show()
        fc2.Show()
        ismdicontainer_form.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dynamic_form.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = True
        ismdicontainer_form.Show()
        
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static i As Integer
        i = i + 1
        If i = 2 Then
            MdiContainerInForm()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim b As Control
        Dim counter As Integer = 0
        For Each b In Me.Controls
            If b.GetType Is GetType(Button) Then
                counter += 1
            End If
        Next

        MsgBox(counter)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        projCH3_form1.Show()
    End Sub
End Class
