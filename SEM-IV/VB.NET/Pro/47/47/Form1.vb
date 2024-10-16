Public Class Form1

    Private Sub btnans_Click(sender As Object, e As EventArgs)
        Dim node As New TreeNode
        node = TreeView1.Nodes.Item(1)
        MsgBox(node.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.Columns.Add("Director", 70, HorizontalAlignment.Left)
        ListView1.Columns.Add("Movie", 60, HorizontalAlignment.Left)
        'ListView1.Columns.Add("Review", 40, HorizontalAlignment.Left)

        ListView1.Items.Add("Yash C.")
        ListView1.Items.Add("Sanjay B.")
        ListView1.Items.Add("Rakesh R.")

        ListView1.Items(0).SubItems.Add("Lamhe")
        ListView1.Items(1).SubItems.Add("Devdas")
        ListView1.Items(2).SubItems.Add("Krish")
    End Sub
End Class
