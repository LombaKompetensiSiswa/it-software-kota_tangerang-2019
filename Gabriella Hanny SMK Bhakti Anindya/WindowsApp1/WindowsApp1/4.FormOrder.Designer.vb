<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrd
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
        Me.components = New System.ComponentModel.Container()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.MenuIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhotoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MsmenuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMKRestorantDataSet3 = New WindowsApp1.SMKRestorantDataSet3()
        Me.Total1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV2 = New System.Windows.Forms.DataGridView()
        Me.MenuID1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Menu1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Photo1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxTot = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Pho = New System.Windows.Forms.PictureBox()
        Me.BDel = New System.Windows.Forms.Button()
        Me.BIns = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxName = New System.Windows.Forms.TextBox()
        Me.TxQty = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MsmenuTableAdapter = New WindowsApp1.SMKRestorantDataSet3TableAdapters.MsmenuTableAdapter()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MsmenuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMKRestorantDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AutoGenerateColumns = False
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV.BackgroundColor = System.Drawing.Color.Tan
        Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MenuIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.PhotoDataGridViewTextBoxColumn})
        Me.DGV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV.DataSource = Me.MsmenuBindingSource
        Me.DGV.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DGV.Location = New System.Drawing.Point(12, 12)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(690, 226)
        Me.DGV.TabIndex = 96
        '
        'MenuIDDataGridViewTextBoxColumn
        '
        Me.MenuIDDataGridViewTextBoxColumn.DataPropertyName = "MenuID"
        Me.MenuIDDataGridViewTextBoxColumn.HeaderText = "MenuID"
        Me.MenuIDDataGridViewTextBoxColumn.Name = "MenuIDDataGridViewTextBoxColumn"
        Me.MenuIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.MenuIDDataGridViewTextBoxColumn.Visible = False
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Menu"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PhotoDataGridViewTextBoxColumn
        '
        Me.PhotoDataGridViewTextBoxColumn.DataPropertyName = "Photo"
        Me.PhotoDataGridViewTextBoxColumn.HeaderText = "Photo"
        Me.PhotoDataGridViewTextBoxColumn.Name = "PhotoDataGridViewTextBoxColumn"
        Me.PhotoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PhotoDataGridViewTextBoxColumn.Visible = False
        '
        'MsmenuBindingSource
        '
        Me.MsmenuBindingSource.DataMember = "Msmenu"
        Me.MsmenuBindingSource.DataSource = Me.SMKRestorantDataSet3
        '
        'SMKRestorantDataSet3
        '
        Me.SMKRestorantDataSet3.DataSetName = "SMKRestorantDataSet3"
        Me.SMKRestorantDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Total1
        '
        Me.Total1.HeaderText = "Total"
        Me.Total1.Name = "Total1"
        Me.Total1.ReadOnly = True
        '
        'DGV2
        '
        Me.DGV2.AllowUserToAddRows = False
        Me.DGV2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV2.BackgroundColor = System.Drawing.Color.Tan
        Me.DGV2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.DGV2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MenuID1, Me.Menu1, Me.Qty1, Me.Price1, Me.Total1, Me.Photo1})
        Me.DGV2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV2.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DGV2.Location = New System.Drawing.Point(12, 432)
        Me.DGV2.Name = "DGV2"
        Me.DGV2.ReadOnly = True
        Me.DGV2.Size = New System.Drawing.Size(687, 198)
        Me.DGV2.TabIndex = 97
        '
        'MenuID1
        '
        Me.MenuID1.HeaderText = "MenuID"
        Me.MenuID1.Name = "MenuID1"
        Me.MenuID1.ReadOnly = True
        Me.MenuID1.Visible = False
        '
        'Menu1
        '
        Me.Menu1.HeaderText = "Menu"
        Me.Menu1.Name = "Menu1"
        Me.Menu1.ReadOnly = True
        '
        'Qty1
        '
        Me.Qty1.HeaderText = "Qty"
        Me.Qty1.Name = "Qty1"
        Me.Qty1.ReadOnly = True
        '
        'Price1
        '
        Me.Price1.HeaderText = "Price"
        Me.Price1.Name = "Price1"
        Me.Price1.ReadOnly = True
        '
        'Photo1
        '
        Me.Photo1.HeaderText = "Photo"
        Me.Photo1.Name = "Photo1"
        Me.Photo1.ReadOnly = True
        Me.Photo1.Visible = False
        '
        'TxTot
        '
        Me.TxTot.AutoSize = True
        Me.TxTot.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTot.ForeColor = System.Drawing.Color.DarkRed
        Me.TxTot.Location = New System.Drawing.Point(632, 649)
        Me.TxTot.Name = "TxTot"
        Me.TxTot.Size = New System.Drawing.Size(0, 18)
        Me.TxTot.TabIndex = 109
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(573, 649)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 18)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "Total:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Tomato
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Brown
        Me.Button1.Location = New System.Drawing.Point(309, 649)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 29)
        Me.Button1.TabIndex = 107
        Me.Button1.Text = "Order"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Pho
        '
        Me.Pho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pho.Location = New System.Drawing.Point(24, 254)
        Me.Pho.Name = "Pho"
        Me.Pho.Size = New System.Drawing.Size(239, 163)
        Me.Pho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pho.TabIndex = 106
        Me.Pho.TabStop = False
        '
        'BDel
        '
        Me.BDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BDel.FlatAppearance.BorderColor = System.Drawing.Color.Tomato
        Me.BDel.FlatAppearance.BorderSize = 2
        Me.BDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan
        Me.BDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BDel.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BDel.ForeColor = System.Drawing.Color.Brown
        Me.BDel.Location = New System.Drawing.Point(538, 388)
        Me.BDel.Name = "BDel"
        Me.BDel.Size = New System.Drawing.Size(97, 29)
        Me.BDel.TabIndex = 104
        Me.BDel.Text = "Delete"
        Me.BDel.UseVisualStyleBackColor = False
        '
        'BIns
        '
        Me.BIns.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BIns.FlatAppearance.BorderColor = System.Drawing.Color.Tomato
        Me.BIns.FlatAppearance.BorderSize = 2
        Me.BIns.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan
        Me.BIns.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BIns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BIns.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BIns.ForeColor = System.Drawing.Color.Brown
        Me.BIns.Location = New System.Drawing.Point(412, 388)
        Me.BIns.Name = "BIns"
        Me.BIns.Size = New System.Drawing.Size(97, 29)
        Me.BIns.TabIndex = 105
        Me.BIns.Text = "Insert"
        Me.BIns.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(300, 269)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 18)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Menu Name"
        '
        'TxName
        '
        Me.TxName.BackColor = System.Drawing.Color.White
        Me.TxName.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TxName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxName.Location = New System.Drawing.Point(412, 265)
        Me.TxName.Name = "TxName"
        Me.TxName.ReadOnly = True
        Me.TxName.Size = New System.Drawing.Size(242, 22)
        Me.TxName.TabIndex = 102
        '
        'TxQty
        '
        Me.TxQty.BackColor = System.Drawing.Color.White
        Me.TxQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxQty.Location = New System.Drawing.Point(412, 302)
        Me.TxQty.Name = "TxQty"
        Me.TxQty.Size = New System.Drawing.Size(242, 22)
        Me.TxQty.TabIndex = 101
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(301, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 18)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Qty"
        '
        'TxPrice
        '
        Me.TxPrice.BackColor = System.Drawing.Color.White
        Me.TxPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxPrice.Location = New System.Drawing.Point(412, 339)
        Me.TxPrice.Name = "TxPrice"
        Me.TxPrice.Size = New System.Drawing.Size(242, 22)
        Me.TxPrice.TabIndex = 99
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(300, 342)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 18)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Price"
        '
        'MsmenuTableAdapter
        '
        Me.MsmenuTableAdapter.ClearBeforeFill = True
        '
        'FrmOrd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(711, 690)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.DGV2)
        Me.Controls.Add(Me.TxTot)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Pho)
        Me.Controls.Add(Me.BDel)
        Me.Controls.Add(Me.BIns)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxName)
        Me.Controls.Add(Me.TxQty)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxPrice)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FrmOrd"
        Me.Text = "FrmOrd"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MsmenuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMKRestorantDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV As DataGridView
    Friend WithEvents MenuIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhotoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MsmenuBindingSource As BindingSource
    Friend WithEvents SMKRestorantDataSet3 As SMKRestorantDataSet3
    Friend WithEvents Total1 As DataGridViewTextBoxColumn
    Friend WithEvents DGV2 As DataGridView
    Friend WithEvents MenuID1 As DataGridViewTextBoxColumn
    Friend WithEvents Menu1 As DataGridViewTextBoxColumn
    Friend WithEvents Qty1 As DataGridViewTextBoxColumn
    Friend WithEvents Price1 As DataGridViewTextBoxColumn
    Friend WithEvents Photo1 As DataGridViewTextBoxColumn
    Friend WithEvents TxTot As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Pho As PictureBox
    Friend WithEvents BDel As Button
    Friend WithEvents BIns As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxName As TextBox
    Friend WithEvents TxQty As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxPrice As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MsmenuTableAdapter As SMKRestorantDataSet3TableAdapters.MsmenuTableAdapter
End Class
