Imports System.Data.SqlClient
Public Class Form1
    Dim cmd As New SqlCommand
    Dim cn As New SqlConnection
    Dim dr As SqlDataReader
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmd = New SqlCommand("select * from tbl_reg where username='" & txtuname.Text & "' and password='" & txtpass.Text & "'", cn)
        dr = cmd.ExecuteReader
        If txtuname.Text = "" And txtpass.Text = "" Then
            MsgBox("fill the username or password")
        End If
        If dr.Read Then
            MsgBox("log in successfull!")
            'Me.Hide()
            computer_billing_system.Show()
            Me.Visible = False
        Else
            MsgBox("incorrect login!")
        End If
        dr.Close()
        txtuname.Text = ""
        txtpass.Text = ""
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=E:\project\myproject\myproject\newadmin.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        cn.Open()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        forgotpwd.Show()
        Me.Visible = False
    End Sub
End Class
