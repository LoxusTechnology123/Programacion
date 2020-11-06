Imports System.Net.Mail
Imports Dominio
Imports Common
Public Class RegistroGeneral

    Private Sub RegistroGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTN_Registro_Click(sender As Object, e As EventArgs) Handles BTN_Registro.Click
        Dim userModel As New UserModel()
        Dim tipo As String = Positions.paciente
        Dim validregister = userModel.Resgister(TXTContraseña.Text, TXTNombre.Text, TXTApellido.Text, TXTEmail.Text, TXTCI.Text, TXT_Puerta.Text, TXT_Ciudad.Text, TXT_Calle.Text, tipo)
        If (TXTNombre.Text <> "" And TXTCI.Text <> "" And TXTApellido.Text <> "" And TXTEmail.Text <> "" And TXTContraseña.Text <> "" And TXT_Calle.Text <> "" And TXT_Ciudad.Text <> "" And TXT_Puerta.Text <> "") Then

            If validregister = True Then
                MessageBox.Show("Logueado Correctamente" + vbNewLine + "Gracias")
            Else
                MessageBox.Show("Verifique los datos")
            End If
        Else
            MessageBox.Show("Faltan Datos")
        End If

    End Sub

    Private Sub TXTCI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCI.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class