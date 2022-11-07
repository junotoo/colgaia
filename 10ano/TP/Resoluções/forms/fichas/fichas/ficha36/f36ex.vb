Public Class f36ex
    Dim array As String(,)
    Private Sub btnaddaluno_Click(sender As Object, e As EventArgs) Handles btnaddaluno.Click
        If Trim(txtnome.Text) <> "" And cbxdisciplinas.SelectedIndex <> -1 Then
            lstAlunos.Items.Add(txtnome.Text)
            txttotal.Text = lstAlunos.Items.Count.ToString
            ReDim Preserve array(8, lstAlunos.Items.Count - 1)
            array(0, lstAlunos.Items.Count - 1) = cbxdisciplinas.SelectedItem
        End If
    End Sub
    Private Sub btnremaluno_Click(sender As Object, e As EventArgs) Handles btnremaluno.Click
        For c As Integer = 0 To 7
            array(c, lstAlunos.SelectedIndex) = Nothing
        Next
        lstDisciplinas.Items.Clear()
        lstAlunos.Items.Remove(lstAlunos.SelectedItem)
        txttotal.Text = lstAlunos.Items.Count
    End Sub
    Private Sub lstAlunos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAlunos.SelectedIndexChanged
        lstDisciplinas.Items.Clear()
        For c As Integer = 0 To 7
            If lstAlunos.SelectedIndex <> -1 Then
                If array(c, lstAlunos.SelectedIndex) <> Nothing Then
                    lstDisciplinas.Items.Add(array(c, lstAlunos.SelectedIndex))
                End If
            End If
        Next
    End Sub
    Private Sub btnadddisc_Click(sender As Object, e As EventArgs) Handles btnadddisc.Click
        If cbxdisciplinas.SelectedIndex <> -1 And Not lstDisciplinas.Items.Contains(cbxdisciplinas.SelectedItem) Then
            array(lstDisciplinas.Items.Count, lstAlunos.SelectedIndex) = cbxdisciplinas.SelectedItem
            lstDisciplinas.Items.Add(cbxdisciplinas.SelectedItem)
        End If
    End Sub
    Private Sub btnremdisc_Click(sender As Object, e As EventArgs) Handles btnremdisc.Click
        If cbxdisciplinas.SelectedIndex <> -1 Then
            Dim index As Integer = lstAlunos.SelectedIndex
            array(lstDisciplinas.Items.Count, index) = Nothing
            lstDisciplinas.Items.RemoveAt(index)
        End If
    End Sub
    Private Sub f36ex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txttotal.Text = lstAlunos.Items.Count
    End Sub
End Class