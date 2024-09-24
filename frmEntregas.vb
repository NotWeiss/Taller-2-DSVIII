Imports System.IO
Imports System.Numerics
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class frmEntregas
    Private indiceData As Integer = 1
    Private limit As Integer

    Private Sub FrmEntregas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bgColor As Color = Color.FromArgb(255, 246, 220)
        Me.BackColor = bgColor

        'Lee los datos de todos los archivos csv'
        CrearSaco()
        Try
            LeerCamion()
        Catch ex As Exception
            MsgBox("Parece que no hay camiones disponibles, Registre algunos antes de continuar", vbOKOnly, "Camiones no Disponibles")

            Dim destination As New frmMain()

            'Nos envia a otro form'
            destination.Show()
            Me.Hide()
        End Try

    End Sub

    Private Sub deleteCsv()
        Try
            ' Define la direccion del directorio donde se ejecuta la aplicacion
            ' y la direccion del archivo donde guardamos los datos.
            Dim projectDirectory As String = Directory.GetParent(Application.StartupPath).Parent.Parent.FullName
            Dim filePath As String = Path.Combine(projectDirectory, "informe.csv")

            If File.Exists(filePath) Then
                File.Delete(filePath)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Function LeerInforme() As Integer
        Try
            ' Define la direccion del directorio donde se ejecuta la aplicacion
            ' y la direccion del archivo donde guardamos los datos.
            Dim projectDirectory As String = Directory.GetParent(Application.StartupPath).Parent.Parent.FullName
            Dim filePath As String = Path.Combine(projectDirectory, "informe.csv")

            'Verifica si el archivo "informe.csv" ya existe'
            Dim fileExist As Boolean = File.Exists(filePath)

            If fileExist Then
                'Busca el ultimo indice del dato'
                Dim target As Integer = File.ReadAllLines(filePath).Count()
                Dim lines As String() = File.ReadAllLines(filePath)
                Dim line As String = lines(target - 1)
                Dim result As String() = line.Split(","c)
                Return LimpiarCaracteres(result(3))

            Else
                Return 0
            End If

        Catch ex As Exception
        End Try
        Return 0
    End Function

    'Genera el peso en Kgs que tendra el Saco'
    Private Sub CrearSaco()
        Dim rand As New Random()
        Dim flag As Integer = LeerInforme()
        txtInfoSaco.Clear()
        If flag = 0 Then
            txtInfoSaco.Text = CStr(rand.Next(2000, 8000)) + "Kgs"
        Else
            txtInfoSaco.Text = CStr(flag) + "Kgs"
        End If

    End Sub

    'Elimina todos los caracteres que no sean numeros'
    Private Function LimpiarCaracteres(input As String) As Integer
        Return Integer.Parse(Regex.Replace(input, "[^\d]", ""))
    End Function

    Private Function LeerCamion() As Integer
        ' Define la direccion del directorio donde se ejecuta la aplicacion
        ' y la direccion del archivo donde guardamos los datos.
        Dim projectDirectory As String = Directory.GetParent(Application.StartupPath).Parent.Parent.FullName
        Dim filePath As String = Path.Combine(projectDirectory, "data.csv")

        limit = File.ReadAllLines(filePath).Count()

        If (indiceData <= limit) Then
            'reads a line from "Data.csv"'
            Dim lines As String() = File.ReadAllLines(filePath)
            Dim line As String = lines(indiceData)

            'returns an array of the data'
            Dim result As String() = line.Split(","c)

            lboCamion.Items.Add("ID: " + result(0))
            lboCamion.Items.Add("Placa: " + result(1))
            lboCamion.Items.Add("Conductor: " + result(2))
            lboCamion.Items.Add("Capacidad: " + result(3))
            lboCamion.Items.Add("Carga Actual: " + result(4))

            indiceData += 1
        End If

        Return limit
    End Function

    Private Sub GenerarInforme(placa As String, destino As String, carga As String, residuo As String)
        Try
            ' Define la direccion del directorio donde se ejecuta la aplicacion
            ' y la direccion del archivo donde guardamos los datos.
            Dim projectDirectory As String = Directory.GetParent(Application.StartupPath).Parent.Parent.FullName
            Dim filePath As String = Path.Combine(projectDirectory, "informe.csv")

            'Verifica si el archivo "data.csv" ya existe'
            Dim fileExist As Boolean = File.Exists(filePath)

            Using writer As StreamWriter = New StreamWriter(filePath, True)
                'Crea el archivo "informe.csv" si no existe'
                If Not fileExist Then
                    writer.WriteLine("Placa del Camion, Destino, Carga, Residuo")
                End If

                Dim data As String = $"{placa},{destino},{carga},{residuo}"
                writer.WriteLine(data)
            End Using

        Catch ex As Exception
            MsgBox("Error Inesperado", vbOKOnly)
        End Try
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim capacidad As Integer = LimpiarCaracteres(lboCamion.Items(3))
        Dim carga As Integer = LimpiarCaracteres(lboCamion.Items(4))
        Dim pesoSaco As Integer = LimpiarCaracteres(txtInfoSaco.Text)

        If (carga + pesoSaco <= capacidad) Then
            carga += pesoSaco
            lboCamion.Items(4) = "Carga Actual: " + CStr(carga) + "Kgs"
            CrearSaco()
        Else
            MsgBox("El camion a alcanzado el maximo de su capacidad", vbOKOnly, "Limite Alcanzado")
        End If
    End Sub

    Private Function Destiny() As String
        If radNorte.Checked Then
            Return "Almacen Norte"
        ElseIf radSur.Checked Then
            Return "Almacen Sur"
        ElseIf radEste.Checked Then
            Return "Almacen Este"
        ElseIf radOeste.Checked Then
            Return "Almacen Oeste"
        End If
        Return ""
    End Function

    Private Sub btnDesplegar_Click(sender As Object, e As EventArgs) Handles btnDesplegar.Click
        Dim placaCamion = lboCamion.Items(1).replace("Placa: ", "")
        Dim almacen = Destiny()
        Dim peso = lboCamion.Items(4).replace("Carga Actual: ", "")
        Dim sobrante = txtInfoSaco.Text

        GenerarInforme(placaCamion, almacen, peso, sobrante)
        If (indiceData + 1 <= limit) Then
            LeerCamion()
        Else
            MsgBox("Parece que no hay mas camiones disponibles, procede a completar las entregas", vbOKOnly, "Completado")
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Dim destination As New frmMain()

        'Nos envia a otro form'
        destination.Show()
        Me.Hide()
    End Sub

    Private Sub btnEntregar_Click(sender As Object, e As EventArgs) Handles btnEntregar.Click
        Dim destination As New frmInforme()

        'Nos envia a otro form'
        destination.Show()
        Me.Hide()
    End Sub
End Class