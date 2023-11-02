<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.books_btn = New System.Windows.Forms.Button()
        Me.borrow_btn = New System.Windows.Forms.Button()
        Me.user_btn = New System.Windows.Forms.Button()
        Me.logout_btn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'books_btn
        '
        Me.books_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.books_btn.Location = New System.Drawing.Point(60, 178)
        Me.books_btn.Name = "books_btn"
        Me.books_btn.Size = New System.Drawing.Size(204, 133)
        Me.books_btn.TabIndex = 0
        Me.books_btn.Text = "Books"
        Me.books_btn.UseVisualStyleBackColor = True
        '
        'borrow_btn
        '
        Me.borrow_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.borrow_btn.Location = New System.Drawing.Point(302, 178)
        Me.borrow_btn.Name = "borrow_btn"
        Me.borrow_btn.Size = New System.Drawing.Size(204, 133)
        Me.borrow_btn.TabIndex = 1
        Me.borrow_btn.Text = "Borrow"
        Me.borrow_btn.UseVisualStyleBackColor = True
        '
        'user_btn
        '
        Me.user_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user_btn.Location = New System.Drawing.Point(546, 178)
        Me.user_btn.Name = "user_btn"
        Me.user_btn.Size = New System.Drawing.Size(204, 133)
        Me.user_btn.TabIndex = 2
        Me.user_btn.Text = "Users"
        Me.user_btn.UseVisualStyleBackColor = True
        '
        'logout_btn
        '
        Me.logout_btn.BackColor = System.Drawing.Color.Red
        Me.logout_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout_btn.ForeColor = System.Drawing.Color.White
        Me.logout_btn.Location = New System.Drawing.Point(12, 12)
        Me.logout_btn.Name = "logout_btn"
        Me.logout_btn.Size = New System.Drawing.Size(117, 23)
        Me.logout_btn.TabIndex = 3
        Me.logout_btn.Text = "Logout"
        Me.logout_btn.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(60, 178)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(204, 133)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Books"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(302, 178)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(204, 133)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Borrow"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(546, 178)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(204, 133)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Users"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 462)
        Me.Controls.Add(Me.logout_btn)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.user_btn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.borrow_btn)
        Me.Controls.Add(Me.books_btn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library Management System"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents books_btn As Button
    Friend WithEvents borrow_btn As Button
    Friend WithEvents user_btn As Button
    Friend WithEvents logout_btn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
