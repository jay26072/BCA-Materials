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
        Me.Hsred = New System.Windows.Forms.HScrollBar()
        Me.Hsgreen = New System.Windows.Forms.HScrollBar()
        Me.Hsblue = New System.Windows.Forms.HScrollBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Hsred
        '
        Me.Hsred.Location = New System.Drawing.Point(9, 23)
        Me.Hsred.Maximum = 255
        Me.Hsred.Name = "Hsred"
        Me.Hsred.Size = New System.Drawing.Size(719, 33)
        Me.Hsred.TabIndex = 0
        '
        'Hsgreen
        '
        Me.Hsgreen.Location = New System.Drawing.Point(9, 84)
        Me.Hsgreen.Maximum = 255
        Me.Hsgreen.Name = "Hsgreen"
        Me.Hsgreen.Size = New System.Drawing.Size(719, 32)
        Me.Hsgreen.TabIndex = 1
        '
        'Hsblue
        '
        Me.Hsblue.Location = New System.Drawing.Point(9, 146)
        Me.Hsblue.Maximum = 255
        Me.Hsblue.Name = "Hsblue"
        Me.Hsblue.Size = New System.Drawing.Size(719, 35)
        Me.Hsblue.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(72, 248)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(584, 220)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 490)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Hsblue)
        Me.Controls.Add(Me.Hsgreen)
        Me.Controls.Add(Me.Hsred)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Hsred As System.Windows.Forms.HScrollBar
    Friend WithEvents Hsgreen As System.Windows.Forms.HScrollBar
    Friend WithEvents Hsblue As System.Windows.Forms.HScrollBar
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
