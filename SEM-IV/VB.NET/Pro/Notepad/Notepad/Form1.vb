Public Class Notepad

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        If Me.Text <> "Notepad" Then
            RichTextBox1.SaveFile(Me.Text, RichTextBoxStreamType.PlainText)
            MsgBox("Your File Save", MsgBoxStyle.Information, "Notepad")
            Me.Text = "Notepad"
            RichTextBox1.Clear()
        Else
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        With OpenFileDialog1
            .Filter = "Text file|*.text|All file(*.*)|*.*"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                RichTextBox1.LoadFile(.FileName, RichTextBoxStreamType.PlainText)
                Me.Text = .FileName
            End If
        End With
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If Me.Text = "Notepad" Then
            With SaveFileDialog1
                .Filter = "Text file|*.txt|All file(*.*)|*.*"
                .Title = "Save file"
                If ShowDialog() = Windows.Forms.DialogResult.OK Then
                    RichTextBox1.SaveFile(.FileName, RichTextBoxStreamType.PlainText)
                    Me.Text = .FileName
                Else
                    RichTextBox1.SaveFile(Me.Text, RichTextBoxStreamType.PlainText)
                    MsgBox("Your File is Saved", MsgBoxStyle.Information, "Notepad")
                End If
            End With
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        With SaveFileDialog1
            .Filter = "Text file|*.txt|All file(*.*)|*.*"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                RichTextBox1.SaveFile(.FileName, RichTextBoxStreamType.PlainText)
                Me.Text = .FileName
            End If
        End With
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PastToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PastToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub SelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectedToolStripMenuItem.Click
        With FontDialog1
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                RichTextBox1.SelectionFont = .Font
            End If
        End With
    End Sub

    Private Sub AllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllToolStripMenuItem.Click
        With FontDialog1
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                RichTextBox1.SelectionFont = .Font
            End If
        End With
    End Sub

    Private Sub SelectedToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SelectedToolStripMenuItem1.Click
        With ColorDialog1
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                RichTextBox1.SelectionColor = .Color
            End If
        End With
    End Sub

    Private Sub LeftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeftToolStripMenuItem.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub CenterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CenterToolStripMenuItem.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub RightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RightToolStripMenuItem.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub BulletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BulletToolStripMenuItem.Click
        RichTextBox1.BulletIndent = 2
        RichTextBox1.SelectionBullet = True
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        RichTextBox1.ZoomFactor = 2
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        RichTextBox1.ZoomFactor = 5
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New FrameStyle
        'frm.showdialog()
    End Sub

    Private Sub Notepad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        RichTextBox1.ZoomFactor = 10
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        RichTextBox1.ZoomFactor = 15
    End Sub
End Class
