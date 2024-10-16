Imports System.Data.OleDb
Public Class Form1
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim ds As DataSet
    Dim source As New BindingSource
    Dim i As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=V:\dot net\demo.accdb")
        cn.Open()
        MsgBox("Database Connected")
        cn.Close()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        cmd = New OleDbCommand("insert into tbldemo values('" & txtid.Text & "','" & txtname.Text & "','" & txtcontact.Text & "','" & txtcity.Text & "')", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Record Insterted Succesfully")
        clear()
    End Sub
    Sub clear()
        txtid.Clear()
        txtname.Clear()
        txtcity.Clear()
        txtcontact.Clear()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        clear()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        da = New OleDbDataAdapter
        dt = New DataTable
        cmd = New OleDbCommand("Select * from tbldemo where Id= " & txtid.Text & "", cn)
        cn.Open()
        da.SelectCommand = cmd
        da.Fill(dt)
        cn.Close()
        txtid.Text = dt.Rows(0).Item(0)
        txtname.Text = dt.Rows(0).Item(1)
        txtcontact.Text = dt.Rows(0).Item(2)
        txtcity.Text = dt.Rows(0).Item(3)
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        cmd = New OleDbCommand("update tbldemo set name='" & txtname.Text & "',contact='" & txtcontact.Text & "',city='" & txtcity.Text & "'where id=" & txtid.Text & " ", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Record Updated")
        clear()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        cmd = New OleDbCommand("delete from tbldemo where id=" & txtid.Text & "", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Record Deleted")
        clear()
    End Sub

    Private Sub btnview_Click(sender As Object, e As EventArgs) Handles btnview.Click
        cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=V:\dot net\demo.accdb")
        ds = New DataSet
        Dim tables As DataTableCollection
        tables = ds.Tables
        da = New OleDbDataAdapter("Select * from tbldemo", cn)
        da.Fill(ds, "tbldemo")
        Dim view As New DataView(tables(0))
        source.DataSource = view
        DataGridView1.DataSource = view
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtid.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        txtname.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txtcontact.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        txtcity.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
    End Sub
End Class
