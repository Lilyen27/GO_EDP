Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader

            strSQL = "Select * from users where username = '" _
                & .usernametxt.Text & "' and password = ('" _
                & .passwordtxt.Text & "')"
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn


            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                Me.Hide()
                adminForm.Show()
            Else
                MessageBox.Show("Invalid username or password")
            End If
            Call Disconnect_to_DB()
        End With
    End Sub
    Private Sub registerbtn_Click(sender As Object, e As EventArgs) Handles registerbtn.Click
        Me.Hide()
        registerForm.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim filePath As String = "C:\Users\johnmhel\Documents\mysql workbench\GO_EDP\User Manual\Users-Manual-GO.pdf"

        If File.Exists(filePath) Then
            Process.Start(filePath)
        Else
            MessageBox.Show("File not found")
        End If
    End Sub
End Class
