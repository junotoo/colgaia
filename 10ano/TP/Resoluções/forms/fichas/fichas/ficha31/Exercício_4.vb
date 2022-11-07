Public Class Exercício_4
    Private Sub Txt_Topo_TextChanged(sender As Object, e As EventArgs) Handles Txt_Topo.TextChanged
        If Txt_Topo.Text.Trim() <> "" Then
            If Not IsNumeric(Txt_Topo.Text.Trim()) Then
                MessageBox.Show("O valor que escreveu não é um número!")

                Txt_Topo.Clear()
                Txt_Topo.Focus()
            End If
        End If

        If Txt_Topo.Text.Trim() <> "" And Txt_Centro.Text.Trim() <> "" Then
            If IsNumeric(Txt_Topo.Text.Trim()) And IsNumeric(Txt_Centro.Text.Trim()) Then
                Btn_Topo.Enabled = True
                Btn_Centro.Enabled = True
                Btn_Baixo.Enabled = True
            Else
                MessageBox.Show("O valor que escreveu não é um número!")

                Txt_Topo.Clear()
                Txt_Topo.Focus()
            End If
        Else
            Btn_Topo.Enabled = False
            Btn_Centro.Enabled = False
            Btn_Baixo.Enabled = False
        End If

        If Txt_Topo.Text <> "" Or Txt_Centro.Text <> "" Or Txt_Baixo.Text <> "" Then
            Btn_Limpar.Enabled = True
        Else
            Btn_Limpar.Enabled = False
        End If
    End Sub

    Private Sub Txt_Centro_TextChanged(sender As Object, e As EventArgs) Handles Txt_Centro.TextChanged
        If Txt_Centro.Text.Trim() <> "" Then
            If Not IsNumeric(Txt_Centro.Text.Trim()) Then
                MessageBox.Show("O valor que escreveu não é um número!")

                Txt_Centro.Clear()
                Txt_Centro.Focus()
            End If
        End If

        If Txt_Topo.Text.Trim() <> "" And Txt_Centro.Text.Trim() <> "" Then
            If IsNumeric(Txt_Topo.Text.Trim()) And IsNumeric(Txt_Centro.Text.Trim()) Then
                Btn_Topo.Enabled = True
                Btn_Centro.Enabled = True
                Btn_Baixo.Enabled = True
                Btn_Limpar.Enabled = True
            Else
                MessageBox.Show("O valor que escreveu não é um número!")

                Txt_Centro.Clear()
                Txt_Centro.Focus()
            End If
        Else
            Btn_Topo.Enabled = False
            Btn_Centro.Enabled = False
            Btn_Baixo.Enabled = False
            Btn_Limpar.Enabled = False
        End If

        If Txt_Topo.Text <> "" Or Txt_Centro.Text <> "" Or Txt_Baixo.Text <> "" Then
            Btn_Limpar.Enabled = True
        Else
            Btn_Limpar.Enabled = False
        End If
    End Sub

    Private Sub Btn_Limpar_Click(sender As Object, e As EventArgs) Handles Btn_Limpar.Click
        Txt_Topo.Clear()
        Txt_Centro.Clear()
        Txt_Baixo.Clear()
    End Sub

    Private Sub Btn_Topo_Click(sender As Object, e As EventArgs) Handles Btn_Topo.Click
        Txt_Baixo.Text = Div_1_2(Txt_Topo.Text, Txt_Centro.Text)
    End Sub

    Private Sub Btn_Centro_Click(sender As Object, e As EventArgs) Handles Btn_Centro.Click
        Txt_Baixo.Text = Div_2_1(Txt_Topo.Text, Txt_Centro.Text)
    End Sub

    Private Sub Btn_Baixo_Click(sender As Object, e As EventArgs) Handles Btn_Baixo.Click
        Dim diferenca As Double

        diferenca = Div_1_2(Txt_Topo.Text, Txt_Centro.Text) - Div_2_1(Txt_Topo.Text, Txt_Centro.Text)

        Txt_Baixo.Text = diferenca
    End Sub

    Private Function Div_1_2(num_1 As Double, num_2 As Double)
        Dim resultado As Double

        resultado = num_1 / num_2
        resultado = resultado.ToString("n") ' Converte o número e formata-o para conter 2 casas decimais

        Return resultado
    End Function

    Private Function Div_2_1(num_1 As Double, num_2 As Double)
        Dim resultado As Double

        resultado = num_2 / num_1
        resultado = resultado.ToString("n") ' Converte o número e formata-o para conter 2 casas decimais

        Return resultado
    End Function
End Class