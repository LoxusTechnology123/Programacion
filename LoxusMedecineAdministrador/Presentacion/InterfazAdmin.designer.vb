<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InterfazAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InterfazAdmin))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.BTNCuentas = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BTNSalir = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BTNPatologiasSintomas = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaTransfarantPictureBox1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.Panelcontenedor = New Guna.UI.WinForms.GunaPanel()
        Me.Datapatologias = New Guna.UI.WinForms.GunaDataGridView()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.DataSintomas = New Guna.UI.WinForms.GunaDataGridView()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelcontenedor.SuspendLayout()
        CType(Me.Datapatologias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.MediumBlue
        Me.GunaPanel1.Controls.Add(Me.BTNCuentas)
        Me.GunaPanel1.Controls.Add(Me.BTNSalir)
        Me.GunaPanel1.Controls.Add(Me.BTNPatologiasSintomas)
        Me.GunaPanel1.Controls.Add(Me.GunaTransfarantPictureBox1)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(120, 700)
        Me.GunaPanel1.TabIndex = 0
        '
        'BTNCuentas
        '
        Me.BTNCuentas.AnimationHoverSpeed = 0.07!
        Me.BTNCuentas.AnimationSpeed = 0.03!
        Me.BTNCuentas.BaseColor = System.Drawing.Color.MediumBlue
        Me.BTNCuentas.BorderColor = System.Drawing.Color.Black
        Me.BTNCuentas.CheckedBaseColor = System.Drawing.Color.Gray
        Me.BTNCuentas.CheckedBorderColor = System.Drawing.Color.Black
        Me.BTNCuentas.CheckedForeColor = System.Drawing.Color.White
        Me.BTNCuentas.CheckedImage = CType(resources.GetObject("BTNCuentas.CheckedImage"), System.Drawing.Image)
        Me.BTNCuentas.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BTNCuentas.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTNCuentas.FocusedColor = System.Drawing.Color.Empty
        Me.BTNCuentas.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCuentas.ForeColor = System.Drawing.Color.White
        Me.BTNCuentas.Image = CType(resources.GetObject("BTNCuentas.Image"), System.Drawing.Image)
        Me.BTNCuentas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BTNCuentas.ImageSize = New System.Drawing.Size(32, 32)
        Me.BTNCuentas.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTNCuentas.Location = New System.Drawing.Point(-2, 437)
        Me.BTNCuentas.Name = "BTNCuentas"
        Me.BTNCuentas.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNCuentas.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTNCuentas.OnHoverForeColor = System.Drawing.Color.White
        Me.BTNCuentas.OnHoverImage = Nothing
        Me.BTNCuentas.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTNCuentas.OnPressedColor = System.Drawing.Color.Black
        Me.BTNCuentas.Size = New System.Drawing.Size(122, 59)
        Me.BTNCuentas.TabIndex = 5
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
        'BTNPatologiasSintomas
        '
        Me.BTNPatologiasSintomas.AnimationHoverSpeed = 0.07!
        Me.BTNPatologiasSintomas.AnimationSpeed = 0.03!
        Me.BTNPatologiasSintomas.BaseColor = System.Drawing.Color.Navy
        Me.BTNPatologiasSintomas.BorderColor = System.Drawing.Color.Black
        Me.BTNPatologiasSintomas.CheckedBaseColor = System.Drawing.Color.Gray
        Me.BTNPatologiasSintomas.CheckedBorderColor = System.Drawing.Color.Black
        Me.BTNPatologiasSintomas.CheckedForeColor = System.Drawing.Color.White
        Me.BTNPatologiasSintomas.CheckedImage = CType(resources.GetObject("BTNPatologiasSintomas.CheckedImage"), System.Drawing.Image)
        Me.BTNPatologiasSintomas.CheckedLineColor = System.Drawing.Color.DimGray
        Me.BTNPatologiasSintomas.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTNPatologiasSintomas.FocusedColor = System.Drawing.Color.Empty
        Me.BTNPatologiasSintomas.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNPatologiasSintomas.ForeColor = System.Drawing.Color.White
        Me.BTNPatologiasSintomas.Image = CType(resources.GetObject("BTNPatologiasSintomas.Image"), System.Drawing.Image)
        Me.BTNPatologiasSintomas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BTNPatologiasSintomas.ImageSize = New System.Drawing.Size(32, 32)
        Me.BTNPatologiasSintomas.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTNPatologiasSintomas.Location = New System.Drawing.Point(0, 381)
        Me.BTNPatologiasSintomas.Name = "BTNPatologiasSintomas"
        Me.BTNPatologiasSintomas.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNPatologiasSintomas.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BTNPatologiasSintomas.OnHoverForeColor = System.Drawing.Color.White
        Me.BTNPatologiasSintomas.OnHoverImage = Nothing
        Me.BTNPatologiasSintomas.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BTNPatologiasSintomas.OnPressedColor = System.Drawing.Color.Black
        Me.BTNPatologiasSintomas.Size = New System.Drawing.Size(122, 59)
        Me.BTNPatologiasSintomas.TabIndex = 2
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
        Me.Panelcontenedor.Controls.Add(Me.Datapatologias)
        Me.Panelcontenedor.Controls.Add(Me.GunaLabel2)
        Me.Panelcontenedor.Controls.Add(Me.DataSintomas)
        Me.Panelcontenedor.Controls.Add(Me.GunaLabel1)
        Me.Panelcontenedor.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panelcontenedor.Location = New System.Drawing.Point(117, 0)
        Me.Panelcontenedor.Name = "Panelcontenedor"
        Me.Panelcontenedor.Size = New System.Drawing.Size(1063, 700)
        Me.Panelcontenedor.TabIndex = 1
        '
        'Datapatologias
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Datapatologias.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Datapatologias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Datapatologias.BackgroundColor = System.Drawing.Color.White
        Me.Datapatologias.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Datapatologias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Datapatologias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Datapatologias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Datapatologias.ColumnHeadersHeight = 4
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Datapatologias.DefaultCellStyle = DataGridViewCellStyle3
        Me.Datapatologias.EnableHeadersVisualStyles = False
        Me.Datapatologias.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Datapatologias.Location = New System.Drawing.Point(172, 447)
        Me.Datapatologias.Name = "Datapatologias"
        Me.Datapatologias.RowHeadersVisible = False
        Me.Datapatologias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datapatologias.Size = New System.Drawing.Size(750, 213)
        Me.Datapatologias.TabIndex = 3
        Me.Datapatologias.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.Datapatologias.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Datapatologias.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Datapatologias.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Datapatologias.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Datapatologias.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Datapatologias.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Datapatologias.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Datapatologias.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Datapatologias.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Datapatologias.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Datapatologias.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Datapatologias.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Datapatologias.ThemeStyle.HeaderStyle.Height = 4
        Me.Datapatologias.ThemeStyle.ReadOnly = False
        Me.Datapatologias.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Datapatologias.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Datapatologias.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Datapatologias.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Datapatologias.ThemeStyle.RowsStyle.Height = 22
        Me.Datapatologias.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Datapatologias.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Verdana", 29.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(435, 381)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(220, 47)
        Me.GunaLabel2.TabIndex = 2
        Me.GunaLabel2.Text = "Patologías"
        '
        'DataSintomas
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.DataSintomas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataSintomas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataSintomas.BackgroundColor = System.Drawing.Color.White
        Me.DataSintomas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataSintomas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataSintomas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataSintomas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataSintomas.ColumnHeadersHeight = 4
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataSintomas.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataSintomas.EnableHeadersVisualStyles = False
        Me.DataSintomas.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataSintomas.Location = New System.Drawing.Point(172, 114)
        Me.DataSintomas.Name = "DataSintomas"
        Me.DataSintomas.RowHeadersVisible = False
        Me.DataSintomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataSintomas.Size = New System.Drawing.Size(750, 213)
        Me.DataSintomas.TabIndex = 1
        Me.DataSintomas.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.DataSintomas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DataSintomas.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataSintomas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataSintomas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataSintomas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataSintomas.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataSintomas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataSintomas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataSintomas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataSintomas.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DataSintomas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataSintomas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataSintomas.ThemeStyle.HeaderStyle.Height = 4
        Me.DataSintomas.ThemeStyle.ReadOnly = False
        Me.DataSintomas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DataSintomas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataSintomas.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DataSintomas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataSintomas.ThemeStyle.RowsStyle.Height = 22
        Me.DataSintomas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataSintomas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Verdana", 29.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(435, 41)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(204, 47)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Sintomas"
        '
        'InterfazAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1180, 700)
        Me.Controls.Add(Me.Panelcontenedor)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InterfazAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InterfazUsuario"
        Me.GunaPanel1.ResumeLayout(False)
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelcontenedor.ResumeLayout(False)
        Me.Panelcontenedor.PerformLayout()
        CType(Me.Datapatologias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaTransfarantPictureBox1 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents BTNSalir As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents BTNPatologiasSintomas As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Panelcontenedor As Guna.UI.WinForms.GunaPanel
    Friend WithEvents BTNCuentas As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Datapatologias As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents DataSintomas As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
End Class
