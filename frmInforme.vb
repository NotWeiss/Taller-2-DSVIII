Imports System.IO

Public Class frmInforme
    Private Sub frmInforme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Define la direccion del directorio donde se ejecuta la aplicacion
            ' y la direccion del archivo donde guardamos los datos.
            Dim projectDirectory As String = Directory.GetParent(Application.StartupPath).Parent.Parent.FullName
            Dim filePath As String = Path.Combine(projectDirectory, "informe.csv")

            If File.Exists(filePath) Then
                lboInforme.Items.Add("Placa" + vbTab + "Destino" + vbTab + vbTab + "Carga")

                Dim lines As String() = File.ReadAllLines(filePath)
                For Each line In lines.Skip(1)
                    Dim preResult As String() = line.Split(","c)
                    Dim result(preResult.Length - 1) As String
                    Array.Copy(preResult, result, preResult.Length - 1)

                    lboInforme.Items.Add(String.Join(vbTab, result))
                Next
            Else
                MsgBox("No se pudo encontrar ningun informe", vbOKOnly)
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