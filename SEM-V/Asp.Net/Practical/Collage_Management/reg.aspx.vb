Imports System.Data
Imports System.Data.SqlClient
Partial Class reg
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=DESKTOP-VOGK8O2\SQLEXPRESS;Initial Catalog=collg;Integrated Security=True"
        con.Open()
        cmd = New SqlCommand("insert into reg values('" + Username.Text + "','" + Password.Text + "','" + Gender.SelectedValue + "','" + dept.SelectedValue + "')", con)
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Record Inserted")
    End Sub
End Class
