Imports MySql.Data.MySqlClient

Module Module1
    Public db As MySqlConnection
    Public diretorio, SQL As String
    Public cont As Integer
    Public resp As String
    Public aux_login As String
    Public aux_nome As String

    Sub conectar_banco()
        Try
            db = New MySqlConnection
            db.ConnectionString = "server=localhost;userid=root;password='';database=inkspace"
            db.Open()
        Catch ex As Exception
            MsgBox("Erro de Conexão", MsgBoxStyle.Information + vbOKOnly, "ATENÇÃO")
        End Try
    End Sub

End Module
