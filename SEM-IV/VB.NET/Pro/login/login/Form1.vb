Public Class Form1

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        If user.Text = "SAI RAM" And pass.Text = "123" Then
            MsgBox("login Sucessfully")
        Else
            MsgBox("Access Denine")
        End If
    End Sub
End Class
