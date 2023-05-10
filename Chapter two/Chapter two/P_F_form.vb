Public Class P_F_form

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FolderBrowserDialog1.ShowDialog()
        Dim path As String = FolderBrowserDialog1.SelectedPath
        Dim items() As String

        If FolderBrowserDialog1.SelectedPath = "" Then Exit Sub
        items = System.IO.Directory.GetFileSystemEntries(path)
        Dim itm As String
        For Each itm In items
            If System.IO.Directory.Exists(itm) Then
                ListBox1.Items.Add("Folder : " & itm)
            Else
                ListBox1.Items.Add("File : " & itm)
            End If
        Next
    End Sub
End Class