Public Class Form1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value >= ProgressBar1.Maximum Then
            ProgressBar1.Value = 0
            value.Text = ProgressBar1.Value
        Else
            ProgressBar1.Value += 20
        End If
        value.Text = ProgressBar1.Value
        value.Text = "ProgressBar Value:" & value.Text

    End Sub

    Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click
        Timer1.Start()
        If btnstart.Text = "Contoinue" Then
            btnstart.Text = "Start"
        End If
        Timer1.Stop()
        btnstart.Text = "Continue"
    End Sub
End Class
