Public Class Form1

    Private Sub btncut_Click(sender As Object, e As EventArgs) Handles btncut.Click
        txtdata.Cut()
    End Sub

    Private Sub btncpy_Click(sender As Object, e As EventArgs) Handles btncpy.Click
        txtdata.Copy()
    End Sub

    Private Sub btnpst_Click(sender As Object, e As EventArgs) Handles btnpst.Click
        txtdata.Paste()
    End Sub

    Private Sub btnundo_Click(sender As Object, e As EventArgs) Handles btnundo.Click
        txtdata.Undo()
    End Sub

    Private Sub btnredo_Click(sender As Object, e As EventArgs) Handles btnredo.Click
        If txtdata.CanRedo = True Then
            txtdata.Undo()
            txtdata.ClearUndo()
        End If
    End Sub

    Private Sub btnclr_Click(sender As Object, e As EventArgs) Handles btnclr.Click
        txtdata.Clear()
    End Sub

    Private Sub upper_Click(sender As Object, e As EventArgs) Handles upper.Click
        txtdata.Text = UCase(txtdata.Text)

    End Sub

    Private Sub Lower_Click(sender As Object, e As EventArgs) Handles Lower.Click
        txtdata.Text = LCase(txtdata.Text)
    End Sub
End Class
