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
        ' Construct the file path relative to the application's startup path
        Dim filePath As String = Path.Combine(Application.StartupPath, "users.txt")

        Dim username As String = txtLoginUsername.Text
        Dim password As String = txtLoginPassword.Text
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

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtLoginUsername_TextChanged(sender As Object, e As EventArgs) Handles txtLoginUsername.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub studentlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked Then
            txtLoginPassword.PasswordChar = ControlChars.NullChar
        Else
            txtLoginPassword.PasswordChar = "*"c
        End If

    End Sub
End Class
