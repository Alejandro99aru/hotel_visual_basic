Imports System.Net.Mail
Imports System.ComponentModel



Public Class Form2
    Dim libra = 0.87
    Dim dolar = 1.06
    Dim yen = 117
    Dim peso = 19.77
    Dim dinero
    Dim fumador
    Dim texto_adicional
    Dim precio_tipo
    Dim precio_desayuno

    Dim nombre = Module1.nombre
    Dim email1 = Module1.email







    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form5.Hide()

    End Sub

    Private Sub cb_tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_tipo.SelectedIndexChanged

    End Sub

    Private Sub cb_tipo_TextChanged(sender As Object, e As EventArgs) Handles cb_tipo.TextChanged



        If cb_tipo.Text = "Habitación deluxe" Then

            precio_tipo = 199

            pb_deluxe.Visible = True
            pb_premium.Visible = False
            pb_ejecutiva.Visible = False
            pb_premium_vistas.Visible = False
            pb_junior_suit.Visible = False
            pb_suit_ejecutiva.Visible = False
            pb_suit_real.Visible = False

            btn_view.Visible = False

            Module2.Habitacion = "Habitacion deluxe"

            texto_adicional = "Repletas de luz natural, las habitaciones Deluxe, de 29 metros cuadrados, 
ofrecen una decoración relajante en tonos suaves y neutros salpicados por toques de color refrescante. 
Sus originales características, como los techos ornamentados se complementan con valiosos muebles de caoba
y lujosos telares con el fin de crear una atmósfera tranquila y relajante."

        End If
        If cb_tipo.Text = "Habitación premium" Then

            precio_tipo = 229

            pb_deluxe.Visible = False
            pb_premium.Visible = True
            pb_ejecutiva.Visible = False
            pb_premium_vistas.Visible = False
            pb_junior_suit.Visible = False
            pb_suit_ejecutiva.Visible = False
            pb_suit_real.Visible = False

            btn_view.Visible = False

            Module2.Habitacion = "Habitación premium"

            texto_adicional = "Con un diseño luminoso y ventilado, estas habitaciones de unos 29 metros de amplitud,
ofrecen el escenario perfecto para renovar cuerpo y mente. Relájese y descanse en un ambiente de glamour creado por
una combinación de colores cálidos, muebles caoba, ricos telares y toques decorativos clásicos."

        End If
        If cb_tipo.Text = "Habitación ejecutiva" Then

            precio_tipo = 259

            pb_deluxe.Visible = False
            pb_premium.Visible = False
            pb_ejecutiva.Visible = True
            pb_premium_vistas.Visible = False
            pb_junior_suit.Visible = False
            pb_suit_ejecutiva.Visible = False
            pb_suit_real.Visible = False

            btn_view.Visible = False

            Module2.Habitacion = "Habitación ejecutiva"

            texto_adicional = "Las Habitaciones Executive son sumamente confortables para asegurarle la mayor productividad 
personal en viajes de negocio. Es idónea también para las familias, ya que además ofrece una mayor versatilidad y comodidad 
al poderse conectar a una habitación ejecutiva adjunta."

        End If
        If cb_tipo.Text = "Habitación premium vistas" Then

            precio_tipo = 289

            pb_deluxe.Visible = False
            pb_premium.Visible = False
            pb_ejecutiva.Visible = False
            pb_premium_vistas.Visible = True
            pb_junior_suit.Visible = False
            pb_suit_ejecutiva.Visible = False
            pb_suit_real.Visible = False

            btn_view.Visible = False

            Module2.Habitacion = "Habitación premium vistas"

            texto_adicional = "Esta categoría de habitación ofrece impresionantes vistas a la emblemática Fuente de Neptuno
y al Museo del Prado, además de ser amplias, luminosas y muy confortables. Relájese y descanse en un ambiente de glamour 
histórico creado por una combinación de colores cálidos, muebles de caoba, ricas telas y toques decorativos clásicos."

        End If
        If cb_tipo.Text = "Junior Suite" Then

            precio_tipo = 439

            pb_deluxe.Visible = False
            pb_premium.Visible = False
            pb_ejecutiva.Visible = False
            pb_premium_vistas.Visible = False
            pb_junior_suit.Visible = True
            pb_suit_ejecutiva.Visible = False
            pb_suit_real.Visible = False

            btn_view.Visible = False

            Module2.Habitacion = "Habitación Junior Suite"

            texto_adicional = "Una paleta de colores suaves recibe a los huéspedes al entrar en las relajantes Junior Suites.
