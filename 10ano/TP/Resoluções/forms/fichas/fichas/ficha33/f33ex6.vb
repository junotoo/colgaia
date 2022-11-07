Public Class f33ex6
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtintroduzir.TextChanged
        If Trim(txtintroduzir.Text) <> "" And txtintroduzir.Text <> lstcidades.SelectedItem Then
            btnacrescenta.Enabled = True
            btnlimpar.Enabled = True
        Else
            btnacrescenta.Enabled = False
            btnlimpar.Enabled = False
        End If
    End Sub

    Private Sub lstcidades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstcidades.SelectedIndexChanged
        If lstcidades.SelectedIndex >= 0 Then
            btnremove.Enabled = True
            txtintroduzir.Text = lstcidades.SelectedItem
        Else
            btnremove.Enabled = False
        End If
    End Sub

    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click
        lstcidades.Items.Remove(lstcidades.SelectedItem)
    End Sub

    Private Sub btnacrescenta_Click(sender As Object, e As EventArgs) Handles btnacrescenta.Click
        lstcidades.Items.Add(txtintroduzir.Text)
    End Sub

    Private Sub btnlimpar_Click(sender As Object, e As EventArgs) Handles btnlimpar.Click
        txtintroduzir.Text = ""
    End Sub

    Private Sub btniniciar_Click(sender As Object, e As EventArgs) Handles btniniciar.Click
        lstcidades.Items.Clear()
        btnacrescenta.Enabled = False
        btniniciar.Enabled = False
        btnlimpar.Enabled = False
        btnremove.Enabled = False
    End Sub
End Class