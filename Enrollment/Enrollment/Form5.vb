Imports System.Data.SqlClient

Public Class Form5
    Dim conn As New SqlConnection("Data Source=DESKTOP-RD1U9LO\SQLEXPRESS; Initial Catalog=Enrollment System; Integrated Security = True")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cmdfour As New SqlCommand("SELECT * FROM Personnel", conn)
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
        If String.IsNullOrEmpty(P_ID.Text) Or String.IsNullOrEmpty(P_LName.Text) Or String.IsNullOrEmpty(P_FName.Text) Or String.IsNullOrEmpty(P_MI.Text) Or String.IsNullOrEmpty(P_BDate.Text) Or String.IsNullOrEmpty(P_Position.Text) Then
            MessageBox.Show("Incomplete Details", "INCOMPLETE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim Insertquery As String = "INSERT INTO Personnel (P_ID,P_LName,P_FName,P_MI,P_BDate,P_Position) values ('" & P_ID.Text & "', '" & P_LName.Text & "','" & P_FName.Text & "', '" & P_MI.Text & "', '" & P_BDate.Text & "', '" & P_Position.Text & "')"
            ExecuteQuery(Insertquery)
            MessageBox.Show("Record Added Successfully", "INSERT", MessageBoxButtons.OK, MessageBoxIcon.Information)
            P_ID.Clear()
            P_LName.Clear()
            P_FName.Clear()
            P_MI.Clear()
            P_BDate.Clear()
            P_Position.Clear()
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
        Dim cmd As New SqlCommand("SELECT * from Personnel WHERE P_ID='" & Search_Box.Text & "'", conn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        If dt.Rows.Count = 1 Then
            P_ID.Text = dt.Rows(0)(0).ToString()
            P_LName.Text = dt.Rows(0)(1).ToString()
            P_FName.Text = dt.Rows(0)(2).ToString()
            P_MI.Text = dt.Rows(0)(3).ToString()
            P_BDate.Text = dt.Rows(0)(4).ToString()
            P_Position.Text = dt.Rows(0)(5).ToString()
            Add_Rec_Click.Enabled = False

        Else
            MessageBox.Show("No Record Found", "No Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

    Private Sub Update_Click_Click(sender As Object, e As EventArgs) Handles Update_Click.Click
        If String.IsNullOrEmpty(P_ID.Text) Or String.IsNullOrEmpty(P_LName.Text) Or String.IsNullOrEmpty(P_FName.Text) Or String.IsNullOrEmpty(P_MI.Text) Or String.IsNullOrEmpty(P_BDate.Text) Or String.IsNullOrEmpty(P_Position.Text) Then
            MessageBox.Show("Incomplete Details", "INCOMPLETE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim updatequery As String = "UPDATE Personnel SET P_LName = '" & P_LName.Text & "',P_FName='" & P_FName.Text & "',P_MI='" & P_MI.Text & "',P_BDate='" & P_BDate.Text & "',P_Position='" & P_Position.Text & " ' WHERE P_ID='" & P_ID.Text & "'"
            ExecuteQuery(updatequery)
            MessageBox.Show("Record Successfully Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            P_ID.Clear()
            P_LName.Clear()
            P_FName.Clear()
            P_MI.Clear()
            P_BDate.Clear()
            P_Position.Clear()
        End If
    End Sub

    Private Sub Delete_Click_Click(sender As Object, e As EventArgs) Handles Delete_Click.Click
        Dim deletequery As String = "DELETE FROM Personnel WHERE P_ID = '" & P_ID.Text & "' "
        ExecuteQuery(deletequery)
        MessageBox.Show("Record was successfully deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        P_ID.Clear()
        P_LName.Clear()
        P_FName.Clear()
        P_MI.Clear()
        P_BDate.Clear()
        P_Position.Clear()
    End Sub

    Private Sub Clear_Click_Click(sender As Object, e As EventArgs) Handles Clear_Click.Click
        P_ID.Clear()
        P_LName.Clear()
        P_FName.Clear()
        P_MI.Clear()
        P_BDate.Clear()
        P_Position.Clear()
    End Sub

    Private Sub Main_Menu_Click(sender As Object, e As EventArgs) Handles Main_Menu.Click
        Me.Hide()
        Form1.Show()
    End Sub


End Class