<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_apps
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
        Me.btn_studentsGrades = New System.Windows.Forms.Button()
        Me.btn_arrRndEl = New System.Windows.Forms.Button()
        Me.btn_arrTwoDimentions = New System.Windows.Forms.Button()
        Me.btn_arrCopy = New System.Windows.Forms.Button()
        Me.btn_arrSort = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_studentsGrades
        '
        Me.btn_studentsGrades.BackColor = System.Drawing.Color.DimGray
        Me.btn_studentsGrades.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_studentsGrades.FlatAppearance.BorderSize = 0
        Me.btn_studentsGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_studentsGrades.Font = New System.Drawing.Font("PT Separated Baloon", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_studentsGrades.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_studentsGrades.Location = New System.Drawing.Point(59, 42)
        Me.btn_studentsGrades.Name = "btn_studentsGrades"
        Me.btn_studentsGrades.Size = New System.Drawing.Size(333, 47)
        Me.btn_studentsGrades.TabIndex = 6
        Me.btn_studentsGrades.Text = "Students Grades"
        Me.btn_studentsGrades.UseVisualStyleBackColor = False
        '
        'btn_arrRndEl
        '
        Me.btn_arrRndEl.BackColor = System.Drawing.Color.DimGray
        Me.btn_arrRndEl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_arrRndEl.FlatAppearance.BorderSize = 0
        Me.btn_arrRndEl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_arrRndEl.Font = New System.Drawing.Font("PT Separated Baloon", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_arrRndEl.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_arrRndEl.Location = New System.Drawing.Point(59, 124)
        Me.btn_arrRndEl.Name = "btn_arrRndEl"
        Me.btn_arrRndEl.Size = New System.Drawing.Size(333, 47)
        Me.btn_arrRndEl.TabIndex = 7
        Me.btn_arrRndEl.Text = "Array RandomEl"
        Me.btn_arrRndEl.UseVisualStyleBackColor = False
        '
        'btn_arrTwoDimentions
        '
        Me.btn_arrTwoDimentions.BackColor = System.Drawing.Color.DimGray
        Me.btn_arrTwoDimentions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_arrTwoDimentions.FlatAppearance.BorderSize = 0
        Me.btn_arrTwoDimentions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_arrTwoDimentions.Font = New System.Drawing.Font("PT Separated Baloon", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_arrTwoDimentions.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_arrTwoDimentions.Location = New System.Drawing.Point(59, 206)
        Me.btn_arrTwoDimentions.Name = "btn_arrTwoDimentions"
        Me.btn_arrTwoDimentions.Size = New System.Drawing.Size(333, 47)
        Me.btn_arrTwoDimentions.TabIndex = 8
        Me.btn_arrTwoDimentions.Text = "Array Two Dimentions"
        Me.btn_arrTwoDimentions.UseVisualStyleBackColor = False
        '
        'btn_arrCopy
        '
        Me.btn_arrCopy.BackColor = System.Drawing.Color.DimGray
        Me.btn_arrCopy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_arrCopy.FlatAppearance.BorderSize = 0
        Me.btn_arrCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_arrCopy.Font = New System.Drawing.Font("PT Separated Baloon", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_arrCopy.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_arrCopy.Location = New System.Drawing.Point(59, 288)
        Me.btn_arrCopy.Name = "btn_arrCopy"
        Me.btn_arrCopy.Size = New System.Drawing.Size(333, 47)
        Me.btn_arrCopy.TabIndex = 9
        Me.btn_arrCopy.Text = "Array Copy"
        Me.btn_arrCopy.UseVisualStyleBackColor = False
        '
        'btn_arrSort
        '
        Me.btn_arrSort.BackColor = System.Drawing.Color.DimGray
        Me.btn_arrSort.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_arrSort.FlatAppearance.BorderSize = 0
        Me.btn_arrSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_arrSort.Font = New System.Drawing.Font("PT Separated Baloon", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_arrSort.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_arrSort.Location = New System.Drawing.Point(59, 370)
        Me.btn_arrSort.Name = "btn_arrSort"
        Me.btn_arrSort.Size = New System.Drawing.Size(333, 47)
        Me.btn_arrSort.TabIndex = 10
        Me.btn_arrSort.Text = "Array Sort"
        Me.btn_arrSort.UseVisualStyleBackColor = False
        '
        'form_apps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(460, 481)
        Me.Controls.Add(Me.btn_arrSort)
        Me.Controls.Add(Me.btn_arrCopy)
        Me.Controls.Add(Me.btn_arrTwoDimentions)
        Me.Controls.Add(Me.btn_arrRndEl)
        Me.Controls.Add(Me.btn_studentsGrades)
        Me.Name = "form_apps"
        Me.ShowIcon = False
        Me.Text = "Apps"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_studentsGrades As System.Windows.Forms.Button
    Friend WithEvents btn_arrRndEl As System.Windows.Forms.Button
    Friend WithEvents btn_arrTwoDimentions As System.Windows.Forms.Button
    Friend WithEvents btn_arrCopy As System.Windows.Forms.Button
    Friend WithEvents btn_arrSort As System.Windows.Forms.Button
End Class
