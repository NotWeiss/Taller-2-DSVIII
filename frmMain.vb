Imports System.IO

Public Class frmMain
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Configura y aplica los colores deseados a los objetos del form'
        Dim navyBlue As Color = Color.FromArgb(0, 51, 102)
        btnRegistro.FlatStyle = FlatStyle.Flat
        btnRegistro.BackColor = navyBlue
        btnEntregas.FlatStyle = FlatStyle.Flat
        btnEntregas.BackColor = navyBlue
        btnCreditos.FlatStyle = FlatStyle.Flat
        btnCreditos.BackColor = navyBlue
        lblTitulo.ForeColor = navyBlue

        Try
            ' Define la direccion del directorio donde se ejecuta la aplicacion
            ' y la direccion del archivo donde guardamos los datos.
            Dim projectDirectory As String = Directory.GetParent(Application.StartupPath).Parent.Parent.FullName
            Dim filePath As String = Path.Combine(projectDirectory, "data.csv")

            'Verifica si el archivo "data.csv" ya existe'
            Dim fileExist As Boolean = File.Exists(filePath)

            'Crea el archivo "data.csv" si no existe'
            If Not fileExist Then
                Using writer As StreamWriter = New StreamWriter(filePath)
                    writer.WriteLine("ID, Placa, Conductor, Capacidad, Carga_Actual, Disponibilidad")
                End Using
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        Dim destination As New frmRegistro()

        'Nos envia a otro form'
        destination.Show()
        Me.Hide()
    End Sub

    Private Sub btnEntregas_Click(sender As Object, e As EventArgs) Handles btnEntregas.Click
        Dim destination As New frmEntregas()

        'Nos envia a otro form'
        destination.Show()
        Me.Hide()
    End Sub

    Private Sub btnCreditos_Click(sender As Object, e As EventArgs) Handles btnCreditos.Click
        Dim destination As New frmCreditos()

        'Nos envia a otro form'
        destination.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub
End Class
