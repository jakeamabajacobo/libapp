<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateBook
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.qty_txtbox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.isbn_txtbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.description_txtbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.author_txtbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.title_txtbox = New System.Windows.Forms.TextBox()
        Me.cancel_btn = New System.Windows.Forms.Button()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.category_cb = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 411)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 24)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Category:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 335)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 24)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Quantity:"
        '
        'qty_txtbox
        '
        Me.qty_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.qty_txtbox.Location = New System.Drawing.Point(54, 361)
        Me.qty_txtbox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.qty_txtbox.Multiline = True
        Me.qty_txtbox.Name = "qty_txtbox"
        Me.qty_txtbox.Size = New System.Drawing.Size(470, 42)
        Me.qty_txtbox.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(51, 259)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 24)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "ISBN:"
        '
        'isbn_txtbox
        '
        Me.isbn_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.isbn_txtbox.Location = New System.Drawing.Point(54, 285)
        Me.isbn_txtbox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.isbn_txtbox.Multiline = True
        Me.isbn_txtbox.Name = "isbn_txtbox"
        Me.isbn_txtbox.Size = New System.Drawing.Size(470, 42)
        Me.isbn_txtbox.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 179)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 24)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Desciption:"
        '
        'description_txtbox
        '
        Me.description_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.description_txtbox.Location = New System.Drawing.Point(54, 205)
        Me.description_txtbox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.description_txtbox.Multiline = True
        Me.description_txtbox.Name = "description_txtbox"
        Me.description_txtbox.Size = New System.Drawing.Size(470, 42)
        Me.description_txtbox.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 102)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 24)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Author"
        '
        'author_txtbox
        '
        Me.author_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.author_txtbox.Location = New System.Drawing.Point(54, 128)
        Me.author_txtbox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.author_txtbox.Multiline = True
        Me.author_txtbox.Name = "author_txtbox"
        Me.author_txtbox.Size = New System.Drawing.Size(470, 42)
        Me.author_txtbox.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 27)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 24)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Title:"
        '
        'title_txtbox
        '
        Me.title_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.title_txtbox.Location = New System.Drawing.Point(54, 53)
        Me.title_txtbox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.title_txtbox.Multiline = True
        Me.title_txtbox.Name = "title_txtbox"
        Me.title_txtbox.Size = New System.Drawing.Size(470, 42)
        Me.title_txtbox.TabIndex = 40
        '
        'cancel_btn
        '
        Me.cancel_btn.Location = New System.Drawing.Point(292, 517)
        Me.cancel_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cancel_btn.Name = "cancel_btn"
        Me.cancel_btn.Size = New System.Drawing.Size(118, 58)
        Me.cancel_btn.TabIndex = 39
        Me.cancel_btn.Tag = "k"
        Me.cancel_btn.Text = "Cancel"
        Me.cancel_btn.UseVisualStyleBackColor = True
        '
        'save_btn
        '
        Me.save_btn.Location = New System.Drawing.Point(154, 517)
        Me.save_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(118, 58)
        Me.save_btn.TabIndex = 38
        Me.save_btn.Text = "Update"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'category_cb
        '
        Me.category_cb.FormattingEnabled = True
        Me.category_cb.Location = New System.Drawing.Point(55, 438)
        Me.category_cb.Name = "category_cb"
        Me.category_cb.Size = New System.Drawing.Size(469, 21)
        Me.category_cb.TabIndex = 52
        '
        'UpdateBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 601)
        Me.Controls.Add(Me.category_cb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.qty_txtbox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.isbn_txtbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.description_txtbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.author_txtbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.title_txtbox)
        Me.Controls.Add(Me.cancel_btn)
        Me.Controls.Add(Me.save_btn)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "UpdateBook"
        Me.Text = "UpdateBook"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents qty_txtbox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents isbn_txtbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents description_txtbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents author_txtbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents title_txtbox As TextBox
    Friend WithEvents cancel_btn As Button
    Friend WithEvents save_btn As Button
    Friend WithEvents category_cb As ComboBox
End Class
