Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim age As Integer = TextBox1.Text
        Select Case age
            Case 1, 2
                lblans.Text = "Child"
            Case 3, 4
                lblans.Text = "You Are In Sr.or Gr.KG"
            Case 5 To 12
                lblans.Text = "You Are In Primary Section"
            Case 13 To 15
                lblans.Text = "You Are In Secondary Section"
            Case 16 To 18
                lblans.Text = "You Are In Higher Secondary"
            Case Else
                lblans.Text = "No idea"
        End Select
    End Sub
End Class
