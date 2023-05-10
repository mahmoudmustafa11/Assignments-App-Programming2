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
        Me.btn_inputData = New System.Windows.Forms.Button()
        Me.btn_appendData = New System.Windows.Forms.Button()
        Me.btn_outputData = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_fileSystemWatcher = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_inputData
        '
        Me.btn_inputData.BackColor = System.Drawing.Color.Tan
        Me.btn_inputData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_inputData.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_inputData.Location = New System.Drawing.Point(24, 219)
        Me.btn_inputData.Name = "btn_inputData"
        Me.btn_inputData.Size = New System.Drawing.Size(309, 61)
        Me.btn_inputData.TabIndex = 1
        Me.btn_inputData.Text = "Input data in file"
        Me.btn_inputData.UseVisualStyleBackColor = False
        '
        'btn_appendData
        '
        Me.btn_appendData.BackColor = System.Drawing.Color.Tan
        Me.btn_appendData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_appendData.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_appendData.Location = New System.Drawing.Point(24, 296)
        Me.btn_appendData.Name = "btn_appendData"
        Me.btn_appendData.Size = New System.Drawing.Size(309, 61)
        Me.btn_appendData.TabIndex = 2
        Me.btn_appendData.Text = "Append data in file"
        Me.btn_appendData.UseVisualStyleBackColor = False
        '
        'btn_outputData
        '
        Me.btn_outputData.BackColor = System.Drawing.Color.Tan
        Me.btn_outputData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_outputData.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_outputData.Location = New System.Drawing.Point(24, 373)
        Me.btn_outputData.Name = "btn_outputData"
        Me.btn_outputData.Size = New System.Drawing.Size(309, 61)
        Me.btn_outputData.TabIndex = 3
        Me.btn_outputData.Text = "Output data from file"
        Me.btn_outputData.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Text", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(294, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 39)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "APP"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Tan
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Maroon
        Me.Button3.Location = New System.Drawing.Point(217, 560)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(209, 78)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Print Verbs"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Tan
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(371, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(309, 61)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Print Words"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Text", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(271, 497)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 39)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Tasks"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Tan
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(371, 296)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(309, 61)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Print Folders and Files"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btn_fileSystemWatcher
        '
        Me.btn_fileSystemWatcher.BackColor = System.Drawing.Color.Tan
        Me.btn_fileSystemWatcher.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_fileSystemWatcher.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fileSystemWatcher.Location = New System.Drawing.Point(371, 373)
        Me.btn_fileSystemWatcher.Name = "btn_fileSystemWatcher"
        Me.btn_fileSystemWatcher.Size = New System.Drawing.Size(309, 61)
        Me.btn_fileSystemWatcher.TabIndex = 9
        Me.btn_fileSystemWatcher.Text = "File system Watcher"
        Me.btn_fileSystemWatcher.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(81, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(517, 65)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Assignments Chapter Two"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(697, 650)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_fileSystemWatcher)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_outputData)
        Me.Controls.Add(Me.btn_appendData)
        Me.Controls.Add(Me.btn_inputData)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Assignments Chapter Two"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_inputData As System.Windows.Forms.Button
    Friend WithEvents btn_appendData As System.Windows.Forms.Button
    Friend WithEvents btn_outputData As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btn_fileSystemWatcher As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
