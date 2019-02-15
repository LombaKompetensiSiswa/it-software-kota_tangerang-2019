<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChef
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
        Me.BPw = New System.Windows.Forms.Button()
        Me.Bout = New System.Windows.Forms.Button()
        Me.Bord = New System.Windows.Forms.Button()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BPw
        '
        Me.BPw.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BPw.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BPw.FlatAppearance.BorderSize = 2
        Me.BPw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan
        Me.BPw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BPw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BPw.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BPw.ForeColor = System.Drawing.Color.Maroon
        Me.BPw.Location = New System.Drawing.Point(174, 231)
        Me.BPw.Name = "BPw"
        Me.BPw.Size = New System.Drawing.Size(217, 33)
        Me.BPw.TabIndex = 54
        Me.BPw.Text = "Change Password"
        Me.BPw.UseVisualStyleBackColor = False
        '
        'Bout
        '
        Me.Bout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Bout.FlatAppearance.BorderSize = 2
        Me.Bout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan
        Me.Bout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Bout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bout.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bout.ForeColor = System.Drawing.Color.Maroon
        Me.Bout.Location = New System.Drawing.Point(174, 285)
        Me.Bout.Name = "Bout"
        Me.Bout.Size = New System.Drawing.Size(217, 33)
        Me.Bout.TabIndex = 53
        Me.Bout.Text = "Logout"
        Me.Bout.UseVisualStyleBackColor = False
        '
        'Bord
        '
        Me.Bord.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Bord.FlatAppearance.BorderSize = 2
        Me.Bord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan
        Me.Bord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Bord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bord.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bord.ForeColor = System.Drawing.Color.Maroon
        Me.Bord.Location = New System.Drawing.Point(174, 176)
        Me.Bord.Name = "Bord"
        Me.Bord.Size = New System.Drawing.Size(217, 33)
        Me.Bord.TabIndex = 52
        Me.Bord.Text = "View Order"
        Me.Bord.UseVisualStyleBackColor = False
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUser.ForeColor = System.Drawing.Color.DarkRed
        Me.LblUser.Location = New System.Drawing.Point(284, 124)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(69, 21)
        Me.LblUser.TabIndex = 51
        Me.LblUser.Text = "[name]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(199, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 21)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Welcome,"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(153, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 38)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Chef Navigation"
        '
        'FrmChef
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(593, 385)
        Me.Controls.Add(Me.BPw)
        Me.Controls.Add(Me.Bout)
        Me.Controls.Add(Me.Bord)
        Me.Controls.Add(Me.LblUser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmChef"
        Me.Text = "Navigation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BPw As Button
    Friend WithEvents Bout As Button
    Friend WithEvents Bord As Button
    Friend WithEvents LblUser As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
