<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMnMem
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxID = New System.Windows.Forms.TextBox()
        Me.TxName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BDel = New System.Windows.Forms.Button()
        Me.BIns = New System.Windows.Forms.Button()
        Me.BUpd = New System.Windows.Forms.Button()
        Me.TxEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.MemberIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JoinDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MsmemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMKRestorantDataSet1 = New WindowsApp1.SMKRestorantDataSet1()
        Me.MsmemberTableAdapter = New WindowsApp1.SMKRestorantDataSet1TableAdapters.MsmemberTableAdapter()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MsmemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMKRestorantDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(216, 275)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 18)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "MemberID"
        '
        'TxID
        '
        Me.TxID.BackColor = System.Drawing.Color.White
        Me.TxID.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TxID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxID.Location = New System.Drawing.Point(336, 272)
        Me.TxID.Name = "TxID"
        Me.TxID.ReadOnly = True
        Me.TxID.Size = New System.Drawing.Size(217, 22)
        Me.TxID.TabIndex = 59
        '
        'TxName
        '
        Me.TxName.BackColor = System.Drawing.Color.White
        Me.TxName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxName.Location = New System.Drawing.Point(336, 309)
        Me.TxName.Name = "TxName"
        Me.TxName.Size = New System.Drawing.Size(217, 22)
        Me.TxName.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(217, 312)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 18)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Name"
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
        Me.BDel.Location = New System.Drawing.Point(456, 390)
        Me.BDel.Name = "BDel"
        Me.BDel.Size = New System.Drawing.Size(97, 29)
        Me.BDel.TabIndex = 49
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
        Me.BIns.Location = New System.Drawing.Point(219, 390)
        Me.BIns.Name = "BIns"
        Me.BIns.Size = New System.Drawing.Size(97, 29)
        Me.BIns.TabIndex = 51
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
        Me.BUpd.Location = New System.Drawing.Point(338, 390)
        Me.BUpd.Name = "BUpd"
        Me.BUpd.Size = New System.Drawing.Size(97, 29)
        Me.BUpd.TabIndex = 50
        Me.BUpd.Text = "Update"
        Me.BUpd.UseVisualStyleBackColor = False
        '
        'TxEmail
        '
        Me.TxEmail.BackColor = System.Drawing.Color.White
        Me.TxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxEmail.Location = New System.Drawing.Point(336, 346)
        Me.TxEmail.Name = "TxEmail"
        Me.TxEmail.Size = New System.Drawing.Size(217, 22)
        Me.TxEmail.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(216, 349)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Email"
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
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MemberIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.JoinDateDataGridViewTextBoxColumn})
        Me.DGV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV.DataSource = Me.MsmemberBindingSource
        Me.DGV.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DGV.Location = New System.Drawing.Point(12, 25)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(776, 226)
        Me.DGV.TabIndex = 48
        '
        'MemberIDDataGridViewTextBoxColumn
        '
        Me.MemberIDDataGridViewTextBoxColumn.DataPropertyName = "MemberID"
        Me.MemberIDDataGridViewTextBoxColumn.HeaderText = "MemberID"
        Me.MemberIDDataGridViewTextBoxColumn.Name = "MemberIDDataGridViewTextBoxColumn"
        Me.MemberIDDataGridViewTextBoxColumn.ReadOnly = True
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
        'JoinDateDataGridViewTextBoxColumn
        '
        Me.JoinDateDataGridViewTextBoxColumn.DataPropertyName = "JoinDate"
        Me.JoinDateDataGridViewTextBoxColumn.HeaderText = "JoinDate"
        Me.JoinDateDataGridViewTextBoxColumn.Name = "JoinDateDataGridViewTextBoxColumn"
        Me.JoinDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MsmemberBindingSource
        '
        Me.MsmemberBindingSource.DataMember = "Msmember"
        Me.MsmemberBindingSource.DataSource = Me.SMKRestorantDataSet1
        '
        'SMKRestorantDataSet1
        '
        Me.SMKRestorantDataSet1.DataSetName = "SMKRestorantDataSet1"
        Me.SMKRestorantDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MsmemberTableAdapter
        '
        Me.MsmemberTableAdapter.ClearBeforeFill = True
        '
        'FrmMnMem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(812, 440)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxID)
        Me.Controls.Add(Me.TxName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BDel)
        Me.Controls.Add(Me.BIns)
        Me.Controls.Add(Me.BUpd)
        Me.Controls.Add(Me.TxEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGV)
        Me.Name = "FrmMnMem"
        Me.Text = "FrmMnMem"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MsmemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMKRestorantDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxID As TextBox
    Friend WithEvents TxName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BDel As Button
    Friend WithEvents BIns As Button
    Friend WithEvents BUpd As Button
    Friend WithEvents TxEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents SMKRestorantDataSet1 As SMKRestorantDataSet1
    Friend WithEvents MsmemberBindingSource As BindingSource
    Friend WithEvents MsmemberTableAdapter As SMKRestorantDataSet1TableAdapters.MsmemberTableAdapter
    Friend WithEvents MemberIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JoinDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
