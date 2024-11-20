<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form3))
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Label3 = New Label()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Button7 = New Button()
        Button8 = New Button()
        Panel1 = New Panel()
        DataGridView1 = New DataGridView()
        TaskBindingSource2 = New BindingSource(components)
        TaskBindingSource1 = New BindingSource(components)
        TaskBindingSource = New BindingSource(components)
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(TaskBindingSource2, ComponentModel.ISupportInitialize).BeginInit()
        CType(TaskBindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        CType(TaskBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.DarkGray
        Label1.Font = New Font("Bauhaus 93", 19.8000011F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlText
        Label1.ImageAlign = ContentAlignment.MiddleLeft
        Label1.Location = New Point(12, 199)
        Label1.Name = "Label1"
        Label1.Size = New Size(318, 793)
        Label1.TabIndex = 0
        Label1.Text = "MENU"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Stencil", 48F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.InactiveCaptionText
        Label2.Location = New Point(810, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(568, 139)
        Label2.TabIndex = 1
        Label2.Text = "TaskMinder"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(12, 376)
        Button1.Name = "Button1"
        Button1.Size = New Size(277, 46)
        Button1.TabIndex = 3
        Button1.Text = "Upcoming"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(12, 285)
        Button2.Name = "Button2"
        Button2.Size = New Size(306, 42)
        Button2.TabIndex = 4
        Button2.Text = "Search"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(12, 339)
        Label3.Name = "Label3"
        Label3.Size = New Size(306, 25)
        Label3.TabIndex = 7
        Label3.Text = "Tasks"
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(12, 479)
        Button3.Name = "Button3"
        Button3.Size = New Size(277, 46)
        Button3.TabIndex = 8
        Button3.Text = "Calander"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button4.Image = CType(resources.GetObject("Button4.Image"), Image)
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(12, 428)
        Button4.Name = "Button4"
        Button4.Size = New Size(277, 45)
        Button4.TabIndex = 9
        Button4.Text = "Today"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button5.Image = CType(resources.GetObject("Button5.Image"), Image)
        Button5.ImageAlign = ContentAlignment.MiddleLeft
        Button5.Location = New Point(12, 531)
        Button5.Name = "Button5"
        Button5.Size = New Size(277, 47)
        Button5.TabIndex = 10
        Button5.Text = "Special Events"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Arial", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button6.Image = CType(resources.GetObject("Button6.Image"), Image)
        Button6.ImageAlign = ContentAlignment.MiddleLeft
        Button6.Location = New Point(12, 938)
        Button6.Name = "Button6"
        Button6.Size = New Size(110, 42)
        Button6.TabIndex = 11
        Button6.Text = "Sign Out"
        Button6.TextAlign = ContentAlignment.MiddleRight
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(12, 652)
        Label4.Name = "Label4"
        Label4.Size = New Size(306, 25)
        Label4.TabIndex = 12
        Label4.Text = "Label"
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.DarkGray
        Label5.Location = New Point(12, 598)
        Label5.Name = "Label5"
        Label5.Size = New Size(318, 25)
        Label5.TabIndex = 13
        Label5.Text = "--------------------------------------------------"
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.DarkGray
        Label6.Location = New Point(12, 848)
        Label6.Name = "Label6"
        Label6.Size = New Size(318, 25)
        Label6.TabIndex = 14
        Label6.Text = "--------------------------------------------------"
        ' 
        ' Button7
        ' 
        Button7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button7.Image = CType(resources.GetObject("Button7.Image"), Image)
        Button7.ImageAlign = ContentAlignment.MiddleLeft
        Button7.Location = New Point(12, 701)
        Button7.Name = "Button7"
        Button7.Size = New Size(277, 46)
        Button7.TabIndex = 15
        Button7.Text = "Personal"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button8.Image = CType(resources.GetObject("Button8.Image"), Image)
        Button8.ImageAlign = ContentAlignment.MiddleLeft
        Button8.Location = New Point(12, 768)
        Button8.Name = "Button8"
        Button8.Size = New Size(277, 46)
        Button8.TabIndex = 16
        Button8.Text = "Work"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(DataGridView1)
        Panel1.Location = New Point(336, 199)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1488, 802)
        Panel1.TabIndex = 17
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(661, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(824, 778)
        DataGridView1.TabIndex = 0
        ' 
        ' TaskBindingSource2
        ' 
        TaskBindingSource2.DataSource = GetType(Task)
        ' 
        ' TaskBindingSource1
        ' 
        TaskBindingSource1.DataSource = GetType(Task)
        ' 
        ' TaskBindingSource
        ' 
        TaskBindingSource.DataSource = GetType(Task)
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(318, 182)
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(1924, 1055)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Label3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        IsMdiContainer = True
        Name = "Form3"
        Text = "Form3"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(TaskBindingSource2, ComponentModel.ISupportInitialize).EndInit()
        CType(TaskBindingSource1, ComponentModel.ISupportInitialize).EndInit()
        CType(TaskBindingSource, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TaskBindingSource As BindingSource
    Friend WithEvents TaskBindingSource1 As BindingSource
    Friend WithEvents TaskBindingSource2 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
End Class
