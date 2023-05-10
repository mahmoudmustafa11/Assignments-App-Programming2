Imports Microsoft.Office.Interop.PowerPoint

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pptApp As New Application
        Dim file_path As String = System.IO.Directory.GetCurrentDirectory

        MsgBox("Wait for the powerpoint file to open")

        Dim pptPresentation As Presentation = pptApp.Presentations.Open(file_path + "\powerpoint\task.ppsm")


        pptPresentation.SlideShowSettings.Run()

    End Sub

End Class
