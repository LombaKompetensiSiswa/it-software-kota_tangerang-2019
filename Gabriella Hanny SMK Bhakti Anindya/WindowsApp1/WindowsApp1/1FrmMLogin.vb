Imports System.Data.SqlClient

Public Class FrmMLogin
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        koneksi()

        Dim cmd = New SqlCommand("SELECT * FROM msmember WHERE Name = '" & txName.Text & "' AND Email = '" & TxEmail.Text & "'", cn)
        Dim rd = cmd.ExecuteReader()
        rd.Read()

        If rd.HasRows Then

            Close()
            FrmLogin.Close()
            FrmWel.Hide()

            mnama = rd.Item(1).ToString
            mid = rd.Item(0).ToString

            FrmNavMember.Show()
            'FrmOrd.Show()
            'FrmPay.Show()

        Else

            MsgBox("Login Gagal.")

        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        FrmMemSU.Show()


    End Sub
End Class