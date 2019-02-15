Imports System.Data.SqlClient
Public Class FrmLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksi()
        cmd = New SqlCommand("SELECT * From Msemployee Where Email = '" & TextBox1.Text & "' and Password ='" & TextBox2.Text & "' ", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            MsgBox("Login gagal")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox1.Focus()
        Else
            pos = dr.Item(5).ToString
            nama = dr.Item(1).ToString
            pas = dr.Item(3).ToString
            employeeid = dr.Item(0).ToString
            Select Case pos
                Case "Admin"
                    FrmAdminNav.Show()
                Case "Chef"
                    FrmChefNav.Show()
                Case "Cashier"
                    FrmCashierNav.Show()
            End Select
            Visible = True
            Me.Hide()
        End If
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
End Class