Imports Dominio
Imports MySql.Data.MySqlClient
Public Class PatologhyAdd
    Dim conexion As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As MySqlDataAdapter
    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        Dim usermodel As New UserModel
        Dim register = usermodel.Resgisterpatologia(txtdesc.Text, txtid.Text, txtnom.Text, txtgrave.Text)
    End Sub

    Private Sub PatologhyAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub
    Public Sub Cargar()
        Try
            conexion.ConnectionString = "server=127.0.0.1; userid=root; password=; database=loxusprueba"
            conexion.Open()
            Dim consulta As String = "select * from patologia"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            datos.Tables.Add("patologia")
            adaptador.Fill(datos.Tables("patologia"))
            DataMedico.DataSource = datos.Tables("patologia")
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class