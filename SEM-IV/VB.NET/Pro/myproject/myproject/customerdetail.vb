Imports System.Data.SqlClient
Public Class customerdetail
    Dim cmd As New SqlCommand
    Dim cn As New SqlConnection
    Dim dr As SqlDataReader
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim bs As New BindingSource
    Dim da As New SqlDataAdapter
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cmd = New SqlCommand("insert into custdetail values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')", cn)
        cmd.ExecuteNonQuery()
        MsgBox("record saved!")
    End Sub

    Private Sub customerdetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=E:\project\myproject\myproject\newadmin.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        cn.Open()
        DataGridView1.ForeColor = Color.Black
    End Sub
    Public Sub cleardata()
        TextBox1.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ds = New DataSet
        tables = ds.Tables
        da = New SqlDataAdapter("select * from custdetail", cn)
        da.Fill(ds, "custdetail")
        Dim view As New DataView(tables(0))
        bs.DataSource = view
        DataGridView1.DataSource = view
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        cmd = New SqlCommand("update  custdetail  set address='" + TextBox2.Text + "',city='" + TextBox3.Text + "',mono='" + TextBox4.Text + "' where custname='" + TextBox1.Text + "'", cn)
        cmd.ExecuteNonQuery()
        MsgBox("records updated!")
        Call cleardata()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class