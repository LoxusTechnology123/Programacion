<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.PanelModificado = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblerrores = New Guna.UI.WinForms.GunaLabel()
        Me.LBL_ConIn = New Guna.UI.WinForms.GunaLabel()
        Me.LBL_CIIn = New Guna.UI.WinForms.GunaLabel()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaLinkLabel2 = New Guna.UI.WinForms.GunaLinkLabel()
        Me.GunaLinkLabel1 = New Guna.UI.WinForms.GunaLinkLabel()
        Me.TXT_CI = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TXT_Contraseña = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BTN_Entrar = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelModificado.SuspendLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(566, -1)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(265, 446)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 0
        Me.GunaPictureBox1.TabStop = False
        '
        'PanelModificado
        '
        Me.PanelModificado.Controls.Add(Me.lblerrores)
        Me.PanelModificado.Controls.Add(Me.LBL_ConIn)
        Me.PanelModificado.Controls.Add(Me.LBL_CIIn)
        Me.PanelModificado.Controls.Add(Me.GunaControlBox2)
        Me.PanelModificado.Controls.Add(Me.GunaLinkLabel2)
        Me.PanelModificado.Controls.Add(Me.GunaLinkLabel1)
        Me.PanelModificado.Controls.Add(Me.TXT_CI)
        Me.PanelModificado.Controls.Add(Me.TXT_Contraseña)
        Me.PanelModificado.Controls.Add(Me.BTN_Entrar)
        Me.PanelModificado.Controls.Add(Me.GunaLabel2)
        Me.PanelModificado.Controls.Add(Me.GunaPictureBox2)
        Me.PanelModificado.Controls.Add(Me.GunaLabel1)
        Me.PanelModificado.Controls.Add(Me.GunaControlBox1)
        Me.PanelModificado.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelModificado.Location = New System.Drawing.Point(0, 0)
        Me.PanelModificado.Name = "PanelModificado"
        Me.PanelModificado.ShadowDecoration.Parent = Me.PanelModificado
        Me.PanelModificado.Size = New System.Drawing.Size(573, 444)
        Me.PanelModificado.TabIndex = 1
        '
        'lblerrores
        '
        Me.lblerrores.AutoSize = True
        Me.lblerrores.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblerrores.ForeColor = System.Drawing.Color.Red
        Me.lblerrores.Location = New System.Drawing.Point(342, 220)
        Me.lblerrores.Name = "lblerrores"
        Me.lblerrores.Size = New System.Drawing.Size(123, 15)
        Me.lblerrores.TabIndex = 22
        Me.lblerrores.Text = "Maximo de caracteres"
        '
        'LBL_ConIn
        '
        Me.LBL_ConIn.AutoSize = True
        Me.LBL_ConIn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LBL_ConIn.ForeColor = System.Drawing.Color.Red
        Me.LBL_ConIn.Location = New System.Drawing.Point(95, 297)
        Me.LBL_ConIn.Name = "LBL_ConIn"
        Me.LBL_ConIn.Size = New System.Drawing.Size(123, 15)
        Me.LBL_ConIn.TabIndex = 21
        Me.LBL_ConIn.Text = "Contraseña Incorrecta"
        '
        'LBL_CIIn
        '
        Me.LBL_CIIn.AutoSize = True
        Me.LBL_CIIn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LBL_CIIn.ForeColor = System.Drawing.Color.Red
        Me.LBL_CIIn.Location = New System.Drawing.Point(95, 220)
        Me.LBL_CIIn.Name = "LBL_CIIn"
        Me.LBL_CIIn.Size = New System.Drawing.Size(74, 15)
        Me.LBL_CIIn.TabIndex = 20
        Me.LBL_CIIn.Text = "CI Incorrecta"
        '
        'GunaControlBox2
        '
        Me.GunaControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox2.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox2.AnimationSpeed = 0.03!
        Me.GunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.GunaControlBox2.IconColor = System.Drawing.Color.Black
        Me.GunaControlBox2.IconSize = 15.0!
        Me.GunaControlBox2.Location = New System.Drawing.Point(42, -1)
        Me.GunaControlBox2.Name = "GunaControlBox2"
        Me.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.Transparent
        Me.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.Black
        Me.GunaControlBox2.OnPressedColor = System.Drawing.Color.Transparent
        Me.GunaControlBox2.Size = New System.Drawing.Size(45, 36)
        Me.GunaControlBox2.TabIndex = 19
        '
        'GunaLinkLabel2
        '
        Me.GunaLinkLabel2.AutoSize = True
        Me.GunaLinkLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLinkLabel2.Location = New System.Drawing.Point(306, 409)
        Me.GunaLinkLabel2.Name = "GunaLinkLabel2"
        Me.GunaLinkLabel2.Size = New System.Drawing.Size(159, 15)
        Me.GunaLinkLabel2.TabIndex = 18
        Me.GunaLinkLabel2.TabStop = True
        Me.GunaLinkLabel2.Text = "¿No tienes cuenta? click aquí"
        '
        'GunaLinkLabel1
        '
        Me.GunaLinkLabel1.AutoSize = True
        Me.GunaLinkLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLinkLabel1.Location = New System.Drawing.Point(112, 409)
        Me.GunaLinkLabel1.Name = "GunaLinkLabel1"
        Me.GunaLinkLabel1.Size = New System.Drawing.Size(143, 15)
        Me.GunaLinkLabel1.TabIndex = 17
        Me.GunaLinkLabel1.TabStop = True
        Me.GunaLinkLabel1.Text = "¿Olvidaste tu Contraseña?"
        '
        'TXT_CI
        '
        Me.TXT_CI.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CI.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_CI.HintForeColor = System.Drawing.Color.Empty
        Me.TXT_CI.HintText = "Cedula de Identidad"
        Me.TXT_CI.isPassword = False
        Me.TXT_CI.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXT_CI.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXT_CI.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXT_CI.LineThickness = 3
        Me.TXT_CI.Location = New System.Drawing.Point(95, 172)
        Me.TXT_CI.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_CI.Name = "TXT_CI"
        Me.TXT_CI.Size = New System.Drawing.Size(370, 44)
        Me.TXT_CI.TabIndex = 16
        Me.TXT_CI.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TXT_Contraseña
        '
        Me.TXT_Contraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Contraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TXT_Contraseña.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_Contraseña.HintForeColor = System.Drawing.Color.Empty
        Me.TXT_Contraseña.HintText = ""
        Me.TXT_Contraseña.isPassword = True
        Me.TXT_Contraseña.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXT_Contraseña.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXT_Contraseña.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXT_Contraseña.LineThickness = 3
        Me.TXT_Contraseña.Location = New System.Drawing.Point(95, 249)
        Me.TXT_Contraseña.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_Contraseña.Name = "TXT_Contraseña"
        Me.TXT_Contraseña.Size = New System.Drawing.Size(370, 44)
        Me.TXT_Contraseña.TabIndex = 15
        Me.TXT_Contraseña.Text = "Contraseña"
        Me.TXT_Contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTN_Entrar
        '
        Me.BTN_Entrar.AnimationHoverSpeed = 0.07!
        Me.BTN_Entrar.AnimationSpeed = 0.03!
        Me.BTN_Entrar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
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
        Me.BTN_Entrar.Location = New System.Drawing.Point(192, 354)
        Me.BTN_Entrar.Name = "BTN_Entrar"
        Me.BTN_Entrar.OnHoverBaseColor = System.Drawing.Color.Green
        Me.BTN_Entrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTN_Entrar.OnHoverForeColor = System.Drawing.Color.White
        Me.BTN_Entrar.OnHoverImage = Nothing
        Me.BTN_Entrar.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_Entrar.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_Entrar.Size = New System.Drawing.Size(180, 42)
        Me.BTN_Entrar.TabIndex = 11
        Me.BTN_Entrar.Text = "Entrar"
        Me.BTN_Entrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel2.Location = New System.Drawing.Point(95, 113)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(249, 15)
        Me.GunaLabel2.TabIndex = 9
        Me.GunaLabel2.Text = "Gracias por elegirnos, le brindaremos lo mejor"
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Image = CType(resources.GetObject("GunaPictureBox2.Image"), System.Drawing.Image)
        Me.GunaPictureBox2.Location = New System.Drawing.Point(517, 395)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(56, 50)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox2.TabIndex = 1
        Me.GunaPictureBox2.TabStop = False
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Cambria", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(91, 45)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(259, 41)
        Me.GunaLabel1.TabIndex = 2
        Me.GunaLabel1.Text = "INICIAR SESIÓN"
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
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.Red
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.Black
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Red
        Me.GunaControlBox1.Size = New System.Drawing.Size(45, 35)
        Me.GunaControlBox1.TabIndex = 0
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.PanelModificado
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 444)
        Me.Controls.Add(Me.PanelModificado)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelModificado.ResumeLayout(False)
        Me.PanelModificado.PerformLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents PanelModificado As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLinkLabel2 As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents GunaLinkLabel1 As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents TXT_CI As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TXT_Contraseña As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BTN_Entrar As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents LBL_ConIn As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LBL_CIIn As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblerrores As Guna.UI.WinForms.GunaLabel
End Class
