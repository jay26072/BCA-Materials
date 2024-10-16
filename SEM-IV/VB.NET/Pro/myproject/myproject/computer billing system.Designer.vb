<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class computer_billing_system
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(computer_billing_system))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.LoginRegisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddNewItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DisplayItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SellPartsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UpdateInvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteInvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DsfaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SearchItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.ItemsToolStripMenuItem, Me.ReportToolStripMenuItem, Me.AboutToolStripMenuItem, Me.DsfaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1130, 34)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ExitToolStripMenuItem1, Me.LoginRegisterToolStripMenuItem})
        Me.AdminToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(81, 30)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(244, 30)
        Me.ChangePasswordToolStripMenuItem.Text = "change password"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(244, 30)
        Me.ExitToolStripMenuItem.Text = "Customer Detail"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(244, 30)
        Me.ExitToolStripMenuItem1.Text = "exit"
        '
        'LoginRegisterToolStripMenuItem
        '
        Me.LoginRegisterToolStripMenuItem.Name = "LoginRegisterToolStripMenuItem"
        Me.LoginRegisterToolStripMenuItem.Size = New System.Drawing.Size(244, 30)
        Me.LoginRegisterToolStripMenuItem.Text = "login register"
        '
        'ItemsToolStripMenuItem
        '
        Me.ItemsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewItemsToolStripMenuItem, Me.DisplayItemToolStripMenuItem, Me.SearchItemToolStripMenuItem})
        Me.ItemsToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemsToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.ItemsToolStripMenuItem.Name = "ItemsToolStripMenuItem"
        Me.ItemsToolStripMenuItem.Size = New System.Drawing.Size(73, 30)
        Me.ItemsToolStripMenuItem.Text = "Items"
        '
        'AddNewItemsToolStripMenuItem
        '
        Me.AddNewItemsToolStripMenuItem.Name = "AddNewItemsToolStripMenuItem"
        Me.AddNewItemsToolStripMenuItem.Size = New System.Drawing.Size(226, 30)
        Me.AddNewItemsToolStripMenuItem.Text = "Add new items"
        '
        'DisplayItemToolStripMenuItem
        '
        Me.DisplayItemToolStripMenuItem.Name = "DisplayItemToolStripMenuItem"
        Me.DisplayItemToolStripMenuItem.Size = New System.Drawing.Size(226, 30)
        Me.DisplayItemToolStripMenuItem.Text = "Display item"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SellPartsToolStripMenuItem, Me.UpdateInvoiceToolStripMenuItem, Me.DeleteInvoiceToolStripMenuItem})
        Me.ReportToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(83, 30)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'SellPartsToolStripMenuItem
        '
        Me.SellPartsToolStripMenuItem.Name = "SellPartsToolStripMenuItem"
        Me.SellPartsToolStripMenuItem.Size = New System.Drawing.Size(226, 30)
        Me.SellPartsToolStripMenuItem.Text = "Sell parts"
        '
        'UpdateInvoiceToolStripMenuItem
        '
        Me.UpdateInvoiceToolStripMenuItem.Name = "UpdateInvoiceToolStripMenuItem"
        Me.UpdateInvoiceToolStripMenuItem.Size = New System.Drawing.Size(226, 30)
        Me.UpdateInvoiceToolStripMenuItem.Text = "Update invoice"
        '
        'DeleteInvoiceToolStripMenuItem
        '
        Me.DeleteInvoiceToolStripMenuItem.Name = "DeleteInvoiceToolStripMenuItem"
        Me.DeleteInvoiceToolStripMenuItem.Size = New System.Drawing.Size(226, 30)
        Me.DeleteInvoiceToolStripMenuItem.Text = "Delete invoice"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem})
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(77, 30)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(168, 30)
        Me.ProgramToolStripMenuItem.Text = "Program"
        '
        'DsfaToolStripMenuItem
        '
        Me.DsfaToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DsfaToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.DsfaToolStripMenuItem.Name = "DsfaToolStripMenuItem"
        Me.DsfaToolStripMenuItem.Size = New System.Drawing.Size(93, 30)
        Me.DsfaToolStripMenuItem.Text = "Log OFF"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(46, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1183, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'SearchItemToolStripMenuItem
        '
        Me.SearchItemToolStripMenuItem.Name = "SearchItemToolStripMenuItem"
        Me.SearchItemToolStripMenuItem.Size = New System.Drawing.Size(226, 30)
        Me.SearchItemToolStripMenuItem.Text = "search item"
        '
        'computer_billing_system
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.myproject.My.Resources.Resources.bgcollo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1130, 497)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "computer_billing_system"
        Me.Text = "  "
        Me.TransparencyKey = System.Drawing.Color.White
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SellPartsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateInvoiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteInvoiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DsfaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginRegisterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
