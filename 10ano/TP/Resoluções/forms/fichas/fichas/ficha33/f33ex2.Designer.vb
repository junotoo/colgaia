<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f33ex2
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
        Me.txtlimite = New System.Windows.Forms.TextBox()
        Me.lbllimite = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtlimite
        '
        Me.txtlimite.Location = New System.Drawing.Point(107, 12)
        Me.txtlimite.Name = "txtlimite"
        Me.txtlimite.Size = New System.Drawing.Size(134, 23)
        Me.txtlimite.TabIndex = 3
        '
        'lbllimite
        '
        Me.lbllimite.AutoSize = True
        Me.lbllimite.Location = New System.Drawing.Point(23, 15)
        Me.lbllimite.Name = "lbllimite"
        Me.lbllimite.Size = New System.Drawing.Size(69, 15)
        Me.lbllimite.TabIndex = 2
        Me.lbllimite.Text = "Valor Limite"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Resultados da Raiz Quadrada"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(45, 89)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(159, 184)
        Me.ListBox1.TabIndex = 5
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(45, 291)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(159, 23)
        Me.btncalcular.TabIndex = 6
        Me.btncalcular.Text = "Calcular Raiz Quadrada"
        Me.btncalcular.UseVisualStyleBackColor = True
        Me.btncalcular.Visible = False
        '
        'f33ex2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 335)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtlimite)
        Me.Controls.Add(Me.lbllimite)
        Me.Name = "f33ex2"
        Me.Text = "Raizes quadradas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtlimite As TextBox
    Friend WithEvents lbllimite As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btncalcular As Button
End Class
