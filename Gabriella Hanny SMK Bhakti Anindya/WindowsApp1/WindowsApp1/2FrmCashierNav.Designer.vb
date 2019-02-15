<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCashier
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
        Me.BChPw = New System.Windows.Forms.Button()
        Me.BOut = New System.Windows.Forms.Button()
        Me.BPay = New System.Windows.Forms.Button()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BChPw
        '
        Me.BChPw.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BChPw.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BChPw.FlatAppearance.BorderSize = 2
        Me.BChPw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan
        Me.BChPw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BChPw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BChPw.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BChPw.ForeColor = System.Drawing.Color.Maroon
        Me.BChPw.Location = New System.Drawing.Point(171, 219)
        Me.BChPw.Name = "BChPw"
        Me.BChPw.Size = New System.Drawing.Size(217, 33)
        Me.BChPw.TabIndex = 66
        Me.BChPw.Text = "Change Password"
        Me.BChPw.UseVisualStyleBackColor = False
        '
        'BOut
        '
        Me.BOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BOut.FlatAppearance.BorderSize = 2
        Me.BOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan
        Me.BOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BOut.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BOut.ForeColor = System.Drawing.Color.Maroon
        Me.BOut.Location = New System.Drawing.Point(171, 273)
        Me.BOut.Name = "BOut"
        Me.BOut.Size = New System.Drawing.Size(217, 33)
        Me.BOut.TabIndex = 65
        Me.BOut.Text = "Logout"
        Me.BOut.UseVisualStyleBackColor = False
        '
        'BPay
        '
        Me.BPay.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BPay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BPay.FlatAppearance.BorderSize = 2
        Me.BPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan
        Me.BPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BPay.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BPay.ForeColor = System.Drawing.Color.Maroon
        Me.BPay.Location = New System.Drawing.Point(171, 164)
        Me.BPay.Name = "BPay"
        Me.BPay.Size = New System.Drawing.Size(217, 33)
        Me.BPay.TabIndex = 64
        Me.BPay.Text = "Payment"
        Me.BPay.UseVisualStyleBackColor = False
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUser.ForeColor = System.Drawing.Color.DarkRed
        Me.LblUser.Location = New System.Drawing.Point(281, 112)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(69, 21)
        Me.LblUser.TabIndex = 63
        Me.LblUser.Text = "[name]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(196, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 21)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Welcome,"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 26.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(125, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 38)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Cashier Navigation"
        '
        'FrmCashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(570, 352)
        Me.Controls.Add(Me.BChPw)
        Me.Controls.Add(Me.BOut)
        Me.Controls.Add(Me.BPay)
        Me.Controls.Add(Me.LblUser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmCashier"
        Me.Text = "Navigation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BChPw As Button
    Friend WithEvents BOut As Button
    Friend WithEvents BPay As Button
    Friend WithEvents LblUser As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
