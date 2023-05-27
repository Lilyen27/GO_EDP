Imports System.IO
Imports MySql.Data.MySqlClient

Public Class adminForm
    Private Sub usersbtn_Click(sender As Object, e As EventArgs) Handles usersbtn.Click
        Me.Hide()
        userForm.Show()
    End Sub

    Private Sub subjectbtn_Click(sender As Object, e As EventArgs) Handles subjectbtn.Click
        Me.Hide()
        subjectForm.Show()
    End Sub

    Private Sub studentbtn_Click(sender As Object, e As EventArgs) Handles studentbtn.Click
        Me.Hide()
        studentForm.Show()
    End Sub

    Private Sub teacherbtn_Click(sender As Object, e As EventArgs) Handles teacherbtn.Click
        Me.Hide()
        teacherForm.Show()
    End Sub

    Private Sub importbtn_Click(sender As Object, e As EventArgs) Handles importbtn.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "CSV Files (*.csv)|*.csv"
        openFileDialog.ShowDialog()

        If openFileDialog.FileName <> "" Then
            Dim dt As New DataTable()
            Dim fileReader As New StreamReader(openFileDialog.FileName)
            Dim line As String = fileReader.ReadLine()
            Dim columns As String() = line.Split(",")
            For Each column As String In columns
                dt.Columns.Add(column.Trim())
            Next
            While Not fileReader.EndOfStream
                line = fileReader.ReadLine()
                Dim fields As String() = line.Split(",")
                dt.Rows.Add(fields)
            End While
            fileReader.Close()
            DataGridView1.DataSource = dt
        End If
    End Sub

    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub backupbtn_Click(sender As Object, e As EventArgs) Handles backupbtn.Click
        Dim backup As New SaveFileDialog
        backup.InitialDirectory = "C:\"
        backup.Title = "Database Backup"
        backup.CheckFileExists = False
        backup.CheckPathExists = False
        backup.DefaultExt = "sql"
        backup.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*"
        backup.RestoreDirectory = True

        If backup.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call Connect_to_DB()
            Dim cmd As MySqlCommand = New MySqlCommand
            cmd.Connection = myconn
            Dim mb As MySqlBackup = New MySqlBackup(cmd)
            mb.ExportToFile(backup.FileName)
            myconn.Close()
            MessageBox.Show("Database Successfully Backup!", "BACKUP", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf backup.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Return
        End If
    End Sub

    Private Sub reportbtn_Click(sender As Object, e As EventArgs) Handles reportbtn.Click
        Me.Hide()
        reportForm.Show()
    End Sub
End Class