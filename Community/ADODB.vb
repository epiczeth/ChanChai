Imports System.Data.SqlClient
Imports System.IO
Public Class ADODB
    Private strConn As String
    Function GetConnect() As SqlConnection
        Dim conn As New SqlConnection(strConn)
        If conn.State <> ConnectionState.Closed Then
            conn.Close()
        End If
        conn.Open()
        Return conn
    End Function
    Public Sub New ()
        strConn = File.ReadAllText(Environment.CurrentDirectory & "\config\constr.txt")
    End Sub
    Function GetDataTable(ByVal sqlstr As String) As DataTable
        Dim ds As New DataSet
        Dim sql As New SqlDataAdapter(sqlstr, GetConnect())
        Return ds.Tables(0)
    End Function

    Function GetExecutedCommand(ByVal sqlstr As String) As Integer
        Dim cmd As New SqlCommand(sqlstr, GetConnect())
        Return cmd.ExecuteNonQuery()
    End Function


    Function GetRowsAffected(ByVal sqlstr As String) As Integer
        Dim ds As New DataSet
        Dim adapter As New SqlDataAdapter(sqlstr, GetConnect())
        adapter.Fill(ds)
        Return ds.Tables(0).Rows.Count
    End Function
End Class
