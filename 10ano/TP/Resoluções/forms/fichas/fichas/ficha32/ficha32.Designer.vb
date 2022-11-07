<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ficha32
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
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
        Me.btnf32ex1 = New System.Windows.Forms.Button()
        Me.btnf32ex2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnf32ex1
        '
        Me.btnf32ex1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnf32ex1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnf32ex1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnf32ex1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnf32ex1.ForeColor = System.Drawing.Color.White
        Me.btnf32ex1.Location = New System.Drawing.Point(21, 125)
        Me.btnf32ex1.Name = "btnf32ex1"
        Me.btnf32ex1.Size = New System.Drawing.Size(272, 266)
        Me.btnf32ex1.TabIndex = 2
        Me.btnf32ex1.Text = "Exercício 1"
        Me.btnf32ex1.UseVisualStyleBackColor = False
        '
        'btnf32ex2
        '
        Me.btnf32ex2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnf32ex2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnf32ex2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnf32ex2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnf32ex2.ForeColor = System.Drawing.Color.White
        Me.btnf32ex2.Location = New System.Drawing.Point(390, 125)
        Me.btnf32ex2.Name = "btnf32ex2"
        Me.btnf32ex2.Size = New System.Drawing.Size(278, 266)
        Me.btnf32ex2.TabIndex = 3
        Me.btnf32ex2.Text = "Exercício 2"
        Me.btnf32ex2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(286, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 37)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ficha 32"
        '
        'ficha32
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnf32ex2)
        Me.Controls.Add(Me.btnf32ex1)
        Me.Name = "ficha32"
        Me.Size = New System.Drawing.Size(694, 427)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnf32ex1 As Button
    Friend WithEvents btnf32ex2 As Button
    Friend WithEvents Label1 As Label
End Class
