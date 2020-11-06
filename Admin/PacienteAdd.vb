Imports Common
Imports Dominio
Imports MySql.Data.MySqlClient
Public Class PacienteAdd
    Dim conexion As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As MySqlDataAdapter
    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        Dim usser As New UserModel
        Dim result = Positions.paciente
        Dim register = usser.Resgisterpaciente(txtcontraseña.Text, txtnombre.Text, txtapelido.Text, txtcorreo.Text, TXT_ci.Text, txtpuerta.Text, txtciudad.Text, txtcalle.Text, result)
    End Sub

    Private Sub PacienteAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub
    Public Sub Cargar()
        Try
            conexion.ConnectionString = "server=127.0.0.1; userid=root; password=; database=loxusprueba"
            conexion.Open()
            Dim consulta As String = "select * from persona where rol = 'Paciente'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            datos.Tables.Add("persona")
            adaptador.Fill(datos.Tables("persona"))
            DataMedico.DataSource = datos.Tables("persona")
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class