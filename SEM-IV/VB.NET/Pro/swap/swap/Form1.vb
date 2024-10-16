Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnswp.Click
        Dim x, y As Integer
        x = TextBox1.Text
        y = TextBox2.Text
        swap(x, y)
        TextBox3.Text = x
        TextBox4.Text = y
    End Sub
    Sub swap(ByRef a As Integer, ByRef b As Integer)
        Dim temp As Integer
        temp = a
        a = b
        b = temp
    End Sub
End Class
