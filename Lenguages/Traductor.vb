Public Class Traductor
    Public Shared Property Idioma As String = "Español"

    Public Shared Function Traducir(clave As String)
        Dim traduccion As String = Nothing

        If Idioma = "Español" Then
            traduccion = My.Resources.Español.ResourceManager.GetString(clave)

        ElseIf Idioma = "Ingles" Then
            traduccion = My.Resources.Ingles.ResourceManager.GetString(clave)
        End If
        If traduccion = Nothing Then
            traduccion = clave
        End If
        Return traduccion
    End Function

End Class
