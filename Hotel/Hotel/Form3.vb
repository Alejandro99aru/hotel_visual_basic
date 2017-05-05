Public Class Form3
    Private Sub bt_save_Click(sender As Object, e As EventArgs) Handles bt_save.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim writer As New IO.StreamWriter(SaveFileDialog1.FileName)
        writer.Write(RichTextBox1.Text)
        writer.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bt_vista.Click
        If RichTextBox1.Text = "" Then
            MsgBox("Error", "Mensaje")
        Else
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font1 As New Font("Comic sans MS", 16, FontStyle.Bold)

        e.Graphics.DrawString(RichTextBox1.Text, font1, Brushes.Black, 200, 200)

    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load
        Dim font1 As New Font("Comic sans MS", 16, FontStyle.Bold)


    End Sub

    Private Sub bt_imprimir_Click(sender As Object, e As EventArgs) Handles bt_imprimir.Click

    End Sub
End Class