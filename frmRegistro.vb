Imports System.IO

Public Class frmRegistro
    Private Sub frmRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bgColor As Color = Color.FromArgb(255, 246, 220)
        Me.BackColor = bgColor
        radbtnA.Checked = True
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Dim destination As New frmMain()

        'Nos envia a otro form'
        destination.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Try
            ' Verifica si los TextBoxes están vacíos
            If String.IsNullOrWhiteSpace(txtboxTransportista.Text) OrElse String.IsNullOrWhiteSpace(txtboxPlaca.Text) Then
                MessageBox.Show("Por favor, rellena todos los campos antes de registrar.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Define la dirección del directorio donde se ejecuta la aplicación
            ' y la dirección del archivo donde guardamos los datos.
            Dim projectDirectory As String = Directory.GetParent(Application.StartupPath).Parent.Parent.FullName
            Dim filePath As String = Path.Combine(projectDirectory, "data.csv")

            ' Lee los valores desde los TextBoxes y RadioButtons
            Dim conductor As String = txtboxTransportista.Text
            Dim placa As String = txtboxPlaca.Text
            Dim capacidad As String = If(radbtnA.Checked, "18000", "28000")
            Dim cargaActual As String = "0" ' Carga actual siempre será 0 inicialmente
            Dim disponibilidad As String = "True"

            ' Agrega una nueva línea al archivo CSV
            Using writer As StreamWriter = New StreamWriter(filePath, True)
                ' Genera un ID único basado en la cantidad de líneas en el archivo (puedes mejorar esto)
                Dim id As Integer = File.ReadAllLines(filePath).Length
                writer.WriteLine($"{id}, {placa}, {conductor}, {capacidad}, {cargaActual}, {disponibilidad}")
            End Using

            ' Limpiar los TextBoxes después de guardar
            txtboxPlaca.Clear()
            txtboxTransportista.Clear()

            ' Confirmar que los datos se han guardado
            MessageBox.Show("¡Datos guardados satisfactoriamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error: " & ex.Message)
        End Try
    End Sub

End Class