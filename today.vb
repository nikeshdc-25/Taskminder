Imports MySql.Data.MySqlClient

Public Class today
    Dim MySqlConnection As New MySqlConnection
    Dim command As MySqlCommand
    Private Sub today_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MySqlConnection As New MySqlConnection("server=localhost;userid=root; password=''; database = taskminder")
        Dim reader As MySqlDataReader
        Try
            MySqlConnection.Open()
            Dim query As String
            query = "insert into taskminder.alltasks (TaskID, TaskTitle, TaskDescription) values ('" & TextBox1.Text & "','" & title.Text & "' , '" & description.Text & "') "
            query = "insert into taskminder.today (titleID, title, description) values ('" & TextBox1.Text & "','" & title.Text & "' , '" & description.Text & "') "
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
            query = "update taskminder.alltasks set TaskTitle='" & title.Text & "' , TaskDescription='" & description.Text & "' where TaskID ='" & TextBox1.Text & "' "
            query = "update taskminder.today set title='" & title.Text & "' , description='" & description.Text & "' where titleID ='" & TextBox1.Text & "' "
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
            query = "delete from taskminder.alltasks where TaskID ='" & TextBox1.Text & "' "
            query = "delete from taskminder.today where titleID ='" & TextBox1.Text & "' "
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
End Class