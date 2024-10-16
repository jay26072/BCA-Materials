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
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.btnchk = New System.Windows.Forms.Button()
        Me.btnunchk = New System.Windows.Forms.Button()
        Me.chklstname = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(77, 250)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(167, 22)
        Me.txtname.TabIndex = 3
        '
        'btnchk
        '
        Me.btnchk.Location = New System.Drawing.Point(12, 305)
        Me.btnchk.Name = "btnchk"
        Me.btnchk.Size = New System.Drawing.Size(124, 47)
        Me.btnchk.TabIndex = 4
        Me.btnchk.Text = "Checked"
        Me.btnchk.UseVisualStyleBackColor = True
        '
        'btnunchk
        '
        Me.btnunchk.Location = New System.Drawing.Point(163, 305)
        Me.btnunchk.Name = "btnunchk"
        Me.btnunchk.Size = New System.Drawing.Size(126, 47)
        Me.btnunchk.TabIndex = 5
        Me.btnunchk.Text = "UnChecked"
        Me.btnunchk.UseVisualStyleBackColor = True
        '
        'chklstname
        '
        Me.chklstname.FormattingEnabled = True
        Me.chklstname.Location = New System.Drawing.Point(71, 34)
        Me.chklstname.Name = "chklstname"
        Me.chklstname.Size = New System.Drawing.Size(173, 191)
        Me.chklstname.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 397)
        Me.Controls.Add(Me.chklstname)
        Me.Controls.Add(Me.btnunchk)
        Me.Controls.Add(Me.btnchk)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents btnchk As System.Windows.Forms.Button
    Friend WithEvents btnunchk As System.Windows.Forms.Button
    Friend WithEvents chklstname As System.Windows.Forms.CheckedListBox

End Class
