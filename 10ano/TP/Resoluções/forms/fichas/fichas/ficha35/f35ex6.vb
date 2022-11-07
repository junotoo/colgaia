Imports System.Linq
Public Class f35ex6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(GroupBox1.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True).Text)
    End Sub
End Class