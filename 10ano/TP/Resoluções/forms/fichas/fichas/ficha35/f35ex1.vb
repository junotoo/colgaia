Public Class f35ex1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnadicionar.Click
        lblcontador.Text = Val(lblcontador.Text) + 1
        If Val(lblcontador.Text) > 0 Then
            btnremover.Enabled = True
        End If
    End Sub

    Private Sub btnremover_Click(sender As Object, e As EventArgs) Handles btnremover.Click
        lblcontador.Text = Val(lblcontador.Text) + 1
        If Val(lblcontador.Text) = 0 Then
            btnremover.Enabled = False
        End If
    End Sub
End Class