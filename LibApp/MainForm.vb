Imports System.Data.OleDb


Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub logout_btn_Click(sender As Object, e As EventArgs) Handles logout_btn.Click
        Me.Hide()
        LoginForm.Show()

    End Sub

    Private Sub books_btn_Click(sender As Object, e As EventArgs) Handles books_btn.Click
        BookForm.Show()

    End Sub

    Private Sub borrow_btn_Click(sender As Object, e As EventArgs) Handles borrow_btn.Click
        BorrowBookForm.Show()

    End Sub

    Private Sub user_btn_Click(sender As Object, e As EventArgs) Handles user_btn.Click
        UserForm.Show()

    End Sub
End Class
