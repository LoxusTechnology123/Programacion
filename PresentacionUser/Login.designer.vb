<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.LinkRegistro = New Guna.UI.WinForms.GunaLinkLabel()
        Me.BTNCerrar = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BTNEntrar = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.TXTContraseña = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.TXTUsuario = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPanel1.SuspendLayout()
        Me.GunaPanel2.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Controls.Add(Me.LinkRegistro)
        Me.GunaPanel1.Controls.Add(Me.BTNCerrar)
        Me.GunaPanel1.Controls.Add(Me.BTNEntrar)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel3)
        Me.GunaPanel1.Controls.Add(Me.TXTContraseña)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel2)
        Me.GunaPanel1.Controls.Add(Me.TXTUsuario)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(382, 402)
        Me.GunaPanel1.TabIndex = 0
        '
        'LinkRegistro
        '
        Me.LinkRegistro.AutoSize = True
        Me.LinkRegistro.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LinkRegistro.Location = New System.Drawing.Point(72, 369)
        Me.LinkRegistro.Name = "LinkRegistro"
        Me.LinkRegistro.Size = New System.Drawing.Size(227, 15)
        Me.LinkRegistro.TabIndex = 10
        Me.LinkRegistro.TabStop = True
        Me.LinkRegistro.Text = "¿Todavia no tienes una cuenta? Click Aquí"
        '
        'BTNCerrar
        '
        Me.BTNCerrar.AnimationHoverSpeed = 0.07!
        Me.BTNCerrar.AnimationSpeed = 0.03!
        Me.BTNCerrar.BaseColor = System.Drawing.Color.Transparent
        Me.BTNCerrar.BorderColor = System.Drawing.Color.Black
        Me.BTNCerrar.CheckedBaseColor = System.Drawing.Color.Red
        Me.BTNCerrar.CheckedBorderColor = System.Drawing.Color.Black
        Me.BTNCerrar.CheckedForeColor = System.Drawing.Color.White
        Me.BTNCerrar.CheckedImage = CType(resources.GetObject("BTNCerrar.CheckedImage"), System.Drawing.Image)
        Me.BTNCerrar.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BTNCerrar.FocusedColor = System.Drawing.Color.Empty
        Me.BTNCerrar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNCerrar.ForeColor = System.Drawing.Color.White
        Me.BTNCerrar.Image = CType(resources.GetObject("BTNCerrar.Image"), System.Drawing.Image)
        Me.BTNCerrar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BTNCerrar.ImageSize = New System.Drawing.Size(20, 20)
        Me.BTNCerrar.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTNCerrar.Location = New System.Drawing.Point(0, 0)
        Me.BTNCerrar.Name = "BTNCerrar"
        Me.BTNCerrar.OnHoverBaseColor = System.Drawing.Color.Red
        Me.BTNCerrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTNCerrar.OnHoverForeColor = System.Drawing.Color.White
        Me.BTNCerrar.OnHoverImage = Nothing
        Me.BTNCerrar.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTNCerrar.OnPressedColor = System.Drawing.Color.Black
        Me.BTNCerrar.Size = New System.Drawing.Size(54, 32)
        Me.BTNCerrar.TabIndex = 9
        '
        'BTNEntrar
        '
        Me.BTNEntrar.AnimationHoverSpeed = 0.07!
        Me.BTNEntrar.AnimationSpeed = 0.03!
        Me.BTNEntrar.BaseColor = System.Drawing.Color.MidnightBlue
        Me.BTNEntrar.BorderColor = System.Drawing.Color.Black
        Me.BTNEntrar.CheckedBaseColor = System.Drawing.Color.Gray
        Me.BTNEntrar.CheckedBorderColor = System.Drawing.Color.Black
        Me.BTNEntrar.CheckedForeColor = System.Drawing.Color.White
        Me.BTNEntrar.CheckedImage = CType(resources.GetObject("BTNEntrar.CheckedImage"), System.Drawing.Image)
        Me.BTNEntrar.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BTNEntrar.FocusedColor = System.Drawing.Color.Empty
        Me.BTNEntrar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNEntrar.ForeColor = System.Drawing.Color.White
        Me.BTNEntrar.Image = Nothing
        Me.BTNEntrar.ImageSize = New System.Drawing.Size(20, 20)
        Me.BTNEntrar.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTNEntrar.Location = New System.Drawing.Point(93, 316)
        Me.BTNEntrar.Name = "BTNEntrar"
        Me.BTNEntrar.OnHoverBaseColor = System.Drawing.Color.MediumBlue
        Me.BTNEntrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTNEntrar.OnHoverForeColor = System.Drawing.Color.White
        Me.BTNEntrar.OnHoverImage = Nothing
        Me.BTNEntrar.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTNEntrar.OnPressedColor = System.Drawing.Color.MediumBlue
        Me.BTNEntrar.Size = New System.Drawing.Size(180, 42)
        Me.BTNEntrar.TabIndex = 8
        Me.BTNEntrar.Text = "Entrar"
        Me.BTNEntrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(55, 218)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(67, 15)
        Me.GunaLabel3.TabIndex = 5
        Me.GunaLabel3.Text = "Contraseña"
        '
        'TXTContraseña
        '
        Me.TXTContraseña.BaseColor = System.Drawing.Color.White
        Me.TXTContraseña.BorderColor = System.Drawing.Color.Navy
        Me.TXTContraseña.BorderSize = 1
        Me.TXTContraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTContraseña.FocusedBaseColor = System.Drawing.Color.White
        Me.TXTContraseña.FocusedBorderColor = System.Drawing.Color.MediumBlue
        Me.TXTContraseña.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TXTContraseña.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTContraseña.Location = New System.Drawing.Point(55, 227)
        Me.TXTContraseña.Name = "TXTContraseña"
        Me.TXTContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTContraseña.Size = New System.Drawing.Size(264, 30)
        Me.TXTContraseña.TabIndex = 7
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(55, 132)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(47, 15)
        Me.GunaLabel2.TabIndex = 4
        Me.GunaLabel2.Text = "Usuario"
        '
        'TXTUsuario
        '
        Me.TXTUsuario.BaseColor = System.Drawing.Color.White
        Me.TXTUsuario.BorderColor = System.Drawing.Color.Navy
        Me.TXTUsuario.BorderSize = 1
        Me.TXTUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTUsuario.FocusedBaseColor = System.Drawing.Color.White
        Me.TXTUsuario.FocusedBorderColor = System.Drawing.Color.MediumBlue
        Me.TXTUsuario.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TXTUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTUsuario.Location = New System.Drawing.Point(55, 141)
        Me.TXTUsuario.Name = "TXTUsuario"
        Me.TXTUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTUsuario.Size = New System.Drawing.Size(264, 30)
        Me.TXTUsuario.TabIndex = 6
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Trebuchet MS", 22.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Navy
        Me.GunaLabel1.Location = New System.Drawing.Point(135, 30)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(93, 38)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Login"
        '
        'GunaPanel2
        '
        Me.GunaPanel2.Controls.Add(Me.GunaPictureBox1)
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaPanel2.Location = New System.Drawing.Point(382, 0)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(321, 402)
        Me.GunaPanel2.TabIndex = 1
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(321, 402)
        Me.GunaPictureBox1.TabIndex = 0
        Me.GunaPictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 402)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.GunaPanel2.ResumeLayout(False)
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents TXTUsuario As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BTNCerrar As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents BTNEntrar As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents TXTContraseña As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents LinkRegistro As Guna.UI.WinForms.GunaLinkLabel
End Class
