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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtcity = New System.Windows.Forms.TextBox()
        Me.txtcourse = New System.Windows.Forms.TextBox()
        Me.txtdob = New System.Windows.Forms.TextBox()
        Me.txtadd = New System.Windows.Forms.TextBox()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.btnview = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "City"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Course"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "DOB"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 351)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Address"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(128, 43)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(152, 22)
        Me.txtid.TabIndex = 6
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(128, 101)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(152, 22)
        Me.txtname.TabIndex = 7
        '
        'txtcity
        '
        Me.txtcity.Location = New System.Drawing.Point(128, 161)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(152, 22)
        Me.txtcity.TabIndex = 8
        '
        'txtcourse
        '
        Me.txtcourse.Location = New System.Drawing.Point(128, 220)
        Me.txtcourse.Name = "txtcourse"
        Me.txtcourse.Size = New System.Drawing.Size(152, 22)
        Me.txtcourse.TabIndex = 9
        '
        'txtdob
        '
        Me.txtdob.Location = New System.Drawing.Point(128, 285)
        Me.txtdob.Name = "txtdob"
        Me.txtdob.Size = New System.Drawing.Size(152, 22)
        Me.txtdob.TabIndex = 10
        '
        'txtadd
        '
        Me.txtadd.Location = New System.Drawing.Point(128, 352)
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(152, 22)
        Me.txtadd.TabIndex = 11
        '
        'btninsert
        '
        Me.btninsert.Location = New System.Drawing.Point(16, 417)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(75, 32)
        Me.btninsert.TabIndex = 12
        Me.btninsert.Text = "Insert"
        Me.btninsert.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(128, 417)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 33)
        Me.btnupdate.TabIndex = 13
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(233, 417)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 33)
        Me.btndelete.TabIndex = 14
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Location = New System.Drawing.Point(16, 482)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(75, 32)
        Me.btnnew.TabIndex = 15
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btnview
        '
        Me.btnview.Location = New System.Drawing.Point(233, 482)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(75, 32)
        Me.btnview.TabIndex = 16
        Me.btnview.Text = "View"
        Me.btnview.UseVisualStyleBackColor = True
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(310, 219)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 25)
        Me.btnsearch.TabIndex = 17
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(391, 31)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(740, 344)
        Me.DataGridView1.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 539)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btninsert)
        Me.Controls.Add(Me.txtadd)
        Me.Controls.Add(Me.txtdob)
        Me.Controls.Add(Me.txtcourse)
        Me.Controls.Add(Me.txtcity)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtcity As System.Windows.Forms.TextBox
    Friend WithEvents txtcourse As System.Windows.Forms.TextBox
    Friend WithEvents txtdob As System.Windows.Forms.TextBox
    Friend WithEvents txtadd As System.Windows.Forms.TextBox
    Friend WithEvents btninsert As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnview As System.Windows.Forms.Button
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

End Class
