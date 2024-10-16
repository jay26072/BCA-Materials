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
        Me.txtno = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtmrp = New System.Windows.Forms.TextBox()
        Me.txtsell = New System.Windows.Forms.TextBox()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnview = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item_No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MRP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 26)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sell Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 26)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Quantity"
        '
        'txtno
        '
        Me.txtno.Location = New System.Drawing.Point(173, 42)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(135, 22)
        Me.txtno.TabIndex = 5
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(173, 95)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(135, 22)
        Me.txtname.TabIndex = 6
        '
        'txtmrp
        '
        Me.txtmrp.Location = New System.Drawing.Point(173, 152)
        Me.txtmrp.Name = "txtmrp"
        Me.txtmrp.Size = New System.Drawing.Size(135, 22)
        Me.txtmrp.TabIndex = 7
        '
        'txtsell
        '
        Me.txtsell.Location = New System.Drawing.Point(173, 208)
        Me.txtsell.Name = "txtsell"
        Me.txtsell.Size = New System.Drawing.Size(135, 22)
        Me.txtsell.TabIndex = 8
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(173, 269)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(135, 22)
        Me.txtqty.TabIndex = 9
        '
        'btninsert
        '
        Me.btninsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninsert.Location = New System.Drawing.Point(12, 360)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(93, 33)
        Me.btninsert.TabIndex = 10
        Me.btninsert.Text = "Insert"
        Me.btninsert.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(126, 360)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(95, 33)
        Me.btnupdate.TabIndex = 11
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(12, 425)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(93, 34)
        Me.btndelete.TabIndex = 12
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(126, 425)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(95, 34)
        Me.btnclear.TabIndex = 13
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnview
        '
        Me.btnview.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnview.Location = New System.Drawing.Point(836, 507)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(97, 33)
        Me.btnview.TabIndex = 14
        Me.btnview.Text = "View"
        Me.btnview.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(498, 39)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(786, 420)
        Me.DataGridView1.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 640)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btninsert)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.txtsell)
        Me.Controls.Add(Me.txtmrp)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtno)
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
    Friend WithEvents txtno As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtmrp As System.Windows.Forms.TextBox
    Friend WithEvents txtsell As System.Windows.Forms.TextBox
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents btninsert As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnview As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

End Class