Con una amplitud de unos 60 metros cuadrados, las Junior son las suites idóneas para viajeros de negocios o de placer que
requieren un alto nivel de confort combinado con un ambiente residencial tranquilo."

        End If
        If cb_tipo.Text = "Suite ejecutiva" Then

            precio_tipo = 689

            pb_deluxe.Visible = False
            pb_premium.Visible = False
            pb_ejecutiva.Visible = False
            pb_premium_vistas.Visible = False
            pb_junior_suit.Visible = False
            pb_suit_ejecutiva.Visible = True
            pb_suit_real.Visible = False

            btn_view.Visible = False

            Module2.Habitacion = "Habitación Suite ejecutiva"

            texto_adicional = "Las impresionantes Suites Executives de The Westin Palace Madrid alcanzan los 95 metros cuadrados
y cuentan con unas impresionantes vistas a la ciudad. La luz inunda toda la suite a través de sus grandes ventanas, 
enmarcadas con cortinas rojas, tras de las cuales se aprecian unas espectaculares vistas de la fuente de Neptuno y el Museo del Prado."

        End If

        If cb_tipo.Text = "Suite Real" Then

            precio_tipo = 4300

            pb_deluxe.Visible = False
            pb_premium.Visible = False
            pb_ejecutiva.Visible = False
            pb_premium_vistas.Visible = False
            pb_junior_suit.Visible = False
            pb_suit_ejecutiva.Visible = False
            pb_suit_real.Visible = True

            btn_view.Visible = True

            Module2.Habitacion = "Habitación Suite Real"

            texto_adicional = "Disfrute de una estancia en la Suite Real. Este elegante conjunto de habitaciones que cubren 160 metros
cuadrados puede ser ampliado añadiendo dos habitaciones contiguas hasta alcanzar 225 metros cuadrados de espacio total."

        End If

        If cb_fumar.Checked = True Then

            fumador = "Fumador"

            Module2.Fumadores = "para fumadores"

        End If


        If cb_desayuno.Text = "Sí" Then

            precio_desayuno = 7

            Module2.Desayuno = "Sí "

        End If

        If cb_dinero.Text = "EUROS" Then

            dinero = Val((precio_tipo + precio_desayuno))

            Module2.Precio = dinero

        End If

        If cb_dinero.Text = "LIBRAS" Then

            dinero = Val((precio_tipo + precio_desayuno) * libra)

            Module2.Precio = dinero

        End If

        If cb_dinero.Text = "DOLARES" Then

            dinero = Val((precio_tipo + precio_desayuno) * dolar)

            Module2.Precio = dinero

        End If

        If cb_dinero.Text = "PESOS" Then

            dinero = Val((precio_tipo + precio_desayuno) * peso)

            Module2.Precio = dinero

        End If

        If cb_dinero.Text = "YENES" Then

            dinero = Val((precio_tipo + precio_desayuno) * yen)

            Module2.Precio = dinero

        End If






        lb_adicional.Text = texto_adicional

        lb_precio.Text = dinero

    End Sub

    Private Sub cb_desayuno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_desayuno.SelectedIndexChanged

    End Sub

    Private Sub cb_desayuno_TextChanged(sender As Object, e As EventArgs) Handles cb_desayuno.TextChanged



        If cb_tipo.Text = "Habitación deluxe" Then

            precio_tipo = 199

            pb_deluxe.Visible = True
            pb_premium.Visible = False
            pb_ejecutiva.Visible = False
            pb_premium_vistas.Visible = False
            pb_junior_suit.Visible = False
            pb_suit_ejecutiva.Visible = False
            pb_suit_real.Visible = False

            btn_view.Visible = False

            Module2.Habitacion = "Habitacion deluxe"

            texto_adicional = "Repletas de luz natural, las habitaciones Deluxe, de 29 metros cuadrados, 
ofrecen una decoración relajante en tonos suaves y neutros salpicados por toques de color refrescante. 
Sus originales características, como los techos ornamentados se complementan con valiosos muebles de caoba
y lujosos telares con el fin de crear una atmósfera tranquila y relajante."

        End If
        If cb_tipo.Text = "Habitación premium" Then

            precio_tipo = 229

            pb_deluxe.Visible = False
            pb_premium.Visible = True
            pb_ejecutiva.Visible = False
            pb_premium_vistas.Visible = False
            pb_junior_suit.Visible = False
            pb_suit_ejecutiva.Visible = False
            pb_suit_real.Visible = False

            btn_view.Visible = False

            Module2.Habitacion = "Habitación premium"

            texto_adicional = "Con un diseño luminoso y ventilado, estas habitaciones de unos 29 metros de amplitud,
