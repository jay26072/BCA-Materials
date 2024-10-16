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
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtcost = New System.Windows.Forms.TextBox()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.txtitemtype = New System.Windows.Forms.TextBox()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnview = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cost"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Item Type"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(159, 49)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(123, 22)
        Me.txtid.TabIndex = 5
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(159, 104)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(123, 22)
        Me.txtname.TabIndex = 6
        '
        'txtcost
        '
        Me.txtcost.Location = New System.Drawing.Point(159, 166)
        Me.txtcost.Name = "txtcost"
        Me.txtcost.Size = New System.Drawing.Size(123, 22)
        Me.txtcost.TabIndex = 7
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(159, 220)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(123, 22)
        Me.txtqty.TabIndex = 8
        '
        'txtitemtype
        '
        Me.txtitemtype.Location = New System.Drawing.Point(159, 280)
        Me.txtitemtype.Name = "txtitemtype"
        Me.txtitemtype.Size = New System.Drawing.Size(123, 22)
        Me.txtitemtype.TabIndex = 9
        '
        'btninsert
        '
        Me.btninsert.Location = New System.Drawing.Point(16, 353)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(70, 29)
        Me.btninsert.TabIndex = 10
        Me.btninsert.Text = "Insert"
        Me.btninsert.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Location = New System.Drawing.Point(118, 353)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(75, 29)
        Me.btnnew.TabIndex = 11
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(220, 353)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(79, 29)
        Me.btnupdate.TabIndex = 12
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(309, 166)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(80, 31)
        Me.btnsearch.TabIndex = 13
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(16, 396)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(70, 32)
        Me.btndelete.TabIndex = 14
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnview
        '
        Me.btnview.Location = New System.Drawing.Point(118, 396)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(75, 31)
        Me.btnview.TabIndex = 15
        Me.btnview.Text = "View"
        Me.btnview.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(405, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(848, 400)
        Me.DataGridView1.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1265, 440)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.btninsert)
        Me.Controls.Add(Me.txtitemtype)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.txtcost)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtid)
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
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtcost As System.Windows.Forms.TextBox
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents txtitemtype As System.Windows.Forms.TextBox
    Friend WithEvents btninsert As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnview As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

End Class
