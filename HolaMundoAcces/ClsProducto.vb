Public Class ClsProducto
    Public Function conexion() As String
        Dim sCn As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SaloNet\Documents\dbAccess\HolaMundoAcces.accdb"
        Return sCn
    End Function
    Public Function listar_producto() As DataSet
        Dim Datset As New DataSet
        Dim Conex As New OleDb.OleDbConnection
        Dim adaptador As New OleDb.OleDbDataAdapter
        Dim Consulta As New OleDb.OleDbCommand
        Conex.ConnectionString = conexion()
        Consulta.CommandType = CommandType.Text
        Consulta.CommandText = "select * from producto"
        Consulta.Connection = Conex
        adaptador.SelectCommand = Consulta
        Conex.Open()
        adaptador.Fill(Datset)
        Conex.Close()
        Return Datset
    End Function
    Public Function Insertar_producto(ByVal descripcion As String, ByVal cantidad As String, ByVal marca As String, ByVal proveedor As String) As Integer
        Dim Datset As Integer
        Dim Conex As New OleDb.OleDbConnection
        Dim adaptador As New OleDb.OleDbDataAdapter
        Dim Consulta As New OleDb.OleDbCommand
        Conex.ConnectionString = conexion()
        Consulta.Connection = Conex
        Consulta.CommandType = CommandType.Text
        Consulta.CommandText = "INSERT INTO producto(descripcion,cantidad,marca,idproveedor)values('" & descripcion & "','" & cantidad & "','" & marca & "','" & proveedor & "')"
        Conex.Open()
        Datset = Consulta.ExecuteNonQuery() ' ExecuteScalar()
        Conex.Close()
        Return Datset
    End Function
    Public Function actualizar_producto(ByVal descripcion As String, ByVal cantidad As String, ByVal marca As String, ByVal proveedor As String, ByVal id As Integer) As Integer
        Dim retorn As Integer
        Dim Conex As New OleDb.OleDbConnection
        Dim adaptador As New OleDb.OleDbDataAdapter
        Dim Consulta As New OleDb.OleDbCommand
        Conex.ConnectionString = conexion()
        Consulta.Connection = Conex
        Consulta.CommandType = CommandType.Text
        Consulta.CommandText = "UPDATE producto SET descripcion='" & descripcion & "',cantidad='" & cantidad & "',marca='" & marca & "',idproveedor='" & proveedor & "' WHERE Id=" & id & ""
        Conex.Open()
        retorn = Consulta.ExecuteNonQuery
        Conex.Close()
        Return retorn
    End Function
    Function Listar_Proveedor_Combo() As DataSet
        Dim Datset As New DataSet
        Dim Conex As New OleDb.OleDbConnection
        Dim adaptador As New OleDb.OleDbDataAdapter
        Dim Consulta As New OleDb.OleDbCommand
        Conex.ConnectionString = conexion()
        Consulta.Connection = Conex
        Consulta.CommandType = CommandType.Text
        Consulta.CommandText = "Select idProveedor,nombre from proveedor"
        adaptador.SelectCommand = Consulta
        Conex.Open()
        adaptador.Fill(Datset)
        Conex.Close()
        Return Datset
    End Function
End Class
