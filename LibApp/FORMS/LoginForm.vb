Imports System.Data.OleDb

Public Class LoginForm


    Dim lib_util As New utils
    Dim dt As New DataTable

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click



        Try
            dt = lib_util.ExecuteFunction("SELECT * FROM `User_Auth` WHERE Username='" & username_txtbox.Text & "' AND Password= '" & password_txtbox.Text & "'")

            If dt.Rows.Count > 0 Then

                If (dt.Rows(0).Item("AccessLevel") = 2) Then

                    With MainForm
                        .books_btn.Enabled = False
                        .user_btn.Enabled = False
                    End With
                Else
                    With MainForm
                        .books_btn.Enabled = True
                        .user_btn.Enabled = True
                    End With
                End If

                Me.Hide()
                MainForm.Show()

            Else
                MessageBox.Show("Invalid Username/Password!")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        Finally
            dt.Clear()

        End Try







    End Sub

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        Me.Close()


    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class