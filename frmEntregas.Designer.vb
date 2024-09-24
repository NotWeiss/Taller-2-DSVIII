<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntregas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntregas))
        grbDestino = New GroupBox()
        radOeste = New RadioButton()
        radEste = New RadioButton()
        radSur = New RadioButton()
        radNorte = New RadioButton()
        txtInfoSaco = New TextBox()
        btnCargar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        btnEntregar = New Button()
        btnDesplegar = New Button()
        btnRegresar = New Button()
        Label3 = New Label()
        lboCamion = New ListBox()
        grbDestino.SuspendLayout()
        SuspendLayout()
        ' 
        ' grbDestino
        ' 
        grbDestino.Controls.Add(radOeste)
        grbDestino.Controls.Add(radEste)
        grbDestino.Controls.Add(radSur)
        grbDestino.Controls.Add(radNorte)
        grbDestino.Location = New Point(497, 174)
        grbDestino.Name = "grbDestino"
        grbDestino.Size = New Size(124, 194)
        grbDestino.TabIndex = 0
        grbDestino.TabStop = False
        grbDestino.Text = "Destino"
        ' 
        ' radOeste
        ' 
        radOeste.AutoSize = True
        radOeste.Location = New Point(13, 133)
        radOeste.Name = "radOeste"
        radOeste.Size = New Size(101, 19)
        radOeste.TabIndex = 3
        radOeste.TabStop = True
        radOeste.Text = "Almacen West"
        radOeste.UseVisualStyleBackColor = True
        ' 
        ' radEste
        ' 
        radEste.AutoSize = True
        radEste.Location = New Point(13, 104)
        radEste.Name = "radEste"
        radEste.Size = New Size(96, 19)
        radEste.TabIndex = 2
        radEste.TabStop = True
        radEste.Text = "Almacen Este"
        radEste.UseVisualStyleBackColor = True
        ' 
        ' radSur
        ' 
        radSur.AutoSize = True
        radSur.Location = New Point(13, 75)
        radSur.Name = "radSur"
        radSur.Size = New Size(92, 19)
        radSur.TabIndex = 1
        radSur.TabStop = True
        radSur.Text = "Almacen Sur"
        radSur.UseVisualStyleBackColor = True
        ' 
        ' radNorte
        ' 
        radNorte.AutoSize = True
        radNorte.Location = New Point(13, 46)
        radNorte.Name = "radNorte"
        radNorte.Size = New Size(105, 19)
        radNorte.TabIndex = 0
        radNorte.TabStop = True
        radNorte.Text = "Almacen Norte"
        radNorte.UseVisualStyleBackColor = True
        ' 
        ' txtInfoSaco
        ' 
        txtInfoSaco.Font = New Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtInfoSaco.Location = New Point(668, 182)
        txtInfoSaco.Name = "txtInfoSaco"
        txtInfoSaco.Size = New Size(287, 53)
        txtInfoSaco.TabIndex = 2
        txtInfoSaco.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnCargar
        ' 
        btnCargar.BackColor = Color.DarkBlue
        btnCargar.FlatStyle = FlatStyle.Flat
        btnCargar.Font = New Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCargar.ForeColor = Color.Beige
        btnCargar.Location = New Point(668, 247)
        btnCargar.Name = "btnCargar"
        btnCargar.Size = New Size(287, 50)
        btnCargar.TabIndex = 3
        btnCargar.Text = "CARGAR SACO"
        btnCargar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(721, 143)
        Label1.Name = "Label1"
        Label1.Size = New Size(181, 36)
        Label1.TabIndex = 4
        Label1.Text = "Peso del Saco:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(93, 143)
        Label2.Name = "Label2"
        Label2.Size = New Size(303, 36)
        Label2.TabIndex = 5
        Label2.Text = "Información del Camión:"
        ' 
        ' btnEntregar
        ' 
        btnEntregar.BackColor = Color.DarkBlue
        btnEntregar.FlatStyle = FlatStyle.Flat
        btnEntregar.Font = New Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEntregar.ForeColor = Color.Beige
        btnEntregar.Location = New Point(668, 518)
        btnEntregar.Name = "btnEntregar"
        btnEntregar.Size = New Size(287, 50)
        btnEntregar.TabIndex = 8
        btnEntregar.Text = "COMPLETAR ENTREGAS"
        btnEntregar.UseVisualStyleBackColor = False
        ' 
        ' btnDesplegar
        ' 
        btnDesplegar.BackColor = Color.DarkBlue
        btnDesplegar.FlatStyle = FlatStyle.Flat
        btnDesplegar.Font = New Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDesplegar.ForeColor = Color.Beige
        btnDesplegar.Location = New Point(375, 518)
        btnDesplegar.Name = "btnDesplegar"
        btnDesplegar.Size = New Size(287, 50)
        btnDesplegar.TabIndex = 9
        btnDesplegar.Text = "DESPLEGAR CAMION"
        btnDesplegar.UseVisualStyleBackColor = False
        ' 
        ' btnRegresar
        ' 
        btnRegresar.BackColor = Color.DarkSalmon
        btnRegresar.FlatStyle = FlatStyle.Flat
        btnRegresar.Font = New Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegresar.ForeColor = Color.Beige
        btnRegresar.Location = New Point(40, 518)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(287, 50)
        btnRegresar.TabIndex = 10
        btnRegresar.Text = "REGRESAR"
        btnRegresar.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Dubai", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(285, 31)
        Label3.Name = "Label3"
        Label3.Size = New Size(434, 63)
        Label3.TabIndex = 11
        Label3.Text = "PROGRAMAR ENTREGAS"
        ' 
        ' lboCamion
        ' 
        lboCamion.BorderStyle = BorderStyle.FixedSingle
        lboCamion.Font = New Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lboCamion.ForeColor = Color.Black
        lboCamion.FormattingEnabled = True
        lboCamion.ItemHeight = 29
        lboCamion.Location = New Point(40, 184)
        lboCamion.Name = "lboCamion"
        lboCamion.Size = New Size(408, 176)
        lboCamion.TabIndex = 12
        ' 
        ' frmEntregas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 600)
        Controls.Add(lboCamion)
        Controls.Add(Label3)
        Controls.Add(btnRegresar)
        Controls.Add(btnDesplegar)
        Controls.Add(btnEntregar)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCargar)
        Controls.Add(txtInfoSaco)
        Controls.Add(grbDestino)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmEntregas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PROGRAMAR ENTREGAS - DISTRIBUIDORA IDK"
        grbDestino.ResumeLayout(False)
        grbDestino.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents grbDestino As GroupBox
    Friend WithEvents radOeste As RadioButton
    Friend WithEvents radEste As RadioButton
    Friend WithEvents radSur As RadioButton
    Friend WithEvents radNorte As RadioButton
    Friend WithEvents txtInfoSaco As TextBox
    Friend WithEvents btnCargar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEntregar As Button
    Friend WithEvents btnDesplegar As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lboCamion As ListBox
End Class
