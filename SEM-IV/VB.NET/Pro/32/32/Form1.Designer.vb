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
        Me.lstname = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Add = New System.Windows.Forms.Button()
        Me.remove = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtval = New System.Windows.Forms.TextBox()
        Me.insert = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'lstname
        '
        Me.lstname.FormattingEnabled = True
        Me.lstname.ItemHeight = 16
        Me.lstname.Location = New System.Drawing.Point(87, 38)
        Me.lstname.Name = "lstname"
        Me.lstname.Size = New System.Drawing.Size(190, 212)
        Me.lstname.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(87, 282)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(164, 22)
        Me.txtname.TabIndex = 3
        '
        'Add
        '
        Me.Add.Location = New System.Drawing.Point(87, 331)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(75, 34)
        Me.Add.TabIndex = 4
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = True
        '
        'remove
        '
        Me.remove.Location = New System.Drawing.Point(176, 331)
        Me.remove.Name = "remove"
        Me.remove.Size = New System.Drawing.Size(90, 34)
        Me.remove.TabIndex = 5
        Me.remove.Text = "Remove"
        Me.remove.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 385)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Pos"
        '
        'txtpos
        '
        Me.txtpos.Location = New System.Drawing.Point(87, 385)
        Me.txtpos.Name = "txtpos"
        Me.txtpos.Size = New System.Drawing.Size(52, 22)
        Me.txtpos.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(159, 388)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Value"
        '
        'txtval
        '
        Me.txtval.Location = New System.Drawing.Point(209, 385)
        Me.txtval.Name = "txtval"
        Me.txtval.Size = New System.Drawing.Size(68, 22)
        Me.txtval.TabIndex = 9
        '
        'insert
        '
        Me.insert.Location = New System.Drawing.Point(87, 432)
        Me.insert.Name = "insert"
        Me.insert.Size = New System.Drawing.Size(75, 31)
        Me.insert.TabIndex = 10
        Me.insert.Text = "Insert"
        Me.insert.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 475)
        Me.Controls.Add(Me.insert)
        Me.Controls.Add(Me.txtval)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtpos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.remove)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstname)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstname As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents remove As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtpos As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtval As System.Windows.Forms.TextBox
    Friend WithEvents insert As System.Windows.Forms.Button

End Class
