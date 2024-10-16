Public Class Form1

    Private Sub chknum_Click(sender As Object, e As EventArgs) Handles chknum.Click
        Dim n As Integer
        n = TextBox1.Text
        If TextBox1.Text Mod 2 = 0 Then
            chkans.Text = ("Even Number Is " & n)
        Else
            chkans.Text = ("Odd Number Is " & n)
        End If
    End Sub

    Private Sub clrtxt_Click(sender As Object, e As EventArgs) Handles clrtxt.Click
        chkans.Text = ""
        TextBox1.Clear()

    End Sub
End Class