ofrecen el escenario perfecto para renovar cuerpo y mente. Relájese y descanse en un ambiente de glamour creado por
una combinación de colores cálidos, muebles caoba, ricos telares y toques decorativos clásicos."

        End If
        If cb_tipo.Text = "Habitación ejecutiva" Then

            precio_tipo = 259

            pb_deluxe.Visible = False
            pb_premium.Visible = False
            pb_ejecutiva.Visible = True
            pb_premium_vistas.Visible = False
            pb_junior_suit.Visible = False
            pb_suit_ejecutiva.Visible = False
            pb_suit_real.Visible = False

            btn_view.Visible = False

            Module2.Habitacion = "Habitación ejecutiva"

            texto_adicional = "Las Habitaciones Executive son sumamente confortables para asegurarle la mayor productividad 
personal en viajes de negocio. Es idónea también para las familias, ya que además ofrece una mayor versatilidad y comodidad 
al poderse conectar a una habitación ejecutiva adjunta."

        End If
        If cb_tipo.Text = "Habitación premium vistas" Then

            precio_tipo = 289

            pb_deluxe.Visible = False
            pb_premium.Visible = False
            pb_ejecutiva.Visible = False
            pb_premium_vistas.Visible = True
            pb_junior_suit.Visible = False
            pb_suit_ejecutiva.Visible = False
            pb_suit_real.Visible = False

            btn_view.Visible = False

            Module2.Habitacion = "Habitación premium vistas"

            texto_adicional = "Esta categoría de habitación ofrece impresionantes vistas a la emblemática Fuente de Neptuno
y al Museo del Prado, además de ser amplias, luminosas y muy confortables. Relájese y descanse en un ambiente de glamour 
histórico creado por una combinación de colores cálidos, muebles de caoba, ricas telas y toques decorativos clásicos."

        End If
        If cb_tipo.Text = "Junior Suite" Then

            precio_tipo = 439

            pb_deluxe.Visible = False
            pb_premium.Visible = False
            pb_ejecutiva.Visible = False
            pb_premium_vistas.Visible = False
            pb_junior_suit.Visible = True
            pb_suit_ejecutiva.Visible = False
            pb_suit_real.Visible = False

            btn_view.Visible = False

            Module2.Habitacion = "Habitación Junior Suite"

            texto_adicional = "Una paleta de colores suaves recibe a los huéspedes al entrar en las relajantes Junior Suites.
Con una amplitud de unos 60 metros cuadrados, las Junior son las suites idóneas para viajeros de negocios o de placer que
requieren un alto nivel de confort combinado con un ambiente residencial tranquilo."

        End If
        If cb_tipo.Text = "Suite ejecutiva" Then

            precio_tipo = 689

            pb_deluxe.Visible = False
            pb_premium.Visible = False
            pb_ejecutiva.Visible = False
            pb_premium_vistas.Visible = False
            pb_junior_suit.Visible = False
            pb_suit_ejecutiva.Visible = True
            pb_suit_real.Visible = False

            btn_view.Visible = False

            Module2.Habitacion = "Habitación Suite ejecutiva"

            texto_adicional = "Las impresionantes Suites Executives de The Westin Palace Madrid alcanzan los 95 metros cuadrados
y cuentan con unas impresionantes vistas a la ciudad. La luz inunda toda la suite a través de sus grandes ventanas, 
enmarcadas con cortinas rojas, tras de las cuales se aprecian unas espectaculares vistas de la fuente de Neptuno y el Museo del Prado."

        End If

        If cb_tipo.Text = "Suite Real" Then

            precio_tipo = 4300

            pb_deluxe.Visible = False
            pb_premium.Visible = False
            pb_ejecutiva.Visible = False
            pb_premium_vistas.Visible = False
            pb_junior_suit.Visible = False
            pb_suit_ejecutiva.Visible = False
            pb_suit_real.Visible = True

            btn_view.Visible = True

            Module2.Habitacion = "Habitación Suite Real"

            texto_adicional = "Disfrute de una estancia en la Suite Real. Este elegante conjunto de habitaciones que cubren 160 metros
