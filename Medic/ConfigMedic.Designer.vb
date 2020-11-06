<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigMedic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfigMedic))
        Me.labelpuerta = New Guna.UI.WinForms.GunaLabel()
        Me.labelciudad = New Guna.UI.WinForms.GunaLabel()
        Me.labelcalle = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.labelcargo = New Guna.UI.WinForms.GunaLabel()
        Me.labelcorreo = New Guna.UI.WinForms.GunaLabel()
        Me.labelapellido = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.labelnombre = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelpuerta
        '
        Me.labelpuerta.AutoSize = True
        Me.labelpuerta.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.labelpuerta.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelpuerta.Location = New System.Drawing.Point(744, 386)
        Me.labelpuerta.Name = "labelpuerta"
        Me.labelpuerta.Size = New System.Drawing.Size(47, 21)
        Me.labelpuerta.TabIndex = 47
        Me.labelpuerta.Text = "Calle:"
        '
        'labelciudad
        '
        Me.labelciudad.AutoSize = True
        Me.labelciudad.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.labelciudad.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelciudad.Location = New System.Drawing.Point(744, 333)
        Me.labelciudad.Name = "labelciudad"
        Me.labelciudad.Size = New System.Drawing.Size(47, 21)
        Me.labelciudad.TabIndex = 46
        Me.labelciudad.Text = "Calle:"
        '
        'labelcalle
        '
        Me.labelcalle.AutoSize = True
        Me.labelcalle.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.labelcalle.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelcalle.Location = New System.Drawing.Point(744, 280)
        Me.labelcalle.Name = "labelcalle"
        Me.labelcalle.Size = New System.Drawing.Size(47, 21)
        Me.labelcalle.TabIndex = 45
        Me.labelcalle.Text = "Calle:"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GunaLabel8.Location = New System.Drawing.Point(638, 386)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(89, 21)
        Me.GunaLabel8.TabIndex = 44
        Me.GunaLabel8.Text = "Nro Puerta:"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GunaLabel7.Location = New System.Drawing.Point(639, 333)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(62, 21)
        Me.GunaLabel7.TabIndex = 43
        Me.GunaLabel7.Text = "Ciudad:"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GunaLabel3.Location = New System.Drawing.Point(638, 280)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(47, 21)
        Me.GunaLabel3.TabIndex = 42
        Me.GunaLabel3.Text = "Calle:"
        '
        'Guna2ComboBox1
        '
        Me.Guna2ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox1.FocusedColor = System.Drawing.Color.Empty
        Me.Guna2ComboBox1.FocusedState.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox1.FormattingEnabled = True
        Me.Guna2ComboBox1.HoverState.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.ItemHeight = 30
        Me.Guna2ComboBox1.ItemsAppearance.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.Location = New System.Drawing.Point(298, 555)
        Me.Guna2ComboBox1.Name = "Guna2ComboBox1"
        Me.Guna2ComboBox1.ShadowDecoration.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.Size = New System.Drawing.Size(170, 36)
        Me.Guna2ComboBox1.TabIndex = 41
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GunaLabel1.Location = New System.Drawing.Point(180, 555)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(85, 28)
        Me.GunaLabel1.TabIndex = 40
        Me.GunaLabel1.Text = "Idiomas:"
        '
        'labelcargo
        '
        Me.labelcargo.AutoSize = True
        Me.labelcargo.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.labelcargo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelcargo.Location = New System.Drawing.Point(744, 220)
        Me.labelcargo.Name = "labelcargo"
        Me.labelcargo.Size = New System.Drawing.Size(49, 20)
        Me.labelcargo.TabIndex = 39
        Me.labelcargo.Text = "Cargo"
        '
        'labelcorreo
        '
        Me.labelcorreo.AutoSize = True
        Me.labelcorreo.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.labelcorreo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelcorreo.Location = New System.Drawing.Point(744, 167)
        Me.labelcorreo.Name = "labelcorreo"
        Me.labelcorreo.Size = New System.Drawing.Size(54, 20)
        Me.labelcorreo.TabIndex = 38
        Me.labelcorreo.Text = "Correo"
        '
        'labelapellido
        '
        Me.labelapellido.AutoSize = True
        Me.labelapellido.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.labelapellido.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelapellido.Location = New System.Drawing.Point(744, 113)
        Me.labelapellido.Name = "labelapellido"
        Me.labelapellido.Size = New System.Drawing.Size(66, 20)
        Me.labelapellido.TabIndex = 37
        Me.labelapellido.Text = "Apellido"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GunaLabel6.Location = New System.Drawing.Point(639, 221)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(55, 21)
        Me.GunaLabel6.TabIndex = 36
        Me.GunaLabel6.Text = "Cargo:"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GunaLabel5.Location = New System.Drawing.Point(639, 167)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(51, 21)
        Me.GunaLabel5.TabIndex = 35
        Me.GunaLabel5.Text = "Email:"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GunaLabel4.Location = New System.Drawing.Point(639, 113)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(70, 21)
        Me.GunaLabel4.TabIndex = 34
        Me.GunaLabel4.Text = "Apellido:"
        '
        'labelnombre
        '
        Me.labelnombre.AutoSize = True
        Me.labelnombre.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.labelnombre.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelnombre.Location = New System.Drawing.Point(744, 59)
        Me.labelnombre.Name = "labelnombre"
        Me.labelnombre.Size = New System.Drawing.Size(64, 20)
        Me.labelnombre.TabIndex = 33
        Me.labelnombre.Text = "Nombre"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GunaLabel2.Location = New System.Drawing.Point(638, 59)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(71, 21)
        Me.GunaLabel2.TabIndex = 32
        Me.GunaLabel2.Text = "Nombre:"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(185, 167)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(225, 225)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Guna2CirclePictureBox1.TabIndex = 31
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'ConfigMedic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(990, 650)
        Me.Controls.Add(Me.labelpuerta)
        Me.Controls.Add(Me.labelciudad)
        Me.Controls.Add(Me.labelcalle)
        Me.Controls.Add(Me.GunaLabel8)
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.Guna2ComboBox1)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.labelcargo)
        Me.Controls.Add(Me.labelcorreo)
        Me.Controls.Add(Me.labelapellido)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.labelnombre)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ConfigMedic"
        Me.Text = "ConfigMedic"
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelpuerta As Guna.UI.WinForms.GunaLabel
    Friend WithEvents labelciudad As Guna.UI.WinForms.GunaLabel
    Friend WithEvents labelcalle As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents labelcargo As Guna.UI.WinForms.GunaLabel
    Friend WithEvents labelcorreo As Guna.UI.WinForms.GunaLabel
    Friend WithEvents labelapellido As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents labelnombre As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
End Class
