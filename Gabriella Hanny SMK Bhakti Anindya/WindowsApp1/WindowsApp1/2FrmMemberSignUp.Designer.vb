<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMemSU
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
        Me.TxName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ChPw = New System.Windows.Forms.Button()
        Me.TxEmail = New System.Windows.Forms.TextBox()
        Me.TXHP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxName
        '
        Me.TxName.BackColor = System.Drawing.Color.White
        Me.TxName.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxName.Location = New System.Drawing.Point(255, 109)
        Me.TxName.Name = "TxName"
        Me.TxName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxName.Size = New System.Drawing.Size(207, 21)
        Me.TxName.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(126, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 18)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Name"
        '
        'ChPw
        '
        Me.ChPw.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ChPw.FlatAppearance.BorderColor = System.Drawing.Color.Tomato
        Me.ChPw.FlatAppearance.BorderSize = 2
        Me.ChPw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan
        Me.ChPw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.ChPw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChPw.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChPw.ForeColor = System.Drawing.Color.Brown
        Me.ChPw.Location = New System.Drawing.Point(255, 234)
        Me.ChPw.Name = "ChPw"
        Me.ChPw.Size = New System.Drawing.Size(68, 29)
        Me.ChPw.TabIndex = 38
        Me.ChPw.Text = "Sign Up"
        Me.ChPw.UseVisualStyleBackColor = False
        '
        'TxEmail
        '
        Me.TxEmail.BackColor = System.Drawing.Color.White
        Me.TxEmail.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxEmail.Location = New System.Drawing.Point(255, 146)
        Me.TxEmail.Name = "TxEmail"
        Me.TxEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxEmail.Size = New System.Drawing.Size(207, 21)
        Me.TxEmail.TabIndex = 42
        '
        'TXHP
        '
        Me.TXHP.BackColor = System.Drawing.Color.White
        Me.TXHP.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXHP.Location = New System.Drawing.Point(255, 184)
        Me.TXHP.Name = "TXHP"
        Me.TXHP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXHP.Size = New System.Drawing.Size(207, 21)
        Me.TXHP.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(126, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 18)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Handphone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(126, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Email"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(194, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 36)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Sign Up Form"
        '
        'FrmMemSU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(610, 311)
        Me.Controls.Add(Me.TxName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ChPw)
        Me.Controls.Add(Me.TxEmail)
        Me.Controls.Add(Me.TXHP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMemSU"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ChPw As Button
    Friend WithEvents TxEmail As TextBox
    Friend WithEvents TXHP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
