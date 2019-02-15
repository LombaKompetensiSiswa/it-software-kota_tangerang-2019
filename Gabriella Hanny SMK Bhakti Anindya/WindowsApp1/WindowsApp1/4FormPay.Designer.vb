<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPay
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
        Me.HeaderorderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMKRestorantDataSet4 = New WindowsApp1.SMKRestorantDataSet4()
        Me.HeaderorderBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMKRestorantDataSet5 = New WindowsApp1.SMKRestorantDataSet5()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxTot = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxBankN = New System.Windows.Forms.ComboBox()
        Me.TxCardN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BPay = New System.Windows.Forms.Button()
        Me.TxPayT = New System.Windows.Forms.ComboBox()
        Me.HeaderorderTableAdapter = New WindowsApp1.SMKRestorantDataSet4TableAdapters.HeaderorderTableAdapter()
        Me.BCancel = New System.Windows.Forms.Button()
        Me.HeaderorderTableAdapter1 = New WindowsApp1.SMKRestorantDataSet5TableAdapters.HeaderorderTableAdapter()
        Me.OrdID = New System.Windows.Forms.TextBox()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderorderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMKRestorantDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderorderBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMKRestorantDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV.BackgroundColor = System.Drawing.Color.Tan
        Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DGV.Location = New System.Drawing.Point(12, 91)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(706, 198)
        Me.DGV.TabIndex = 51
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
        'HeaderorderBindingSource1
        '
        Me.HeaderorderBindingSource1.DataMember = "Headerorder"
        Me.HeaderorderBindingSource1.DataSource = Me.SMKRestorantDataSet5
        '
        'SMKRestorantDataSet5
        '
        Me.SMKRestorantDataSet5.DataSetName = "SMKRestorantDataSet5"
        Me.SMKRestorantDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(211, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 18)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "OrderID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 26.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(254, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 38)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Form Payment"
        '
        'TxTot
        '
        Me.TxTot.AutoSize = True
        Me.TxTot.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTot.ForeColor = System.Drawing.Color.DarkRed
        Me.TxTot.Location = New System.Drawing.Point(651, 304)
        Me.TxTot.Name = "TxTot"
        Me.TxTot.Size = New System.Drawing.Size(67, 18)
        Me.TxTot.TabIndex = 83
        Me.TxTot.Text = "[Total]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(592, 304)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 18)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(160, 397)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 18)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Bank Name"
        '
        'TxBankN
        '
        Me.TxBankN.BackColor = System.Drawing.Color.White
        Me.TxBankN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxBankN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxBankN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxBankN.FormattingEnabled = True
        Me.TxBankN.Items.AddRange(New Object() {"BNI", "BCA", "Mandiri", "Paypal"})
        Me.TxBankN.Location = New System.Drawing.Point(294, 393)
        Me.TxBankN.Name = "TxBankN"
        Me.TxBankN.Size = New System.Drawing.Size(217, 24)
        Me.TxBankN.TabIndex = 88
        '
        'TxCardN
        '
        Me.TxCardN.BackColor = System.Drawing.Color.White
        Me.TxCardN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCardN.Location = New System.Drawing.Point(294, 356)
        Me.TxCardN.Name = "TxCardN"
        Me.TxCardN.Size = New System.Drawing.Size(217, 22)
        Me.TxCardN.TabIndex = 86
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(159, 358)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 18)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Card Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkRed
        Me.Label6.Location = New System.Drawing.Point(159, 321)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 18)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Payment Type"
        '
        'BPay
        '
        Me.BPay.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BPay.FlatAppearance.BorderColor = System.Drawing.Color.Tomato
        Me.BPay.FlatAppearance.BorderSize = 2
        Me.BPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan
        Me.BPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BPay.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BPay.ForeColor = System.Drawing.Color.Brown
        Me.BPay.Location = New System.Drawing.Point(294, 454)
        Me.BPay.Name = "BPay"
        Me.BPay.Size = New System.Drawing.Size(97, 29)
        Me.BPay.TabIndex = 90
        Me.BPay.Text = "Pay"
        Me.BPay.UseVisualStyleBackColor = False
        '
        'TxPayT
        '
        Me.TxPayT.BackColor = System.Drawing.Color.White
        Me.TxPayT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxPayT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxPayT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxPayT.FormattingEnabled = True
        Me.TxPayT.Items.AddRange(New Object() {"Bank Account", "Credit Card"})
        Me.TxPayT.Location = New System.Drawing.Point(294, 321)
        Me.TxPayT.Name = "TxPayT"
        Me.TxPayT.Size = New System.Drawing.Size(217, 24)
        Me.TxPayT.TabIndex = 91
        '
        'HeaderorderTableAdapter
        '
        Me.HeaderorderTableAdapter.ClearBeforeFill = True
        '
        'BCancel
        '
        Me.BCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BCancel.FlatAppearance.BorderColor = System.Drawing.Color.Tomato
        Me.BCancel.FlatAppearance.BorderSize = 2
        Me.BCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan
        Me.BCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancel.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancel.ForeColor = System.Drawing.Color.Brown
        Me.BCancel.Location = New System.Drawing.Point(414, 454)
        Me.BCancel.Name = "BCancel"
        Me.BCancel.Size = New System.Drawing.Size(97, 29)
        Me.BCancel.TabIndex = 92
        Me.BCancel.Text = "Cancel"
        Me.BCancel.UseVisualStyleBackColor = False
        '
        'HeaderorderTableAdapter1
        '
        Me.HeaderorderTableAdapter1.ClearBeforeFill = True
        '
        'OrdID
        '
        Me.OrdID.BackColor = System.Drawing.Color.White
        Me.OrdID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrdID.Location = New System.Drawing.Point(294, 53)
        Me.OrdID.Name = "OrdID"
        Me.OrdID.ReadOnly = True
        Me.OrdID.Size = New System.Drawing.Size(217, 22)
        Me.OrdID.TabIndex = 93
        '
        'FrmPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(739, 505)
        Me.Controls.Add(Me.OrdID)
        Me.Controls.Add(Me.BCancel)
        Me.Controls.Add(Me.TxPayT)
        Me.Controls.Add(Me.BPay)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxBankN)
        Me.Controls.Add(Me.TxCardN)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxTot)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DGV)
        Me.Name = "FrmPay"
        Me.Text = "FrmPay"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderorderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMKRestorantDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderorderBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMKRestorantDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxTot As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxBankN As ComboBox
    Friend WithEvents TxCardN As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BPay As Button
    Friend WithEvents TxPayT As ComboBox
    Friend WithEvents SMKRestorantDataSet4 As SMKRestorantDataSet4
    Friend WithEvents HeaderorderBindingSource As BindingSource
    Friend WithEvents HeaderorderTableAdapter As SMKRestorantDataSet4TableAdapters.HeaderorderTableAdapter
    Friend WithEvents BCancel As Button
    Friend WithEvents SMKRestorantDataSet5 As SMKRestorantDataSet5
    Friend WithEvents HeaderorderBindingSource1 As BindingSource
    Friend WithEvents HeaderorderTableAdapter1 As SMKRestorantDataSet5TableAdapters.HeaderorderTableAdapter
    Friend WithEvents OrdID As TextBox
End Class
