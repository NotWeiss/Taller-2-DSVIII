<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInforme
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInforme))
        lblInforme = New Label()
        lboInforme = New ListBox()
        btnRegresar = New Button()
        SuspendLayout()
        ' 
        ' lblInforme
        ' 
        lblInforme.AutoSize = True
        lblInforme.Font = New Font("Dubai", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInforme.Location = New Point(301, 44)
        lblInforme.Name = "lblInforme"
        lblInforme.Size = New Size(426, 63)
        lblInforme.TabIndex = 12
        lblInforme.Text = "INFORME DE ENTREGAS"
        ' 
        ' lboInforme
        ' 
        lboInforme.BorderStyle = BorderStyle.FixedSingle
        lboInforme.Font = New Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lboInforme.ForeColor = Color.Black
        lboInforme.FormattingEnabled = True
        lboInforme.ItemHeight = 23
        lboInforme.Location = New Point(241, 151)
        lboInforme.Name = "lboInforme"
        lboInforme.Size = New Size(546, 255)
        lboInforme.TabIndex = 13
        ' 
        ' btnRegresar
        ' 
        btnRegresar.BackColor = Color.DarkSalmon
        btnRegresar.FlatStyle = FlatStyle.Flat
        btnRegresar.Font = New Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegresar.ForeColor = Color.Beige
        btnRegresar.Location = New Point(366, 458)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(287, 50)
        btnRegresar.TabIndex = 14
        btnRegresar.Text = "REGRESAR"
        btnRegresar.UseVisualStyleBackColor = False
        ' 
        ' frmInforme
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 600)
        Controls.Add(btnRegresar)
        Controls.Add(lboInforme)
        Controls.Add(lblInforme)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmInforme"
        Text = "frmInforme"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblInforme As Label
    Friend WithEvents lboInforme As ListBox
    Friend WithEvents btnRegresar As Button
End Class
