Imports System.Data.SqlClient
Public Class addnewitem
    Dim cmd As New SqlCommand
    Dim cn As New SqlConnection
    Dim dr As SqlDataReader
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim bs As New BindingSource
    Dim da As New SqlDataAdapter
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub addnewitem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=E:\project\myproject\myproject\newadmin.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        cn.Open()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cmd = New SqlCommand("insert into additem values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')", cn)
        cmd.ExecuteNonQuery()
        MsgBox("record saved!")
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmd = New SqlCommand("delete from additem where itemid='" + TextBox1.Text + "'", cn)
        cmd.ExecuteNonQuery()
        MsgBox("record deleted!")
        Call cleardata()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        cmd = New SqlCommand("update  additem  set itemnm='" + TextBox2.Text + "',itemdescription='" + TextBox3.Text + "',price='" + TextBox4.Text + "' where itemid='" + TextBox1.Text + "'", cn)
        cmd.ExecuteNonQuery()
        MsgBox("records updated!")
        Call cleardata()
    End Sub
    Public Sub cleardata()
        TextBox1.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'ds = New DataSet
        'tables = ds.Tables
        'da = New SqlDataAdapter("SELECT * FROM additem WHERE itemid='" + TextBox1.Text + "'", cn)
        'da.Fill(ds, "additem")
        'MsgBox("record found")
        'da.Fill(ds)
        'DataGridView1.DataSource = ds
    End Sub
End Class