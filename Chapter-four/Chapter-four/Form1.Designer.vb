<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_apply = New System.Windows.Forms.Button()
        Me.btn_tasks = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Simple Bold Jut Out", 16.0!)
        Me.Label1.Location = New System.Drawing.Point(74, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "تطبيقات وتاسكات الباب الرابع"
        '
        'btn_apply
        '
        Me.btn_apply.BackColor = System.Drawing.Color.DimGray
        Me.btn_apply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_apply.FlatAppearance.BorderSize = 0
        Me.btn_apply.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_apply.Font = New System.Drawing.Font("PT Separated Baloon", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_apply.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_apply.Location = New System.Drawing.Point(48, 127)
        Me.btn_apply.Name = "btn_apply"
        Me.btn_apply.Size = New System.Drawing.Size(144, 47)
        Me.btn_apply.TabIndex = 1
        Me.btn_apply.Text = "Apps"
        Me.btn_apply.UseVisualStyleBackColor = False
        '
        'btn_tasks
        '
        Me.btn_tasks.BackColor = System.Drawing.Color.DimGray
        Me.btn_tasks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_tasks.FlatAppearance.BorderSize = 0
        Me.btn_tasks.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_tasks.Font = New System.Drawing.Font("PT Separated Baloon", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_tasks.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_tasks.Location = New System.Drawing.Point(255, 127)
        Me.btn_tasks.Name = "btn_tasks"
        Me.btn_tasks.Size = New System.Drawing.Size(144, 47)
        Me.btn_tasks.TabIndex = 2
        Me.btn_tasks.Text = "Tasks"
        Me.btn_tasks.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(461, 246)
        Me.Controls.Add(Me.btn_tasks)
        Me.Controls.Add(Me.btn_apply)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Chapter Four"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_apply As System.Windows.Forms.Button
    Friend WithEvents btn_tasks As System.Windows.Forms.Button

End Class
