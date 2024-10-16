<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class itemorder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(itemorder))
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.AdditemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Celldrop = New myproject.celldrop
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.AdditemTableAdapter = New myproject.celldropTableAdapters.additemTableAdapter
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdditemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Celldrop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(193, 455)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(105, 37)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(331, 455)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 37)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(318, 72)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(164, 20)
        Me.TextBox1.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(102, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 26)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Item ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(102, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 26)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Item name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(581, 353)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 26)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Quantity:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.Location = New System.Drawing.Point(732, 353)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 26)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Total:"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(582, 401)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(108, 20)
        Me.TextBox7.TabIndex = 48
        Me.TextBox7.Text = "1"
        '
        'TextBox8
        '
        Me.TextBox8.Enabled = False
        Me.TextBox8.Location = New System.Drawing.Point(737, 401)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(108, 20)
        Me.TextBox8.TabIndex = 49
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(574, 67)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(116, 37)
        Me.Button4.TabIndex = 50
        Me.Button4.Text = "Generate"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(574, 121)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(610, 229)
        Me.DataGridView1.TabIndex = 52
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(318, 217)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(164, 20)
        Me.TextBox4.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(102, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 26)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Customer name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Image = CType(resources.GetObject("Label9.Image"), System.Drawing.Image)
        Me.Label9.Location = New System.Drawing.Point(102, 258)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 26)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Address:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
        Me.Label10.Location = New System.Drawing.Point(102, 305)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 26)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "City:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Image = CType(resources.GetObject("Label11.Image"), System.Drawing.Image)
        Me.Label11.Location = New System.Drawing.Point(102, 350)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 26)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Mobile no:"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(318, 356)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(164, 20)
        Me.TextBox9.TabIndex = 60
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(318, 308)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(164, 20)
        Me.TextBox10.TabIndex = 59
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(318, 262)
        Me.TextBox11.Multiline = True
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(164, 20)
        Me.TextBox11.TabIndex = 58
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ComboBox1.DataSource = Me.AdditemBindingSource
        Me.ComboBox1.DisplayMember = "itemnm"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(318, 121)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(164, 21)
        Me.ComboBox1.TabIndex = 62
        Me.ComboBox1.ValueMember = "itemnm"
        '
        'AdditemBindingSource
        '
        Me.AdditemBindingSource.DataMember = "additem"
        Me.AdditemBindingSource.DataSource = Me.Celldrop
        '
        'Celldrop
        '
        Me.Celldrop.DataSetName = "celldrop"
        Me.Celldrop.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(318, 165)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(164, 33)
        Me.TextBox3.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(102, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 26)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Item description:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(318, 401)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(164, 20)
        Me.TextBox5.TabIndex = 66
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Image = CType(resources.GetObject("Label12.Image"), System.Drawing.Image)
        Me.Label12.Location = New System.Drawing.Point(102, 395)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 26)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "Item price:"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(469, 455)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(105, 37)
        Me.Button5.TabIndex = 67
        Me.Button5.Text = "clear"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'AdditemTableAdapter
        '
        Me.AdditemTableAdapter.ClearBeforeFill = True
        '
        'itemorder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.myproject.My.Resources.Resources.bgcollo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1090, 642)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Name = "itemorder"
        Me.Text = "itemorder"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdditemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Celldrop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Celldrop As myproject.celldrop
    Friend WithEvents AdditemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AdditemTableAdapter As myproject.celldropTableAdapters.additemTableAdapter
End Class
