Public Class Exercício_1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Txt_Num.TextChanged
        If Txt_Num.Text.Trim() <> "" Then
            Try
                If IsNumeric(Convert.ToInt32(Txt_Num.Text)) Then
                    Btn_Num.Enabled = True
                End If
            Catch ex As Exception
                MessageBox.Show("O valor introduzido não é um número inteiro!")
                Txt_Num.Clear()
            End Try
        Else
            Btn_Num.Enabled = False
        End If
    End Sub

    Private Sub Btn_Num_Click(sender As Object, e As EventArgs) Handles Btn_Num.Click
        If Num_Primo(Convert.ToInt32(Txt_Num.Text)) Then
            MessageBox.Show("O número é primo!!")
        Else
            MessageBox.Show("O número não é primo!!")
        End If

        Txt_Num.Clear()
        Txt_Num.Focus()
    End Sub

    Private Function Num_Primo(num As Integer) As Boolean
        Dim c As Integer = 0

        For i = 1 To num
            If num Mod i = 0 Then
                c += 1
            End If
        Next

        c -= 2 'Retirar 1 e o próprio número

        If c = 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
