Imports System.Data.SqlClient

Module Connection

    Public cn As SqlConnection
    Public mnama As String
    Public unama As String
    Public pw As String
    Public pos As String
    Public uid As String
    Public mid As String
    Public t As String

    Public Sub koneksi()


        t = ("Data Source=DESKTOP-783H1SP\SQLEXPRESS;Initial Catalog=SMKRestorant;Integrated Security=True")
        cn = New SqlConnection(t)
        cn.Open()

    End Sub

End Module
