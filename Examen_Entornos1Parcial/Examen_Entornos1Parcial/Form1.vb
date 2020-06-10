Public Class Form1
    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        If txtUsuario.Text.ToUpper() = "ADMINISTRADOR" And txtContraseña.Text = "SinHacer2020" Then
            Ingreso_de_pruebas.Show()
            Me.Hide()
        Else
            MsgBox("Datos incorrectos")
        End If
    End Sub
End Class