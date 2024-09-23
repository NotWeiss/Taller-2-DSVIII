Public Class frmMain
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim navyBlue As Color = Color.FromArgb(0, 51, 102)
        btnRegistro.FlatStyle = FlatStyle.Flat
        btnRegistro.BackColor = navyBlue
        btnEntregas.FlatStyle = FlatStyle.Flat
        btnEntregas.BackColor = navyBlue
        btnCreditos.FlatStyle = FlatStyle.Flat
        btnCreditos.BackColor = navyBlue
        lblTitulo.ForeColor = navyBlue

    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click

    End Sub
End Class
