Public Class Form1

    Private Sub txtname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtname.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
            e.Handled = True
            ErrorProvider1.SetError(txtname, "Please Enter Only Name")
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub txtage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtage.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
            ErrorProvider1.SetError(txtage, "Please Enter Only Number")
        End If
    End Sub
End Class
