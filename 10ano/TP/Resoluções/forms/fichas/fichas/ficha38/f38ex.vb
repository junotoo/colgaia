Public Class f38ex
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnadicionar.Click
        Dim flag As Boolean = False
        Dim c As Integer = 0
        If lsvdados.Items.Count > 0 Then
            For i As Integer = 0 To lsvdados.Items.Count - 1
                If lsvdados.Items(i).SubItems(0).Text = txtcliente.Text Then
                    flag = True
                End If
            Next
        End If
        If flag = False Then
            lsvdados.Items.Add(New ListViewItem({txtcliente.Text, txtnome.Text, txtmorada.Text, txttlm.Text, txttlm.Text}))
        End If
    End Sub
    Private Sub btnremover_Click(sender As Object, e As EventArgs) Handles btnremover.Click
        For Each i As ListViewItem In lsvdados.SelectedItems
            lsvdados.Items.Remove(i)
        Next
    End Sub
    Private Sub btnselect_Click(sender As Object, e As EventArgs) Handles btnselect.Click
        txtcliente.Text = lsvdados.SelectedItems(0).SubItems(0).Text
        txtnome.Text = lsvdados.SelectedItems(0).SubItems(1).Text
        txtmorada.Text = lsvdados.SelectedItems(0).SubItems(2).Text
        txttlm.Text = lsvdados.SelectedItems(0).SubItems(3).Text
    End Sub
    Private Sub btnselectgrupo_Click(sender As Object, e As EventArgs) Handles btnselectgrupo.Click
        Dim aux As String = ""
        If lsvdados.SelectedItems.ToString <> "" Then
            For Each i As Integer In lsvdados.SelectedIndices
                aux += lsvdados.Items(i).SubItems(1).Text
                aux += ", "
            Next
            MessageBox.Show(aux)
        End If
    End Sub
    Private Sub lsvdados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvdados.SelectedIndexChanged
        btnselect.Enabled = True
        btnselectgrupo.Enabled = True
    End Sub
End Class