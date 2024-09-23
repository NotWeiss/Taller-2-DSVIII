<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        pctLogo = New PictureBox()
        lblName = New Label()
        btnRegistro = New Button()
        btnEntregas = New Button()
        btnSalir = New Button()
        btnCreditos = New Button()
        lblTitulo = New Label()
        CType(pctLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pctLogo
        ' 
        pctLogo.BackColor = Color.Transparent
        pctLogo.Image = CType(resources.GetObject("pctLogo.Image"), Image)
        pctLogo.Location = New Point(402, 12)
        pctLogo.Name = "pctLogo"
        pctLogo.Size = New Size(586, 576)
        pctLogo.SizeMode = PictureBoxSizeMode.Zoom
        pctLogo.TabIndex = 0
        pctLogo.TabStop = False
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.BackColor = Color.Transparent
        lblName.Font = New Font("Tw Cen MT Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.ForeColor = Color.Beige
        lblName.Location = New Point(514, 364)
        lblName.Name = "lblName"
        lblName.Size = New Size(362, 56)
        lblName.TabIndex = 1
        lblName.Text = "DISTRIBUIDORA IDK"
        ' 
        ' btnRegistro
        ' 
        btnRegistro.BackColor = Color.Navy
        btnRegistro.FlatStyle = FlatStyle.Flat
        btnRegistro.Font = New Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegistro.ForeColor = Color.White
        btnRegistro.Location = New Point(14, 251)
        btnRegistro.Name = "btnRegistro"
        btnRegistro.Size = New Size(360, 50)
        btnRegistro.TabIndex = 2
        btnRegistro.Text = "REGISTRO DE CAMIONES"
        btnRegistro.UseVisualStyleBackColor = False
        ' 
        ' btnEntregas
        ' 
        btnEntregas.BackColor = Color.Navy
        btnEntregas.FlatStyle = FlatStyle.Flat
        btnEntregas.Font = New Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEntregas.ForeColor = Color.White
        btnEntregas.Location = New Point(14, 195)
        btnEntregas.Name = "btnEntregas"
        btnEntregas.Size = New Size(360, 50)
        btnEntregas.TabIndex = 3
        btnEntregas.Text = "PROGRAMAR ENTREGAS"
        btnEntregas.UseVisualStyleBackColor = False
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.DarkSalmon
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.Font = New Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSalir.ForeColor = Color.White
        btnSalir.Location = New Point(14, 471)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(360, 50)
        btnSalir.TabIndex = 4
        btnSalir.Text = "SALIR"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' btnCreditos
        ' 
        btnCreditos.BackColor = Color.Navy
        btnCreditos.FlatStyle = FlatStyle.Flat
        btnCreditos.Font = New Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCreditos.ForeColor = Color.White
        btnCreditos.Location = New Point(14, 307)
        btnCreditos.Name = "btnCreditos"
        btnCreditos.Size = New Size(360, 50)
        btnCreditos.TabIndex = 5
        btnCreditos.Text = "CREDITOS"
        btnCreditos.UseVisualStyleBackColor = False
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.BackColor = Color.Transparent
        lblTitulo.Font = New Font("Dubai", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitulo.ForeColor = SystemColors.ActiveCaptionText
        lblTitulo.Location = New Point(20, 71)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(348, 60)
        lblTitulo.TabIndex = 6
        lblTitulo.Text = "SISTEMA DE ENVIOS"
        ' 
        ' frmMain
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = SystemColors.WindowFrame
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1000, 600)
        Controls.Add(lblTitulo)
        Controls.Add(btnCreditos)
        Controls.Add(btnSalir)
        Controls.Add(btnEntregas)
        Controls.Add(btnRegistro)
        Controls.Add(lblName)
        Controls.Add(pctLogo)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmMain"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "SISTEMA DE ENVIOS - DISTRIBUIDORA IDK"
        CType(pctLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pctLogo As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents btnRegistro As Button
    Friend WithEvents btnEntregas As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnCreditos As Button
    Friend WithEvents lblTitulo As Label

End Class
