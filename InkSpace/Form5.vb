Public Class frm_menu_adm

    Private Sub pic_voltar_Click(sender As Object, e As EventArgs) Handles pic_voltar.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub lbl_voltar_Click(sender As Object, e As EventArgs) Handles lbl_voltar.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub pic_confirmar_Click(sender As Object, e As EventArgs) Handles pic_confirmar.Click
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub lbl_confirmar_Click(sender As Object, e As EventArgs) Handles lbl_confirmar.Click
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub pic_limpar_Click(sender As Object, e As EventArgs) Handles pic_limpar.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub lbl_limpar_Click(sender As Object, e As EventArgs) Handles lbl_limpar.Click
        Me.Hide()
        Form6.Show()
    End Sub
End Class