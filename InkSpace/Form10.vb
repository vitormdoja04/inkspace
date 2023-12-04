Imports MySql.Data.MySqlClient
Public Class Form10
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            SQL = "SELECT * FROM adm WHERE cod_adm = @cod_adm"
            Dim cmd As New MySqlCommand(SQL, db)

            cmd.Parameters.AddWithValue("@cod_adm", txt_cod.Text)

            Dim resultado As Object = cmd.ExecuteScalar()


            If resultado = Nothing Then
                MsgBox("Essa conta não existe!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                txt_cod.Clear()

            ElseIf resultado = 1 Then
                MsgBox("Essa conta não pode ser excluída!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                txt_cod.Clear()
            Else
                SQL = "delete from adm where cod_adm = @cod_adm"

                Dim cmd2 As New MySqlCommand(SQL, db)
                cmd2.Parameters.AddWithValue("@cod_adm", txt_cod.Text)

                cmd2.ExecuteScalar()
                MsgBox("Pedido excluído com sucesso!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                txt_cod.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectar_banco()
    End Sub

    Private Sub pic_voltar_Click(sender As Object, e As EventArgs) Handles pic_voltar.Click
        Me.Hide()
        Form6.Show()
    End Sub
End Class