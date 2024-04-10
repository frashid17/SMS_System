Imports System.IO

Public Class stafflogin
    Private Sub changePassChar_CheckedChanged(sender As Object, e As EventArgs) Handles changePassChar.CheckedChanged
        If changePassChar.Checked Then
            txtPassword.PasswordChar = ControlChars.NullChar
        Else
            txtPassword.PasswordChar = "*"c
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim filePath As String = Path.Combine(Application.StartupPath, "staffpass.txt")

        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim userFound As Boolean = False

        ' Check if the file exists before attempting to read from it
        If File.Exists(filePath) Then
            Using reader As New StreamReader(filePath)
                Dim line As String
                While Not reader.EndOfStream
                    line = reader.ReadLine()
                    Dim userInfo() As String = line.Split(","c)
                    If userInfo.Length >= 3 AndAlso userInfo(0) = username AndAlso userInfo(2) = password Then
                        ' User found, open profile form
                        Dim profileForm As New ProfileForm(userInfo(1), userInfo(3))
                        profileForm.Show()
                        userFound = True
                        Exit While
                    End If
                End While
            End Using
        Else
            MessageBox.Show("User database file does not exist. Please sign up first.")
        End If

        If Not userFound Then
            MessageBox.Show("Invalid username or password. Please try again.")
        End If

        ' Clear input fields
        txtUsername.Clear()
        txtPassword.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        staffreg.Show()
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class