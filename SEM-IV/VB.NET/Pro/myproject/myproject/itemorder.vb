Imports System.Data.SqlClient
Imports System.Data.DataRowView
Public Class itemorder
    Dim cmd As New SqlCommand
    Dim cn As New SqlConnection
    Dim dr As SqlDataReader
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim bs As New BindingSource
    Dim da As New SqlDataAdapter

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'you must enter the itemquntyty neither the total will display 0..
        TextBox8.Text = Val(TextBox5.Text) * Val(TextBox7.Text)
        cmd = New SqlCommand("insert into itemorder values('" + TextBox1.Text + "','" + ComboBox1.SelectedText + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox11.Text + "','" + TextBox10.Text + "','" + TextBox9.Text + "','" + TextBox5.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "')", cn)
        cmd.ExecuteNonQuery()
        MsgBox("record saved!")
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub itemorder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Celldrop.additem' table. You can move, or remove it, as needed.
        Me.AdditemTableAdapter.Fill(Me.Celldrop.additem)
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=E:\project\myproject\myproject\newadmin.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        cn.Open()
        DataGridView1.ForeColor = Color.Black
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        cmd = New SqlCommand("select * from additem where itemnm='" + ComboBox1.SelectedValue + "'", cn)
        dr = cmd.ExecuteReader
        If dr.Read Then
            TextBox1.Text = dr.Item(0)
            TextBox3.Text = dr.Item(2)
            TextBox5.Text = dr.Item(3)
        End If
        dr.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        showdata()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        ComboBox1.Text = ""
    End Sub
    Public Sub showdata()
        ds = New DataSet
        tables = ds.Tables
        da = New SqlDataAdapter("select * from itemorder", cn)
        da.Fill(ds, "itemorder")
        Dim view As New DataView(tables(0))
        bs.DataSource = view
        DataGridView1.DataSource = view
    End Sub
End Class