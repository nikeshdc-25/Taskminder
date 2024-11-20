<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class today
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
        Button1 = New Button()
        title = New TextBox()
        description = New TextBox()
        Button2 = New Button()
        Button3 = New Button()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(32, 307)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 0
        Button1.Text = "Save"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' title
        ' 
        title.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        title.Location = New Point(32, 96)
        title.Name = "title"
        title.PlaceholderText = "Enter Title Name"
        title.Size = New Size(378, 34)
        title.TabIndex = 1
        ' 
        ' description
        ' 
        description.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        description.Location = New Point(32, 139)
        description.Multiline = True
        description.Name = "description"
        description.PlaceholderText = "Enter Description Here"
        description.Size = New Size(378, 150)
        description.TabIndex = 2
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(169, 307)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 3
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(316, 307)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 4
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(37, 56)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Enter Title ID Here..."
        TextBox1.Size = New Size(154, 27)
        TextBox1.TabIndex = 5
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' today
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.Beige
        ClientSize = New Size(868, 890)
        Controls.Add(TextBox1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(description)
        Controls.Add(title)
        Controls.Add(Button1)
        Name = "today"
        StartPosition = FormStartPosition.Manual
        Text = "today"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents title As TextBox
    Friend WithEvents description As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
