<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f35ex3
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
        Me.lstdisciplinas = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnremover = New System.Windows.Forms.Button()
        Me.btnacrescentar = New System.Windows.Forms.Button()
        Me.btnjuntar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstdisciplinas
        '
        Me.lstdisciplinas.FormattingEnabled = True
        Me.lstdisciplinas.ItemHeight = 15
        Me.lstdisciplinas.Items.AddRange(New Object() {"LP", "POO", "Matematica", "Fisica", "Contabilidade", "Estatistica"})
        Me.lstdisciplinas.Location = New System.Drawing.Point(12, 47)
        Me.lstdisciplinas.Name = "lstdisciplinas"
        Me.lstdisciplinas.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstdisciplinas.Size = New System.Drawing.Size(142, 109)
        Me.lstdisciplinas.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Lista de disciplinas"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(278, 47)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(163, 23)
        Me.TextBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(278, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Caixa de Texto para introduzir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(278, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Seleccoes:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(278, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Lista de seleccoes separadas por -"
        '
        'btnremover
        '
        Me.btnremover.Location = New System.Drawing.Point(169, 46)
        Me.btnremover.Name = "btnremover"
        Me.btnremover.Size = New System.Drawing.Size(96, 23)
        Me.btnremover.TabIndex = 6
        Me.btnremover.Text = "Remover ->"
        Me.btnremover.UseVisualStyleBackColor = True
        '
        'btnacrescentar
        '
        Me.btnacrescentar.Location = New System.Drawing.Point(169, 75)
        Me.btnacrescentar.Name = "btnacrescentar"
        Me.btnacrescentar.Size = New System.Drawing.Size(96, 23)
        Me.btnacrescentar.TabIndex = 7
        Me.btnacrescentar.Text = "<- Acrescentar"
        Me.btnacrescentar.UseVisualStyleBackColor = True
        '
        'btnjuntar
        '
        Me.btnjuntar.Location = New System.Drawing.Point(169, 104)
        Me.btnjuntar.Name = "btnjuntar"
        Me.btnjuntar.Size = New System.Drawing.Size(96, 23)
        Me.btnjuntar.TabIndex = 8
        Me.btnjuntar.Text = "Juntar"
        Me.btnjuntar.UseVisualStyleBackColor = True
        '
        'f35ex3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 168)
        Me.Controls.Add(Me.btnjuntar)
        Me.Controls.Add(Me.btnacrescentar)
        Me.Controls.Add(Me.btnremover)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstdisciplinas)
        Me.Name = "f35ex3"
        Me.Text = "Exercicio com ListBox de seleccao multipla"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstdisciplinas As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnremover As Button
    Friend WithEvents btnacrescentar As Button
    Friend WithEvents btnjuntar As Button
End Class
