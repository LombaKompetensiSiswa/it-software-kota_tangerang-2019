Imports System.Data.SqlClient
Public Class FrmViewOrder
    Private Sub FrmViewOrder_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If CloseReason.ApplicationExitCall Then
            FrmChefNav.Show()
        End If
    End Sub

    Sub getorder()
        Call Koneksi()
        cmd = New SqlCommand("SELECT OrderID from Headerorder", conn)
        dr = cmd.ExecuteReader
        While dr.Read()
            Dim idorder As Integer = 0
            idorder = dr.Item(0)
            ComboBox1.Items.Add(idorder)
        End While
    End Sub

    Private Sub FrmViewOrder_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call getorder()
        Call tampildata()
    End Sub

    Sub tampildata()
        Dim tampil As New DataGridViewColumn
        Call Koneksi()
        da = New SqlDataAdapter("SELECT Msmenu.Name,Detailorder.Qty From Detailorder inner join Msmenu on Msmenu.Menuid = Detailorder.Menuid where Orderid = '" & ComboBox1.Text & "' ", conn)
        ds = New DataSet
        da.Fill(ds, "Detailorder")
        DataGridView1.DataSource() = ds.Tables("Detailorder")
    End Sub

    Sub dd()
        Dim cc As New DataGridViewComboBoxColumn
        cc.HeaderText = "Action"
        cc.Name = "cc"
        cc.Items.AddRange("Pending,Deliver,Cooking")
        DataGridView1.Rows.Add(cc)
    End Sub
End Class