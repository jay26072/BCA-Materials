Imports System.Data
Imports System.Data.SqlClient
Partial Class Login
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=DESKTOP-VOGK8O2\SQLEXPRESS;Initial Catalog=Clg;Integrated Security=True"
        con.Open()
        cmd = New SqlCommand("select * from reg where Username'" + Username.Text + "'", con)



    End Sub
End Class
