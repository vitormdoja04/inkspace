Imports MySql.Data.MySqlClient

Public Class Form7

    Private ReadOnly servidor = "localhost"
    Private ReadOnly banco = "inkspace"
    Private ReadOnly usuario = "root"
    Private ReadOnly senhaa = ""
    Public ReadOnly strCon = $"server={servidor};User Id ={usuario};database={banco};password={senhaa}"
    Dim cm As New MySqlCommand
    Dim dr As MySqlDataReader

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectar_banco()
        getPedidos()
        configurar_dgv_pedidos()
    End Sub

    Private Sub configurar_dgv_pedidos()
        With dgv_pedidos
            .DefaultCellStyle.Font = New Font("Arial", 9)
            .DefaultCellStyle.ForeColor = Color.Black
            .RowHeadersWidth = 25
        End With
    End Sub

    Sub getPedidos()
        dgv_pedidos.Rows.Clear()
        cm = New MySqlCommand("SELECT * FROM pedidos ORDER BY nome_pedido ASC", db)
        dr = cm.ExecuteReader
        While dr.Read
            dgv_pedidos.Rows.Add(dr.Item("cod_pedido").ToString, dr.Item("nome_pedido").ToString, dr.Item("cpf_pedido").ToString, dr.Item("telefone_pedido").ToString, dr.Item("data_pedido").ToString, dr.Item("horario_pedido").ToString, dr.Item("disponibilidade_pedido").ToString, dr.Item("tipo_pedido").ToString, dr.Item("preco_pedido").ToString, dr.Item("imagem_ref_pedido"), dr.Item("desc_pedido").ToString)
        End While
        dr.Close()

        For i = 0 To dgv_pedidos.Rows.Count - 1
            Dim r As DataGridViewRow = dgv_pedidos.Rows(i)
            r.Height = 100
        Next

        Dim imagecolumn = DirectCast(dgv_pedidos.Columns("imagem_ref_pedido"), DataGridViewImageColumn)
        imagecolumn.ImageLayout = DataGridViewImageCellLayout.Stretch
    End Sub

    Sub getPedidosbyData()
        dgv_pedidos.Rows.Clear()
        cm = New MySqlCommand("SELECT * FROM pedidos where data_pedido = '" & datepicker_busca.Text & "'", db)
        dr = cm.ExecuteReader
        While dr.Read
            dgv_pedidos.Rows.Add(dr.Item("cod_pedido").ToString, dr.Item("nome_pedido").ToString, dr.Item("cpf_pedido").ToString, dr.Item("telefone_pedido").ToString, dr.Item("data_pedido").ToString, dr.Item("horario_pedido").ToString, dr.Item("disponibilidade_pedido").ToString, dr.Item("tipo_pedido").ToString, dr.Item("preco_pedido").ToString, dr.Item("imagem_ref_pedido"), dr.Item("desc_pedido").ToString)
        End While
        dr.Close()

        For i = 0 To dgv_pedidos.Rows.Count - 1
            Dim r As DataGridViewRow = dgv_pedidos.Rows(i)
            r.Height = 100
        Next

        Dim imagecolumn = DirectCast(dgv_pedidos.Columns("imagem_ref_pedido"), DataGridViewImageColumn)
        imagecolumn.ImageLayout = DataGridViewImageCellLayout.Stretch
    End Sub

    Private Sub pic_voltar_Click(sender As Object, e As EventArgs) Handles pic_voltar.Click
        Me.Hide()
        frm_menu_adm.Show()
        getPedidos()
    End Sub

    Private Sub btn_busca_Click(sender As Object, e As EventArgs) Handles btn_busca.Click
        getPedidosbyData()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        getPedidos()
        Form9.Show()
    End Sub
End Class