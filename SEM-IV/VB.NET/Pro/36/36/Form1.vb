Public Class Form1
    Private Sub btnclos_Click(sender As Object, e As EventArgs) Handles btnclos.Click
        Close()
    End Sub

    Private Sub TextBox1_MouseHover(sender As Object, e As EventArgs) Handles TextBox1.MouseHover
        ToolTip1.SetToolTip(TextBox1, "Enter Username")
    End Sub

    Private Sub TextBox2_MouseHover(sender As Object, e As EventArgs) Handles TextBox2.MouseHover
        ToolTip1.SetToolTip(TextBox2, "Enter Password")
    End Sub

    Private Sub btnclos_MouseHover(sender As Object, e As EventArgs) Handles btnclos.MouseHover
        ToolTip1.SetToolTip(btnclos, "Close")
    End Sub
End Class
