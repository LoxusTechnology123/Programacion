# Programacion
Codigo de las aplicaciones 
Public Class FormularioPrincipal

    Private Sub GunaAdvenceButton4_Click(sender As Object, e As EventArgs) Handles BTNCerrar.Click
        Application.Exit() REM Cierra la aplicacion y todas las ventanas de forma segura
    End Sub

    Public Sub abrirformulario(Of miformulario As {Form, New})()
        Dim formulario As Form REM Se crea una variable de tipo form
        formulario = panelcontenedor.Controls.OfType(Of miformulario)().FirstOrDefault()
        If formulario Is Nothing Then 
            formulario = New miformulario()
            formulario.TopLevel = False
            formulario.FormBorderStyle = FormBorderStyle.None REM Saca los bordes
            formulario.Dock = DockStyle.Fill REM Se ajusta el panel al centro
            panelcontenedor.Controls.Add(formulario) 
            panelcontenedor.Tag = formulario
            formulario.Show() REM muestra el formulario
            formulario.BringToFront() REM pone el panel de frente
        Else
            formulario.BringToFront()
        End If
    End Sub

    Private Sub GunaAdvenceButton5_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton5.Click
        Me.WindowState = FormWindowState.Minimized REM Minimiza la ventana
    End Sub

    Private Sub BTNSintomas_Click(sender As Object, e As EventArgs) Handles BTNSintomas.Click
        abrirformulario(Of Sintomas)() REM llama al metodo y coloca el panel Sintoma
        BTNSintomas.LineLeft = 3 Le agrega una linea de color 
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Hora.Text = DateTime.Now.ToLongTimeString() REM Hora en tiempo real
        Fecha.Text = DateTime.Now.ToLongDateString() REM fecha en tiempo real
    End Sub
End Class

--------------------------------------------------------------------------------------------------------------------------------

Public Class Sintomas
    Private Sub BtnDiarrea_Click(sender As Object, e As EventArgs) Handles BtnDiarrea.Click
        panelcontenedor.AutoScroll = False REM saca el autoscroll del panel 
        abrirformulario(Of SintomaDiarrea)() 
    End Sub
    Private Sub abrirformulario(Of miformulario As {Form, New})()
        Dim formulario As Form
        formulario = Me.Controls.OfType(Of miformulario)().FirstOrDefault()
        If formulario Is Nothing Then
            formulario = New miformulario()
            formulario.TopLevel = False
            formulario.FormBorderStyle = FormBorderStyle.None
            formulario.Dock = DockStyle.Fill
            Me.Controls.Add(formulario)
            Me.Tag = formulario
            formulario.Show()
            formulario.BringToFront()
        Else
            formulario.BringToFront()
        End If
    End Sub
End Class

--------------------------------------------------------------------------------------------------------------------------------

Public Class SintomaDiarrea
    Private Sub SintomaDiarrea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles btnsi.Click
        PanelRespuestaAnidada.BackColor = Color.DodgerBlue
        PanelRespuestaAnidada1.BackColor = Color.SlateGray
    End Sub

    Private Sub GunaAdvenceButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton4.Click
        DiagnosticoFlotante.Show()
        PanelRespuestaAnidada.BackColor = Color.SlateGray
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles btnno.Click
        PanelRespuestaAnidada1.BackColor = Color.DodgerBlue
        PanelRespuestaAnidada.BackColor = Color.SlateGray
    End Sub

    Private Sub GunaAdvenceButton24_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton24.Click
        GunaPanel2.BackColor = Color.DodgerBlue
        PanelRespuestaAnidada1.BackColor = Color.SlateGray
    End Sub

    Private Sub GunaAdvenceButton5_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton5.Click
        panelrespuesta.BackColor = Color.DodgerBlue
    End Sub

    Private Sub GunaAdvenceButton6_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton6.Click
        DiagnosticoFlotante1.Show()
        panelrespuesta.BackColor = Color.SlateGray
    End Sub

    Private Sub GunaAdvenceButton8_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton8.Click
        DiagnosticoFlotante2.Show()
        panelrespuesta.BackColor = Color.SlateGray
    End Sub

    Private Sub GunaAdvenceButton7_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton7.Click
        panelrespuesta2.BackColor = Color.DodgerBlue
        panelrespuesta.BackColor = Color.SlateGray
    End Sub

    Private Sub GunaAdvenceButton10_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton10.Click
        DiagnosticoFlotante3.Show()
        panelrespuesta2.BackColor = Color.SlateGray
    End Sub

    Private Sub GunaAdvenceButton9_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton9.Click
        panelrespuesta12.BackColor = Color.DodgerBlue
    End Sub

    Private Sub GunaAdvenceButton12_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton12.Click
        DiagnosticoFlotante4.Show()
        panelrespuesta12.BackColor = Color.SlateGray
    End Sub

    Private Sub GunaAdvenceButton14_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton14.Click
        DiagnosticoFlotante5.Show()
    End Sub

    Private Sub GunaAdvenceButton16_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton16.Click
        DiagnosticoFlotante6.Show()
    End Sub

    Private Sub GunaAdvenceButton23_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton23.Click
        DiagnosticoFlotante7.Show()
    End Sub

    Private Sub GunaAdvenceButton26_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton26.Click
        DiagnosticoFlotante8.Show()
    End Sub

    Private Sub GunaAdvenceButton21_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton21.Click
        DiagnosticoFlotante12.Show()
    End Sub

    Private Sub GunaAdvenceButton19_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton19.Click
        DiagnosticoFlotante9.Show()
    End Sub
    Private Sub GunaAdvenceButton17_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton17.Click
        DiagnosticoFoltante10.Show()
    End Sub
    Private Sub GunaAdvenceButton1_Click_1(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        DiagnosticoFlotante11.Show()
    End Sub

    Private Sub GunaAdvenceButton28_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton28.Click
        abrirformulario(Of Sintomas)()
    End Sub
    Private Sub abrirformulario(Of miformulario As {Form, New})()
        Dim formulario As Form
        formulario = Me.Controls.OfType(Of miformulario)().FirstOrDefault()
        If formulario Is Nothing Then
            formulario = New miformulario()
            formulario.TopLevel = False
            formulario.FormBorderStyle = FormBorderStyle.None
            formulario.Dock = DockStyle.Fill
            Me.Controls.Add(formulario)
            Me.Tag = formulario
            formulario.Show()
            formulario.BringToFront()
        Else
            formulario.BringToFront()
        End If
    End Sub
End Class

--------------------------------------------------------------------------------------------------------------------------------

Public Class DiagnosticoFlotante12 REM esto se repite 12 veces con cada ventana flotante
    Private Sub BTNCerrar_Click(sender As Object, e As EventArgs) Handles BTNCerrar.Click
        Me.Close()
    End Sub

    Private Sub GunaAdvenceButton5_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
