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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.Check = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Age"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(132, 51)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(132, 22)
        Me.txtname.TabIndex = 2
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(132, 124)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(132, 22)
        Me.txtage.TabIndex = 3
        '
        'Check
        '
        Me.Check.Location = New System.Drawing.Point(132, 190)
        Me.Check.Name = "Check"
        Me.Check.Size = New System.Drawing.Size(75, 32)
        Me.Check.TabIndex = 4
        Me.Check.Text = "Submit"
        Me.Check.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 244)
        Me.Controls.Add(Me.Check)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents Check As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

End Class
