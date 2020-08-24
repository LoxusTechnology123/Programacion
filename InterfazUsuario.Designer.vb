<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InterfazUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InterfazUsuario))
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.BTNSalir = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BTNActividad = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BTNChat = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BTNPatologias = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BTNSintomas = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaTransfarantPictureBox1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.Panelcontenedor = New Guna.UI.WinForms.GunaPanel()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.TXTDiagnostico = New Guna.UI.WinForms.GunaTextBox()
        Me.Combo3 = New Guna.UI.WinForms.GunaComboBox()
        Me.Combo2 = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Combo1 = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelcontenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.MediumBlue
        Me.GunaPanel1.Controls.Add(Me.BTNSalir)
        Me.GunaPanel1.Controls.Add(Me.BTNActividad)
        Me.GunaPanel1.Controls.Add(Me.BTNChat)
        Me.GunaPanel1.Controls.Add(Me.BTNPatologias)
        Me.GunaPanel1.Controls.Add(Me.BTNSintomas)
        Me.GunaPanel1.Controls.Add(Me.GunaTransfarantPictureBox1)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(120, 700)
        Me.GunaPanel1.TabIndex = 0
        '
        'BTNSalir
        '
        Me.BTNSalir.AnimationHoverSpeed = 0.07!
        Me.BTNSalir.AnimationSpeed = 0.03!
        Me.BTNSalir.BaseColor = System.Drawing.Color.MediumBlue
        Me.BTNSalir.BorderColor = System.Drawing.Color.Black
        Me.BTNSalir.CheckedBaseColor = System.Drawing.Color.Gray
        Me.BTNSalir.CheckedBorderColor = System.Drawing.Color.Black
        Me.BTNSalir.CheckedForeColor = System.Drawing.Color.White
        Me.BTNSalir.CheckedImage = CType(resources.GetObject("BTNSalir.CheckedImage"), System.Drawing.Image)
        Me.BTNSalir.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BTNSalir.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTNSalir.FocusedColor = System.Drawing.Color.Empty
        Me.BTNSalir.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSalir.ForeColor = System.Drawing.Color.White
        Me.BTNSalir.Image = CType(resources.GetObject("BTNSalir.Image"), System.Drawing.Image)
        Me.BTNSalir.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BTNSalir.ImageSize = New System.Drawing.Size(32, 32)
        Me.BTNSalir.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTNSalir.Location = New System.Drawing.Point(0, 641)
        Me.BTNSalir.Name = "BTNSalir"
        Me.BTNSalir.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNSalir.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTNSalir.OnHoverForeColor = System.Drawing.Color.White
        Me.BTNSalir.OnHoverImage = Nothing
        Me.BTNSalir.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTNSalir.OnPressedColor = System.Drawing.Color.Black
        Me.BTNSalir.Size = New System.Drawing.Size(122, 59)
        Me.BTNSalir.TabIndex = 4
        '
        'BTNActividad
        '
        Me.BTNActividad.AnimationHoverSpeed = 0.07!
        Me.BTNActividad.AnimationSpeed = 0.03!
        Me.BTNActividad.BaseColor = System.Drawing.Color.MediumBlue
        Me.BTNActividad.BorderColor = System.Drawing.Color.Black
        Me.BTNActividad.CheckedBaseColor = System.Drawing.Color.Gray
        Me.BTNActividad.CheckedBorderColor = System.Drawing.Color.Black
        Me.BTNActividad.CheckedForeColor = System.Drawing.Color.White
        Me.BTNActividad.CheckedImage = CType(resources.GetObject("BTNActividad.CheckedImage"), System.Drawing.Image)
        Me.BTNActividad.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BTNActividad.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTNActividad.FocusedColor = System.Drawing.Color.Empty
        Me.BTNActividad.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNActividad.ForeColor = System.Drawing.Color.White
        Me.BTNActividad.Image = CType(resources.GetObject("BTNActividad.Image"), System.Drawing.Image)
        Me.BTNActividad.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BTNActividad.ImageSize = New System.Drawing.Size(32, 32)
        Me.BTNActividad.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTNActividad.Location = New System.Drawing.Point(1, 441)
        Me.BTNActividad.Name = "BTNActividad"
        Me.BTNActividad.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNActividad.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTNActividad.OnHoverForeColor = System.Drawing.Color.White
        Me.BTNActividad.OnHoverImage = Nothing
        Me.BTNActividad.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTNActividad.OnPressedColor = System.Drawing.Color.Black
        Me.BTNActividad.Size = New System.Drawing.Size(122, 59)
        Me.BTNActividad.TabIndex = 2
        '
        'BTNChat
        '
        Me.BTNChat.AnimationHoverSpeed = 0.07!
        Me.BTNChat.AnimationSpeed = 0.03!
        Me.BTNChat.BaseColor = System.Drawing.Color.MediumBlue
        Me.BTNChat.BorderColor = System.Drawing.Color.Black
        Me.BTNChat.CheckedBaseColor = System.Drawing.Color.Gray
        Me.BTNChat.CheckedBorderColor = System.Drawing.Color.Black
        Me.BTNChat.CheckedForeColor = System.Drawing.Color.White
        Me.BTNChat.CheckedImage = CType(resources.GetObject("BTNChat.CheckedImage"), System.Drawing.Image)
        Me.BTNChat.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BTNChat.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTNChat.FocusedColor = System.Drawing.Color.Empty
        Me.BTNChat.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNChat.ForeColor = System.Drawing.Color.White
        Me.BTNChat.Image = CType(resources.GetObject("BTNChat.Image"), System.Drawing.Image)
        Me.BTNChat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BTNChat.ImageSize = New System.Drawing.Size(32, 32)
        Me.BTNChat.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTNChat.Location = New System.Drawing.Point(0, 381)
        Me.BTNChat.Name = "BTNChat"
        Me.BTNChat.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNChat.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTNChat.OnHoverForeColor = System.Drawing.Color.White
        Me.BTNChat.OnHoverImage = Nothing
        Me.BTNChat.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTNChat.OnPressedColor = System.Drawing.Color.Black
        Me.BTNChat.Size = New System.Drawing.Size(122, 59)
        Me.BTNChat.TabIndex = 2
        '
        'BTNPatologias
        '
        Me.BTNPatologias.AnimationHoverSpeed = 0.07!
        Me.BTNPatologias.AnimationSpeed = 0.03!
        Me.BTNPatologias.BaseColor = System.Drawing.Color.DarkBlue
        Me.BTNPatologias.BorderColor = System.Drawing.Color.Black
        Me.BTNPatologias.CheckedBaseColor = System.Drawing.Color.Gray
        Me.BTNPatologias.CheckedBorderColor = System.Drawing.Color.Black
        Me.BTNPatologias.CheckedForeColor = System.Drawing.Color.White
        Me.BTNPatologias.CheckedImage = CType(resources.GetObject("BTNPatologias.CheckedImage"), System.Drawing.Image)
        Me.BTNPatologias.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BTNPatologias.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTNPatologias.FocusedColor = System.Drawing.Color.Empty
        Me.BTNPatologias.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNPatologias.ForeColor = System.Drawing.Color.White
        Me.BTNPatologias.Image = CType(resources.GetObject("BTNPatologias.Image"), System.Drawing.Image)
        Me.BTNPatologias.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BTNPatologias.ImageSize = New System.Drawing.Size(32, 32)
        Me.BTNPatologias.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTNPatologias.Location = New System.Drawing.Point(0, 321)
        Me.BTNPatologias.Name = "BTNPatologias"
        Me.BTNPatologias.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNPatologias.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTNPatologias.OnHoverForeColor = System.Drawing.Color.White
        Me.BTNPatologias.OnHoverImage = Nothing
        Me.BTNPatologias.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTNPatologias.OnPressedColor = System.Drawing.Color.Black
        Me.BTNPatologias.Size = New System.Drawing.Size(122, 59)
        Me.BTNPatologias.TabIndex = 3
        '
        'BTNSintomas
        '
        Me.BTNSintomas.AnimationHoverSpeed = 0.07!
        Me.BTNSintomas.AnimationSpeed = 0.03!
        Me.BTNSintomas.BaseColor = System.Drawing.Color.MediumBlue
        Me.BTNSintomas.BorderColor = System.Drawing.Color.Black
        Me.BTNSintomas.CheckedBaseColor = System.Drawing.Color.Gray
        Me.BTNSintomas.CheckedBorderColor = System.Drawing.Color.Black
        Me.BTNSintomas.CheckedForeColor = System.Drawing.Color.White
        Me.BTNSintomas.CheckedImage = CType(resources.GetObject("BTNSintomas.CheckedImage"), System.Drawing.Image)
        Me.BTNSintomas.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BTNSintomas.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTNSintomas.FocusedColor = System.Drawing.Color.Empty
        Me.BTNSintomas.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSintomas.ForeColor = System.Drawing.Color.White
        Me.BTNSintomas.Image = CType(resources.GetObject("BTNSintomas.Image"), System.Drawing.Image)
        Me.BTNSintomas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BTNSintomas.ImageSize = New System.Drawing.Size(32, 32)
        Me.BTNSintomas.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTNSintomas.Location = New System.Drawing.Point(1, 330)
        Me.BTNSintomas.Name = "BTNSintomas"
        Me.BTNSintomas.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNSintomas.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTNSintomas.OnHoverForeColor = System.Drawing.Color.White
        Me.BTNSintomas.OnHoverImage = Nothing
        Me.BTNSintomas.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTNSintomas.OnPressedColor = System.Drawing.Color.Black
        Me.BTNSintomas.Size = New System.Drawing.Size(122, 59)
        Me.BTNSintomas.TabIndex = 1
        '
        'GunaTransfarantPictureBox1
        '
        Me.GunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox1.Image = CType(resources.GetObject("GunaTransfarantPictureBox1.Image"), System.Drawing.Image)
        Me.GunaTransfarantPictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.GunaTransfarantPictureBox1.Name = "GunaTransfarantPictureBox1"
        Me.GunaTransfarantPictureBox1.Size = New System.Drawing.Size(120, 283)
        Me.GunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.GunaTransfarantPictureBox1.TabIndex = 2
        Me.GunaTransfarantPictureBox1.TabStop = False
        '
        'Panelcontenedor
        '
        Me.Panelcontenedor.Controls.Add(Me.GunaAdvenceButton1)
        Me.Panelcontenedor.Controls.Add(Me.TXTDiagnostico)
        Me.Panelcontenedor.Controls.Add(Me.Combo3)
        Me.Panelcontenedor.Controls.Add(Me.Combo2)
        Me.Panelcontenedor.Controls.Add(Me.GunaLabel1)
        Me.Panelcontenedor.Controls.Add(Me.Combo1)
        Me.Panelcontenedor.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panelcontenedor.Location = New System.Drawing.Point(117, 0)
        Me.Panelcontenedor.Name = "Panelcontenedor"
        Me.Panelcontenedor.Size = New System.Drawing.Size(1063, 700)
        Me.Panelcontenedor.TabIndex = 1
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.DarkSlateGray
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.Image = Nothing
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(466, 589)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(180, 42)
        Me.GunaAdvenceButton1.TabIndex = 5
        Me.GunaAdvenceButton1.Text = "Obtener patología"
        Me.GunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTDiagnostico
        '
        Me.TXTDiagnostico.BaseColor = System.Drawing.Color.White
        Me.TXTDiagnostico.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.TXTDiagnostico.BorderSize = 1
        Me.TXTDiagnostico.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTDiagnostico.FocusedBaseColor = System.Drawing.Color.White
        Me.TXTDiagnostico.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTDiagnostico.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TXTDiagnostico.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTDiagnostico.Location = New System.Drawing.Point(281, 411)
        Me.TXTDiagnostico.Name = "TXTDiagnostico"
        Me.TXTDiagnostico.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTDiagnostico.SelectedText = ""
        Me.TXTDiagnostico.Size = New System.Drawing.Size(543, 130)
        Me.TXTDiagnostico.TabIndex = 4
        '
        'Combo3
        '
        Me.Combo3.BackColor = System.Drawing.Color.Transparent
        Me.Combo3.BaseColor = System.Drawing.Color.White
        Me.Combo3.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.Combo3.BorderSize = 1
        Me.Combo3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Combo3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo3.FocusedColor = System.Drawing.Color.Empty
        Me.Combo3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Combo3.ForeColor = System.Drawing.Color.Black
        Me.Combo3.FormattingEnabled = True
        Me.Combo3.Location = New System.Drawing.Point(796, 224)
        Me.Combo3.Name = "Combo3"
        Me.Combo3.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Combo3.OnHoverItemForeColor = System.Drawing.Color.White
        Me.Combo3.Size = New System.Drawing.Size(201, 26)
        Me.Combo3.TabIndex = 3
        '
        'Combo2
        '
        Me.Combo2.BackColor = System.Drawing.Color.Transparent
        Me.Combo2.BaseColor = System.Drawing.Color.White
        Me.Combo2.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.Combo2.BorderSize = 1
        Me.Combo2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Combo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo2.FocusedColor = System.Drawing.Color.Empty
        Me.Combo2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Combo2.ForeColor = System.Drawing.Color.Black
        Me.Combo2.FormattingEnabled = True
        Me.Combo2.Location = New System.Drawing.Point(445, 224)
        Me.Combo2.Name = "Combo2"
        Me.Combo2.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Combo2.OnHoverItemForeColor = System.Drawing.Color.White
        Me.Combo2.Size = New System.Drawing.Size(201, 26)
        Me.Combo2.TabIndex = 2
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Verdana", 29.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(437, 53)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(224, 47)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Sintomas"
        '
        'Combo1
        '
        Me.Combo1.BackColor = System.Drawing.Color.Transparent
        Me.Combo1.BaseColor = System.Drawing.Color.White
        Me.Combo1.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.Combo1.BorderSize = 1
        Me.Combo1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo1.FocusedColor = System.Drawing.Color.Empty
        Me.Combo1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Combo1.ForeColor = System.Drawing.Color.Black
        Me.Combo1.FormattingEnabled = True
        Me.Combo1.Location = New System.Drawing.Point(84, 224)
        Me.Combo1.Name = "Combo1"
        Me.Combo1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Combo1.OnHoverItemForeColor = System.Drawing.Color.White
        Me.Combo1.Size = New System.Drawing.Size(201, 26)
        Me.Combo1.TabIndex = 0
        '
        'InterfazUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1180, 700)
        Me.Controls.Add(Me.Panelcontenedor)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InterfazUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InterfazUsuario"
        Me.GunaPanel1.ResumeLayout(False)
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelcontenedor.ResumeLayout(False)
        Me.Panelcontenedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaTransfarantPictureBox1 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents BTNSalir As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents BTNActividad As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents BTNChat As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents BTNPatologias As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents BTNSintomas As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Panelcontenedor As Guna.UI.WinForms.GunaPanel
    Friend WithEvents TXTDiagnostico As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Combo3 As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Combo2 As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Combo1 As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
End Class
