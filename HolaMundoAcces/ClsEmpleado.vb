Public Class ClsEmpleado
    Public Function conexion() As String
        Dim sCn As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SaloNet\Documents\dbAccess\HolaMundoAcces.accdb"
        Return sCn
    End Function
    Public Function listar_empleado() As DataSet
        Dim Datset As New DataSet
        Dim Conex As New OleDb.OleDbConnection
        Dim adaptador As New OleDb.OleDbDataAdapter
        Dim Consulta As New OleDb.OleDbCommand
        Conex.ConnectionString = conexion()
        Consulta.CommandType = CommandType.Text
        Consulta.CommandText = "select * from empleado"
        Consulta.Connection = Conex
        adaptador.SelectCommand = Consulta
        Conex.Open()
        adaptador.Fill(Datset)
        Conex.Close()
        Return Datset
    End Function
    Public Function Insertar_Empleado(ByVal nombre As String, ByVal apellido As String, ByVal edad As String, ByVal fechaEntrada As Date) As Integer
        Dim retorn As Integer
        Dim Conex As New OleDb.OleDbConnection
        Dim adaptador As New OleDb.OleDbDataAdapter
        Dim Consulta As New OleDb.OleDbCommand
        Conex.ConnectionString = conexion()
        Consulta.Connection = Conex
        Consulta.CommandType = CommandType.Text
        Consulta.CommandText = "INSERT INTO empleado(nombres,apellido,edad,fechaEntrada)values('" & nombre & "','" & apellido & "','" & edad & "','" & fechaEntrada & "')"
        Conex.Open()
        retorn = Consulta.ExecuteNonQuery() ' ExecuteScalar()
        Conex.Close()
        Return retorn
    End Function

    Public Function actualizar_empleado(ByVal nombre As String, ByVal apellido As String, ByVal edad As String, ByVal fechaEntrada As Date, ByVal id As Integer) As Integer
        Dim retorn As Integer
        Dim conex As New OleDb.OleDbConnection
        Dim adaptador As New OleDb.OleDbDataAdapter
        Dim Consulta As New OleDb.OleDbCommand
        conex.ConnectionString = conexion()
        Consulta.Connection = conex
        Consulta.CommandType = CommandType.Text
        Consulta.CommandText = "UPDATE empleado SET nombres='" & nombre & "',apellido='" & apellido & "',edad='" & edad & "',fechaEntrada ='" & fechaEntrada & "' WHERE Id=" & id & ""
        conex.Open()
        retorn = Consulta.ExecuteNonQuery
        conex.Close()
        Return retorn
    End Function

    Public Function Eliminar_Empleado(ByVal id As Integer) As Integer
        Dim iRet As Integer
        Dim conex As New OleDb.OleDbConnection
        Dim adaptador As New OleDb.OleDbDataAdapter
        Dim consulta As New OleDb.OleDbCommand
        conex.ConnectionString = conexion()
        consulta.Connection = conex
        consulta.CommandType = CommandType.Text
        consulta.CommandText = "DELETE FROM empleado WHERE id=" & id & ""
        conex.Open()
        iRet = consulta.ExecuteNonQuery
        conex.Close()
        Return iRet
    End Function
    Function listar_empleado_nombre(ByVal nombre As String) As DataSet
        Dim Datset As New DataSet
        'Dim objcadenaconexion As New ClsConexion
        Dim conex As New OleDb.OleDbConnection
        Dim adaptador As New OleDb.OleDbDataAdapter
        Dim Consulta As New OleDb.OleDbCommand
        conex.ConnectionString = conexion()
        Consulta.Connection = conex
        Consulta.CommandType = CommandType.Text
        Consulta.CommandText = "select nombres,apellido,edad,fechaEntrada FROM empleado where nombres like '%' + RTRIM('" & nombre & "') + '%'"
        ' oCmd.Parameters.Add("@NumeroFactura", SqlDbType.Char).Value = numero
        adaptador.SelectCommand = Consulta
        conex.Open()
        adaptador.Fill(Datset)
        conex.Close()
        Return Datset
    End Function
End Class
