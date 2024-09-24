Public Class frmCreditos
    Private Sub frmCreditos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bgColor As Color = Color.FromArgb(255, 246, 220)
        Me.BackColor = bgColor

        lblPc.Text = Environ("COMPUTERNAME")
        lblUser.Text = Environ("USERNAME")
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Dim destination As New frmMain()

        'Nos envia a otro form'
        destination.Show()
        Me.Hide()
    End Sub
End Class