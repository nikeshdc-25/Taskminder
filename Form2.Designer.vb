<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        Label1 = New Label()
        Label2 = New Label()
        CheckBox1 = New CheckBox()
        Button1 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.ActiveCaptionText
        Label1.BorderStyle = BorderStyle.Fixed3D
        resources.ApplyResources(Label1, "Label1")
        Label1.ForeColor = SystemColors.Highlight
        Label1.Name = "Label1"
        ' 
        ' Label2
        ' 
        Label2.BackColor = SystemColors.ActiveCaptionText
        resources.ApplyResources(Label2, "Label2")
        Label2.ForeColor = SystemColors.Highlight
        Label2.Name = "Label2"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.BackColor = SystemColors.Window
        resources.ApplyResources(CheckBox1, "CheckBox1")
        CheckBox1.Name = "CheckBox1"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        resources.ApplyResources(Button1, "Button1")
        Button1.ForeColor = SystemColors.HotTrack
        Button1.Name = "Button1"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        resources.ApplyResources(TextBox1, "TextBox1")
        TextBox1.ForeColor = SystemColors.WindowText
        TextBox1.Name = "TextBox1"
        ' 
        ' TextBox2
        ' 
        resources.ApplyResources(TextBox2, "TextBox2")
        TextBox2.Name = "TextBox2"
        ' 
        ' Form2
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(CheckBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Name = "Form2"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
