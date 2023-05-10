Public Class Form1

    Private Sub btn_inputData_Click(sender As Object, e As EventArgs) Handles btn_inputData.Click
        Dim filePath As String = System.IO.Directory.GetCurrentDirectory + "\assests\input_data.txt"

        FileOpen(1, filePath, OpenMode.Output)
        For i = 1 To 20
            Write(1, i)
        Next
        FileClose(1)

    End Sub

    Private Sub btn_appendData_Click(sender As Object, e As EventArgs) Handles btn_appendData.Click
        Dim filePath As String = System.IO.Directory.GetCurrentDirectory + "\assests\input_data.txt"

        FileOpen(1, filePath, OpenMode.Append)
        For i = 21 To 40
            Write(1, i)
        Next
        FileClose(1)

    End Sub

    Private Sub btn_outputData_Click(sender As Object, e As EventArgs) Handles btn_outputData.Click
        Dim filePath As String = System.IO.Directory.GetCurrentDirectory + "\assests\input_data.txt"
        Dim result As String = "", cont As String
        FileOpen(1, filePath, OpenMode.Input)

        While Not EOF(1)
            Input(1, cont)
            result += cont + vbCrLf
        End While

        If result = "" Then
            MsgBox("File not Content")
            FileClose(1)
        Else
            MsgBox(result)
            FileClose(1)
        End If
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        words_form.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        P_F_form.Show()
    End Sub

    Private Sub btn_fileSystemWatcher_Click(sender As Object, e As EventArgs) Handles btn_fileSystemWatcher.Click
        fileSystemWatcher_form.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        printVerbs_form.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DesktopLocation = New Point(200, 30)
    End Sub
End Class
