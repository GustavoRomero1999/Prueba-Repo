Public Class FRMPRINCIPAL

    Private Sub BTNACEPTAR_Click(sender As Object, e As EventArgs) Handles BTNACEPTAR.Click
        TextBox1.Text = "BIENVENIDO GIT"
    End Sub

    Private Sub BTNBOTRRAR_Click(sender As Object, e As EventArgs) Handles BTNBOTRRAR.Click
        TextBox1.Text = ""
    End Sub
End Class
