Public Class computer_billing_system

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        customerdetail.Show()
    End Sub

    Private Sub AddNewItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewItemsToolStripMenuItem.Click
        addnewitem.Show()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        changepass.Show()
    End Sub

    Private Sub SellPartsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SellPartsToolStripMenuItem.Click
        itemorder.Show()
    End Sub

    Private Sub computer_billing_system_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ProgramToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramToolStripMenuItem.Click
        aboutus.Show()
    End Sub

    Private Sub DisplayItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayItemToolStripMenuItem.Click
        Displayitem.Show()
    End Sub

    Private Sub CustToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub DsfaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DsfaToolStripMenuItem.Click
        Form1.Show()
        Me.Visible = False
    End Sub

    Private Sub UpdateInvoiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateInvoiceToolStripMenuItem.Click
        invoice.Show()
    End Sub

    Private Sub LoginRegisterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginRegisterToolStripMenuItem.Click
        loginregister.Show()
    End Sub

    Private Sub SearchItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchItemToolStripMenuItem.Click
        searchitems.Show()
    End Sub
End Class