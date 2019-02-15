Imports System.Data.SqlClient

Public Class FrmChPw
    Private Sub ChPw_Click(sender As Object, e As EventArgs) Handles ChPw.Click


        If Opw.Text = pw Then

            If Npw.Text = String.Empty Or Cpw.Text = String.Empty Then

                MsgBox("Jangan biarkan form kosong.")

            Else

                If Npw.Text = Cpw.Text Then

                    koneksi()

                    Dim i = New SqlCommand("UPDATE msemployee SET password = '" & Npw.Text & "' WHERE employeeID = '" & uid & "' ", cn)
                    i.ExecuteNonQuery()
                    MsgBox("Password Changed.")

                    FrmAdmin.Close()
                    FrmChef.Close()
                    FrmCashier.Close()
                    FrmMnEmp.Close()
                    FrmMnMem.Close()
                    FrmMnMenu.Close()
                    FrmVord.Close()
                    FrmVPay.Close()
                    FrmWel.Show()
                    FrmLogin.Show()

                    Close()

                    MsgBox("Masukan Password Baru Anda.")

                Else

                    MsgBox("Password baru tidak sama")

                    End If

            End If

        Else

                MsgBox("Password lama tidak sama. ")

        End If

        'If Opw.Text = pw Then

    End Sub

End Class