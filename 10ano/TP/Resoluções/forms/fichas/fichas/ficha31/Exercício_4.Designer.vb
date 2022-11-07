<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercício_4
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
        Me.Lbl_Topo = New System.Windows.Forms.Label()
        Me.Btn_Topo = New System.Windows.Forms.Button()
        Me.Btn_Centro = New System.Windows.Forms.Button()
        Me.Btn_Baixo = New System.Windows.Forms.Button()
        Me.Btn_Limpar = New System.Windows.Forms.Button()
        Me.Txt_Topo = New System.Windows.Forms.TextBox()
        Me.Grp_Topo = New System.Windows.Forms.GroupBox()
        Me.Grp_Centro = New System.Windows.Forms.GroupBox()
        Me.Txt_Centro = New System.Windows.Forms.TextBox()
        Me.Grp_Baixo = New System.Windows.Forms.GroupBox()
        Me.Txt_Baixo = New System.Windows.Forms.TextBox()
        Me.Grp_Topo.SuspendLayout()
        Me.Grp_Centro.SuspendLayout()
        Me.Grp_Baixo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Topo
        '
        Me.Lbl_Topo.AutoSize = True
        Me.Lbl_Topo.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl_Topo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_Topo.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Lbl_Topo.Location = New System.Drawing.Point(44, 15)
        Me.Lbl_Topo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Topo.Name = "Lbl_Topo"
        Me.Lbl_Topo.Size = New System.Drawing.Size(416, 45)
        Me.Lbl_Topo.TabIndex = 0
        Me.Lbl_Topo.Text = "Operações sobre Números"
        '
        'Btn_Topo
        '
        Me.Btn_Topo.Enabled = False
        Me.Btn_Topo.Location = New System.Drawing.Point(17, 108)
        Me.Btn_Topo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_Topo.Name = "Btn_Topo"
        Me.Btn_Topo.Size = New System.Drawing.Size(144, 83)
        Me.Btn_Topo.TabIndex = 2
        Me.Btn_Topo.Text = "Divide o 1º Número pelo 2º"
        Me.Btn_Topo.UseVisualStyleBackColor = True
        '
        'Btn_Centro
        '
        Me.Btn_Centro.Enabled = False
        Me.Btn_Centro.Location = New System.Drawing.Point(17, 218)
        Me.Btn_Centro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_Centro.Name = "Btn_Centro"
        Me.Btn_Centro.Size = New System.Drawing.Size(144, 83)
        Me.Btn_Centro.TabIndex = 3
        Me.Btn_Centro.Text = "Divide o 2º Número pelo 1º"
        Me.Btn_Centro.UseVisualStyleBackColor = True
        '
        'Btn_Baixo
        '
        Me.Btn_Baixo.Enabled = False
        Me.Btn_Baixo.Location = New System.Drawing.Point(17, 328)
        Me.Btn_Baixo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_Baixo.Name = "Btn_Baixo"
        Me.Btn_Baixo.Size = New System.Drawing.Size(144, 82)
        Me.Btn_Baixo.TabIndex = 4
        Me.Btn_Baixo.Text = "Diferença entre os anteriores"
        Me.Btn_Baixo.UseVisualStyleBackColor = True
        '
        'Btn_Limpar
        '
        Me.Btn_Limpar.Enabled = False
        Me.Btn_Limpar.Location = New System.Drawing.Point(336, 430)
        Me.Btn_Limpar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_Limpar.Name = "Btn_Limpar"
        Me.Btn_Limpar.Size = New System.Drawing.Size(79, 62)
        Me.Btn_Limpar.TabIndex = 5
        Me.Btn_Limpar.Text = "Limpar"
        Me.Btn_Limpar.UseVisualStyleBackColor = True
        '
        'Txt_Topo
        '
        Me.Txt_Topo.Location = New System.Drawing.Point(26, 32)
        Me.Txt_Topo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_Topo.Name = "Txt_Topo"
        Me.Txt_Topo.Size = New System.Drawing.Size(208, 31)
        Me.Txt_Topo.TabIndex = 0
        '
        'Grp_Topo
        '
        Me.Grp_Topo.Controls.Add(Me.Txt_Topo)
        Me.Grp_Topo.Location = New System.Drawing.Point(170, 93)
        Me.Grp_Topo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Grp_Topo.Name = "Grp_Topo"
        Me.Grp_Topo.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Grp_Topo.Size = New System.Drawing.Size(244, 98)
        Me.Grp_Topo.TabIndex = 7
        Me.Grp_Topo.TabStop = False
        Me.Grp_Topo.Text = "Primeiro Número"
        '
        'Grp_Centro
        '
        Me.Grp_Centro.Controls.Add(Me.Txt_Centro)
        Me.Grp_Centro.Location = New System.Drawing.Point(170, 203)
        Me.Grp_Centro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Grp_Centro.Name = "Grp_Centro"
        Me.Grp_Centro.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Grp_Centro.Size = New System.Drawing.Size(244, 98)
        Me.Grp_Centro.TabIndex = 8
        Me.Grp_Centro.TabStop = False
        Me.Grp_Centro.Text = "Segundo Número"
        '
        'Txt_Centro
        '
        Me.Txt_Centro.Location = New System.Drawing.Point(26, 32)
        Me.Txt_Centro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_Centro.Name = "Txt_Centro"
        Me.Txt_Centro.Size = New System.Drawing.Size(208, 31)
        Me.Txt_Centro.TabIndex = 1
        '
        'Grp_Baixo
        '
        Me.Grp_Baixo.Controls.Add(Me.Txt_Baixo)
        Me.Grp_Baixo.Location = New System.Drawing.Point(170, 312)
        Me.Grp_Baixo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Grp_Baixo.Name = "Grp_Baixo"
        Me.Grp_Baixo.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Grp_Baixo.Size = New System.Drawing.Size(244, 98)
        Me.Grp_Baixo.TabIndex = 9
        Me.Grp_Baixo.TabStop = False
        Me.Grp_Baixo.Text = "Resultado"
        '
        'Txt_Baixo
        '
        Me.Txt_Baixo.Location = New System.Drawing.Point(26, 32)
        Me.Txt_Baixo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_Baixo.Name = "Txt_Baixo"
        Me.Txt_Baixo.ReadOnly = True
        Me.Txt_Baixo.Size = New System.Drawing.Size(208, 31)
        Me.Txt_Baixo.TabIndex = 6
        Me.Txt_Baixo.TabStop = False
        '
        'Exercício_4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 512)
        Me.Controls.Add(Me.Grp_Baixo)
        Me.Controls.Add(Me.Grp_Centro)
        Me.Controls.Add(Me.Grp_Topo)
        Me.Controls.Add(Me.Btn_Limpar)
        Me.Controls.Add(Me.Btn_Baixo)
        Me.Controls.Add(Me.Btn_Centro)
        Me.Controls.Add(Me.Btn_Topo)
        Me.Controls.Add(Me.Lbl_Topo)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Exercício_4"
        Me.Text = "Exercício 1_6"
        Me.Grp_Topo.ResumeLayout(False)
        Me.Grp_Topo.PerformLayout()
        Me.Grp_Centro.ResumeLayout(False)
        Me.Grp_Centro.PerformLayout()
        Me.Grp_Baixo.ResumeLayout(False)
        Me.Grp_Baixo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Topo As Label
    Friend WithEvents Btn_Topo As Button
    Friend WithEvents Btn_Centro As Button
    Friend WithEvents Btn_Baixo As Button
    Friend WithEvents Btn_Limpar As Button
    Friend WithEvents Txt_Topo As TextBox
    Friend WithEvents Grp_Topo As GroupBox
    Friend WithEvents Grp_Centro As GroupBox
    Friend WithEvents Txt_Centro As TextBox
    Friend WithEvents Grp_Baixo As GroupBox
    Friend WithEvents Txt_Baixo As TextBox
End Class
