Public Class f33ex4
    Private Sub btngerar_Click(sender As Object, e As EventArgs) Handles btngerar.Click
        Dim r As New List(Of Integer)
        Dim rg As New Random
        Dim rn As Integer

        Do
            rn = rg.Next(1, 50)
            If Not r.Contains(rn) Then
                r.Add(rn)
            End If
        Loop Until r.Count = 4

        TextBox1.Text = r(0).ToString
        TextBox2.Text = r(1).ToString
        TextBox3.Text = r(2).ToString
        TextBox4.Text = r(3).ToString
        TextBox5.Text = r(4).ToString
        TextBox6.Text = CInt(Int((12 * Rnd()) + 1))
        Do
            TextBox7.Text = CInt(Int((12 * Rnd()) + 1))
        Loop Until TextBox7.Text <> TextBox6.Text
    End Sub
End Class