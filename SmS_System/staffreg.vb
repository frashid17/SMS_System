Imports System.IO

Public Class staffreg
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles showpass.CheckedChanged
        If showpass.Checked Then
            txtPass.PasswordChar = ControlChars.NullChar
        Else
            txtPass.PasswordChar = "*"c
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filepath As String = "staffpass.txt"
        Dim userInformation As String = $"{txtUser.Text},{txtName.Text},{txtPass.Text},{ComboBox1.SelectedItem}"
        Using writer As New StreamWriter(filepath, True)
            writer.WriteLine(userInformation)
        End Using

        MessageBox.Show("Sign up successful!")
        ' Clear input fields
        txtUser.Clear()
        txtPass.Clear()
        txtPass2.Clear()
        txtEmail.Clear()

        stafflogin.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        stafflogin.Show()
        Me.Close()
    End Sub
End Class