Imports System.Data.SqlClient
Public Class searchitems
    Dim cmd As New SqlCommand
    Dim cn As New SqlConnection
    Dim dr As SqlDataReader
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim bs As New BindingSource
    Dim da As New SqlDataAdapter
    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.Click
        cmd = New SqlCommand("select * from additem where itemnm='" + txtSearch.Text + "'", cn)
        dr = cmd.ExecuteReader
        If dr.Read Then
            MsgBox("Record found")
        Else
            MsgBox("record does not exist")
        End If
        DataGridView1.DataSource = dr
        dr.Close()
        ds = New DataSet
        tables = ds.Tables
        da = New SqlDataAdapter("select * from additem where itemnm='" + txtSearch.Text + "'", cn)
        da.Fill(ds, "additem")
        Dim view1 As New DataView(tables(0))
        bs.DataSource = view1
        DataGridView1.DataSource = view1
    End Sub

    Private Sub searchitems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=E:\project\myproject\myproject\newadmin.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        cn.Open()
        DataGridView1.ForeColor = Color.Black
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class