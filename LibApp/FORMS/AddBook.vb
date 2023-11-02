Public Class AddBook
    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click

        title_txtbox.Text = ""
        author_txtbox.Text = ""
        category_txtbox.Text = ""
        description_txtbox.Text = ""
        isbn_txtbox.Text = ""
        qty_txtbox.Text = ""

        Me.Hide()
        MainForm.Show()



    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click

    End Sub
End Class