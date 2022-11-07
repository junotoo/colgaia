<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f33ex5
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
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtmax = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(68, 14)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(100, 23)
        Me.txtnumero.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Número"
        '
        'btncalcular
        '
        Me.btncalcular.Enabled = False
        Me.btncalcular.Location = New System.Drawing.Point(157, 66)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.btncalcular.TabIndex = 2
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(215, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Maior Algarismo"
        '
        'txtmax
        '
        Me.txtmax.Location = New System.Drawing.Point(314, 115)
        Me.txtmax.Name = "txtmax"
        Me.txtmax.ReadOnly = True
        Me.txtmax.Size = New System.Drawing.Size(100, 23)
        Me.txtmax.TabIndex = 3
        '
        'f33ex5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 157)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtmax)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnumero)
        Me.Name = "f33ex5"
        Me.Text = "f33ex5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnumero As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btncalcular As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtmax As TextBox
End Class
