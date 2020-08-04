Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class frmUsuario
    Dim conexion As New conexion()
    Dim dt As DataTable


    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                Limpiar()
                insertaUsuario()
                mostrarDatos()
                'MessageBox.Show("Correo valido,", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conexion.conexion.Close()

            End If

    End Sub
    Private Sub insertaUsuario()
        Dim idUsuario As Integer
        Dim nombre, apellido, userName, psw, correo, rol, estado As String
        idUsuario = Val(txtCodigo.Text)
        nombre = txtNombre.Text
        apellido = txtApellido.Text
        userName = txtUsuario.Text
        psw = txtContraseña.Text
        correo = txtCorreo.Text
        estado = "activo"
        rol = cmbRol.Text


        Try
            If conexion.insertarUsuario(idUsuario, nombre, apellido, userName, psw, rol, estado, correo) Then
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

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim Cancel As Integer

        Try
            If (MsgBox("¿Esta seguro que desea eliminar este servicio?", vbCritical + vbYesNo) = vbYes) Then
                eliminarUsuario()
            Else
                Cancel = 1
            End If
        Catch ex As Exception
            MsgBox("ex.Message")
        End Try
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



    Private Sub btnModificar_Click_1(sender As Object, e As EventArgs) Handles btnModificar.Click
        modificarUsuario()
    End Sub

    Private Sub modificarUsuario()

        Dim idUsuario As Integer
        Dim nombre, apellido, userName, psw, correo, rol As String
        idUsuario = Val(txtCodigo.Text)
        nombre = txtNombre.Text
        apellido = txtApellido.Text
        userName = txtUsuario.Text
        psw = txtContraseña.Text
        correo = txtCorreo.Text
        rol = cmbRol.Text

        Try
            If (conexion.modificarUsuario(idUsuario, nombre, apellido, userName, psw, rol, correo)) Then
                MessageBox.Show("Actualizado")
                mostrarDatos()
                Limpiar()
                'conexion.conexion.Close()
            Else
                MessageBox.Show("Error al actualizar")
                'conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            mostrarDatos()
            conexion.conexion.Close()
        End Try
    End Sub

    Private Sub mostrarBusqueda()
        Try
            dt = conexion.buscarUsuario(" usuario ", " nombreUsuario like '%" + txtBuscar.Text + "%'")
            If dt.Rows.Count <> 0 Then
                dtgUsuario.DataSource = dt
                conexion.conexion.Close()
            Else
                dtgUsuario.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        conexion.conexion.Close()
        mostrarBusqueda()
    End Sub

    Private Sub dtgUsuario_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dtgUsuario.CellContentClick
        llenarCampos(e)
    End Sub



    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

        txtNombre.Text = StrConv(txtNombre.Text, vbProperCase)
        txtNombre.SelectionStart = Len(txtNombre.Text)
    End Sub

    Private Sub txtApellido_TextChanged(sender As Object, e As EventArgs) Handles txtApellido.TextChanged

        txtApellido.Text = StrConv(txtApellido.Text, vbProperCase)
        txtApellido.SelectionStart = Len(txtApellido.Text)
    End Sub
End Class
