<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f33ex6
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
        Me.lstcidades = New System.Windows.Forms.ListBox()
        Me.btnremove = New System.Windows.Forms.Button()
        Me.btnacrescenta = New System.Windows.Forms.Button()
        Me.btnlimpar = New System.Windows.Forms.Button()
        Me.btniniciar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtintroduzir = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstcidades
        '
        Me.lstcidades.FormattingEnabled = True
        Me.lstcidades.ItemHeight = 15
        Me.lstcidades.Items.AddRange(New Object() {"Guimarães", "Braga", "Barcelos", "Porto", "Lisboa"})
        Me.lstcidades.Location = New System.Drawing.Point(12, 49)
        Me.lstcidades.Name = "lstcidades"
        Me.lstcidades.Size = New System.Drawing.Size(184, 139)
        Me.lstcidades.TabIndex = 0
        '
        'btnremove
        '
        Me.btnremove.Enabled = False
        Me.btnremove.Location = New System.Drawing.Point(243, 49)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(86, 28)
        Me.btnremove.TabIndex = 1
        Me.btnremove.Text = "Remover"
        Me.btnremove.UseVisualStyleBackColor = True
        '
        'btnacrescenta
        '
        Me.btnacrescenta.Enabled = False
        Me.btnacrescenta.Location = New System.Drawing.Point(243, 83)
        Me.btnacrescenta.Name = "btnacrescenta"
        Me.btnacrescenta.Size = New System.Drawing.Size(86, 28)
        Me.btnacrescenta.TabIndex = 2
        Me.btnacrescenta.Text = "Acrescentar"
        Me.btnacrescenta.UseVisualStyleBackColor = True
        '
        'btnlimpar
        '
        Me.btnlimpar.Enabled = False
        Me.btnlimpar.Location = New System.Drawing.Point(243, 117)
        Me.btnlimpar.Name = "btnlimpar"
        Me.btnlimpar.Size = New System.Drawing.Size(86, 28)
        Me.btnlimpar.TabIndex = 3
        Me.btnlimpar.Text = "Limpar"
        Me.btnlimpar.UseVisualStyleBackColor = True
        '
        'btniniciar
        '
        Me.btniniciar.Enabled = False
        Me.btniniciar.Location = New System.Drawing.Point(243, 151)
        Me.btniniciar.Name = "btniniciar"
        Me.btniniciar.Size = New System.Drawing.Size(86, 28)
        Me.btniniciar.TabIndex = 4
        Me.btniniciar.Text = "Iniciar"
        Me.btniniciar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cidades"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Caixa de texto para selecionar/introduzir"
        '
        'txtintroduzir
        '
        Me.txtintroduzir.Location = New System.Drawing.Point(12, 218)
        Me.txtintroduzir.Name = "txtintroduzir"
        Me.txtintroduzir.Size = New System.Drawing.Size(317, 23)
        Me.txtintroduzir.TabIndex = 7
        '
        'f33ex6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 250)
        Me.Controls.Add(Me.txtintroduzir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btniniciar)
        Me.Controls.Add(Me.btnlimpar)
        Me.Controls.Add(Me.btnacrescenta)
        Me.Controls.Add(Me.btnremove)
        Me.Controls.Add(Me.lstcidades)
        Me.Name = "f33ex6"
        Me.Text = "Exercicio com ListBox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstcidades As ListBox
    Friend WithEvents btnremove As Button
    Friend WithEvents btnacrescenta As Button
    Friend WithEvents btnlimpar As Button
    Friend WithEvents btniniciar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtintroduzir As TextBox
End Class