cuadrados puede ser ampliado añadiendo dos habitaciones contiguas hasta alcanzar 225 metros cuadrados de espacio total."

        End If

        If cb_fumar.Checked = True Then

            fumador = "Fumador"

            Module2.Fumadores = "para fumadores"

        End If


        If cb_desayuno.Text = "Sí" Then

            precio_desayuno = 7

            Module2.Desayuno = "Sí "

        End If

        If cb_dinero.Text = "EUROS" Then

            dinero = Val((precio_tipo + precio_desayuno))

            Module2.Precio = dinero

        End If

        If cb_dinero.Text = "LIBRAS" Then

            dinero = Val((precio_tipo + precio_desayuno) * libra)

            Module2.Precio = dinero

        End If

        If cb_dinero.Text = "DOLARES" Then

            dinero = Val((precio_tipo + precio_desayuno) * dolar)

            Module2.Precio = dinero

        End If

        If cb_dinero.Text = "PESOS" Then

            dinero = Val((precio_tipo + precio_desayuno) * peso)

            Module2.Precio = dinero

        End If

        If cb_dinero.Text = "YENES" Then

            dinero = Val((precio_tipo + precio_desayuno) * yen)

            Module2.Precio = dinero

        End If






        lb_adicional.Text = texto_adicional

        lb_precio.Text = dinero
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_dinero.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles cb_dinero.TextChanged




        If cb_tipo.Text = "Habitación deluxe" Then

            precio_tipo = 199

            pb_deluxe.Visible = True
            pb_premium.Visible = False
            pb_ejecutiva.Visible = False
            pb_premium_vistas.Visible = False
            pb_junior_suit.Visible = False
            pb_suit_ejecutiva.Visible = False
            pb_suit_real.Visible = False

            btn_view.Visible = False

            Module2.Habitacion = "Habitacion deluxe"

            texto_adicional = "Repletas de luz natural, las habitaciones Deluxe, de 29 metros cuadrados, 
ofrecen una decoración relajante en tonos suaves y neutros salpicados por toques de color refrescante. 
Sus originales características, como los techos ornamentados se complementan con valiosos muebles de caoba
y lujosos telares con el fin de crear una atmósfera tranquila y relajante."

        End If
        If cb_tipo.Text = "Habitación premium" Then

            precio_tipo = 229

            pb_deluxe.Visible = False
            pb_premium.Visible = True
            pb_ejecutiva.Visible = False
            pb_premium_vistas.Visible = False
            pb_junior_suit.Visible = False
            pb_suit_ejecutiva.Visible = False
            pb_suit_real.Visible = False

            btn_view.Visible = False

            Module2.Habitacion = "Habitación premium"

            texto_adicional = "Con un diseño luminoso y ventilado, estas habitaciones de unos 29 metros de amplitud,
ofrecen el escenario perfecto para renovar cuerpo y mente. Relájese y descanse en un ambiente de glamour creado por
una combinación de colores cálidos, muebles caoba, ricos telares y toques decorativos clásicos."

        End If
        If cb_tipo.Text = "Habitación ejecutiva" Then

            precio_tipo = 259

            pb_deluxe.Visible = False
            pb_premium.Visible = False
            pb_ejecutiva.Visible = True
            pb_premium_vistas.Visible = False
            pb_junior_suit.Visible = False
            pb_suit_ejecutiva.Visible = False
            pb_suit_real.Visible = False

            btn_view.Visible = False

            Module2.Habitacion = "Habitación ejecutiva"

            texto_adicional = "Las Habitaciones Executive son sumamente confortables para asegurarle la mayor productividad 
personal en viajes de negocio. Es idónea también para las familias, ya que además ofrece una mayor versatilidad y comodidad 
al poderse conectar a una habitación ejecutiva adjunta."

        End If
        If cb_tipo.Text = "Habitación premium vistas" Then

            precio_tipo = 289

            pb_deluxe.Visible = False
            pb_premium.Visible = False
            pb_ejecutiva.Visible = False
            pb_premium_vistas.Visible = True
            pb_junior_suit.Visible = False
            pb_suit_ejecutiva.Visible = False
            pb_suit_real.Visible = False

            btn_view.Visible = False

            Module2.Habitacion = "Habitación premium vistas"

            texto_adicional = "Esta categoría de habitación ofrece impresionantes vistas a la emblemática Fuente de Neptuno
