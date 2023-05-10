Imports System.IO
Imports System.Windows.Forms

Public Class projCH3Bio_form2
    Public Shared fontpro As Font, backColorV As Color, img_filename As String


    Private Sub btn_img_Click(sender As Object, e As EventArgs) Handles btn_img.Click
        With OpenFileDialog1
            .Filter = "Images|*.JPG|*.GIF|*.PNG|*.TIFF|*.BMP|*.JPEG|"
            If .ShowDialog() = DialogResult.OK Then
                PictureBox1.Image = Image.FromFile(.FileName)
                img_filename = .FileName
            End If
        End With
    End Sub

    Private Sub btn_backColor_Click(sender As Object, e As EventArgs) Handles btn_backColor.Click
        With ColorDialog1
            .SolidColorOnly = True
            If .ShowDialog = DialogResult.OK Then
                TabPage1.BackColor = .Color
                listview_skill.BackColor = .Color
                backColorV = .Color
            End If
        End With
    End Sub

    Private Sub btn_font_Click(sender As Object, e As EventArgs) Handles btn_font.Click
        With FontDialog1
            .ShowApply = True
            If .ShowDialog = DialogResult.OK Then
                bio_lbl.Font = .Font
                bioText_lbl.Font = .Font
                lbl_skill.Font = .Font
                listview_skill.Font = .Font
            End If
            fontpro = .Font
        End With
    End Sub

    Private Sub btn_sFile_Click(sender As Object, e As EventArgs) Handles btn_sFile.Click
        With SaveFileDialog1
            .Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            .InitialDirectory = "D:\"
            If .ShowDialog() = DialogResult.OK Then
                Dim fileName As String = .FileName
                Dim fileContent As String = bioText_lbl.Text
                File.WriteAllText(fileName, fileContent)
            End If
        End With
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim back_Color_Document As New SolidBrush(backColorV)
        Dim bmp As New Bitmap(150, 150)
        listview_skill.DrawToBitmap(bmp, New Rectangle(0, 0, 150, 150))

        Try
            e.Graphics.FillRectangle(back_Color_Document, 0, 0, e.PageBounds.Width, e.PageBounds.Height)
            e.Graphics.DrawString(bio_lbl.Text, New Font(fontpro.Name, fontpro.Size, fontpro.Style), Brushes.DimGray, 12, 20)
            e.Graphics.DrawString(bioText_lbl.Text, New Font(fontpro.Name, fontpro.Size, fontpro.Style), Brushes.Black, 12, 60)
            e.Graphics.DrawString(lbl_skill.Text, New Font(fontpro.Name, fontpro.Size, fontpro.Style), Brushes.DimGray, 12, 400)
            e.Graphics.DrawImage(bmp, 12, 450, 150, 150)
        Catch ex As Exception
            MsgBox("Select Font property")
            Exit Sub
        End Try

        If File.Exists(img_filename) Then
            e.Graphics.DrawImage(PictureBox1.Image, 400, 400, 400, 500)
        End If
    End Sub

    Private Sub btn_configure_Click(sender As Object, e As EventArgs) Handles btn_configure.Click
        PageSetupDialog1.ShowDialog()
    End Sub

    Private Sub btn_preview_Click(sender As Object, e As EventArgs) Handles btn_preview.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub projCH3Bio_form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close this form?", "Confirm Close", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
End Class