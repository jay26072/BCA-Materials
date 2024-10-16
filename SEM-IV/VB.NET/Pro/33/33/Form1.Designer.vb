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
        Me.lstname = New System.Windows.Forms.ListBox()
        Me.lstname1 = New System.Windows.Forms.ListBox()
        Me.rightshift = New System.Windows.Forms.Button()
        Me.allright = New System.Windows.Forms.Button()
        Me.shiftMright = New System.Windows.Forms.Button()
        Me.leftshift = New System.Windows.Forms.Button()
        Me.allLeft = New System.Windows.Forms.Button()
        Me.shiftMleft = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstname
        '
        Me.lstname.FormattingEnabled = True
        Me.lstname.ItemHeight = 16
        Me.lstname.Location = New System.Drawing.Point(13, 50)
        Me.lstname.Name = "lstname"
        Me.lstname.Size = New System.Drawing.Size(198, 388)
        Me.lstname.TabIndex = 0
        '
        'lstname1
        '
        Me.lstname1.FormattingEnabled = True
        Me.lstname1.ItemHeight = 16
        Me.lstname1.Location = New System.Drawing.Point(319, 50)
        Me.lstname1.Name = "lstname1"
        Me.lstname1.Size = New System.Drawing.Size(224, 388)
        Me.lstname1.TabIndex = 1
        '
        'rightshift
        '
        Me.rightshift.Location = New System.Drawing.Point(226, 59)
        Me.rightshift.Name = "rightshift"
        Me.rightshift.Size = New System.Drawing.Size(75, 23)
        Me.rightshift.TabIndex = 2
        Me.rightshift.Text = ">"
        Me.rightshift.UseVisualStyleBackColor = True
        '
        'allright
        '
        Me.allright.Location = New System.Drawing.Point(226, 125)
        Me.allright.Name = "allright"
        Me.allright.Size = New System.Drawing.Size(75, 23)
        Me.allright.TabIndex = 3
        Me.allright.Text = ">>"
        Me.allright.UseVisualStyleBackColor = True
        '
        'shiftMright
        '
        Me.shiftMright.Location = New System.Drawing.Point(226, 190)
        Me.shiftMright.Name = "shiftMright"
        Me.shiftMright.Size = New System.Drawing.Size(75, 23)
        Me.shiftMright.TabIndex = 4
        Me.shiftMright.Text = ">>>"
        Me.shiftMright.UseVisualStyleBackColor = True
        '
        'leftshift
        '
        Me.leftshift.Location = New System.Drawing.Point(226, 256)
        Me.leftshift.Name = "leftshift"
        Me.leftshift.Size = New System.Drawing.Size(75, 23)
        Me.leftshift.TabIndex = 5
        Me.leftshift.Text = "<"
        Me.leftshift.UseVisualStyleBackColor = True
        '
        'allLeft
        '
        Me.allLeft.Location = New System.Drawing.Point(226, 324)
        Me.allLeft.Name = "allLeft"
        Me.allLeft.Size = New System.Drawing.Size(75, 23)
        Me.allLeft.TabIndex = 6
        Me.allLeft.Text = "<<"
        Me.allLeft.UseVisualStyleBackColor = True
        '
        'shiftMleft
        '
        Me.shiftMleft.Location = New System.Drawing.Point(226, 386)
        Me.shiftMleft.Name = "shiftMleft"
        Me.shiftMleft.Size = New System.Drawing.Size(75, 23)
        Me.shiftMleft.TabIndex = 7
        Me.shiftMleft.Text = "<<<"
        Me.shiftMleft.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 470)
        Me.Controls.Add(Me.shiftMleft)
        Me.Controls.Add(Me.allLeft)
        Me.Controls.Add(Me.leftshift)
        Me.Controls.Add(Me.shiftMright)
        Me.Controls.Add(Me.allright)
        Me.Controls.Add(Me.rightshift)
        Me.Controls.Add(Me.lstname1)
        Me.Controls.Add(Me.lstname)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstname As System.Windows.Forms.ListBox
    Friend WithEvents lstname1 As System.Windows.Forms.ListBox
    Friend WithEvents rightshift As System.Windows.Forms.Button
    Friend WithEvents allright As System.Windows.Forms.Button
    Friend WithEvents shiftMright As System.Windows.Forms.Button
    Friend WithEvents leftshift As System.Windows.Forms.Button
    Friend WithEvents allLeft As System.Windows.Forms.Button
    Friend WithEvents shiftMleft As System.Windows.Forms.Button

End Class
