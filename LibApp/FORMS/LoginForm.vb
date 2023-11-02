Imports System.Data.OleDb

Public Class LoginForm
    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Me.Hide()
        MainForm.Show()

    End Sub

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        Me.Close()


    End Sub
End Class