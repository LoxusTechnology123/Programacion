<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PacienteAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PacienteAdd))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtpuerta = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtciudad = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtcalle = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtcontraseña = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtcorreo = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtapelido = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtnombre = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TXT_ci = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GunaAdvenceButton3 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.DataMedico = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        CType(Me.DataMedico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtpuerta
        '
        Me.txtpuerta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpuerta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtpuerta.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtpuerta.HintForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtpuerta.HintText = "Numero de Puerta"
        Me.txtpuerta.isPassword = False
        Me.txtpuerta.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtpuerta.LineIdleColor = System.Drawing.Color.Black
        Me.txtpuerta.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtpuerta.LineThickness = 3
        Me.txtpuerta.Location = New System.Drawing.Point(579, 431)
        Me.txtpuerta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpuerta.Name = "txtpuerta"
        Me.txtpuerta.Size = New System.Drawing.Size(344, 44)
        Me.txtpuerta.TabIndex = 41
        Me.txtpuerta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtciudad
        '
        Me.txtciudad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtciudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtciudad.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtciudad.HintForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtciudad.HintText = "Ciudad"
        Me.txtciudad.isPassword = False
        Me.txtciudad.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtciudad.LineIdleColor = System.Drawing.Color.Black
        Me.txtciudad.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtciudad.LineThickness = 3
        Me.txtciudad.Location = New System.Drawing.Point(761, 363)
        Me.txtciudad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtciudad.Name = "txtciudad"
        Me.txtciudad.Size = New System.Drawing.Size(162, 44)
        Me.txtciudad.TabIndex = 40
        Me.txtciudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtcalle
        '
        Me.txtcalle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtcalle.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtcalle.HintForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtcalle.HintText = "Calle"
        Me.txtcalle.isPassword = False
        Me.txtcalle.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtcalle.LineIdleColor = System.Drawing.Color.Black
        Me.txtcalle.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtcalle.LineThickness = 3
        Me.txtcalle.Location = New System.Drawing.Point(579, 363)
        Me.txtcalle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcalle.Name = "txtcalle"
        Me.txtcalle.Size = New System.Drawing.Size(162, 44)
        Me.txtcalle.TabIndex = 39
        Me.txtcalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcontraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtcontraseña.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtcontraseña.HintForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtcontraseña.HintText = "Contraseña"
        Me.txtcontraseña.isPassword = True
        Me.txtcontraseña.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtcontraseña.LineIdleColor = System.Drawing.Color.Black
        Me.txtcontraseña.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtcontraseña.LineThickness = 3
        Me.txtcontraseña.Location = New System.Drawing.Point(579, 297)
        Me.txtcontraseña.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.Size = New System.Drawing.Size(344, 44)
        Me.txtcontraseña.TabIndex = 37
        Me.txtcontraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtcorreo
        '
        Me.txtcorreo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtcorreo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtcorreo.HintForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtcorreo.HintText = "Correo"
        Me.txtcorreo.isPassword = False
        Me.txtcorreo.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtcorreo.LineIdleColor = System.Drawing.Color.Black
        Me.txtcorreo.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtcorreo.LineThickness = 3
        Me.txtcorreo.Location = New System.Drawing.Point(761, 224)
        Me.txtcorreo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(162, 44)
        Me.txtcorreo.TabIndex = 36
        Me.txtcorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtapelido
        '
        Me.txtapelido.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtapelido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtapelido.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtapelido.HintForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtapelido.HintText = "Apellido"
        Me.txtapelido.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.txtapelido.isPassword = False
        Me.txtapelido.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtapelido.LineIdleColor = System.Drawing.Color.Black
        Me.txtapelido.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtapelido.LineThickness = 3
        Me.txtapelido.Location = New System.Drawing.Point(761, 157)
        Me.txtapelido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtapelido.Name = "txtapelido"
        Me.txtapelido.Size = New System.Drawing.Size(162, 44)
        Me.txtapelido.TabIndex = 35
        Me.txtapelido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtnombre
        '
        Me.txtnombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtnombre.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtnombre.HintForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtnombre.HintText = "Nombre"
        Me.txtnombre.isPassword = False
        Me.txtnombre.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtnombre.LineIdleColor = System.Drawing.Color.Black
        Me.txtnombre.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtnombre.LineThickness = 3
        Me.txtnombre.Location = New System.Drawing.Point(579, 157)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(162, 44)
        Me.txtnombre.TabIndex = 34
        Me.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TXT_ci
        '
        Me.TXT_ci.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_ci.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TXT_ci.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TXT_ci.HintForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TXT_ci.HintText = "CI"
        Me.TXT_ci.isPassword = False
        Me.TXT_ci.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_ci.LineIdleColor = System.Drawing.Color.Black
        Me.TXT_ci.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXT_ci.LineThickness = 3
        Me.TXT_ci.Location = New System.Drawing.Point(579, 224)
        Me.TXT_ci.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_ci.Name = "TXT_ci"
        Me.TXT_ci.Size = New System.Drawing.Size(162, 44)
        Me.TXT_ci.TabIndex = 33
        Me.TXT_ci.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GunaAdvenceButton3
        '
        Me.GunaAdvenceButton3.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton3.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton3.BaseColor = System.Drawing.Color.DarkSlateGray
        Me.GunaAdvenceButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton3.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.CheckedImage = CType(resources.GetObject("GunaAdvenceButton3.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton3.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton3.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.Image = Nothing
        Me.GunaAdvenceButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton3.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton3.Location = New System.Drawing.Point(220, 580)
        Me.GunaAdvenceButton3.Name = "GunaAdvenceButton3"
        Me.GunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.DarkSlateGray
        Me.GunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.OnHoverImage = Nothing
        Me.GunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.Size = New System.Drawing.Size(140, 42)
        Me.GunaAdvenceButton3.TabIndex = 32
        Me.GunaAdvenceButton3.Text = "Agregar"
        Me.GunaAdvenceButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataMedico
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataMedico.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataMedico.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataMedico.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataMedico.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataMedico.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataMedico.DoubleBuffered = True
        Me.DataMedico.EnableHeadersVisualStyles = False
        Me.DataMedico.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.DataMedico.HeaderForeColor = System.Drawing.Color.SeaGreen
        Me.DataMedico.Location = New System.Drawing.Point(67, 104)
        Me.DataMedico.Name = "DataMedico"
        Me.DataMedico.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataMedico.Size = New System.Drawing.Size(459, 458)
        Me.DataMedico.TabIndex = 29
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 29.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GunaLabel1.Location = New System.Drawing.Point(220, 29)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(166, 52)
        Me.GunaLabel1.TabIndex = 28
        Me.GunaLabel1.Text = "Paciente"
        '
        'PacienteAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(990, 650)
        Me.Controls.Add(Me.txtpuerta)
        Me.Controls.Add(Me.txtciudad)
        Me.Controls.Add(Me.txtcalle)
        Me.Controls.Add(Me.txtcontraseña)
        Me.Controls.Add(Me.txtcorreo)
        Me.Controls.Add(Me.txtapelido)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.TXT_ci)
        Me.Controls.Add(Me.GunaAdvenceButton3)
        Me.Controls.Add(Me.DataMedico)
        Me.Controls.Add(Me.GunaLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PacienteAdd"
        Me.Text = "PacienteAdd"
        CType(Me.DataMedico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtpuerta As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtciudad As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtcalle As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtcontraseña As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtcorreo As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtapelido As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtnombre As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TXT_ci As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents GunaAdvenceButton3 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents DataMedico As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
End Class
