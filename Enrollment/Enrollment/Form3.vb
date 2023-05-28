Imports System.Data.SqlClient


Public Class Form3
    Dim conn As New SqlConnection("Data Source=DESKTOP-RD1U9LO\SQLEXPRESS; Initial Catalog=Enrollment System; Integrated Security = True")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand("SELECT * FROM Student", conn)
        Dim adapter As New SqlDataAdapter(cmd)
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
        If String.IsNullOrEmpty(St_LRN.Text) Or String.IsNullOrEmpty(St_LName.Text) Or String.IsNullOrEmpty(St_FName.Text) Or String.IsNullOrEmpty(St_MI.Text) Or String.IsNullOrEmpty(St_Strand.Text) Or String.IsNullOrEmpty(St_Track.Text) Or String.IsNullOrEmpty(St_GradeLevel.Text) Or String.IsNullOrEmpty(St_Section.Text) Or String.IsNullOrEmpty(St_SchoolYear.Text) Or String.IsNullOrEmpty(St_Semester.Text) Then
            MessageBox.Show("Incomplete Details", "INCOMPLETE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim Insertquery As String = "INSERT INTO Student (St_LRN,St_LName,St_FName,St_MI,St_Strand,St_Track,St_GradeLevel,St_Section,St_SchoolYear,St_Semester) values ('" & St_LRN.Text & "', '" & St_LName.Text & "','" & St_FName.Text & "', '" & St_MI.Text & "','" & St_Strand.Text & "', '" & St_Track.Text & "', '" & St_GradeLevel.Text & "', '" & St_Section.Text & "', '" & St_SchoolYear.Text & "', '" & St_Semester.Text & "')"
            ExecuteQuery(Insertquery)
            MessageBox.Show("Record Added Successfully", "INSERT", MessageBoxButtons.OK, MessageBoxIcon.Information)
            St_LRN.Clear()
            St_LName.Clear()
            St_FName.Clear()
            St_MI.Clear()
            St_Strand.Clear()
            St_Track.Clear()
            St_GradeLevel.Clear()
            St_Section.Clear()
            St_SchoolYear.Clear()
            St_Semester.Clear()
        End If
    End Sub


    Private Sub SearchBox_Click_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SearchBox_Click.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SearchBox_Click_Click(sender As Object, e As EventArgs) Handles SearchBox_Click.Click
        Dim cmd As New SqlCommand("SELECT * from Student WHERE St_LRN='" & Search_Box.Text & "'", conn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        If dt.Rows.Count = 1 Then
            St_LRN.Text = dt.Rows(0)(0).ToString()
            St_LName.Text = dt.Rows(0)(1).ToString()
            St_FName.Text = dt.Rows(0)(2).ToString()
            St_MI.Text = dt.Rows(0)(3).ToString()
            St_Strand.Text = dt.Rows(0)(4).ToString()
            St_Track.Text = dt.Rows(0)(5).ToString()
            St_GradeLevel.Text = dt.Rows(0)(6).ToString()
            St_Section.Text = dt.Rows(0)(7).ToString()
            St_SchoolYear.Text = dt.Rows(0)(8).ToString()
            St_Semester.Text = dt.Rows(0)(9).ToString()
            Add_Rec_Click.Enabled = False

        Else
            MessageBox.Show("No Record Found", "No Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

    End Sub

    Private Sub Update_Click_Click(sender As Object, e As EventArgs) Handles Update_Click.Click
        If String.IsNullOrEmpty(St_LRN.Text) Or String.IsNullOrEmpty(St_LName.Text) Or String.IsNullOrEmpty(St_FName.Text) Or String.IsNullOrEmpty(St_MI.Text) Or String.IsNullOrEmpty(St_Strand.Text) Or String.IsNullOrEmpty(St_Track.Text) Or String.IsNullOrEmpty(St_GradeLevel.Text) Or String.IsNullOrEmpty(St_Section.Text) Or String.IsNullOrEmpty(St_SchoolYear.Text) Or String.IsNullOrEmpty(St_Semester.Text) Then
            MessageBox.Show("Incomplete Details", "INCOMPLETE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim updatequery As String = "UPDATE Student SET St_LName = '" & St_LName.Text & "',St_FName='" & St_FName.Text & "',St_MI='" & St_MI.Text & "',St_Strand='" & St_Strand.Text & "',St_Track='" & St_Track.Text & "',St_GradeLevel='" & St_GradeLevel.Text & "',St_Section='" & St_Section.Text & "',St_SchoolYear='" & St_SchoolYear.Text & "',St_Semester='" & St_Semester.Text & "' WHERE St_LRN='" & St_LRN.Text & "'"
            ExecuteQuery(updatequery)
            MessageBox.Show("Record Successfully Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            St_LRN.Clear()
            St_LName.Clear()
            St_FName.Clear()
            St_MI.Clear()
            St_Strand.Clear()
            St_Track.Clear()
            St_GradeLevel.Clear()
            St_Section.Clear()
            St_SchoolYear.Clear()
            St_Semester.Clear()
        End If
    End Sub

    Private Sub Delete_Click_Click(sender As Object, e As EventArgs) Handles Delete_Click.Click
        Dim deletequery As String = "DELETE FROM Student WHERE St_LRN = '" & St_LRN.Text & "' "
        ExecuteQuery(deletequery)
        MessageBox.Show("Record was successfully deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        St_LRN.Clear()
        St_LName.Clear()
        St_FName.Clear()
        St_MI.Clear()
        St_Strand.Clear()
        St_Track.Clear()
        St_GradeLevel.Clear()
        St_Section.Clear()
        St_SchoolYear.Clear()
        St_Semester.Clear()
    End Sub

    Private Sub Clear_Click_Click(sender As Object, e As EventArgs) Handles Clear_Click.Click
        St_LRN.Clear()
        St_LName.Clear()
        St_FName.Clear()
        St_MI.Clear()
        St_Strand.Clear()
        St_Track.Clear()
        St_GradeLevel.Clear()
        St_Section.Clear()
        St_SchoolYear.Clear()
        St_Semester.Clear()
        Add_Rec_Click.Enabled = True
    End Sub

    Private Sub Main_Menu_Click(sender As Object, e As EventArgs) Handles Main_Menu.Click
        Me.Hide()
        Form1.Show()
    End Sub


End Class