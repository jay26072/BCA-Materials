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
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.value = New System.Windows.Forms.Label()
        Me.btnstart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(55, 91)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(214, 41)
        Me.ProgressBar1.TabIndex = 0
        '
        'Timer1
        '
        '
        'value
        '
        Me.value.AutoSize = True
        Me.value.Location = New System.Drawing.Point(64, 55)
        Me.value.Name = "value"
        Me.value.Size = New System.Drawing.Size(0, 17)
        Me.value.TabIndex = 2
        '
        'btnstart
        '
        Me.btnstart.Location = New System.Drawing.Point(112, 224)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(81, 32)
        Me.btnstart.TabIndex = 3
        Me.btnstart.Text = "Start"
        Me.btnstart.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 335)
        Me.Controls.Add(Me.btnstart)
        Me.Controls.Add(Me.value)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents value As System.Windows.Forms.Label
    Friend WithEvents btnstart As System.Windows.Forms.Button

End Class
