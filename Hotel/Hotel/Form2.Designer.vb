<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_tipo = New System.Windows.Forms.ComboBox()
        Me.lb_adicional = New System.Windows.Forms.Label()
        Me.cb_desayuno = New System.Windows.Forms.ComboBox()
        Me.pb_deluxe = New System.Windows.Forms.PictureBox()
        Me.pb_premium = New System.Windows.Forms.PictureBox()
        Me.pb_ejecutiva = New System.Windows.Forms.PictureBox()
        Me.pb_premium_vistas = New System.Windows.Forms.PictureBox()
        Me.pb_junior_suit = New System.Windows.Forms.PictureBox()
        Me.pb_suit_ejecutiva = New System.Windows.Forms.PictureBox()
        Me.pb_suit_real = New System.Windows.Forms.PictureBox()
        Me.cb_fumar = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lb_precio = New System.Windows.Forms.Label()
        Me.cb_dinero = New System.Windows.Forms.ComboBox()
        Me.btn_view = New System.Windows.Forms.Button()
        Me.btn_pay = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        CType(Me.pb_deluxe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_premium, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_ejecutiva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_premium_vistas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_junior_suit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_suit_ejecutiva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_suit_real, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(246, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calcular el precio"
        '
        'cb_tipo
        '
        Me.cb_tipo.FormattingEnabled = True
        Me.cb_tipo.Items.AddRange(New Object() {"Habitación deluxe", "Habitación premium", "Habitación ejecutiva", "Habitación premium vistas", "Junior Suite", "Suite ejecutiva", "Suite Real", ""})
        Me.cb_tipo.Location = New System.Drawing.Point(61, 202)
        Me.cb_tipo.Name = "cb_tipo"
        Me.cb_tipo.Size = New System.Drawing.Size(121, 21)
        Me.cb_tipo.TabIndex = 1
        Me.cb_tipo.Text = "Tipo de habitación"
        '
        'lb_adicional
        '
        Me.lb_adicional.AutoSize = True
        Me.lb_adicional.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_adicional.Location = New System.Drawing.Point(12, 327)
        Me.lb_adicional.Name = "lb_adicional"
        Me.lb_adicional.Size = New System.Drawing.Size(17, 20)
        Me.lb_adicional.TabIndex = 2
        Me.lb_adicional.Text = "k"
        '
        'cb_desayuno
        '
        Me.cb_desayuno.FormattingEnabled = True
        Me.cb_desayuno.Items.AddRange(New Object() {"Sí", "No"})
        Me.cb_desayuno.Location = New System.Drawing.Point(253, 202)
        Me.cb_desayuno.Name = "cb_desayuno"
        Me.cb_desayuno.Size = New System.Drawing.Size(121, 21)
        Me.cb_desayuno.TabIndex = 3
        Me.cb_desayuno.Text = "¿Desayuno?"
        '
        'pb_deluxe
        '
        Me.pb_deluxe.Image = CType(resources.GetObject("pb_deluxe.Image"), System.Drawing.Image)
        Me.pb_deluxe.Location = New System.Drawing.Point(482, 130)
        Me.pb_deluxe.Name = "pb_deluxe"
        Me.pb_deluxe.Size = New System.Drawing.Size(288, 171)
        Me.pb_deluxe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_deluxe.TabIndex = 4
        Me.pb_deluxe.TabStop = False
        Me.pb_deluxe.Visible = False
        '
        'pb_premium
        '
        Me.pb_premium.Image = CType(resources.GetObject("pb_premium.Image"), System.Drawing.Image)
        Me.pb_premium.Location = New System.Drawing.Point(482, 130)
        Me.pb_premium.Name = "pb_premium"
        Me.pb_premium.Size = New System.Drawing.Size(288, 171)
        Me.pb_premium.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_premium.TabIndex = 5
        Me.pb_premium.TabStop = False
        Me.pb_premium.Visible = False
        '
        'pb_ejecutiva
        '
        Me.pb_ejecutiva.Image = CType(resources.GetObject("pb_ejecutiva.Image"), System.Drawing.Image)
        Me.pb_ejecutiva.Location = New System.Drawing.Point(482, 130)
        Me.pb_ejecutiva.Name = "pb_ejecutiva"
        Me.pb_ejecutiva.Size = New System.Drawing.Size(288, 171)
        Me.pb_ejecutiva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_ejecutiva.TabIndex = 6
        Me.pb_ejecutiva.TabStop = False
        Me.pb_ejecutiva.Visible = False
        '
        'pb_premium_vistas
        '
        Me.pb_premium_vistas.Image = CType(resources.GetObject("pb_premium_vistas.Image"), System.Drawing.Image)
        Me.pb_premium_vistas.Location = New System.Drawing.Point(482, 130)
        Me.pb_premium_vistas.Name = "pb_premium_vistas"
        Me.pb_premium_vistas.Size = New System.Drawing.Size(288, 171)
        Me.pb_premium_vistas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_premium_vistas.TabIndex = 7
        Me.pb_premium_vistas.TabStop = False
        Me.pb_premium_vistas.Visible = False
        '
        'pb_junior_suit
        '
        Me.pb_junior_suit.Image = CType(resources.GetObject("pb_junior_suit.Image"), System.Drawing.Image)
        Me.pb_junior_suit.Location = New System.Drawing.Point(482, 130)
        Me.pb_junior_suit.Name = "pb_junior_suit"
        Me.pb_junior_suit.Size = New System.Drawing.Size(288, 171)
        Me.pb_junior_suit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_junior_suit.TabIndex = 8
        Me.pb_junior_suit.TabStop = False
        Me.pb_junior_suit.Visible = False
        '
        'pb_suit_ejecutiva
        '
        Me.pb_suit_ejecutiva.Image = CType(resources.GetObject("pb_suit_ejecutiva.Image"), System.Drawing.Image)
        Me.pb_suit_ejecutiva.Location = New System.Drawing.Point(482, 130)
        Me.pb_suit_ejecutiva.Name = "pb_suit_ejecutiva"
        Me.pb_suit_ejecutiva.Size = New System.Drawing.Size(288, 171)
        Me.pb_suit_ejecutiva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_suit_ejecutiva.TabIndex = 9
        Me.pb_suit_ejecutiva.TabStop = False
        Me.pb_suit_ejecutiva.Visible = False
        '
        'pb_suit_real
        '
        Me.pb_suit_real.Image = CType(resources.GetObject("pb_suit_real.Image"), System.Drawing.Image)
        Me.pb_suit_real.Location = New System.Drawing.Point(482, 130)
        Me.pb_suit_real.Name = "pb_suit_real"
        Me.pb_suit_real.Size = New System.Drawing.Size(288, 171)
        Me.pb_suit_real.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_suit_real.TabIndex = 10
        Me.pb_suit_real.TabStop = False
        Me.pb_suit_real.Visible = False
        '
        'cb_fumar
        '
        Me.cb_fumar.AutoSize = True
        Me.cb_fumar.Location = New System.Drawing.Point(61, 252)
        Me.cb_fumar.Name = "cb_fumar"
        Me.cb_fumar.Size = New System.Drawing.Size(153, 17)
        Me.cb_fumar.TabIndex = 11
        Me.cb_fumar.Text = "Habitación para fumadores" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.cb_fumar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(479, 454)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Precio "
        '
        'lb_precio
        '
        Me.lb_precio.AutoSize = True
        Me.lb_precio.Location = New System.Drawing.Point(552, 454)
        Me.lb_precio.Name = "lb_precio"
        Me.lb_precio.Size = New System.Drawing.Size(0, 13)
        Me.lb_precio.TabIndex = 13
        '
        'cb_dinero
        '
        Me.cb_dinero.FormattingEnabled = True
        Me.cb_dinero.Items.AddRange(New Object() {"EUROS", "LIBRAS", "DOLARES", "PESOS", "YENES"})
        Me.cb_dinero.Location = New System.Drawing.Point(649, 451)
        Me.cb_dinero.Name = "cb_dinero"
        Me.cb_dinero.Size = New System.Drawing.Size(121, 21)
        Me.cb_dinero.TabIndex = 14
        Me.cb_dinero.Text = "EUROS"
        '
        'btn_view
        '
        Me.btn_view.Location = New System.Drawing.Point(271, 173)
        Me.btn_view.Name = "btn_view"
        Me.btn_view.Size = New System.Drawing.Size(75, 23)
        Me.btn_view.TabIndex = 16
        Me.btn_view.Text = "Live view"
        Me.btn_view.UseVisualStyleBackColor = True
        Me.btn_view.Visible = False
        '
        'btn_pay
        '
        Me.btn_pay.Location = New System.Drawing.Point(299, 449)
        Me.btn_pay.Name = "btn_pay"
        Me.btn_pay.Size = New System.Drawing.Size(75, 23)
        Me.btn_pay.TabIndex = 0
        Me.btn_pay.Text = "PAGAR"
        Me.btn_pay.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(198, 449)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 17
        Me.btn_cancel.Text = "CANCELAR"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 490)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_pay)
        Me.Controls.Add(Me.btn_view)
        Me.Controls.Add(Me.cb_dinero)
        Me.Controls.Add(Me.lb_precio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cb_fumar)
        Me.Controls.Add(Me.pb_suit_real)
        Me.Controls.Add(Me.pb_suit_ejecutiva)
        Me.Controls.Add(Me.pb_junior_suit)
        Me.Controls.Add(Me.pb_premium_vistas)
        Me.Controls.Add(Me.pb_ejecutiva)
        Me.Controls.Add(Me.pb_premium)
        Me.Controls.Add(Me.pb_deluxe)
        Me.Controls.Add(Me.cb_desayuno)
        Me.Controls.Add(Me.lb_adicional)
        Me.Controls.Add(Me.cb_tipo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Selecionar habitación"
        CType(Me.pb_deluxe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_premium, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_ejecutiva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_premium_vistas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_junior_suit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_suit_ejecutiva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_suit_real, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cb_tipo As ComboBox
    Friend WithEvents lb_adicional As Label
    Friend WithEvents cb_desayuno As ComboBox
    Friend WithEvents pb_deluxe As PictureBox
    Friend WithEvents pb_premium As PictureBox
    Friend WithEvents pb_ejecutiva As PictureBox
    Friend WithEvents pb_premium_vistas As PictureBox
    Friend WithEvents pb_junior_suit As PictureBox
    Friend WithEvents pb_suit_ejecutiva As PictureBox
    Friend WithEvents pb_suit_real As PictureBox
    Friend WithEvents cb_fumar As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lb_precio As Label
    Friend WithEvents cb_dinero As ComboBox
    Friend WithEvents btn_view As Button
    Friend WithEvents btn_pay As Button
    Friend WithEvents btn_cancel As Button
End Class
