Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form1
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()

    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs)
        studentlogin.Show()

        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs)
        stafflogin.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = -1 Then
            MessageBox.Show("Please select an item from the ComboBox before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ComboBox1.Focus()
        Else
            If ComboBox1.SelectedItem IsNot Nothing Then
                Dim selectedItem As String = ComboBox1.SelectedItem.ToString()
                If selectedItem = "STAFF" Then
                    Dim staffPortalForm As New stafflogin()
                    staffPortalForm.Show()
                    Me.Close()
                ElseIf selectedItem = "STUDENTS" Then
                    Dim studentPortalForm As New studentlogin()
                    studentPortalForm.Show()
                    Me.Close()
                End If
            End If
        End If

    End Sub
End Class