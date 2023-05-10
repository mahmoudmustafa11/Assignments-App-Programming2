Public Class fileSystemWatcher_form

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Start" Then
            FileSystemWatcher1.EnableRaisingEvents = True
            Button1.Text = "Stop"

            Label1.Text = "اذهب للقرص C وعدل ف اي ملف امتداده txt " & vbCrLf & " ليظهر التغيير في ListBox"
        Else
            FileSystemWatcher1.EnableRaisingEvents = False
            Button1.Text = "Start"
            Label1.Text = ""
        End If
    End Sub

    Private Sub fileSystemWatcher_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileSystemWatcher1.Path = "c:\"
        FileSystemWatcher1.IncludeSubdirectories = False
        FileSystemWatcher1.Filter = "*.txt"
        FileSystemWatcher1.NotifyFilter =
            IO.NotifyFilters.CreationTime Or
            IO.NotifyFilters.LastWrite Or
            IO.NotifyFilters.LastAccess Or
            IO.NotifyFilters.FileName
        FileSystemWatcher1.EnableRaisingEvents = False
    End Sub

    Private Sub watcher(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Changed,
                                                                                                  FileSystemWatcher1.Created,
                                                                                                  FileSystemWatcher1.Deleted

        ListBox1.Items.Add(e.ChangeType & vbTab & e.FullPath)
    End Sub

    Private Sub FileSystemWatcher1_Renamed(sender As Object, e As IO.RenamedEventArgs) Handles FileSystemWatcher1.Renamed
        ListBox1.Items.Add(e.ChangeType & "    " & e.OldFullPath & " To " & e.FullPath)
    End Sub

End Class