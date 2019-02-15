Imports System.Data.SqlClient


Public Class FrmVord

    Private Sub FrmVord_Exit(sender As Object, e As EventArgs) Handles Me.MouseLeave

        UpdVal()

    End Sub

    Private Sub FrmVord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMKRestorantDataSet7.Headerorder' table. You can move, or remove it, as needed.
        Me.HeaderorderTableAdapter.Fill(Me.SMKRestorantDataSet7.Headerorder)

        'OrdID.BackColor = Color.White

    End Sub

    Private Sub OrdID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OrdID.SelectedIndexChanged


        If DGV.Rows.Count = 0 Then

            Datax()

            If DGV.Columns(0).Visible = True Then

                hidel()

                If Not DGV.Columns.Contains("Action") Then

                    cc()
                    CCVal()

                End If

            End If

        End If

        If DGV.Rows.Count > 0 Then

            DGV.DataSource.clear
            DGV.Columns.Clear()
            Datax()
            hidel()
            cc()
            CCVal()

        End If




    End Sub

    Public Sub Datax()

        koneksi()

        Dim y = New SqlDataAdapter("SELECT Detailorder.detailID, DetailOrder.OrderID, msmenu.menuID, msmenu.Name as Menu, detailorder.qty, Detailorder.Status FROM Detailorder INNER JOIN MsMenu ON detailorder.MenuID = msmenu.MenuID WHERE detailorder.OrderID = '" & OrdID.Text & "'", cn)
        Dim x = New DataTable
        y.Fill(x)

        DGV.DataSource = x

    End Sub

    Public Sub CCVal()


        For i As Integer = 0 To DGV.Rows.Count - 1

            DGV.Item("CCB", i).Value = DGV.Item("Status", i).Value

        Next

    End Sub

    Public Sub hidel()

        DGV.Columns(0).Visible = False
        DGV.Columns(1).Visible = False
        DGV.Columns(2).Visible = False
        DGV.Columns(5).Visible = False

        DGV.Columns(3).ReadOnly = True
        DGV.Columns(4).ReadOnly = True

    End Sub

    Public Sub cc()

        Dim l As New DataGridViewComboBoxColumn
        l.Name = "CCB"
        l.HeaderText = "Action"
        l.Items.AddRange("Pending", "Cooking", "Deliver", "Done")

        DGV.Columns.Add(l)

    End Sub















    Private Sub UpdVal()

        If DGV.Columns.Contains("Filler") Then

            koneksi()

            Dim cell = DGV.CurrentCell.RowIndex

            Dim x = DGV.Item(6, cell).Value.ToString
            Dim y = DGV.Rows(cell).Cells(0).Value.ToString

            Dim Insert2 = New SqlCommand("UPDATE detailorder SET Status = '" & x & "' WHERE DetailID = '" & y & "'", cn)

            Insert2.ExecuteNonQuery()

            Dim insert1 = New SqlCommand("UPDATE headerorder SET employeeID = '" & uid & "' WHERE OrderID = '" & OrdID.Text & "'", cn)

            insert1.ExecuteNonQuery()


            Dim l As New DataGridViewCheckBoxColumn
            l.Name = "fillerx"
            l.HeaderText = "fillerx"
            l.Visible = False

            DGV.Columns.Add(l)

        End If



    End Sub

    Private Sub DGV_Cell(sender As Object, e As EventArgs) Handles DGV.EditingControlShowing

        Dim l As New DataGridViewCheckBoxColumn
        l.Name = "filler"
        l.HeaderText = "filler"
        l.Visible = False

        DGV.Columns.Add(l)

    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As EventArgs) Handles DGV.CellMouseLeave

        UpdVal()

    End Sub


    Private Sub DGV_ColumnAdded(sender As Object, e As EventArgs) Handles DGV.ColumnAdded

        If DGV.Columns.Contains("FillerX") Then

            DGV.Columns.Remove("Filler")
            DGV.Columns.Remove("FillerX")

        End If

    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellMouseLeave
        UpdVal()
    End Sub

End Class