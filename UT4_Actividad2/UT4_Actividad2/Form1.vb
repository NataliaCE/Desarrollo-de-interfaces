Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Form1
    Dim nombre As String
    Dim apellidos As String
    Dim dni As String
    Dim fecha As String
    Dim depto As Integer
    Dim periodo As String
    Dim directorio As String = Directory.GetCurrentDirectory()
    Dim dir As DirectoryInfo = Directory.GetParent(directorio)
    Dim carpeta As DirectoryInfo = Directory.GetParent(dir.ToString())
    Dim MiConexionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & carpeta.ToString() & "\BaseDatos.mdf;Integrated Security=True"
    Dim MiConexion As New SqlConnection(MiConexionString)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try
            MiConexion.Open()
            MessageBox.Show("Conexion exitosa.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
        AsignarTextBox()
        obtenerRegistro()
    End Sub

    Private Sub btn_enviar_Click(sender As Object, e As EventArgs) Handles btn_enviar.Click
        Try
            If ComprobarDatosPersonales() And ComprobarDatosEmpresa() Then
                insertarDatos()
                MessageBox.Show("Datos enviados.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        obtenerRegistro()
    End Sub

    Public Sub AsignarTextBox()
        tb_nombre.Tag = Err_nombre
        tb_apellido.Tag = Err_apellidos
        tb_dni.Tag = Err_dni
    End Sub

    Function ComprobarDatosPersonales() As Boolean

        'Nombre, apellido y dni no están vacíos
        Dim contador As Integer = 0
        Dim obliga As Label
        For Each valor In Gb_datosPersonales.Controls
            If TypeOf valor Is TextBox Then
                obliga = valor.tag
                If valor.text.trim() = "" Then
                    obliga.Text = "Campo obligatorio"
                    contador += 1
                Else
                    obliga.Text = "*"
                End If
            End If
        Next

        'DNI válido
        If Not tb_dni.Text.Trim = "" Then
            If compruebaDNI(tb_dni.Text) Then
                Err_dni.Text = "*"
            Else
                Err_dni.Text = "DNI no válido"
                contador += 1
            End If
        End If

        'Fecha de nacimiento
        Dim fechaMinima As Date = "01/01/2006"
        If Not dtp_fecha.Value.Date.CompareTo(fechaMinima) = -1 Then
            contador += 1
            Err_fecha.Text = "Fecha no válida"
        Else
            Err_fecha.Text = ""
            fecha = dtp_fecha.Value.ToString("MM/dd/yyyy")
        End If

        'Obtencion de datos
        If contador > 0 Then
            Return False
        Else
            nombre = tb_nombre.Text.Trim()
            apellidos = tb_apellido.Text.Trim()
            dni = tb_dni.Text.Trim()
            Return True
        End If
    End Function

    Function ComprobarDatosEmpresa() As Boolean
        Dim siRadio As Boolean = False
        Dim siCombo As Boolean = False

        'Departamentos
        For Each check As RadioButton In Pnl_radio.Controls
            If check.Checked Then
                siRadio = True
                depto = check.Tag
            End If
        Next
        If Not siRadio Then
            Err_depto.Text = "Campo obligatorio"
        Else
            Err_depto.Text = "*"
        End If

        'Periodos
        If Cbx_periodo.SelectedIndex = -1 Then
            Err_periodo.Text = "Campo obligatorio"
        Else
            Err_periodo.Text = "*"
            siCombo = True
            periodo = Cbx_periodo.SelectedItem.ToString()
        End If


        If siRadio And siCombo Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub insertarDatos()
        Dim cadena As String
        Dim comando As SqlCommand

        Try
            cadena = "INSERT INTO RegPersonal (Nombre, Apellidos, DNI, Departamento, Periodo, Nacimiento) VALUES ('" & nombre & "', '" & apellidos & "', '" & dni & "', " & depto & ", '" & periodo & "', '" & fecha & "')"
            comando = New SqlCommand(cadena, MiConexion)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MiConexion.Close()
    End Sub

    Private Sub obtenerRegistro()
        Dim cadena As String
        Dim comando As SqlCommand
        Dim registro As SqlDataReader

        Try
            cadena = "SELECT IDENT_CURRENT('RegPersonal') as total"
            comando = New SqlCommand(cadena, MiConexion)
            registro = comando.ExecuteReader()
            If registro.Read() Then
                lbl_registro.Text = registro("total") + 1
            End If
            registro.Close()

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub

    Function compruebaDNI(d As String) As Boolean

        Dim patron As String = "[0-9]{8}[a-zA-Z]"
        Dim r As Regex = New Regex(patron)

        If r.IsMatch(d) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
