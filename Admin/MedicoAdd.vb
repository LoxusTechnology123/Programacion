Imports Common
Imports Dominio
Imports MySql.Data.MySqlClient
Public Class MedicoAdd
    Dim conexion As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As MySqlDataAdapter

    Private Sub MedicoAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        Dim usermodel As New UserModel
        Dim result = Positions.medico
        Dim validregister = usermodel.ResgisterMedico(txtcontraseñamedico.Text, txtmediconombre.Text, txtmedicoapellido.Text, txtcorreomedico.Text, TXT_cimedico.Text, txtpuerta.Text, txtciudad.Text, txtcalle.Text, result, txtespecialidadmedico.Text)
    End Sub
    Public Sub Cargar()
        Try
            conexion.ConnectionString = "server=127.0.0.1; userid=root; password=; database=loxusprueba"
            conexion.Open()
            Dim consulta As String = "select * from persona where rol = 'Medico'"
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