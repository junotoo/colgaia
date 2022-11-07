<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f38ex
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.txtmorada = New System.Windows.Forms.TextBox()
        Me.txttlm = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.lsvdados = New System.Windows.Forms.ListView()
        Me.num = New System.Windows.Forms.ColumnHeader()
        Me.nome = New System.Windows.Forms.ColumnHeader()
        Me.morada = New System.Windows.Forms.ColumnHeader()
        Me.tlm = New System.Windows.Forms.ColumnHeader()
        Me.contact = New System.Windows.Forms.ColumnHeader()
        Me.btnadicionar = New System.Windows.Forms.Button()
        Me.btnremover = New System.Windows.Forms.Button()
        Me.btnselect = New System.Windows.Forms.Button()
        Me.btnselectgrupo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telefone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Morada"
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(70, 61)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(445, 23)
        Me.txtnome.TabIndex = 3
        '
        'txtmorada
        '
        Me.txtmorada.Location = New System.Drawing.Point(70, 96)
        Me.txtmorada.Name = "txtmorada"
        Me.txtmorada.Size = New System.Drawing.Size(445, 23)
        Me.txtmorada.TabIndex = 4
        '
        'txttlm
        '
        Me.txttlm.Location = New System.Drawing.Point(70, 134)
        Me.txttlm.Name = "txttlm"
        Me.txttlm.Size = New System.Drawing.Size(100, 23)
        Me.txttlm.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(400, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Numero do Cliente"
        '
        'txtcliente
        '
        Me.txtcliente.Location = New System.Drawing.Point(514, 25)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(112, 23)
        Me.txtcliente.TabIndex = 7
        '
        'lsvdados
        '
        Me.lsvdados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.num, Me.nome, Me.morada, Me.tlm, Me.contact})
        Me.lsvdados.FullRowSelect = True
        Me.lsvdados.GridLines = True
        Me.lsvdados.Location = New System.Drawing.Point(23, 180)
        Me.lsvdados.Name = "lsvdados"
        Me.lsvdados.Size = New System.Drawing.Size(603, 242)
        Me.lsvdados.TabIndex = 8
        Me.lsvdados.UseCompatibleStateImageBehavior = False
        Me.lsvdados.View = System.Windows.Forms.View.Details
        '
        'num
        '
        Me.num.Tag = ""
        Me.num.Text = "Nº"
        Me.num.Width = 40
        '
        'nome
        '
        Me.nome.Text = "Nome"
        Me.nome.Width = 150
        '
        'morada
        '
        Me.morada.Text = "Morada"
        Me.morada.Width = 150
        '
        'tlm
        '
        Me.tlm.Text = "Telefone"
        Me.tlm.Width = 100
        '
        'contact
        '
        Me.contact.Text = "Contacto"
        Me.contact.Width = 150
        '
        'btnadicionar
        '
        Me.btnadicionar.Location = New System.Drawing.Point(23, 433)
        Me.btnadicionar.Name = "btnadicionar"
        Me.btnadicionar.Size = New System.Drawing.Size(147, 23)
        Me.btnadicionar.TabIndex = 9
        Me.btnadicionar.Text = "Adicionar a Lista"
        Me.btnadicionar.UseVisualStyleBackColor = True
        '
        'btnremover
        '
        Me.btnremover.Location = New System.Drawing.Point(176, 433)
        Me.btnremover.Name = "btnremover"
        Me.btnremover.Size = New System.Drawing.Size(147, 23)
        Me.btnremover.TabIndex = 10
        Me.btnremover.Text = "Remover da lista"
        Me.btnremover.UseVisualStyleBackColor = True
        '
        'btnselect
        '
        Me.btnselect.Enabled = False
        Me.btnselect.Location = New System.Drawing.Point(329, 433)
        Me.btnselect.Name = "btnselect"
        Me.btnselect.Size = New System.Drawing.Size(147, 23)
        Me.btnselect.TabIndex = 11
        Me.btnselect.Text = "Selecionar"
        Me.btnselect.UseVisualStyleBackColor = True
        '
        'btnselectgrupo
        '
        Me.btnselectgrupo.Enabled = False
        Me.btnselectgrupo.Location = New System.Drawing.Point(482, 433)
        Me.btnselectgrupo.Name = "btnselectgrupo"
        Me.btnselectgrupo.Size = New System.Drawing.Size(147, 23)
        Me.btnselectgrupo.TabIndex = 12
        Me.btnselectgrupo.Text = "Selecionar Grupo"
        Me.btnselectgrupo.UseVisualStyleBackColor = True
        '
        'f38ex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 468)
        Me.Controls.Add(Me.btnselectgrupo)
        Me.Controls.Add(Me.btnselect)
        Me.Controls.Add(Me.btnremover)
        Me.Controls.Add(Me.btnadicionar)
        Me.Controls.Add(Me.lsvdados)
        Me.Controls.Add(Me.txtcliente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txttlm)
        Me.Controls.Add(Me.txtmorada)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "f38ex"
        Me.Text = "f38ex"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnome As TextBox
    Friend WithEvents txtmorada As TextBox
    Friend WithEvents txttlm As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcliente As TextBox
    Friend WithEvents lsvdados As ListView
    Friend WithEvents btnadicionar As Button
    Friend WithEvents num As ColumnHeader
    Friend WithEvents nome As ColumnHeader
    Friend WithEvents morada As ColumnHeader
    Private WithEvents tlm As ColumnHeader
    Friend WithEvents contact As ColumnHeader
    Friend WithEvents btnremover As Button
    Friend WithEvents btnselect As Button
    Friend WithEvents btnselectgrupo As Button
End Class
