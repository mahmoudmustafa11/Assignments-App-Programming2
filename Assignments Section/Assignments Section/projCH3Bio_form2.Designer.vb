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
        Dim ListViewItem17 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("HTML")
        Dim ListViewItem18 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("CSS")
        Dim ListViewItem19 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Javascript")
        Dim ListViewItem20 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("vb")
        Me.tab_bio = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_font = New System.Windows.Forms.Button()
        Me.bioText_lbl = New System.Windows.Forms.Label()
        Me.bio_lbl = New System.Windows.Forms.Label()
        Me.btn_backColor = New System.Windows.Forms.Button()
        Me.btn_img = New System.Windows.Forms.Button()
        Me.btn_sFile = New System.Windows.Forms.Button()
        Me.lbl_skill = New System.Windows.Forms.Label()
        Me.listview_skill = New System.Windows.Forms.ListView()
        Me.tab_printSetting = New System.Windows.Forms.TabPage()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.btn_preview = New System.Windows.Forms.Button()
        Me.btn_configure = New System.Windows.Forms.Button()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.tab_bio.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_printSetting.SuspendLayout()
        Me.SuspendLayout()
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
        Me.tab_bio.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.btn_font)
        Me.TabPage1.Controls.Add(Me.bioText_lbl)
        Me.TabPage1.Controls.Add(Me.bio_lbl)
        Me.TabPage1.Controls.Add(Me.btn_backColor)
        Me.TabPage1.Controls.Add(Me.btn_img)
        Me.TabPage1.Controls.Add(Me.btn_sFile)
        Me.TabPage1.Controls.Add(Me.lbl_skill)
        Me.TabPage1.Controls.Add(Me.listview_skill)
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
        'bioText_lbl
        '
        Me.bioText_lbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bioText_lbl.AutoSize = True
        Me.bioText_lbl.Font = New System.Drawing.Font("Sitka Small", 14.0!, System.Drawing.FontStyle.Bold)
        Me.bioText_lbl.Location = New System.Drawing.Point(16, 44)
        Me.bioText_lbl.Name = "bioText_lbl"
        Me.bioText_lbl.Size = New System.Drawing.Size(741, 252)
        Me.bioText_lbl.TabIndex = 17
        Me.bioText_lbl.Text = resources.GetString("bioText_lbl.Text")
        '
        'bio_lbl
        '
        Me.bio_lbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bio_lbl.AutoSize = True
        Me.bio_lbl.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bio_lbl.ForeColor = System.Drawing.Color.DimGray
        Me.bio_lbl.Location = New System.Drawing.Point(20, 15)
        Me.bio_lbl.Name = "bio_lbl"
        Me.bio_lbl.Size = New System.Drawing.Size(78, 16)
        Me.bio_lbl.TabIndex = 16
        Me.bio_lbl.Text = "About me"
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
        'lbl_skill
        '
        Me.lbl_skill.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_skill.AutoSize = True
        Me.lbl_skill.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_skill.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_skill.Location = New System.Drawing.Point(20, 343)
        Me.lbl_skill.Name = "lbl_skill"
        Me.lbl_skill.Size = New System.Drawing.Size(45, 16)
        Me.lbl_skill.TabIndex = 25
        Me.lbl_skill.Text = "Skills"
        '
        'listview_skill
        '
        Me.listview_skill.Font = New System.Drawing.Font("Sitka Small", 10.0!, System.Drawing.FontStyle.Bold)
        Me.listview_skill.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem17, ListViewItem18, ListViewItem19, ListViewItem20})
        Me.listview_skill.Location = New System.Drawing.Point(23, 373)
        Me.listview_skill.Name = "listview_skill"
        Me.listview_skill.Size = New System.Drawing.Size(170, 150)
        Me.listview_skill.TabIndex = 24
        Me.listview_skill.UseCompatibleStateImageBehavior = False
        Me.listview_skill.View = System.Windows.Forms.View.SmallIcon
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
        'PageSetupDialog1
        '
        Me.PageSetupDialog1.Document = Me.PrintDocument1
        '
        'PrintDocument1
        '
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
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "mahmoud"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bio"
        Me.tab_bio.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_printSetting.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab_bio As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_font As System.Windows.Forms.Button
    Friend WithEvents bioText_lbl As System.Windows.Forms.Label
    Friend WithEvents bio_lbl As System.Windows.Forms.Label
    Friend WithEvents btn_backColor As System.Windows.Forms.Button
    Friend WithEvents btn_img As System.Windows.Forms.Button
    Friend WithEvents btn_sFile As System.Windows.Forms.Button
    Friend WithEvents lbl_skill As System.Windows.Forms.Label
    Friend WithEvents listview_skill As System.Windows.Forms.ListView
    Friend WithEvents tab_printSetting As System.Windows.Forms.TabPage
    Friend WithEvents btn_print As System.Windows.Forms.Button
    Friend WithEvents btn_preview As System.Windows.Forms.Button
    Friend WithEvents btn_configure As System.Windows.Forms.Button
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
End Class
