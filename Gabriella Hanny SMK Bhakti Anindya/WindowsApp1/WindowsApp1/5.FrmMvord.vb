Imports System.Data.SqlClient

Public Class FrmMvord
    Private Sub FrmMvord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()

        Dim y = New SqlDataAdapter("SELECT orderid, Date FROM Headerorder WHERE MemberID = '" & mid & "'", cn)
        Dim x = New DataTable
        y.Fill(x)

        DGV1.DataSource = x

        DGV1.ColumnHeadersVisible = False
        DGV1.RowHeadersVisible = False

        DGV1.Columns(1).Visible = False

        cn.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellClick


        koneksi()

        Dim y = New SqlDataAdapter("SELECT Detailorder.detailID, DetailOrder.OrderID, msmenu.menuID, msmenu.Name as Menu, detailorder.qty, msmenu.price, detailorder.price, Detailorder.Status, msmenu.photo FROM Detailorder INNER JOIN MsMenu ON detailorder.MenuID = msmenu.MenuID WHERE detailorder.OrderID = '" & DGV1.CurrentCell.Value.ToString & "'", cn)
        Dim x = New DataTable
        y.Fill(x)


        DGV.DataSource = x
        DGV.Columns(0).Visible = False
        DGV.Columns(1).Visible = False
        DGV.Columns(2).Visible = False
        DGV.Columns(5).Visible = False
        DGV.Columns(6).Visible = False
        DGV.Columns(8).Visible = False
        DGV.RowHeadersVisible = False

        TxNam.Text = DGV.Rows(0).Cells(3).Value.ToString
        TxPri.Text = DGV.Rows(0).Cells(4).Value.ToString
        TxTotal.Text = DGV.Rows(0).Cells(5).Value.ToString
        TXDate.Text = DGV1.CurrentRow.Cells(1).Value.ToString
        Pho.ImageLocation = DGV.Rows(0).Cells(8).Value.ToString

    End Sub


    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick

        Dim row = DGV.CurrentRow
        TxNam.Text = row.Cells(3).Value.ToString
        TxPri.Text = row.Cells(5).Value.ToString
        TxTotal.Text = row.Cells(6).Value.ToString
        Pho.ImageLocation = row.Cells(8).Value.ToString

    End Sub

End Class