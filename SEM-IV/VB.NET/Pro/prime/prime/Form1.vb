Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim n As Integer

        n = TextBox1.Text
        For i = 2 To n - 1
            If n Mod i = 0 Then
                lblans.Text = "Number Is Not Prime"
                Exit Sub
            End If
        Next
        lblans.Text = "Number Is Prime"
    End Sub
End Class
