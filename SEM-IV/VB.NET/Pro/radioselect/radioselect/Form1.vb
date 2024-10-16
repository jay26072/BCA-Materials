Public Class Form1

    Private Sub rdomale_CheckedChanged(sender As Object, e As EventArgs) Handles rdomale.CheckedChanged
        PictureBox1.Image = Image.FromFile("D:\BCA\Sem-IV\VB.NET\Pro\male.jpg")
    End Sub

    Private Sub rdofemale_CheckedChanged(sender As Object, e As EventArgs) Handles rdofemale.CheckedChanged
        PictureBox1.Image = Image.FromFile("D:\BCA\Sem-IV\VB.NET\Pro\female.jpg")
    End Sub
End Class
