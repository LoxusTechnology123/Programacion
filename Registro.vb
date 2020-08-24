Imports MySql.Data.MySqlClient
Public Class Registro
    Dim MysqlConn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles BRNAtras.Click
        Me.Close()
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles BTNCerrarRegistro.Click
        Me.Close()
    End Sub

    Private Sub BTNRegistrarse_Click(sender As Object, e As EventArgs) Handles BTNRegistrarse.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=; database=MyCompany"
        Call registrar()
    End Sub
    Private Sub registrar()
        If MysqlConn.State = ConnectionState.Closed Then
            MysqlConn.Open()
        End If
        Dim command As New MySqlCommand("insert into pacientes(Nombre, Apellido, Nombre_Usuario, Contraseña, Email)values
        ('" & Me.TXTNombre.Text & "','" & Me.TXTApellido.Text & "','" & Me.TXTNombreUsuario.Text & "','" & Me.TXTContraseñaIngresar.Text & "','" & Me.TXTEmail.Text & "')", MysqlConn)
        command.ExecuteNonQuery()
        MsgBox("Usuario registrado correctamente", MsgBoxStyle.Information, "Confirmar")
        If MysqlConn.State = ConnectionState.Open Then
            MysqlConn.Close()
        End If
    End Sub
End Class