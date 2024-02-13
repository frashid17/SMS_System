Imports System.IO

Public Class changepass

    Public Class ProfileForm
        ' Define a global variable to store the username
        Private loggedInUsername As String


    End Class

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtNewPassword.PasswordChar = ControlChars.NullChar
            confirmpassword.PasswordChar = ControlChars.NullChar
        Else
            txtNewPassword.PasswordChar = "*"c
            confirmpassword.PasswordChar = "*"c
        End If
    End Sub
End Class