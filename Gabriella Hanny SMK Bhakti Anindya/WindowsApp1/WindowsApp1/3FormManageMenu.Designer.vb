<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMnMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxID = New System.Windows.Forms.TextBox()
        Me.TxName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxPrice = New System.Windows.Forms.TextBox()
        Me.TxPho = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.MenuIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhotoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MsmenuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMKRestorantDataSet2 = New WindowsApp1.SMKRestorantDataSet2()
        Me.BDel = New System.Windows.Forms.Button()
        Me.BIns = New System.Windows.Forms.Button()
        Me.BUpd = New System.Windows.Forms.Button()
        Me.InsPho = New System.Windows.Forms.Button()
        Me.Pho = New System.Windows.Forms.PictureBox()
        Me.MsmenuTableAdapter = New WindowsApp1.SMKRestorantDataSet2TableAdapters.MsmenuTableAdapter()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MsmenuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMKRestorantDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(104, 268)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 18)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "MenuID"
        '
        'TxID
        '
        Me.TxID.BackColor = System.Drawing.Color.White
        Me.TxID.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TxID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxID.Location = New System.Drawing.Point(182, 267)
        Me.TxID.Name = "TxID"
        Me.TxID.ReadOnly = True
        Me.TxID.Size = New System.Drawing.Size(217, 22)
        Me.TxID.TabIndex = 59
        '
        'TxName
        '
        Me.TxName.BackColor = System.Drawing.Color.White
        Me.TxName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxName.Location = New System.Drawing.Point(182, 304)
        Me.TxName.Name = "TxName"
        Me.TxName.Size = New System.Drawing.Size(217, 22)
        Me.TxName.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(105, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 18)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Name"
        '
        'TxPrice
        '
        Me.TxPrice.BackColor = System.Drawing.Color.White
        Me.TxPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxPrice.Location = New System.Drawing.Point(182, 341)
        Me.TxPrice.Name = "TxPrice"
        Me.TxPrice.Size = New System.Drawing.Size(217, 22)
        Me.TxPrice.TabIndex = 55
        '
        'TxPho
        '
        Me.TxPho.BackColor = System.Drawing.Color.White
        Me.TxPho.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TxPho.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxPho.Location = New System.Drawing.Point(182, 378)
        Me.TxPho.Name = "TxPho"
        Me.TxPho.ReadOnly = True
        Me.TxPho.Size = New System.Drawing.Size(217, 22)
        Me.TxPho.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(104, 378)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 18)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Photo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(104, 341)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 18)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Price"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
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
        Me.DGV.Location = New System.Drawing.Point(107, 20)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(596, 226)
        Me.DGV.TabIndex = 48
        '
        'MenuIDDataGridViewTextBoxColumn
        '
        Me.MenuIDDataGridViewTextBoxColumn.DataPropertyName = "MenuID"
        Me.MenuIDDataGridViewTextBoxColumn.HeaderText = "MenuID"
        Me.MenuIDDataGridViewTextBoxColumn.Name = "MenuIDDataGridViewTextBoxColumn"
        Me.MenuIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
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
        '
        'MsmenuBindingSource
        '
        Me.MsmenuBindingSource.DataMember = "Msmenu"
        Me.MsmenuBindingSource.DataSource = Me.SMKRestorantDataSet2
        '
        'SMKRestorantDataSet2
        '
        Me.SMKRestorantDataSet2.DataSetName = "SMKRestorantDataSet2"
        Me.SMKRestorantDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.BDel.Location = New System.Drawing.Point(341, 413)
        Me.BDel.Name = "BDel"
        Me.BDel.Size = New System.Drawing.Size(97, 29)
        Me.BDel.TabIndex = 61
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
        Me.BIns.Location = New System.Drawing.Point(104, 413)
        Me.BIns.Name = "BIns"
        Me.BIns.Size = New System.Drawing.Size(97, 29)
        Me.BIns.TabIndex = 62
        Me.BIns.Text = "Insert"
        Me.BIns.UseVisualStyleBackColor = False
        '
        'BUpd
        '
        Me.BUpd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BUpd.FlatAppearance.BorderColor = System.Drawing.Color.Tomato
        Me.BUpd.FlatAppearance.BorderSize = 2
        Me.BUpd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan
        Me.BUpd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BUpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BUpd.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUpd.ForeColor = System.Drawing.Color.Brown
        Me.BUpd.Location = New System.Drawing.Point(223, 413)
        Me.BUpd.Name = "BUpd"
        Me.BUpd.Size = New System.Drawing.Size(97, 29)
        Me.BUpd.TabIndex = 63
        Me.BUpd.Text = "Update"
        Me.BUpd.UseVisualStyleBackColor = False
        '
        'InsPho
        '
        Me.InsPho.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.InsPho.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.InsPho.FlatAppearance.BorderSize = 2
        Me.InsPho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan
        Me.InsPho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.InsPho.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InsPho.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InsPho.ForeColor = System.Drawing.Color.Maroon
        Me.InsPho.Location = New System.Drawing.Point(405, 378)
        Me.InsPho.Name = "InsPho"
        Me.InsPho.Size = New System.Drawing.Size(33, 22)
        Me.InsPho.TabIndex = 64
        Me.InsPho.Text = "..."
        Me.InsPho.UseVisualStyleBackColor = False
        '
        'Pho
        '
        Me.Pho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pho.Location = New System.Drawing.Point(473, 267)
        Me.Pho.Name = "Pho"
        Me.Pho.Size = New System.Drawing.Size(230, 163)
        Me.Pho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pho.TabIndex = 65
        Me.Pho.TabStop = False
        '
        'MsmenuTableAdapter
        '
        Me.MsmenuTableAdapter.ClearBeforeFill = True
        '
        'FrmMnMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(800, 460)
        Me.Controls.Add(Me.Pho)
        Me.Controls.Add(Me.InsPho)
        Me.Controls.Add(Me.BDel)
        Me.Controls.Add(Me.BIns)
        Me.Controls.Add(Me.BUpd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxID)
        Me.Controls.Add(Me.TxName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxPrice)
        Me.Controls.Add(Me.TxPho)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGV)
        Me.Name = "FrmMnMenu"
        Me.Text = "FrmMnMenu"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MsmenuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMKRestorantDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxID As TextBox
    Friend WithEvents TxName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxPrice As TextBox
    Friend WithEvents TxPho As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents BDel As Button
    Friend WithEvents BIns As Button
    Friend WithEvents BUpd As Button
    Friend WithEvents InsPho As Button
    Friend WithEvents Pho As PictureBox
    Friend WithEvents SMKRestorantDataSet2 As SMKRestorantDataSet2
    Friend WithEvents MsmenuBindingSource As BindingSource
    Friend WithEvents MsmenuTableAdapter As SMKRestorantDataSet2TableAdapters.MsmenuTableAdapter
    Friend WithEvents MenuIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhotoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
