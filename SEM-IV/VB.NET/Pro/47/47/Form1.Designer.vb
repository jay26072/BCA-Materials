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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gurukul")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bhopal")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("DriveIn")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ahemdabad", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kandivali")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Borivali")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Malad")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mumbai", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6, TreeNode7})
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Location = New System.Drawing.Point(13, 12)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(352, 367)
        Me.TabControl.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TreeView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(344, 338)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TreeView"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(6, 6)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Node1"
        TreeNode1.Text = "Gurukul"
        TreeNode2.Name = "Node2"
        TreeNode2.Text = "Bhopal"
        TreeNode3.Name = "Node3"
        TreeNode3.Text = "DriveIn"
        TreeNode4.Name = "Node0"
        TreeNode4.Text = "Ahemdabad"
        TreeNode5.Name = "Node5"
        TreeNode5.Text = "Kandivali"
        TreeNode6.Name = "Node6"
        TreeNode6.Text = "Borivali"
        TreeNode7.Name = "Node7"
        TreeNode7.Text = "Malad"
        TreeNode8.Name = "Node4"
        TreeNode8.Text = "Mumbai"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode8})
        Me.TreeView1.Size = New System.Drawing.Size(284, 293)
        Me.TreeView1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ListView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(410, 360)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ListView"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(18, 29)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(372, 182)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 383)
        Me.Controls.Add(Me.TabControl)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ListView1 As System.Windows.Forms.ListView

End Class
