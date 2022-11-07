Public Class formsec
    Private Sub btnconfirma_Click(sender As Object, e As EventArgs) Handles btnconfirma.Click
        Dim index As Integer = f37ex.lstnome.SelectedIndex
        If Label4.Text = "Atualizar" Then
            f37ex.lstnome.Items.RemoveAt(index)
            f37ex.lstnome.Items.Insert(index, TextBox1.Text)
            f37ex.lstnum.Items.RemoveAt(index)
            f37ex.lstnum.Items.Insert(index, TextBox1.Text)
            f37ex.lstturma.Items.RemoveAt(index)
            f37ex.lstturma.Items.Insert(index, TextBox1.Text)
        End If
        If Label4.Text = "Adicionar" Then
            f37ex.lstnome.Items.Add(TextBox1.Text)
            f37ex.lstturma.Items.Add(TextBox2.Text)
            f37ex.lstnum.Items.Add(TextBox3.Text)
        End If
        If Label4.Text = "Remover" Then
            f37ex.lstnome.Items.RemoveAt(index)
            f37ex.lstturma.Items.RemoveAt(index)
            f37ex.lstnum.Items.RemoveAt(index)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class