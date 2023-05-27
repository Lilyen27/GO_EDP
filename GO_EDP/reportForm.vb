Imports System.Data.Common
Imports Excel = Microsoft.Office.Interop.Excel
Imports MySql.Data.MySqlClient

Public Class reportForm
    Public sqlColumns As String = "StudentID as Student_ID, first_name as First_Name, last_name as Last_Name, Age as Age, Gender as Gender, Address as Address"
    Private Sub Load_Data_to_Grid(ByVal strsql As String)
        Dim myreader As MySqlDataReader
        Dim mycommand As New MySqlCommand
        Dim mydataAdapter As New MySqlDataAdapter
        Dim mydatatable As New DataTable

        Connect_to_DB()
        With Me
            Try
                mycommand.Connection = myconn
                mycommand.CommandText = strsql
                myreader = mycommand.ExecuteReader
                mydatatable = New DataTable

                myreader.Close()
                mydataAdapter.SelectCommand = mycommand

                mydataAdapter.Fill(mydatatable)
                DataGridView1.AutoSize = True
                .DataGridView1.Refresh()
                .DataGridView1.EndEdit()
                .DataGridView1.DataSource = mydatatable
                .DataGridView1.ReadOnly = True
                .DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

            Catch ex As MySqlException
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error on SQL query")
            End Try
            myreader = Nothing
            mycommand = Nothing
            Disconnect_to_DB()
        End With
    End Sub

    Private Sub reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Load_Data_to_Grid("select " & Me.sqlColumns & " from students")
    End Sub

    Private Sub mainbtn_Click(sender As Object, e As EventArgs) Handles mainbtn.Click
        Me.Hide()
        adminForm.Show()
    End Sub

    Private Sub registerbtn_Click(sender As Object, e As EventArgs) Handles registerbtn.Click
        Call importToExcel(Me.DataGridView1, "STUDENTREPORT.xlsx")
    End Sub
End Class