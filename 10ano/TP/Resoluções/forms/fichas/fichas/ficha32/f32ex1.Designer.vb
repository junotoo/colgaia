<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f32ex1
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
        Me.grppneus = New System.Windows.Forms.GroupBox()
        Me.chkboxServ3 = New System.Windows.Forms.CheckBox()
        Me.chkboxServ2 = New System.Windows.Forms.CheckBox()
        Me.chkboxServ1 = New System.Windows.Forms.CheckBox()
        Me.grpcor = New System.Windows.Forms.GroupBox()
        Me.rtbvermelho = New System.Windows.Forms.RadioButton()
        Me.rtbpreto = New System.Windows.Forms.RadioButton()
        Me.btnconfirma = New System.Windows.Forms.Button()
        Me.txtcor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtservico1 = New System.Windows.Forms.TextBox()
        Me.txtservico2 = New System.Windows.Forms.TextBox()
        Me.txtservico3 = New System.Windows.Forms.TextBox()
        Me.grppneus.SuspendLayout()
        Me.grpcor.SuspendLayout()
        Me.SuspendLayout()
        '
        'grppneus
        '
        Me.grppneus.Controls.Add(Me.chkboxServ3)
        Me.grppneus.Controls.Add(Me.chkboxServ2)
        Me.grppneus.Controls.Add(Me.chkboxServ1)
        Me.grppneus.Location = New System.Drawing.Point(12, 12)
        Me.grppneus.Name = "grppneus"
        Me.grppneus.Size = New System.Drawing.Size(306, 57)
        Me.grppneus.TabIndex = 0
        Me.grppneus.TabStop = False
        Me.grppneus.Text = "Troca de Pneus"
        '
        'chkboxServ3
        '
        Me.chkboxServ3.AutoSize = True
        Me.chkboxServ3.Location = New System.Drawing.Point(200, 22)
        Me.chkboxServ3.Name = "chkboxServ3"
        Me.chkboxServ3.Size = New System.Drawing.Size(105, 19)
        Me.chkboxServ3.TabIndex = 2
        Me.chkboxServ3.Text = "Troca de Pneus"
        Me.chkboxServ3.UseVisualStyleBackColor = True
        '
        'chkboxServ2
        '
        Me.chkboxServ2.AutoSize = True
        Me.chkboxServ2.Location = New System.Drawing.Point(79, 22)
        Me.chkboxServ2.Name = "chkboxServ2"
        Me.chkboxServ2.Size = New System.Drawing.Size(120, 19)
        Me.chkboxServ2.TabIndex = 1
        Me.chkboxServ2.Text = "Mudança de Óleo"
        Me.chkboxServ2.UseVisualStyleBackColor = True
        '
        'chkboxServ1
        '
        Me.chkboxServ1.AutoSize = True
        Me.chkboxServ1.Location = New System.Drawing.Point(6, 22)
        Me.chkboxServ1.Name = "chkboxServ1"
        Me.chkboxServ1.Size = New System.Drawing.Size(74, 19)
        Me.chkboxServ1.TabIndex = 0
        Me.chkboxServ1.Text = "Lavagem"
        Me.chkboxServ1.UseVisualStyleBackColor = True
        '
        'grpcor
        '
        Me.grpcor.Controls.Add(Me.rtbvermelho)
        Me.grpcor.Controls.Add(Me.rtbpreto)
        Me.grpcor.Location = New System.Drawing.Point(12, 75)
        Me.grpcor.Name = "grpcor"
        Me.grpcor.Size = New System.Drawing.Size(178, 57)
        Me.grpcor.TabIndex = 1
        Me.grpcor.TabStop = False
        Me.grpcor.Text = "Cor"
        '
        'rtbvermelho
        '
        Me.rtbvermelho.AutoSize = True
        Me.rtbvermelho.Location = New System.Drawing.Point(89, 22)
        Me.rtbvermelho.Name = "rtbvermelho"
        Me.rtbvermelho.Size = New System.Drawing.Size(75, 19)
        Me.rtbvermelho.TabIndex = 1
        Me.rtbvermelho.TabStop = True
        Me.rtbvermelho.Text = "Vermelho"
        Me.rtbvermelho.UseVisualStyleBackColor = True
        '
        'rtbpreto
        '
        Me.rtbpreto.AutoSize = True
        Me.rtbpreto.Location = New System.Drawing.Point(16, 22)
        Me.rtbpreto.Name = "rtbpreto"
        Me.rtbpreto.Size = New System.Drawing.Size(53, 19)
        Me.rtbpreto.TabIndex = 0
        Me.rtbpreto.TabStop = True
        Me.rtbpreto.Text = "Preto"
        Me.rtbpreto.UseVisualStyleBackColor = True
        '
        'btnconfirma
        '
        Me.btnconfirma.Location = New System.Drawing.Point(212, 87)
        Me.btnconfirma.Name = "btnconfirma"
        Me.btnconfirma.Size = New System.Drawing.Size(86, 39)
        Me.btnconfirma.TabIndex = 2
        Me.btnconfirma.Text = "Confirma"
        Me.btnconfirma.UseVisualStyleBackColor = True
        '
        'txtcor
        '
        Me.txtcor.Location = New System.Drawing.Point(85, 138)
        Me.txtcor.Name = "txtcor"
        Me.txtcor.ReadOnly = True
        Me.txtcor.Size = New System.Drawing.Size(100, 23)
        Me.txtcor.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(17, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(18, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Serviço1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(18, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Serviço2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(18, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Serviço3"
        '
        'txtservico1
        '
        Me.txtservico1.Location = New System.Drawing.Point(85, 166)
        Me.txtservico1.Name = "txtservico1"
        Me.txtservico1.ReadOnly = True
        Me.txtservico1.Size = New System.Drawing.Size(100, 23)
        Me.txtservico1.TabIndex = 8
        '
        'txtservico2
        '
        Me.txtservico2.Location = New System.Drawing.Point(85, 195)
        Me.txtservico2.Name = "txtservico2"
        Me.txtservico2.ReadOnly = True
        Me.txtservico2.Size = New System.Drawing.Size(100, 23)
        Me.txtservico2.TabIndex = 9
        '
        'txtservico3
        '
        Me.txtservico3.Location = New System.Drawing.Point(85, 224)
        Me.txtservico3.Name = "txtservico3"
        Me.txtservico3.ReadOnly = True
        Me.txtservico3.Size = New System.Drawing.Size(100, 23)
        Me.txtservico3.TabIndex = 10
        '
        'f32ex1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 289)
        Me.Controls.Add(Me.txtservico3)
        Me.Controls.Add(Me.txtservico2)
        Me.Controls.Add(Me.txtservico1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcor)
        Me.Controls.Add(Me.btnconfirma)
        Me.Controls.Add(Me.grpcor)
        Me.Controls.Add(Me.grppneus)
        Me.Name = "f32ex1"
        Me.Text = "Escolha cor e serviços feitos na Oficina"
        Me.grppneus.ResumeLayout(False)
        Me.grppneus.PerformLayout()
        Me.grpcor.ResumeLayout(False)
        Me.grpcor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grppneus As GroupBox
    Friend WithEvents chkboxServ3 As CheckBox
    Friend WithEvents chkboxServ2 As CheckBox
    Friend WithEvents chkboxServ1 As CheckBox
    Friend WithEvents grpcor As GroupBox
    Friend WithEvents rtbvermelho As RadioButton
    Friend WithEvents rtbpreto As RadioButton
    Friend WithEvents btnconfirma As Button
    Friend WithEvents txtcor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtservico1 As TextBox
    Friend WithEvents txtservico2 As TextBox
    Friend WithEvents txtservico3 As TextBox
End Class
