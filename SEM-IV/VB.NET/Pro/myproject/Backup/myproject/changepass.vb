Imports System.Data.SqlClient
Public Class changepass
    Dim cmd As New SqlCommand
    Dim cn As New SqlConnection
    Dim dr As SqlDataReader
    Private Sub changepass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=E:\project\myproject\myproject\newadmin.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        cn.Open()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'On Error Resume Next
        ' a.connect()
        ' RS = New ADODB.Recordset
        'RS.Open("select Password from Users where User_Name='" & Main.UserLabel.Text & "'", a.CN, 3, 3)
        'If (TextBox1.Text = rs.Fields("Password").Value) Then
        'If (TextBox2.Text = TextBox3.Text) Then
        'rs.Fields("Password").Value = TextBox2.Text
        'rs.Update()
        'MsgBox("Password Changed Successfully")
        'Me.Close()
        'Main.IsMdiContainer = False
        'Else
        'MsgBox("Password Does Not Match", MsgBoxStyle.Critical)
        'Call Clear()
        'End If
        'Else
        'MsgBox("Passwords Does Not Match", MsgBoxStyle.Critical)
        'Call Clear()
        'End If
        'a.CN.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class