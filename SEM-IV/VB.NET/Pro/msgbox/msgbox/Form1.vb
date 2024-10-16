Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' MessageBox.Show("Welcome", "Hello", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        Dim a As String
        a = InputBox("Enter Your Name:", "Demo")
        MessageBox.Show(a)
    End Sub
End Class
