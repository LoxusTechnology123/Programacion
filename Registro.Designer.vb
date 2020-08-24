<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro))
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.BTNCerrarRegistro = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BRNAtras = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.TXTNombreUsuario = New Guna.UI.WinForms.GunaTextBox()
        Me.TXTContraseñaIngresar = New Guna.UI.WinForms.GunaTextBox()
        Me.TXTEmail = New Guna.UI.WinForms.GunaTextBox()
        Me.TXTNombre = New Guna.UI.WinForms.GunaTextBox()
        Me.TXTApellido = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.BTNRegistrarse = New Guna.UI.WinForms.GunaAdvenceButton()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(497, -3)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(400, 494)
        Me.GunaPictureBox1.TabIndex = 1
        Me.GunaPictureBox1.TabStop = False
        '
        'BTNCerrarRegistro
        '
        Me.BTNCerrarRegistro.AnimationHoverSpeed = 0.07!
        Me.BTNCerrarRegistro.AnimationSpeed = 0.03!
        Me.BTNCerrarRegistro.BaseColor = System.Drawing.Color.Transparent
        Me.BTNCerrarRegistro.BorderColor = System.Drawing.Color.Black
        Me.BTNCerrarRegistro.CheckedBaseColor = System.Drawing.Color.Red
        Me.BTNCerrarRegistro.CheckedBorderColor = System.Drawing.Color.Black
        Me.BTNCerrarRegistro.CheckedForeColor = System.Drawing.Color.White
        Me.BTNCerrarRegistro.CheckedImage = CType(resources.GetObject("BTNCerrarRegistro.CheckedImage"), System.Drawing.Image)
        Me.BTNCerrarRegistro.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BTNCerrarRegistro.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTNCerrarRegistro.FocusedColor = System.Drawing.Color.Empty
        Me.BTNCerrarRegistro.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNCerrarRegistro.ForeColor = System.Drawing.Color.White
        Me.BTNCerrarRegistro.Image = CType(resources.GetObject("BTNCerrarRegistro.Image"), System.Drawing.Image)
        Me.BTNCerrarRegistro.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BTNCerrarRegistro.ImageSize = New System.Drawing.Size(32, 32)
        Me.BTNCerrarRegistro.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTNCerrarRegistro.Location = New System.Drawing.Point(443, 1)
        Me.BTNCerrarRegistro.Name = "BTNCerrarRegistro"
        Me.BTNCerrarRegistro.OnHoverBaseColor = System.Drawing.Color.Red
        Me.BTNCerrarRegistro.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTNCerrarRegistro.OnHoverForeColor = System.Drawing.Color.White
        Me.BTNCerrarRegistro.OnHoverImage = Nothing
        Me.BTNCerrarRegistro.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTNCerrarRegistro.OnPressedColor = System.Drawing.Color.Red
        Me.BTNCerrarRegistro.Size = New System.Drawing.Size(53, 42)
        Me.BTNCerrarRegistro.TabIndex = 5
        '
        'BRNAtras
        '
        Me.BRNAtras.AnimationHoverSpeed = 0.07!
        Me.BRNAtras.AnimationSpeed = 0.03!
        Me.BRNAtras.BaseColor = System.Drawing.Color.Transparent
        Me.BRNAtras.BorderColor = System.Drawing.Color.Black
        Me.BRNAtras.CheckedBaseColor = System.Drawing.Color.DarkSlateGray
        Me.BRNAtras.CheckedBorderColor = System.Drawing.Color.Black
        Me.BRNAtras.CheckedForeColor = System.Drawing.Color.White
        Me.BRNAtras.CheckedImage = CType(resources.GetObject("BRNAtras.CheckedImage"), System.Drawing.Image)
        Me.BRNAtras.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BRNAtras.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BRNAtras.FocusedColor = System.Drawing.Color.Empty
        Me.BRNAtras.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BRNAtras.ForeColor = System.Drawing.Color.White
        Me.BRNAtras.Image = CType(resources.GetObject("BRNAtras.Image"), System.Drawing.Image)
        Me.BRNAtras.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BRNAtras.ImageSize = New System.Drawing.Size(32, 32)
        Me.BRNAtras.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BRNAtras.Location = New System.Drawing.Point(0, 0)
        Me.BRNAtras.Name = "BRNAtras"
        Me.BRNAtras.OnHoverBaseColor = System.Drawing.Color.DarkSlateGray
        Me.BRNAtras.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BRNAtras.OnHoverForeColor = System.Drawing.Color.White
        Me.BRNAtras.OnHoverImage = Nothing
        Me.BRNAtras.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BRNAtras.OnPressedColor = System.Drawing.Color.DarkSlateGray
        Me.BRNAtras.Size = New System.Drawing.Size(53, 42)
        Me.BRNAtras.TabIndex = 6
        '
        'TXTNombreUsuario
        '
        Me.TXTNombreUsuario.BaseColor = System.Drawing.Color.White
        Me.TXTNombreUsuario.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.TXTNombreUsuario.BorderSize = 1
        Me.TXTNombreUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTNombreUsuario.FocusedBaseColor = System.Drawing.Color.White
        Me.TXTNombreUsuario.FocusedBorderColor = System.Drawing.Color.DarkSlateGray
        Me.TXTNombreUsuario.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TXTNombreUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTNombreUsuario.Location = New System.Drawing.Point(98, 196)
        Me.TXTNombreUsuario.Name = "TXTNombreUsuario"
        Me.TXTNombreUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTNombreUsuario.SelectedText = ""
        Me.TXTNombreUsuario.Size = New System.Drawing.Size(299, 30)
        Me.TXTNombreUsuario.TabIndex = 7
        '
        'TXTContraseñaIngresar
        '
        Me.TXTContraseñaIngresar.BaseColor = System.Drawing.Color.White
        Me.TXTContraseñaIngresar.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.TXTContraseñaIngresar.BorderSize = 1
        Me.TXTContraseñaIngresar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTContraseñaIngresar.FocusedBaseColor = System.Drawing.Color.White
        Me.TXTContraseñaIngresar.FocusedBorderColor = System.Drawing.Color.DarkSlateGray
        Me.TXTContraseñaIngresar.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TXTContraseñaIngresar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTContraseñaIngresar.Location = New System.Drawing.Point(98, 256)
        Me.TXTContraseñaIngresar.Name = "TXTContraseñaIngresar"
        Me.TXTContraseñaIngresar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTContraseñaIngresar.SelectedText = ""
        Me.TXTContraseñaIngresar.Size = New System.Drawing.Size(299, 30)
        Me.TXTContraseñaIngresar.TabIndex = 8
        '
        'TXTEmail
        '
        Me.TXTEmail.BaseColor = System.Drawing.Color.White
        Me.TXTEmail.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.TXTEmail.BorderSize = 1
        Me.TXTEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTEmail.FocusedBaseColor = System.Drawing.Color.White
        Me.TXTEmail.FocusedBorderColor = System.Drawing.Color.DarkSlateGray
        Me.TXTEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TXTEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTEmail.Location = New System.Drawing.Point(98, 315)
        Me.TXTEmail.Name = "TXTEmail"
        Me.TXTEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTEmail.SelectedText = ""
        Me.TXTEmail.Size = New System.Drawing.Size(299, 30)
        Me.TXTEmail.TabIndex = 9
        '
        'TXTNombre
        '
        Me.TXTNombre.BaseColor = System.Drawing.Color.White
        Me.TXTNombre.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.TXTNombre.BorderSize = 1
        Me.TXTNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTNombre.FocusedBaseColor = System.Drawing.Color.White
        Me.TXTNombre.FocusedBorderColor = System.Drawing.Color.DarkSlateGray
        Me.TXTNombre.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TXTNombre.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTNombre.Location = New System.Drawing.Point(98, 139)
        Me.TXTNombre.Name = "TXTNombre"
        Me.TXTNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTNombre.SelectedText = ""
        Me.TXTNombre.Size = New System.Drawing.Size(146, 30)
        Me.TXTNombre.TabIndex = 10
        '
        'TXTApellido
        '
        Me.TXTApellido.BaseColor = System.Drawing.Color.White
        Me.TXTApellido.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.TXTApellido.BorderSize = 1
        Me.TXTApellido.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTApellido.FocusedBaseColor = System.Drawing.Color.White
        Me.TXTApellido.FocusedBorderColor = System.Drawing.Color.DarkSlateGray
        Me.TXTApellido.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TXTApellido.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTApellido.Location = New System.Drawing.Point(251, 139)
        Me.TXTApellido.Name = "TXTApellido"
        Me.TXTApellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTApellido.SelectedText = ""
        Me.TXTApellido.Size = New System.Drawing.Size(146, 30)
        Me.TXTApellido.TabIndex = 11
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Verdana", 29.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GunaLabel1.Location = New System.Drawing.Point(144, 41)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(204, 47)
        Me.GunaLabel1.TabIndex = 12
        Me.GunaLabel1.Text = "Registro"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(95, 130)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(51, 15)
        Me.GunaLabel2.TabIndex = 13
        Me.GunaLabel2.Text = "Nombre"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(250, 130)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(51, 15)
        Me.GunaLabel3.TabIndex = 14
        Me.GunaLabel3.Text = "Apellido"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel4.Location = New System.Drawing.Point(95, 187)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(47, 15)
        Me.GunaLabel4.TabIndex = 15
        Me.GunaLabel4.Text = "Usuario"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel5.Location = New System.Drawing.Point(95, 247)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(67, 15)
        Me.GunaLabel5.TabIndex = 16
        Me.GunaLabel5.Text = "Contraseña"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel6.Location = New System.Drawing.Point(95, 306)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(36, 15)
        Me.GunaLabel6.TabIndex = 17
        Me.GunaLabel6.Text = "Email"
        '
        'BTNRegistrarse
        '
        Me.BTNRegistrarse.AnimationHoverSpeed = 0.07!
        Me.BTNRegistrarse.AnimationSpeed = 0.03!
        Me.BTNRegistrarse.BaseColor = System.Drawing.Color.DarkSlateGray
        Me.BTNRegistrarse.BorderColor = System.Drawing.Color.Black
        Me.BTNRegistrarse.CheckedBaseColor = System.Drawing.Color.DarkSlateGray
        Me.BTNRegistrarse.CheckedBorderColor = System.Drawing.Color.Black
        Me.BTNRegistrarse.CheckedForeColor = System.Drawing.Color.White
        Me.BTNRegistrarse.CheckedImage = Nothing
        Me.BTNRegistrarse.CheckedLineColor = System.Drawing.Color.DarkSlateGray
        Me.BTNRegistrarse.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTNRegistrarse.FocusedColor = System.Drawing.Color.Empty
        Me.BTNRegistrarse.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNRegistrarse.ForeColor = System.Drawing.Color.White
        Me.BTNRegistrarse.Image = Nothing
        Me.BTNRegistrarse.ImageSize = New System.Drawing.Size(20, 20)
        Me.BTNRegistrarse.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTNRegistrarse.Location = New System.Drawing.Point(159, 396)
        Me.BTNRegistrarse.Name = "BTNRegistrarse"
        Me.BTNRegistrarse.OnHoverBaseColor = System.Drawing.Color.DarkSlateGray
        Me.BTNRegistrarse.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTNRegistrarse.OnHoverForeColor = System.Drawing.Color.White
        Me.BTNRegistrarse.OnHoverImage = Nothing
        Me.BTNRegistrarse.OnHoverLineColor = System.Drawing.Color.DarkSlateGray
        Me.BTNRegistrarse.OnPressedColor = System.Drawing.Color.Black
        Me.BTNRegistrarse.Size = New System.Drawing.Size(180, 42)
        Me.BTNRegistrarse.TabIndex = 18
        Me.BTNRegistrarse.Text = "Registrarse"
        Me.BTNRegistrarse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 490)
        Me.Controls.Add(Me.BTNRegistrarse)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.TXTApellido)
        Me.Controls.Add(Me.TXTNombre)
        Me.Controls.Add(Me.TXTEmail)
        Me.Controls.Add(Me.TXTContraseñaIngresar)
        Me.Controls.Add(Me.TXTNombreUsuario)
        Me.Controls.Add(Me.BRNAtras)
        Me.Controls.Add(Me.BTNCerrarRegistro)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro"
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents BTNCerrarRegistro As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents BRNAtras As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents TXTNombreUsuario As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents TXTContraseñaIngresar As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents TXTEmail As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents TXTNombre As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents TXTApellido As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BTNRegistrarse As Guna.UI.WinForms.GunaAdvenceButton
End Class
