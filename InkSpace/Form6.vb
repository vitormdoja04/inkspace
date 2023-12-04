Imports MySql.Data.MySqlClient

Public Class Form6

    Private ReadOnly servidor = "localhost"
    Private ReadOnly banco = "inkspace"
    Private ReadOnly usuario = "root"
    Private ReadOnly senhaa = ""
    Public ReadOnly strCon = $"server={servidor};User Id ={usuario};database={banco};password={senhaa}"
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectar_banco()
        dgv_adm.DataSource = getAdm()
        Call configurar_dgv_adm()
    End Sub
    Private Sub configurar_dgv_adm()
        With dgv_adm
            .DefaultCellStyle.Font = New Font("Arial", 9)
            .DefaultCellStyle.ForeColor = Color.Black
            .RowHeadersWidth = 15
        End With
    End Sub

    Private Function getAdm() As DataTable
        SQL = "SELECT * FROM adm ORDER BY login_adm ASC"
        Dim dt As New DataTable

        Try
            Using cn = New MySqlConnection(strCon)
                cn.Open()
                Using da = New MySqlDataAdapter(SQL, cn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Erro: " + ex.Message)
            dt = Nothing
        End Try

        Return dt

    End Function

    Private Sub pic_add_adm_Click(sender As Object, e As EventArgs) Handles pic_add_adm.Click
        Me.Hide()
        Form8.Show()
        dgv_adm.DataSource = getAdm()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
        Form8.Show()
        dgv_adm.DataSource = getAdm()
    End Sub

    Private Sub pic_voltar_Click(sender As Object, e As EventArgs) Handles pic_voltar.Click
        Me.Hide()
        frm_menu_adm.Show()
        dgv_adm.DataSource = getAdm()
    End Sub

    Private Sub lbl_voltar_Click(sender As Object, e As EventArgs) Handles lbl_voltar.Click
        Me.Hide()
        frm_menu_adm.Show()
        dgv_adm.DataSource = getAdm()
    End Sub

    Private Sub btn_busca_Click(sender As Object, e As EventArgs) Handles btn_busca.Click
        If txt_login.Text = Nothing Then
            dgv_adm.DataSource = getAdm()
        Else
            dgv_adm.DataSource = getAdmbyLogin()
        End If
    End Sub

    Private Function getAdmbyLogin() As DataTable
        SQL = "SELECT * FROM adm where login_adm = '" & txt_login.Text & "'"
        Dim dt As New DataTable

        Try
            Using cn = New MySqlConnection(strCon)
                cn.Open()
                Using da = New MySqlDataAdapter(SQL, cn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Erro: " + ex.Message)
            dt = Nothing
        End Try


        Return dt
    End Function

    Private Sub pic_limpar_Click(sender As Object, e As EventArgs) Handles pic_limpar.Click
        configurar_dgv_adm()
        getAdm()
        Me.Hide()
        Form10.Show()
    End Sub
End Class