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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Sub_Code = New TextBox()
        Sub_Title = New TextBox()
        Sub_Type = New TextBox()
        Sub_Strand = New TextBox()
        Sub_Track = New TextBox()
        Search_Box = New TextBox()
        Update_Click = New Button()
        SearchBox_Click = New Button()
        Clear_Click = New Button()
        Delete_Click = New Button()
        Add_Rec_Click = New Button()
        Main_Menu = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 22.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.Highlight
        Label1.Location = New Point(518, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(236, 43)
        Label1.TabIndex = 0
        Label1.Text = "Subject Form"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cambria", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.MenuHighlight
        Label2.Location = New Point(102, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(186, 36)
        Label2.TabIndex = 1
        Label2.Text = "Subject Code"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cambria", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.MenuHighlight
        Label3.Location = New Point(102, 170)
        Label3.Name = "Label3"
        Label3.Size = New Size(183, 36)
        Label3.TabIndex = 1
        Label3.Text = "Subject Title"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cambria", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.MenuHighlight
        Label4.Location = New Point(102, 229)
        Label4.Name = "Label4"
        Label4.Size = New Size(186, 36)
        Label4.TabIndex = 2
        Label4.Text = "Subject Type"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Cambria", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.MenuHighlight
        Label5.Location = New Point(102, 283)
        Label5.Name = "Label5"
        Label5.Size = New Size(107, 36)
        Label5.TabIndex = 3
        Label5.Text = "Strand"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Cambria", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.MenuHighlight
        Label6.Location = New Point(102, 334)
        Label6.Name = "Label6"
        Label6.Size = New Size(93, 36)
        Label6.TabIndex = 4
        Label6.Text = "Track"
        ' 
        ' Sub_Code
        ' 
        Sub_Code.BackColor = Color.Cornsilk
        Sub_Code.Font = New Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Sub_Code.ForeColor = SystemColors.HotTrack
        Sub_Code.Location = New Point(308, 115)
        Sub_Code.Name = "Sub_Code"
        Sub_Code.Size = New Size(256, 31)
        Sub_Code.TabIndex = 5
        ' 
        ' Sub_Title
        ' 
        Sub_Title.BackColor = Color.Cornsilk
        Sub_Title.Font = New Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Sub_Title.ForeColor = SystemColors.HotTrack
        Sub_Title.Location = New Point(308, 166)
        Sub_Title.Name = "Sub_Title"
        Sub_Title.Size = New Size(256, 31)
        Sub_Title.TabIndex = 6
        ' 
        ' Sub_Type
        ' 
        Sub_Type.BackColor = Color.Cornsilk
        Sub_Type.Font = New Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Sub_Type.ForeColor = SystemColors.HotTrack
        Sub_Type.Location = New Point(308, 225)
        Sub_Type.Name = "Sub_Type"
        Sub_Type.Size = New Size(256, 31)
        Sub_Type.TabIndex = 7
        ' 
        ' Sub_Strand
        ' 
        Sub_Strand.BackColor = Color.Cornsilk
        Sub_Strand.Font = New Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Sub_Strand.ForeColor = SystemColors.HotTrack
        Sub_Strand.Location = New Point(308, 279)
        Sub_Strand.Name = "Sub_Strand"
        Sub_Strand.Size = New Size(256, 31)
        Sub_Strand.TabIndex = 8
        ' 
        ' Sub_Track
        ' 
        Sub_Track.BackColor = Color.Cornsilk
        Sub_Track.Font = New Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Sub_Track.ForeColor = SystemColors.HotTrack
        Sub_Track.Location = New Point(308, 334)
        Sub_Track.Name = "Sub_Track"
        Sub_Track.Size = New Size(256, 31)
        Sub_Track.TabIndex = 9
        ' 
        ' Search_Box
        ' 
        Search_Box.BackColor = Color.Cornsilk
        Search_Box.Font = New Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Search_Box.ForeColor = SystemColors.HotTrack
        Search_Box.Location = New Point(613, 310)
        Search_Box.Name = "Search_Box"
        Search_Box.Size = New Size(256, 31)
        Search_Box.TabIndex = 10
        ' 
        ' Update_Click
        ' 
        Update_Click.BackColor = SystemColors.Highlight
        Update_Click.Font = New Font("Cambria", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Update_Click.ForeColor = SystemColors.ButtonHighlight
        Update_Click.Location = New Point(642, 669)
        Update_Click.Name = "Update_Click"
        Update_Click.Size = New Size(212, 74)
        Update_Click.TabIndex = 11
        Update_Click.Text = "Update"
        Update_Click.UseVisualStyleBackColor = False
        ' 
        ' SearchBox_Click
        ' 
        SearchBox_Click.BackColor = SystemColors.Highlight
        SearchBox_Click.Font = New Font("Cambria", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        SearchBox_Click.ForeColor = SystemColors.ButtonHighlight
        SearchBox_Click.Location = New Point(642, 377)
        SearchBox_Click.Name = "SearchBox_Click"
        SearchBox_Click.Size = New Size(212, 74)
        SearchBox_Click.TabIndex = 12
        SearchBox_Click.Text = "Search"
        SearchBox_Click.UseVisualStyleBackColor = False
        ' 
        ' Clear_Click
        ' 
        Clear_Click.BackColor = SystemColors.Highlight
        Clear_Click.Font = New Font("Cambria", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Clear_Click.ForeColor = SystemColors.ButtonHighlight
        Clear_Click.Location = New Point(642, 478)
        Clear_Click.Name = "Clear_Click"
        Clear_Click.Size = New Size(212, 74)
        Clear_Click.TabIndex = 14
        Clear_Click.Text = "Clear"
        Clear_Click.UseVisualStyleBackColor = False
        ' 
        ' Delete_Click
        ' 
        Delete_Click.BackColor = SystemColors.Highlight
        Delete_Click.Font = New Font("Cambria", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Delete_Click.ForeColor = SystemColors.ButtonHighlight
        Delete_Click.Location = New Point(642, 767)
        Delete_Click.Name = "Delete_Click"
        Delete_Click.Size = New Size(212, 74)
        Delete_Click.TabIndex = 13
        Delete_Click.Text = "Delete"
        Delete_Click.UseVisualStyleBackColor = False
        ' 
        ' Add_Rec_Click
        ' 
        Add_Rec_Click.BackColor = SystemColors.Highlight
        Add_Rec_Click.Font = New Font("Cambria", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Add_Rec_Click.ForeColor = SystemColors.ButtonHighlight
        Add_Rec_Click.Location = New Point(319, 426)
        Add_Rec_Click.Name = "Add_Rec_Click"
        Add_Rec_Click.Size = New Size(212, 74)
        Add_Rec_Click.TabIndex = 15
        Add_Rec_Click.Text = "Add Record"
        Add_Rec_Click.UseVisualStyleBackColor = False
        ' 
        ' Main_Menu
        ' 
        Main_Menu.BackColor = SystemColors.Highlight
        Main_Menu.Font = New Font("Cambria", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Main_Menu.ForeColor = SystemColors.ButtonHighlight
        Main_Menu.Location = New Point(238, 616)
        Main_Menu.Name = "Main_Menu"
        Main_Menu.Size = New Size(293, 74)
        Main_Menu.TabIndex = 16
        Main_Menu.Text = "Back to Main Menu"
        Main_Menu.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ActiveCaption
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(951, 87)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(480, 754)
        DataGridView1.TabIndex = 17
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1461, 867)
        Controls.Add(DataGridView1)
        Controls.Add(Main_Menu)
        Controls.Add(Add_Rec_Click)
        Controls.Add(Clear_Click)
        Controls.Add(Delete_Click)
        Controls.Add(SearchBox_Click)
        Controls.Add(Update_Click)
        Controls.Add(Search_Box)
        Controls.Add(Sub_Track)
        Controls.Add(Sub_Strand)
        Controls.Add(Sub_Type)
        Controls.Add(Sub_Title)
        Controls.Add(Sub_Code)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Sub_Code As TextBox
    Friend WithEvents Sub_Title As TextBox
    Friend WithEvents Sub_Type As TextBox
    Friend WithEvents Sub_Strand As TextBox
    Friend WithEvents Sub_Track As TextBox
    Friend WithEvents Search_Box As TextBox
    Friend WithEvents Update_Click As Button
    Friend WithEvents SearchBox_Click As Button
    Friend WithEvents Clear_Click As Button
    Friend WithEvents Delete_Click As Button
    Friend WithEvents Add_Rec_Click As Button
    Friend WithEvents Main_Menu As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
