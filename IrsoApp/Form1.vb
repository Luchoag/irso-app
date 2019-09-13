Imports System.IO
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("http://distancia.irso.edu.ar/moodle/login/index.php")
        cicloLectivo()
        elegirAño()
        elegirSeccion()
    End Sub

    Sub cicloLectivo()
        comboCicloLectivo.Items.Add("2019")
        comboCicloLectivo.Items.Add("2018")
        comboCicloLectivo.Items.Add("2017")
        comboCicloLectivo.SelectedIndex = 0
    End Sub

    Sub elegirAño()
        comboAño.Items.Add("1er Año")
        comboAño.Items.Add("2do Año")
        comboAño.Items.Add("3er Año")
        comboAño.SelectedIndex = 0
        elegirMateria()
    End Sub

    Sub elegirMateria()
        If comboAño.SelectedIndex = 0 Then
            comboMateria.Items.Clear()
            comboMateria.Items.Add("Álgebra")
            comboMateria.Items.Add("Estructura de un Computador")
            comboMateria.Items.Add("Gestión Administrativa")
            comboMateria.Items.Add("Inglés Técnico")
            comboMateria.Items.Add("Programación I")
            comboMateria.Items.Add("Teoría de Sistemas")
        ElseIf comboAño.SelectedIndex = 1 Then
            comboMateria.Items.Clear()
            comboMateria.Items.Add("Análisis Matemático")
            comboMateria.Items.Add("Base de Datos")
            comboMateria.Items.Add("Ética Profesional")
            comboMateria.Items.Add("Integración de Programación")
            comboMateria.Items.Add("Probabilidad y Estadística")
            comboMateria.Items.Add("Programación II")
            comboMateria.Items.Add("Redes")
        ElseIf comboAño.SelectedIndex = 2 Then
            comboMateria.Items.Clear()
            comboMateria.Items.Add("Administración de Proyectos")
            comboMateria.Items.Add("Análisis y DIseño de Sistemas")
            comboMateria.Items.Add("Desarrollo e Integración Profesional")
            comboMateria.Items.Add("Estructura e Información de las Org.")
            comboMateria.Items.Add("Investigación Operativa")
            comboMateria.Items.Add("Paradigmas Tecnológicos")
            comboMateria.Items.Add("Seguridad y Calidad del Software")
        End If
        comboMateria.SelectedIndex = 0
    End Sub

    Sub elegirSeccion()
        comboSeccion.Items.Add("Principal")
        comboSeccion.Items.Add("Calificaciones")
        comboSeccion.SelectedIndex = 0
    End Sub

    Private Sub comboAño_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboAño.SelectedIndexChanged
        elegirMateria()
    End Sub

    Private Sub btnIr_Click(sender As Object, e As EventArgs) Handles btnIr.Click
        WebBrowser1.Navigate(asignarLink())
        WebBrowser1.Document.Focus()
    End Sub

    Function asignarId() As String
        Dim id As String = "0"
        Select Case comboCicloLectivo.SelectedIndex
            Case 0
                If comboAño.SelectedItem = "1er Año" Then
                    id = comboMateria.SelectedIndex + "168"
                ElseIf comboAño.SelectedItem = "2do Año" Then
                    id = comboMateria.SelectedIndex + "174"
                ElseIf comboAño.SelectedItem = "3er Año" Then
                    id = comboMateria.SelectedIndex + "181"
                End If
            Case 1
                If comboAño.SelectedItem = "1er Año" Then
                    id = comboMateria.SelectedIndex + "148"
                ElseIf comboAño.SelectedItem = "2do Año" Then
                    id = comboMateria.SelectedIndex + "154"
                ElseIf comboAño.SelectedItem = "3er Año" Then
                    id = comboMateria.SelectedIndex + "161"
                End If
            Case 2
                If comboAño.SelectedItem = "1er Año" Then
                    id = comboMateria.SelectedIndex + "127"
                ElseIf comboAño.SelectedItem = "2do Año" Then
                    id = comboMateria.SelectedIndex + "133"
                ElseIf comboAño.SelectedItem = "3er Año" Then
                    id = comboMateria.SelectedIndex + "141"
                End If
        End Select
        asignarId = id
    End Function

    Function asignarLink() As String
        Dim linkPrincipal As String = "http://distancia.irso.edu.ar/moodle/course/view.php?id="
        Dim linkCalificaciones As String = "http://distancia.irso.edu.ar/moodle/grade/report/index.php?id="
        If comboSeccion.SelectedItem = "Principal" Then
            linkPrincipal = linkPrincipal & asignarId()
            asignarLink = linkPrincipal
        ElseIf comboSeccion.SelectedItem = "Calificaciones" Then
            linkCalificaciones = linkCalificaciones & asignarId()
            asignarLink = linkCalificaciones
        Else : asignarLink = "Error"
        End If

    End Function

    Private Sub pictureUser_Click(sender As Object, e As EventArgs) Handles pictureUser.Click, labelPerfil.Click
        abrirUsuario()
    End Sub

    Private Sub pictureMensajes_Click(sender As Object, e As EventArgs) Handles pictureMensajes.Click, labelMensaje.Click
        WebBrowser1.Navigate("http://distancia.irso.edu.ar/moodle/message/index.php")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub btnFwd_Click(sender As Object, e As EventArgs) Handles btnFwd.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub pictureConfig_Click(sender As Object, e As EventArgs) Handles pictureConfig.Click, labelConfig.Click
        If File.Exists("userID.txt") Then
            Dim respuesta As Integer = MsgBox("¿Desea modificar su número de ID?", MsgBoxStyle.OkCancel, "Modificación de Usuario")
            If respuesta = 1 Then
                File.Delete("userID.txt")
                abrirUsuario()
            End If
        Else
            abrirUsuario()
        End If
    End Sub

    Sub abrirUsuario()
        Dim idUsuario As String = "http://distancia.irso.edu.ar/moodle/user/profile.php?id="
        Dim file1 As System.IO.StreamWriter
        Dim file2 As System.IO.StreamReader
        Dim input As String
        If File.Exists("userID.txt") Then
            file2 = My.Computer.FileSystem.OpenTextFileReader("userID.txt")
            WebBrowser1.Navigate(idUsuario & file2.ReadLine())
            file2.Close()
        Else
            input = InputBox("Ingrese su número de ID de la plataforma IRSO. El mismo puede verse al entrar a su perfil desde un navegador, siendo los últimos digitos de la URL. Esta configuración es necesaria por única vez.", "Configuración de usuario")
            If Not String.IsNullOrEmpty(input) Then
                File.Create("userID.txt").Dispose()
                file1 = My.Computer.FileSystem.OpenTextFileWriter("userID.txt", True)
                file1.WriteLine(input)
                WebBrowser1.Navigate(idUsuario & input)
                file1.Close()
            End If
        End If
    End Sub

End Class

