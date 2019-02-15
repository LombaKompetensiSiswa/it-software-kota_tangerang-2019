<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMvord
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.Pho = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxPri = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXDate = New System.Windows.Forms.TextBox()
        Me.TxNam = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToOrderColumns = True
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV.BackgroundColor = System.Drawing.Color.Tan
        Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DGV.Location = New System.Drawing.Point(304, 104)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(454, 326)
        Me.DGV.TabIndex = 93
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.AllowUserToDeleteRows = False
        Me.DGV1.AllowUserToOrderColumns = True
        Me.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV1.BackgroundColor = System.Drawing.Color.Tan
        Me.DGV1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.DGV1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV1.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DGV1.Location = New System.Drawing.Point(89, 106)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.ReadOnly = True
        Me.DGV1.Size = New System.Drawing.Size(198, 20)
        Me.DGV1.TabIndex = 94
        '
        'Pho
        '
        Me.Pho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pho.Location = New System.Drawing.Point(12, 143)
        Me.Pho.Name = "Pho"
        Me.Pho.Size = New System.Drawing.Size(275, 163)
        Me.Pho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pho.TabIndex = 115
        Me.Pho.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(12, 381)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 18)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Price"
        '
        'TxPri
        '
        Me.TxPri.BackColor = System.Drawing.Color.White
        Me.TxPri.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TxPri.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxPri.Location = New System.Drawing.Point(74, 380)
        Me.TxPri.Name = "TxPri"
        Me.TxPri.ReadOnly = True
        Me.TxPri.Size = New System.Drawing.Size(213, 22)
        Me.TxPri.TabIndex = 111
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(2, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 18)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "Order ID"
        '
        'TxTotal
        '
        Me.TxTotal.BackColor = System.Drawing.Color.White
        Me.TxTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxTotal.Location = New System.Drawing.Point(74, 408)
        Me.TxTotal.Name = "TxTotal"
        Me.TxTotal.Size = New System.Drawing.Size(213, 22)
        Me.TxTotal.TabIndex = 108
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(12, 412)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 26.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(229, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(275, 38)
        Me.Label3.TabIndex = 116
        Me.Label3.Text = "Form View Order"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(17, 353)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 18)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "Date"
        '
        'TXDate
        '
        Me.TXDate.BackColor = System.Drawing.Color.White
        Me.TXDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TXDate.Location = New System.Drawing.Point(74, 352)
        Me.TXDate.Name = "TXDate"
        Me.TXDate.Size = New System.Drawing.Size(213, 22)
        Me.TXDate.TabIndex = 118
        '
        'TxNam
        '
        Me.TxNam.BackColor = System.Drawing.Color.White
        Me.TxNam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxNam.Location = New System.Drawing.Point(74, 324)
        Me.TxNam.Name = "TxNam"
        Me.TxNam.Size = New System.Drawing.Size(213, 22)
        Me.TxNam.TabIndex = 120
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkRed
        Me.Label6.Location = New System.Drawing.Point(12, 325)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 18)
        Me.Label6.TabIndex = 119
        Me.Label6.Text = "Name"
        '
        'FrmMvord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxNam)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Pho)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxPri)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.DGV)
        Me.Name = "FrmMvord"
        Me.Text = "FrmMvord"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV As DataGridView
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents Pho As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxPri As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxTotal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TXDate As TextBox
    Friend WithEvents TxNam As TextBox
    Friend WithEvents Label6 As Label
End Class
