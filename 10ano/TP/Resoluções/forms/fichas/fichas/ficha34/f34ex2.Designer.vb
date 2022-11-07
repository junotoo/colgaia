<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f34ex2
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
        Me.rbtservicos = New System.Windows.Forms.RadioButton()
        Me.rbtprodutos = New System.Windows.Forms.RadioButton()
        Me.lblservprod = New System.Windows.Forms.Label()
        Me.txtservprod = New System.Windows.Forms.TextBox()
        Me.btnadicionar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.clbservicos = New System.Windows.Forms.CheckedListBox()
        Me.clbprodutos = New System.Windows.Forms.CheckedListBox()
        Me.txtnumserv = New System.Windows.Forms.TextBox()
        Me.txtnumprod = New System.Windows.Forms.TextBox()
        Me.btnlimpaserv = New System.Windows.Forms.Button()
        Me.btnordenarservicos = New System.Windows.Forms.Button()
        Me.btnlimpaprod = New System.Windows.Forms.Button()
        Me.btnordenarprod = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnadicionar)
        Me.GroupBox1.Controls.Add(Me.txtservprod)
        Me.GroupBox1.Controls.Add(Me.lblservprod)
        Me.GroupBox1.Controls.Add(Me.rbtprodutos)
        Me.GroupBox1.Controls.Add(Me.rbtservicos)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(566, 108)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adiciona Opções de Serviços/Produtos"
        '
        'rbtservicos
        '
        Me.rbtservicos.AutoSize = True
        Me.rbtservicos.Checked = True
        Me.rbtservicos.Location = New System.Drawing.Point(6, 32)
        Me.rbtservicos.Name = "rbtservicos"
        Me.rbtservicos.Size = New System.Drawing.Size(68, 19)
        Me.rbtservicos.TabIndex = 0
        Me.rbtservicos.TabStop = True
        Me.rbtservicos.Text = "Serviços"
        Me.rbtservicos.UseVisualStyleBackColor = True
        '
        'rbtprodutos
        '
        Me.rbtprodutos.AutoSize = True
        Me.rbtprodutos.Location = New System.Drawing.Point(6, 67)
        Me.rbtprodutos.Name = "rbtprodutos"
        Me.rbtprodutos.Size = New System.Drawing.Size(73, 19)
        Me.rbtprodutos.TabIndex = 1
        Me.rbtprodutos.Text = "Produtos"
        Me.rbtprodutos.UseVisualStyleBackColor = True
        '
        'lblservprod
        '
        Me.lblservprod.AutoSize = True
        Me.lblservprod.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblservprod.Location = New System.Drawing.Point(276, 19)
        Me.lblservprod.Name = "lblservprod"
        Me.lblservprod.Size = New System.Drawing.Size(45, 15)
        Me.lblservprod.TabIndex = 2
        Me.lblservprod.Text = "Serviço"
        '
        'txtservprod
        '
        Me.txtservprod.Location = New System.Drawing.Point(276, 37)
        Me.txtservprod.Name = "txtservprod"
        Me.txtservprod.Size = New System.Drawing.Size(202, 23)
        Me.txtservprod.TabIndex = 3
        '
        'btnadicionar
        '
        Me.btnadicionar.Location = New System.Drawing.Point(276, 67)
        Me.btnadicionar.Name = "btnadicionar"
        Me.btnadicionar.Size = New System.Drawing.Size(115, 28)
        Me.btnadicionar.TabIndex = 4
        Me.btnadicionar.Text = "Adicionar"
        Me.btnadicionar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nº de Serviços"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(330, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nº de Produtos"
        '
        'clbservicos
        '
        Me.clbservicos.FormattingEnabled = True
        Me.clbservicos.Items.AddRange(New Object() {"Troca de Pneus"})
        Me.clbservicos.Location = New System.Drawing.Point(18, 170)
        Me.clbservicos.Name = "clbservicos"
        Me.clbservicos.Size = New System.Drawing.Size(258, 130)
        Me.clbservicos.TabIndex = 3
        '
        'clbprodutos
        '
        Me.clbprodutos.FormattingEnabled = True
        Me.clbprodutos.Items.AddRange(New Object() {"Óleo Castrol Edge 5W30"})
        Me.clbprodutos.Location = New System.Drawing.Point(330, 170)
        Me.clbprodutos.Name = "clbprodutos"
        Me.clbprodutos.Size = New System.Drawing.Size(229, 130)
        Me.clbprodutos.TabIndex = 4
        '
        'txtnumserv
        '
        Me.txtnumserv.Location = New System.Drawing.Point(239, 144)
        Me.txtnumserv.Name = "txtnumserv"
        Me.txtnumserv.ReadOnly = True
        Me.txtnumserv.Size = New System.Drawing.Size(37, 23)
        Me.txtnumserv.TabIndex = 5
        Me.txtnumserv.Text = "1"
        '
        'txtnumprod
        '
        Me.txtnumprod.Location = New System.Drawing.Point(522, 144)
        Me.txtnumprod.Name = "txtnumprod"
        Me.txtnumprod.ReadOnly = True
        Me.txtnumprod.Size = New System.Drawing.Size(37, 23)
        Me.txtnumprod.TabIndex = 6
        Me.txtnumprod.Text = "1"
        '
        'btnlimpaserv
        '
        Me.btnlimpaserv.Location = New System.Drawing.Point(18, 306)
        Me.btnlimpaserv.Name = "btnlimpaserv"
        Me.btnlimpaserv.Size = New System.Drawing.Size(75, 40)
        Me.btnlimpaserv.TabIndex = 7
        Me.btnlimpaserv.Text = "Limpar Serviços"
        Me.btnlimpaserv.UseVisualStyleBackColor = True
        '
        'btnordenarservicos
        '
        Me.btnordenarservicos.Location = New System.Drawing.Point(201, 306)
        Me.btnordenarservicos.Name = "btnordenarservicos"
        Me.btnordenarservicos.Size = New System.Drawing.Size(75, 40)
        Me.btnordenarservicos.TabIndex = 8
        Me.btnordenarservicos.Text = "Ordenar Serviços"
        Me.btnordenarservicos.UseVisualStyleBackColor = True
        '
        'btnlimpaprod
        '
        Me.btnlimpaprod.Location = New System.Drawing.Point(330, 306)
        Me.btnlimpaprod.Name = "btnlimpaprod"
        Me.btnlimpaprod.Size = New System.Drawing.Size(75, 40)
        Me.btnlimpaprod.TabIndex = 9
        Me.btnlimpaprod.Text = "Limpar Produtos"
        Me.btnlimpaprod.UseVisualStyleBackColor = True
        '
        'btnordenarprod
        '
        Me.btnordenarprod.Location = New System.Drawing.Point(484, 306)
        Me.btnordenarprod.Name = "btnordenarprod"
        Me.btnordenarprod.Size = New System.Drawing.Size(75, 40)
        Me.btnordenarprod.TabIndex = 10
        Me.btnordenarprod.Text = "Ordenar Produtos"
        Me.btnordenarprod.UseVisualStyleBackColor = True
        '
        'f34ex2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 358)
        Me.Controls.Add(Me.btnordenarprod)
        Me.Controls.Add(Me.btnlimpaprod)
        Me.Controls.Add(Me.btnordenarservicos)
        Me.Controls.Add(Me.btnlimpaserv)
        Me.Controls.Add(Me.txtnumprod)
        Me.Controls.Add(Me.txtnumserv)
        Me.Controls.Add(Me.clbprodutos)
        Me.Controls.Add(Me.clbservicos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "f34ex2"
        Me.Text = "Trabalhar com CheckedListBox"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtservicos As RadioButton
    Friend WithEvents btnadicionar As Button
    Friend WithEvents txtservprod As TextBox
    Friend WithEvents lblservprod As Label
    Friend WithEvents rbtprodutos As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents clbservicos As CheckedListBox
    Friend WithEvents clbprodutos As CheckedListBox
    Friend WithEvents txtnumserv As TextBox
    Friend WithEvents txtnumprod As TextBox
    Friend WithEvents btnlimpaserv As Button
    Friend WithEvents btnordenarservicos As Button
    Friend WithEvents btnlimpaprod As Button
    Friend WithEvents btnordenarprod As Button
End Class
