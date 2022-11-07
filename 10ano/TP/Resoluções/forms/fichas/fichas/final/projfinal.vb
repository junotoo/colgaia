Public Class projfinal
    Dim lastpoint As Point
    Structure dados
        Dim nome As String
        Dim escalao As String
        Dim data As Date
        Dim caracteristicas As String
        Dim imagem As Image
    End Structure
    Dim jogadores As dados()
    Dim pos As Integer = 0
    Dim pos2 As Integer
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        lastpoint = New Point(e.X, e.Y)
    End Sub
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = MouseButtons.Left Then
            Me.Left += e.X - lastpoint.X
            Me.Top += e.Y - lastpoint.Y
        End If
    End Sub
    Private Sub btnmin_Click(sender As Object, e As EventArgs) Handles btnmin.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnfechar_Click(sender As Object, e As EventArgs) Handles btnfechar.Click
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If btnadd.Text = "Adicionar" Then
            cbxano.SelectedIndex = -1
            cbxano.Enabled = True
            txtcaracteristicas.Clear()
            txtcaracteristicas.Enabled = True
            txtdia.Clear()
            txtdia.Enabled = True
            txtmes.Clear()
            txtmes.Enabled = True
            txtnome.Clear()
            txtnome.Enabled = True
            PictureBox1.Image = Nothing
            cbxescalao.Enabled = True
            cbxescalao.SelectedIndex = -1
            btnadd.Text = "Guardar"
        Else
            If IsDate(txtdia.Text + "/" + txtmes.Text + "/" + cbxano.selecteditem) Then
                lblerrodata.Visible = False
                If Trim(txtnome.Text) <> "" And Trim(txtdia.Text) <> "" And Trim(txtmes.Text) <> "" And cbxano.selecteditem <> "" And Trim(txtcaracteristicas.Text) <> "" And cbxescalao.SelectedIndex <> -1 And PictureBox1.Image IsNot Nothing Then
                    ReDim Preserve jogadores(pos + 1)
                    jogadores(pos).nome = txtnome.Text
                    jogadores(pos).escalao = cbxescalao.Text
                    jogadores(pos).imagem = PictureBox1.Image.Clone
                    jogadores(pos).caracteristicas = txtcaracteristicas.Text
                    jogadores(pos).data = txtdia.Text + "/" + txtmes.Text + "/" + cbxano.selecteditem
                    btnadd.Text = "Adicionar"
                    pos += 1
                    pos2 = pos
                    Label7.Text = "Posição: " + (pos + 1).ToString
                Else
                    MessageBox.Show("Preencha todos os campos antes de guardar o jogador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                lblerrodata.Visible = True
            End If
        End If
    End Sub
    Private Sub btnfoto_Click(sender As Object, e As EventArgs) Handles btnfoto.Click
        Dim foto As OpenFileDialog = New OpenFileDialog()
        foto.Title = "Selecione uma imagem"
        foto.InitialDirectory = "/fotos"
        foto.Filter = "Imagens (*.jfif; *.jpg; *.jpeg; *.gif; *.bmp)|*.jfif; *.jpg; *.jpeg; *.gif; *.bmp|All files (*.*)|*.*"
        foto.FilterIndex = 2
        foto.RestoreDirectory = True
        If foto.ShowDialog() = DialogResult.OK Then
            PictureBox1.ImageLocation = foto.FileName
        End If
    End Sub
    Private Sub btnprimeiro_Click(sender As Object, e As EventArgs) Handles btnprimeiro.Click
        If pos > 0 Then
            pos2 = 0
            mostrarposição(pos2)
        Else
            MessageBox.Show("Não tem nenhuma posição criada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub btnproximo_Click(sender As Object, e As EventArgs) Handles btnproximo.Click
        If pos2 < pos - 1 Then
            pos2 += 1
            mostrarposição(pos2)
        Else
            MessageBox.Show("Já está na ultima posição!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub btnultimo_Click(sender As Object, e As EventArgs) Handles btnultimo.Click
        If pos > 0 Then
            pos2 = pos - 1
            mostrarposição(pos2)
        Else
            MessageBox.Show("Não tem nenhuma posição criada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Sub mostrarposição(pos2 As Integer)
        btnadd.Enabled = True
        btnfoto.Enabled = False
        cbxano.Enabled = False
        txtcaracteristicas.Enabled = False
        txtdia.Enabled = False
        txtmes.Enabled = False
        txtnome.Enabled = False
        cbxescalao.Enabled = False
        txtnome.Text = jogadores(pos2).nome
        txtdia.Text = jogadores(pos2).data.Day
        txtmes.Text = jogadores(pos2).data.Month
        cbxano.Text = jogadores(pos2).data.Year
        txtcaracteristicas.Text = jogadores(pos2).data.Year
        cbxescalao.SelectedItem = jogadores(pos2).escalao
        PictureBox1.Image = jogadores(pos2).imagem
        PictureBox1.Refresh()
        Label7.Text = "Posição: " + (pos2 + 1).ToString
        btnadd.Text = "Adicionar"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnpesquisa.Click
        If btnpesquisa.Text = "Pesquisar dados" Then
            btnpesquisa.Text = "Voltar"
            Pesquisa2.BringToFront()
            Pesquisa2.Visible = True
            Pesquisa2.lsvencontrados.Items.Clear()
            btnadd.Enabled = False
            btnanterior.Enabled = False
            btnfoto.Enabled = False
            btnprimeiro.Enabled = False
            btnultimo.Enabled = False
            btnproximo.Enabled = False
            Pesquisa2.Label6.Visible = False
            For c As Integer = 0 To pos - 1
                Pesquisa2.lsvencontrados.Items.Add(New ListViewItem({jogadores(c).nome, jogadores(c).escalao, jogadores(c).data.Day, jogadores(c).data.Month, jogadores(c).data.Year, c + 1}))
            Next
        Else
            btnpesquisa.Text = "Pesquisar dados"
            Pesquisa2.SendToBack()
            Pesquisa2.Visible = False
            btnadd.Enabled = True
            btnanterior.Enabled = True
            btnfoto.Enabled = True
            btnprimeiro.Enabled = True
            btnultimo.Enabled = True
            btnproximo.Enabled = True
        End If
    End Sub
    Private Sub btnanterior_Click(sender As Object, e As EventArgs) Handles btnanterior.Click
        If pos2 > 0 Then
            pos2 -= 1
            mostrarposição(pos2)
        Else
            MessageBox.Show("Já está na primeira posição!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub cbxescalao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxescalao.SelectedIndexChanged
        Select Case cbxescalao.SelectedItem
            Case "sub11"
                TrocarAnos({"2011", "2012", "2013", "2014"})
            Case "sub12"
                TrocarAnos({"2010", "2011", "2012", "2013"})
            Case "sub13"
                TrocarAnos({"2009", "2010", "2011", "2012"})
            Case "sub15"
                TrocarAnos({"2007", "2008", "2009", "2010"})
        End Select
    End Sub
    Sub TrocarAnos(anos() As String)
        cbxano.Items.Clear()
        cbxano.Items.Add(anos(0))
        cbxano.Items.Add(anos(1))
        cbxano.Items.Add(anos(2))
        cbxano.Items.Add(anos(3))
    End Sub
End Class