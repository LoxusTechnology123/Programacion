Imports Dominio
Imports Common
Public Class ChatMedic
    Private Sub ChatMedic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXTChat.ReadOnly = True
        Timer1.Start()
        TXTChat.ReadOnly = True
    End Sub
    Private Sub ActualizarChat()
        TXTChat.Clear()

        Dim textocompleto = ""
        Dim mensajes As List(Of Message) = LogicalControl.instancia.Obtenermensajes()
        For Each mensaje As Message In mensajes
            Dim lineamensaje = vbNewLine & mensaje.Nombre & " " & mensaje.apellido & "; " & vbNewLine & mensaje.Texto & vbNewLine
            textocompleto = textocompleto & lineamensaje
        Next

        TXTChat.Text = textocompleto

    End Sub

    Private Sub BTNEnviarMensaje_Click(sender As Object, e As EventArgs) Handles BTNEnviarMensaje.Click
        Dim nombre As String = ActiveUser.Nombre
        Dim apellido As String = ActiveUser.Apellido
        Dim mensaje As New Message(TXT_CIChat.Text, BTNEnviar.Text, nombre, apellido)
        LogicalControl.instancia.AgregarMensaje(mensaje)
        ActualizarChat()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ActualizarChat()
    End Sub

    Private Sub BTN_Entrar_Click(sender As Object, e As EventArgs) Handles BTN_Entrar.Click
        TXTChat.Clear()
    End Sub
End Class