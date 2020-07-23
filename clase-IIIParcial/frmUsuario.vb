Imports System.Text.RegularExpressions
Public Class frmUsuario
    Dim conexion As New conexion()
    Dim dt As DataTable
    Private srt As Object

    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TiendaDataSet.usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.TiendaDataSet.usuario)
        conexion.conectar()
        mostrarDatos()
    End Sub

    Private Function validarCorreo(ByVal isCorreo As String) As Boolean
        Return Regex.IsMatch(isCorreo, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function

    Private Sub Limpiar()
        txtCodigo.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtContraseña.Clear()
        txtCorreo.Clear()
        txtUsuario.Clear()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If validarCorreo(LCase(txtCorreo.Text)) = False Then
            MessageBox.Show("Correo invalido, *username@dominio.com*", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCorreo.Focus()
            txtCorreo.SelectAll()
            mostrarDatos()
        Else
            insertaUsuario()
            'MessageBox.Show("Correo valido,", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conexion.conexion.Close()

        End If

    End Sub
    Private Sub insertaUsuario()
        Dim idUsuario As Integer
        Dim nombre, apellido, userName, psw, correo, rol, estado As String
        idUsuario = txtCodigo.Text
        nombre = txtNombre.Text
        apellido = txtApellido.Text
        userName = txtUsuario.Text
        psw = txtContraseña.Text
        correo = txtCorreo.Text
        rol = cmbRol.Text
        estado = "activo"

        Try
            If conexion.insertarUsuario(idUsuario, (nombre), apellido, userName, psw, rol, estado, LCase(correo)) Then
                MessageBox.Show("Guardado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrarDatos()
            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.conexion.Close()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function mayus(str As String) As String
        Return SrtConv(srt, VbStrConv.ProperCase)
    End Function

    Private Function SrtConv(srt As Object, properCase As VbStrConv) As String
        Throw New NotImplementedException()
    End Function

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminarUsuario()
    End Sub

    Private Sub eliminarUsuario()
        Dim idUsuario As Integer
        Dim rol As String

        idUsuario = txtCodigo.Text
        rol = cmbRol.Text
        Try
            If (conexion.eliminarUsuario(idUsuario, rol)) Then
                MsgBox("Dado de baja")
                mostrarDatos()
            Else
                MsgBox("Error al dar de baja")
                conexion.conexion.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub mostrarDatos()
        Try

            conexion.consulta("select * from usuario", "usuario")

            dtgUsuario.DataSource = conexion.ds.Tables("usuario")
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.conexion.Close()

        End Try
    End Sub


    Private Sub llenarCampos(e As DataGridViewCellEventArgs)
        conexion.conexion.Close()
        Try
            Dim dtg As DataGridViewRow = dtgUsuario.Rows(e.RowIndex)
            txtCodigo.Text = dtg.Cells(0).Value.ToString()
            txtNombre.Text = dtg.Cells(1).Value.ToString()
            txtApellido.Text = dtg.Cells(2).Value.ToString()
            txtUsuario.Text = dtg.Cells(3).Value.ToString()
            txtContraseña.Text = dtg.Cells(4).Value.ToString()
            cmbRol.Text = dtg.Cells(5).Value.ToString()
            txtEstado.Text = dtg.Cells(6).Value.ToString()
            txtCorreo.Text = dtg.Cells(7).Value.ToString()
            conexion.conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.conexion.Close()
        End Try
    End Sub

    Private Sub dtgUsuario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        conexion.conexion.Close()
        llenarCampos(e)
    End Sub

    Private Sub btnModificar_Click_1(sender As Object, e As EventArgs) Handles btnModificar.Click
        modificarUsuario()
    End Sub

    Private Sub modificarUsuario()
        conexion.conexion.Close()
        Dim idUsuario As Integer
        Dim nombre, apellido, userName, psw, correo, rol As String
        idUsuario = txtCodigo.Text
        nombre = txtNombre.Text
        apellido = txtApellido.Text
        userName = txtUsuario.Text
        psw = txtContraseña.Text
        correo = txtCorreo.Text
        rol = cmbRol.Text

        Try
            conexion.conexion.Open()

            If (conexion.modificarUsuario(idUsuario, nombre, apellido, userName, psw, rol, correo)) Then
                MessageBox.Show("Actualizado")
                mostrarDatos()
                Limpiar()
                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al actualizar")
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.conexion.Close()
        End Try
    End Sub
    Private Sub mostrarBusqueda()

            Dim userName As String

            userName = txtUsuario.Text

            Try
                conexion.conexion.Open()

            If (conexion.buscar(userName)) Then
                dtgUsuario.DataSource = dt
                conexion.conexion.Close()
            Else
                dtgUsuario.DataSource = Nothing
                MsgBox("No se puedo encontrar el usuario")
                conexion.conexion.Close()

            End If
        Catch ex As Exception
                MsgBox(ex.Message)
                conexion.conexion.Close()
            End Try

    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        conexion.conexion.Close()
        mostrarBusqueda()
    End Sub

End Class
