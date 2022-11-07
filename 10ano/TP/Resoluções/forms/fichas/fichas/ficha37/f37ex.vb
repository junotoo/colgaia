Public Class f37ex
    Private Sub btnadicionar_Click(sender As Object, e As EventArgs) Handles btnadicionar.Click
        formsec.Show()
        formsec.Label4.Text = "Adicionar"
    End Sub

    Private Sub btnatualizar_Click(sender As Object, e As EventArgs) Handles btnatualizar.Click
        If lstnome.SelectedIndex <> -1 Then
            formsec.Show()
            formsec.Label4.Text = "Atualizar"
            formsec.TextBox1.Text = lstnome.SelectedItem
            formsec.TextBox2.Text = lstturma.Items(lstnome.SelectedIndex).ToString
            formsec.TextBox3.Text = lstnum.Items(lstnome.SelectedIndex).ToString
        End If
    End Sub

    Private Sub btnremover_Click(sender As Object, e As EventArgs) Handles btnremover.Click
        If lstnome.SelectedIndex <> -1 Then
            formsec.Show()
            formsec.Label4.Text = "Remover"
            formsec.TextBox1.Text = lstnome.SelectedItem
            formsec.TextBox2.Text = lstturma.Items(lstnome.SelectedIndex).ToString
            formsec.TextBox3.Text = lstnum.Items(lstnome.SelectedIndex).ToString
            formsec.TextBox1.ReadOnly = True
            formsec.TextBox2.ReadOnly = True
            formsec.TextBox3.ReadOnly = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        formsec.Close()
        Me.Close()
    End Sub
End Class