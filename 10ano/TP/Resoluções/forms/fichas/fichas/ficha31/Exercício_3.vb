Public Class Exercício_3
    Private Sub Txt_Num_TextChanged(sender As Object, e As EventArgs) Handles Txt_Num.TextChanged
        If Txt_Num.Text <> "" Then
            If IsNumeric(Txt_Num.Text) Then
                Btn_Calcular.Enabled = True
            Else
                MessageBox.Show("O valor que escreveu não é um número!")

                Txt_Num.Clear()
                Txt_Num.Focus()
            End If
        Else
            Btn_Calcular.Enabled = False
        End If
    End Sub

    Private Sub Btn_Calcular_Click(sender As Object, e As EventArgs) Handles Btn_Calcular.Click
        Dim valor_final As String

        If Txt_Num.Text.IndexOf(",") <> -1 Then
            valor_final = Txt_Num.Text.Trim().Remove(Txt_Num.Text.IndexOf(","), 1)
        Else
            valor_final = Txt_Num.Text.Trim()
        End If

        Txt_Resultado.Text = Len(valor_final)
    End Sub
End Class