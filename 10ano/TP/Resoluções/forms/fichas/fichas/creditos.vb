Public Class creditos
    Private Sub btntwitch_Click(sender As Object, e As EventArgs) Handles btntwitch.Click
        Dim url As String = "https://www.twitch.tv/junogrosso"
        System.Diagnostics.Process.Start(url)
    End Sub

    Private Sub btndiscord_Click(sender As Object, e As EventArgs) Handles btndiscord.Click
        Process.Start("https://discord.gg/PDMKaubU9Y")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btngithub.Click
        Process.Start("https://github.com/junotoo/")
    End Sub

    Private Sub btnyoutube_Click(sender As Object, e As EventArgs) Handles btnyoutube.Click
        Process.Start("https://www.youtube.com/channel/UCqK08_f7qp9xcaVyLleOvgg")
    End Sub
End Class
