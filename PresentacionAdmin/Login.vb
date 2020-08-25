Imports MySql.Data.MySqlClient
Public Class Login
    Dim MysqlConn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=; database=MyCompany"
        Dim reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from administrador where nombre_usuario='" & TXTUsuario.Text & "'and contraseña='" & TXTContraseña.Text & "'"
            command = New MySqlCommand(Query, MysqlConn)
            reader = command.ExecuteReader
            Dim count As Integer
            While reader.Read
                count = count + 1
            End While
            If count = 1 Then
                MessageBox.Show("Login Correcto")
                InterfazAdmin.Show()
            Else
                MessageBox.Show("Contraseña o Usuario Incorrectos")
                TXTContraseña.Text = ""
                TXTContraseña.Focus()
            End If
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        Application.Exit()
    End Sub

End Class
