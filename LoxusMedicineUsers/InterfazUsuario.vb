Imports MySql.Data.MySqlClient
Public Class InterfazUsuario
    Dim MysqlConn As MySqlConnection
    Dim command As MySqlCommand
    Dim datos As DataSet
    Dim adaptador As MySqlDataAdapter
    Private Sub InterfazUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call llenarcombo1() 'Lama al metodo llenar combo
        Call llenarcombo2() 'Lama al metodo llenar combo
        Call llenarcombo3() 'Lama al metodo llenar combo
    End Sub
    Private Sub llenarcombo1()
        Try
            MysqlConn = New MySqlConnection 'Crea la conexion
            MysqlConn.ConnectionString = "server=localhost; userid=root; password=; database=MyCompany" 'Especifica a donde se va a conectar
            MysqlConn.Open() 'Abre la conexion
            Dim consulta As String
            consulta = "select * from sintomas"
            adaptador = New MySqlDataAdapter(consulta, MysqlConn)
            datos = New DataSet
            datos.Tables.Add("sintomas")
            adaptador.Fill(datos.Tables("sintomas"))
            Combo1.DataSource = datos.Tables("sintomas")
            Combo1.DisplayMember = "Nombre" 'Trae de la tabla la columna Nombre
            MysqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub llenarcombo2()
        Try
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=localhost; userid=root; password=; database=MyCompany"
            MysqlConn.Open()
            Dim consulta As String
            consulta = "select * from sintomas"
            adaptador = New MySqlDataAdapter(consulta, MysqlConn)
            datos = New DataSet
            datos.Tables.Add("sintomas")
            adaptador.Fill(datos.Tables("sintomas"))
            Combo2.DataSource = datos.Tables("sintomas")
            Combo2.DisplayMember = "Nombre"
            MysqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub llenarcombo3()
        Try
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=localhost; userid=root; password=; database=MyCompany"
            MysqlConn.Open()
            Dim consulta As String
            consulta = "select * from sintomas"
            adaptador = New MySqlDataAdapter(consulta, MysqlConn)
            datos = New DataSet
            datos.Tables.Add("sintomas")
            adaptador.Fill(datos.Tables("sintomas"))
            Combo3.DataSource = datos.Tables("sintomas")
            Combo3.DisplayMember = "Nombre"
            MysqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub llenar()
        If Combo1.SelectedIndex = 0 And Combo2.SelectedIndex = 0 And Combo3.SelectedIndex = 0 Then
            TXTDiagnostico.Text = "Resfriado o Gripe"
        ElseIf Combo1.SelectedIndex = 1 And Combo2.SelectedIndex = 1 And Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Covid-19"
        ElseIf Combo1.SelectedIndex = 1 And Combo2.SelectedIndex = 1 And Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Sindrome de la Hipersensibilidad de la tos"

        ElseIf Combo1.SelectedIndex = 1 And Combo2.SelectedIndex = 2 And Combo3.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Covid-19"
        ElseIf Combo1.SelectedIndex = 1 And Combo2.SelectedIndex = 2 And Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Covid-19"
        ElseIf Combo1.SelectedIndex = 1 And Combo2.SelectedIndex = 2 And Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Neumonía"

        ElseIf Combo1.SelectedIndex = 1 And Combo2.SelectedIndex = 3 And Combo3.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Sindrome de la Hipersensibilidad de la tos"
        ElseIf Combo1.SelectedIndex = 1 And Combo2.SelectedIndex = 3 And Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Neumonía"
        ElseIf Combo1.SelectedIndex = 1 And Combo2.SelectedIndex = 3 And Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Sindrome de la Hipersensibilidad de la tos"

        ElseIf Combo1.SelectedIndex = 2 And Combo2.SelectedIndex = 1 And Combo3.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Covid-19"
        ElseIf Combo1.SelectedIndex = 2 And Combo2.SelectedIndex = 1 And Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Covid-19"
        ElseIf Combo1.SelectedIndex = 2 And Combo2.SelectedIndex = 1 And Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Sindrome de la Hipersensibilidad de la tos"

        ElseIf Combo1.SelectedIndex = 2 And Combo2.SelectedIndex = 2 And Combo3.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Covid-19"
        ElseIf Combo1.SelectedIndex = 2 And Combo2.SelectedIndex = 2 And Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Diarrea por Antibioticos"
        ElseIf Combo1.SelectedIndex = 2 And Combo2.SelectedIndex = 2 And Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Neumonía"

        ElseIf Combo1.SelectedIndex = 2 And Combo2.SelectedIndex = 3 And Combo3.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Covid-19"
        ElseIf Combo1.SelectedIndex = 2 And Combo2.SelectedIndex = 3 And Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Neumonía"
        ElseIf Combo1.SelectedIndex = 2 And Combo2.SelectedIndex = 3 And Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Asma"

        ElseIf Combo1.SelectedIndex = 3 And Combo2.SelectedIndex = 1 And Combo3.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Bronquitis aguda"
        ElseIf Combo1.SelectedIndex = 3 And Combo2.SelectedIndex = 1 And Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Covid-19"
        ElseIf Combo1.SelectedIndex = 3 And Combo2.SelectedIndex = 1 And Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Bronquitis aguda"

        ElseIf Combo1.SelectedIndex = 3 And Combo2.SelectedIndex = 2 And Combo3.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Covid-19"
        ElseIf Combo1.SelectedIndex = 3 And Combo2.SelectedIndex = 2 And Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Neumonía"
        ElseIf Combo1.SelectedIndex = 3 And Combo2.SelectedIndex = 2 And Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Neumonía"

        ElseIf Combo1.SelectedIndex = 3 And Combo2.SelectedIndex = 3 And Combo3.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Bronquitis aguda"
        ElseIf Combo1.SelectedIndex = 3 And Combo2.SelectedIndex = 3 And Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Asma"
        ElseIf Combo1.SelectedIndex = 3 And Combo2.SelectedIndex = 3 And Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Problema con los Pulmones"

        ElseIf Combo1.SelectedIndex = 1 And Combo2.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Resfriado o Gripe"
        ElseIf Combo1.SelectedIndex = 1 And Combo2.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Covid-19"
        ElseIf Combo1.SelectedIndex = 1 And Combo2.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Bronquitis aguda"

        ElseIf Combo1.SelectedIndex = 2 And Combo2.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Covid-19"
        ElseIf Combo1.SelectedIndex = 2 And Combo2.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Diarrea por Antibioticos"
        ElseIf Combo1.SelectedIndex = 2 And Combo2.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Asma"

        ElseIf Combo1.SelectedIndex = 3 And Combo2.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Bronquitis aguda"
        ElseIf Combo1.SelectedIndex = 3 And Combo2.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Asma"
        ElseIf Combo1.SelectedIndex = 3 And Combo2.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Problema con los Pulmones"

            REM Suponiendo que no coloque los sintomas en orden (1-3) 

        ElseIf Combo1.SelectedIndex = 1 And Combo3.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Resfriado o Gripe"
        ElseIf Combo1.SelectedIndex = 1 And Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Covid-19"
        ElseIf Combo1.SelectedIndex = 1 And Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Bronquitis aguda"

        ElseIf Combo1.SelectedIndex = 2 And Combo3.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Covid-19"
        ElseIf Combo1.SelectedIndex = 2 And Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Diarrea por Antibioticos"
        ElseIf Combo1.SelectedIndex = 2 And Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Asma"

        ElseIf Combo1.SelectedIndex = 3 And Combo3.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Bronquitis aguda"
        ElseIf Combo1.SelectedIndex = 3 And Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Asma"
        ElseIf Combo1.SelectedIndex = 3 And Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Problema con los Pulmones"

            REM Suponiendo que no coloque los sintomas en orden (2-3)

        ElseIf Combo2.SelectedIndex = 1 And Combo3.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Resfriado o Gripe"
        ElseIf Combo2.SelectedIndex = 1 And Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Covid-19"
        ElseIf Combo2.SelectedIndex = 1 And Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Bronquitis aguda"

        ElseIf Combo2.SelectedIndex = 2 And Combo3.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Covid-19"
        ElseIf Combo2.SelectedIndex = 2 And Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Diarrea por Antibioticos"
        ElseIf Combo2.SelectedIndex = 2 And Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Asma"

        ElseIf Combo2.SelectedIndex = 3 And Combo3.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Bronquitis aguda"
        ElseIf Combo2.SelectedIndex = 3 And Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Asma"
        ElseIf Combo2.SelectedIndex = 3 And Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Problema con los Pulmones"

        ElseIf Combo1.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Resfriado o Gripe"
        ElseIf Combo1.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Diarrea por Antibioticos"
        ElseIf Combo1.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Problema con los Pulmones"

            REM Suponiendo que no coloque los sintomas en orden (2)

        ElseIf Combo2.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Resfriado o Gripe"
        ElseIf Combo2.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Diarrea por Antibioticos"
        ElseIf Combo2.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Problema con los Pulmones"

            REM Suponiendo que no coloque los sintomas en orden (2)

        ElseIf Combo3.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Resfriado o Gripe"
        ElseIf Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Diarrea por Antibioticos"
        ElseIf Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Problema con los Pulmones"
        End If
    End Sub

    Private Sub GunaAdvenceButton5_Click(sender As Object, e As EventArgs)
        Call llenar()
    End Sub

    Public Sub abrirformulario(Of miformulario As {Form, New})()
        Dim formulario As Form 'Se crea una variable de tipo form
        formulario = panelcontenedor.Controls.OfType(Of miformulario)().FirstOrDefault()
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

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles BTNChat.Click
        abrirformulario(Of Chat)() 'Llama al metodo abrirformulario
        BTNChat.BaseColor = Color.Navy
        BTNActividad.BaseColor = Color.MediumBlue
        BTNPatologias.BaseColor = Color.MediumBlue
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=; database=MyCompany"
        Call llenar()
        Call MandarInfo()
    End Sub
    Private Sub MandarInfo()
        If MysqlConn.State = ConnectionState.Closed Then
            MysqlConn.Open()
        End If
        Dim command As New MySqlCommand("insert into patologiassintomas(Nombre_Patologia)values
        ('" & Me.TXTDiagnostico.Text & "')", MysqlConn)
        command.ExecuteNonQuery()
        If MysqlConn.State = ConnectionState.Open Then
            MysqlConn.Close()
        End If
    End Sub

    Private Sub BTNActividad_Click(sender As Object, e As EventArgs) Handles BTNActividad.Click
        abrirformulario(Of Actividad)() 'Llama al metodo abrirformulario
        BTNChat.BaseColor = Color.MediumBlue
        BTNActividad.BaseColor = Color.Navy
        BTNPatologias.BaseColor = Color.MediumBlue
    End Sub

    Private Sub BTNPatologias_Click(sender As Object, e As EventArgs) Handles BTNPatologias.Click
        abrirformulario(Of InterfazUsuario)() 'Llama al metodo abrirformulario
        BTNChat.BaseColor = Color.MediumBlue
        BTNActividad.BaseColor = Color.MediumBlue
        BTNPatologias.BaseColor = Color.Navy
    End Sub

    Private Sub Panelcontenedor_Paint(sender As Object, e As PaintEventArgs) Handles Panelcontenedor.Paint

    End Sub
End Class