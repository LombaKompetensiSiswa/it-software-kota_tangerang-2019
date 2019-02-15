Imports System.Data.SqlClient

Public Class FrmVPay

    Private Sub OrdID_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles OrdID.SelectedIndexChanged

        koneksi()

        Dim y = New SqlDataAdapter("SELECT msmenu.Name as Menu, detailorder.qty, msmenu.price, detailorder.price FROM msmenu INNER JOIN detailorder ON msmenu.menuid = detailorder.menuid WHERE detailorder.OrderID = '" & OrdID.Text & "'", cn)
        Dim x = New DataTable
        y.Fill(x)

        DGV.DataSource = x

        Dim tot As Integer = 0
        For t As Integer = 0 To DGV.Rows.Count - 1
            tot = tot + DGV.Rows(t).Cells(3).Value
            TxTot.Text = tot
        Next

    End Sub

    Private Sub FrmVPay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMKRestorantDataSet6.Headerorder' table. You can move, or remove it, as needed.
        Me.HeaderorderTableAdapter1.Fill(Me.SMKRestorantDataSet6.Headerorder)

    End Sub
End Class