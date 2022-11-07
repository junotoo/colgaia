Public Class f35ex5
    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged

    End Sub

    Private Sub btnresultado_Click(sender As Object, e As EventArgs) Handles btnresultado.Click
        lblresultado.Text = ""
        If CheckBox1.Checked Then
            lblresultado.Text = CheckBox1.Text

        End If

        If CheckBox2.Checked Then
            If lblresultado.Text <> "" Then
                lblresultado.Text &= " + "
            End If
            lblresultado.Text = lblresultado.Text & CheckBox2.Text
        End If
        If CheckBox3.Checked Then
            If lblresultado.Text <> "" Then
                lblresultado.Text &= " + "
            End If
            lblresultado.Text &= CheckBox3.Text
        End If

        If CheckBox4.Checked Then
            If lblresultado.Text <> "" Then
                lblresultado.Text &= " + "
            End If
            lblresultado.Text &= CheckBox4.Text
        End If
    End Sub

    Private Sub f35ex5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class