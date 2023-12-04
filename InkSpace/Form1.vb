Public Class Form1
    Private Sub img_adm_Click(sender As Object, e As EventArgs) Handles img_adm.Click
        Try
            Hide()
            frm_adm.Show()
        Catch ex As Exception
            MsgBox("Erro ao continuar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção!")
        End Try
    End Sub

    Private Sub img_pedido_Click(sender As Object, e As EventArgs) Handles img_pedido.Click
        Me.Hide()
        frm_pedidos.Show()
    End Sub

    Private Sub lbl_pedido_Click(sender As Object, e As EventArgs) Handles lbl_pedido.Click
        Me.Hide()
        frm_pedidos.Show()
    End Sub

    Private Sub img_trabalhos_Click(sender As Object, e As EventArgs) Handles img_trabalhos.Click
        Me.Hide()
        frm_trabalhos.Show()
    End Sub

    Private Sub lbl_trabalhos_Click(sender As Object, e As EventArgs) Handles lbl_trabalhos.Click
        Me.Hide()
        frm_trabalhos.Show()
    End Sub

    Private Sub lbl_adm_Click(sender As Object, e As EventArgs) Handles lbl_adm.Click

    End Sub
End Class
