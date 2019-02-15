Imports System.Data.SqlClient
Public Class FrmCashierNav
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmPayment.show
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmChangePass.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Logut As String
        Logut = MsgBox("apakah anda yakin ingin keluar", vbQuestion + vbYesNo, "logout")
        If Logut = vbYes Then
            FrmLogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub FrmCashierNav_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = nama
    End Sub
End Class