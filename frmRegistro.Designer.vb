<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistro
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistro))
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label7 = New Label()
        Label6 = New Label()
        lblTransportista = New Label()
        lblPlaca = New Label()
        lblCapacidad = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtboxPlaca = New TextBox()
        txtboxTransportista = New TextBox()
        radbtnA = New RadioButton()
        radbtnB = New RadioButton()
        btnRegistrar = New Button()
        btnRegresar = New Button()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(149), CByte(189), CByte(255))
        Panel1.Location = New Point(723, 22)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(278, 75)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(51), CByte(102))
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Location = New Point(0, 22)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(683, 75)
        Panel2.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ButtonHighlight
        Label7.Location = New Point(23, 13)
        Label7.Name = "Label7"
        Label7.Size = New Size(400, 45)
        Label7.TabIndex = 1
        Label7.Text = "REGISTRO DE CAMIONES"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(149), CByte(189), CByte(255))
        Label6.Location = New Point(411, 13)
        Label6.Name = "Label6"
        Label6.Size = New Size(231, 45)
        Label6.TabIndex = 0
        Label6.Text = "FORMULARIO"
        ' 
        ' lblTransportista
        ' 
        lblTransportista.AutoSize = True
        lblTransportista.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTransportista.Location = New Point(68, 130)
        lblTransportista.Name = "lblTransportista"
        lblTransportista.Size = New Size(232, 20)
        lblTransportista.TabIndex = 2
        lblTransportista.Text = "Nombre Transportista                :"
        ' 
        ' lblPlaca
        ' 
        lblPlaca.AutoSize = True
        lblPlaca.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPlaca.Location = New Point(67, 194)
        lblPlaca.Name = "lblPlaca"
        lblPlaca.Size = New Size(233, 20)
        lblPlaca.TabIndex = 3
        lblPlaca.Text = "Identificacion de placa                :"
        ' 
        ' lblCapacidad
        ' 
        lblCapacidad.AutoSize = True
        lblCapacidad.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCapacidad.Location = New Point(65, 256)
        lblCapacidad.Name = "lblCapacidad"
        lblCapacidad.Size = New Size(235, 20)
        lblCapacidad.TabIndex = 4
        lblCapacidad.Text = "Capacidad de carga (kgs)            :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(64, 324)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 20)
        Label4.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(460, 119)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 15)
        Label5.TabIndex = 6
        ' 
        ' txtboxPlaca
        ' 
        txtboxPlaca.BackColor = Color.FromArgb(CByte(215), CByte(233), CByte(250))
        txtboxPlaca.BorderStyle = BorderStyle.None
        txtboxPlaca.Location = New Point(306, 190)
        txtboxPlaca.Multiline = True
        txtboxPlaca.Name = "txtboxPlaca"
        txtboxPlaca.Size = New Size(256, 31)
        txtboxPlaca.TabIndex = 8
        ' 
        ' txtboxTransportista
        ' 
        txtboxTransportista.BackColor = Color.FromArgb(CByte(215), CByte(233), CByte(250))
        txtboxTransportista.BorderStyle = BorderStyle.None
        txtboxTransportista.Location = New Point(306, 125)
        txtboxTransportista.Multiline = True
        txtboxTransportista.Name = "txtboxTransportista"
        txtboxTransportista.Size = New Size(256, 31)
        txtboxTransportista.TabIndex = 9
        ' 
        ' radbtnA
        ' 
        radbtnA.AutoSize = True
        radbtnA.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        radbtnA.Location = New Point(306, 258)
        radbtnA.Name = "radbtnA"
        radbtnA.Size = New Size(80, 19)
        radbtnA.TabIndex = 10
        radbtnA.TabStop = True
        radbtnA.Text = "18,000.00"
        radbtnA.UseVisualStyleBackColor = True
        ' 
        ' radbtnB
        ' 
        radbtnB.AccessibleDescription = ""
        radbtnB.AutoSize = True
        radbtnB.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        radbtnB.Location = New Point(306, 283)
        radbtnB.Name = "radbtnB"
        radbtnB.Size = New Size(80, 19)
        radbtnB.TabIndex = 11
        radbtnB.TabStop = True
        radbtnB.Text = "28,000.00"
        radbtnB.UseVisualStyleBackColor = True
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.BackColor = Color.FromArgb(CByte(74), CByte(182), CByte(146))
        btnRegistrar.FlatStyle = FlatStyle.Flat
        btnRegistrar.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegistrar.ForeColor = SystemColors.ButtonHighlight
        btnRegistrar.Location = New Point(68, 354)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(203, 44)
        btnRegistrar.TabIndex = 12
        btnRegistrar.Text = "REGISTRAR"
        btnRegistrar.UseVisualStyleBackColor = False
        ' 
        ' btnRegresar
        ' 
        btnRegresar.BackColor = Color.DarkSalmon
        btnRegresar.FlatStyle = FlatStyle.Flat
        btnRegresar.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegresar.ForeColor = SystemColors.ControlLightLight
        btnRegresar.Location = New Point(723, 354)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(203, 44)
        btnRegresar.TabIndex = 13
        btnRegresar.Text = "REGRESAR"
        btnRegresar.UseVisualStyleBackColor = False
        ' 
        ' frmRegistro
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 600)
        Controls.Add(btnRegresar)
        Controls.Add(btnRegistrar)
        Controls.Add(radbtnB)
        Controls.Add(radbtnA)
        Controls.Add(txtboxTransportista)
        Controls.Add(txtboxPlaca)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(lblCapacidad)
        Controls.Add(lblPlaca)
        Controls.Add(lblTransportista)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmRegistro"
        StartPosition = FormStartPosition.CenterScreen
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTransportista As Label
    Friend WithEvents lblPlaca As Label
    Friend WithEvents lblCapacidad As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtboxPlaca As TextBox
    Friend WithEvents txtboxTransportista As TextBox
    Friend WithEvents radbtnA As RadioButton
    Friend WithEvents radbtnB As RadioButton
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnRegresar As Button
End Class
