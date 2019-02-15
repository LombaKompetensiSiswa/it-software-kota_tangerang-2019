Imports System.Data.SqlClient

Public Class FrmLogin

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        koneksi()

        Dim cmd = New SqlCommand("SELECT * FROM Msemployee WHERE Email = '" & txEmail.Text & "' AND Password = '" & TxPw.Text & "'", cn)
        Dim rd = cmd.ExecuteReader()
        rd.Read()

        If rd.HasRows Then

            Close()
            FrmMLogin.Close()
            FrmWel.Hide()

            uid = rd.Item(0).ToString
            unama = rd.Item(1).ToString
            pw = rd.Item(3).ToString
            pos = rd.Item(5).ToString

            Select Case pos.Trim()
                Case "Admin"
                    FrmAdmin.Show()
                Case "Chef"
                    FrmChef.Show()
                Case "Cashier"
                    FrmCashier.Show()
            End Select

        Else

            MsgBox("Login Gagal")

        End If

    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class