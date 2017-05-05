Public Class Form6
    Dim nombre = Module1.nombre
    Dim email = Module1.email

    Dim Habitacion = Module2.Habitacion
    Dim Desayuno = Module2.Desayuno
    Dim Fumadores = Module2.Fumadores
    Dim Precio As Double

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrintPreviewControl1.Document = PrintDocument1

    End Sub


    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Precio = Module2.Precio
        Dim ReportFont As Font = New Drawing.Font("Time New Roman", 14)
        e.Graphics.DrawString("Para: " + email, ReportFont, Brushes.Green, 100, 100)
        e.Graphics.DrawString("De: alejandro@elgeekman.com", ReportFont, Brushes.Green, 100, 125)
        e.Graphics.DrawString("Hola " + nombre + ",", ReportFont, Brushes.Chocolate, 100, 200)
        e.Graphics.DrawString("Has reservado la " + Habitacion + " " + Fumadores + Desayuno, ReportFont, Brushes.Chocolate, 100, 225)
        e.Graphics.DrawString("Con un precio de:", ReportFont, Brushes.Chocolate, 100, 250)
        e.Graphics.DrawString(Precio, ReportFont, Brushes.Chocolate, 100, 275)
        e.Graphics.DrawString("Esperamos que disfrute de su alojamiento", ReportFont, Brushes.Chocolate, 100, 300)
        e.Graphics.DrawString("Un saludo,", ReportFont, Brushes.Chocolate, 100, 325)
        e.Graphics.DrawString("Alejandro", ReportFont, Brushes.Chocolate, 100, 350)
    End Sub

    Private Sub PrintPreviewControl1_Click(sender As Object, e As EventArgs) Handles PrintPreviewControl1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class