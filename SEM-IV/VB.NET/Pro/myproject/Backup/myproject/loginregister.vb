Imports System.Data.SqlClient
Public Class loginregister
    Dim cmd As New SqlCommand
    Dim cn As New SqlConnection
    Dim dr As SqlDataReader
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim bs As New BindingSource
    Dim da As New SqlDataAdapter
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cmdutype.Text = "" Then
            MsgBox("select usertype")
        ElseIf txtuname.Text = "" Then
            MsgBox("enter username")
        ElseIf txtpass.Text = "" Then
            MsgBox("enter password")
        Else
            cmd = New SqlCommand("insert into tbl_reg values('" & cmdutype.Text & "','" & txtuname.Text & "','" & txtpass.Text & "')", cn)
            cmd.ExecuteNonQuery()
            MsgBox("record added")
            loadgrid()
            Call clear()
        End If
    End Sub

    Private Sub loginregister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=E:\project\myproject\myproject\newadmin.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        cn.Open()
        DataGridView1.ForeColor = Color.Black
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cmd = New SqlCommand("update tbl_reg set usertype='" & cmdutype.Text & "',username='" & txtuname.Text & "',password='" & txtpass.Text & "'", cn)
        cmd.ExecuteNonQuery()
        MsgBox("record updated")
        DataGridView1.ForeColor = Color.Black
        loadgrid()
        Call clear()
    End Sub
    Public Sub loadgrid()
        ds = New DataSet
        tables = ds.Tables
        da = New SqlDataAdapter("select * from tbl_reg", cn)
        da.Fill(ds, "tbl_reg")
        Dim view As New DataView(tables(0))
        bs.DataSource = view
        DataGridView1.ForeColor = Color.Black
        DataGridView1.DataSource = view
    End Sub
    Public Sub clear()
        cmdutype.SelectedIndex = -1
        txtuname.Text = ""
        txtpass.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cmd = New SqlCommand("delete from tbl_reg where username='" & txtuname.Text & "'", cn)
        cmd.ExecuteNonQuery()
        MsgBox("record deleted")
        DataGridView1.ForeColor = Color.Black
        clear()
        loadgrid()
    End Sub
End Class