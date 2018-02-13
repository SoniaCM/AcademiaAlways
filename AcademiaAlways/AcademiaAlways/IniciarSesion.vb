Public Class IniciarSesion

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        Gestiones.Show()
        Me.Close()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Presentacion.Show()
        Me.Close()
    End Sub
End Class