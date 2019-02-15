Imports System.Data.SqlClient

Public Class FrmMemSU
    Private Sub ChPw_Click(sender As Object, e As EventArgs) Handles ChPw.Click

        koneksi()

        Dim i = New SqlCommand("INSERT INTO msmember (Name, Email, Handphone, JoinDate) VALUES ('" & TxName.Text & "','" & TxEmail.Text & "', '" & TXHP.Text & "', '" & Now & "')", cn)
        i.ExecuteNonQuery()
        MsgBox("Signed Up!")

        cn.Close()

        Close()

    End Sub

    Private Sub TXHP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXHP.KeyPress

        If Not Not (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            MsgBox("Hanya Masukan Angka (0-9)")
        End If

        If Not Not (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True

        End If

    End Sub

End Class