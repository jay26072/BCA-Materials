﻿Public Class Form1

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        tblans.Text = ""
        Dim i As Integer
        For i = 1 To 10
            tblans.Text &= TrackBar1.Value & " X " & i & " = " & (TrackBar1.Value * i) & vbNewLine
        Next

    End Sub
End Class
