<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdmin
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
        Me.LblUser = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Bmem = New System.Windows.Forms.Button()
        Me.BChPW = New System.Windows.Forms.Button()
        Me.BOut = New System.Windows.Forms.Button()
        Me.Bemp = New System.Windows.Forms.Button()
        Me.Bmen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUser.ForeColor = System.Drawing.Color.DarkRed
        Me.LblUser.Location = New System.Drawing.Point(315, 77)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(74, 21)
        Me.LblUser.TabIndex = 34
        Me.LblUser.Text = "[Nama]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(230, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 21)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Welcome,"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 26.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(176, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 38)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Admin Navigation"
        '
        'Bmem
        '
        Me.Bmem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bmem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Bmem.FlatAppearance.BorderSize = 2
        Me.Bmem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan
        Me.Bmem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Bmem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bmem.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bmem.ForeColor = System.Drawing.Color.Maroon
        Me.Bmem.Location = New System.Drawing.Point(203, 214)
        Me.Bmem.Name = "Bmem"
        Me.Bmem.Size = New System.Drawing.Size(217, 33)
        Me.Bmem.TabIndex = 41
        Me.Bmem.Text = "Manage Member"
        Me.Bmem.UseVisualStyleBackColor = False
        '
        'BChPW
        '
        Me.BChPW.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BChPW.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BChPW.FlatAppearance.BorderSize = 2
        Me.BChPW.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan
        Me.BChPW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BChPW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BChPW.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BChPW.ForeColor = System.Drawing.Color.Maroon
        Me.BChPW.Location = New System.Drawing.Point(203, 262)
        Me.BChPW.Name = "BChPW"
        Me.BChPW.Size = New System.Drawing.Size(217, 33)
        Me.BChPW.TabIndex = 40
        Me.BChPW.Text = "Change Password"
        Me.BChPW.UseVisualStyleBackColor = False
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
        Me.BOut.Location = New System.Drawing.Point(203, 310)
        Me.BOut.Name = "BOut"
        Me.BOut.Size = New System.Drawing.Size(217, 33)
        Me.BOut.TabIndex = 39
        Me.BOut.Text = "Logout"
        Me.BOut.UseVisualStyleBackColor = False
        '
        'Bemp
        '
        Me.Bemp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bemp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Bemp.FlatAppearance.BorderSize = 2
        Me.Bemp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan
        Me.Bemp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Bemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bemp.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bemp.ForeColor = System.Drawing.Color.Maroon
        Me.Bemp.Location = New System.Drawing.Point(203, 116)
        Me.Bemp.Name = "Bemp"
        Me.Bemp.Size = New System.Drawing.Size(217, 33)
        Me.Bemp.TabIndex = 38
        Me.Bemp.Text = "Manage Employee"
        Me.Bemp.UseVisualStyleBackColor = False
        '
        'Bmen
        '
        Me.Bmen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bmen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Bmen.FlatAppearance.BorderSize = 2
        Me.Bmen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan
        Me.Bmen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Bmen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bmen.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bmen.ForeColor = System.Drawing.Color.Maroon
        Me.Bmen.Location = New System.Drawing.Point(203, 166)
        Me.Bmen.Name = "Bmen"
        Me.Bmen.Size = New System.Drawing.Size(217, 33)
        Me.Bmen.TabIndex = 37
        Me.Bmen.Text = "Manage Menu"
        Me.Bmen.UseVisualStyleBackColor = False
        '
        'FrmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(625, 359)
        Me.Controls.Add(Me.Bmem)
        Me.Controls.Add(Me.BChPW)
        Me.Controls.Add(Me.BOut)
        Me.Controls.Add(Me.Bemp)
        Me.Controls.Add(Me.Bmen)
        Me.Controls.Add(Me.LblUser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmAdmin"
        Me.Text = "Navigation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblUser As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Bmem As Button
    Friend WithEvents BChPW As Button
    Friend WithEvents BOut As Button
    Friend WithEvents Bemp As Button
    Friend WithEvents Bmen As Button
End Class
