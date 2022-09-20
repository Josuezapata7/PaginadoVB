Imports System.Data.Odbc

Module Conexion_ODBC
    Dim conexionODBC As New OdbcConnection

    Public Sub Conectar(connection_string As String)
        conexionODBC.ConnectionString = connection_string
        Try
            conexionODBC.Open()
            Console.WriteLine("Conectado")
        Catch ex As ODBCException
            MsgBox(ex.ToString())
        End Try

    End Sub

    Public Sub Cerrar()
        conexionODBC.Close()
    End Sub

    Public Function Hacer_consulta(query As String) As DataTable
        Dim datos As New DataTable
        Dim adaptador As New OdbcDataAdapter(query, conexionODBC)
        adaptador.Fill(datos)
        Return datos
    End Function

    Public Function CONNECTION_STRING() As String
        Dim cnx_string As String
        cnx_string = "
        Driver={IBM INFORMIX ODBC DRIVER};
        Database=miBD;
        Host=192.168.247.128;
        Server=miServidor;
        Service=50000;
        Protocol=onsoctcp;
        UID=" & NOMBRE_USUARIO() &
        ";PWD=" & PASSWORD() & ";"
        Return cnx_string
    End Function

    Public Function NOMBRE_USUARIO() As String
        Return "admin"
    End Function

    Public Function PASSWORD() As String
        Return "1234"
    End Function

End Module
