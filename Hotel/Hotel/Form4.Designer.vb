<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.web = New System.Windows.Forms.WebBrowser()
        Me.ButtonZOOMMAS = New System.Windows.Forms.Button()
        Me.ButtonZOOMMENOS = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'web
        '
        Me.web.Dock = System.Windows.Forms.DockStyle.Fill
        Me.web.Location = New System.Drawing.Point(0, 0)
        Me.web.MinimumSize = New System.Drawing.Size(20, 20)
        Me.web.Name = "web"
        Me.web.ScriptErrorsSuppressed = True
        Me.web.Size = New System.Drawing.Size(832, 490)
        Me.web.TabIndex = 5
        Me.web.Url = New System.Uri("http://api.deckchair.com/v1/viewer/image/58f90834d120a70001efaeb2?width=1920&heig" &
        "ht=1080&resizeMode=fill&gravity=Auto&quality=90&panelMode=false&format=jpg", System.UriKind.Absolute)
        '
        'ButtonZOOMMAS
        '
        Me.ButtonZOOMMAS.Enabled = False
        Me.ButtonZOOMMAS.Location = New System.Drawing.Point(74, 0)
        Me.ButtonZOOMMAS.Name = "ButtonZOOMMAS"
        Me.ButtonZOOMMAS.Size = New System.Drawing.Size(85, 23)
        Me.ButtonZOOMMAS.TabIndex = 6
        Me.ButtonZOOMMAS.Text = "AUMENTAR"
        Me.ButtonZOOMMAS.UseVisualStyleBackColor = True
        '
        'ButtonZOOMMENOS
        '
        Me.ButtonZOOMMENOS.Enabled = False
        Me.ButtonZOOMMENOS.Location = New System.Drawing.Point(205, -1)
        Me.ButtonZOOMMENOS.Name = "ButtonZOOMMENOS"
        Me.ButtonZOOMMENOS.Size = New System.Drawing.Size(75, 23)
        Me.ButtonZOOMMENOS.TabIndex = 7
        Me.ButtonZOOMMENOS.Text = "DISMINUIR"
        Me.ButtonZOOMMENOS.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 490)
        Me.Controls.Add(Me.ButtonZOOMMENOS)
        Me.Controls.Add(Me.ButtonZOOMMAS)
        Me.Controls.Add(Me.web)
        Me.Name = "Form4"
        Me.Text = "Directo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents web As WebBrowser
    Friend WithEvents ButtonZOOMMAS As Button
    Friend WithEvents ButtonZOOMMENOS As Button
End Class
