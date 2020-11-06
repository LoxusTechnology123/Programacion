<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChatMedic
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChatMedic))
        Me.BTN_Entrar = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.TXT_CIChat = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaVSeparator3 = New Guna.UI.WinForms.GunaVSeparator()
        Me.TXTChat = New Guna.UI.WinForms.GunaTextBox()
        Me.Guna2Separator4 = New Guna.UI2.WinForms.Guna2Separator()
        Me.BTNEnviarMensaje = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BTNEnviar = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.PanelChat = New Guna.UI2.WinForms.Guna2Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.labelinfo = New Guna.UI.WinForms.GunaLabel()
        Me.PanelChat.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTN_Entrar
        '
        Me.BTN_Entrar.AnimationHoverSpeed = 0.07!
        Me.BTN_Entrar.AnimationSpeed = 0.03!
        Me.BTN_Entrar.BaseColor = System.Drawing.Color.Black
        Me.BTN_Entrar.BorderColor = System.Drawing.Color.Black
        Me.BTN_Entrar.CheckedBaseColor = System.Drawing.Color.Green
        Me.BTN_Entrar.CheckedBorderColor = System.Drawing.Color.Black
        Me.BTN_Entrar.CheckedForeColor = System.Drawing.Color.White
        Me.BTN_Entrar.CheckedImage = CType(resources.GetObject("BTN_Entrar.CheckedImage"), System.Drawing.Image)
        Me.BTN_Entrar.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BTN_Entrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_Entrar.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_Entrar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_Entrar.ForeColor = System.Drawing.Color.White
        Me.BTN_Entrar.Image = Nothing
        Me.BTN_Entrar.ImageSize = New System.Drawing.Size(20, 20)
        Me.BTN_Entrar.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_Entrar.Location = New System.Drawing.Point(14, 544)
        Me.BTN_Entrar.Name = "BTN_Entrar"
        Me.BTN_Entrar.OnHoverBaseColor = System.Drawing.Color.Green
        Me.BTN_Entrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTN_Entrar.OnHoverForeColor = System.Drawing.Color.White
        Me.BTN_Entrar.OnHoverImage = Nothing
        Me.BTN_Entrar.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_Entrar.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_Entrar.Size = New System.Drawing.Size(190, 42)
        Me.BTN_Entrar.TabIndex = 46
        Me.BTN_Entrar.Text = "Limpiar chat"
        Me.BTN_Entrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_CIChat
        '
        Me.TXT_CIChat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CIChat.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CIChat.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TXT_CIChat.HintForeColor = System.Drawing.Color.Empty
        Me.TXT_CIChat.HintText = "Cedula de Identidad"
        Me.TXT_CIChat.isPassword = False
        Me.TXT_CIChat.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXT_CIChat.LineIdleColor = System.Drawing.Color.Black
        Me.TXT_CIChat.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXT_CIChat.LineThickness = 3
        Me.TXT_CIChat.Location = New System.Drawing.Point(14, 168)
        Me.TXT_CIChat.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_CIChat.Name = "TXT_CIChat"
        Me.TXT_CIChat.Size = New System.Drawing.Size(190, 44)
        Me.TXT_CIChat.TabIndex = 45
        Me.TXT_CIChat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GunaLabel2.Location = New System.Drawing.Point(43, 76)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(121, 50)
        Me.GunaLabel2.TabIndex = 44
        Me.GunaLabel2.Text = "Ingrese la CI " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del Paciente"
        Me.GunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaVSeparator3
        '
        Me.GunaVSeparator3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaVSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.GunaVSeparator3.Location = New System.Drawing.Point(211, -15)
        Me.GunaVSeparator3.Name = "GunaVSeparator3"
        Me.GunaVSeparator3.Size = New System.Drawing.Size(14, 681)
        Me.GunaVSeparator3.TabIndex = 41
        '
        'TXTChat
        '
        Me.TXTChat.BackColor = System.Drawing.Color.Transparent
        Me.TXTChat.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.TXTChat.BorderColor = System.Drawing.Color.Silver
        Me.TXTChat.BorderSize = 1
        Me.TXTChat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTChat.FocusedBaseColor = System.Drawing.Color.White
        Me.TXTChat.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTChat.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TXTChat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXTChat.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TXTChat.Location = New System.Drawing.Point(10, 3)
        Me.TXTChat.Name = "TXTChat"
        Me.TXTChat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTChat.Radius = 3
        Me.TXTChat.SelectedText = ""
        Me.TXTChat.Size = New System.Drawing.Size(814, 559)
        Me.TXTChat.TabIndex = 42
        '
        'Guna2Separator4
        '
        Me.Guna2Separator4.FillColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Guna2Separator4.Location = New System.Drawing.Point(6, 51)
        Me.Guna2Separator4.Name = "Guna2Separator4"
        Me.Guna2Separator4.Size = New System.Drawing.Size(199, 10)
        Me.Guna2Separator4.TabIndex = 40
        '
        'BTNEnviarMensaje
        '
        Me.BTNEnviarMensaje.AnimationHoverSpeed = 0.07!
        Me.BTNEnviarMensaje.AnimationSpeed = 0.03!
        Me.BTNEnviarMensaje.BackColor = System.Drawing.Color.Transparent
        Me.BTNEnviarMensaje.BaseColor = System.Drawing.Color.DarkSlateGray
        Me.BTNEnviarMensaje.BorderColor = System.Drawing.Color.Black
        Me.BTNEnviarMensaje.CheckedBaseColor = System.Drawing.Color.Gray
        Me.BTNEnviarMensaje.CheckedBorderColor = System.Drawing.Color.Black
        Me.BTNEnviarMensaje.CheckedForeColor = System.Drawing.Color.White
        Me.BTNEnviarMensaje.CheckedImage = CType(resources.GetObject("BTNEnviarMensaje.CheckedImage"), System.Drawing.Image)
        Me.BTNEnviarMensaje.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BTNEnviarMensaje.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTNEnviarMensaje.FocusedColor = System.Drawing.Color.Empty
        Me.BTNEnviarMensaje.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNEnviarMensaje.ForeColor = System.Drawing.Color.White
        Me.BTNEnviarMensaje.Image = CType(resources.GetObject("BTNEnviarMensaje.Image"), System.Drawing.Image)
        Me.BTNEnviarMensaje.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BTNEnviarMensaje.ImageSize = New System.Drawing.Size(20, 20)
        Me.BTNEnviarMensaje.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTNEnviarMensaje.Location = New System.Drawing.Point(900, 575)
        Me.BTNEnviarMensaje.Name = "BTNEnviarMensaje"
        Me.BTNEnviarMensaje.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNEnviarMensaje.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTNEnviarMensaje.OnHoverForeColor = System.Drawing.Color.White
        Me.BTNEnviarMensaje.OnHoverImage = Nothing
        Me.BTNEnviarMensaje.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTNEnviarMensaje.OnPressedColor = System.Drawing.Color.Black
        Me.BTNEnviarMensaje.Radius = 3
        Me.BTNEnviarMensaje.Size = New System.Drawing.Size(72, 50)
        Me.BTNEnviarMensaje.TabIndex = 39
        '
        'BTNEnviar
        '
        Me.BTNEnviar.BackColor = System.Drawing.Color.Transparent
        Me.BTNEnviar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.BTNEnviar.BorderColor = System.Drawing.Color.Silver
        Me.BTNEnviar.BorderSize = 1
        Me.BTNEnviar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BTNEnviar.FocusedBaseColor = System.Drawing.Color.White
        Me.BTNEnviar.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNEnviar.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.BTNEnviar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNEnviar.Location = New System.Drawing.Point(231, 575)
        Me.BTNEnviar.Name = "BTNEnviar"
        Me.BTNEnviar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BTNEnviar.Radius = 3
        Me.BTNEnviar.SelectedText = ""
        Me.BTNEnviar.Size = New System.Drawing.Size(642, 50)
        Me.BTNEnviar.TabIndex = 38
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Verdana", 29.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GunaLabel1.Location = New System.Drawing.Point(6, 1)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(120, 47)
        Me.GunaLabel1.TabIndex = 37
        Me.GunaLabel1.Text = "Chat"
        '
        'PanelChat
        '
        Me.PanelChat.Controls.Add(Me.TXTChat)
        Me.PanelChat.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelChat.Location = New System.Drawing.Point(221, 0)
        Me.PanelChat.Name = "PanelChat"
        Me.PanelChat.ShadowDecoration.Parent = Me.PanelChat
        Me.PanelChat.Size = New System.Drawing.Size(769, 650)
        Me.PanelChat.TabIndex = 43
        '
        'Timer1
        '
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.labelinfo)
        Me.Guna2Panel1.Controls.Add(Me.GunaLabel3)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(14, 415)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(190, 100)
        Me.Guna2Panel1.TabIndex = 47
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.GunaLabel3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GunaLabel3.Location = New System.Drawing.Point(57, 10)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(81, 20)
        Me.GunaLabel3.TabIndex = 48
        Me.GunaLabel3.Text = "Solicitudes"
        '
        'labelinfo
        '
        Me.labelinfo.AutoSize = True
        Me.labelinfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.labelinfo.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.labelinfo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelinfo.Location = New System.Drawing.Point(57, 49)
        Me.labelinfo.Name = "labelinfo"
        Me.labelinfo.Size = New System.Drawing.Size(81, 20)
        Me.labelinfo.TabIndex = 49
        Me.labelinfo.Text = "Solicitudes"
        '
        'ChatMedic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(990, 650)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.BTN_Entrar)
        Me.Controls.Add(Me.TXT_CIChat)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaVSeparator3)
        Me.Controls.Add(Me.Guna2Separator4)
        Me.Controls.Add(Me.BTNEnviarMensaje)
        Me.Controls.Add(Me.BTNEnviar)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.PanelChat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ChatMedic"
        Me.Text = "ChatMedic"
        Me.PanelChat.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_Entrar As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents TXT_CIChat As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaVSeparator3 As Guna.UI.WinForms.GunaVSeparator
    Friend WithEvents TXTChat As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Guna2Separator4 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents BTNEnviarMensaje As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents BTNEnviar As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PanelChat As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents labelinfo As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
End Class
