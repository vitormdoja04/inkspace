Imports MySql.Data.MySqlClient
Public Class Form9
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            SQL = "SELECT * FROM pedidos WHERE cod_pedido = @cod_pedido"
            Dim cmd As New MySqlCommand(SQL, db)

            cmd.Parameters.AddWithValue("@cod_pedido", txt_cod.Text)

            Dim resultado As Object = cmd.ExecuteScalar()


            If resultado = Nothing Then
                MsgBox("Esse pedido não existe!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                txt_cod.Clear()

            Else
                SQL = "delete from pedidos where cod_pedido = @cod_pedido"

                Dim cmd2 As New MySqlCommand(SQL, db)
                cmd2.Parameters.AddWithValue("@cod_pedido", txt_cod.Text)

                cmd2.ExecuteScalar()
                MsgBox("Pedido excluído com sucesso!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                txt_cod.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectar_banco()
    End Sub

    Private Sub pic_voltar_Click(sender As Object, e As EventArgs) Handles pic_voltar.Click
        Me.Hide()
        Form7.Show()
    End Sub
End Class