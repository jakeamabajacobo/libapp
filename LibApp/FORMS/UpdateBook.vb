Imports System.Data.OleDb

Public Class UpdateBook

    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\git\libapp\LibApp\DB\Books97.accdb")
    Dim com As New OleDbCommand
    Dim adpt As New OleDbDataAdapter
    Dim dt As New DataTable
    Dim str_qry As String
    Dim utils As New utils
    Dim dtt As New DataTable


    Function populateTable(ByVal uid As String)

        Try
            str_qry = "SELECT ID,Title,Description,Author,Quantity,ISBN,CategoryID FROM Books WHERE ID=" & uid & ""
            con.Open()
            com.Connection = con
            com.CommandText = str_qry
            adpt.SelectCommand = com

            dtt.Clear()
            adpt.Fill(dtt)

            If dtt.Rows.Count > 0 Then

                title_txtbox.Text = dtt.Rows(0).Item("Title")
                description_txtbox.Text = dtt.Rows(0).Item("Description")
                author_txtbox.Text = dtt.Rows(0).Item("Author")
                qty_txtbox.Text = dtt.Rows(0).Item("Quantity")
                isbn_txtbox.Text = dtt.Rows(0).Item("ISBN")
                category_cb.SelectedIndex = Convert.ToInt32(dtt.Rows(0).Item("CategoryID")) - 1
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
            dtt.Dispose()

        End Try



    End Function


    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        Me.Hide()
        BookForm.Show()

    End Sub

    Private Sub UpdateBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            dt = New DataTable
            dt = utils.ExecuteFunction("SELECT * FROM CategoryID")

            category_cb.DataSource = dt
            category_cb.DisplayMember = "CategoryName"
            category_cb.ValueMember = "CategoryID"

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try


        '  populateTable(BookForm.sel_id)




    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click


        Try
            con.Open()
            com.Connection = con
            com.CommandText = str_qry

            If com.ExecuteNonQuery > 0 Then
                MsgBox("Item Saved!")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
            com.Dispose()

        End Try




    End Sub
End Class