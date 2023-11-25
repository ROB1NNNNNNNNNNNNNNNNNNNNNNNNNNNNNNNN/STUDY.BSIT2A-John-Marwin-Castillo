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
        cbotype = New ComboBox()
        Search = New Label()
        txtdata = New TextBox()
        btnfind = New Button()
        dgvrecord = New DataGridView()
        btnback = New Button()
        CType(dgvrecord, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cbotype
        ' 
        cbotype.FormattingEnabled = True
        cbotype.Location = New Point(65, 35)
        cbotype.Name = "cbotype"
        cbotype.Size = New Size(199, 23)
        cbotype.TabIndex = 0
        ' 
        ' Search
        ' 
        Search.AutoSize = True
        Search.Location = New Point(270, 43)
        Search.Name = "Search"
        Search.Size = New Size(42, 15)
        Search.TabIndex = 1
        Search.Text = "Search"
        ' 
        ' txtdata
        ' 
        txtdata.Location = New Point(440, 35)
        txtdata.Name = "txtdata"
        txtdata.Size = New Size(209, 23)
        txtdata.TabIndex = 2
        ' 
        ' btnfind
        ' 
        btnfind.Location = New Point(664, 35)
        btnfind.Name = "btnfind"
        btnfind.Size = New Size(112, 23)
        btnfind.TabIndex = 3
        btnfind.Text = "Find Record"
        btnfind.UseVisualStyleBackColor = True
        ' 
        ' dgvrecord
        ' 
        dgvrecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvrecord.Location = New Point(12, 70)
        dgvrecord.Name = "dgvrecord"
        dgvrecord.RowTemplate.Height = 25
        dgvrecord.Size = New Size(766, 304)
        dgvrecord.TabIndex = 4
        ' 
        ' btnback
        ' 
        btnback.Location = New Point(664, 393)
        btnback.Name = "btnback"
        btnback.Size = New Size(114, 39)
        btnback.TabIndex = 5
        btnback.Text = "Back"
        btnback.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(788, 493)
        ControlBox = False
        Controls.Add(btnback)
        Controls.Add(dgvrecord)
        Controls.Add(btnfind)
        Controls.Add(txtdata)
        Controls.Add(Search)
        Controls.Add(cbotype)
        Name = "Form2"
        Text = "Form2"
        CType(dgvrecord, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cbotype As ComboBox
    Friend WithEvents Search As Label
    Friend WithEvents txtdata As TextBox
    Friend WithEvents btnfind As Button
    Friend WithEvents dgvrecord As DataGridView
    Friend WithEvents btnback As Button
End Class
