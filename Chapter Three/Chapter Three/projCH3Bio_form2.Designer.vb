<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class projCH3Bio_form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(projCH3Bio_form2))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("HTML")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("CSS")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Javascript")
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("vb")
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_font = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_backColor = New System.Windows.Forms.Button()
        Me.btn_img = New System.Windows.Forms.Button()
        Me.btn_sFile = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.btn_preview = New System.Windows.Forms.Button()
        Me.btn_configure = New System.Windows.Forms.Button()
        Me.tab_printSetting = New System.Windows.Forms.TabPage()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.tab_bio = New System.Windows.Forms.TabControl()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_printSetting.SuspendLayout()
        Me.tab_bio.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.btn_font)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btn_backColor)
        Me.TabPage1.Controls.Add(Me.btn_img)
        Me.TabPage1.Controls.Add(Me.btn_sFile)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.ListView1)
        Me.TabPage1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TabPage1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(947, 699)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "BIO"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(646, 299)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(221, 257)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'btn_font
        '
        Me.btn_font.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_font.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_font.Font = New System.Drawing.Font("Sitka Small", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_font.Location = New System.Drawing.Point(475, 634)
        Me.btn_font.Name = "btn_font"
        Me.btn_font.Size = New System.Drawing.Size(201, 57)
        Me.btn_font.TabIndex = 18
        Me.btn_font.Text = "Font change"
        Me.btn_font.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Small", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(16, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(741, 252)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(20, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "About me"
        '
        'btn_backColor
        '
        Me.btn_backColor.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_backColor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_backColor.Font = New System.Drawing.Font("Sitka Small", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_backColor.Location = New System.Drawing.Point(264, 634)
        Me.btn_backColor.Name = "btn_backColor"
        Me.btn_backColor.Size = New System.Drawing.Size(201, 57)
        Me.btn_backColor.TabIndex = 19
        Me.btn_backColor.Text = "BackColor change"
        Me.btn_backColor.UseVisualStyleBackColor = True
        '
        'btn_img
        '
        Me.btn_img.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_img.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_img.Font = New System.Drawing.Font("Sitka Small", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_img.Location = New System.Drawing.Point(53, 634)
        Me.btn_img.Name = "btn_img"
        Me.btn_img.Size = New System.Drawing.Size(201, 57)
        Me.btn_img.TabIndex = 22
        Me.btn_img.Text = "Image load"
        Me.btn_img.UseVisualStyleBackColor = True
        '
        'btn_sFile
        '
        Me.btn_sFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_sFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sFile.Font = New System.Drawing.Font("Sitka Small", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_sFile.Location = New System.Drawing.Point(686, 634)
        Me.btn_sFile.Name = "btn_sFile"
        Me.btn_sFile.Size = New System.Drawing.Size(201, 57)
        Me.btn_sFile.TabIndex = 20
        Me.btn_sFile.Text = "Save File"
        Me.btn_sFile.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(20, 343)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Skills"
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("Sitka Small", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4})
        Me.ListView1.Location = New System.Drawing.Point(23, 373)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(170, 150)
        Me.ListView1.TabIndex = 24
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.SmallIcon
        '
        'PageSetupDialog1
        '
        Me.PageSetupDialog1.Document = Me.PrintDocument1
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "mahmoud"
        '
        'btn_print
        '
        Me.btn_print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_print.Font = New System.Drawing.Font("Sitka Small", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_print.Location = New System.Drawing.Point(555, 71)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(189, 57)
        Me.btn_print.TabIndex = 14
        Me.btn_print.Text = "print"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'btn_preview
        '
        Me.btn_preview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_preview.Font = New System.Drawing.Font("Sitka Small", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_preview.Location = New System.Drawing.Point(323, 71)
        Me.btn_preview.Name = "btn_preview"
        Me.btn_preview.Size = New System.Drawing.Size(189, 57)
        Me.btn_preview.TabIndex = 13
        Me.btn_preview.Text = "preview"
        Me.btn_preview.UseVisualStyleBackColor = True
        '
        'btn_configure
        '
        Me.btn_configure.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_configure.Font = New System.Drawing.Font("Sitka Small", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_configure.Location = New System.Drawing.Point(102, 71)
        Me.btn_configure.Name = "btn_configure"
        Me.btn_configure.Size = New System.Drawing.Size(189, 57)
        Me.btn_configure.TabIndex = 12
        Me.btn_configure.Text = "configuration of"
        Me.btn_configure.UseVisualStyleBackColor = True
        '
        'tab_printSetting
        '
        Me.tab_printSetting.BackColor = System.Drawing.Color.Silver
        Me.tab_printSetting.Controls.Add(Me.btn_print)
        Me.tab_printSetting.Controls.Add(Me.btn_preview)
        Me.tab_printSetting.Controls.Add(Me.btn_configure)
        Me.tab_printSetting.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.tab_printSetting.Location = New System.Drawing.Point(4, 22)
        Me.tab_printSetting.Name = "tab_printSetting"
        Me.tab_printSetting.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_printSetting.Size = New System.Drawing.Size(947, 699)
        Me.tab_printSetting.TabIndex = 1
        Me.tab_printSetting.Text = "Print setting"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'tab_bio
        '
        Me.tab_bio.Controls.Add(Me.TabPage1)
        Me.tab_bio.Controls.Add(Me.tab_printSetting)
        Me.tab_bio.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tab_bio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab_bio.Location = New System.Drawing.Point(0, 0)
        Me.tab_bio.Name = "tab_bio"
        Me.tab_bio.SelectedIndex = 0
        Me.tab_bio.Size = New System.Drawing.Size(955, 725)
        Me.tab_bio.TabIndex = 1
        '
        'projCH3Bio_form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(955, 725)
        Me.Controls.Add(Me.tab_bio)
        Me.Name = "projCH3Bio_form2"
        Me.ShowIcon = False
        Me.Text = "Bio"
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_printSetting.ResumeLayout(False)
        Me.tab_bio.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_font As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_backColor As System.Windows.Forms.Button
    Friend WithEvents btn_img As System.Windows.Forms.Button
    Friend WithEvents btn_sFile As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents btn_print As System.Windows.Forms.Button
    Friend WithEvents btn_preview As System.Windows.Forms.Button
    Friend WithEvents btn_configure As System.Windows.Forms.Button
    Friend WithEvents tab_printSetting As System.Windows.Forms.TabPage
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents tab_bio As System.Windows.Forms.TabControl
End Class
