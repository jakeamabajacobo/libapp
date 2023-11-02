Imports System.Data.OleDb

Public Class LoginForm

    Private db_connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\git\libapp\LibApp\DB\Books97.accdb")


    Private oledb_con As New OleDb.OleDbConnection()

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click



        Dim str_qry As String
        Dim db_command As New OleDbCommand
        Dim db_adatper As New OleDbDataAdapter
        Dim dt As New DataTable


        str_qry = "SELECT * FROM `User_Auth` WHERE Username= '" & username_txtbox.Text & "' AND Password= '" & password_txtbox.Text & "'  "

        Try
            db_connection.Open()
            db_command.Connection = db_connection
            db_command.CommandText = str_qry
            db_adatper.SelectCommand = db_command
            db_adatper.Fill(dt)


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
            db_connection.Close()

        End Try







    End Sub

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        Me.Close()


    End Sub
End Class