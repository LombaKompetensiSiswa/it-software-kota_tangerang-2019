<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChPw
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
        Me.Opw = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ChPw = New System.Windows.Forms.Button()
        Me.Npw = New System.Windows.Forms.TextBox()
        Me.Cpw = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Opw
        '
        Me.Opw.BackColor = System.Drawing.Color.White
        Me.Opw.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opw.Location = New System.Drawing.Point(230, 110)
        Me.Opw.Name = "Opw"
        Me.Opw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Opw.Size = New System.Drawing.Size(217, 21)
        Me.Opw.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(69, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 18)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Old Password"
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
        Me.ChPw.Location = New System.Drawing.Point(230, 235)
        Me.ChPw.Name = "ChPw"
        Me.ChPw.Size = New System.Drawing.Size(68, 29)
        Me.ChPw.TabIndex = 30
        Me.ChPw.Text = "Save"
        Me.ChPw.UseVisualStyleBackColor = False
        '
        'Npw
        '
        Me.Npw.BackColor = System.Drawing.Color.White
        Me.Npw.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Npw.Location = New System.Drawing.Point(230, 147)
        Me.Npw.Name = "Npw"
        Me.Npw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Npw.Size = New System.Drawing.Size(217, 21)
        Me.Npw.TabIndex = 34
        '
        'Cpw
        '
        Me.Cpw.BackColor = System.Drawing.Color.White
        Me.Cpw.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cpw.Location = New System.Drawing.Point(230, 185)
        Me.Cpw.Name = "Cpw"
        Me.Cpw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Cpw.Size = New System.Drawing.Size(217, 21)
        Me.Cpw.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(69, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 18)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Confirm Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(69, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 18)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "New Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(98, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 36)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Change Your Password"
        '
        'FrmChPw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(565, 303)
        Me.Controls.Add(Me.Opw)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ChPw)
        Me.Controls.Add(Me.Npw)
        Me.Controls.Add(Me.Cpw)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmChPw"
        Me.Text = "Change Your Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Opw As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ChPw As Button
    Friend WithEvents Npw As TextBox
    Friend WithEvents Cpw As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
