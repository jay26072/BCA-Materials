Public Class Form1

    Private Sub btnans_Click(sender As Object, e As EventArgs) Handles btnans.Click
        Dim open As Integer
        open = Shell("C:\Program Files\Notepad++\notepad++.exe", AppWinStyle.NormalFocus)
    End Sub
End Class
