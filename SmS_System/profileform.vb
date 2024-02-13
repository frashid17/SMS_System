Public Class ProfileForm
    Private userName As String
    Private course As String

    Public Sub New(userName As String, course As String)
        InitializeComponent()
        Me.userName = userName
        Me.course = course
    End Sub

    Private Sub ProfileForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text = "Username: " & userName
        lblCourse.Text = "Course: " & course
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        ' Add code to change password
    End Sub

    Private Sub btnChangePassword_Click_1(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Dim changePasswordForm As New changepass()
        changePasswordForm.ShowDialog()
    End Sub
End Class
