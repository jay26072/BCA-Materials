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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chknum = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkans = New System.Windows.Forms.Label()
        Me.clrtxt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(235, 62)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(158, 22)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Any Number"
        '
        'chknum
        '
        Me.chknum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chknum.Location = New System.Drawing.Point(97, 140)
        Me.chknum.Name = "chknum"
        Me.chknum.Size = New System.Drawing.Size(118, 36)
        Me.chknum.TabIndex = 2
        Me.chknum.Text = "Check"
        Me.chknum.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ans"
        '
        'chkans
        '
        Me.chkans.AutoSize = True
        Me.chkans.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkans.Location = New System.Drawing.Point(132, 226)
        Me.chkans.Name = "chkans"
        Me.chkans.Size = New System.Drawing.Size(26, 26)
        Me.chkans.TabIndex = 4
        Me.chkans.Text = "  "
        '
        'clrtxt
        '
        Me.clrtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clrtxt.Location = New System.Drawing.Point(246, 140)
        Me.clrtxt.Name = "clrtxt"
        Me.clrtxt.Size = New System.Drawing.Size(118, 36)
        Me.clrtxt.TabIndex = 5
        Me.clrtxt.Text = "Clear"
        Me.clrtxt.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 457)
        Me.Controls.Add(Me.clrtxt)
        Me.Controls.Add(Me.chkans)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chknum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chknum As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkans As System.Windows.Forms.Label
    Friend WithEvents clrtxt As System.Windows.Forms.Button

End Class
