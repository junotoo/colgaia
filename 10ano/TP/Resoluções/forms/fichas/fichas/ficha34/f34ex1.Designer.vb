<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f34ex1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxmarcaauto = New System.Windows.Forms.ComboBox()
        Me.btnremover = New System.Windows.Forms.Button()
        Me.btnadicionar = New System.Windows.Forms.Button()
        Me.txtmarca = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Marca"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxmarcaauto)
        Me.GroupBox1.Controls.Add(Me.btnremover)
        Me.GroupBox1.Location = New System.Drawing.Point(319, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(243, 95)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'cbxmarcaauto
        '
        Me.cbxmarcaauto.FormattingEnabled = True
        Me.cbxmarcaauto.Items.AddRange(New Object() {"Fiat", "Ford", "Mercedes", "Renault", "Volkswagen"})
        Me.cbxmarcaauto.Location = New System.Drawing.Point(6, 37)
        Me.cbxmarcaauto.Name = "cbxmarcaauto"
        Me.cbxmarcaauto.Size = New System.Drawing.Size(231, 23)
        Me.cbxmarcaauto.Sorted = True
        Me.cbxmarcaauto.TabIndex = 2
        '
        'btnremover
        '
        Me.btnremover.Location = New System.Drawing.Point(6, 66)
        Me.btnremover.Name = "btnremover"
        Me.btnremover.Size = New System.Drawing.Size(107, 23)
        Me.btnremover.TabIndex = 1
        Me.btnremover.Text = "Remover"
        Me.btnremover.UseVisualStyleBackColor = True
        '
        'btnadicionar
        '
        Me.btnadicionar.Location = New System.Drawing.Point(62, 102)
        Me.btnadicionar.Name = "btnadicionar"
        Me.btnadicionar.Size = New System.Drawing.Size(75, 23)
        Me.btnadicionar.TabIndex = 2
        Me.btnadicionar.Text = "Adicionar"
        Me.btnadicionar.UseVisualStyleBackColor = True
        '
        'txtmarca
        '
        Me.txtmarca.Location = New System.Drawing.Point(62, 60)
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(149, 23)
        Me.txtmarca.TabIndex = 3
        '
        'f34ex1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 255)
        Me.Controls.Add(Me.txtmarca)
        Me.Controls.Add(Me.btnadicionar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "f34ex1"
        Me.Text = "Adiciona Items a uma ComboBox"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbxmarcaauto As ComboBox
    Friend WithEvents btnremover As Button
    Friend WithEvents btnadicionar As Button
    Friend WithEvents txtmarca As TextBox
End Class
