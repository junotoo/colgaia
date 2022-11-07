<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f33ex1
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
        Me.lbllimite = New System.Windows.Forms.Label()
        Me.txtlimite = New System.Windows.Forms.TextBox()
        Me.grptipo = New System.Windows.Forms.GroupBox()
        Me.rdbpares = New System.Windows.Forms.RadioButton()
        Me.rdbsequencial = New System.Windows.Forms.RadioButton()
        Me.lstNumero = New System.Windows.Forms.ListBox()
        Me.btnlistar = New System.Windows.Forms.Button()
        Me.grptipo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbllimite
        '
        Me.lbllimite.AutoSize = True
        Me.lbllimite.Location = New System.Drawing.Point(53, 26)
        Me.lbllimite.Name = "lbllimite"
        Me.lbllimite.Size = New System.Drawing.Size(40, 15)
        Me.lbllimite.TabIndex = 0
        Me.lbllimite.Text = "Limite"
        '
        'txtlimite
        '
        Me.txtlimite.Location = New System.Drawing.Point(109, 23)
        Me.txtlimite.Name = "txtlimite"
        Me.txtlimite.Size = New System.Drawing.Size(134, 23)
        Me.txtlimite.TabIndex = 1
        '
        'grptipo
        '
        Me.grptipo.Controls.Add(Me.rdbpares)
        Me.grptipo.Controls.Add(Me.rdbsequencial)
        Me.grptipo.Location = New System.Drawing.Point(53, 82)
        Me.grptipo.Name = "grptipo"
        Me.grptipo.Size = New System.Drawing.Size(227, 56)
        Me.grptipo.TabIndex = 2
        Me.grptipo.TabStop = False
        Me.grptipo.Text = "Seleção do tipo de listagem"
        '
        'rdbpares
        '
        Me.rdbpares.AutoSize = True
        Me.rdbpares.Location = New System.Drawing.Point(128, 22)
        Me.rdbpares.Name = "rdbpares"
        Me.rdbpares.Size = New System.Drawing.Size(53, 19)
        Me.rdbpares.TabIndex = 1
        Me.rdbpares.TabStop = True
        Me.rdbpares.Text = "Pares"
        Me.rdbpares.UseVisualStyleBackColor = True
        '
        'rdbsequencial
        '
        Me.rdbsequencial.AutoSize = True
        Me.rdbsequencial.Location = New System.Drawing.Point(6, 22)
        Me.rdbsequencial.Name = "rdbsequencial"
        Me.rdbsequencial.Size = New System.Drawing.Size(82, 19)
        Me.rdbsequencial.TabIndex = 0
        Me.rdbsequencial.TabStop = True
        Me.rdbsequencial.Text = "Sequencial"
        Me.rdbsequencial.UseVisualStyleBackColor = True
        '
        'lstNumero
        '
        Me.lstNumero.FormattingEnabled = True
        Me.lstNumero.ItemHeight = 15
        Me.lstNumero.Location = New System.Drawing.Point(12, 167)
        Me.lstNumero.Name = "lstNumero"
        Me.lstNumero.Size = New System.Drawing.Size(141, 229)
        Me.lstNumero.TabIndex = 3
        '
        'btnlistar
        '
        Me.btnlistar.Location = New System.Drawing.Point(205, 167)
        Me.btnlistar.Name = "btnlistar"
        Me.btnlistar.Size = New System.Drawing.Size(75, 23)
        Me.btnlistar.TabIndex = 4
        Me.btnlistar.Text = "Listar"
        Me.btnlistar.UseVisualStyleBackColor = True
        Me.btnlistar.Visible = False
        '
        'f33ex1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 450)
        Me.Controls.Add(Me.btnlistar)
        Me.Controls.Add(Me.lstNumero)
        Me.Controls.Add(Me.grptipo)
        Me.Controls.Add(Me.txtlimite)
        Me.Controls.Add(Me.lbllimite)
        Me.Name = "f33ex1"
        Me.Text = " "
        Me.grptipo.ResumeLayout(False)
        Me.grptipo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbllimite As Label
    Friend WithEvents txtlimite As TextBox
    Friend WithEvents grptipo As GroupBox
    Friend WithEvents rdbpares As RadioButton
    Friend WithEvents rdbsequencial As RadioButton
    Friend WithEvents lstNumero As ListBox
    Friend WithEvents btnlistar As Button
End Class
