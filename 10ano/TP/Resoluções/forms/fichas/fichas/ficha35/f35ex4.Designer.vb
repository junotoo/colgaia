<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f35ex4
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
        Me.cbxcidades = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtselecao = New System.Windows.Forms.TextBox()
        Me.btnacrescenta = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbxcidades
        '
        Me.cbxcidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxcidades.FormattingEnabled = True
        Me.cbxcidades.Location = New System.Drawing.Point(12, 40)
        Me.cbxcidades.Name = "cbxcidades"
        Me.cbxcidades.Size = New System.Drawing.Size(151, 28)
        Me.cbxcidades.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ComboBox com lista de Cidades"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Seleccao"
        '
        'txtselecao
        '
        Me.txtselecao.Location = New System.Drawing.Point(12, 113)
        Me.txtselecao.Name = "txtselecao"
        Me.txtselecao.Size = New System.Drawing.Size(151, 27)
        Me.txtselecao.TabIndex = 3
        '
        'btnacrescenta
        '
        Me.btnacrescenta.Location = New System.Drawing.Point(211, 72)
        Me.btnacrescenta.Name = "btnacrescenta"
        Me.btnacrescenta.Size = New System.Drawing.Size(94, 29)
        Me.btnacrescenta.TabIndex = 4
        Me.btnacrescenta.Text = "Acrescentar"
        Me.btnacrescenta.UseVisualStyleBackColor = True
        '
        'f35ex4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 164)
        Me.Controls.Add(Me.btnacrescenta)
        Me.Controls.Add(Me.txtselecao)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxcidades)
        Me.Name = "f35ex4"
        Me.Text = "Exercício com ComboBox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxcidades As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtselecao As TextBox
    Friend WithEvents btnacrescenta As Button
End Class
