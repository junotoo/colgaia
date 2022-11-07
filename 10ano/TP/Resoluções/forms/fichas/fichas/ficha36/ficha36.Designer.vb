<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ficha36
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnf33ex1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(286, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 37)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Ficha 36"
        '
        'btnf33ex1
        '
        Me.btnf33ex1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnf33ex1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnf33ex1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnf33ex1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnf33ex1.ForeColor = System.Drawing.Color.White
        Me.btnf33ex1.Location = New System.Drawing.Point(23, 128)
        Me.btnf33ex1.Name = "btnf33ex1"
        Me.btnf33ex1.Size = New System.Drawing.Size(646, 281)
        Me.btnf33ex1.TabIndex = 8
        Me.btnf33ex1.Text = "Exercício Único"
        Me.btnf33ex1.UseVisualStyleBackColor = False
        '
        'ficha36
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnf33ex1)
        Me.Name = "ficha36"
        Me.Size = New System.Drawing.Size(694, 427)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnf33ex1 As Button
End Class
