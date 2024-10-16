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
        Me.components = New System.ComponentModel.Container
        Me.btnstart = New System.Windows.Forms.Button
        Me.btnstop = New System.Windows.Forms.Button
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblprocess = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnstart
        '
        Me.btnstart.Location = New System.Drawing.Point(102, 107)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(75, 35)
        Me.btnstart.TabIndex = 0
        Me.btnstart.Text = "Start"
        Me.btnstart.UseVisualStyleBackColor = True
        '
        'btnstop
        '
        Me.btnstop.Location = New System.Drawing.Point(183, 107)
        Me.btnstop.Name = "btnstop"
        Me.btnstop.Size = New System.Drawing.Size(75, 35)
        Me.btnstop.TabIndex = 1
        Me.btnstop.Text = "Stop"
        Me.btnstop.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 57)
        Me.ProgressBar1.MarqueeAnimationSpeed = 1000
        Me.ProgressBar1.Maximum = 2000
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(361, 44)
        Me.ProgressBar1.TabIndex = 2
        '
        'Timer1
        '
        '
        'lblprocess
        '
        Me.lblprocess.AutoSize = True
        Me.lblprocess.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprocess.Location = New System.Drawing.Point(12, 29)
        Me.lblprocess.Name = "lblprocess"
        Me.lblprocess.Size = New System.Drawing.Size(222, 25)
        Me.lblprocess.TabIndex = 3
        Me.lblprocess.Text = "ProgressBar Value : 0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 160)
        Me.Controls.Add(Me.lblprocess)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnstop)
        Me.Controls.Add(Me.btnstart)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnstart As System.Windows.Forms.Button
    Friend WithEvents btnstop As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblprocess As System.Windows.Forms.Label

End Class
