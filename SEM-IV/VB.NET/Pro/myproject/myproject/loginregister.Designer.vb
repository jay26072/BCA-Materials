<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginregister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginregister))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtpass = New System.Windows.Forms.TextBox
        Me.txtuname = New System.Windows.Forms.TextBox
        Me.cmdutype = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(383, 102)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(435, 271)
        Me.DataGridView1.TabIndex = 21
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(257, 331)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 42)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "CLEAR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(244, 242)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 42)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "UPDATE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(144, 331)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 42)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(131, 242)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 42)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "REGISTER"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(244, 188)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(121, 20)
        Me.txtpass.TabIndex = 16
        '
        'txtuname
        '
        Me.txtuname.Location = New System.Drawing.Point(244, 148)
        Me.txtuname.Name = "txtuname"
        Me.txtuname.Size = New System.Drawing.Size(121, 20)
        Me.txtuname.TabIndex = 15
        '
        'cmdutype
        '
        Me.cmdutype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmdutype.FormattingEnabled = True
        Me.cmdutype.Items.AddRange(New Object() {"ADMIN", "EMPLOYEE"})
        Me.cmdutype.Location = New System.Drawing.Point(244, 102)
        Me.cmdutype.Name = "cmdutype"
        Me.cmdutype.Size = New System.Drawing.Size(121, 21)
        Me.cmdutype.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(103, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 26)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(91, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 26)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "User name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(106, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 26)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Usertype:"
        '
        'loginregister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.myproject.My.Resources.Resources.bgcollo
        Me.ClientSize = New System.Drawing.Size(875, 467)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtuname)
        Me.Controls.Add(Me.cmdutype)
        Me.Name = "loginregister"
        Me.Text = "loginregister"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents txtuname As System.Windows.Forms.TextBox
    Friend WithEvents cmdutype As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
