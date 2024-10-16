Public Class Form1

    Private Sub TrackBarRed_Scroll(sender As Object, e As EventArgs) Handles TrackBarRed.Scroll, TrackBarGreen.Scroll, TrackBarBlue.Scroll
        Me.BackColor = Color.FromArgb(TrackBarRed.Value, TrackBarGreen.Value, TrackBarBlue.Value)
        txtred.Text = TrackBarRed.Value
        txtgreen.Text = TrackBarGreen.Value
        txtblue.Text = TrackBarBlue.Value

    End Sub
End Class
