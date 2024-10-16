Imports System.Data.OleDb
Public Class Form1
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim ds As DataSet
    Dim source As New BindingSource
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\BCA\Sem-IV\VB.NET\Pro\students.accdb")
        cn.Open()
        MsgBox("DATABASE IS CONNECTED")
        cn.Close()
    End Sub

    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        cmd = New OleDbCommand("Insert into studinfo values(' " & txtid.Text & " ',' " & txtname.Text & " ','" & txtcity.Text & " ',' " & txtcourse.Text & " ','" & txtdob.Text & " ',' " & txtadd.Text & "' )", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("RECORD INSERTED SUCCESSFULLY!")
        clear()
    End Sub
    Sub clear()
        txtid.Clear()
        txtname.Clear()
        txtcity.Clear()
        txtcourse.Clear()
        txtdob.Clear()
        txtadd.Clear()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        cmd = New OleDbCommand("update studinfo set NAME ='" & txtname.Text & "',CITY= '" & txtcity.Text & "',COURSE=' " & txtcourse.Text & " ',DOB=' " & txtdob.Text & " ', ADDRESS= ' " & txtadd.Text & " '  where ID=" & txtid.Text & "", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("RECORD UPDATED SUCCESSFULLY")
        clear()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        clear()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        da = New OleDbDataAdapter
        dt = New DataTable
        cmd = New OleDbCommand("select*from studinfo where ID=" & txtid.Text & "", cn)
        cn.Open()
        da.SelectCommand = cmd
        da.Fill(dt)
        cn.Close()
        txtid.Text = dt.Rows(0).Item(0)
        txtname.Text = dt.Rows(0).Item(1)
        txtcity.Text = dt.Rows(0).Item(2)
        txtcourse.Text = dt.Rows(0).Item(3)
        txtdob.Text = dt.Rows(0).Item(4)
        txtadd.Text = dt.Rows(0).Item(5)

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        cmd = New OleDbCommand("delete from studinfo where id=" & txtid.Text & " ", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("RECORD DELETED SUCCESSFULLY")
        clear()

    End Sub

    Private Sub btnview_Click(sender As Object, e As EventArgs) Handles btnview.Click
        cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\BCA\Sem-IV\VB.NET\Pro\students.accdb")
        ds = New DataSet
        Dim tables As DataTableCollection
        tables = ds.Tables
        da = New OleDbDataAdapter("Select* from studinfo", cn)
        da.Fill(ds, "studinfo")
        Dim view As New DataView(tables(0))
        source.DataSource = view
        DataGridView1.DataSource = view
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtid.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        txtname.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        txtcity.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        txtcourse.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        txtdob.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        txtadd.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
    End Sub
End Class
