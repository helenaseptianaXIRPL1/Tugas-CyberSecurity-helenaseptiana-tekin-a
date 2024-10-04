Public Class Form1
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        TextBox1.Clear()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim openFile As New OpenFileDialog()
        openFile.Filter = "Text Files|*.txt"
        If openFile.ShowDialog() = DialogResult.OK Then
            TextBox1.Text = System.IO.File.ReadAllText(openFile.FileName)
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim saveFile As New SaveFileDialog()
        saveFile.Filter = "Text Files|*.txt"
        If saveFile.ShowDialog() = DialogResult.OK Then
            System.IO.File.WriteAllText(saveFile.FileName, TextBox1.Text)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        TextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        TextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        TextBox1.Paste()
    End Sub
End Class
