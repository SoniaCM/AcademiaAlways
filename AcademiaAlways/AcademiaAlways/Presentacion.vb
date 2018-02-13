Public Class Presentacion

    Private Sub LinkAcademia_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkAcademia.LinkClicked
        Process.Start("http://www.always-idiomas.com/")
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        IniciarSesion.Show()
        Me.Hide()
    End Sub
End Class
