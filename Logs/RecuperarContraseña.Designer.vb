<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RecuperarContraseña
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecuperarContraseña))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.TXT_Recuperar = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.BTN_Enviar = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.labelresultado = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Guna2Panel1.Controls.Add(Me.GunaControlBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(467, 28)
        Me.Guna2Panel1.TabIndex = 0
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.IconColor = System.Drawing.Color.Black
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(422, 0)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(45, 28)
        Me.GunaControlBox1.TabIndex = 1
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.Guna2Panel1
        '
        'TXT_Recuperar
        '
        Me.TXT_Recuperar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Recuperar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Recuperar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_Recuperar.HintForeColor = System.Drawing.Color.Empty
        Me.TXT_Recuperar.HintText = ""
        Me.TXT_Recuperar.isPassword = False
        Me.TXT_Recuperar.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXT_Recuperar.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXT_Recuperar.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXT_Recuperar.LineThickness = 3
        Me.TXT_Recuperar.Location = New System.Drawing.Point(46, 86)
        Me.TXT_Recuperar.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_Recuperar.Name = "TXT_Recuperar"
        Me.TXT_Recuperar.Size = New System.Drawing.Size(370, 44)
        Me.TXT_Recuperar.TabIndex = 17
        Me.TXT_Recuperar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(46, 35)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(188, 21)
        Me.GunaLabel1.TabIndex = 18
        Me.GunaLabel1.Text = "Ingrese su Cedula o Email"
        '
        'BTN_Enviar
        '
        Me.BTN_Enviar.AnimationHoverSpeed = 0.07!
        Me.BTN_Enviar.AnimationSpeed = 0.03!
        Me.BTN_Enviar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BTN_Enviar.BorderColor = System.Drawing.Color.Black
        Me.BTN_Enviar.CheckedBaseColor = System.Drawing.Color.Green
        Me.BTN_Enviar.CheckedBorderColor = System.Drawing.Color.Black
        Me.BTN_Enviar.CheckedForeColor = System.Drawing.Color.White
        Me.BTN_Enviar.CheckedImage = CType(resources.GetObject("BTN_Enviar.CheckedImage"), System.Drawing.Image)
        Me.BTN_Enviar.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BTN_Enviar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTN_Enviar.FocusedColor = System.Drawing.Color.Empty
        Me.BTN_Enviar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_Enviar.ForeColor = System.Drawing.Color.White
        Me.BTN_Enviar.Image = Nothing
        Me.BTN_Enviar.ImageSize = New System.Drawing.Size(20, 20)
        Me.BTN_Enviar.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_Enviar.Location = New System.Drawing.Point(236, 146)
        Me.BTN_Enviar.Name = "BTN_Enviar"
        Me.BTN_Enviar.OnHoverBaseColor = System.Drawing.Color.Green
        Me.BTN_Enviar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTN_Enviar.OnHoverForeColor = System.Drawing.Color.White
        Me.BTN_Enviar.OnHoverImage = Nothing
        Me.BTN_Enviar.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTN_Enviar.OnPressedColor = System.Drawing.Color.Black
        Me.BTN_Enviar.Size = New System.Drawing.Size(180, 42)
        Me.BTN_Enviar.TabIndex = 19
        Me.BTN_Enviar.Text = "Enviar"
        Me.BTN_Enviar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelresultado
        '
        Me.labelresultado.AutoSize = True
        Me.labelresultado.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.labelresultado.ForeColor = System.Drawing.Color.Red
        Me.labelresultado.Location = New System.Drawing.Point(46, 203)
        Me.labelresultado.Name = "labelresultado"
        Me.labelresultado.Size = New System.Drawing.Size(59, 15)
        Me.labelresultado.TabIndex = 20
        Me.labelresultado.Text = "Resultado"
        '
        'RecuperarContraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 257)
        Me.Controls.Add(Me.labelresultado)
        Me.Controls.Add(Me.BTN_Enviar)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.TXT_Recuperar)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RecuperarContraseña"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RecuperarContraseña"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents TXT_Recuperar As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BTN_Enviar As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents labelresultado As Guna.UI.WinForms.GunaLabel
End Class
