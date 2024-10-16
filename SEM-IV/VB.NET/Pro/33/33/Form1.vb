Public Class Form1

    Private Sub rightshift_Click(sender As Object, e As EventArgs) Handles rightshift.Click
        lstname1.Items.Add(lstname.SelectedItem)
        lstname.Items.Remove(lstname.SelectedItem)
    End Sub

    Private Sub leftshift_Click(sender As Object, e As EventArgs) Handles leftshift.Click
        lstname.Items.Add(lstname1.SelectedItem)
        lstname1.Items.Remove(lstname1.SelectedItem)
    End Sub

    Private Sub allright_Click(sender As Object, e As EventArgs) Handles allright.Click
        Dim i As Integer
        For i = 0 To lstname1.Items.Count - 1
            lstname.Items.Add(lstname1.Items.Item(i))
        Next
        lstname1.Items.Clear()
    End Sub

    Private Sub allLeft_Click(sender As Object, e As EventArgs) Handles allLeft.Click
        Dim i As Integer
        For i = 0 To lstname.Items.Count - 1
            lstname1.Items.Add(lstname.Items.Item(i))
        Next
        lstname.Items.Clear()
    End Sub

    Private Sub shiftMright_Click(sender As Object, e As EventArgs) Handles shiftMright.Click
        Dim i As Integer
        For i = 0 To lstname1.SelectedItems.Count - 1
            lstname.Items.Add(lstname1.SelectedItems.Item(0))
            lstname1.Items.Remove(lstname1.SelectedItems.Item(0))
        Next
    End Sub

    Private Sub shiftMleft_Click(sender As Object, e As EventArgs) Handles shiftMleft.Click
        Dim i As Integer
        For i = 0 To lstname.SelectedItems.Count - 1
            lstname1.Items.Add(lstname.SelectedItems.Item(0))
            lstname.Items.Add(lstname.SelectedItems.Item(0))
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstname.Items.Add("Aku")
        lstname.Items.Add("Janu")
        lstname.Items.Add("Anchit")
        lstname.Items.Add("Urja")
        lstname.Items.Add("Neeti")

        lstname1.Items.Add("Om")
        lstname1.Items.Add("Sai")
        lstname1.Items.Add("Ram")
        lstname1.Items.Add("Jimi")
        lstname1.Items.Add("Ami")
        lstname1.Items.Add("Jay")
        lstname1.Items.Add("Dev")
    End Sub
End Class
