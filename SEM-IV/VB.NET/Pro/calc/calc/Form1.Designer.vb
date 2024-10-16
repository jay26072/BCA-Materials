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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btnsum = New System.Windows.Forms.Button()
        Me.Btnsub = New System.Windows.Forms.Button()
        Me.Btnmul = New System.Windows.Forms.Button()
        Me.Btndiv = New System.Windows.Forms.Button()
        Me.Btnclear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(112, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(134, 22)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(112, 91)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(134, 22)
        Me.TextBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 33)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "No2"
        '
        'Btnsum
        '
        Me.Btnsum.Location = New System.Drawing.Point(12, 221)
        Me.Btnsum.Name = "Btnsum"
        Me.Btnsum.Size = New System.Drawing.Size(106, 30)
        Me.Btnsum.TabIndex = 4
        Me.Btnsum.Text = "+"
        Me.Btnsum.UseVisualStyleBackColor = True
        '
        'Btnsub
        '
        Me.Btnsub.Location = New System.Drawing.Point(124, 221)
        Me.Btnsub.Name = "Btnsub"
        Me.Btnsub.Size = New System.Drawing.Size(101, 30)
        Me.Btnsub.TabIndex = 5
        Me.Btnsub.Text = "-"
        Me.Btnsub.UseVisualStyleBackColor = True
        '
        'Btnmul
        '
        Me.Btnmul.Location = New System.Drawing.Point(12, 279)
        Me.Btnmul.Name = "Btnmul"
        Me.Btnmul.Size = New System.Drawing.Size(106, 32)
        Me.Btnmul.TabIndex = 6
        Me.Btnmul.Text = "*"
        Me.Btnmul.UseVisualStyleBackColor = True
        '
        'Btndiv
        '
        Me.Btndiv.Location = New System.Drawing.Point(124, 279)
        Me.Btndiv.Name = "Btndiv"
        Me.Btndiv.Size = New System.Drawing.Size(101, 31)
        Me.Btndiv.TabIndex = 7
        Me.Btndiv.Text = "/"
        Me.Btndiv.UseVisualStyleBackColor = True
        '
        'Btnclear
        '
        Me.Btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnclear.Location = New System.Drawing.Point(85, 335)
        Me.Btnclear.Name = "Btnclear"
        Me.Btnclear.Size = New System.Drawing.Size(75, 29)
        Me.Btnclear.TabIndex = 10
        Me.Btnclear.Text = "C"
        Me.Btnclear.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 25)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Answer"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(112, 153)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(134, 22)
        Me.TextBox3.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 401)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Btnclear)
        Me.Controls.Add(Me.Btndiv)
        Me.Controls.Add(Me.Btnmul)
        Me.Controls.Add(Me.Btnsub)
        Me.Controls.Add(Me.Btnsum)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Btnsum As System.Windows.Forms.Button
    Friend WithEvents Btnsub As System.Windows.Forms.Button
    Friend WithEvents Btnmul As System.Windows.Forms.Button
    Friend WithEvents Btndiv As System.Windows.Forms.Button
    Friend WithEvents Btnclear As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox

End Class
