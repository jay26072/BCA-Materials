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
        Me.user = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.Login = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 117)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'user
        '
        Me.user.Location = New System.Drawing.Point(148, 44)
        Me.user.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(132, 22)
        Me.user.TabIndex = 2
        '
        'pass
        '
        Me.pass.Location = New System.Drawing.Point(148, 117)
        Me.pass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pass.Name = "pass"
        Me.pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9899)
        Me.pass.Size = New System.Drawing.Size(132, 22)
        Me.pass.TabIndex = 3
        '
        'Login
        '
        Me.Login.Location = New System.Drawing.Point(93, 192)
        Me.Login.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(100, 28)
        Me.Login.TabIndex = 4
        Me.Login.Text = "Login"
        Me.Login.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 275)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents user As System.Windows.Forms.TextBox
    Friend WithEvents pass As System.Windows.Forms.TextBox
    Friend WithEvents Login As System.Windows.Forms.Button

End Class
