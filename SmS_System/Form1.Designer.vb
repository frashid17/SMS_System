<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStaff
        '
        Me.btnStaff.BackgroundImage = CType(resources.GetObject("btnStaff.BackgroundImage"), System.Drawing.Image)
        Me.btnStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnStaff.ForeColor = System.Drawing.Color.Yellow
        Me.btnStaff.Location = New System.Drawing.Point(12, 31)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(185, 122)
        Me.btnStaff.TabIndex = 0
        Me.btnStaff.Text = "Staff Portal"
        Me.btnStaff.UseVisualStyleBackColor = True
        '
        'btnStudent
        '
        Me.btnStudent.BackColor = System.Drawing.Color.Transparent
        Me.btnStudent.BackgroundImage = CType(resources.GetObject("btnStudent.BackgroundImage"), System.Drawing.Image)
        Me.btnStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStudent.Font = New System.Drawing.Font("Marlett", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudent.ForeColor = System.Drawing.Color.Red
        Me.btnStudent.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnStudent.Location = New System.Drawing.Point(541, 26)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(256, 112)
        Me.btnStudent.TabIndex = 1
        Me.btnStudent.Text = "Student Portal"
        Me.btnStudent.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "STAFF PORTAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(638, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "STUDENT PORTAL"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnClose.Location = New System.Drawing.Point(641, 404)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(125, 34)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "EXIT"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnStudent)
        Me.Controls.Add(Me.btnStaff)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStaff As Button
    Friend WithEvents btnStudent As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClose As Button
End Class
