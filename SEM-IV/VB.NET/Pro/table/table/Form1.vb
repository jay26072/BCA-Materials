Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1, n2, i As Integer
        n1 = 5
        n2 = 10
        For i = 1 To n2
            Dim a As Integer
            a = n1 * i
            lbltable.Text = lbltable.Text & n1 & " * " & i & " = " & a
            lbltable.Text = lbltable.Text & vbCrLf
        Next
    End Sub
End Class
