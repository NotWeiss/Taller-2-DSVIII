<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCreditos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreditos))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lblPc = New Label()
        lblUser = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        btnRegresar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(244, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(511, 40)
        Label1.TabIndex = 0
        Label1.Text = "Universidad Tecnológica de Panamá"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(267, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(465, 37)
        Label2.TabIndex = 1
        Label2.Text = "Licenciatura en desarrollo de software"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(355, 161)
        Label3.Name = "Label3"
        Label3.Size = New Size(288, 37)
        Label3.TabIndex = 2
        Label3.Text = "Franz Vera 8-971-1172"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(318, 198)
        Label4.Name = "Label4"
        Label4.Size = New Size(363, 37)
        Label4.TabIndex = 3
        Label4.Text = "Reynaldo Pedroza 8-964-809"
        ' 
        ' lblPc
        ' 
        lblPc.AutoSize = True
        lblPc.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPc.Location = New Point(477, 254)
        lblPc.Name = "lblPc"
        lblPc.Size = New Size(45, 37)
        lblPc.TabIndex = 4
        lblPc.Text = "pc"
        lblPc.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUser.Location = New Point(466, 291)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(66, 37)
        lblUser.TabIndex = 5
        lblUser.Text = "user"
        lblUser.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(394, 346)
        Label5.Name = "Label5"
        Label5.Size = New Size(210, 37)
        Label5.TabIndex = 6
        Label5.Text = "Version de VBA: "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(445, 383)
        Label6.Name = "Label6"
        Label6.Size = New Size(109, 37)
        Label6.TabIndex = 7
        Label6.Text = "VBA 7.1"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(441, 107)
        Label7.Name = "Label7"
        Label7.Size = New Size(117, 37)
        Label7.TabIndex = 8
        Label7.Text = "Taller #2"
        ' 
        ' btnRegresar
        ' 
        btnRegresar.BackColor = Color.DarkSalmon
        btnRegresar.FlatStyle = FlatStyle.Flat
        btnRegresar.Font = New Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegresar.ForeColor = Color.Beige
        btnRegresar.Location = New Point(355, 445)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(287, 50)
        btnRegresar.TabIndex = 11
        btnRegresar.Text = "REGRESAR"
        btnRegresar.UseVisualStyleBackColor = False
        ' 
        ' frmCreditos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 600)
        Controls.Add(btnRegresar)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(lblUser)
        Controls.Add(lblPc)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmCreditos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CREDITOS - DISTRIBUIDORA IDK"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPc As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnRegresar As Button
End Class