Imports Dominio
Imports Common
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblerrores.Visible = False
        LBL_ConIn.Visible = False
        LBL_CIIn.Visible = False
    End Sub
    Private Sub BTN_Entrar_Click(sender As Object, e As EventArgs) Handles BTN_Entrar.Click
        Dim userModel As New UserModel()
        Dim validLogin = userModel.Login(TXT_CI.Text, TXT_Contraseña.Text)
        If TXT_CI.Text <> "" And TXT_Contraseña.Text <> "" Then
            If TXT_CI.Text.Length = 8 Then
                If validLogin = True Then
                    If ActiveUser.Rol = Positions.paciente Then
                        Dim frm2 As New Interfaz()
                        frm2.Show()
                        AddHandler frm2.FormClosed, AddressOf Me.Logout
                        Me.Hide()
                    End If
                    If ActiveUser.Rol = Positions.medico Then
                        Dim frm3 As New InterfazMedico()
                        frm3.Show()
                        AddHandler frm3.FormClosed, AddressOf Me.Logout
                        Me.Hide()
                    End If
                    If ActiveUser.Rol = Positions.administrador Then
                        Dim frm4 As New InterfazAdministrador()
                        frm4.Show()
                        AddHandler frm4.FormClosed, AddressOf Me.Logout
                        Me.Hide()
                    End If

                Else
                    LBL_CIIn.Visible = True
                    LBL_ConIn.Visible = True
                    TXT_Contraseña.Focus()
                End If
            Else
                lblerrores.Visible = True
            End If
        Else
            MessageBox.Show("Faltan Datos")
        End If

    End Sub
    Private Sub Logout(sender As Object, e As FormClosedEventArgs)
        Me.Show()
        TXT_CI.Focus()
    End Sub
    Private Sub TXT_CI_OnValueChanged(sender As Object, e As EventArgs) Handles TXT_CI.OnValueChanged
        LBL_CIIn.Visible = False
        LBL_ConIn.Visible = False
    End Sub
    Private Sub TXT_Contraseña_OnValueChanged(sender As Object, e As EventArgs) Handles TXT_Contraseña.OnValueChanged
        LBL_CIIn.Visible = False
        LBL_ConIn.Visible = False
    End Sub
    Public Sub abrirformulario(Of miformulario As {Form, New})()
        Dim formulario As Form 'Se crea una variable de tipo form
        formulario = PanelModificado.Controls.OfType(Of miformulario)().FirstOrDefault()
        If formulario Is Nothing Then
            formulario = New miformulario()
            formulario.TopLevel = False
            formulario.FormBorderStyle = FormBorderStyle.None 'Saca los bordes
            formulario.Dock = DockStyle.Fill 'Se ajusta el panel al centro
            PanelModificado.Controls.Add(formulario) 'Agrega el formulario 
            PanelModificado.Tag = formulario 'Establece el nombre para el control 
            formulario.Show() 'muestra el formulario
            formulario.BringToFront() 'pone el panel de frente
        Else
            formulario.BringToFront() 'pone el panel de frente
        End If
    End Sub

    Private Sub GunaLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel1.LinkClicked
        Dim RecuperarContr As New RecuperarContraseña
        RecuperarContr.ShowDialog()

    End Sub

    Private Sub GunaLinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel2.LinkClicked
        abrirformulario(Of RegistroGeneral)()
    End Sub

    Private Sub PanelModificado_Paint(sender As Object, e As PaintEventArgs) Handles PanelModificado.Paint

    End Sub

    'Public Sub Cargaridiomas()
    '---------------Form Login--------------- 
    '   LBL_Titulo.Text = Traductor.Traducir("Titulo_Login")
    '   LBL_User.Text = Traductor.Traducir("LBL_Usuario")
    '  LBL_LogPassUser.Text = Traductor.Traducir("LBL_Contraseña")
    '  BTN_LogUser.Text = Traductor.Traducir("BTN_LogUser")
    '  BTN_LogMedic.Text = Traductor.Traducir("BTN_LogMedic")
    '  BTN_LogAdmin.Text = Traductor.Traducir("BTN_LogAdmin")
    '   LBL_Account.Text = Traductor.Traducir("LBL_CrearCuenta")
    '  LBL_RecuPass.Text = Traductor.Traducir("LBL_Recuperar")
    '  BTN_LoginUser.Text = Traductor.Traducir("BTN_Login")
    '  LBL_ErrorLogPass.Text = Traductor.Traducir("LBL_ErrorContraseña")
    '  LBL_ErrorLog.Text = Traductor.Traducir("LBL_ErrorUsuario")
    '   LBL_MaxPass.Text = Traductor.Traducir("LBL_MaxPass")
    '  LBL_MaxUser.Text = Traductor.Traducir("LBL_MaxUser")
    'End Sub
End Class