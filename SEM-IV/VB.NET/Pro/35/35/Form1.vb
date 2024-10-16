Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With cmbno.Items
            .Add("1")
            .Add("2")
            .Add("3")
            .Add("4")
            .Add("5")
            .Add("6")
        End With
        With cmbname.Items
            .Add("Jay")
            .Add("Parth")
            .Add("Keval")
            .Add("Khushi")
            .Add("Mayur")
            .Add("Vivek")
        End With
    End Sub

    Private Sub cmbno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbno.SelectedIndexChanged
        cmbname.SelectedIndex = cmbno.SelectedIndex
    End Sub

    Private Sub cmbname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbname.SelectedIndexChanged
        cmbno.SelectedIndex = cmbname.SelectedIndex
    End Sub
End Class
