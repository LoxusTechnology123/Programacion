Public Class LoxusSupportMail
    Inherits MasterEmailServices

    Public Sub New()
        senderMail = "soporteloxus@gmail.com"
        password = "Soporte123"
        host = "smtp.gmail.com"
        port = 587
        ssl = True
        InitializeSmtpClient()
    End Sub

    Public Sub Noti()

    End Sub

End Class
