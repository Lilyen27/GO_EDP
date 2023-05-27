Imports Excel = Microsoft.Office.Interop.Excel
Imports MySql.Data.MySqlClient

Public Class studentForm
    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "Insert into students values('" _
                & .studentID.Text & "', '" _
                & .firstnametxt.Text & "', '" _
                & .lastnametxt.Text & "', '" _
                & .agetxt.Text & "', '" _
                & .gendertxt.Text & "', '" _
                & .addresstxt.Text & "')"
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Record Successfully Added!")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Disconnect_to_DB()
        End With
    End Sub

    Private Sub Clear_Boxes()
        With Me
            .studentID.Text = vbNullString
            .firstnametxt.Text = ""
            .lastnametxt.Text = ""
            .agetxt.Text = ""
            .gendertxt.Text = ""
            .addresstxt.Text = ""
        End With
    End Sub

    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "Update students set StudentID = '" _
                & .studentID.Text & "' where first_name = '" _
                & .firstnametxt.Text & "' and last_name = '" _
                & .lastnametxt.Text & "' and Age = '" _
                & .agetxt.Text & "' and Gender = '" _
                & .gendertxt.Text & "' and Address = '" _
                & .addresstxt.Text & "'"

                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Record Successfully Updated")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Disconnect_to_DB()
        End With
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                Dim answer As MsgBoxResult
                answer = MsgBox("Are you sure you want to delete this record", MsgBoxStyle.YesNo)
                If answer = MsgBoxResult.Yes Then
                    strSQL = "Delete from students" _
                                    & " where StudentID = '" _
                                    & .studentID.Text & "'"
                    mycmd.CommandText = strSQL
                    mycmd.Connection = myconn
                    mycmd.ExecuteNonQuery()
                    MsgBox("Record Successfully Deleted")
                    Call Clear_Boxes()
                End If

            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Disconnect_to_DB()
        End With
    End Sub

    Private Sub mainbtn_Click(sender As Object, e As EventArgs) Handles mainbtn.Click
        Me.Hide()
        adminForm.Show()
    End Sub

    Private Sub loadbtn_Click(sender As Object, e As EventArgs) Handles loadbtn.Click
        Me.DataGridView1.Rows.Clear()
        Dim strsql As String
        Dim mycommand As New MySqlCommand
        strsql = "Select * from students"
        Connect_to_DB()
        With mycommand
            .Connection = myconn
            .CommandType = CommandType.Text
            .CommandText = strsql
        End With
        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader

        If DataGridView1.Columns.Count = 0 Then
            DataGridView1.Columns.Add("StudentID", "Student ID")
            DataGridView1.Columns.Add("first_name", "First Name")
            DataGridView1.Columns.Add("last_name", "Last Name")
            DataGridView1.Columns.Add("Age", "Age")
            DataGridView1.Columns.Add("Gender", "Gender")
            DataGridView1.Columns.Add("Address", "Address")
        End If
        While myreader.Read()
            Me.DataGridView1.Rows.Add(New Object() {myreader.Item("StudentID"), myreader.Item("first_name"), myreader.Item("last_name"), myreader.Item("Age"), myreader.Item("Gender"), myreader.Item("Address")})
        End While
        Disconnect_to_DB()
    End Sub
End Class