Public Class Form4
    Dim ESCALA As Integer = 100 'TAMAÑO INICIAL DESEADO
    Dim PASO As Integer = 20 'PASO DE TAMAÑO DESEADO
    Dim HORIZONTAL As Integer
    Dim PASOX As Integer = 20 'PASO DE SCROLL HORIZONTAL DESEADO
    Dim VERTICAL As Integer
    Dim PASOY As Integer = 20 'PASO DE SCROLL VERTICAL DESEADO

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        web.Navigate("api.deckchair.com/v1/viewer/image/58f90834d120a70001efaeb2?width=1920&height=1080&resizeMode=fill&gravity=Auto&quality=90&panelMode=false&format=jpg")

    End Sub

    Private Sub web_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles web.DocumentCompleted
        ButtonZOOMMAS.Enabled = True
        ButtonZOOMMENOS.Enabled = True

        Try
            Dim MyWeb As Object
            MyWeb = web.ActiveXInstance
            MyWeb.ExecWB(63, 2, Convert.ToInt32(ESCALA), "NULL")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ButtonZOOMMAS_Click(sender As Object, e As EventArgs) Handles ButtonZOOMMAS.Click
        ESCALA = ESCALA + PASO
        Try
            Dim MyWeb As Object
            MyWeb = web.ActiveXInstance
            MyWeb.ExecWB(63, 2, Convert.ToInt32(ESCALA), "NULL")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ButtonZOOMMENOS_Click(sender As Object, e As EventArgs) Handles ButtonZOOMMENOS.Click
        ESCALA = ESCALA - PASO
        Try
            Dim MyWeb As Object
            MyWeb = web.ActiveXInstance
            MyWeb.ExecWB(63, 2, Convert.ToInt32(ESCALA), "NULL")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class