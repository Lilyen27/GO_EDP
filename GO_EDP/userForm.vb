﻿Imports MySql.Data.MySqlClient

Public Class userForm
    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "Insert into users values('" _
                & .useridtxt.Text & "', '" _
                & .usernametxt.Text & "', '" _
                & .passwordtxt.Text & "', '" _
                & .imagetxt.Text & "', '" _
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
            .useridtxt.Text = vbNullString
            .usernametxt.Text = ""
            .passwordtxt.Text = ""
            .imagetxt.Text = ""
            .addresstxt.Text = ""
        End With
    End Sub

    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "Update teacher set user_id = '" _
                & .useridtxt.Text & "' where username = '" _
                & .usernametxt.Text & "' and password = '" _
                & .passwordtxt.Text & "' and email = '" _
                & .imagetxt.Text & "' and address = '" _
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
                    strSQL = "Delete from users" _
                                    & " where user_id = '" _
                                    & .useridtxt.Text & "'"
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
        strsql = "Select * from users"
        Connect_to_DB()
        With mycommand
            .Connection = myconn
            .CommandType = CommandType.Text
            .CommandText = strsql
        End With
        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader

        If DataGridView1.Columns.Count = 0 Then
            DataGridView1.Columns.Add("user_id", "User ID")
            DataGridView1.Columns.Add("username", "First Name")
            DataGridView1.Columns.Add("password", "Last Name")
            DataGridView1.Columns.Add("email", "Email")
            DataGridView1.Columns.Add("address", "Address")
        End If
        While myreader.Read()
            Me.DataGridView1.Rows.Add(New Object() {myreader.Item("user_id"), myreader.Item("username"), myreader.Item("password"), myreader.Item("email"), myreader.Item("Address")})
        End While
        Disconnect_to_DB()
    End Sub

    Private Sub mainbtn_Click(sender As Object, e As EventArgs) Handles mainbtn.Click
        Me.Hide()
        adminForm.Show()
    End Sub
End Class