<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f32ex2
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkpepperoni = New System.Windows.Forms.CheckBox()
        Me.chkfiambre = New System.Windows.Forms.CheckBox()
        Me.chkcogumelos = New System.Windows.Forms.CheckBox()
        Me.rtbfina = New System.Windows.Forms.RadioButton()
        Me.rtbnormal = New System.Windows.Forms.RadioButton()
        Me.rtbmozzarela = New System.Windows.Forms.RadioButton()
        Me.rtbparmesao = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.fichas.My.Resources.Resources.pizza
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(21, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 126)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkcogumelos)
        Me.GroupBox1.Controls.Add(Me.chkfiambre)
        Me.GroupBox1.Controls.Add(Me.chkpepperoni)
        Me.GroupBox1.Location = New System.Drawing.Point(181, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingredientes"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rtbnormal)
        Me.GroupBox2.Controls.Add(Me.rtbfina)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 177)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(166, 100)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de massa"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rtbparmesao)
        Me.GroupBox3.Controls.Add(Me.rtbmozzarela)
        Me.GroupBox3.Location = New System.Drawing.Point(215, 177)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(166, 100)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo de Queijo"
        '
        'chkpepperoni
        '
        Me.chkpepperoni.AutoSize = True
        Me.chkpepperoni.Location = New System.Drawing.Point(14, 25)
        Me.chkpepperoni.Name = "chkpepperoni"
        Me.chkpepperoni.Size = New System.Drawing.Size(80, 19)
        Me.chkpepperoni.TabIndex = 0
        Me.chkpepperoni.Text = "Pepperoni"
        Me.chkpepperoni.UseVisualStyleBackColor = True
        '
        'chkfiambre
        '
        Me.chkfiambre.AutoSize = True
        Me.chkfiambre.Location = New System.Drawing.Point(14, 50)
        Me.chkfiambre.Name = "chkfiambre"
        Me.chkfiambre.Size = New System.Drawing.Size(69, 19)
        Me.chkfiambre.TabIndex = 1
        Me.chkfiambre.Text = "Fiambre"
        Me.chkfiambre.UseVisualStyleBackColor = True
        '
        'chkcogumelos
        '
        Me.chkcogumelos.AutoSize = True
        Me.chkcogumelos.Location = New System.Drawing.Point(14, 75)
        Me.chkcogumelos.Name = "chkcogumelos"
        Me.chkcogumelos.Size = New System.Drawing.Size(87, 19)
        Me.chkcogumelos.TabIndex = 2
        Me.chkcogumelos.Text = "Cogumelos"
        Me.chkcogumelos.UseVisualStyleBackColor = True
        '
        'rtbfina
        '
        Me.rtbfina.AutoSize = True
        Me.rtbfina.Location = New System.Drawing.Point(12, 29)
        Me.rtbfina.Name = "rtbfina"
        Me.rtbfina.Size = New System.Drawing.Size(47, 19)
        Me.rtbfina.TabIndex = 0
        Me.rtbfina.TabStop = True
        Me.rtbfina.Text = "Fina"
        Me.rtbfina.UseVisualStyleBackColor = True
        '
        'rtbnormal
        '
        Me.rtbnormal.AutoSize = True
        Me.rtbnormal.Location = New System.Drawing.Point(12, 60)
        Me.rtbnormal.Name = "rtbnormal"
        Me.rtbnormal.Size = New System.Drawing.Size(65, 19)
        Me.rtbnormal.TabIndex = 1
        Me.rtbnormal.TabStop = True
        Me.rtbnormal.Text = "Normal"
        Me.rtbnormal.UseVisualStyleBackColor = True
        '
        'rtbmozzarela
        '
        Me.rtbmozzarela.AutoSize = True
        Me.rtbmozzarela.Location = New System.Drawing.Point(6, 28)
        Me.rtbmozzarela.Name = "rtbmozzarela"
        Me.rtbmozzarela.Size = New System.Drawing.Size(78, 19)
        Me.rtbmozzarela.TabIndex = 1
        Me.rtbmozzarela.TabStop = True
        Me.rtbmozzarela.Text = "Mozzarela"
        Me.rtbmozzarela.UseVisualStyleBackColor = True
        '
        'rtbparmesao
        '
        Me.rtbparmesao.AutoSize = True
        Me.rtbparmesao.Location = New System.Drawing.Point(6, 60)
        Me.rtbparmesao.Name = "rtbparmesao"
        Me.rtbparmesao.Size = New System.Drawing.Size(77, 19)
        Me.rtbparmesao.TabIndex = 2
        Me.rtbparmesao.TabStop = True
        Me.rtbparmesao.Text = "Parmesão"
        Me.rtbparmesao.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(142, 300)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 48)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Verifica Encomenda"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'f32ex2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 360)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "f32ex2"
        Me.Text = "Pizzaria do Come Mais"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkcogumelos As CheckBox
    Friend WithEvents chkfiambre As CheckBox
    Friend WithEvents chkpepperoni As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rtbnormal As RadioButton
    Friend WithEvents rtbfina As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rtbparmesao As RadioButton
    Friend WithEvents rtbmozzarela As RadioButton
    Friend WithEvents Button1 As Button
End Class
