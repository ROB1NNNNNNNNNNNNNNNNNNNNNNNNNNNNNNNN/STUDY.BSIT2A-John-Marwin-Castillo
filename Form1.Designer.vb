<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        btnsave = New Button()
        txtpass = New TextBox()
        txtuname = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        btndelete = New Button()
        btnupdate = New Button()
        txtuid = New TextBox()
        Label5 = New Label()
        btnsearch = New Button()
        txtpassword = New TextBox()
        txtusername = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnsave)
        GroupBox1.Controls.Add(txtpass)
        GroupBox1.Controls.Add(txtuname)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(26, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(336, 367)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Insert"
        ' 
        ' btnsave
        ' 
        btnsave.Location = New Point(177, 244)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(75, 23)
        btnsave.TabIndex = 4
        btnsave.Text = "Save"
        btnsave.UseVisualStyleBackColor = True
        ' 
        ' txtpass
        ' 
        txtpass.Location = New Point(164, 131)
        txtpass.Name = "txtpass"
        txtpass.Size = New Size(100, 23)
        txtpass.TabIndex = 3
        ' 
        ' txtuname
        ' 
        txtuname.Location = New Point(164, 75)
        txtuname.Name = "txtuname"
        txtuname.Size = New Size(100, 23)
        txtuname.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(41, 131)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 1
        Label2.Text = "Password: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(41, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 15)
        Label1.TabIndex = 0
        Label1.Text = "Username: "
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btndelete)
        GroupBox2.Controls.Add(btnupdate)
        GroupBox2.Controls.Add(txtuid)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(btnsearch)
        GroupBox2.Controls.Add(txtpassword)
        GroupBox2.Controls.Add(txtusername)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Location = New Point(399, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(336, 367)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        GroupBox2.Text = "Search"
        ' 
        ' btndelete
        ' 
        btndelete.Location = New Point(215, 261)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(75, 23)
        btndelete.TabIndex = 9
        btndelete.Text = "Delete"
        btndelete.UseVisualStyleBackColor = True
        ' 
        ' btnupdate
        ' 
        btnupdate.Location = New Point(124, 261)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(75, 23)
        btnupdate.TabIndex = 8
        btnupdate.Text = "Update"
        btnupdate.UseVisualStyleBackColor = True
        ' 
        ' txtuid
        ' 
        txtuid.Location = New Point(164, 47)
        txtuid.Name = "txtuid"
        txtuid.Size = New Size(100, 23)
        txtuid.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(41, 47)
        Label5.Name = "Label5"
        Label5.Size = New Size(47, 15)
        Label5.TabIndex = 5
        Label5.Text = "UserID: "
        ' 
        ' btnsearch
        ' 
        btnsearch.Location = New Point(164, 232)
        btnsearch.Name = "btnsearch"
        btnsearch.Size = New Size(75, 23)
        btnsearch.TabIndex = 4
        btnsearch.Text = "Search"
        btnsearch.UseVisualStyleBackColor = True
        ' 
        ' txtpassword
        ' 
        txtpassword.Location = New Point(164, 131)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(100, 23)
        txtpassword.TabIndex = 3
        ' 
        ' txtusername
        ' 
        txtusername.Location = New Point(164, 88)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(100, 23)
        txtusername.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(41, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 15)
        Label3.TabIndex = 1
        Label3.Text = "Password: "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(41, 91)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 15)
        Label4.TabIndex = 0
        Label4.Text = "Username: "
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(341, 406)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 39)
        Button1.TabIndex = 7
        Button1.Text = "Filter Data"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(758, 549)
        Controls.Add(Button1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Insert"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnsave As Button
    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtuname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtuid As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnsearch As Button
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnupdate As Button
End Class
