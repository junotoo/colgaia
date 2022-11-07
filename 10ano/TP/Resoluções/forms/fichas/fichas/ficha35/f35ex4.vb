Public Class f35ex4
    Private Sub cbxcidades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxcidades.SelectedIndexChanged
        txtselecao.Text = cbxcidades.SelectedItem
    End Sub

    Private Sub btnacrescenta_Click(sender As Object, e As EventArgs) Handles btnacrescenta.Click
        If Not cbxcidades.Items.Contains(txtselecao.Text) Then
            cbxcidades.Items.Add(txtselecao.Text)
            cbxcidades.SelectedItem() = txtselecao.Text
        End If
    End Sub
End Class