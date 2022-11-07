Public Class Form1
    Dim lastPoint As Point
    Private Sub btnmin_Click(sender As Object, e As EventArgs) Handles btnmin.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnfechar_Click(sender As Object, e As EventArgs) Handles btnfechar.Click
        Application.Exit()
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        lastpoint = New Point(e.X, e.Y)
    End Sub
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = MouseButtons.Left Then
            Me.Left += e.X - lastpoint.X
            Me.Top += e.Y - lastpoint.Y
        End If
    End Sub

    Private Sub Label2_MouseDown(sender As Object, e As MouseEventArgs) Handles Label2.MouseDown
        lastPoint = New Point(e.X, e.Y)
    End Sub

    Private Sub Label2_MouseMove(sender As Object, e As MouseEventArgs) Handles Label2.MouseMove
        If e.Button = MouseButtons.Left Then
            Me.Left += e.X - lastPoint.X
            Me.Top += e.Y - lastPoint.Y
        End If
    End Sub

    Private Sub btnficha32_Click(sender As Object, e As EventArgs) Handles btnficha32.Click
        Ficha321.BringToFront()
        Ficha321.Show()

    End Sub

    Private Sub btnficha31_Click(sender As Object, e As EventArgs) Handles btnficha31.Click
        Ficha311.BringToFront()
        Ficha311.Show()
    End Sub

    Private Sub btnficha33_Click(sender As Object, e As EventArgs) Handles btnficha33.Click
        Ficha331.BringToFront()
        Ficha331.Show()
    End Sub

    Private Sub btnficha34_Click(sender As Object, e As EventArgs) Handles btnficha34.Click
        Ficha341.BringToFront()
        Ficha341.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.RockNRoll2,
            AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub btnficha35_Click(sender As Object, e As EventArgs) Handles btnficha35.Click
        Ficha351.BringToFront()
        Ficha351.Show()
    End Sub

    Private Sub btnficha30_Click(sender As Object, e As EventArgs) Handles btnficha30.Click
        Creditos1.BringToFront()
    End Sub

    Private Sub btnficha36_Click(sender As Object, e As EventArgs) Handles btnficha36.Click
        Ficha361.BringToFront()
        Ficha361.Show()
    End Sub

    Private Sub btnficha37_Click(sender As Object, e As EventArgs) Handles btnficha37.Click
        Ficha371.BringToFront()
        Ficha371.Show()
    End Sub

    Private Sub btnficha38_Click(sender As Object, e As EventArgs) Handles btnficha38.Click
        Ficha381.BringToFront()
        Ficha381.Show()
    End Sub

    Private Sub btnfinal_Click(sender As Object, e As EventArgs) Handles btnfinal.Click
        Final1.BringToFront()
        Final1.Show()
    End Sub
End Class
