Public Class Form1

    Private Sub setcol_Click(sender As Object, e As EventArgs) Handles setcol.Click
        With ColorDialog1
            .Color = Color.Orange
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.BackColor = .Color
            End If
        End With
    End Sub
End Class