y al Museo del Prado, además de ser amplias, luminosas y muy confortables. Relájese y descanse en un ambiente de glamour 
histórico creado por una combinación de colores cálidos, muebles de caoba, ricas telas y toques decorativos clásicos."

        End If
        If cb_tipo.Text = "Junior Suite" Then

            precio_tipo = 439

            pb_deluxe.Visible = False
            pb_premium.Visible = False
            pb_ejecutiva.Visible = False
            pb_premium_vistas.Visible = False
            pb_junior_suit.Visible = True
            pb_suit_ejecutiva.Visible = False
            pb_suit_real.Visible = False

            btn_view.Visible = False

            Module2.Habitacion = "Habitación Junior Suite"

            texto_adicional = "Una paleta de colores suaves recibe a los huéspedes al entrar en las relajantes Junior Suites.
Con una amplitud de unos 60 metros cuadrados, las Junior son las suites idóneas para viajeros de negocios o de placer que
requieren un alto nivel de confort combinado con un ambiente residencial tranquilo."

        End If
        If cb_tipo.Text = "Suite ejecutiva" Then

            precio_tipo = 689

            pb_deluxe.Visible = False
            pb_premium.Visible = False
            pb_ejecutiva.Visible = False
            pb_premium_vistas.Visible = False
            pb_junior_suit.Visible = False
            pb_suit_ejecutiva.Visible = True
            pb_suit_real.Visible = False

            btn_view.Visible = False

            Module2.Habitacion = "Habitación Suite ejecutiva"

            texto_adicional = "Las impresionantes Suites Executives de The Westin Palace Madrid alcanzan los 95 metros cuadrados
y cuentan con unas impresionantes vistas a la ciudad. La luz inunda toda la suite a través de sus grandes ventanas, 
enmarcadas con cortinas rojas, tras de las cuales se aprecian unas espectaculares vistas de la fuente de Neptuno y el Museo del Prado."

        End If

        If cb_tipo.Text = "Suite Real" Then

            precio_tipo = 4300

            pb_deluxe.Visible = False
            pb_premium.Visible = False
            pb_ejecutiva.Visible = False
            pb_premium_vistas.Visible = False
            pb_junior_suit.Visible = False
            pb_suit_ejecutiva.Visible = False
            pb_suit_real.Visible = True

            btn_view.Visible = True

            Module2.Habitacion = "Habitación Suite Real"

            texto_adicional = "Disfrute de una estancia en la Suite Real. Este elegante conjunto de habitaciones que cubren 160 metros
cuadrados puede ser ampliado añadiendo dos habitaciones contiguas hasta alcanzar 225 metros cuadrados de espacio total."

        End If

        If cb_fumar.Checked = True Then

            fumador = "Fumador"

            Module2.Fumadores = "para fumadores"

        End If


        If cb_desayuno.Text = "Sí" Then

            precio_desayuno = 7

            Module2.Desayuno = "Sí "

        End If

        If cb_dinero.Text = "EUROS" Then

            dinero = Val((precio_tipo + precio_desayuno))

            Module2.Precio = dinero

        End If

        If cb_dinero.Text = "LIBRAS" Then

            dinero = Val((precio_tipo + precio_desayuno) * libra)

            Module2.Precio = dinero

        End If

        If cb_dinero.Text = "DOLARES" Then

            dinero = Val((precio_tipo + precio_desayuno) * dolar)

            Module2.Precio = dinero

        End If

        If cb_dinero.Text = "PESOS" Then

            dinero = Val((precio_tipo + precio_desayuno) * peso)

            Module2.Precio = dinero

        End If

        If cb_dinero.Text = "YENES" Then

            dinero = Val((precio_tipo + precio_desayuno) * yen)

            Module2.Precio = dinero

        End If






        lb_adicional.Text = texto_adicional

        lb_precio.Text = dinero

    End Sub

    Private Sub bt_factura_Click(sender As Object, e As EventArgs)
        Form3.Show()
    End Sub

    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        Form4.Show()
    End Sub

    Private Sub btn_pay_Click(sender As Object, e As EventArgs) Handles btn_pay.Click
        If cb_fumar.Checked = True Then

            fumador = "Fumador"

            Module2.Fumadores = "para fumadores"

        End If


        If cb_desayuno.Text = "Sí" Then

            precio_desayuno = 7

            Module2.Desayuno = "y con desayuno. "

        End If
        Form6.Show()
        Me.Hide()



    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Form1.Show()
        Me.Hide
    End Sub
End Class