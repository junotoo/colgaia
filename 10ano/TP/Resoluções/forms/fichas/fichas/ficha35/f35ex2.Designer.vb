<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f35ex2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtintroduzir = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btniniciar = New System.Windows.Forms.Button()
        Me.btnlimpar = New System.Windows.Forms.Button()
        Me.btnacrescenta = New System.Windows.Forms.Button()
        Me.btnremove = New System.Windows.Forms.Button()
        Me.lstcidades = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'txtintroduzir
        '
        Me.txtintroduzir.Location = New System.Drawing.Point(12, 213)
        Me.txtintroduzir.Name = "txtintroduzir"
        Me.txtintroduzir.Size = New System.Drawing.Size(317, 23)
        Me.txtintroduzir.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Caixa de texto para selecionar/introduzir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Cidades"
        '
        'btniniciar
        '
        Me.btniniciar.Enabled = False
        Me.btniniciar.Location = New System.Drawing.Point(243, 146)
        Me.btniniciar.Name = "btniniciar"
        Me.btniniciar.Size = New System.Drawing.Size(86, 28)
        Me.btniniciar.TabIndex = 12
        Me.btniniciar.Text = "Iniciar"
        Me.btniniciar.UseVisualStyleBackColor = True
        '
        'btnlimpar
        '
        Me.btnlimpar.Enabled = False
        Me.btnlimpar.Location = New System.Drawing.Point(243, 112)
        Me.btnlimpar.Name = "btnlimpar"
        Me.btnlimpar.Size = New System.Drawing.Size(86, 28)
        Me.btnlimpar.TabIndex = 11
        Me.btnlimpar.Text = "Limpar"
        Me.btnlimpar.UseVisualStyleBackColor = True
        '
        'btnacrescenta
        '
        Me.btnacrescenta.Enabled = False
        Me.btnacrescenta.Location = New System.Drawing.Point(243, 78)
        Me.btnacrescenta.Name = "btnacrescenta"
        Me.btnacrescenta.Size = New System.Drawing.Size(86, 28)
        Me.btnacrescenta.TabIndex = 10
        Me.btnacrescenta.Text = "Acrescentar"
        Me.btnacrescenta.UseVisualStyleBackColor = True
        '
        'btnremove
        '
        Me.btnremove.Enabled = False
        Me.btnremove.Location = New System.Drawing.Point(243, 44)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(86, 28)
        Me.btnremove.TabIndex = 9
        Me.btnremove.Text = "Remover"
        Me.btnremove.UseVisualStyleBackColor = True
        '
        'lstcidades
        '
        Me.lstcidades.FormattingEnabled = True
        Me.lstcidades.ItemHeight = 15
        Me.lstcidades.Items.AddRange(New Object() {"Guimarães", "Braga", "Barcelos", "Porto", "Lisboa"})
        Me.lstcidades.Location = New System.Drawing.Point(12, 44)
        Me.lstcidades.Name = "lstcidades"
        Me.lstcidades.Size = New System.Drawing.Size(184, 139)
        Me.lstcidades.TabIndex = 8
        '
        'f35ex2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 256)
        Me.Controls.Add(Me.txtintroduzir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btniniciar)
        Me.Controls.Add(Me.btnlimpar)
        Me.Controls.Add(Me.btnacrescenta)
        Me.Controls.Add(Me.btnremove)
        Me.Controls.Add(Me.lstcidades)
        Me.Name = "f35ex2"
        Me.Text = "Exercicio com ListBox de Seleccao Unica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtintroduzir As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btniniciar As Button
    Friend WithEvents btnlimpar As Button
    Friend WithEvents btnacrescenta As Button
    Friend WithEvents btnremove As Button
    Friend WithEvents lstcidades As ListBox
End Class
