<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f35ex1
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
        Me.btnadicionar = New System.Windows.Forms.Button()
        Me.btnremover = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblcontador = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnadicionar
        '
        Me.btnadicionar.ForeColor = System.Drawing.Color.Black
        Me.btnadicionar.Location = New System.Drawing.Point(12, 21)
        Me.btnadicionar.Name = "btnadicionar"
        Me.btnadicionar.Size = New System.Drawing.Size(74, 23)
        Me.btnadicionar.TabIndex = 0
        Me.btnadicionar.Text = "+"
        Me.btnadicionar.UseVisualStyleBackColor = True
        '
        'btnremover
        '
        Me.btnremover.Enabled = False
        Me.btnremover.ForeColor = System.Drawing.Color.Black
        Me.btnremover.Location = New System.Drawing.Point(12, 50)
        Me.btnremover.Name = "btnremover"
        Me.btnremover.Size = New System.Drawing.Size(74, 23)
        Me.btnremover.TabIndex = 1
        Me.btnremover.Text = "-"
        Me.btnremover.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(92, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Contador:"
        '
        'lblcontador
        '
        Me.lblcontador.AutoSize = True
        Me.lblcontador.Location = New System.Drawing.Point(147, 38)
        Me.lblcontador.Name = "lblcontador"
        Me.lblcontador.Size = New System.Drawing.Size(13, 15)
        Me.lblcontador.TabIndex = 3
        Me.lblcontador.Text = "0"
        '
        'f35ex1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(225, 89)
        Me.Controls.Add(Me.lblcontador)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnremover)
        Me.Controls.Add(Me.btnadicionar)
        Me.Name = "f35ex1"
        Me.Text = "f35ex1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnadicionar As Button
    Friend WithEvents btnremover As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblcontador As Label
End Class
