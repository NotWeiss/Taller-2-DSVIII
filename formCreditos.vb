Public Class frmCreditos
    Private Sub frmCreditos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bgColor As Color = Color.FromArgb(255, 246, 220)
        Me.BackColor = bgColor

        lblPc.Text = Environ("COMPUTERNAME")
        lblUser.Text = Environ("USERNAME")
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class