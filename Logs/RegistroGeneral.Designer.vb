<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistroGeneral
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroGeneral))
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.TXTCI = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TXTNombre = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TXTApellido = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TXTEmail = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TXTContraseña = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BTN_Registro = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.TXT_Calle = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TXT_Ciudad = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TXT_Puerta = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaControlBox2
        '
        Me.GunaControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox2.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox2.AnimationSpeed = 0.03!
        Me.GunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.GunaControlBox2.IconColor = System.Drawing.Color.Black
        Me.GunaControlBox2.IconSize = 15.0!
        Me.GunaControlBox2.Location = New System.Drawing.Point(42, 0)
        Me.GunaControlBox2.Name = "GunaControlBox2"
        Me.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox2.Size = New System.Drawing.Size(45, 36)
        Me.GunaControlBox2.TabIndex = 21
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.IconColor = System.Drawing.Color.Black
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(0, 0)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(45, 35)
        Me.GunaControlBox1.TabIndex = 20
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Cambria", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(88, 43)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(232, 41)
        Me.GunaLabel1.TabIndex = 22
        Me.GunaLabel1.Text = "REGISTRARSE"
        '
        'TXTCI
        '
        Me.TXTCI.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTCI.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXTCI.HintForeColor = System.Drawing.Color.Empty
        Me.TXTCI.HintText = "Cedula de Identidad"
        Me.TXTCI.isPassword = False
        Me.TXTCI.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXTCI.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXTCI.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXTCI.LineThickness = 3
        Me.TXTCI.Location = New System.Drawing.Point(95, 166)
        Me.TXTCI.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTCI.Name = "TXTCI"
        Me.TXTCI.Size = New System.Drawing.Size(193, 44)
        Me.TXTCI.TabIndex = 23
        Me.TXTCI.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TXTNombre
        '
        Me.TXTNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTNombre.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXTNombre.HintForeColor = System.Drawing.Color.Empty
        Me.TXTNombre.HintText = "Nombre"
        Me.TXTNombre.isPassword = False
        Me.TXTNombre.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXTNombre.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXTNombre.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXTNombre.LineThickness = 3
        Me.TXTNombre.Location = New System.Drawing.Point(95, 114)
        Me.TXTNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTNombre.Name = "TXTNombre"
        Me.TXTNombre.Size = New System.Drawing.Size(193, 44)
        Me.TXTNombre.TabIndex = 24
        Me.TXTNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TXTApellido
        '
        Me.TXTApellido.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTApellido.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTApellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXTApellido.HintForeColor = System.Drawing.Color.Empty
        Me.TXTApellido.HintText = "Apellido"
        Me.TXTApellido.isPassword = False
        Me.TXTApellido.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXTApellido.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXTApellido.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXTApellido.LineThickness = 3
        Me.TXTApellido.Location = New System.Drawing.Point(296, 114)
        Me.TXTApellido.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTApellido.Name = "TXTApellido"
        Me.TXTApellido.Size = New System.Drawing.Size(193, 44)
        Me.TXTApellido.TabIndex = 25
        Me.TXTApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TXTEmail
        '
        Me.TXTEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTEmail.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXTEmail.HintForeColor = System.Drawing.Color.Empty
        Me.TXTEmail.HintText = "Email"
        Me.TXTEmail.isPassword = False
        Me.TXTEmail.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXTEmail.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXTEmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXTEmail.LineThickness = 3
        Me.TXTEmail.Location = New System.Drawing.Point(95, 218)
        Me.TXTEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTEmail.Name = "TXTEmail"
        Me.TXTEmail.Size = New System.Drawing.Size(394, 44)
        Me.TXTEmail.TabIndex = 26
        Me.TXTEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TXTContraseña
        '
        Me.TXTContraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTContraseña.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTContraseña.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXTContraseña.HintForeColor = System.Drawing.Color.Empty
        Me.TXTContraseña.HintText = "Contraseña"
        Me.TXTContraseña.isPassword = True
        Me.TXTContraseña.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXTContraseña.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXTContraseña.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXTContraseña.LineThickness = 3
        Me.TXTContraseña.Location = New System.Drawing.Point(296, 166)
        Me.TXTContraseña.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTContraseña.Name = "TXTContraseña"
        Me.TXTContraseña.Size = New System.Drawing.Size(193, 44)
        Me.TXTContraseña.TabIndex = 27
        Me.TXTContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTN_Registro
        '
        Me.BTN_Registro.AnimationHoverSpeed = 0.07!
        Me.BTN_Registro.AnimationSpeed = 0.03!
        Me.BTN_Registro.BaseColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BTN_Registro.BorderColor = System.Drawing.Color.Black
        Me.BTN_Registro.CheckedBaseColor = System.Drawing.Color.Green
        Me.BTN_Registro.CheckedBorderColor = System.Drawing.Color.Black
        Me.BTN_Registro.CheckedForeColor = System.Drawing.Color.White
        Me.BTN_Registro.CheckedImage = CType(resources.GetObject("BTN_Registro.CheckedImage"), System.Drawing.Image)
        Me.BTN_Registro.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BTN_Registro.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_Registro.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_Registro.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_Registro.ForeColor = System.Drawing.Color.White
        Me.BTN_Registro.Image = Nothing
        Me.BTN_Registro.ImageSize = New System.Drawing.Size(20, 20)
        Me.BTN_Registro.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_Registro.Location = New System.Drawing.Point(191, 390)
        Me.BTN_Registro.Name = "BTN_Registro"
        Me.BTN_Registro.OnHoverBaseColor = System.Drawing.Color.Green
        Me.BTN_Registro.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTN_Registro.OnHoverForeColor = System.Drawing.Color.White
        Me.BTN_Registro.OnHoverImage = Nothing
        Me.BTN_Registro.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_Registro.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_Registro.Size = New System.Drawing.Size(180, 42)
        Me.BTN_Registro.TabIndex = 33
        Me.BTN_Registro.Text = "Registrarse"
        Me.BTN_Registro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Image = CType(resources.GetObject("GunaPictureBox2.Image"), System.Drawing.Image)
        Me.GunaPictureBox2.Location = New System.Drawing.Point(517, 394)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(56, 50)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox2.TabIndex = 34
        Me.GunaPictureBox2.TabStop = False
        '
        'TXT_Calle
        '
        Me.TXT_Calle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Calle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Calle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_Calle.HintForeColor = System.Drawing.Color.Empty
        Me.TXT_Calle.HintText = "Calle"
        Me.TXT_Calle.isPassword = False
        Me.TXT_Calle.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXT_Calle.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXT_Calle.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXT_Calle.LineThickness = 3
        Me.TXT_Calle.Location = New System.Drawing.Point(95, 271)
        Me.TXT_Calle.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_Calle.Name = "TXT_Calle"
        Me.TXT_Calle.Size = New System.Drawing.Size(193, 44)
        Me.TXT_Calle.TabIndex = 36
        Me.TXT_Calle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TXT_Ciudad
        '
        Me.TXT_Ciudad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Ciudad.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Ciudad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_Ciudad.HintForeColor = System.Drawing.Color.Empty
        Me.TXT_Ciudad.HintText = "Ciudad"
        Me.TXT_Ciudad.isPassword = False
        Me.TXT_Ciudad.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXT_Ciudad.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXT_Ciudad.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXT_Ciudad.LineThickness = 3
        Me.TXT_Ciudad.Location = New System.Drawing.Point(296, 271)
        Me.TXT_Ciudad.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_Ciudad.Name = "TXT_Ciudad"
        Me.TXT_Ciudad.Size = New System.Drawing.Size(193, 44)
        Me.TXT_Ciudad.TabIndex = 37
        Me.TXT_Ciudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TXT_Puerta
        '
        Me.TXT_Puerta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Puerta.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Puerta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_Puerta.HintForeColor = System.Drawing.Color.Empty
        Me.TXT_Puerta.HintText = "NºPuerta o M Y S"
        Me.TXT_Puerta.isPassword = False
        Me.TXT_Puerta.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXT_Puerta.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXT_Puerta.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXT_Puerta.LineThickness = 3
        Me.TXT_Puerta.Location = New System.Drawing.Point(95, 323)
        Me.TXT_Puerta.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_Puerta.Name = "TXT_Puerta"
        Me.TXT_Puerta.Size = New System.Drawing.Size(393, 44)
        Me.TXT_Puerta.TabIndex = 38
        Me.TXT_Puerta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'RegistroGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 444)
        Me.Controls.Add(Me.TXT_Puerta)
        Me.Controls.Add(Me.TXT_Ciudad)
        Me.Controls.Add(Me.TXT_Calle)
        Me.Controls.Add(Me.GunaPictureBox2)
        Me.Controls.Add(Me.BTN_Registro)
        Me.Controls.Add(Me.TXTContraseña)
        Me.Controls.Add(Me.TXTEmail)
        Me.Controls.Add(Me.TXTApellido)
        Me.Controls.Add(Me.TXTNombre)
        Me.Controls.Add(Me.TXTCI)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaControlBox2)
        Me.Controls.Add(Me.GunaControlBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegistroGeneral"
        Me.Text = "RegistroGeneral"
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TXTCI As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TXTNombre As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TXTApellido As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TXTEmail As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TXTContraseña As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BTN_Registro As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents TXT_Calle As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TXT_Ciudad As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TXT_Puerta As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
