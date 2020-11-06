<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminAdd))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaAdvenceButton3 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.DataMedico = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.txtpuerta = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtciudad = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtcalle = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtcontraseñamedico = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtcorreomedico = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtmedicoapellido = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtmediconombre = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TXT_cimedico = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        CType(Me.DataMedico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GunaAdvenceButton3.Location = New System.Drawing.Point(231, 582)
        Me.GunaAdvenceButton3.Name = "GunaAdvenceButton3"
        Me.GunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.DarkSlateGray
        Me.GunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.OnHoverImage = Nothing
        Me.GunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.Size = New System.Drawing.Size(140, 42)
        Me.GunaAdvenceButton3.TabIndex = 43
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
        Me.DataMedico.Location = New System.Drawing.Point(71, 104)
        Me.DataMedico.Name = "DataMedico"
        Me.DataMedico.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataMedico.Size = New System.Drawing.Size(459, 458)
        Me.DataMedico.TabIndex = 40
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 29.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GunaLabel1.Location = New System.Drawing.Point(156, 35)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(269, 52)
        Me.GunaLabel1.TabIndex = 39
        Me.GunaLabel1.Text = "Administrador"
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
        Me.txtpuerta.Location = New System.Drawing.Point(578, 442)
        Me.txtpuerta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpuerta.Name = "txtpuerta"
        Me.txtpuerta.Size = New System.Drawing.Size(344, 44)
        Me.txtpuerta.TabIndex = 51
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
        Me.txtciudad.Location = New System.Drawing.Point(760, 374)
        Me.txtciudad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtciudad.Name = "txtciudad"
        Me.txtciudad.Size = New System.Drawing.Size(162, 44)
        Me.txtciudad.TabIndex = 50
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
        Me.txtcalle.Location = New System.Drawing.Point(578, 374)
        Me.txtcalle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcalle.Name = "txtcalle"
        Me.txtcalle.Size = New System.Drawing.Size(162, 44)
        Me.txtcalle.TabIndex = 49
        Me.txtcalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtcontraseñamedico
        '
        Me.txtcontraseñamedico.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcontraseñamedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtcontraseñamedico.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtcontraseñamedico.HintForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtcontraseñamedico.HintText = "Contraseña"
        Me.txtcontraseñamedico.isPassword = True
        Me.txtcontraseñamedico.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtcontraseñamedico.LineIdleColor = System.Drawing.Color.Black
        Me.txtcontraseñamedico.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtcontraseñamedico.LineThickness = 3
        Me.txtcontraseñamedico.Location = New System.Drawing.Point(578, 302)
        Me.txtcontraseñamedico.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcontraseñamedico.Name = "txtcontraseñamedico"
        Me.txtcontraseñamedico.Size = New System.Drawing.Size(344, 44)
        Me.txtcontraseñamedico.TabIndex = 48
        Me.txtcontraseñamedico.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtcorreomedico
        '
        Me.txtcorreomedico.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcorreomedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtcorreomedico.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtcorreomedico.HintForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtcorreomedico.HintText = "Correo"
        Me.txtcorreomedico.isPassword = False
        Me.txtcorreomedico.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtcorreomedico.LineIdleColor = System.Drawing.Color.Black
        Me.txtcorreomedico.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtcorreomedico.LineThickness = 3
        Me.txtcorreomedico.Location = New System.Drawing.Point(760, 229)
        Me.txtcorreomedico.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcorreomedico.Name = "txtcorreomedico"
        Me.txtcorreomedico.Size = New System.Drawing.Size(162, 44)
        Me.txtcorreomedico.TabIndex = 47
        Me.txtcorreomedico.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtmedicoapellido
        '
        Me.txtmedicoapellido.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmedicoapellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtmedicoapellido.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtmedicoapellido.HintForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtmedicoapellido.HintText = "Apellido"
        Me.txtmedicoapellido.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.txtmedicoapellido.isPassword = False
        Me.txtmedicoapellido.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtmedicoapellido.LineIdleColor = System.Drawing.Color.Black
        Me.txtmedicoapellido.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtmedicoapellido.LineThickness = 3
        Me.txtmedicoapellido.Location = New System.Drawing.Point(760, 162)
        Me.txtmedicoapellido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmedicoapellido.Name = "txtmedicoapellido"
        Me.txtmedicoapellido.Size = New System.Drawing.Size(162, 44)
        Me.txtmedicoapellido.TabIndex = 46
        Me.txtmedicoapellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtmediconombre
        '
        Me.txtmediconombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmediconombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtmediconombre.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtmediconombre.HintForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtmediconombre.HintText = "Nombre"
        Me.txtmediconombre.isPassword = False
        Me.txtmediconombre.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtmediconombre.LineIdleColor = System.Drawing.Color.Black
        Me.txtmediconombre.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtmediconombre.LineThickness = 3
        Me.txtmediconombre.Location = New System.Drawing.Point(578, 162)
        Me.txtmediconombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmediconombre.Name = "txtmediconombre"
        Me.txtmediconombre.Size = New System.Drawing.Size(162, 44)
        Me.txtmediconombre.TabIndex = 45
        Me.txtmediconombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TXT_cimedico
        '
        Me.TXT_cimedico.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_cimedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TXT_cimedico.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TXT_cimedico.HintForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TXT_cimedico.HintText = "CI"
        Me.TXT_cimedico.isPassword = False
        Me.TXT_cimedico.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_cimedico.LineIdleColor = System.Drawing.Color.Black
        Me.TXT_cimedico.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXT_cimedico.LineThickness = 3
        Me.TXT_cimedico.Location = New System.Drawing.Point(578, 229)
        Me.TXT_cimedico.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_cimedico.Name = "TXT_cimedico"
        Me.TXT_cimedico.Size = New System.Drawing.Size(162, 44)
        Me.TXT_cimedico.TabIndex = 44
        Me.TXT_cimedico.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'AdminAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(990, 650)
        Me.Controls.Add(Me.txtpuerta)
        Me.Controls.Add(Me.txtciudad)
        Me.Controls.Add(Me.txtcalle)
        Me.Controls.Add(Me.txtcontraseñamedico)
        Me.Controls.Add(Me.txtcorreomedico)
        Me.Controls.Add(Me.txtmedicoapellido)
        Me.Controls.Add(Me.txtmediconombre)
        Me.Controls.Add(Me.TXT_cimedico)
        Me.Controls.Add(Me.GunaAdvenceButton3)
        Me.Controls.Add(Me.DataMedico)
        Me.Controls.Add(Me.GunaLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminAdd"
        Me.Text = "AdminAdd"
        CType(Me.DataMedico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaAdvenceButton3 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents DataMedico As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtpuerta As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtciudad As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtcalle As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtcontraseñamedico As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtcorreomedico As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtmedicoapellido As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtmediconombre As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TXT_cimedico As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
