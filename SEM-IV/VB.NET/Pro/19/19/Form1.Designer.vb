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
        Me.txtinput = New System.Windows.Forms.TextBox()
        Me.txtsqr = New System.Windows.Forms.TextBox()
        Me.txtcub = New System.Windows.Forms.TextBox()
        Me.btnans = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Any Value:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Square:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cube:"
        '
        'txtinput
        '
        Me.txtinput.Location = New System.Drawing.Point(232, 64)
        Me.txtinput.Name = "txtinput"
        Me.txtinput.Size = New System.Drawing.Size(144, 22)
        Me.txtinput.TabIndex = 3
        '
        'txtsqr
        '
        Me.txtsqr.Location = New System.Drawing.Point(232, 132)
        Me.txtsqr.Name = "txtsqr"
        Me.txtsqr.Size = New System.Drawing.Size(144, 22)
        Me.txtsqr.TabIndex = 4
        '
        'txtcub
        '
        Me.txtcub.Location = New System.Drawing.Point(232, 210)
        Me.txtcub.Name = "txtcub"
        Me.txtcub.Size = New System.Drawing.Size(144, 22)
        Me.txtcub.TabIndex = 5
        '
        'btnans
        '
        Me.btnans.Location = New System.Drawing.Point(185, 272)
        Me.btnans.Name = "btnans"
        Me.btnans.Size = New System.Drawing.Size(75, 23)
        Me.btnans.TabIndex = 6
        Me.btnans.Text = "Ans"
        Me.btnans.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 403)
        Me.Controls.Add(Me.btnans)
        Me.Controls.Add(Me.txtcub)
        Me.Controls.Add(Me.txtsqr)
        Me.Controls.Add(Me.txtinput)
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
    Friend WithEvents txtinput As System.Windows.Forms.TextBox
    Friend WithEvents txtsqr As System.Windows.Forms.TextBox
    Friend WithEvents txtcub As System.Windows.Forms.TextBox
    Friend WithEvents btnans As System.Windows.Forms.Button

End Class
