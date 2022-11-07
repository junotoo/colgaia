Public Class f33ex2
    Private Sub txtlimite_TextChanged(sender As Object, e As EventArgs) Handles txtlimite.TextChanged
        If IsNumeric(Trim(txtlimite.Text)) Then
            btncalcular.Visible = True
        Else
            btncalcular.Visible = False
        End If
    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        For c As Integer = 1 To Val(txtlimite.Text ^ 2)
            ListBox1.Items.Add(Math.Sqrt(c))
        Next
    End Sub
End Class