Public Class Message
    Public Property Cipersona As String
    Public Property Nombre As String
    Public Property Texto As String
    Public Property apellido As String

    Public Sub New(pCipersona As String, pTexto As String, pnombre As String, papellido As String)
        Me.Cipersona = pCipersona
        Me.Texto = pTexto
        Me.Nombre = pnombre
        Me.apellido = papellido
    End Sub
End Class
