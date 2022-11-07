Public Class pesquisa
    Private Sub btnpesquisa_Click(sender As Object, e As EventArgs) Handles btnpesquisa.Click
        filtro(txtnome.Text, 0)
        filtro(cbxescalao.Text, 1)
        filtro(txtdia.Text, 2)
        filtro(txtmes.Text, 3)
        filtro(txtano.Text, 4)
    End Sub
    Sub filtro(txt As String, index As Integer)
        Dim c As Integer = 0
        Dim items As Integer = lsvencontrados.Items.Count
        If Trim(txt) <> "" Then
            While c <= items - 1
                If lsvencontrados.Items(c).SubItems(index).Text.IndexOf(txt) = -1 Then
                    lsvencontrados.Items.RemoveAt(c)
                    items = lsvencontrados.Items.Count
                End If
                c += 1
            End While
            c = 0
        End If
    End Sub

    Private Sub lsvencontrados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvencontrados.SelectedIndexChanged
        If Val(lsvencontrados.SelectedItems(0).SubItems(5).Text) > 0 Then
            projfinal.mostrarposição(Val(lsvencontrados.SelectedItems(0).SubItems(5).Text) - 1)
            Label6.Visible = True
        End If
    End Sub
End Class
