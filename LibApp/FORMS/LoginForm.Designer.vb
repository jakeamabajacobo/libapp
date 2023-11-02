<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.username_txtbox = New System.Windows.Forms.TextBox()
        Me.password_txtbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.login_btn = New System.Windows.Forms.Button()
        Me.cancel_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'username_txtbox
        '
        Me.username_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.username_txtbox.Location = New System.Drawing.Point(179, 83)
        Me.username_txtbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.username_txtbox.Name = "username_txtbox"
        Me.username_txtbox.Size = New System.Drawing.Size(419, 26)
        Me.username_txtbox.TabIndex = 0
        '
        'password_txtbox
        '
        Me.password_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.password_txtbox.Location = New System.Drawing.Point(179, 146)
        Me.password_txtbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.password_txtbox.Name = "password_txtbox"
        Me.password_txtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_txtbox.Size = New System.Drawing.Size(419, 26)
        Me.password_txtbox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        '
        'login_btn
        '
        Me.login_btn.Location = New System.Drawing.Point(247, 223)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(105, 46)
        Me.login_btn.TabIndex = 4
        Me.login_btn.Text = "Login"
        Me.login_btn.UseVisualStyleBackColor = True
        '
        'cancel_btn
        '
        Me.cancel_btn.Location = New System.Drawing.Point(389, 223)
        Me.cancel_btn.Name = "cancel_btn"
        Me.cancel_btn.Size = New System.Drawing.Size(105, 46)
        Me.cancel_btn.TabIndex = 5
        Me.cancel_btn.Tag = "k"
        Me.cancel_btn.Text = "Cancel"
        Me.cancel_btn.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 310)
        Me.ControlBox = False
        Me.Controls.Add(Me.cancel_btn)
        Me.Controls.Add(Me.login_btn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.password_txtbox)
        Me.Controls.Add(Me.username_txtbox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents username_txtbox As TextBox
    Friend WithEvents password_txtbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents login_btn As Button
    Friend WithEvents cancel_btn As Button
End Class
