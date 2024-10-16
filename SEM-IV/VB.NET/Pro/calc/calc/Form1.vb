Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Btnsum_Click(sender As Object, e As EventArgs) Handles Btnsum.Click
        TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
    End Sub

    Private Sub Btnsub_Click(sender As Object, e As EventArgs) Handles Btnsub.Click
        TextBox3.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
    End Sub

    Private Sub Btnmul_Click(sender As Object, e As EventArgs) Handles Btnmul.Click
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
    End Sub

    Private Sub Btndiv_Click(sender As Object, e As EventArgs) Handles Btndiv.Click
        TextBox3.Text = Val(TextBox1.Text) / Val(TextBox2.Text)
    End Sub

    Private Sub Btnclear_Click(sender As Object, e As EventArgs) Handles Btnclear.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub
End Class