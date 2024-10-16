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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.txtcity = New System.Windows.Forms.TextBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnview = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 59)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 103)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 158)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contact"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 208)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "City"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(195, 58)
        Me.txtid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(132, 22)
        Me.txtid.TabIndex = 4
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(195, 106)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(132, 22)
        Me.txtname.TabIndex = 5
        '
        'txtcontact
        '
        Me.txtcontact.Location = New System.Drawing.Point(195, 158)
        Me.txtcontact.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(132, 22)
        Me.txtcontact.TabIndex = 6
        '
        'txtcity
        '
        Me.txtcity.Location = New System.Drawing.Point(195, 207)
        Me.txtcity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(132, 22)
        Me.txtcity.TabIndex = 7
        '
        'btnsearch
        '
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Location = New System.Drawing.Point(377, 54)
        Me.btnsearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(100, 28)
        Me.btnsearch.TabIndex = 8
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(49, 287)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(100, 28)
        Me.btnsave.TabIndex = 9
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.Location = New System.Drawing.Point(195, 287)
        Me.btnnew.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(100, 28)
        Me.btnnew.TabIndex = 10
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(340, 287)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(100, 28)
        Me.btnupdate.TabIndex = 11
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(477, 287)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(100, 28)
        Me.btndelete.TabIndex = 12
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(608, 59)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(431, 256)
        Me.DataGridView1.TabIndex = 13
        '
        'btnview
        '
        Me.btnview.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnview.Location = New System.Drawing.Point(779, 322)
        Me.btnview.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(100, 34)
        Me.btnview.TabIndex = 14
        Me.btnview.Text = "View"
        Me.btnview.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1148, 448)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.txtcity)
        Me.Controls.Add(Me.txtcontact)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtcontact As System.Windows.Forms.TextBox
    Friend WithEvents txtcity As System.Windows.Forms.TextBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnview As System.Windows.Forms.Button

End Class
