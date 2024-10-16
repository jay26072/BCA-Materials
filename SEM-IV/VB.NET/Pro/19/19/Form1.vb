Public Class Form1

    Private Sub btnans_Click(sender As Object, e As EventArgs) Handles btnans.Click
        txtsqr.Text = sqr(txtinput.Text)
        txtcub.Text = cube(txtinput.Text)
    End Sub
    Function sqr(ByVal no As Integer) As Integer
        Return no * no
    End Function
    Function cube(ByVal no As Integer) As Integer
        Return no * no * no
    End Function
End Class
