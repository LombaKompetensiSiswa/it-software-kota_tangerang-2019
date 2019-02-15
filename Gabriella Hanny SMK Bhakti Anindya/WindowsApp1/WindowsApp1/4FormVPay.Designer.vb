<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVPay
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
        Me.HeaderorderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMKRestorantDataSet4 = New WindowsApp1.SMKRestorantDataSet4()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.TxTot = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.HeaderorderTableAdapter = New WindowsApp1.SMKRestorantDataSet4TableAdapters.HeaderorderTableAdapter()
        Me.OrdID = New System.Windows.Forms.ComboBox()
        Me.HeaderorderBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMKRestorantDataSet6 = New WindowsApp1.SMKRestorantDataSet6()
        Me.HeaderorderTableAdapter1 = New WindowsApp1.SMKRestorantDataSet6TableAdapters.HeaderorderTableAdapter()
        CType(Me.HeaderorderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMKRestorantDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderorderBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMKRestorantDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HeaderorderBindingSource
        '
        Me.HeaderorderBindingSource.DataMember = "Headerorder"
        Me.HeaderorderBindingSource.DataSource = Me.SMKRestorantDataSet4
        '
        'SMKRestorantDataSet4
        '
        Me.SMKRestorantDataSet4.DataSetName = "SMKRestorantDataSet4"
        Me.SMKRestorantDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.DGV.Location = New System.Drawing.Point(44, 96)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(706, 252)
        Me.DGV.TabIndex = 92
        '
        'TxTot
        '
        Me.TxTot.AutoSize = True
        Me.TxTot.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTot.ForeColor = System.Drawing.Color.DarkRed
        Me.TxTot.Location = New System.Drawing.Point(683, 361)
        Me.TxTot.Name = "TxTot"
        Me.TxTot.Size = New System.Drawing.Size(0, 18)
        Me.TxTot.TabIndex = 97
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(624, 361)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 18)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Total:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 26.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(224, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 38)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Form View Payment"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(232, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 18)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "OrderID"
        '
        'HeaderorderTableAdapter
        '
        Me.HeaderorderTableAdapter.ClearBeforeFill = True
        '
        'OrdID
        '
        Me.OrdID.BackColor = System.Drawing.Color.White
        Me.OrdID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OrdID.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.HeaderorderBindingSource, "OrderID", True))
        Me.OrdID.DataSource = Me.HeaderorderBindingSource1
        Me.OrdID.DisplayMember = "OrderID"
        Me.OrdID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OrdID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.OrdID.FormattingEnabled = True
        Me.OrdID.Location = New System.Drawing.Point(315, 56)
        Me.OrdID.Name = "OrdID"
        Me.OrdID.Size = New System.Drawing.Size(217, 24)
        Me.OrdID.TabIndex = 98
        Me.OrdID.ValueMember = "OrderID"
        '
        'HeaderorderBindingSource1
        '
        Me.HeaderorderBindingSource1.DataMember = "Headerorder"
        Me.HeaderorderBindingSource1.DataSource = Me.SMKRestorantDataSet6
        '
        'SMKRestorantDataSet6
        '
        Me.SMKRestorantDataSet6.DataSetName = "SMKRestorantDataSet6"
        Me.SMKRestorantDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HeaderorderTableAdapter1
        '
        Me.HeaderorderTableAdapter1.ClearBeforeFill = True
        '
        'FrmVPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(805, 388)
        Me.Controls.Add(Me.OrdID)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.TxTot)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Name = "FrmVPay"
        Me.Text = "FormVPay"
        CType(Me.HeaderorderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMKRestorantDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderorderBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMKRestorantDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HeaderorderBindingSource As BindingSource
    Friend WithEvents SMKRestorantDataSet4 As SMKRestorantDataSet4
    Friend WithEvents DGV As DataGridView
    Friend WithEvents TxTot As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents HeaderorderTableAdapter As SMKRestorantDataSet4TableAdapters.HeaderorderTableAdapter
    Friend WithEvents OrdID As ComboBox
    Friend WithEvents SMKRestorantDataSet6 As SMKRestorantDataSet6
    Friend WithEvents HeaderorderBindingSource1 As BindingSource
    Friend WithEvents HeaderorderTableAdapter1 As SMKRestorantDataSet6TableAdapters.HeaderorderTableAdapter
End Class
