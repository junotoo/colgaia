Public Class f33ex1
    Private Sub txtlimite_TextChanged(sender As Object, e As EventArgs) Handles txtlimite.TextChanged
        If IsNumeric(Trim(txtlimite.Text)) And (rdbpares.Checked Or rdbsequencial.Checked) Then
            btnlistar.Visible = True
        Else
            btnlistar.Visible = False
        End If
    End Sub

    Private Sub rdbsequencial_CheckedChanged(sender As Object, e As EventArgs) Handles rdbsequencial.CheckedChanged
        If IsNumeric(Trim(txtlimite.Text)) And (rdbpares.Checked Or rdbsequencial.Checked) Then
            btnlistar.Visible = True
        Else
            btnlistar.Visible = False
        End If
    End Sub

    Private Sub rdbpares_CheckedChanged(sender As Object, e As EventArgs) Handles rdbpares.CheckedChanged
        If IsNumeric(Trim(txtlimite.Text)) And (rdbpares.Checked Or rdbsequencial.Checked) Then
            btnlistar.Visible = True
        Else
            btnlistar.Visible = False
        End If
    End Sub

    Private Sub btnlistar_Click(sender As Object, e As EventArgs) Handles btnlistar.Click
        If rdbsequencial.Checked Then
            For c As Integer = 0 To Val(txtlimite.Text)
                lstNumero.Items.Add(c)
            Next
        Else
            For c As Integer = 0 To Val(txtlimite.Text) Step 2
                lstNumero.Items.Add(c)
            Next
        End If

    End Sub
End Class