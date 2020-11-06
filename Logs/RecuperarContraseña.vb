Imports Dominio
Public Class RecuperarContraseña
    Private Sub BTN_Enviar_Click(sender As Object, e As EventArgs) Handles BTN_Enviar.Click
        Dim userModel As New UserModel()
        Dim result = userModel.recoverPassword(TXT_Recuperar.Text)
        labelresultado.Text = result
    End Sub
End Class