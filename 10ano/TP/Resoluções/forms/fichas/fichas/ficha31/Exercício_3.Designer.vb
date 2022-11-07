<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercício_3
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
        Me.Lbl_Num = New System.Windows.Forms.Label()
        Me.Lbl_Algarismos = New System.Windows.Forms.Label()
        Me.Txt_Num = New System.Windows.Forms.TextBox()
        Me.Txt_Resultado = New System.Windows.Forms.TextBox()
        Me.Btn_Calcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_Num
        '
        Me.Lbl_Num.AutoSize = True
        Me.Lbl_Num.Location = New System.Drawing.Point(37, 53)
        Me.Lbl_Num.Name = "Lbl_Num"
        Me.Lbl_Num.Size = New System.Drawing.Size(54, 15)
        Me.Lbl_Num.TabIndex = 0
        Me.Lbl_Num.Text = "Número:"
        '
        'Lbl_Algarismos
        '
        Me.Lbl_Algarismos.AutoSize = True
        Me.Lbl_Algarismos.Location = New System.Drawing.Point(22, 112)
        Me.Lbl_Algarismos.Name = "Lbl_Algarismos"
        Me.Lbl_Algarismos.Size = New System.Drawing.Size(69, 15)
        Me.Lbl_Algarismos.TabIndex = 1
        Me.Lbl_Algarismos.Text = "Algarismos:"
        '
        'Txt_Num
        '
        Me.Txt_Num.Location = New System.Drawing.Point(97, 50)
        Me.Txt_Num.Name = "Txt_Num"
        Me.Txt_Num.Size = New System.Drawing.Size(100, 23)
        Me.Txt_Num.TabIndex = 2
        '
        'Txt_Resultado
        '
        Me.Txt_Resultado.Location = New System.Drawing.Point(97, 109)
        Me.Txt_Resultado.Name = "Txt_Resultado"
        Me.Txt_Resultado.ReadOnly = True
        Me.Txt_Resultado.Size = New System.Drawing.Size(100, 23)
        Me.Txt_Resultado.TabIndex = 3
        Me.Txt_Resultado.TabStop = False
        '
        'Btn_Calcular
        '
        Me.Btn_Calcular.Enabled = False
        Me.Btn_Calcular.Location = New System.Drawing.Point(246, 82)
        Me.Btn_Calcular.Name = "Btn_Calcular"
        Me.Btn_Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Calcular.TabIndex = 4
        Me.Btn_Calcular.Text = "Calcular"
        Me.Btn_Calcular.UseVisualStyleBackColor = True
        '
        'Exercício_3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 203)
        Me.Controls.Add(Me.Btn_Calcular)
        Me.Controls.Add(Me.Txt_Resultado)
        Me.Controls.Add(Me.Txt_Num)
        Me.Controls.Add(Me.Lbl_Algarismos)
        Me.Controls.Add(Me.Lbl_Num)
        Me.Name = "Exercício_3"
        Me.Text = "Conta Algarismos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Num As Label
    Friend WithEvents Lbl_Algarismos As Label
    Friend WithEvents Txt_Num As TextBox
    Friend WithEvents Txt_Resultado As TextBox
    Friend WithEvents Btn_Calcular As Button
End Class
