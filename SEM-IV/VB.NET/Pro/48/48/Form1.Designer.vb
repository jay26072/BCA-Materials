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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtdoj = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btndisplay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Emp_Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date Of Join"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(207, 50)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(143, 22)
        Me.txtid.TabIndex = 3
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(207, 115)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(143, 22)
        Me.txtname.TabIndex = 4
        '
        'txtdoj
        '
        Me.txtdoj.Location = New System.Drawing.Point(207, 188)
        Me.txtdoj.Name = "txtdoj"
        Me.txtdoj.Size = New System.Drawing.Size(143, 22)
        Me.txtdoj.TabIndex = 5
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(544, 50)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(293, 180)
        Me.ListBox1.TabIndex = 6
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(544, 291)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(293, 24)
        Me.ComboBox1.TabIndex = 7
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(21, 306)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 8
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btndisplay
        '
        Me.btndisplay.Location = New System.Drawing.Point(207, 306)
        Me.btndisplay.Name = "btndisplay"
        Me.btndisplay.Size = New System.Drawing.Size(75, 23)
        Me.btndisplay.TabIndex = 9
        Me.btndisplay.Text = "Display"
        Me.btndisplay.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 459)
        Me.Controls.Add(Me.btndisplay)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.txtdoj)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtdoj As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btndisplay As System.Windows.Forms.Button

End Class
