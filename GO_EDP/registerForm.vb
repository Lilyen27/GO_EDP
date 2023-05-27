Imports MySql.Data.MySqlClient

Public Class registerForm
    Private Sub registerbtn_Click(sender As Object, e As EventArgs) Handles registerbtn.Click
        Call Connect_to_DB()
        Dim mycmd As New MySqlCommand

        Dim name As String = usernametxt.Text
        Dim password As String = passwordtxt.Text
        Dim address As String = emailtxt.Text
        Dim email As String = addresstxt.Text

        Dim sql As String = "INSERT INTO users (username, password, email, address) VALUES (@name, @password, @email, @address)"
        mycmd = New MySqlCommand(sql, myconn)

        mycmd.Parameters.AddWithValue("@name", name)
        mycmd.Parameters.AddWithValue("@password", password)
        mycmd.Parameters.AddWithValue("@email", email)
        mycmd.Parameters.AddWithValue("@address", address)
        mycmd.ExecuteNonQuery()
        MessageBox.Show("Account Successfully Created!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Call Disconnect_to_DB()
        Form1.Show()
        Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class