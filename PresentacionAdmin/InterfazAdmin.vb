Imports MySql.Data.MySqlClient
Public Class InterfazAdmin
    Dim MysqlConn As MySqlConnection
    Private Sub InterfazUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call llenar()
        Call llenar2()
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
        command.CommandText = "select * from sintomas"
        Dim dt As DataTable = New DataTable
        Dim ds As MySqlDataAdapter = New MySqlDataAdapter(command)

        ds.Fill(dt)
        DataSintomas.DataSource = dt
        MysqlConn.Close()
    End Sub

    Private Sub llenar2()
        MysqlConn = New MySqlConnection 'Crea la conexion
        Dim command As MySqlCommand = New MySqlCommand

        command.Connection = MysqlConn
        Try
            MysqlConn.ConnectionString = "server=localhost; userid=root; password=; database=MyCompany" 'Especifica a donde se va a conectar
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        command.CommandText = "select * from patologias"
        Dim dt As DataTable = New DataTable
        Dim ds As MySqlDataAdapter = New MySqlDataAdapter(command)

        ds.Fill(dt)
        Datapatologias.DataSource = dt
        MysqlConn.Close()
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles BTNCuentas.Click
        abrirformulario(Of Cuentas)()
        BTNPatologiasSintomas.BaseColor = Color.MediumBlue
        BTNCuentas.BaseColor = Color.Navy
    End Sub

    Public Sub abrirformulario(Of miformulario As {Form, New})()
        Dim formulario As Form 'Se crea una variable de tipo form
        formulario = Panelcontenedor.Controls.OfType(Of miformulario)().FirstOrDefault()
        If formulario Is Nothing Then
            formulario = New miformulario()
            formulario.TopLevel = False
            formulario.FormBorderStyle = FormBorderStyle.None 'Saca los bordes
            formulario.Dock = DockStyle.Fill 'Se ajusta el panel al centro
            Panelcontenedor.Controls.Add(formulario) 'Agrega el formulario 
            Panelcontenedor.Tag = formulario 'Establece el nombre para el control 
            formulario.Show() 'muestra el formulario
            formulario.BringToFront() 'pone el panel de frente
        Else
            formulario.BringToFront() 'pone el panel de frente
        End If
    End Sub

    Private Sub BTNPatologiasSintomas_Click(sender As Object, e As EventArgs) Handles BTNPatologiasSintomas.Click
        abrirformulario(Of InterfazAdmin)()
        BTNPatologiasSintomas.BaseColor = Color.Navy
        BTNCuentas.BaseColor = Color.MediumBlue
    End Sub
End Class