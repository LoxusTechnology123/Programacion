Imports MySql.Data.MySqlClient
Public Class Actividad
    Dim MysqlConn As MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Private Sub Actividad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MysqlConn = New MySqlConnection 'Crea la conexion
            MysqlConn.ConnectionString = "server=localhost; userid=root; password=; database=MyCompany" 'Especifica a donde se va a conectar
            MysqlConn.Open() 'Abre la conexion
            Dim consulta As String
            consulta = "select nombre_patologia * from patologiassintomas"
            adaptador = New MySqlDataAdapter(consulta, MysqlConn)
            datos = New DataSet
            adaptador.Fill(datos, "patologiassintomas")
            GridPatologias.DataSource = datos
            GridPatologias.DataMember = "patologiassintomas"
        Catch ex As Exception

        End Try
    End Sub
End Class