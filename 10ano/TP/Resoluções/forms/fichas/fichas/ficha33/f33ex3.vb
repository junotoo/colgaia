Public Class f33ex3
    Private Sub rbtdiasSemana_CheckedChanged(sender As Object, e As EventArgs) Handles rbtdiasSemana.CheckedChanged
        Dim semana As String() = {"Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado", "Domingo"}
        lstResultados.Items.Clear()
        For c As Integer = 0 To 6
            lstResultados.Items.Add(semana(c))
        Next
    End Sub
    Private Sub btnsair_Click(sender As Object, e As EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub

    Private Sub rbtmeses_CheckedChanged(sender As Object, e As EventArgs) Handles rbtmeses.CheckedChanged
        Dim meses As String() = {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"}
        lstResultados.Items.Clear()
        For c As Integer = 0 To 11
            lstResultados.Items.Add(meses(c))
        Next
    End Sub

    Private Sub rbtestacoes_CheckedChanged(sender As Object, e As EventArgs) Handles rbtestacoes.CheckedChanged
        Dim estacoes As String() = {"Inverno", "Primavera", "Verão", "Outono"}
        lstResultados.Items.Clear()
        For c As Integer = 0 To 3
            lstResultados.Items.Add(estacoes(c))
        Next
    End Sub
End Class