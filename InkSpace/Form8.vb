Imports MySql.Data.MySqlClient
Public Class Form8
    Private Sub pic_salvar_Click(sender As Object, e As EventArgs) Handles pic_salvar.Click
        Try
            SQL = "SELECT * FROM adm WHERE login_adm = @login_adm"
            Dim cmd As New MySqlCommand(SQL, db)

            cmd.Parameters.AddWithValue("@login_adm", txt_login.Text)

            Dim resultado As Object = cmd.ExecuteScalar()

            If resultado Is Nothing Then

                SQL = "INSERT into adm (login_adm, senha_adm) values (@login_adm, @txt_senha)"

                Dim cmd2 As New MySqlCommand(SQL, db)
                cmd2.Parameters.AddWithValue("@login_adm", txt_login.Text)
                cmd2.Parameters.AddWithValue("@txt_senha", txt_senha.Text)

                cmd2.ExecuteScalar()
                MsgBox("Cadastro realizado com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                txt_login.Clear()
                txt_senha.Clear()

            Else
                SQL = "update adm set senha_adm = @txt_senha where login_adm = @txt_login"

                Dim cmd2 As New MySqlCommand(SQL, db)
                cmd2.Parameters.AddWithValue("@txt_login", txt_login.Text)
                cmd2.Parameters.AddWithValue("@txt_senha", txt_senha.Text)

                cmd2.ExecuteScalar()
                MsgBox("Cadastro atualizado com sucesso", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                txt_login.Clear()
                txt_senha.Clear()

            End If

        Catch ex As Exception
            MsgBox("Falha ao realizar cadastro.", MsgBoxStyle.Critical, "Atenção")
        End Try
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectar_banco()
    End Sub

    Private Sub pic_voltar_Click(sender As Object, e As EventArgs) Handles pic_voltar.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        Form6.Show()
    End Sub
End Class