Imports MySql.Data.MySqlClient
Public Class Cuentas
    Dim MysqlConn As MySqlConnection
    Private Sub Cuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call llenar()
        Call llenar1()
    End Sub

    Private Sub llenar()
        MysqlConn = New MySqlConnection 'Crea la conexion
        Dim command As MySqlCommand = New MySqlCommand

        command.Connection = MysqlConn
        Try
            MysqlConn.ConnectionString = "server=localhost; userid=root; password=; database=MyCompany" 'Especifica a donde se va a conectar
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        command.CommandText = "select * from pacientes"
        Dim dt As DataTable = New DataTable
        Dim ds As MySqlDataAdapter = New MySqlDataAdapter(command)

        ds.Fill(dt)
        DataUsers.DataSource = dt
        MysqlConn.Close()
    End Sub

    Private Sub llenar1()
        MysqlConn = New MySqlConnection 'Crea la conexion
        Dim command As MySqlCommand = New MySqlCommand

        command.Connection = MysqlConn
        Try
            MysqlConn.ConnectionString = "server=localhost; userid=root; password=; database=MyCompany" 'Especifica a donde se va a conectar
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        command.CommandText = "select * from medicos"
        Dim dt As DataTable = New DataTable
        Dim ds As MySqlDataAdapter = New MySqlDataAdapter(command)

        ds.Fill(dt)
        DataMedic.DataSource = dt
        MysqlConn.Close()
    End Sub
End Class
