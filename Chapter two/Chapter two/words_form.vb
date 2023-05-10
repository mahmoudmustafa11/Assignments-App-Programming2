Public Class words_form

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.DefaultExt = "TXT"
        OpenFileDialog1.Filter = "Text|*.TXT|All Files|*.*"
        OpenFileDialog1.FileName = "words.txt"
        OpenFileDialog1.ShowDialog()
        Dim txtLine As String = ""
        Dim words() As String
        Dim Delimiters() As Char = {CType(" ", Char), CType("", Char), CType(".", Char),
                                    CType(".", Char), CType("*", Char), CType("!", Char),
                                    CType(":", Char), CType(":", Char), Chr(10), Chr(13)}
        Try
            If OpenFileDialog1.FileName = "" Then Exit Sub
            FileOpen(1, OpenFileDialog1.FileName, OpenMode.Input)

            Do Until EOF(1)
                Input(1, txtLine)
                words = txtLine.Split(Delimiters)

                Dim word As String
                For i = 0 To words.Length - 1
                    word = words(i).ToUpper
                    ListBox1.Items.Add(word)
                Next
            Loop
            FileClose(1)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class