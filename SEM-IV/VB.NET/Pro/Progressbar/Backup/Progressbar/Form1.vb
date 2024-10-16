Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'it test if the progressbar current value is greater than or equal to the set maximum value
        If ProgressBar1.Value >= ProgressBar1.Maximum Then
            'if it is true the progress bar value will be reset into 0
            ProgressBar1.Value = 0
            lblprocess.Text = ProgressBar1.Value
        Else
            'else the progressbar value will incremented by 20 until such time it will reach the maximum value
            ProgressBar1.Value += 20
        End If
        lblprocess.Text = ProgressBar1.Value
        lblprocess.Text = "ProgressBar Value: " & lblprocess.Text

    End Sub

    Private Sub btnstart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstart.Click
        'it start the timer
        Timer1.Start()
        'check if the button text is set into Continue the it will set into Start
        If btnstart.Text = "Continue" Then
            btnstart.Text = "Start"
        End If
    End Sub

    Private Sub btnstop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstop.Click
        'it stop the timer
        Timer1.Stop()
        'set the text of btstart into Continue
        btnstart.Text = "Continue"
        
    End Sub

End Class
