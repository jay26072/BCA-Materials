Public Class Form1
    Public Function factorial(ByVal number As Integer) As Integer
        Dim ans As Integer = 2
        If number = 0 Or number = 1 Then ans = 1
        If number < 0 Or number > 12 Then
            Return -9999
        End If
        If number > 2 Then
            For index As Integer = 3 To number
                ans = ans * index
            Next
        End If
        Return ans

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        For index As Integer = 1 To 5
            ListBox1.Items.Add("Factorial of " & index.ToString & " Is = " & factorial(index).ToString)
        Next
    End Sub
End Class
