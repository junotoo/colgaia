Public Class f34ex2
    Private Sub rbtservicos_CheckedChanged(sender As Object, e As EventArgs) Handles rbtservicos.CheckedChanged
        If rbtservicos.Checked Then
            lblservprod.Text = "Serviço"
        Else
            lblservprod.Text = "Produto"
        End If
    End Sub

    Private Sub btnadicionar_Click(sender As Object, e As EventArgs) Handles btnadicionar.Click
        If Trim(txtservprod.Text) <> "" Then
            If rbtservicos.Checked Then
                If Not clbservicos.Items.Contains(txtservprod.Text) Then
                    clbservicos.Items.Add(txtservprod.Text)
                    txtnumserv.Text = clbservicos.Items.Count
                    btnlimpaserv.Enabled = True
                    btnordenarservicos.Enabled = True
                End If
            Else
                If Not clbprodutos.Items.Contains(txtservprod.Text) Then
                    clbprodutos.Items.Add(txtservprod.Text)
                    txtnumprod.Text = clbprodutos.Items.Count
                    btnlimpaprod.Enabled = True
                    btnordenarprod.Enabled = True
                End If
            End If
            Else
            MessageBox.Show("Não foi introduzido texto na caixa...", "Sem texto")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlimpaserv.Click
        clbservicos.Items.Clear()
        btnlimpaserv.Enabled = False
        btnordenarservicos.Enabled = False
        txtnumserv.Text = clbservicos.Items.Count
    End Sub

    Private Sub btnlimpaprod_Click(sender As Object, e As EventArgs) Handles btnlimpaprod.Click
        clbprodutos.Items.Clear()
        btnlimpaprod.Enabled = False
        btnordenarprod.Enabled = False
        txtnumprod.Text = clbprodutos.Items.Count
    End Sub

    Private Sub btnordenarprod_Click(sender As Object, e As EventArgs) Handles btnordenarprod.Click
        clbprodutos.Sorted = True
    End Sub

    Private Sub btnordenarservicos_Click(sender As Object, e As EventArgs) Handles btnordenarservicos.Click
        clbservicos.Sorted = True
    End Sub
End Class