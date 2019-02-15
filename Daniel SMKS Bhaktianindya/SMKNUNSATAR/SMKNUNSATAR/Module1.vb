Imports System.Data.SqlClient
Module Module1
    Public da As SqlDataAdapter
    Public dr As SqlDataReader
    Public ds As DataSet
    Public conn As SqlConnection
    Public str As String
    Public cmd As SqlCommand
    Public nama As String
    Public pos As String
    Public employeeid As String
    Public pas As String
    Public orderid As Integer

    Sub Koneksi()
        str = "Data Source=DESKTOP-774DQEU\SQLEXPRESS;Initial Catalog=SMKNUSANTARA;Integrated Security=True"
        conn = New SqlConnection(str)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
