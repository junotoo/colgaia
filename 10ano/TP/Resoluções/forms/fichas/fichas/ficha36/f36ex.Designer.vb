<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f36ex
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
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstAlunos = New System.Windows.Forms.ListBox()
        Me.btnaddaluno = New System.Windows.Forms.Button()
        Me.btnremaluno = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxdisciplinas = New System.Windows.Forms.ComboBox()
        Me.btnadddisc = New System.Windows.Forms.Button()
        Me.btnremdisc = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstDisciplinas = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome:"
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(64, 22)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(196, 23)
        Me.txtnome.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(266, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Alunos Inscritos"
        '
        'lstAlunos
        '
        Me.lstAlunos.FormattingEnabled = True
        Me.lstAlunos.ItemHeight = 15
        Me.lstAlunos.Location = New System.Drawing.Point(266, 53)
        Me.lstAlunos.Name = "lstAlunos"
        Me.lstAlunos.Size = New System.Drawing.Size(186, 409)
        Me.lstAlunos.TabIndex = 3
        '
        'btnaddaluno
        '
        Me.btnaddaluno.Location = New System.Drawing.Point(64, 65)
        Me.btnaddaluno.Name = "btnaddaluno"
        Me.btnaddaluno.Size = New System.Drawing.Size(107, 37)
        Me.btnaddaluno.TabIndex = 4
        Me.btnaddaluno.Text = "Adicionar Aluno"
        Me.btnaddaluno.UseVisualStyleBackColor = True
        '
        'btnremaluno
        '
        Me.btnremaluno.ForeColor = System.Drawing.Color.Red
        Me.btnremaluno.Location = New System.Drawing.Point(64, 121)
        Me.btnremaluno.Name = "btnremaluno"
        Me.btnremaluno.Size = New System.Drawing.Size(107, 37)
        Me.btnremaluno.TabIndex = 5
        Me.btnremaluno.Text = "Remover Aluno"
        Me.btnremaluno.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Disciplinas para Matricula:"
        '
        'cbxdisciplinas
        '
        Me.cbxdisciplinas.FormattingEnabled = True
        Me.cbxdisciplinas.Items.AddRange(New Object() {"Português", "Filosofia", "Inglês", "Matemática", "Física e Química", "Técnicas de Programação", "Aplicações Informáticas", "Fundamentos e Arquitetura de Computadores"})
        Me.cbxdisciplinas.Location = New System.Drawing.Point(15, 205)
        Me.cbxdisciplinas.Name = "cbxdisciplinas"
        Me.cbxdisciplinas.Size = New System.Drawing.Size(245, 23)
        Me.cbxdisciplinas.TabIndex = 8
        '
        'btnadddisc
        '
        Me.btnadddisc.Location = New System.Drawing.Point(15, 245)
        Me.btnadddisc.Name = "btnadddisc"
        Me.btnadddisc.Size = New System.Drawing.Size(123, 37)
        Me.btnadddisc.TabIndex = 9
        Me.btnadddisc.Text = "Adicionar Disciplina"
        Me.btnadddisc.UseVisualStyleBackColor = True
        '
        'btnremdisc
        '
        Me.btnremdisc.ForeColor = System.Drawing.Color.Red
        Me.btnremdisc.Location = New System.Drawing.Point(144, 245)
        Me.btnremdisc.Name = "btnremdisc"
        Me.btnremdisc.Size = New System.Drawing.Size(116, 37)
        Me.btnremdisc.TabIndex = 10
        Me.btnremdisc.Text = "Remover Disciplina"
        Me.btnremdisc.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 296)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Disciplinas Matriculadas"
        '
        'lstDisciplinas
        '
        Me.lstDisciplinas.FormattingEnabled = True
        Me.lstDisciplinas.ItemHeight = 15
        Me.lstDisciplinas.Location = New System.Drawing.Point(15, 333)
        Me.lstDisciplinas.Name = "lstDisciplinas"
        Me.lstDisciplinas.Size = New System.Drawing.Size(236, 139)
        Me.lstDisciplinas.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(64, 494)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 37)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Sair"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(269, 505)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Total de Alunos"
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(383, 502)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(69, 23)
        Me.txttotal.TabIndex = 15
        '
        'f36ex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 553)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lstDisciplinas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnremdisc)
        Me.Controls.Add(Me.btnadddisc)
        Me.Controls.Add(Me.cbxdisciplinas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnremaluno)
        Me.Controls.Add(Me.btnaddaluno)
        Me.Controls.Add(Me.lstAlunos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.Label1)
        Me.Name = "f36ex"
        Me.Text = "Matrícula de Alunos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtnome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lstAlunos As ListBox
    Friend WithEvents btnaddaluno As Button
    Friend WithEvents btnremaluno As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxdisciplinas As ComboBox
    Friend WithEvents btnadddisc As Button
    Friend WithEvents btnremdisc As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lstDisciplinas As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txttotal As TextBox
End Class
