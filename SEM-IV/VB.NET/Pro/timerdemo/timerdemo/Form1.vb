Public Class Form1
    Dim i As Integer
    Dim s(9) As Color
    Dim left As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        s(0) = Color.DarkBlue
        s(1) = Color.Gray
        s(2) = Color.Khaki
        s(3) = Color.OliveDrab
        s(4) = Color.Violet
        s(5) = Color.Chocolate
        s(6) = Color.WhiteSmoke
        s(7) = Color.Magenta
        s(9) = Color.Bisque
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.BackColor = s(i)
        Label1.ForeColor = s(i + 1)
        i = i + 1
        If i = 8 Then
            i = 0
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If left = False Then
            Label1.Left = Label1.Left + 50
            If Label1.Left >= 700 Then
                left = True
            End If
        ElseIf left = True Then
            Label1.Left = Label1.Left - 50
            If Label1.Left <= 10 Then
                left = False
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub
End Class
