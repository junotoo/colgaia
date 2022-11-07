Public Class Exercício_2
    Private Sub Txt_Segundos_TextChanged(sender As Object, e As EventArgs) Handles Txt_Segundos.TextChanged
        If Txt_Segundos.Text <> "" Then
            Try
                If IsNumeric(Convert.ToInt32(Txt_Segundos.Text)) Then
                    Btn_Converter.Enabled = True
                End If
            Catch ex As Exception
                MessageBox.Show("O valor introduzido não é um número inteiro!")
                Txt_Segundos.Clear()
            End Try
        Else
            Btn_Converter.Enabled = False
        End If
    End Sub

    Private Sub Btn_Converter_Click(sender As Object, e As EventArgs) Handles Btn_Converter.Click
        Txt_Resultado.Text = Convert.ToString(TimeSpan.FromSeconds(Convert.ToInt32(Txt_Segundos.Text)))

        Txt_Segundos.Clear()
        Txt_Segundos.Focus()
    End Sub
End Class