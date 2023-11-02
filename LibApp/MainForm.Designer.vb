<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.books_btn = New System.Windows.Forms.Button()
        Me.borrow_btn = New System.Windows.Forms.Button()
        Me.user_btn = New System.Windows.Forms.Button()
        Me.logout_btn = New System.Windows.Forms.Button()
        Me.brw_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'books_btn
        '
        Me.books_btn.AccessibleName = "btn_books"
        Me.books_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.books_btn.Location = New System.Drawing.Point(59, 178)
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
        'brw_btn
        '
        Me.brw_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brw_btn.Location = New System.Drawing.Point(302, 178)
        Me.brw_btn.Name = "brw_btn"
        Me.brw_btn.Size = New System.Drawing.Size(204, 133)
        Me.brw_btn.TabIndex = 1
        Me.brw_btn.Text = "Borrow"
        Me.brw_btn.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 462)
        Me.Controls.Add(Me.logout_btn)
        Me.Controls.Add(Me.brw_btn)
        Me.Controls.Add(Me.user_btn)
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
    Friend WithEvents brw_btn As Button
End Class
