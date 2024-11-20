<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class upcoming
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        Button3 = New Button()
        Button2 = New Button()
        description = New TextBox()
        title = New TextBox()
        Button1 = New Button()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(33, 61)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Enter Title ID Here..."
        TextBox1.Size = New Size(185, 27)
        TextBox1.TabIndex = 11
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(317, 305)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 10
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(170, 305)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 9
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' description
        ' 
        description.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        description.Location = New Point(33, 137)
        description.Multiline = True
        description.Name = "description"
        description.PlaceholderText = "Enter Description Here"
        description.Size = New Size(378, 150)
        description.TabIndex = 8
        ' 
        ' title
        ' 
        title.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        title.Location = New Point(33, 94)
        title.Name = "title"
        title.PlaceholderText = "Enter Title Name"
        title.Size = New Size(378, 34)
        title.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(33, 305)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 6
        Button1.Text = "Save"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(224, 61)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Date(YYYY-MM-DD)"
        TextBox2.Size = New Size(185, 27)
        TextBox2.TabIndex = 12
        ' 
        ' upcoming
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(873, 856)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(description)
        Controls.Add(title)
        Controls.Add(Button1)
        ForeColor = SystemColors.ControlText
        Name = "upcoming"
        StartPosition = FormStartPosition.Manual
        Text = "upcoming"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents description As TextBox
    Friend WithEvents title As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
End Class
