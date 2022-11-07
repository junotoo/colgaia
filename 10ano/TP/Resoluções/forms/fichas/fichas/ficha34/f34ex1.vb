Public Class f34ex1
    Private Sub btnadicionar_Click(sender As Object, e As EventArgs) Handles btnadicionar.Click
        If Trim(txtmarca.Text) <> "" Then
            If Not cbxmarcaauto.Items.Contains(txtmarca.Text) Then
                cbxmarcaauto.Items.Add(txtmarca.Text)
            End If
        Else
            MessageBox.Show("Não foi introduzido texto na caixa...", "Sem texto", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub btnremover_Click(sender As Object, e As EventArgs) Handles btnremover.Click
        cbxmarcaauto.Items.Remove(cbxmarcaauto.SelectedItem)
    End Sub
End Class