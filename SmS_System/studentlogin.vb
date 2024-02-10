Imports System.IO

Public Class studentlogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtLoginUsername.Text.Trim()
        Dim password As String = txtLoginPassword.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if the entered credentials match any saved credentials
        Dim filePath As String = "user_credentials.txt"
        Dim found As Boolean = False
        Using reader As New StreamReader(filePath)
            Dim line As String
            While Not reader.EndOfStream
                line = reader.ReadLine()
                Dim parts() As String = line.Split(",")
                If parts.Length = 2 AndAlso parts(0) = username AndAlso parts(1) = password Then
                    found = True
                    Exit While
                End If
            End While
        End Using

        If found Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Clear input fields
        txtLoginUsername.Clear()
        txtLoginPassword.Clear()


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click


        Form1.Show()

        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label1.Visible = True Then
            Label1.Visible = False
        Else
            Label1.Visible = True
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Form2.Show()

        Me.Close()
    End Sub
End Class
