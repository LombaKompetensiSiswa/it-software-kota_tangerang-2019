<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVord
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
        Me.OrdID = New System.Windows.Forms.ComboBox()
        Me.HeaderorderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMKRestorantDataSet7 = New WindowsApp1.SMKRestorantDataSet7()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.TxTot = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.HeaderorderTableAdapter = New WindowsApp1.SMKRestorantDataSet7TableAdapters.HeaderorderTableAdapter()
        CType(Me.HeaderorderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMKRestorantDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrdID
        '
        Me.OrdID.BackColor = System.Drawing.Color.White
        Me.OrdID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OrdID.DataSource = Me.HeaderorderBindingSource
        Me.OrdID.DisplayMember = "OrderID"
        Me.OrdID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OrdID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.OrdID.FormattingEnabled = True
        Me.OrdID.Location = New System.Drawing.Point(324, 93)
        Me.OrdID.Name = "OrdID"
        Me.OrdID.Size = New System.Drawing.Size(217, 24)
        Me.OrdID.TabIndex = 104
        Me.OrdID.ValueMember = "OrderID"
        '
        'HeaderorderBindingSource
        '
        Me.HeaderorderBindingSource.DataMember = "Headerorder"
        Me.HeaderorderBindingSource.DataSource = Me.SMKRestorantDataSet7
        '
        'SMKRestorantDataSet7
        '
        Me.SMKRestorantDataSet7.DataSetName = "SMKRestorantDataSet7"
        Me.SMKRestorantDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.DGV.Location = New System.Drawing.Point(50, 131)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(706, 294)
        Me.DGV.TabIndex = 99
        '
        'TxTot
        '
        Me.TxTot.AutoSize = True
        Me.TxTot.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTot.ForeColor = System.Drawing.Color.DarkRed
        Me.TxTot.Location = New System.Drawing.Point(686, 392)
        Me.TxTot.Name = "TxTot"
        Me.TxTot.Size = New System.Drawing.Size(0, 18)
        Me.TxTot.TabIndex = 103
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 26.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(255, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 38)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Form View Order"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(241, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 18)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "OrderID"
        '
        'HeaderorderTableAdapter
        '
        Me.HeaderorderTableAdapter.ClearBeforeFill = True
        '
        'FrmVord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.OrdID)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.TxTot)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Name = "FrmVord"
        Me.Text = "FrmVord"
        CType(Me.HeaderorderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMKRestorantDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OrdID As ComboBox
    Friend WithEvents DGV As DataGridView
    Friend WithEvents TxTot As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SMKRestorantDataSet7 As SMKRestorantDataSet7
    Friend WithEvents HeaderorderBindingSource As BindingSource
    Friend WithEvents HeaderorderTableAdapter As SMKRestorantDataSet7TableAdapters.HeaderorderTableAdapter
End Class
