Imports System.Data.SqlClient
Public Class FrmChangePass
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "") Or (TextBox1.Text = "") Or (TextBox1.Text = "") Then
            MsgBox("masukan data terlebih dahulu")
        ElseIf (TextBox1.Text <> pas) Then
            MsgBox("password lama salah")
        ElseIf (TextBox2.Text <> TextBox3.Text) Then
            MsgBox("password baru tidak sama dengan password konfirmasi")
        Else
            Call koneksi()
            cmd = New SqlCommand("UPDATE Msemployee SET Password ='" & TextBox3.Text & "' WHERE EmployeeID = '" & employeeid & "' ", conn)
            cmd.ExecuteNonQuery()
            MsgBox("password berhasil diganti")
            FrmLogin.Show()
            Me.Hide()
        End If
    End Sub
End Class