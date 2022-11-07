<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Exercício_1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Btn_Num = New System.Windows.Forms.Button()
        Me.Txt_Num = New System.Windows.Forms.TextBox()
        Me.Lbl_Num = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_Num
        '
        Me.Btn_Num.Enabled = False
        Me.Btn_Num.Location = New System.Drawing.Point(150, 47)
        Me.Btn_Num.Name = "Btn_Num"
        Me.Btn_Num.Size = New System.Drawing.Size(105, 33)
        Me.Btn_Num.TabIndex = 0
        Me.Btn_Num.Text = "Verificar Primo"
        Me.Btn_Num.UseVisualStyleBackColor = True
        '
        'Txt_Num
        '
        Me.Txt_Num.Location = New System.Drawing.Point(107, 18)
        Me.Txt_Num.Name = "Txt_Num"
        Me.Txt_Num.Size = New System.Drawing.Size(100, 23)
        Me.Txt_Num.TabIndex = 1
        '
        'Lbl_Num
        '
        Me.Lbl_Num.AutoSize = True
        Me.Lbl_Num.Location = New System.Drawing.Point(12, 26)
        Me.Lbl_Num.Name = "Lbl_Num"
        Me.Lbl_Num.Size = New System.Drawing.Size(91, 15)
        Me.Lbl_Num.TabIndex = 2
        Me.Lbl_Num.Text = "Número Inteiro:"
        '
        'Exercício_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 90)
        Me.Controls.Add(Me.Lbl_Num)
        Me.Controls.Add(Me.Txt_Num)
        Me.Controls.Add(Me.Btn_Num)
        Me.Name = "Exercício_1"
        Me.Text = "Verificar Número Primo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Num As Button
    Friend WithEvents Txt_Num As TextBox
    Friend WithEvents Lbl_Num As Label
End Class
