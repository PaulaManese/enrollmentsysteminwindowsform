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
        Label1 = New Label()
        Student_Button = New Button()
        Personnel_Button = New Button()
        Subject_Button = New Button()
        School_Button = New Button()
        Transaction_Button = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 24.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.Highlight
        Label1.Location = New Point(431, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(358, 47)
        Label1.TabIndex = 0
        Label1.Text = "Enrollment System"
        ' 
        ' Student_Button
        ' 
        Student_Button.BackColor = SystemColors.MenuHighlight
        Student_Button.Font = New Font("Cambria", 24.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Student_Button.ForeColor = SystemColors.ButtonHighlight
        Student_Button.Location = New Point(28, 149)
        Student_Button.Name = "Student_Button"
        Student_Button.Size = New Size(238, 102)
        Student_Button.TabIndex = 1
        Student_Button.Text = "Student"
        Student_Button.UseVisualStyleBackColor = False
        ' 
        ' Personnel_Button
        ' 
        Personnel_Button.BackColor = SystemColors.MenuHighlight
        Personnel_Button.Font = New Font("Cambria", 24.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Personnel_Button.ForeColor = SystemColors.ButtonHighlight
        Personnel_Button.Location = New Point(334, 149)
        Personnel_Button.Name = "Personnel_Button"
        Personnel_Button.Size = New Size(247, 102)
        Personnel_Button.TabIndex = 2
        Personnel_Button.Text = "Personnel"
        Personnel_Button.UseVisualStyleBackColor = False
        ' 
        ' Subject_Button
        ' 
        Subject_Button.BackColor = SystemColors.MenuHighlight
        Subject_Button.Font = New Font("Cambria", 24.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Subject_Button.ForeColor = SystemColors.ButtonHighlight
        Subject_Button.Location = New Point(654, 149)
        Subject_Button.Name = "Subject_Button"
        Subject_Button.Size = New Size(223, 102)
        Subject_Button.TabIndex = 3
        Subject_Button.Text = "Subject"
        Subject_Button.UseVisualStyleBackColor = False
        ' 
        ' School_Button
        ' 
        School_Button.BackColor = SystemColors.MenuHighlight
        School_Button.Font = New Font("Cambria", 24.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        School_Button.ForeColor = SystemColors.ButtonHighlight
        School_Button.Location = New Point(936, 149)
        School_Button.Name = "School_Button"
        School_Button.Size = New Size(210, 102)
        School_Button.TabIndex = 4
        School_Button.Text = "School"
        School_Button.UseVisualStyleBackColor = False
        ' 
        ' Transaction_Button
        ' 
        Transaction_Button.BackColor = SystemColors.MenuHighlight
        Transaction_Button.Font = New Font("Cambria", 24.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Transaction_Button.ForeColor = SystemColors.ButtonHighlight
        Transaction_Button.Location = New Point(456, 343)
        Transaction_Button.Name = "Transaction_Button"
        Transaction_Button.Size = New Size(309, 81)
        Transaction_Button.TabIndex = 5
        Transaction_Button.Text = "Transaction"
        Transaction_Button.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1221, 454)
        Controls.Add(Transaction_Button)
        Controls.Add(School_Button)
        Controls.Add(Subject_Button)
        Controls.Add(Personnel_Button)
        Controls.Add(Student_Button)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Student_Button As Button
    Friend WithEvents Personnel_Button As Button
    Friend WithEvents Subject_Button As Button
    Friend WithEvents School_Button As Button
    Friend WithEvents Transaction_Button As Button
End Class
