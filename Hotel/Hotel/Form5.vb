Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txtbox_name.Text = "" Or txtbox_email.Text = "" Then

            Label2.Visible = True
            Label2.Text = "No has introducido tu email o tu nombre"
        Else
            Module1.email = txtbox_email.Text
            Module1.nombre = txtbox_name.Text
            Dim f2 As New Form2

            Form2.Show()
        End If



    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()

    End Sub
End Class