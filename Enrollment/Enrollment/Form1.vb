Public Class Form1
    Private Sub Subject_Button_Click(sender As Object, e As EventArgs) Handles Subject_Button.Click
        Form2.Show()

    End Sub

    Private Sub Student_Button_Click(sender As Object, e As EventArgs) Handles Student_Button.Click
        Form3.Show()

    End Sub

    Private Sub Personnel_Button_Click(sender As Object, e As EventArgs) Handles Personnel_Button.Click
        Form5.Show()

    End Sub

    Private Sub School_Button_Click(sender As Object, e As EventArgs) Handles School_Button.Click
        Form6.Show()

    End Sub

    Private Sub Transaction_Button_Click(sender As Object, e As EventArgs) Handles Transaction_Button.Click
        Form4.Show()
    End Sub

End Class
