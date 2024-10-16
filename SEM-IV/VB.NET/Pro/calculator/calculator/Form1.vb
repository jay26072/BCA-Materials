Public Class Form1
    Dim no1 As Double
    Dim op As Char
    Private Sub btn0_Click(ByVal sender As Object, e As EventArgs) Handles btn0.Click, btn00.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        txtcalval.Text = sender.text

    End Sub

    Private Sub btndiv_Click(sender As Object, e As EventArgs) Handles btndiv.Click, btnsub.Click, btnsum.Click, btnmul.Click
        no1 = txtcalval.Text
        txtcalval.Clear()
        op = sender.text
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtcalval.Clear()
    End Sub

    Private Sub btneqal_Click(ByVal sender As Object, e As EventArgs) Handles btneqal.Click
        If op = "+" Then
            txtcalval.Text = no1 + Val(txtcalval.Text)
        ElseIf op = "-" Then
            txtcalval.Text = no1 - txtcalval.Text
        ElseIf op = "X" Then
            txtcalval.Text = no1 * txtcalval.Text
        ElseIf op = "/" Then
            txtcalval.Text = no1 / txtcalval.Text
        End If
    End Sub
End Class