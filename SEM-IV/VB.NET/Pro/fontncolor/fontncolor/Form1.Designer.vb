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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.bgcolor = New System.Windows.Forms.Button()
        Me.fontcolour = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.btnfont = New System.Windows.Forms.Button()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 32)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(465, 282)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'bgcolor
        '
        Me.bgcolor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bgcolor.Location = New System.Drawing.Point(508, 70)
        Me.bgcolor.Name = "bgcolor"
        Me.bgcolor.Size = New System.Drawing.Size(118, 40)
        Me.bgcolor.TabIndex = 1
        Me.bgcolor.Text = "BackColor"
        Me.bgcolor.UseVisualStyleBackColor = True
        '
        'fontcolour
        '
        Me.fontcolour.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fontcolour.Location = New System.Drawing.Point(508, 176)
        Me.fontcolour.Name = "fontcolour"
        Me.fontcolour.Size = New System.Drawing.Size(118, 40)
        Me.fontcolour.TabIndex = 2
        Me.fontcolour.Text = "Font Color"
        Me.fontcolour.UseVisualStyleBackColor = True
        '
        'btnfont
        '
        Me.btnfont.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfont.Location = New System.Drawing.Point(508, 272)
        Me.btnfont.Name = "btnfont"
        Me.btnfont.Size = New System.Drawing.Size(118, 42)
        Me.btnfont.TabIndex = 3
        Me.btnfont.Text = "Font"
        Me.btnfont.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 334)
        Me.Controls.Add(Me.btnfont)
        Me.Controls.Add(Me.fontcolour)
        Me.Controls.Add(Me.bgcolor)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents bgcolor As System.Windows.Forms.Button
    Friend WithEvents fontcolour As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents btnfont As System.Windows.Forms.Button
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog

End Class
