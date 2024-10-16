Public Class Form1


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnN.Click
        Dim i As Integer
        For i = 1 To TextBox1.Text
            TextBox2.Text &= i & Space(2)
        Next
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

        e.Handled = Not Char.IsDigit(e.KeyChar)

    End Sub

End Class
