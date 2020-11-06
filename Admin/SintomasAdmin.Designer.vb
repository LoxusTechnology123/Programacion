<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SintomasAdmin
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SintomasAdmin))
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.DataSintomasAdmin = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.GunaAdvenceButton3 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.TXT_ID = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TXT_NomSintoma = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        CType(Me.DataSintomasAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 29.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GunaLabel1.Location = New System.Drawing.Point(229, 24)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(182, 52)
        Me.GunaLabel1.TabIndex = 2
        Me.GunaLabel1.Text = "Sintomas"
        '
        'DataSintomasAdmin
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DataSintomasAdmin.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataSintomasAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataSintomasAdmin.BackgroundColor = System.Drawing.Color.White
        Me.DataSintomasAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataSintomasAdmin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataSintomasAdmin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataSintomasAdmin.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataSintomasAdmin.ColumnHeadersHeight = 4
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataSintomasAdmin.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataSintomasAdmin.EnableHeadersVisualStyles = False
        Me.DataSintomasAdmin.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataSintomasAdmin.Location = New System.Drawing.Point(76, 120)
        Me.DataSintomasAdmin.Name = "DataSintomasAdmin"
        Me.DataSintomasAdmin.RowHeadersVisible = False
        Me.DataSintomasAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataSintomasAdmin.Size = New System.Drawing.Size(459, 430)
        Me.DataSintomasAdmin.TabIndex = 3
        Me.DataSintomasAdmin.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DataSintomasAdmin.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DataSintomasAdmin.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataSintomasAdmin.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataSintomasAdmin.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataSintomasAdmin.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataSintomasAdmin.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataSintomasAdmin.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataSintomasAdmin.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataSintomasAdmin.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataSintomasAdmin.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DataSintomasAdmin.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataSintomasAdmin.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataSintomasAdmin.ThemeStyle.HeaderStyle.Height = 4
        Me.DataSintomasAdmin.ThemeStyle.ReadOnly = False
        Me.DataSintomasAdmin.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DataSintomasAdmin.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataSintomasAdmin.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DataSintomasAdmin.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataSintomasAdmin.ThemeStyle.RowsStyle.Height = 22
        Me.DataSintomasAdmin.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataSintomasAdmin.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        Me.GunaAdvenceButton3.Location = New System.Drawing.Point(238, 582)
        Me.GunaAdvenceButton3.Name = "GunaAdvenceButton3"
        Me.GunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.DarkSlateGray
        Me.GunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.OnHoverImage = Nothing
        Me.GunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.Size = New System.Drawing.Size(140, 42)
        Me.GunaAdvenceButton3.TabIndex = 8
        Me.GunaAdvenceButton3.Text = "Agregar"
        Me.GunaAdvenceButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_ID
        '
        Me.TXT_ID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TXT_ID.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TXT_ID.HintForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TXT_ID.HintText = "ID"
        Me.TXT_ID.isPassword = False
        Me.TXT_ID.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_ID.LineIdleColor = System.Drawing.Color.Black
        Me.TXT_ID.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXT_ID.LineThickness = 3
        Me.TXT_ID.Location = New System.Drawing.Point(585, 238)
        Me.TXT_ID.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_ID.Name = "TXT_ID"
        Me.TXT_ID.Size = New System.Drawing.Size(370, 44)
        Me.TXT_ID.TabIndex = 16
        Me.TXT_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TXT_NomSintoma
        '
        Me.TXT_NomSintoma.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NomSintoma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TXT_NomSintoma.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TXT_NomSintoma.HintForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TXT_NomSintoma.HintText = "Nombre del Sintoma"
        Me.TXT_NomSintoma.isPassword = False
        Me.TXT_NomSintoma.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_NomSintoma.LineIdleColor = System.Drawing.Color.Black
        Me.TXT_NomSintoma.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TXT_NomSintoma.LineThickness = 3
        Me.TXT_NomSintoma.Location = New System.Drawing.Point(585, 321)
        Me.TXT_NomSintoma.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_NomSintoma.Name = "TXT_NomSintoma"
        Me.TXT_NomSintoma.Size = New System.Drawing.Size(370, 44)
        Me.TXT_NomSintoma.TabIndex = 17
        Me.TXT_NomSintoma.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'SintomasAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(990, 650)
        Me.Controls.Add(Me.TXT_NomSintoma)
        Me.Controls.Add(Me.TXT_ID)
        Me.Controls.Add(Me.GunaAdvenceButton3)
        Me.Controls.Add(Me.DataSintomasAdmin)
        Me.Controls.Add(Me.GunaLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SintomasAdmin"
        CType(Me.DataSintomasAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents DataSintomasAdmin As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents GunaAdvenceButton3 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents TXT_ID As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TXT_NomSintoma As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
