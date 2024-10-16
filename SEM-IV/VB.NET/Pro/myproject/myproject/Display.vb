Imports System.Data.SqlClient
Public Class Displayitem
    Dim cmd As New SqlCommand
    Dim cn As New SqlConnection
    Dim dr As SqlDataReader
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim bs As New BindingSource
    Dim da As New SqlDataAdapter
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ds = New DataSet
        tables = ds.Tables
        da = New SqlDataAdapter("select * from additem", cn)
        da.Fill(ds, "additem")
        Dim view As New DataView(tables(0))
        bs.DataSource = view
        DataGridView1.DataSource = view
    End Sub

    Private Sub Displayitem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=E:\project\myproject\myproject\newadmin.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        cn.Open()
        DataGridView1.ForeColor = Color.Black
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class