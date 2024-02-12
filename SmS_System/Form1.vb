Public Class Form1
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs)
        studentlogin.Show()

        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs)
        stafflogin.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ComboBox1.SelectedItem.ToString() = "STAFF" Then
            ' Show the staff portal form
            Dim staffPortalForm As New stafflogin()
            staffPortalForm.Show()
        ElseIf ComboBox1.SelectedItem.ToString() = "STUDENTS" Then
            ' Show the student portal form
            Dim studentPortalForm As New studentlogin()
            studentPortalForm.Show()
        End If

    End Sub
End Class