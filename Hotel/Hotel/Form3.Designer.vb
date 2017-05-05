<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.bt_save = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.bt_imprimir = New System.Windows.Forms.Button()
        Me.bt_vista = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "Factura reserva hotel"
        Me.SaveFileDialog1.Filter = "PDF|*.pdf|Text Files|*.txt|Gif Image|*.gif"
        Me.SaveFileDialog1.Title = "Save File"
        '
        'bt_save
        '
        Me.bt_save.Location = New System.Drawing.Point(146, 426)
        Me.bt_save.Name = "bt_save"
        Me.bt_save.Size = New System.Drawing.Size(104, 23)
        Me.bt_save.TabIndex = 0
        Me.bt_save.Text = "Guardar archivo"
        Me.bt_save.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(285, 28)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(225, 287)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'bt_imprimir
        '
        Me.bt_imprimir.Location = New System.Drawing.Point(301, 426)
        Me.bt_imprimir.Name = "bt_imprimir"
        Me.bt_imprimir.Size = New System.Drawing.Size(75, 23)
        Me.bt_imprimir.TabIndex = 2
        Me.bt_imprimir.Text = "Imprimir"
        Me.bt_imprimir.UseVisualStyleBackColor = True
        '
        'bt_vista
        '
        Me.bt_vista.Location = New System.Drawing.Point(435, 426)
        Me.bt_vista.Name = "bt_vista"
        Me.bt_vista.Size = New System.Drawing.Size(75, 23)
        Me.bt_vista.TabIndex = 3
        Me.bt_vista.Text = "Vista Previa"
        Me.bt_vista.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 490)
        Me.Controls.Add(Me.bt_vista)
        Me.Controls.Add(Me.bt_imprimir)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.bt_save)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents bt_save As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents bt_imprimir As Button
    Friend WithEvents bt_vista As Button
End Class
