Imports System.Data.SqlClient

Public Class FrmPay

    Private Sub FrmPay_Close(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If DGV.Columns.Contains("Filler") Then

            If DGV.Columns.Contains("Fillerx") Then

                Dim x = New SqlCommand("DELETE FROM DetailOrder WHERE orderID = '" & OrdID.Text & "'", cn)
                x.ExecuteNonQuery()
                Dim y = New SqlCommand("DELETE FROM HeaderOrder WHERE orderID = '" & OrdID.Text & "'", cn)
                y.ExecuteNonQuery()

                FrmWel.Show()
                FrmOrd.Close()

            End If

        End If

    End Sub

    Private Sub FrmPay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        koneksi()
        Dim sel = New SqlCommand("SELECT MAX(OrderID) FROM HeaderOrder", cn)
        Dim rd = sel.ExecuteReader
        rd.Read()

        OrdID.Text = rd.Item(0).ToString


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

        Dim l As New DataGridViewCheckBoxColumn
        l.Name = "filler"
        l.HeaderText = "filler"
        l.Visible = False

        DGV.Columns.Add(l)

        Dim ll As New DataGridViewCheckBoxColumn
        ll.Name = "fillerx"
        ll.HeaderText = "fillerx"
        ll.Visible = False

        DGV.Columns.Add(ll)


        'TODO: This line of code loads data into the 'SMKRestorantDataSet5.Headerorder' table. You can move, or remove it, as needed.
        Me.HeaderorderTableAdapter1.Fill(Me.SMKRestorantDataSet5.Headerorder)
        'TODO: This line of code loads data into the 'SMKRestorantDataSet4.Headerorder' table. You can move, or remove it, as needed.
        Me.HeaderorderTableAdapter.Fill(Me.SMKRestorantDataSet4.Headerorder)

    End Sub

    Private Sub OrdID_SelectedIndexChanged(sender As Object, e As EventArgs)


    End Sub


    Private Sub BPay_Click(sender As Object, e As EventArgs) Handles BPay.Click

        Dim i = New SqlCommand("UPDATE headerorder SET payment = '" & TxPayT.Text & "', Bank = '" & TxBankN.Text & "' WHERE OrderID = '" & OrdID.Text & "'", cn)
        i.ExecuteNonQuery()

        MsgBox("Terimakasih atas Pesanan Anda.")

        DGV.Columns.Remove("Filler")

        Close()
        FrmOrd.Close()
        FrmWel.Show()



    End Sub

    Private Sub TxCardN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxCardN.KeyPress

        If Not Not (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            MsgBox("Hanya Masukan Angka (0-9)")
        End If

        If Not Not (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BCancel.Click

        Close()

    End Sub


End Class