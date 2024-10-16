Public Class Form1
    Public Class EmployeeEntity
        Public eid As Integer
        Public ename As String
        Public edoj As DateTime
    End Class

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim obj As New EmployeeEntity

        obj.eid = txtid.Text
        obj.ename = txtname.Text
        obj.edoj = Convert.ToDateTime(txtdoj.Text)

        ListBox1.Items.Add(obj.eid & "--" & obj.ename & "--" & obj.edoj)
        txtid.Clear()
        txtname.Clear()
        txtdoj.Clear()
    End Sub

    Private Sub btndisplay_Click(sender As Object, e As EventArgs) Handles btndisplay.Click
        ComboBox1.Items.Add(ListBox1.Items(0))
        ComboBox1.Items.Add(ListBox1.Items(1))
        ComboBox1.Items.Add(ListBox1.Items(2))
        ComboBox1.Items.Add(ListBox1.Items(3))
        ComboBox1.Items.Add(ListBox1.Items(4))
    End Sub
End Class
