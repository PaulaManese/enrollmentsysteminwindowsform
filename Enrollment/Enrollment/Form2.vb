Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Dim conn As New SqlConnection("Data Source=DESKTOP-RD1U9LO\SQLEXPRESS; Initial Catalog=Enrollment System; Integrated Security = True")
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand("SELECT * FROM Subject", conn)
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
        If String.IsNullOrEmpty(Sub_Code.Text) Or String.IsNullOrEmpty(Sub_Title.Text) Or String.IsNullOrEmpty(Sub_Type.Text) Or String.IsNullOrEmpty(Sub_Strand.Text) Or String.IsNullOrEmpty(Sub_Track.Text) Then
            MessageBox.Show("Incomplete Details", "INCOMPLETE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim Insertquery As String = "INSERT INTO Subject (Sub_Code,Sub_Title,Sub_Type,Sub_Strand,Sub_Track) values ('" & Sub_Code.Text & "', '" & Sub_Title.Text & "','" & Sub_Type.Text & "', '" & Sub_Strand.Text & "', '" & Sub_Track.Text & "' )"
            ExecuteQuery(Insertquery)
            MessageBox.Show("Record Added Successfully", "INSERT", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Sub_Code.Clear()
            Sub_Title.Clear()
            Sub_Type.Clear()
            Sub_Strand.Clear()
            Sub_Track.Clear()
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
        Dim cmd As New SqlCommand("SELECT * from Subject WHERE Sub_Code='" & Search_Box.Text & "'", conn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        If dt.Rows.Count = 1 Then
            Sub_Code.Text = dt.Rows(0)(0).ToString
            Sub_Title.Text = dt.Rows(0)(1).ToString
            Sub_Type.Text = dt.Rows(0)(2).ToString
            Sub_Strand.Text = dt.Rows(0)(3).ToString
            Sub_Track.Text = dt.Rows(0)(4).ToString
            Add_Rec_Click.Enabled = False

        Else
            MessageBox.Show("No Record Found", "No Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

    Private Sub Update_Click_Click(sender As Object, e As EventArgs) Handles Update_Click.Click
        If String.IsNullOrEmpty(Sub_Code.Text) Or String.IsNullOrEmpty(Sub_Title.Text) Or String.IsNullOrEmpty(Sub_Type.Text) Or String.IsNullOrEmpty(Sub_Strand.Text) Or String.IsNullOrEmpty(Sub_Track.Text) Then
            MessageBox.Show("Incomplete Details", "INCOMPLETE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim updatequery As String = "UPDATE Subject SET Sub_Title = '" & Sub_Title.Text & "',Sub_Type='" & Sub_Type.Text & "',Sub_Strand='" & Sub_Strand.Text & "',Sub_Track='" & Sub_Track.Text & "' WHERE Sub_Code='" & Sub_Code.Text & "'"
            ExecuteQuery(updatequery)
            MessageBox.Show("Record Successfully Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Sub_Code.Clear()
            Sub_Title.Clear()
            Sub_Type.Clear()
            Sub_Strand.Clear()
            Sub_Track.Clear()
        End If
    End Sub

    Private Sub Delete_Click_Click(sender As Object, e As EventArgs) Handles Delete_Click.Click
        Dim deletequery As String = "DELETE FROM Subject WHERE Sub_Code = '" & Sub_Code.Text & "' "
        ExecuteQuery(deletequery)
        MessageBox.Show("Record was successfully deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Sub_Code.Clear()
        Sub_Title.Clear()
        Sub_Type.Clear()
        Sub_Strand.Clear()
        Sub_Track.Clear()
    End Sub

    Private Sub Clear_Click_Click(sender As Object, e As EventArgs) Handles Clear_Click.Click
        Sub_Code.Clear()
        Sub_Title.Clear()
        Sub_Type.Clear()
        Sub_Strand.Clear()
        Sub_Track.Clear()
        Add_Rec_Click.Enabled = True
    End Sub

    Private Sub Main_Menu_Click(sender As Object, e As EventArgs) Handles Main_Menu.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class