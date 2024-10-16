Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value >= ProgressBar1.Maximum Then
            ProgressBar1.Value = 0
            lblprocess.Text = ProgressBar1.Value
        Else
            ProgressBar1.Value += 20
        End If
        lblprocess.Text = ProgressBar1.Value
        lblprocess.Text = "ProgressBar Value: " & lblprocess.Text

    End Sub

    Private Sub btnstart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstart.Click
        Timer1.Start()
        If btnstart.Text = "Continue" Then
            btnstart.Text = "Start"
        End If
    End Sub

    Private Sub btnstop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstop.Click
        Timer1.Stop()
        btnstart.Text = "Continue"
    End Sub
End Class
