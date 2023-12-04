Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing
Public Class frm_pedidos

    Dim mysqlred As MySqlDataReader

    Private Sub pic_voltar_Click(sender As Object, e As EventArgs) Handles pic_voltar.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub lbl_voltar_Click(sender As Object, e As EventArgs) Handles lbl_voltar.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub pic_limpar_Click(sender As Object, e As EventArgs) Handles pic_limpar.Click
        txt_nome.Clear()
        txt_cpf.Clear()
        txt_telefone.Clear()
        date_data.ResetText()
        txt_desc.Clear()
        cmb_hora.ResetText()
        cmb_tipo.ResetText()
        txt_disponivel.Clear()
        txt_preco.Clear()
        PictureBox2.Image = Nothing
    End Sub

    Private Sub lbl_limpar_Click(sender As Object, e As EventArgs) Handles lbl_limpar.Click
        txt_nome.Clear()
        txt_cpf.Clear()
        txt_telefone.Clear()
        date_data.ResetText()
        txt_desc.Clear()
        cmb_hora.ResetText()
        cmb_tipo.ResetText()
        txt_disponivel.Clear()
        txt_preco.Clear()
        PictureBox2.Image = Nothing
    End Sub

    Private Sub frm_pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectar_banco()
    End Sub

    Private Sub pic_confirmar_Click(sender As Object, e As EventArgs) Handles pic_confirmar.Click
        Try
            SQL = "SELECT * FROM pedidos WHERE data_pedido = @date_data and horario_pedido = @cmb_hora"

            Dim cmd As New MySqlCommand(SQL, db)
            Dim filesize As UInt32
            Dim mstream As New System.IO.MemoryStream

            cmd.Parameters.AddWithValue("@date_data", date_data.Text)
            cmd.Parameters.AddWithValue("@cmb_hora", cmb_hora.SelectedItem)

            Dim resultado As Object = cmd.ExecuteScalar()



            If resultado = Nothing Then
                If txt_nome.Text = Nothing Or txt_cpf.Text = Nothing Or txt_telefone.Text = Nothing Or cmb_tipo.Text = Nothing Or PictureBox2.Image Is Nothing Then
                    MsgBox("É preciso preencher todos os campos obrigatórios!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                Else

                    PictureBox2.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim arrimage() As Byte = mstream.GetBuffer
                    filesize = mstream.Length
                    mstream.Close()

                    Dim ms As New MemoryStream


                    SQL = "INSERT INTO pedidos (nome_pedido, cpf_pedido, telefone_pedido, data_pedido, horario_pedido, disponibilidade_pedido, tipo_pedido, preco_pedido, imagem_ref_pedido, desc_pedido) VALUES (@txt_nome, @txt_cpf, @txt_telefone, @date_data, @cmb_hora, @txt_disponivel, @cmb_tipo, @txt_preco, @img_ref, @txt_desc)"

                    Dim cmd2 As New MySqlCommand(SQL, db)
                    cmd2.Parameters.AddWithValue("@txt_nome", txt_nome.Text)
                    cmd2.Parameters.AddWithValue("@txt_cpf", txt_cpf.Text)
                    cmd2.Parameters.AddWithValue("@txt_telefone", txt_telefone.Text)
                    cmd2.Parameters.AddWithValue("@date_data", date_data.Text)
                    cmd2.Parameters.AddWithValue("@cmb_hora", cmb_hora.SelectedItem)
                    cmd2.Parameters.AddWithValue("@txt_disponivel", "Não")
                    cmd2.Parameters.AddWithValue("@cmb_tipo", cmb_tipo.SelectedItem)
                    cmd2.Parameters.AddWithValue("@txt_preco", txt_preco.Text)
                    cmd2.Parameters.AddWithValue("@img_ref", arrimage)
                    cmd2.Parameters.AddWithValue("@txt_desc", txt_desc.Text)

                    cmd2.ExecuteScalar()
                    MsgBox("Sessão agendada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                    txt_nome.Clear()
                    txt_cpf.Clear()
                    txt_telefone.Clear()
                    date_data.ResetText()
                    txt_desc.Clear()
                    cmb_hora.ResetText()
                    cmb_tipo.ResetText()
                    txt_disponivel.Clear()
                    txt_preco.Clear()
                    PictureBox2.Image = Nothing
                End If
            Else
                MsgBox("Esse horário já está ocupado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lbl_confirmar_Click(sender As Object, e As EventArgs) Handles lbl_confirmar.Click
        Try
            SQL = "SELECT * FROM pedidos WHERE data_pedido = @date_data and horario_pedido = @cmb_hora"
            Dim cmd As New MySqlCommand(SQL, db)

            cmd.Parameters.AddWithValue("@date_data", date_data.Text)
            cmd.Parameters.AddWithValue("@cmb_hora", cmb_hora.SelectedItem)

            Dim resultado As Object = cmd.ExecuteScalar()

            If resultado = Nothing Then
                SQL = "INSERT INTO pedidos (nome_pedido, cpf_pedido, telefone_pedido, data_pedido, horario_pedido, disponibilidade_pedido, tipo_pedido, preco_pedido, imagem_ref_pedido, desc_pedido) VALUES (@txt_nome, @txt_cpf, @txt_telefone, @date_data, @cmb_hora, @txt_disponivel, @cmb_tipo, @txt_preco, @img, @txt_desc)"

                Dim cmd2 As New MySqlCommand(SQL, db)
                cmd2.Parameters.AddWithValue("@txt_nome", txt_nome.Text)
                cmd2.Parameters.AddWithValue("@txt_cpf", txt_cpf.Text)
                cmd2.Parameters.AddWithValue("@txt_telefone", txt_telefone.Text)
                cmd2.Parameters.AddWithValue("@date_data", date_data.Text)
                cmd2.Parameters.AddWithValue("@cmb_hora", cmb_hora.SelectedItem)
                cmd2.Parameters.AddWithValue("@txt_disponivel", "Não")
                cmd2.Parameters.AddWithValue("@cmb_tipo", cmb_tipo.SelectedItem)
                cmd2.Parameters.AddWithValue("@txt_preco", txt_preco.Text)
                cmd2.Parameters.AddWithValue("@img", PictureBox2.Image)
                cmd2.Parameters.AddWithValue("@txt_desc", txt_desc.Text)

                cmd2.ExecuteScalar()
                MsgBox("Sessão agendada com sucesso!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
            Else
                MsgBox("Esse horário já está ocupado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmb_hora_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_hora.SelectedIndexChanged
        Try
            SQL = "select * from pedidos where data_pedido = @txt_data and horario_pedido = @txt_hora"
            Dim cmd As New MySqlCommand(SQL, db)

            cmd.Parameters.AddWithValue("@txt_data", date_data.Text)
            cmd.Parameters.AddWithValue("@txt_hora", cmb_hora.Text)

            Dim resultado As Object = cmd.ExecuteScalar()

            If resultado = Nothing Then
                txt_disponivel.Text = "Sim"
            Else
                txt_disponivel.Text = "Não"
            End If
        Catch ex As Exception
            MsgBox("Erro de disponibilidade", MsgBoxStyle.Critical, "Atenção")
        End Try
    End Sub

    Private Sub cmb_tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipo.SelectedIndexChanged
        If cmb_tipo.Text = "Preto e Branco" Then
            txt_preco.Text = "R$60,00 - R$200,00"
        ElseIf cmb_tipo.Text = "Colorido" Then
            txt_preco.Text = "R$100,00 - R$500,00"
        End If
    End Sub

    Private Sub btn_img_Click(sender As Object, e As EventArgs) Handles btn_img.Click
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            PictureBox2.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
End Class

