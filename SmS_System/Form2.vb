Imports System.IO

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
        Dim filepath As String = "users.txt"
        Dim userInformation As String = $"{txtUsername.Text},{txtFullname.Text},{txtPassword.Text},{ComboBox1.SelectedItem}"
        Using writer As New StreamWriter(filepath, True)
            writer.WriteLine(userInformation)
        End Using

        MessageBox.Show("Sign up successful!")
        ' Clear input fields
        txtUsername.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()

        studentlogin.Show()
    End Sub
End Class