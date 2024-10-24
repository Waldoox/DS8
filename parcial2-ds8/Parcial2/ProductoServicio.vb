Imports System.Data.SqlClient

Public Class ProductoServicio

    Private conexion As New ConexionBD()

    ' Método para insertar un nuevo producto
    Public Sub InsertarProducto(producto As Producto)
        Try
            Dim cmd As New SqlCommand("AgregarProducto", conexion.AbrirConexion())
            cmd.CommandType = CommandType.StoredProcedure

            ' Parámetros del procedimiento almacenado
            cmd.Parameters.AddWithValue("@NombreProducto", producto.NombreProducto)
            cmd.Parameters.AddWithValue("@Precio", producto.Precio)
            cmd.Parameters.AddWithValue("@Stock", producto.Stock)
            cmd.Parameters.AddWithValue("@FechaIngreso", producto.FechaIngreso)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conexion.CerrarConexion()
        End Try
    End Sub

    ' Método para obtener todos los productos
    Public Function ObtenerProductos() As List(Of Producto)
        Dim productos As New List(Of Producto)
        Try
            Dim cmd As New SqlCommand("ObtenerTodosLosProductos", conexion.AbrirConexion())
            cmd.CommandType = CommandType.StoredProcedure

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim producto As New Producto() With {
                    .ProductoID = reader("ProductoID"),
                    .NombreProducto = reader("NombreProducto"),
                    .Precio = reader("Precio"),
                    .Stock = reader("Stock"),
                    .FechaIngreso = reader("FechaIngreso"),
                    .Activo = reader("Activo")
                }
                productos.Add(producto)
            End While
        Catch ex As Exception
            Throw ex
        Finally
            conexion.CerrarConexion()
        End Try
        Return productos
    End Function
End Class
