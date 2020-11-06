Public Class LogicalControl
    Private Property mensajes As New List(Of Message)
    Public Shared Property instancia As New LogicalControl

    Public Function Obtenermensajes() As List(Of Message)
        Return mensajes
    End Function

    Public Sub AgregarMensaje(mensaje As Message)
        mensajes.Add(mensaje)
    End Sub

End Class
