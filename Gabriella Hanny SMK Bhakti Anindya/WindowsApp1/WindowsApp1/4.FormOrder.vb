Imports System.Data.SqlClient

Public Class FrmOrd

    Private Sub FrmOrd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMKRestorantDataSet3.Msmenu' table. You can move, or remove it, as needed.
        Me.MsmenuTableAdapter.Fill(Me.SMKRestorantDataSet3.Msmenu)

    End Sub

    Public Sub TTotal()
        Dim tot As Integer = 0
        For t As Integer = 0 To DGV2.Rows.Count - 1
            tot = tot + DGV2.Rows(t).Cells(4).Value
            TxTot.Text = tot
        Next
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick

        Dim row = DGV.CurrentRow
        TxName.Text = row.Cells(1).Value.ToString
        TxPrice.Text = row.Cells(2).Value.ToString
        Pho.ImageLocation = row.Cells(3).Value.ToString

    End Sub

    Private Sub TxQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxQty.KeyPress

        If Not Not (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            MsgBox("Hanya Masukan Angka (0-9)")
        End If

        If Not Not (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True

        End If

    End Sub

    Private Sub TxQty_TextChanged(sender As Object, e As EventArgs) Handles TxQty.TextChanged

        Dim row = DGV.CurrentRow
        Dim prices = row.Cells(2).Value.ToString

        If Not TxName.Text = "" Then

            If TxPrice.Text = "0" Or TxQty.Text = "0" Then

                TxPrice.Text = prices

            Else

                Dim qty As Integer
                Int32.TryParse(TxQty.Text, qty)
                Dim price As Integer
                Int32.TryParse(prices, price)

                TxPrice.Text = price * qty

            End If

        End If

    End Sub

    Private Sub BIns_Click(sender As Object, e As EventArgs) Handles BIns.Click

        Dim row = DGV.CurrentRow

        DGV2.Rows.Add(row.Cells(0).Value.ToString, TxName.Text, TxQty.Text, row.Cells(2).Value.ToString, TxPrice.Text, row.Cells(3).Value.ToString)

        TxQty.Clear()

        TTotal()

    End Sub

    Private Sub BDel_Click(sender As Object, e As EventArgs) Handles BDel.Click

        Dim index = DGV2.CurrentCell.RowIndex
        DGV2.Rows.RemoveAt(index)

        TTotal()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        koneksi()

        Dim ins = New SqlCommand("INSERT INTO HeaderOrder (EmployeeID, MemberID, Date, Payment, Bank, Status) VALUES ('','" & mid & "','" & Now & "','','','Pending')", cn)
        ins.ExecuteNonQuery()


        Dim sel = New SqlCommand("SELECT MAX(OrderID) FROM HeaderOrder", cn)
        Dim rd = sel.ExecuteReader
        rd.Read()

        Dim id = rd.Item(0).ToString
        rd.Close()

        For x As Integer = 0 To DGV2.Rows.Count - 1

            Dim i = New SqlCommand("INSERT INTO Detailorder (OrderID, MenuID, Qty, Price, Status) VALUES ('" & id & "','" & DGV2.Item(0, x).Value & "','" & DGV2.Item(2, x).Value & "','" & DGV2.Item(4, x).Value & "','Pending')", cn)
            i.ExecuteNonQuery()

        Next

        Close()
        FrmPay.Show()

    End Sub

End Class