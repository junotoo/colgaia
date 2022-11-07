<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercício_2
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Lbl_Segundos = New System.Windows.Forms.Label()
        Me.Lbl_Resultado = New System.Windows.Forms.Label()
        Me.Txt_Segundos = New System.Windows.Forms.TextBox()
        Me.Txt_Resultado = New System.Windows.Forms.TextBox()
        Me.Btn_Converter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_Segundos
        '
        Me.Lbl_Segundos.AutoSize = True
        Me.Lbl_Segundos.Location = New System.Drawing.Point(28, 65)
        Me.Lbl_Segundos.Name = "Lbl_Segundos"
        Me.Lbl_Segundos.Size = New System.Drawing.Size(62, 15)
        Me.Lbl_Segundos.TabIndex = 0
        Me.Lbl_Segundos.Text = "Segundos:"
        '
        'Lbl_Resultado
        '
        Me.Lbl_Resultado.AutoSize = True
        Me.Lbl_Resultado.Location = New System.Drawing.Point(28, 240)
        Me.Lbl_Resultado.Name = "Lbl_Resultado"
        Me.Lbl_Resultado.Size = New System.Drawing.Size(62, 15)
        Me.Lbl_Resultado.TabIndex = 1
        Me.Lbl_Resultado.Text = "Resultado:"
        '
        'Txt_Segundos
        '
        Me.Txt_Segundos.Location = New System.Drawing.Point(96, 65)
        Me.Txt_Segundos.Name = "Txt_Segundos"
        Me.Txt_Segundos.Size = New System.Drawing.Size(100, 23)
        Me.Txt_Segundos.TabIndex = 2
        '
        'Txt_Resultado
        '
        Me.Txt_Resultado.Location = New System.Drawing.Point(96, 237)
        Me.Txt_Resultado.Name = "Txt_Resultado"
        Me.Txt_Resultado.ReadOnly = True
        Me.Txt_Resultado.Size = New System.Drawing.Size(100, 23)
        Me.Txt_Resultado.TabIndex = 3
        Me.Txt_Resultado.TabStop = False
        '
        'Btn_Converter
        '
        Me.Btn_Converter.Enabled = False
        Me.Btn_Converter.Location = New System.Drawing.Point(109, 146)
        Me.Btn_Converter.Name = "Btn_Converter"
        Me.Btn_Converter.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Converter.TabIndex = 4
        Me.Btn_Converter.Text = "Converter"
        Me.Btn_Converter.UseVisualStyleBackColor = True
        '
        'Exercício_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 386)
        Me.Controls.Add(Me.Btn_Converter)
        Me.Controls.Add(Me.Txt_Resultado)
        Me.Controls.Add(Me.Txt_Segundos)
        Me.Controls.Add(Me.Lbl_Resultado)
        Me.Controls.Add(Me.Lbl_Segundos)
        Me.Name = "Exercício_2"
        Me.Text = "Converter Segundos em H:M:S"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Segundos As Label
    Friend WithEvents Lbl_Resultado As Label
    Friend WithEvents Txt_Segundos As TextBox
    Friend WithEvents Txt_Resultado As TextBox
    Friend WithEvents Btn_Converter As Button
End Class
