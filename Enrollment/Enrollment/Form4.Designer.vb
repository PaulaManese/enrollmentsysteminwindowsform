<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Main_Menu = New Button()
        Add_Rec_Click = New Button()
        T_STLRN = New ComboBox()
        T_PID = New ComboBox()
        SearchBox_Click = New Button()
        Delete_Click = New Button()
        Update_Click = New Button()
        Clear_Click = New Button()
        T_SUBCODE = New ComboBox()
        Label4 = New Label()
        Label5 = New Label()
        Search_Box = New TextBox()
        T_SCID = New ComboBox()
        Label6 = New Label()
        T_DATE = New TextBox()
        T_ID = New TextBox()
        Label7 = New Label()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 22.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.Highlight
        Label1.Location = New Point(709, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(220, 43)
        Label1.TabIndex = 41
        Label1.Text = "Transaction"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cambria", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.MenuHighlight
        Label2.Location = New Point(232, 223)
        Label2.Name = "Label2"
        Label2.Size = New Size(388, 36)
        Label2.TabIndex = 42
        Label2.Text = "Student's Learning Number"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cambria", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.MenuHighlight
        Label3.Location = New Point(229, 323)
        Label3.Name = "Label3"
        Label3.Size = New Size(268, 36)
        Label3.TabIndex = 43
        Label3.Text = "Personnel Number"
        ' 
        ' Main_Menu
        ' 
        Main_Menu.BackColor = SystemColors.Highlight
        Main_Menu.Font = New Font("Cambria", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Main_Menu.ForeColor = SystemColors.ButtonHighlight
        Main_Menu.Location = New Point(532, 923)
        Main_Menu.Name = "Main_Menu"
        Main_Menu.Size = New Size(293, 74)
        Main_Menu.TabIndex = 44
        Main_Menu.Text = "Back to Main Menu"
        Main_Menu.UseVisualStyleBackColor = False
        ' 
        ' Add_Rec_Click
        ' 
        Add_Rec_Click.BackColor = SystemColors.Highlight
        Add_Rec_Click.Font = New Font("Cambria", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Add_Rec_Click.ForeColor = SystemColors.ButtonHighlight
        Add_Rec_Click.Location = New Point(603, 767)
        Add_Rec_Click.Name = "Add_Rec_Click"
        Add_Rec_Click.Size = New Size(212, 74)
        Add_Rec_Click.TabIndex = 83
        Add_Rec_Click.Text = "Enroll"
        Add_Rec_Click.UseVisualStyleBackColor = False
        ' 
        ' T_STLRN
        ' 
        T_STLRN.BackColor = Color.Cornsilk
        T_STLRN.Font = New Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        T_STLRN.ForeColor = SystemColors.HotTrack
        T_STLRN.FormattingEnabled = True
        T_STLRN.Location = New Point(703, 214)
        T_STLRN.Name = "T_STLRN"
        T_STLRN.Size = New Size(300, 51)
        T_STLRN.TabIndex = 84
        ' 
        ' T_PID
        ' 
        T_PID.BackColor = Color.Cornsilk
        T_PID.Font = New Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        T_PID.ForeColor = SystemColors.HotTrack
        T_PID.FormattingEnabled = True
        T_PID.Items.AddRange(New Object() {"School", "Subject"})
        T_PID.Location = New Point(703, 323)
        T_PID.Name = "T_PID"
        T_PID.Size = New Size(300, 51)
        T_PID.TabIndex = 85
        ' 
        ' SearchBox_Click
        ' 
        SearchBox_Click.BackColor = SystemColors.Highlight
        SearchBox_Click.Font = New Font("Cambria", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        SearchBox_Click.ForeColor = SystemColors.ButtonHighlight
        SearchBox_Click.Location = New Point(1113, 612)
        SearchBox_Click.Name = "SearchBox_Click"
        SearchBox_Click.Size = New Size(212, 74)
        SearchBox_Click.TabIndex = 88
        SearchBox_Click.Text = "Search"
        SearchBox_Click.UseVisualStyleBackColor = False
        ' 
        ' Delete_Click
        ' 
        Delete_Click.BackColor = SystemColors.Highlight
        Delete_Click.Font = New Font("Cambria", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Delete_Click.ForeColor = SystemColors.ButtonHighlight
        Delete_Click.Location = New Point(1113, 1042)
        Delete_Click.Name = "Delete_Click"
        Delete_Click.Size = New Size(212, 74)
        Delete_Click.TabIndex = 87
        Delete_Click.Text = "Delete"
        Delete_Click.UseVisualStyleBackColor = False
        ' 
        ' Update_Click
        ' 
        Update_Click.BackColor = SystemColors.Highlight
        Update_Click.Font = New Font("Cambria", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Update_Click.ForeColor = SystemColors.ButtonHighlight
        Update_Click.Location = New Point(1113, 944)
        Update_Click.Name = "Update_Click"
        Update_Click.Size = New Size(212, 74)
        Update_Click.TabIndex = 86
        Update_Click.Text = "Update"
        Update_Click.UseVisualStyleBackColor = False
        ' 
        ' Clear_Click
        ' 
        Clear_Click.BackColor = SystemColors.Highlight
        Clear_Click.Font = New Font("Cambria", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Clear_Click.ForeColor = SystemColors.ButtonHighlight
        Clear_Click.Location = New Point(1113, 727)
        Clear_Click.Name = "Clear_Click"
        Clear_Click.Size = New Size(212, 74)
        Clear_Click.TabIndex = 89
        Clear_Click.Text = "Clear"
        Clear_Click.UseVisualStyleBackColor = False
        ' 
        ' T_SUBCODE
        ' 
        T_SUBCODE.BackColor = Color.Cornsilk
        T_SUBCODE.Font = New Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        T_SUBCODE.ForeColor = SystemColors.HotTrack
        T_SUBCODE.FormattingEnabled = True
        T_SUBCODE.Items.AddRange(New Object() {"School", "Subject"})
        T_SUBCODE.Location = New Point(706, 514)
        T_SUBCODE.Name = "T_SUBCODE"
        T_SUBCODE.Size = New Size(300, 51)
        T_SUBCODE.TabIndex = 93
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cambria", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.MenuHighlight
        Label4.Location = New Point(232, 523)
        Label4.Name = "Label4"
        Label4.Size = New Size(114, 36)
        Label4.TabIndex = 91
        Label4.Text = "Subject"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Cambria", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.MenuHighlight
        Label5.Location = New Point(229, 425)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 36)
        Label5.TabIndex = 90
        Label5.Text = "School"
        ' 
        ' Search_Box
        ' 
        Search_Box.BackColor = Color.Cornsilk
        Search_Box.Font = New Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Search_Box.ForeColor = SystemColors.HotTrack
        Search_Box.Location = New Point(1057, 558)
        Search_Box.Name = "Search_Box"
        Search_Box.Size = New Size(335, 31)
        Search_Box.TabIndex = 94
        ' 
        ' T_SCID
        ' 
        T_SCID.BackColor = Color.Cornsilk
        T_SCID.Font = New Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        T_SCID.ForeColor = SystemColors.HotTrack
        T_SCID.FormattingEnabled = True
        T_SCID.Items.AddRange(New Object() {"School", "Subject"})
        T_SCID.Location = New Point(703, 410)
        T_SCID.Name = "T_SCID"
        T_SCID.Size = New Size(300, 51)
        T_SCID.TabIndex = 95
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Cambria", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.MenuHighlight
        Label6.Location = New Point(232, 610)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 36)
        Label6.TabIndex = 96
        Label6.Text = "Date"
        ' 
        ' T_DATE
        ' 
        T_DATE.BackColor = Color.Cornsilk
        T_DATE.Font = New Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point)
        T_DATE.ForeColor = SystemColors.HotTrack
        T_DATE.Location = New Point(709, 617)
        T_DATE.Name = "T_DATE"
        T_DATE.Size = New Size(300, 31)
        T_DATE.TabIndex = 97
        ' 
        ' T_ID
        ' 
        T_ID.BackColor = Color.Cornsilk
        T_ID.Font = New Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point)
        T_ID.ForeColor = SystemColors.HotTrack
        T_ID.Location = New Point(709, 690)
        T_ID.Name = "T_ID"
        T_ID.Size = New Size(300, 31)
        T_ID.TabIndex = 99
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Cambria", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label7.ForeColor = SystemColors.MenuHighlight
        Label7.Location = New Point(229, 709)
        Label7.Name = "Label7"
        Label7.Size = New Size(296, 36)
        Label7.TabIndex = 98
        Label7.Text = "Transaction Number"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ActiveCaption
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(1449, 90)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(420, 1012)
        DataGridView1.TabIndex = 100
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1893, 1185)
        Controls.Add(DataGridView1)
        Controls.Add(T_ID)
        Controls.Add(Label7)
        Controls.Add(T_DATE)
        Controls.Add(Label6)
        Controls.Add(T_SCID)
        Controls.Add(Search_Box)
        Controls.Add(T_SUBCODE)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Clear_Click)
        Controls.Add(SearchBox_Click)
        Controls.Add(Delete_Click)
        Controls.Add(Update_Click)
        Controls.Add(T_PID)
        Controls.Add(T_STLRN)
        Controls.Add(Add_Rec_Click)
        Controls.Add(Main_Menu)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form4"
        Text = "Form4"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Main_Menu As Button
    Friend WithEvents Add_Rec_Click As Button
    Friend WithEvents T_STLRN As ComboBox
    Friend WithEvents T_PID As ComboBox
    Friend WithEvents SearchBox_Click As Button
    Friend WithEvents Delete_Click As Button
    Friend WithEvents Update_Click As Button
    Friend WithEvents Clear_Click As Button
    Friend WithEvents T_SUBCODE As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Search_Box As TextBox
    Friend WithEvents T_SCID As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents T_DATE As TextBox
    Friend WithEvents T_ID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
