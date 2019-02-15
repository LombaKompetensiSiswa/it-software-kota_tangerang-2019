Imports System.Data.SqlClient

Public Class FrmMnMem
    Private Sub FrmMnMem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMKRestorantDataSet1.Msmember' table. You can move, or remove it, as needed.
        Me.MsmemberTableAdapter.Fill(Me.SMKRestorantDataSet1.Msmember)

    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        Dim row = DGV.CurrentRow
        TxID.Text = row.Cells(0).Value.ToString
        TxName.Text = row.Cells(1).Value.ToString
        TxEmail.Text = row.Cells(2).Value.ToString

    End Sub

    Private Sub BDel_Click(sender As Object, e As EventArgs) Handles BDel.Click
        Dim i = New SqlCommand("DELETE FROM msmember WHERE MemberID = '" & TxID.Text & "'", cn)
        i.ExecuteNonQuery()
        MsgBox("Deleted.")
        Me.MsmemberTableAdapter.Fill(Me.SMKRestorantDataSet1.Msmember)

    End Sub

    Private Sub BIns_Click(sender As Object, e As EventArgs) Handles BIns.Click
        Dim i = New SqlCommand("INSERT INTO msmember (Name, Email, Handphone, JoinDate) VALUES ('" & TxName.Text & "','" & TxEmail.Text & "','','" & Now & "')", cn)
        i.ExecuteNonQuery()
        MsgBox("Inserted.")
        Me.MsmemberTableAdapter.Fill(Me.SMKRestorantDataSet1.Msmember)

    End Sub

    Private Sub BUpd_Click(sender As Object, e As EventArgs) Handles BUpd.Click
        Dim i = New SqlCommand("UPDATE msmember SET Name = '" & TxName.Text & "', Email = '" & TxEmail.Text & "' WHERE memberID = '" & TxID.Text & "'", cn)
        i.ExecuteNonQuery()
        MsgBox("Updated.")
        Me.MsmemberTableAdapter.Fill(Me.SMKRestorantDataSet1.Msmember)

    End Sub
End Class