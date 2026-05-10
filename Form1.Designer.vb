<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel2 = New Panel()
        Button1 = New Button()
        Panel3 = New Panel()
        Button2 = New Button()
        Panel4 = New Panel()
        Button3 = New Button()
        Panel5 = New Panel()
        Button4 = New Button()
        Panel6 = New Panel()
        Button5 = New Button()
        Panel7 = New Panel()
        Button6 = New Button()
        Panel8 = New Panel()
        Button7 = New Button()
        Panel9 = New Panel()
        Button8 = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        Panel8.SuspendLayout()
        Panel9.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 37)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(37, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(191, 20)
        Label1.TabIndex = 1
        Label1.Text = "SISTEM MANAJEMEN KOST"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.justify_align_3489323
        PictureBox1.Location = New Point(12, 7)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(19, 22)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.Black
        FlowLayoutPanel1.Controls.Add(Panel2)
        FlowLayoutPanel1.Location = New Point(1, 35)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(166, 420)
        FlowLayoutPanel1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.Controls.Add(Button1)
        Panel2.Location = New Point(3, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(202, 34)
        Panel2.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.White
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(-98, -3)
        Button1.Name = "Button1"
        Button1.Padding = New Padding(25, 0, 0, 0)
        Button1.Size = New Size(272, 58)
        Button1.TabIndex = 3
        Button1.Text = "                    Profil"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Black
        Panel3.Controls.Add(Button2)
        Panel3.Location = New Point(219, 331)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(202, 52)
        Panel3.TabIndex = 4
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Black
        Button2.ForeColor = Color.White
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(-26, -13)
        Button2.Name = "Button2"
        Button2.Padding = New Padding(25, 0, 0, 0)
        Button2.Size = New Size(272, 75)
        Button2.TabIndex = 3
        Button2.Text = "                    Kontak"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Black
        Panel4.Location = New Point(473, 113)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(202, 52)
        Panel4.TabIndex = 5
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Black
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.White
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.Location = New Point(-94, 39)
        Button3.Name = "Button3"
        Button3.Padding = New Padding(25, 0, 0, 0)
        Button3.Size = New Size(272, 75)
        Button3.TabIndex = 3
        Button3.Text = "                       Cari Kost"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Black
        Panel5.Location = New Point(473, 171)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(202, 52)
        Panel5.TabIndex = 5
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Black
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = Color.White
        Button4.Image = CType(resources.GetObject("Button4.Image"), Image)
        Button4.Location = New Point(-94, 88)
        Button4.Name = "Button4"
        Button4.Padding = New Padding(25, 0, 0, 0)
        Button4.Size = New Size(272, 75)
        Button4.TabIndex = 3
        Button4.Text = "                    Galeri"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Black
        Panel6.Controls.Add(Button5)
        Panel6.Location = New Point(219, 389)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(202, 52)
        Panel6.TabIndex = 6
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Black
        Button5.ForeColor = Color.White
        Button5.Image = CType(resources.GetObject("Button5.Image"), Image)
        Button5.Location = New Point(-46, -10)
        Button5.Name = "Button5"
        Button5.Padding = New Padding(25, 0, 0, 0)
        Button5.Size = New Size(272, 75)
        Button5.TabIndex = 3
        Button5.Text = "                    Profil"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.Black
        Panel7.Controls.Add(Button4)
        Panel7.Controls.Add(Button3)
        Panel7.Controls.Add(Button6)
        Panel7.Location = New Point(0, 84)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(167, 166)
        Panel7.TabIndex = 7
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Black
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatStyle = FlatStyle.Flat
        Button6.ForeColor = Color.White
        Button6.Image = CType(resources.GetObject("Button6.Image"), Image)
        Button6.Location = New Point(-94, -6)
        Button6.Name = "Button6"
        Button6.Padding = New Padding(25, 0, 0, 0)
        Button6.Size = New Size(272, 75)
        Button6.TabIndex = 3
        Button6.Text = "                    Menu"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.Black
        Panel8.Controls.Add(Button7)
        Panel8.Location = New Point(473, 229)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(202, 52)
        Panel8.TabIndex = 7
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Black
        Button7.ForeColor = Color.White
        Button7.Image = CType(resources.GetObject("Button7.Image"), Image)
        Button7.Location = New Point(-60, -13)
        Button7.Name = "Button7"
        Button7.Padding = New Padding(25, 0, 0, 0)
        Button7.Size = New Size(272, 75)
        Button7.TabIndex = 3
        Button7.Text = "                            Tentang Kami"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.Black
        Panel9.Controls.Add(Button8)
        Panel9.Location = New Point(473, 287)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(202, 52)
        Panel9.TabIndex = 7
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.Black
        Button8.ForeColor = Color.White
        Button8.Image = CType(resources.GetObject("Button8.Image"), Image)
        Button8.Location = New Point(-60, -13)
        Button8.Name = "Button8"
        Button8.Padding = New Padding(25, 0, 0, 0)
        Button8.Size = New Size(272, 75)
        Button8.TabIndex = 3
        Button8.Text = "                    Keluar"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel9)
        Controls.Add(Panel7)
        Controls.Add(Panel8)
        Controls.Add(Panel6)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel5)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Button8 As Button

End Class
