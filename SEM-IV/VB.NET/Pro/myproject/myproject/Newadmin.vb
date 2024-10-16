Imports System.Data.SqlClient
Public Class Newadmin
    Dim cmd As New SqlCommand
    Dim cn As New SqlConnection
    Dim dr As SqlDataReader
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmd = New SqlCommand("insert into user values='" & Val(TextBox1.Text) & +"','" + TextBox2.Text + "','" + TextBox3.Text + "'", cn)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub Newadmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=E:\mayur\computershop\myproject\myproject\newadmin.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        cn.Open()
    End Sub
End Class