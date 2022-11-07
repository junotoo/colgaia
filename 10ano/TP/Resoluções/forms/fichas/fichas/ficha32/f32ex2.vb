Public Class f32ex2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim msg As String = "A sua encomenda tem "
        If chkpepperoni.Checked Or chkfiambre.Checked Or chkcogumelos.Checked Then
            msg &= "ingrediente extra de"
            If chkpepperoni.Checked Then
                msg &= " " & chkpepperoni.Text
            End If
            If chkfiambre.Checked Then
                msg &= " " & chkfiambre.Text
            End If
            If chkpepperoni.Checked Then
                msg &= " " & chkcogumelos.Text
            End If
            msg &= ", "
        End If
        If rtbfina.Checked Then
            msg &= rtbfina.Text
        ElseIf rtbnormal.Checked Then
            msg &= rtbnormal.Text
        End If
        msg &= " e Queijo "
        If rtbmozzarela.Checked Then
            msg &= rtbmozzarela.Text
        ElseIf rtbparmesao.Checked Then
            msg &= rtbparmesao.Text
        End If
        MessageBox.Show(msg & ".")
    End Sub
End Class