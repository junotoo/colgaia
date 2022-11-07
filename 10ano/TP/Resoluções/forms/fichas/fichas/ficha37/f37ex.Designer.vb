<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f37ex
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstnome = New System.Windows.Forms.ListBox()
        Me.lstturma = New System.Windows.Forms.ListBox()
        Me.lstnum = New System.Windows.Forms.ListBox()
        Me.btnremover = New System.Windows.Forms.Button()
        Me.btnatualizar = New System.Windows.Forms.Button()
        Me.btnadicionar = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(32, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOME DO ALUNO"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(261, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TURMA"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(394, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nº"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lstnome
        '
        Me.lstnome.FormattingEnabled = True
        Me.lstnome.ItemHeight = 15
        Me.lstnome.Location = New System.Drawing.Point(32, 59)
        Me.lstnome.Name = "lstnome"
        Me.lstnome.Size = New System.Drawing.Size(230, 199)
        Me.lstnome.TabIndex = 3
        '
        'lstturma
        '
        Me.lstturma.FormattingEnabled = True
        Me.lstturma.ItemHeight = 15
        Me.lstturma.Location = New System.Drawing.Point(261, 59)
        Me.lstturma.Name = "lstturma"
        Me.lstturma.Size = New System.Drawing.Size(134, 199)
        Me.lstturma.TabIndex = 4
        '
        'lstnum
        '
        Me.lstnum.FormattingEnabled = True
        Me.lstnum.ItemHeight = 15
        Me.lstnum.Location = New System.Drawing.Point(394, 59)
        Me.lstnum.Name = "lstnum"
        Me.lstnum.Size = New System.Drawing.Size(64, 199)
        Me.lstnum.TabIndex = 5
        '
        'btnremover
        '
        Me.btnremover.Location = New System.Drawing.Point(343, 264)
        Me.btnremover.Name = "btnremover"
        Me.btnremover.Size = New System.Drawing.Size(115, 41)
        Me.btnremover.TabIndex = 6
        Me.btnremover.Text = "Remover"
        Me.btnremover.UseVisualStyleBackColor = True
        '
        'btnatualizar
        '
        Me.btnatualizar.Location = New System.Drawing.Point(197, 264)
        Me.btnatualizar.Name = "btnatualizar"
        Me.btnatualizar.Size = New System.Drawing.Size(123, 41)
        Me.btnatualizar.TabIndex = 7
        Me.btnatualizar.Text = "Atualizar"
        Me.btnatualizar.UseVisualStyleBackColor = True
        '
        'btnadicionar
        '
        Me.btnadicionar.Location = New System.Drawing.Point(32, 264)
        Me.btnadicionar.Name = "btnadicionar"
        Me.btnadicionar.Size = New System.Drawing.Size(124, 41)
        Me.btnadicionar.TabIndex = 8
        Me.btnadicionar.Text = "Adicionar"
        Me.btnadicionar.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(379, 321)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(67, 39)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Fechar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'f37ex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 372)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnadicionar)
        Me.Controls.Add(Me.btnatualizar)
        Me.Controls.Add(Me.btnremover)
        Me.Controls.Add(Me.lstnum)
        Me.Controls.Add(Me.lstturma)
        Me.Controls.Add(Me.lstnome)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "f37ex"
        Me.Text = "Principal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lstnome As ListBox
    Friend WithEvents lstturma As ListBox
    Friend WithEvents lstnum As ListBox
    Friend WithEvents btnremover As Button
    Friend WithEvents btnatualizar As Button
    Friend WithEvents btnadicionar As Button
    Friend WithEvents Button4 As Button
End Class
