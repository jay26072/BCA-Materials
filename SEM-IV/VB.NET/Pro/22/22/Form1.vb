Public Class Form1

    Private Sub tbdata_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbdata.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then

            e.Handled = True
            MessageBox.Show("Enter Only Charcaters")
        End If
    End Sub
End Class
