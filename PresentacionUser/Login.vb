Imports MySql.Data.MySqlClient
Public Class Login
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub BTNCerrar_Click(sender As Object, e As EventArgs) Handles BTNCerrar.Click
        Application.Exit()
    End Sub

    Private Sub LinkRegistro_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkRegistro.LinkClicked
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=; database=MyCompany"

        Try
            MysqlConn.Open()
            MessageBox.Show("SIII")
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub BTNEntrar_Click(sender As Object, e As EventArgs) Handles BTNEntrar.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=; database=MyCompany"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from users where nombre_user ='" & TXTUsuario.Text & "' and contraseña='" & TXTContraseña.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
            End While

            If count = 1 Then
                MessageBox.Show("Correcto")
                InterfazUsuario.Show()
                Me.Close()
            ElseIf count > 1 Then
                MessageBox.Show("duplicado")
            Else
                MessageBox.Show("Incorrecto")
            End If
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
End Class
