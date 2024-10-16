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
        Me.txtdata = New System.Windows.Forms.RichTextBox()
        Me.btncut = New System.Windows.Forms.Button()
        Me.btncpy = New System.Windows.Forms.Button()
        Me.btnpst = New System.Windows.Forms.Button()
        Me.btnundo = New System.Windows.Forms.Button()
        Me.btnredo = New System.Windows.Forms.Button()
        Me.btnclr = New System.Windows.Forms.Button()
        Me.upper = New System.Windows.Forms.Button()
        Me.Lower = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtdata
        '
        Me.txtdata.Location = New System.Drawing.Point(12, 22)
        Me.txtdata.Name = "txtdata"
        Me.txtdata.Size = New System.Drawing.Size(533, 170)
        Me.txtdata.TabIndex = 0
        Me.txtdata.Text = ""
        '
        'btncut
        '
        Me.btncut.Location = New System.Drawing.Point(24, 215)
        Me.btncut.Name = "btncut"
        Me.btncut.Size = New System.Drawing.Size(75, 35)
        Me.btncut.TabIndex = 1
        Me.btncut.Text = "Cut"
        Me.btncut.UseVisualStyleBackColor = True
        '
        'btncpy
        '
        Me.btncpy.Location = New System.Drawing.Point(133, 215)
        Me.btncpy.Name = "btncpy"
        Me.btncpy.Size = New System.Drawing.Size(75, 35)
        Me.btncpy.TabIndex = 2
        Me.btncpy.Text = "Copy"
        Me.btncpy.UseVisualStyleBackColor = True
        '
        'btnpst
        '
        Me.btnpst.Location = New System.Drawing.Point(235, 216)
        Me.btnpst.Name = "btnpst"
        Me.btnpst.Size = New System.Drawing.Size(75, 34)
        Me.btnpst.TabIndex = 3
        Me.btnpst.Text = "Past"
        Me.btnpst.UseVisualStyleBackColor = True
        '
        'btnundo
        '
        Me.btnundo.Location = New System.Drawing.Point(24, 269)
        Me.btnundo.Name = "btnundo"
        Me.btnundo.Size = New System.Drawing.Size(75, 32)
        Me.btnundo.TabIndex = 4
        Me.btnundo.Text = "Undo"
        Me.btnundo.UseVisualStyleBackColor = True
        '
        'btnredo
        '
        Me.btnredo.Location = New System.Drawing.Point(133, 269)
        Me.btnredo.Name = "btnredo"
        Me.btnredo.Size = New System.Drawing.Size(75, 32)
        Me.btnredo.TabIndex = 5
        Me.btnredo.Text = "Redo"
        Me.btnredo.UseVisualStyleBackColor = True
        '
        'btnclr
        '
        Me.btnclr.Location = New System.Drawing.Point(235, 269)
        Me.btnclr.Name = "btnclr"
        Me.btnclr.Size = New System.Drawing.Size(75, 32)
        Me.btnclr.TabIndex = 6
        Me.btnclr.Text = "Clear"
        Me.btnclr.UseVisualStyleBackColor = True
        '
        'upper
        '
        Me.upper.Location = New System.Drawing.Point(331, 268)
        Me.upper.Name = "upper"
        Me.upper.Size = New System.Drawing.Size(168, 33)
        Me.upper.TabIndex = 7
        Me.upper.Text = "UpperCase"
        Me.upper.UseVisualStyleBackColor = True
        '
        'Lower
        '
        Me.Lower.Location = New System.Drawing.Point(331, 216)
        Me.Lower.Name = "Lower"
        Me.Lower.Size = New System.Drawing.Size(168, 33)
        Me.Lower.TabIndex = 8
        Me.Lower.Text = "LowerCase"
        Me.Lower.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 320)
        Me.Controls.Add(Me.Lower)
        Me.Controls.Add(Me.upper)
        Me.Controls.Add(Me.btnclr)
        Me.Controls.Add(Me.btnredo)
        Me.Controls.Add(Me.btnundo)
        Me.Controls.Add(Me.btnpst)
        Me.Controls.Add(Me.btncpy)
        Me.Controls.Add(Me.btncut)
        Me.Controls.Add(Me.txtdata)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtdata As System.Windows.Forms.RichTextBox
    Friend WithEvents btncut As System.Windows.Forms.Button
    Friend WithEvents btncpy As System.Windows.Forms.Button
    Friend WithEvents btnpst As System.Windows.Forms.Button
    Friend WithEvents btnundo As System.Windows.Forms.Button
    Friend WithEvents btnredo As System.Windows.Forms.Button
    Friend WithEvents btnclr As System.Windows.Forms.Button
    Friend WithEvents upper As System.Windows.Forms.Button
    Friend WithEvents Lower As System.Windows.Forms.Button

End Class
