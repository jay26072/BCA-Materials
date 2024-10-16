Imports System.Data.OleDb
Public Class Form1
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim ds As DataSet
    Dim source As New BindingSource
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\BCA\Sem-IV\VB.NET\Pro\exam\groceryitem.accdb")
        cn.Open()
        MsgBox("Databbase Connected")
        cn.Close()
    End Sub

    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        cmd = New OleDbCommand("insert into grocerymst values('" & txtno.Text & "','" & txtname.Text & "','" & txtmrp.Text & "','" & txtsell.Text & "','" & txtqty.Text & "')", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Record Insert Sucessfully")
        cn.Close()
        clear()
    End Sub
    Sub clear()
        txtno.Clear()
        txtname.Clear()
        txtmrp.Clear()
        txtsell.Clear()
        txtqty.Clear()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        cmd = New OleDbCommand("update grocerymst set Name='" & txtname.Text & "',MRP='" & txtmrp.Text & "',Sell Price='" & txtsell.Text & "',Quantity='" & txtqty.Text & "' where No=" & txtno.Text & "", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Record Updated Sucessfully")
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        cmd = New OleDbCommand("delete from grocerymst where No=" & txtno.Text & "", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Record Delete Sucessfully")
        clear()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clear()
    End Sub

    Private Sub btnview_Click(sender As Object, e As EventArgs) Handles btnview.Click
        cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\BCA\Sem-IV\VB.NET\Pro\exam\groceryitem.accdb")
        ds = New DataSet
        Dim tables As DataTableCollection
        tables = ds.Tables
        da = New OleDbDataAdapter("Select * from grocerymst", cn)
        da.Fill(ds, "grocertmst")
        Dim view As New DataView(tables(0))
        source.DataSource = view
        DataGridView1.DataSource = view

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtno.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        txtname.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txtmrp.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        txtsell.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        txtqty.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
    End Sub
End Class
