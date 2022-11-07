Public Class f32ex1
    Private Sub btnconfirma_Click(sender As Object, e As EventArgs) Handles btnconfirma.Click
        If chkboxServ1.Checked Then
            txtservico1.Text = chkboxServ1.Text
        End If
        If chkboxServ2.Checked Then
            txtservico2.Text = chkboxServ2.Text
        End If
        If chkboxServ3.Checked Then
            txtservico3.Text = chkboxServ3.Text
        End If
        If rtbpreto.Checked Then
            txtcor.Text = rtbpreto.Text
        ElseIf rtbvermelho.Checked Then
            txtcor.Text = rtbvermelho.Text
        End If

    End Sub
End Class