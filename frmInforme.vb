Imports System.IO

Public Class frmInforme
    Private Sub frmInforme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Define la direccion del directorio donde se ejecuta la aplicacion
            ' y la direccion del archivo donde guardamos los datos.
            Dim projectDirectory As String = Directory.GetParent(Application.StartupPath).Parent.Parent.FullName
            Dim filePath As String = Path.Combine(projectDirectory, "informe.csv")

            If File.Exists(filePath) Then
                Dim lines As String() = File.ReadAllLines(filePath)
                lboInforme.Items.Add("Placa" + vbTab + "Destino" + vbTab + vbTab + "Carga" + vbTab + +"Residuo")

                For Each line In lines.Skip(1)
                    lboInforme.Items.Add(line.Replace(",", vbTab))
                Next
            Else
                Dim destination As New frmMain()

                'Nos envia a otro form'
                destination.Show()
                Me.Hide()
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Dim destination As New frmMain()

        'Nos envia a otro form'
        destination.Show()
        Me.Hide()
    End Sub
End Class