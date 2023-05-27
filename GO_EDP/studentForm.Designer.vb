<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class studentForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.studentID = New System.Windows.Forms.TextBox()
        Me.addbtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.firstnametxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lastnametxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gendertxt = New System.Windows.Forms.TextBox()
        Me.agetxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.addresstxt = New System.Windows.Forms.TextBox()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.mainbtn = New System.Windows.Forms.Button()
        Me.loadbtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Coral
        Me.Label1.Location = New System.Drawing.Point(74, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "STUDENT ID:"
        '
        'studentID
        '
        Me.studentID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.studentID.Location = New System.Drawing.Point(79, 111)
        Me.studentID.Multiline = True
        Me.studentID.Name = "studentID"
        Me.studentID.Size = New System.Drawing.Size(314, 37)
        Me.studentID.TabIndex = 8
        '
        'addbtn
        '
        Me.addbtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addbtn.ForeColor = System.Drawing.Color.Coral
        Me.addbtn.Location = New System.Drawing.Point(78, 499)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(134, 48)
        Me.addbtn.TabIndex = 10
        Me.addbtn.Text = "ADD"
        Me.addbtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Coral
        Me.Label2.Location = New System.Drawing.Point(74, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 23)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "FIRST NAME:"
        '
        'firstnametxt
        '
        Me.firstnametxt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstnametxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.firstnametxt.Location = New System.Drawing.Point(79, 191)
        Me.firstnametxt.Multiline = True
        Me.firstnametxt.Name = "firstnametxt"
        Me.firstnametxt.Size = New System.Drawing.Size(314, 37)
        Me.firstnametxt.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Coral
        Me.Label3.Location = New System.Drawing.Point(74, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 23)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "LAST NAME:"
        '
        'lastnametxt
        '
        Me.lastnametxt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastnametxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lastnametxt.Location = New System.Drawing.Point(79, 276)
        Me.lastnametxt.Multiline = True
        Me.lastnametxt.Name = "lastnametxt"
        Me.lastnametxt.Size = New System.Drawing.Size(314, 37)
        Me.lastnametxt.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Coral
        Me.Label4.Location = New System.Drawing.Point(228, 334)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 23)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "GENDER:"
        '
        'gendertxt
        '
        Me.gendertxt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gendertxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gendertxt.Location = New System.Drawing.Point(233, 363)
        Me.gendertxt.Multiline = True
        Me.gendertxt.Name = "gendertxt"
        Me.gendertxt.Size = New System.Drawing.Size(160, 37)
        Me.gendertxt.TabIndex = 15
        '
        'agetxt
        '
        Me.agetxt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agetxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.agetxt.Location = New System.Drawing.Point(79, 363)
        Me.agetxt.Multiline = True
        Me.agetxt.Name = "agetxt"
        Me.agetxt.Size = New System.Drawing.Size(105, 37)
        Me.agetxt.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Coral
        Me.Label5.Location = New System.Drawing.Point(74, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 23)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "AGE:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Coral
        Me.Label6.Location = New System.Drawing.Point(322, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(484, 46)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "STUDENT IFORMATION"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(523, 111)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(555, 490)
        Me.DataGridView1.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Coral
        Me.Label7.Location = New System.Drawing.Point(75, 414)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 23)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "ADDRESS:"
        '
        'addresstxt
        '
        Me.addresstxt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addresstxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.addresstxt.Location = New System.Drawing.Point(79, 440)
        Me.addresstxt.Multiline = True
        Me.addresstxt.Name = "addresstxt"
        Me.addresstxt.Size = New System.Drawing.Size(314, 37)
        Me.addresstxt.TabIndex = 19
        '
        'deletebtn
        '
        Me.deletebtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletebtn.ForeColor = System.Drawing.Color.Coral
        Me.deletebtn.Location = New System.Drawing.Point(256, 499)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(137, 48)
        Me.deletebtn.TabIndex = 21
        Me.deletebtn.Text = "DELETE"
        Me.deletebtn.UseVisualStyleBackColor = True
        '
        'updatebtn
        '
        Me.updatebtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatebtn.ForeColor = System.Drawing.Color.Coral
        Me.updatebtn.Location = New System.Drawing.Point(79, 553)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(134, 48)
        Me.updatebtn.TabIndex = 22
        Me.updatebtn.Text = "UPDATE"
        Me.updatebtn.UseVisualStyleBackColor = True
        '
        'mainbtn
        '
        Me.mainbtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainbtn.ForeColor = System.Drawing.Color.Coral
        Me.mainbtn.Location = New System.Drawing.Point(946, 18)
        Me.mainbtn.Name = "mainbtn"
        Me.mainbtn.Size = New System.Drawing.Size(132, 48)
        Me.mainbtn.TabIndex = 23
        Me.mainbtn.Text = "MAIN MENU"
        Me.mainbtn.UseVisualStyleBackColor = True
        '
        'loadbtn
        '
        Me.loadbtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loadbtn.ForeColor = System.Drawing.Color.Coral
        Me.loadbtn.Location = New System.Drawing.Point(256, 553)
        Me.loadbtn.Name = "loadbtn"
        Me.loadbtn.Size = New System.Drawing.Size(137, 48)
        Me.loadbtn.TabIndex = 25
        Me.loadbtn.Text = "LOAD"
        Me.loadbtn.UseVisualStyleBackColor = True
        '
        'studentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.GO_EDP.My.Resources.Resources.pinkcover
        Me.ClientSize = New System.Drawing.Size(1090, 618)
        Me.Controls.Add(Me.loadbtn)
        Me.Controls.Add(Me.mainbtn)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.addresstxt)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.agetxt)
        Me.Controls.Add(Me.gendertxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lastnametxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.firstnametxt)
        Me.Controls.Add(Me.addbtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.studentID)
        Me.Name = "studentForm"
        Me.Text = "studentForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents studentID As TextBox
    Friend WithEvents addbtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents firstnametxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lastnametxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents gendertxt As TextBox
    Friend WithEvents agetxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents addresstxt As TextBox
    Friend WithEvents deletebtn As Button
    Friend WithEvents updatebtn As Button
    Friend WithEvents mainbtn As Button
    Friend WithEvents loadbtn As Button
End Class
