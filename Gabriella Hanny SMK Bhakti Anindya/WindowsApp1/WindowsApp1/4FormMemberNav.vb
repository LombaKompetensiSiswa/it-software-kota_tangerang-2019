Imports System.Data.SqlClient
Public Class FrmNavMember

    Private Sub FrmChef_Load(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmMvord.Close()
        FrmOrd.Close()
        FrmWel.Show()
        FrmPay.Close()

    End Sub

    Private Sub FrmNavMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblUser.Text = mnama

    End Sub

    Private Sub Bmen_Click(sender As Object, e As EventArgs) Handles Bmen.Click

        FrmMVord.Show()

    End Sub

    Private Sub Bemp_Click(sender As Object, e As EventArgs) Handles Bemp.Click
        FrmOrd.Show()

    End Sub

    Private Sub Bmem_Click(sender As Object, e As EventArgs)
        'FrmReview.Show()

    End Sub

    Private Sub BOut_Click(sender As Object, e As EventArgs) Handles BOut.Click

    End Sub
End Class