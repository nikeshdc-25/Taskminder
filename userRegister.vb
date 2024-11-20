Imports MySql.Data.MySqlClient

Public Class userRegister
    Dim MySqlConnection As New MySqlConnection
    Dim command As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MySqlConnection As New MySqlConnection("server=localhost;userid=root; password=''; database = taskminder")
        Dim reader As MySqlDataReader
        Try
            MySqlConnection.Open()
            Dim query As String
            If TextBox3.Text = TextBox4.Text Then
                query = "insert into taskminder.userdata (appdata, username, password) values ('" & TextBox1.Text & "','" & TextBox2.Text & "' , '" & TextBox3.Text & "') "
                command = New MySqlCommand(query, MySqlConnection)
                reader = command.ExecuteReader
                MsgBox("Congratulation, Account has been created Successfully!")
                MySqlConnection.Close()
                Form3.ShowDialog()
                Me.Hide()
            Else
                MsgBox("Password Didn't Match. Try Again!")
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConnection.Dispose()
        End Try
    End Sub
End Class