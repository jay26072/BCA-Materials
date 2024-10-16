Public Class Form1

    Private Sub Hsred_Scroll(sender As Object, e As ScrollEventArgs) Handles Hsred.Scroll
        PictureBox1.BackColor = Color.FromArgb(Hsred.Value, Hsgreen.Value, Hsblue.Value)
    End Sub

    Private Sub Hsgreen_Scroll(sender As Object, e As ScrollEventArgs) Handles Hsgreen.Scroll
        PictureBox1.BackColor = Color.FromArgb(Hsred.Value, Hsgreen.Value, Hsblue.Value)
    End Sub

    Private Sub Hsblue_Scroll(sender As Object, e As ScrollEventArgs) Handles Hsblue.Scroll
        PictureBox1.BackColor = Color.FromArgb(Hsred.Value, Hsgreen.Value, Hsblue.Value)
    End Sub
End Class
