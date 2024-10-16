Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = Val((TextBox1.Text * 9 / 5)) + 32
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = Val(TextBox1.Text * 0.013)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox2.Text = Val(TextBox1.Text * 0.01)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox2.Text = Val(TextBox1.Text * 0.012)
    End Sub
End Class
