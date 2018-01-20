Public Class ClsCombosRelacionados
    Public Function conexion() As String
        Dim sCn As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SaloNet\Documents\dbAccess\HolaMundoAcces.accdb"
        Return sCn
    End Function


    Public Function listar_Combo_Departamento() As DataSet
        Dim Datset As New DataSet
        Dim Conex As New OleDb.OleDbConnection
        Dim adaptador As New OleDb.OleDbDataAdapter
        Dim Consulta As New OleDb.OleDbCommand
        Conex.ConnectionString = conexion()
        Consulta.CommandType = CommandType.Text
        Consulta.CommandText = "select * from departamento"
        Consulta.Connection = Conex
        adaptador.SelectCommand = Consulta
        Conex.Open()
        adaptador.Fill(Datset)
        Conex.Close()
        Return Datset
    End Function


    Public Function listar_Combo_Provincia(ByVal departamento As Integer) As DataSet
        Dim Datset As New DataSet
        Dim Conex As New OleDb.OleDbConnection
        Dim adaptador As New OleDb.OleDbDataAdapter
        Dim Consulta As New OleDb.OleDbCommand
        Conex.ConnectionString = conexion()
        Consulta.CommandType = CommandType.Text
        Consulta.CommandText = "select * from provincia where iddepartamento = " & departamento & " "
        Consulta.Connection = Conex
        adaptador.SelectCommand = Consulta
        Conex.Open()
        adaptador.Fill(Datset)
        Conex.Close()
        Return Datset
    End Function

End Class
