Public Class f35ex3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnremover.Click
        lstdisciplinas.Items.Remove(lstdisciplinas.SelectedItems)
    End Sub

    Private Sub btnacrescentar_Click(sender As Object, e As EventArgs) Handles btnacrescentar.Click
        lstdisciplinas.Items.Add(TextBox1.Text)
    End Sub
    Private Sub btnjuntar_Click(sender As Object, e As EventArgs) Handles btnjuntar.Click
        Label3.Text = "Selecoes: "
    End Sub
End Class