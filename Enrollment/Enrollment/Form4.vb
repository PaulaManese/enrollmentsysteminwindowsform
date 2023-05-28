Imports System.Data.SqlClient


Public Class Form4
    Dim conn As New SqlConnection("Data Source=DESKTOP-RD1U9LO\SQLEXPRESS; Initial Catalog=Enrollment System; Integrated Security = True")


    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load





        Dim cmd As New SqlCommand("SELECT * FROM Student", conn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        T_STLRN.DataSource = dt
        T_STLRN.DisplayMember = "St_LRN"
        T_STLRN.ValueMember = "St_LRN"



        Dim cmdone As New SqlCommand("SELECT * FROM Personnel", conn)
        Dim daone As New SqlDataAdapter(cmdone)
        Dim dtone As New DataTable
        daone.Fill(dtone)

        T_PID.DataSource = dtone
        T_PID.DisplayMember = "P_ID"
        T_PID.ValueMember = "P_ID"


        Dim cmdtwo As New SqlCommand("SELECT * FROM School", conn)
        Dim datwo As New SqlDataAdapter(cmdtwo)
        Dim dttwo As New DataTable
        datwo.Fill(dttwo)

        T_SCID.DataSource = dttwo
        T_SCID.DisplayMember = "Sc_ID"
        T_SCID.ValueMember = "Sc_ID"



        Dim cmdthree As New SqlCommand("SELECT * FROM Subject", conn)
        Dim dathree As New SqlDataAdapter(cmdthree)
        Dim dtthree As New DataTable
        dathree.Fill(dtthree)

        T_SUBCODE.DataSource = dtthree
        T_SUBCODE.DisplayMember = "Sub_ID"
        T_SUBCODE.ValueMember = "Sub_Code"


        Dim cmdfour As New SqlCommand("SELECT * FROM Transact", conn)
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
        If String.IsNullOrEmpty(T_ID.Text) Or String.IsNullOrEmpty(T_PID.Text) Or String.IsNullOrEmpty(T_SCID.Text) Or String.IsNullOrEmpty(T_SUBCODE.Text) Or String.IsNullOrEmpty(T_STLRN.Text) Or String.IsNullOrEmpty(T_DATE.Text) Then
            MessageBox.Show("Incomplete Details", "INCOMPLETE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim Insertquery As String = "INSERT INTO Transact (T_ID, T_PID, T_SCID, T_SUBCODE, T_STLRN, T_DATE) values ('" & T_ID.Text & "', '" & T_PID.Text & "', '" & T_SCID.Text & "', '" & T_SUBCODE.Text & "' , '" & T_STLRN.Text & "', '" & T_DATE.Text & "')"
            ExecuteQuery(Insertquery)
            MessageBox.Show("Successfully Enrolled", "INSERT", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        Dim cmd As New SqlCommand("SELECT * from Transact WHERE T_ID='" & Search_Box.Text & "'", conn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        If dt.Rows.Count = 1 Then
            T_ID.Text = dt.Rows(0)(0).ToString
            T_PID.Text = dt.Rows(0)(1).ToString
            T_SCID.Text = dt.Rows(0)(2).ToString
            T_SUBCODE.Text = dt.Rows(0)(3).ToString
            T_STLRN.Text = dt.Rows(0)(4).ToString
            T_DATE.Text = dt.Rows(0)(5).ToString
            Add_Rec_Click.Enabled = False

        Else
            MessageBox.Show("No Record Found", "No Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

    Private Sub Delete_Click_Click(sender As Object, e As EventArgs) Handles Delete_Click.Click
        Dim deletequery As String = "DELETE FROM Transact WHERE T_ID = '" & T_ID.Text & "' "
        ExecuteQuery(deletequery)
        MessageBox.Show("Record was successfully deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Update_Click_Click(sender As Object, e As EventArgs) Handles Update_Click.Click
        If String.IsNullOrEmpty(T_ID.Text) Or String.IsNullOrEmpty(T_DATE.Text) Then
            MessageBox.Show("Incomplete Details", "INCOMPLETE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim updatequery As String = "UPDATE Transact SET T_DATE = '" & T_DATE.Text & "' WHERE T_ID='" & T_ID.Text & "'"
            ExecuteQuery(updatequery)
            MessageBox.Show("Record Successfully Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Clear_Click_Click(sender As Object, e As EventArgs) Handles Clear_Click.Click
        T_ID.Clear()
        T_DATE.Clear()
        T_STLRN.Text = String.Empty
        T_PID.Text = String.Empty
        T_SCID.Text = String.Empty
        T_SUBCODE.Text = String.Empty
        T_STLRN.Text = String.Empty
        Add_Rec_Click.Enabled = True
    End Sub

    Private Sub Main_Menu_Click(sender As Object, e As EventArgs) Handles Main_Menu.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub T_STLRN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles T_STLRN.SelectedIndexChanged

    End Sub
End Class