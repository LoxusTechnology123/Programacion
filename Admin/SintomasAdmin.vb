Imports Dominio
Imports MySql.Data.MySqlClient
Public Class SintomasAdmin
    Dim conexion As MySqlConnection
    Dim datos As DataSet
    Dim adaptador As MySqlDataAdapter
    Private Sub SintomasAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        Dim userModel As New UserModel()
        Dim validregister = userModel.ResgisterSintoma(TXT_ID.Text, TXT_NomSintoma.Text)
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) 
    End Sub
    Public Sub Cargar()
        Try
            conexion.ConnectionString = "server=127.0.0.1; userid=root; password=; database=loxusprueba"
            conexion.Open()
            Dim consulta As String = "select * from sintoma"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            datos.Tables.Add("sintoma")
            adaptador.Fill(datos.Tables("sintoma"))
            DataSintomasAdmin.DataSource = datos.Tables("sintoma")
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class