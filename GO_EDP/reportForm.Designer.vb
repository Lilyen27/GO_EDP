<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class reportForm
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
        Me.registerbtn = New System.Windows.Forms.Button()
        Me.mainbtn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'registerbtn
        '
        Me.registerbtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registerbtn.ForeColor = System.Drawing.Color.Coral
        Me.registerbtn.Location = New System.Drawing.Point(495, 754)
        Me.registerbtn.Name = "registerbtn"
        Me.registerbtn.Size = New System.Drawing.Size(127, 58)
        Me.registerbtn.TabIndex = 7
        Me.registerbtn.Text = "PRINT"
        Me.registerbtn.UseVisualStyleBackColor = True
        '
        'mainbtn
        '
        Me.mainbtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainbtn.ForeColor = System.Drawing.Color.Coral
        Me.mainbtn.Location = New System.Drawing.Point(942, 12)
        Me.mainbtn.Name = "mainbtn"
        Me.mainbtn.Size = New System.Drawing.Size(136, 48)
        Me.mainbtn.TabIndex = 24
        Me.mainbtn.Text = "MAIN MENU"
        Me.mainbtn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 89)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1066, 429)
        Me.DataGridView1.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Coral
        Me.Label6.Location = New System.Drawing.Point(447, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(216, 46)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "REPORTS"
        '
        'reportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GO_EDP.My.Resources.Resources.pinkcover
        Me.ClientSize = New System.Drawing.Size(1090, 833)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.mainbtn)
        Me.Controls.Add(Me.registerbtn)
        Me.Name = "reportForm"
        Me.Text = "reportForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents registerbtn As Button
    Friend WithEvents mainbtn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
End Class
