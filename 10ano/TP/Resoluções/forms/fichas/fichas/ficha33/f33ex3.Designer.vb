<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f33ex3
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtestacoes = New System.Windows.Forms.RadioButton()
        Me.rbtmeses = New System.Windows.Forms.RadioButton()
        Me.rbtdiasSemana = New System.Windows.Forms.RadioButton()
        Me.lstResultados = New System.Windows.Forms.ListBox()
        Me.btnsair = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtestacoes)
        Me.GroupBox1.Controls.Add(Me.rbtmeses)
        Me.GroupBox1.Controls.Add(Me.rbtdiasSemana)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 66)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'rbtestacoes
        '
        Me.rbtestacoes.AutoSize = True
        Me.rbtestacoes.Location = New System.Drawing.Point(193, 27)
        Me.rbtestacoes.Name = "rbtestacoes"
        Me.rbtestacoes.Size = New System.Drawing.Size(112, 19)
        Me.rbtestacoes.TabIndex = 2
        Me.rbtestacoes.TabStop = True
        Me.rbtestacoes.Text = "Estações do Ano"
        Me.rbtestacoes.UseVisualStyleBackColor = True
        '
        'rbtmeses
        '
        Me.rbtmeses.AutoSize = True
        Me.rbtmeses.Location = New System.Drawing.Point(128, 27)
        Me.rbtmeses.Name = "rbtmeses"
        Me.rbtmeses.Size = New System.Drawing.Size(58, 19)
        Me.rbtmeses.TabIndex = 1
        Me.rbtmeses.TabStop = True
        Me.rbtmeses.Text = "Meses"
        Me.rbtmeses.UseVisualStyleBackColor = True
        '
        'rbtdiasSemana
        '
        Me.rbtdiasSemana.AutoSize = True
        Me.rbtdiasSemana.Location = New System.Drawing.Point(14, 27)
        Me.rbtdiasSemana.Name = "rbtdiasSemana"
        Me.rbtdiasSemana.Size = New System.Drawing.Size(108, 19)
        Me.rbtdiasSemana.TabIndex = 0
        Me.rbtdiasSemana.TabStop = True
        Me.rbtdiasSemana.Text = "Dias da Semana"
        Me.rbtdiasSemana.UseVisualStyleBackColor = True
        '
        'lstResultados
        '
        Me.lstResultados.FormattingEnabled = True
        Me.lstResultados.ItemHeight = 15
        Me.lstResultados.Location = New System.Drawing.Point(74, 102)
        Me.lstResultados.Name = "lstResultados"
        Me.lstResultados.Size = New System.Drawing.Size(183, 184)
        Me.lstResultados.TabIndex = 1
        '
        'btnsair
        '
        Me.btnsair.Location = New System.Drawing.Point(242, 319)
        Me.btnsair.Name = "btnsair"
        Me.btnsair.Size = New System.Drawing.Size(75, 23)
        Me.btnsair.TabIndex = 2
        Me.btnsair.Text = "Sair"
        Me.btnsair.UseVisualStyleBackColor = True
        '
        'f33ex3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 354)
        Me.Controls.Add(Me.btnsair)
        Me.Controls.Add(Me.lstResultados)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "f33ex3"
        Me.Text = "Tempo ao Longo do Ano"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtestacoes As RadioButton
    Friend WithEvents rbtmeses As RadioButton
    Friend WithEvents rbtdiasSemana As RadioButton
    Friend WithEvents lstResultados As ListBox
    Friend WithEvents btnsair As Button
End Class
