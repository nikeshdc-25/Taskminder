Imports MySql.Data.MySqlClient

Public Class Form2
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then

            TextBox2.PasswordChar = ControlChars.NullChar
        Else

            TextBox2.PasswordChar = "*"c
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MySqlConnection As New MySqlConnection
        MySqlConnection.ConnectionString = "server=localhost;userid=root;password='';database=taskminder"
        Try
            MySqlConnection.Open()
            Dim query As String
            query = "select * from taskminder.userdata where username='" & TextBox1.Text & "' and password = '" & TextBox2.Text & "' "
            command = New MySqlCommand(query, MySqlConnection)
            reader = command.ExecuteReader
            Dim count = 0
            While reader.Read
                count = count + 1
            End While
            If count = 1 Then
                MessageBox.Show("Succesfully connected to the Database!")
                MessageBox.Show("Welcome Back, " + TextBox1.Text + "!")
                Form3.ShowDialog()
                Me.Hide()
            Else
                MySqlConnection.Close()
                MsgBox(" Error Username/Password! Enter Again!!!", vbCritical)
            End If
        Catch ex As MySqlException
        End Try
    End Sub


End Class