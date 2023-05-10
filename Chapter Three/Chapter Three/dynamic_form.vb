Public Class dynamic_form

    Sub dynamicForm()
        Dim addBtn As New Button
        addBtn.Text = "New Button"
        addBtn.Top = 200
        addBtn.Left = 100
        addBtn.Width = 200
        addBtn.Height = 90
        addBtn.Cursor = Cursors.Hand
        addBtn.Font = New Font("Trebuchet MS", 18, FontStyle.Bold Or FontStyle.Italic)
        Me.Controls.Add(addBtn)

        AddHandler addBtn.Click, New System.EventHandler(AddressOf addBtn_Load)
    End Sub

    Sub addBtn_Load(sender As Object, e As EventArgs)
        MsgBox("YET")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static i As Integer
        i = i + 1
        If i = 2 Then
            dynamicForm()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub dynamic_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
End Class