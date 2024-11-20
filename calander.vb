Public Class Task
    Public Property daate As DateTime
    Public Property Title As String
    Public Property Description As String
End Class

Public Class calander
    Private TaskList As New List(Of Task)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        Dim selectedDate As DateTime = e.Start
        Dim taskTitle As String = InputBox("Enter task title:")
        Dim taskDescription As String = InputBox("Enter task description:")


        Dim newTask As New Task()
        newTask.daate = selectedDate
        newTask.Title = taskTitle
        newTask.Description = taskDescription

        TaskList.Add(newTask)
    End Sub
End Class
