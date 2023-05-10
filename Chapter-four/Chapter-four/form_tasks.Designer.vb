<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_tasks
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
        Me.btn_subtrack = New System.Windows.Forms.Button()
        Me.btn_multiple = New System.Windows.Forms.Button()
        Me.btn_multiDimentions = New System.Windows.Forms.Button()
        Me.btn_sortDescending = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_subtrack
        '
        Me.btn_subtrack.BackColor = System.Drawing.Color.DimGray
        Me.btn_subtrack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_subtrack.FlatAppearance.BorderSize = 0
        Me.btn_subtrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_subtrack.Font = New System.Drawing.Font("PT Separated Baloon", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_subtrack.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_subtrack.Location = New System.Drawing.Point(85, 39)
        Me.btn_subtrack.Name = "btn_subtrack"
        Me.btn_subtrack.Size = New System.Drawing.Size(333, 47)
        Me.btn_subtrack.TabIndex = 2
        Me.btn_subtrack.Text = "Subtract twoArrays"
        Me.btn_subtrack.UseVisualStyleBackColor = False
        '
        'btn_multiple
        '
        Me.btn_multiple.BackColor = System.Drawing.Color.DimGray
        Me.btn_multiple.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_multiple.FlatAppearance.BorderSize = 0
        Me.btn_multiple.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_multiple.Font = New System.Drawing.Font("PT Separated Baloon", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_multiple.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_multiple.Location = New System.Drawing.Point(85, 129)
        Me.btn_multiple.Name = "btn_multiple"
        Me.btn_multiple.Size = New System.Drawing.Size(333, 47)
        Me.btn_multiple.TabIndex = 3
        Me.btn_multiple.Text = "Multiple twoArrays"
        Me.btn_multiple.UseVisualStyleBackColor = False
        '
        'btn_multiDimentions
        '
        Me.btn_multiDimentions.BackColor = System.Drawing.Color.DimGray
        Me.btn_multiDimentions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_multiDimentions.FlatAppearance.BorderSize = 0
        Me.btn_multiDimentions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_multiDimentions.Font = New System.Drawing.Font("PT Separated Baloon", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_multiDimentions.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_multiDimentions.Location = New System.Drawing.Point(85, 219)
        Me.btn_multiDimentions.Name = "btn_multiDimentions"
        Me.btn_multiDimentions.Size = New System.Drawing.Size(333, 47)
        Me.btn_multiDimentions.TabIndex = 4
        Me.btn_multiDimentions.Text = "Multi dimentions"
        Me.btn_multiDimentions.UseVisualStyleBackColor = False
        '
        'btn_sortDescending
        '
        Me.btn_sortDescending.BackColor = System.Drawing.Color.DimGray
        Me.btn_sortDescending.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sortDescending.FlatAppearance.BorderSize = 0
        Me.btn_sortDescending.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sortDescending.Font = New System.Drawing.Font("PT Separated Baloon", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_sortDescending.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_sortDescending.Location = New System.Drawing.Point(85, 309)
        Me.btn_sortDescending.Name = "btn_sortDescending"
        Me.btn_sortDescending.Size = New System.Drawing.Size(333, 47)
        Me.btn_sortDescending.TabIndex = 5
        Me.btn_sortDescending.Text = "Sort Array descending"
        Me.btn_sortDescending.UseVisualStyleBackColor = False
        '
        'form_tasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(501, 418)
        Me.Controls.Add(Me.btn_sortDescending)
        Me.Controls.Add(Me.btn_multiDimentions)
        Me.Controls.Add(Me.btn_multiple)
        Me.Controls.Add(Me.btn_subtrack)
        Me.Name = "form_tasks"
        Me.ShowIcon = False
        Me.Text = "Tasks"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_subtrack As System.Windows.Forms.Button
    Friend WithEvents btn_multiple As System.Windows.Forms.Button
    Friend WithEvents btn_multiDimentions As System.Windows.Forms.Button
    Friend WithEvents btn_sortDescending As System.Windows.Forms.Button
End Class
