Imports System.Data.SqlClient
Public Class conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source= DORISMEZA\SQLEXPRESS;Initial Catalog=Tienda; Integrated Security=True")
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public cmb As SqlCommand
    Public dr As SqlDataReader

    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conectado")

        Catch ex As Exception
            MessageBox.Show("Error")
        Finally
            conexion.Close()
        End Try

    End Sub

    Public Function insertarUsuario(idUsuario As Integer, nombre As String, apellido As String, userName As String,
                                    psw As String, rol As String, estado As String, correo As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("insertarUsuario", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@idUsuario", idUsuario)
            cmb.Parameters.AddWithValue("@nombre", nombre)
            cmb.Parameters.AddWithValue("@apellido", apellido)
            cmb.Parameters.AddWithValue("@userName", userName)
            cmb.Parameters.AddWithValue("@psw", psw)
            cmb.Parameters.AddWithValue("@rol", rol)
            cmb.Parameters.AddWithValue("@estado", estado)
            cmb.Parameters.AddWithValue("@correo", correo)

            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()
        End Try

    End Function

    Public Function eliminarUsuario(idUsuario As Integer, rol As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("eliminarUsuario", conexion)
            cmb.CommandType = 4
            cmb.Parameters.AddWithValue("@idUsuario", idUsuario)
            cmb.Parameters.AddWithValue("@rol", rol)
            If cmb.ExecuteNonQuery <> 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()

        End Try
    End Function

    Public Function modificarUsuario(idUsuario As Integer, nombre As String, apellido As String, userName As String,
                                    psw As String, rol As String, correo As String)


        Try
            conexion.Open()
            cmb = New SqlCommand("modificarUsuario", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@idUsuario", idUsuario)
            cmb.Parameters.AddWithValue("@nombre", nombre)
            cmb.Parameters.AddWithValue("@apellido", apellido)
            cmb.Parameters.AddWithValue("@userName", userName)
            cmb.Parameters.AddWithValue("@psw", psw)
            cmb.Parameters.AddWithValue("@rol", rol)
            cmb.Parameters.AddWithValue("@correo", correo)

            If cmb.ExecuteNonQuery <> 0 Then
                Return True
            Else
                Return False

            End If


            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Function


    Public Function consulta()
        Try
            conexion.Open()

            cmb = New SqlCommand("consultaUsuario", conexion)

            cmb.CommandType = CommandType.StoredProcedure

            If cmb.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmb)
                da.Fill(dt)
                Return dt
                conexion.Close()
            Else
                Return Nothing
                conexion.Close()
            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()
            Return Nothing
        End Try
    End Function

    Public Function buscar(userName As String)
        Try
            Dim dt As DataTable
            conexion.Open()
            cmb = New SqlCommand("buscarUsuario", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@userName", userName)
            da.Fill(dt)
            If cmb.ExecuteNonQuery Then
                Return True
                conexion.Close()
            Else
                Return False
                conexion.Close()
            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
            conexion.Close()
        End Try
    End Function





    'Public Function validarUsuario(ByVal codigo As String) As Boolean
    'Dim resultado As Boolean = False
    'Try
    '       conexion.Open()
    '
    ' cmb = New SqlCommand("select * from personas.estudiante where codigo='" + codigo + "'", conexion)
    'dr = cmb.ExecuteReader
    'If dr.Read Then
    '           resultado = True
    'End If
    '       dr.Close()
    'Catch ex As Exception
    '       MsgBox(ex.Message)
    'End Try
    'Return resultado
    'End Function*/

End Class
