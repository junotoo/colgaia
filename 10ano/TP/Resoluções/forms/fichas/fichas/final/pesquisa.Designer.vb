<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pesquisa
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
        Me.btnpesquisa = New System.Windows.Forms.Button()
        Me.lblerrodata = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtano = New System.Windows.Forms.TextBox()
        Me.txtmes = New System.Windows.Forms.TextBox()
        Me.txtdia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxescalao = New System.Windows.Forms.ComboBox()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Nome = New System.Windows.Forms.ColumnHeader()
        Me.escalao = New System.Windows.Forms.ColumnHeader()
        Me.dia = New System.Windows.Forms.ColumnHeader()
        Me.mes = New System.Windows.Forms.ColumnHeader()
        Me.ano = New System.Windows.Forms.ColumnHeader()
        Me.pos = New System.Windows.Forms.ColumnHeader()
        Me.lsvencontrados = New System.Windows.Forms.ListView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnpesquisa
        '
        Me.btnpesquisa.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnpesquisa.ForeColor = System.Drawing.Color.White
        Me.btnpesquisa.Location = New System.Drawing.Point(242, 254)
        Me.btnpesquisa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnpesquisa.Name = "btnpesquisa"
        Me.btnpesquisa.Size = New System.Drawing.Size(81, 38)
        Me.btnpesquisa.TabIndex = 55
        Me.btnpesquisa.Text = "Pesquisar"
        Me.btnpesquisa.UseVisualStyleBackColor = False
        '
        'lblerrodata
        '
        Me.lblerrodata.AutoSize = True
        Me.lblerrodata.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblerrodata.ForeColor = System.Drawing.Color.Red
        Me.lblerrodata.Location = New System.Drawing.Point(108, 197)
        Me.lblerrodata.Name = "lblerrodata"
        Me.lblerrodata.Size = New System.Drawing.Size(97, 19)
        Me.lblerrodata.TabIndex = 53
        Me.lblerrodata.Text = "Data Incorreta"
        Me.lblerrodata.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(188, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 15)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(144, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 15)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "-"
        '
        'txtano
        '
        Me.txtano.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtano.ForeColor = System.Drawing.Color.White
        Me.txtano.Location = New System.Drawing.Point(204, 172)
        Me.txtano.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtano.Name = "txtano"
        Me.txtano.Size = New System.Drawing.Size(41, 23)
        Me.txtano.TabIndex = 50
        '
        'txtmes
        '
        Me.txtmes.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtmes.ForeColor = System.Drawing.Color.White
        Me.txtmes.Location = New System.Drawing.Point(160, 172)
        Me.txtmes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtmes.Name = "txtmes"
        Me.txtmes.Size = New System.Drawing.Size(27, 23)
        Me.txtmes.TabIndex = 49
        '
        'txtdia
        '
        Me.txtdia.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtdia.ForeColor = System.Drawing.Color.White
        Me.txtdia.Location = New System.Drawing.Point(111, 172)
        Me.txtdia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtdia.Name = "txtdia"
        Me.txtdia.Size = New System.Drawing.Size(27, 23)
        Me.txtdia.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 30)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Dia de nascimento" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(dia-mês-ano)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 15)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Escalão"
        '
        'cbxescalao
        '
        Me.cbxescalao.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.cbxescalao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxescalao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxescalao.ForeColor = System.Drawing.Color.White
        Me.cbxescalao.FormattingEnabled = True
        Me.cbxescalao.Items.AddRange(New Object() {"sub11", "sub12", "sub13", "sub15"})
        Me.cbxescalao.Location = New System.Drawing.Point(112, 128)
        Me.cbxescalao.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxescalao.Name = "cbxescalao"
        Me.cbxescalao.Size = New System.Drawing.Size(133, 23)
        Me.cbxescalao.TabIndex = 45
        '
        'txtnome
        '
        Me.txtnome.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtnome.ForeColor = System.Drawing.Color.White
        Me.txtnome.Location = New System.Drawing.Point(112, 94)
        Me.txtnome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(150, 23)
        Me.txtnome.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 15)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Nome do Jogador"
        '
        'Nome
        '
        Me.Nome.Text = "Nome"
        '
        'escalao
        '
        Me.escalao.Text = "Escalão"
        '
        'dia
        '
        Me.dia.Text = "Dia"
        '
        'mes
        '
        Me.mes.Text = "Mês"
        '
        'ano
        '
        Me.ano.Text = "Ano"
        '
        'pos
        '
        Me.pos.Text = "Posição"
        '
        'lsvencontrados
        '
        Me.lsvencontrados.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.lsvencontrados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nome, Me.escalao, Me.dia, Me.mes, Me.ano, Me.pos})
        Me.lsvencontrados.ForeColor = System.Drawing.Color.White
        Me.lsvencontrados.FullRowSelect = True
        Me.lsvencontrados.GridLines = True
        Me.lsvencontrados.Location = New System.Drawing.Point(269, 56)
        Me.lsvencontrados.Name = "lsvencontrados"
        Me.lsvencontrados.Size = New System.Drawing.Size(364, 177)
        Me.lsvencontrados.TabIndex = 54
        Me.lsvencontrados.UseCompatibleStateImageBehavior = False
        Me.lsvencontrados.View = System.Windows.Forms.View.Details
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(229, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(404, 15)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Os dados do jogador selecionado foram carregados no formulário principal"
        '
        'pesquisa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnpesquisa)
        Me.Controls.Add(Me.lsvencontrados)
        Me.Controls.Add(Me.lblerrodata)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtano)
        Me.Controls.Add(Me.txtmes)
        Me.Controls.Add(Me.txtdia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbxescalao)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "pesquisa"
        Me.Size = New System.Drawing.Size(639, 318)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnpesquisa As Button
    Friend WithEvents lblerrodata As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtano As TextBox
    Friend WithEvents txtmes As TextBox
    Friend WithEvents txtdia As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxescalao As ComboBox
    Friend WithEvents txtnome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Nome As ColumnHeader
    Friend WithEvents escalao As ColumnHeader
    Friend WithEvents dia As ColumnHeader
    Friend WithEvents mes As ColumnHeader
    Friend WithEvents ano As ColumnHeader
    Friend WithEvents pos As ColumnHeader
    Friend WithEvents lsvencontrados As ListView
    Friend WithEvents Label6 As Label
End Class
