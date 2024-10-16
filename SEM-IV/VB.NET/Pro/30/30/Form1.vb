Public Class Form1

    Private Sub Answer_Click(sender As Object, e As EventArgs) Handles Answer.Click
        Dim str As String
        str = "Your Name is " & txtname.Text
        If rdomale.Checked = True Then
            str &= "  Your Gender is Male"
        Else
            str &= "Your Gender is Female"
        End If
        MsgBox(str, MsgBoxStyle.Information, "Hello")
    End Sub
End Class
