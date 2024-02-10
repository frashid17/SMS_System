Public Class Form2
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label5.Visible = True Then
            Label5.Visible = False
        Else
            Label5.Visible = True
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        studentlogin.Show()
        Me.Close()

    End Sub

    Private Sub DASHBOARDToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim confirmPassword As String = txtConfirmPassword.Text.Trim()

        If username = "" Or password = "" Or confirmPassword = "" Then
            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If password <> confirmPassword Then
            MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Save username and password to a text file
        Dim filePath As String = "user_credentials.txt"
        Using writer As New IO.StreamWriter(filePath, True)
            writer.WriteLine(username & "," & password)
        End Using

        MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Clear input fields
        txtUsername.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()

        studentlogin.Show()
    End Sub
End Class