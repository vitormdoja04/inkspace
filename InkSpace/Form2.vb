Imports MySql.Data.MySqlClient
Public Class frm_adm
    Private Sub img_sair_Click(sender As Object, e As EventArgs) Handles img_sair.Click
        Try
            Me.Hide()
            Form1.Show()
        Catch ex As Exception
            MsgBox("Erro ao continuar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção!")
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Try
            SQL = "SELECT * FROM adm WHERE login_adm = @txt_login and senha_adm = @txt_senha"
            Dim cmd As New MySqlCommand(SQL, db)

            cmd.Parameters.AddWithValue("@txt_login", txt_user.Text)
            cmd.Parameters.AddWithValue("@txt_senha", txt_senha.Text)

            Dim resultado As Object = cmd.ExecuteScalar()

            If resultado = Nothing Then
                MsgBox("Usuário Inválido!", MsgBoxStyle.Information, "Atenção")
            Else
                MsgBox("Acesso Concedido!", MsgBoxStyle.Information, "Atenção")
                Me.Hide()
                frm_menu_adm.Show()
            End If
        Catch ex As Exception
            MsgBox("Falha ao realizar cadastro.", MsgBoxStyle.Critical, "Atenção")
        End Try
    End Sub

    Private Sub img_login_Click(sender As Object, e As EventArgs) Handles img_login.Click
        Try
            SQL = "SELECT * FROM adm WHERE login_adm = @txt_login and senha_adm = @txt_senha"
            Dim cmd As New MySqlCommand(SQL, db)

            cmd.Parameters.AddWithValue("@txt_login", txt_user.Text)
            cmd.Parameters.AddWithValue("@txt_senha", txt_senha.Text)

            Dim resultado As Object = cmd.ExecuteScalar()

            If resultado = Nothing Then
                MsgBox("Usuário Inválido!", MsgBoxStyle.Information, "Atenção")
            Else
                MsgBox("Acesso Concedido!", MsgBoxStyle.Information, "Atenção")
                txt_senha.Clear()
                txt_user.Clear()
                Me.Hide()
                frm_menu_adm.Show()
            End If
        Catch ex As Exception
            MsgBox("Falha ao realizar cadastro.", MsgBoxStyle.Critical, "Atenção")
        End Try
    End Sub

    Private Sub frm_adm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectar_banco()
    End Sub
End Class