Public Class Form1

    Private Sub btnchk_Click(sender As Object, e As EventArgs) Handles btnchk.Click
        Dim str As String
        Dim i As Integer

        For i = 0 To chklstname.Items.Count - 1
            str = chklstname.Items.Item(i)
            If str.StartsWith(txtname.Text) = True Then
                chklstname.SetItemChecked(i, True)
            Else
                chklstname.SetItemChecked(i, False)
            End If
        Next
    End Sub

    Private Sub btnunchk_Click(sender As Object, e As EventArgs) Handles btnunchk.Click
        Dim i As Integer
        For i = 0 To chklstname.Items.Count - 1
            chklstname.SetItemChecked(i, False)
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chklstname.Items.Add("Parth")
        chklstname.Items.Add("Bhvik")
        chklstname.Items.Add("Khushi")
        chklstname.Items.Add("Catan")
        chklstname.Items.Add("Divya")
        chklstname.Items.Add("Jay")
        chklstname.Items.Add("Keval")
        chklstname.Items.Add("Hardik")
    End Sub
End Class
