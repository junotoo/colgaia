Public Class f33ex5
    Function maioralgarismo(num As Char()) As Char
        Dim max As Integer = -1
        For c As Integer = 0 To num.Length - 1
            If Asc(num(c)) > max Then
                max = Asc(num(c))
            End If
        Next
        Return (Chr(max))
    End Function
    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        txtmax.Text = maioralgarismo(txtnumero.Text.ToCharArray)
    End Sub
    Private Sub txtnumero_TextChanged(sender As Object, e As EventArgs) Handles txtnumero.TextChanged
        If IsNumeric(Trim(txtnumero.Text)) Then
            btncalcular.Enabled = True
        End If
    End Sub
End Class