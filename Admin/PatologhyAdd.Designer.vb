<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatologhyAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatologhyAdd))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtid = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtdesc = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtnom = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GunaAdvenceButton3 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.DataMedico = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.txtgrave = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        CType(Me.DataMedico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtid
        '
        Me.txtid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtid.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtid.HintForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtid.HintText = "ID"
        Me.txtid.isPassword = False
        Me.txtid.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtid.LineIdleColor = System.Drawing.Color.Black
        Me.txtid.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtid.LineThickness = 3
        Me.txtid.Location = New System.Drawing.Point(571, 239)
        Me.txtid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(344, 44)
        Me.txtid.TabIndex = 37
        Me.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtdesc
        '
        Me.txtdesc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtdesc.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtdesc.HintForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtdesc.HintText = "Descripcion"
        Me.txtdesc.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.txtdesc.isPassword = False
        Me.txtdesc.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtdesc.LineIdleColor = System.Drawing.Color.Black
        Me.txtdesc.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtdesc.LineThickness = 3
        Me.txtdesc.Location = New System.Drawing.Point(571, 343)
        Me.txtdesc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(344, 44)
        Me.txtdesc.TabIndex = 35
        Me.txtdesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtnom
        '
        Me.txtnom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtnom.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtnom.HintForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtnom.HintText = "Nombre"
        Me.txtnom.isPassword = False
        Me.txtnom.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtnom.LineIdleColor = System.Drawing.Color.Black
        Me.txtnom.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtnom.LineThickness = 3
        Me.txtnom.Location = New System.Drawing.Point(571, 291)
        Me.txtnom.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Size = New System.Drawing.Size(344, 44)
        Me.txtnom.TabIndex = 34
        Me.txtnom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.GunaAdvenceButton3.Location = New System.Drawing.Point(226, 581)
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
        Me.GunaLabel1.Location = New System.Drawing.Point(202, 28)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(184, 52)
        Me.GunaLabel1.TabIndex = 28
        Me.GunaLabel1.Text = "Patología"
        '
        'txtgrave
        '
        Me.txtgrave.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtgrave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtgrave.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtgrave.HintForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtgrave.HintText = "Gravedad"
        Me.txtgrave.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.txtgrave.isPassword = False
        Me.txtgrave.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtgrave.LineIdleColor = System.Drawing.Color.Black
        Me.txtgrave.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtgrave.LineThickness = 3
        Me.txtgrave.Location = New System.Drawing.Point(571, 395)
        Me.txtgrave.Margin = New System.Windows.Forms.Padding(4)
        Me.txtgrave.Name = "txtgrave"
        Me.txtgrave.Size = New System.Drawing.Size(344, 44)
        Me.txtgrave.TabIndex = 38
        Me.txtgrave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PatologhyAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(990, 650)
        Me.Controls.Add(Me.txtgrave)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.txtdesc)
        Me.Controls.Add(Me.txtnom)
        Me.Controls.Add(Me.GunaAdvenceButton3)
        Me.Controls.Add(Me.DataMedico)
        Me.Controls.Add(Me.GunaLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PatologhyAdd"
        Me.Text = "PatologhyAdd"
        CType(Me.DataMedico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtid As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtdesc As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtnom As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents GunaAdvenceButton3 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents DataMedico As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtgrave As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
