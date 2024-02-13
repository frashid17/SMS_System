<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProfileForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.btnUpdateDetails = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(132, 73)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(39, 13)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Label1"
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Location = New System.Drawing.Point(463, 79)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(39, 13)
        Me.lblCourse.TabIndex = 1
        Me.lblCourse.Text = "Label1"
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Location = New System.Drawing.Point(32, 211)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(103, 42)
        Me.btnChangePassword.TabIndex = 2
        Me.btnChangePassword.Text = "Change Password"
        Me.btnChangePassword.UseVisualStyleBackColor = True
        '
        'btnUpdateDetails
        '
        Me.btnUpdateDetails.Location = New System.Drawing.Point(450, 186)
        Me.btnUpdateDetails.Name = "btnUpdateDetails"
        Me.btnUpdateDetails.Size = New System.Drawing.Size(161, 66)
        Me.btnUpdateDetails.TabIndex = 3
        Me.btnUpdateDetails.Text = "update details"
        Me.btnUpdateDetails.UseVisualStyleBackColor = True
        '
        'ProfileForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnUpdateDetails)
        Me.Controls.Add(Me.btnChangePassword)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.lblUsername)
        Me.Name = "ProfileForm"
        Me.Text = "profileform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblCourse As Label
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents btnUpdateDetails As Button
End Class
