Imports System.Data.OleDb
Public Class Form1
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=S:\20BCA86\vb\database\demo.accdb")
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

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        clear()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        da = New OleDbDataAdapter
        dt = New DataTable
        cmd = New OleDbCommand("select * from tbldemo where Id= " & txtid.Text & " ", cn)
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
        cmd = New OleDbCommand("update table tbldemo set name='" & txtname.Text & "',contact='" & txtcontact.Text & "',city='" & txtcity.Text & "'", cn)
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
End Class
