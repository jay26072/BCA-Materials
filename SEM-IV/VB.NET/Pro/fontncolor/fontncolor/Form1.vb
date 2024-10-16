Public Class Form1

    Private Sub bgcolor_Click(sender As Object, e As EventArgs) Handles bgcolor.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub fontcolour_Click(sender As Object, e As EventArgs) Handles fontcolour.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub btnfont_Click(sender As Object, e As EventArgs) Handles btnfont.Click
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.Font = FontDialog1.Font
        End If
    End Sub
End Class
