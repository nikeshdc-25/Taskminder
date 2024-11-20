Imports MySql.Data.MySqlClient
Public Class upcoming
    Dim MySqlConnection As New MySqlConnection
    Dim command As MySqlCommand
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MySqlConnection As New MySqlConnection("server=localhost;userid=root; password=''; database = taskminder")
        Dim reader As MySqlDataReader
        Try
            MySqlConnection.Open()
            Dim query As String
            query = "insert into taskminder.upcoming (Date, titleID, title, description) values ('" & TextBox2.Text & "', '" & TextBox1.Text & "','" & title.Text & "' , '" & description.Text & "') "
            command = New MySqlCommand(query, MySqlConnection)
            reader = command.ExecuteReader
            MsgBox("Task Added Successfully!")
            MySqlConnection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConnection.Dispose()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MySqlConnection As New MySqlConnection("server=localhost;userid=root; password=''; database = taskminder")
        Dim reader As MySqlDataReader
        Try
            MySqlConnection.Open()
            Dim query As String
            query = "update taskminder.upcoming set date='" & TextBox2.Text & "', title='" & title.Text & "' , description='" & description.Text & "' where titleID ='" & TextBox1.Text & "' "
            command = New MySqlCommand(query, MySqlConnection)
            reader = command.ExecuteReader
            MsgBox("Task Updated Successfully!")
            MySqlConnection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConnection.Dispose()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim MySqlConnection As New MySqlConnection("server=localhost;userid=root; password=''; database = taskminder")
        Dim reader As MySqlDataReader
        Try
            MySqlConnection.Open()
            Dim query As String
            query = "delete from taskminder.upcoming where titleID ='" & TextBox1.Text & "' "
            command = New MySqlCommand(query, MySqlConnection)
            reader = command.ExecuteReader
            MsgBox("Task Deleted Successfully!")
            MySqlConnection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConnection.Dispose()
        End Try
    End Sub

    Private Sub upcoming_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class