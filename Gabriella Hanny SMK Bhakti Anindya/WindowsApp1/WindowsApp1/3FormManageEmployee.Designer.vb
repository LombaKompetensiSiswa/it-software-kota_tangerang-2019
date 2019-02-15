<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMnEmp
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
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HandphoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MsEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMKRestorantDataSet = New WindowsApp1.SMKRestorantDataSet()
        Me.TxName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BUpd = New System.Windows.Forms.Button()
        Me.TxEmail = New System.Windows.Forms.TextBox()
        Me.TxHp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BDel = New System.Windows.Forms.Button()
        Me.BIns = New System.Windows.Forms.Button()
        Me.TxPos = New System.Windows.Forms.ComboBox()
        Me.TxID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MsEmployeeTableAdapter = New WindowsApp1.SMKRestorantDataSetTableAdapters.MsEmployeeTableAdapter()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MsEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMKRestorantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.HandphoneDataGridViewTextBoxColumn, Me.PositionDataGridViewTextBoxColumn})
        Me.DGV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV.DataSource = Me.MsEmployeeBindingSource
        Me.DGV.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DGV.Location = New System.Drawing.Point(12, 12)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(776, 226)
        Me.DGV.TabIndex = 0
        '
        'EmployeeIDDataGridViewTextBoxColumn
        '
        Me.EmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID"
        Me.EmployeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID"
        Me.EmployeeIDDataGridViewTextBoxColumn.Name = "EmployeeIDDataGridViewTextBoxColumn"
        Me.EmployeeIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.ReadOnly = True
        Me.PasswordDataGridViewTextBoxColumn.Visible = False
        '
        'HandphoneDataGridViewTextBoxColumn
        '
        Me.HandphoneDataGridViewTextBoxColumn.DataPropertyName = "Handphone"
        Me.HandphoneDataGridViewTextBoxColumn.HeaderText = "Handphone"
        Me.HandphoneDataGridViewTextBoxColumn.Name = "HandphoneDataGridViewTextBoxColumn"
        Me.HandphoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PositionDataGridViewTextBoxColumn
        '
        Me.PositionDataGridViewTextBoxColumn.DataPropertyName = "Position"
        Me.PositionDataGridViewTextBoxColumn.HeaderText = "Position"
        Me.PositionDataGridViewTextBoxColumn.Name = "PositionDataGridViewTextBoxColumn"
        Me.PositionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MsEmployeeBindingSource
        '
        Me.MsEmployeeBindingSource.DataMember = "MsEmployee"
        Me.MsEmployeeBindingSource.DataSource = Me.SMKRestorantDataSet
        '
        'SMKRestorantDataSet
        '
        Me.SMKRestorantDataSet.DataSetName = "SMKRestorantDataSet"
        Me.SMKRestorantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TxName
        '
        Me.TxName.BackColor = System.Drawing.Color.White
        Me.TxName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxName.Location = New System.Drawing.Point(336, 295)
        Me.TxName.Name = "TxName"
        Me.TxName.Size = New System.Drawing.Size(217, 22)
        Me.TxName.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(217, 298)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 18)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Name"
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
        Me.BUpd.Location = New System.Drawing.Point(339, 455)
        Me.BUpd.Name = "BUpd"
        Me.BUpd.Size = New System.Drawing.Size(97, 29)
        Me.BUpd.TabIndex = 37
        Me.BUpd.Text = "Update"
        Me.BUpd.UseVisualStyleBackColor = False
        '
        'TxEmail
        '
        Me.TxEmail.BackColor = System.Drawing.Color.White
        Me.TxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxEmail.Location = New System.Drawing.Point(336, 332)
        Me.TxEmail.Name = "TxEmail"
        Me.TxEmail.Size = New System.Drawing.Size(217, 22)
        Me.TxEmail.TabIndex = 41
        '
        'TxHp
        '
        Me.TxHp.BackColor = System.Drawing.Color.White
        Me.TxHp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxHp.Location = New System.Drawing.Point(336, 369)
        Me.TxHp.Name = "TxHp"
        Me.TxHp.Size = New System.Drawing.Size(217, 22)
        Me.TxHp.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(216, 372)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 18)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Handphone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(216, 335)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Email"
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
        Me.BDel.Location = New System.Drawing.Point(457, 455)
        Me.BDel.Name = "BDel"
        Me.BDel.Size = New System.Drawing.Size(97, 29)
        Me.BDel.TabIndex = 37
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
        Me.BIns.Location = New System.Drawing.Point(220, 455)
        Me.BIns.Name = "BIns"
        Me.BIns.Size = New System.Drawing.Size(97, 29)
        Me.BIns.TabIndex = 37
        Me.BIns.Text = "Insert"
        Me.BIns.UseVisualStyleBackColor = False
        '
        'TxPos
        '
        Me.TxPos.BackColor = System.Drawing.Color.White
        Me.TxPos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxPos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxPos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxPos.FormattingEnabled = True
        Me.TxPos.Items.AddRange(New Object() {"Admin", "Chef", "Cashier"})
        Me.TxPos.Location = New System.Drawing.Point(336, 406)
        Me.TxPos.Name = "TxPos"
        Me.TxPos.Size = New System.Drawing.Size(217, 24)
        Me.TxPos.TabIndex = 44
        '
        'TxID
        '
        Me.TxID.BackColor = System.Drawing.Color.White
        Me.TxID.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TxID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxID.Location = New System.Drawing.Point(336, 258)
        Me.TxID.Name = "TxID"
        Me.TxID.ReadOnly = True
        Me.TxID.Size = New System.Drawing.Size(217, 22)
        Me.TxID.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(216, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 18)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "EmployeeID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(217, 411)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 18)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Position"
        '
        'MsEmployeeTableAdapter
        '
        Me.MsEmployeeTableAdapter.ClearBeforeFill = True
        '
        'FrmMnEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(800, 509)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxID)
        Me.Controls.Add(Me.TxPos)
        Me.Controls.Add(Me.TxName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BDel)
        Me.Controls.Add(Me.BIns)
        Me.Controls.Add(Me.BUpd)
        Me.Controls.Add(Me.TxEmail)
        Me.Controls.Add(Me.TxHp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGV)
        Me.Name = "FrmMnEmp"
        Me.Text = "_3FrmManageEmployee"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MsEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMKRestorantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV As DataGridView
    Friend WithEvents TxName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BUpd As Button
    Friend WithEvents TxEmail As TextBox
    Friend WithEvents TxHp As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BDel As Button
    Friend WithEvents BIns As Button
    Friend WithEvents TxPos As ComboBox
    Friend WithEvents TxID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SMKRestorantDataSet As SMKRestorantDataSet
    Friend WithEvents MsEmployeeBindingSource As BindingSource
    Friend WithEvents MsEmployeeTableAdapter As SMKRestorantDataSetTableAdapters.MsEmployeeTableAdapter
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HandphoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
