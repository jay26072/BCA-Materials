Public Class calc
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Integer
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = a + b
        Label4.Text = c


    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a, b, c As Integer
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = a - b
        Label4.Text = c
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a, b, c As Integer
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = a * b
        Label4.Text = c
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a, b, c As Integer
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = a / b
        Label4.Text = c
    End Sub
End Class