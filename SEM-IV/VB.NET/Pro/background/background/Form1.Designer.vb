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
        Me.txtred = New System.Windows.Forms.TextBox()
        Me.txtgreen = New System.Windows.Forms.TextBox()
        Me.txtblue = New System.Windows.Forms.TextBox()
        Me.TrackBarRed = New System.Windows.Forms.TrackBar()
        Me.TrackBarGreen = New System.Windows.Forms.TrackBar()
        Me.TrackBarBlue = New System.Windows.Forms.TrackBar()
        CType(Me.TrackBarRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Red"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(186, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Green"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(384, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Blue"
        '
        'txtred
        '
        Me.txtred.Location = New System.Drawing.Point(53, 38)
        Me.txtred.Name = "txtred"
        Me.txtred.Size = New System.Drawing.Size(100, 22)
        Me.txtred.TabIndex = 3
        '
        'txtgreen
        '
        Me.txtgreen.Location = New System.Drawing.Point(240, 41)
        Me.txtgreen.Name = "txtgreen"
        Me.txtgreen.Size = New System.Drawing.Size(100, 22)
        Me.txtgreen.TabIndex = 4
        '
        'txtblue
        '
        Me.txtblue.Location = New System.Drawing.Point(426, 41)
        Me.txtblue.Name = "txtblue"
        Me.txtblue.Size = New System.Drawing.Size(100, 22)
        Me.txtblue.TabIndex = 5
        '
        'TrackBarRed
        '
        Me.TrackBarRed.Location = New System.Drawing.Point(16, 143)
        Me.TrackBarRed.Maximum = 255
        Me.TrackBarRed.Name = "TrackBarRed"
        Me.TrackBarRed.Size = New System.Drawing.Size(1122, 56)
        Me.TrackBarRed.TabIndex = 6
        '
        'TrackBarGreen
        '
        Me.TrackBarGreen.Location = New System.Drawing.Point(12, 233)
        Me.TrackBarGreen.Maximum = 255
        Me.TrackBarGreen.Name = "TrackBarGreen"
        Me.TrackBarGreen.Size = New System.Drawing.Size(1122, 56)
        Me.TrackBarGreen.TabIndex = 7
        '
        'TrackBarBlue
        '
        Me.TrackBarBlue.Location = New System.Drawing.Point(16, 312)
        Me.TrackBarBlue.Maximum = 255
        Me.TrackBarBlue.Name = "TrackBarBlue"
        Me.TrackBarBlue.Size = New System.Drawing.Size(1122, 56)
        Me.TrackBarBlue.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1150, 383)
        Me.Controls.Add(Me.TrackBarBlue)
        Me.Controls.Add(Me.TrackBarGreen)
        Me.Controls.Add(Me.TrackBarRed)
        Me.Controls.Add(Me.txtblue)
        Me.Controls.Add(Me.txtgreen)
        Me.Controls.Add(Me.txtred)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TrackBarRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarBlue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtred As System.Windows.Forms.TextBox
    Friend WithEvents txtgreen As System.Windows.Forms.TextBox
    Friend WithEvents txtblue As System.Windows.Forms.TextBox
    Friend WithEvents TrackBarRed As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBarGreen As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBarBlue As System.Windows.Forms.TrackBar

End Class
