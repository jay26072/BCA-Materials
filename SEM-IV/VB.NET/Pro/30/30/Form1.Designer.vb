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
        Me.rdomale = New System.Windows.Forms.RadioButton()
        Me.rdofemale = New System.Windows.Forms.RadioButton()
        Me.Answer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Gender"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(125, 37)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(138, 22)
        Me.txtname.TabIndex = 2
        '
        'rdomale
        '
        Me.rdomale.AutoSize = True
        Me.rdomale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdomale.Location = New System.Drawing.Point(125, 92)
        Me.rdomale.Name = "rdomale"
        Me.rdomale.Size = New System.Drawing.Size(63, 21)
        Me.rdomale.TabIndex = 3
        Me.rdomale.TabStop = True
        Me.rdomale.Text = "Male"
        Me.rdomale.UseVisualStyleBackColor = True
        '
        'rdofemale
        '
        Me.rdofemale.AutoSize = True
        Me.rdofemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdofemale.Location = New System.Drawing.Point(206, 92)
        Me.rdofemale.Name = "rdofemale"
        Me.rdofemale.Size = New System.Drawing.Size(81, 21)
        Me.rdofemale.TabIndex = 4
        Me.rdofemale.TabStop = True
        Me.rdofemale.Text = "Female"
        Me.rdofemale.UseVisualStyleBackColor = True
        '
        'Answer
        '
        Me.Answer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Answer.Location = New System.Drawing.Point(125, 152)
        Me.Answer.Name = "Answer"
        Me.Answer.Size = New System.Drawing.Size(162, 46)
        Me.Answer.TabIndex = 5
        Me.Answer.Text = "Submit"
        Me.Answer.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 233)
        Me.Controls.Add(Me.Answer)
        Me.Controls.Add(Me.rdofemale)
        Me.Controls.Add(Me.rdomale)
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
    Friend WithEvents rdomale As System.Windows.Forms.RadioButton
    Friend WithEvents rdofemale As System.Windows.Forms.RadioButton
    Friend WithEvents Answer As System.Windows.Forms.Button

End Class
