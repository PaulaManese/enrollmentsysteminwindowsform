Imports System.Data.SqlClient

Public Class Form6
    Dim conn As New SqlConnection("Data Source=DESKTOP-RD1U9LO\SQLEXPRESS; Initial Catalog=Enrollment System; Integrated Security = True")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cmdfour As New SqlCommand("SELECT * FROM School", conn)
        Dim adapter As New SqlDataAdapter(cmdfour)
        Dim table As New DataTable
        adapter.Fill(table)
        DataGridView1.DataSource = table


    End Sub

    Public Sub ExecuteQuery(ByVal query As String)
        Dim cmd As New SqlCommand(query, conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

    Private Sub Add_Rec_Click_Click(sender As Object, e As EventArgs) Handles Add_Rec_Click.Click
        If String.IsNullOrEmpty(Sc_ID.Text) Or String.IsNullOrEmpty(Sc_Name.Text) Or String.IsNullOrEmpty(Sc_SchoolYear.Text) Or String.IsNullOrEmpty(Sc_Strand.Text) Or String.IsNullOrEmpty(Sc_Track.Text) Or String.IsNullOrEmpty(Sc_GradeLevel.Text) Or String.IsNullOrEmpty(Sc_Section.Text) Or String.IsNullOrEmpty(Sc_Semester.Text) Then
            MessageBox.Show("Incomplete Details", "INCOMPLETE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim Insertquery As String = "INSERT INTO School (Sc_ID, Sc_Name, Sc_SchoolYear, Sc_Strand, Sc_Track, Sc_GradeLevel, Sc_Section, Sc_Semester) values ('" & Sc_ID.Text & "', '" & Sc_Name.Text & "','" & Sc_SchoolYear.Text & "', '" & Sc_Strand.Text & "', '" & Sc_Track.Text & "', '" & Sc_GradeLevel.Text & "', '" & Sc_Section.Text & "', '" & Sc_GradeLevel.Text & "')"
            ExecuteQuery(Insertquery)
            MessageBox.Show("Record Added Successfully", "INSERT", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Sc_ID.Clear()
            Sc_Name.Clear()
            Sc_SchoolYear.Clear()
            Sc_Strand.Clear()
            Sc_Track.Clear()
            Sc_GradeLevel.Clear()
            Sc_Section.Clear()
            Sc_Semester.Clear()
        End If
    End Sub

    Private Sub Search_Box_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Search_Box.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SearchBox_Click_Click(sender As Object, e As EventArgs) Handles SearchBox_Click.Click
        Dim cmd As New SqlCommand("SELECT * from School WHERE Sc_ID='" & Search_Box.Text & "'", conn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        If dt.Rows.Count = 1 Then
            Sc_ID.Text = dt.Rows(0)(0).ToString()
            Sc_Name.Text = dt.Rows(0)(1).ToString()
            Sc_SchoolYear.Text = dt.Rows(0)(2).ToString()
            Sc_Strand.Text = dt.Rows(0)(3).ToString()
            Sc_Track.Text = dt.Rows(0)(4).ToString()
            Sc_GradeLevel.Text = dt.Rows(0)(5).ToString()
            Sc_Section.Text = dt.Rows(0)(6).ToString()
            Sc_Section.Text = dt.Rows(0)(6).ToString()
            Sc_Semester.Text = dt.Rows(0)(7).ToString()
            Add_Rec_Click.Enabled = False

        Else
            MessageBox.Show("No Record Found", "No Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub



    Private Sub Delete_Click_Click(sender As Object, e As EventArgs) Handles Delete_Click.Click
        Dim deletequery As String = "DELETE FROM School WHERE Sc_ID = '" & Sc_ID.Text & "' "
        ExecuteQuery(deletequery)
        MessageBox.Show("Record was successfully deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Sc_ID.Clear()
        Sc_Name.Clear()
        Sc_SchoolYear.Clear()
        Sc_Strand.Clear()
        Sc_Track.Clear()
        Sc_GradeLevel.Clear()
        Sc_Section.Clear()
        Sc_Semester.Clear()
    End Sub

    Private Sub Clear_Click_Click(sender As Object, e As EventArgs) Handles Clear_Click.Click
        Sc_ID.Clear()
        Sc_Name.Clear()
        Sc_SchoolYear.Clear()
        Sc_Strand.Clear()
        Sc_Track.Clear()
        Sc_GradeLevel.Clear()
        Sc_Section.Clear()
        Sc_Semester.Clear()
        Add_Rec_Click.Enabled = True
    End Sub

    Private Sub Update_Click_Click(sender As Object, e As EventArgs) Handles Update_Click.Click
        If String.IsNullOrEmpty(Sc_ID.Text) Or String.IsNullOrEmpty(Sc_Name.Text) Or String.IsNullOrEmpty(Sc_SchoolYear.Text) Or String.IsNullOrEmpty(Sc_Strand.Text) Or String.IsNullOrEmpty(Sc_Track.Text) Or String.IsNullOrEmpty(Sc_GradeLevel.Text) Or String.IsNullOrEmpty(Sc_Section.Text) Or String.IsNullOrEmpty(Sc_Semester.Text) Then
            MessageBox.Show("Incomplete Details", "INCOMPLETE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim updatequery As String = "UPDATE School SET Sc_Name = '" & Sc_Name.Text & "',Sc_SchoolYear='" & Sc_SchoolYear.Text & "',Sc_Strand='" & Sc_Strand.Text & "',Sc_Track='" & Sc_Track.Text & "',Sc_GradeLevel='" & Sc_GradeLevel.Text & "',Sc_Section='" & Sc_Section.Text & "',Sc_Semester='" & Sc_Semester.Text & "' WHERE Sc_ID='" & Sc_ID.Text & "'"
            ExecuteQuery(updatequery)
            MessageBox.Show("Record Successfully Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Sc_ID.Clear()
            Sc_Name.Clear()
            Sc_SchoolYear.Clear()
            Sc_Strand.Clear()
            Sc_Track.Clear()
            Sc_GradeLevel.Clear()
            Sc_Section.Clear()
            Sc_Semester.Clear()
        End If
    End Sub

    Private Sub Main_Menu_Click(sender As Object, e As EventArgs) Handles Main_Menu.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class