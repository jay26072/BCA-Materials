Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String
        str = TextBox1.Text
        TextBox2.Text = str.Length()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim str, str1 As String
        str = "Hello"
        str1 = TextBox1.Text
        TextBox2.Text = String.Compare(str, str1)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim str, str1 As String
        str = "Hello ,"
        str1 = TextBox1.Text
        TextBox2.Text = String.Concat(str, str1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim str1, str2 As String
        str1 = TextBox1.Text
        str2 = String.Copy(str1)
        TextBox2.Text = str2
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim str1 As String = TextBox1.Text
        Dim str2 As String = "Jay"
        If String.Equals(str1, str2) Then
            TextBox2.Text = "String Equals"
        Else
            TextBox2.Text = "String Not Equals"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim str As String = TextBox1.Text
        MsgBox(str.Length)
        str = str.Trim
        MsgBox(str.Length)
        TextBox2.Text = str
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim str As String
        str = TextBox1.Text
        If str.EndsWith("Jay") = True Then
            TextBox2.Text = "String EndsWith -->'Jay'"
        Else
            TextBox2.Text = "String Not EndsWith -->'Jay'"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim str As String
        str = TextBox1.Text
        TextBox2.Text = str.IndexOf("Jay")
    End Sub
End Class
