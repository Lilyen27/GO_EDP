Imports MySql.Data.MySqlClient

Public Class teacherForm
    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "Insert into teacher values('" _
                & .teacherID.Text & "', '" _
                & .firstnametxt.Text & "', '" _
                & .lastnametxt.Text & "', '" _
                & .subjecttxt.Text & "')"
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
            .teacherID.Text = vbNullString
            .firstnametxt.Text = ""
            .lastnametxt.Text = ""
            .subjecttxt.Text = ""
        End With
    End Sub

    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "Update teacher set TeacherID = '" _
                & .teacherID.Text & "' where FirstName = '" _
                & .firstnametxt.Text & "' and LastName = '" _
                & .lastnametxt.Text & "' and SubjectHandled = '" _
                & .subjecttxt.Text & "'"

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
                    strSQL = "Delete from teacher" _
                                    & " where TeacherID = '" _
                                    & .teacherID.Text & "'"
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

    Private Sub loadbtn_Click(sender As Object, e As EventArgs) Handles loadbtn.Click
        Me.DataGridView1.Rows.Clear()
        Dim strsql As String
        Dim mycommand As New MySqlCommand
        strsql = "Select * from teacher"
        Connect_to_DB()
        With mycommand
            .Connection = myconn
            .CommandType = CommandType.Text
            .CommandText = strsql
        End With
        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader

        If DataGridView1.Columns.Count = 0 Then
            DataGridView1.Columns.Add("TeacherID", "Teacher ID")
            DataGridView1.Columns.Add("FirstName", "First Name")
            DataGridView1.Columns.Add("LastName", "Last Name")
            DataGridView1.Columns.Add("SubjectHandled", "Sibject Handled")
        End If
        While myreader.Read()
            Me.DataGridView1.Rows.Add(New Object() {myreader.Item("TeacherID"), myreader.Item("FirstName"), myreader.Item("LastName"), myreader.Item("SubjectHandled")})
        End While
        Disconnect_to_DB()
    End Sub

    Private Sub mainbtn_Click(sender As Object, e As EventArgs) Handles mainbtn.Click
        Me.Hide()
        adminForm.Show()
    End Sub
End Class