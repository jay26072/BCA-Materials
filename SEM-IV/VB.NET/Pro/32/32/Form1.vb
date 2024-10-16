Public Class Form1

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        lstname.Items.Add(txtname.Text)
        txtname.Clear()
    End Sub

    Private Sub remove_Click(sender As Object, e As EventArgs) Handles remove.Click
        If lstname.Items.Contains(txtname.Text) Then
            lstname.Items.Remove(txtname.Text)
        End If
        txtname.Clear()
    End Sub

    Private Sub insert_Click(sender As Object, e As EventArgs) Handles insert.Click
        lstname.Items.Insert(txtpos.Text, txtval.Text)
        txtpos.Clear()
        txtval.Clear()
    End Sub
End Class
