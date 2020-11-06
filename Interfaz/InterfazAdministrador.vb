Imports Common
Imports Dominio
Public Class InterfazAdministrador

    Private Sub InterfazAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Security()
        LoadUser()
    End Sub
    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        If MessageBox.Show("¿Esta seguro que desea cerrar sesión?", "Warning",
          MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
    Public Sub abrirformulario(Of miformulario As {Form, New})()
        Dim formulario As Form 'Se crea una variable de tipo form
        formulario = PanelInterfaz.Controls.OfType(Of miformulario)().FirstOrDefault()
        If formulario Is Nothing Then
            formulario = New miformulario()
            formulario.TopLevel = False
            formulario.FormBorderStyle = FormBorderStyle.None 'Saca los bordes
            formulario.Dock = DockStyle.Fill 'Se ajusta el panel al centro
            PanelInterfaz.Controls.Add(formulario) 'Agrega el formulario 
            PanelInterfaz.Tag = formulario 'Establece el nombre para el control 
            formulario.Show() 'muestra el formulario
            formulario.BringToFront() 'pone el panel de frente
        Else
            formulario.BringToFront() 'pone el panel de frente
        End If
    End Sub

    Private Sub LoadUser()
        Labelcargo.Text = ActiveUser.Rol
        Labelnombre.Text = ActiveUser.Apellido + " " + ActiveUser.Nombre
        Labelemail.Text = ActiveUser.Email
        Label4.Text = ActiveUser.Apellido + " " + ActiveUser.Nombre
    End Sub

    Private Sub Security()
        Dim user As New UserModel()
        If user.AnyMethod(ActiveUser.CI_Persona) = False Then
            MessageBox.Show("Error")
            Me.Close()
        End If
    End Sub

    Private Sub vlose_Click(sender As Object, e As EventArgs) Handles vlose.Click
        If MessageBox.Show("¿Esta seguro que desea cerrar el programa?", "Warning",
          MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub BTN_Sintomas_Click(sender As Object, e As EventArgs) Handles BTN_Sintomas.Click
        abrirformulario(Of SintomasAdmin)()
    End Sub

    Private Sub BTN_Chat_Click(sender As Object, e As EventArgs) Handles BTN_Chat.Click
        abrirformulario(Of MedicoAdd)()
    End Sub

    Private Sub BTN_Configuracion_Click(sender As Object, e As EventArgs) Handles BTN_Configuracion.Click
        abrirformulario(Of PacienteAdd)()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        abrirformulario(Of PatologhyAdd)()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        abrirformulario(Of AdminAdd)()
    End Sub
End Class