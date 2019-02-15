Public Class FrmCashier
    Private Sub FrmChef_Load(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmChPw.Close()
        FrmVPay.Close()
        FrmWel.Show()

    End Sub

    Private Sub FrmCashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblUser.Text = unama
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BChPw.Click
        FrmChPw.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BOut.Click
        FrmWel.Show()
        Close()

    End Sub

    Private Sub Bmem_Click(sender As Object, e As EventArgs) Handles BPay.Click

        FrmVPay.Show()

    End Sub
End Class