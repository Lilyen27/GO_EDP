<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userForm
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
        Me.loadbtn = New System.Windows.Forms.Button()
        Me.mainbtn = New System.Windows.Forms.Button()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.addresstxt = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.imagetxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.passwordtxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.usernametxt = New System.Windows.Forms.TextBox()
        Me.addbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.useridtxt = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'loadbtn
        '
        Me.loadbtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loadbtn.ForeColor = System.Drawing.Color.Coral
        Me.loadbtn.Location = New System.Drawing.Point(225, 544)
        Me.loadbtn.Name = "loadbtn"
        Me.loadbtn.Size = New System.Drawing.Size(137, 48)
        Me.loadbtn.TabIndex = 44
        Me.loadbtn.Text = "LOAD"
        Me.loadbtn.UseVisualStyleBackColor = True
        '
        'mainbtn
        '
        Me.mainbtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainbtn.ForeColor = System.Drawing.Color.Coral
        Me.mainbtn.Location = New System.Drawing.Point(911, 20)
        Me.mainbtn.Name = "mainbtn"
        Me.mainbtn.Size = New System.Drawing.Size(136, 48)
        Me.mainbtn.TabIndex = 43
        Me.mainbtn.Text = "MAIN MENU"
        Me.mainbtn.UseVisualStyleBackColor = True
        '
        'updatebtn
        '
        Me.updatebtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatebtn.ForeColor = System.Drawing.Color.Coral
        Me.updatebtn.Location = New System.Drawing.Point(48, 544)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(134, 48)
        Me.updatebtn.TabIndex = 42
        Me.updatebtn.Text = "UPDATE"
        Me.updatebtn.UseVisualStyleBackColor = True
        '
        'deletebtn
        '
        Me.deletebtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletebtn.ForeColor = System.Drawing.Color.Coral
        Me.deletebtn.Location = New System.Drawing.Point(225, 490)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(137, 48)
        Me.deletebtn.TabIndex = 41
        Me.deletebtn.Text = "DELETE"
        Me.deletebtn.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Coral
        Me.Label7.Location = New System.Drawing.Point(44, 416)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 23)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "ADDRESS:"
        '
        'addresstxt
        '
        Me.addresstxt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addresstxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.addresstxt.Location = New System.Drawing.Point(48, 442)
        Me.addresstxt.Multiline = True
        Me.addresstxt.Name = "addresstxt"
        Me.addresstxt.Size = New System.Drawing.Size(314, 37)
        Me.addresstxt.TabIndex = 39
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(492, 96)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(555, 496)
        Me.DataGridView1.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Coral
        Me.Label6.Location = New System.Drawing.Point(326, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(436, 46)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "REGISTERED USERS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Coral
        Me.Label5.Location = New System.Drawing.Point(43, 336)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 23)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "EMAIL:"
        '
        'imagetxt
        '
        Me.imagetxt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imagetxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.imagetxt.Location = New System.Drawing.Point(48, 365)
        Me.imagetxt.Multiline = True
        Me.imagetxt.Name = "imagetxt"
        Me.imagetxt.Size = New System.Drawing.Size(314, 37)
        Me.imagetxt.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Coral
        Me.Label3.Location = New System.Drawing.Point(43, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 23)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "PASSWORD:"
        '
        'passwordtxt
        '
        Me.passwordtxt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordtxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.passwordtxt.Location = New System.Drawing.Point(48, 278)
        Me.passwordtxt.Multiline = True
        Me.passwordtxt.Name = "passwordtxt"
        Me.passwordtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordtxt.Size = New System.Drawing.Size(314, 37)
        Me.passwordtxt.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Coral
        Me.Label2.Location = New System.Drawing.Point(43, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 23)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "USERNAME:"
        '
        'usernametxt
        '
        Me.usernametxt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernametxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.usernametxt.Location = New System.Drawing.Point(48, 193)
        Me.usernametxt.Multiline = True
        Me.usernametxt.Name = "usernametxt"
        Me.usernametxt.Size = New System.Drawing.Size(314, 37)
        Me.usernametxt.TabIndex = 29
        '
        'addbtn
        '
        Me.addbtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addbtn.ForeColor = System.Drawing.Color.Coral
        Me.addbtn.Location = New System.Drawing.Point(47, 490)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(134, 48)
        Me.addbtn.TabIndex = 28
        Me.addbtn.Text = "ADD"
        Me.addbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Coral
        Me.Label1.Location = New System.Drawing.Point(43, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 23)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "USER ID:"
        '
        'useridtxt
        '
        Me.useridtxt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.useridtxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.useridtxt.Location = New System.Drawing.Point(48, 113)
        Me.useridtxt.Multiline = True
        Me.useridtxt.Name = "useridtxt"
        Me.useridtxt.Size = New System.Drawing.Size(314, 37)
        Me.useridtxt.TabIndex = 26
        '
        'userForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GO_EDP.My.Resources.Resources.pinkcover
        Me.ClientSize = New System.Drawing.Size(1090, 612)
        Me.Controls.Add(Me.loadbtn)
        Me.Controls.Add(Me.mainbtn)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.addresstxt)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.imagetxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.passwordtxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.usernametxt)
        Me.Controls.Add(Me.addbtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.useridtxt)
        Me.Name = "userForm"
        Me.Text = "userForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loadbtn As Button
    Friend WithEvents mainbtn As Button
    Friend WithEvents updatebtn As Button
    Friend WithEvents deletebtn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents addresstxt As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents imagetxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents passwordtxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents usernametxt As TextBox
    Friend WithEvents addbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents useridtxt As TextBox
End Class
