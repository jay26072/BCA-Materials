Imports System.Data.OleDb
Public Class Form1
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim ds As DataSet
    Dim source As BindingSource

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\BCA\Sem-IV\VB.NET\Pro\item.accdb")
        cn.Open()
        MsgBox("DATABASE CONNECTED")
        cn.Close()
    End Sub

    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        cmd = New OleDbCommand("insert into item_mst values('" & txtid.Text & "','" & txtname.Text & "','" & txtcost.Text & "','" & txtqty.Text & "', '" & txtitemtype.Text & " ')", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("record inserted successfully")
        Clear()
    End Sub
    Sub clear()
        txtid.Clear()
        txtname.Clear()
        txtcost.Clear()
        txtqty.Clear()
        txtitemtype.Clear()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        clear()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        cmd = New OleDbCommand("update item_mst set NAME='" & txtname.Text & "', COST='" & txtcost.Text & "' ,QUANTITY= '" & txtqty.Text & "' ,TYPE= '" & txtitemtype.Text & "' where ID=" & txtid.Text & " ", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("RECORD UPDATED SUCCESSFULLY")

    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        da = New OleDbDataAdapter
        dt = New DataTable
        cmd = New OleDbCommand("select * from item_mst where ID=" & txtid.Text & " ", cn)
        cn.Open()
        da.SelectCommand = cmd
        da.Fill(dt)
        cn.Close()

        txtid.Text = dt.Rows(0).Item(0)
        txtname.Text = dt.Rows(0).Item(1)
        txtcost.Text = dt.Rows(0).Item(2)
        txtqty.Text = dt.Rows(0).Item(3)
        txtitemtype.Text = dt.Rows(0).Item(4)

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        cmd = New OleDbCommand("delete from item_mst where ID=" & txtid.Text & "", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("RECORD DELETED SUCCESSFULLY")
        clear()

    End Sub

    Private Sub btnview_Click(sender As Object, e As EventArgs) Handles btnview.Click
        cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\BCA\Sem-IV\VB.NET\Pro\item.accdb")
        ds = New DataSet
        da = New OleDbDataAdapter
        Dim tables As DataTableCollection
        tables = ds.Tables
        cmd = New OleDbCommand("select * from item_mst where Quantity=0", cn)
        cn.Open()
        da.SelectCommand = cmd
        da.Fill(ds, "item_mst")
        Dim view1 As New DataView(tables(0))
        DataGridView1.DataSource = view1

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txtid.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        txtname.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        txtcost.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        txtqty.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        txtitemtype.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()

    End Sub
End Class
