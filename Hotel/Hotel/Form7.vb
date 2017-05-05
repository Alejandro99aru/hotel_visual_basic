Public Class Form7

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Me.Hide()
            Form5.Show()
            Timer1.Stop()
        End If

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Form1.Hide()

    End Sub
End Class