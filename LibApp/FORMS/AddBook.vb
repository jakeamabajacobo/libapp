Imports System.Data.OleDb
Public Class AddBook






    Dim utils As New utils
    Dim dt As New DataTable

    Function clearForm()
        title_txtbox.Text = ""
        author_txtbox.Text = ""

        description_txtbox.Text = ""
        isbn_txtbox.Text = ""
        qty_txtbox.Text = ""

        Me.Hide()
        MainForm.Show()
    End Function

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        clearForm()


    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click


        If utils.DataExist("SELECT * FROM  `Books` WHERE `ISBN`=" & Convert.ToInt32(isbn_txtbox.Text) & "") > 0 Then
            'existing
            utils.ManipulateDB("UPDATE `Books` SET `Title`='" & title_txtbox.Text & "',`Description`='" & description_txtbox.Text & "',`CategoryID`='" & category_cb.SelectedIndex.ToString & "',`Author`='" & author_txtbox.Text & "',`Quantity`='" & qty_txtbox.Text & "'")
        Else
            'new data
            utils.ManipulateDB("INSERT INTO  `Books` (`Title`,`ISBN`,`Description`,`CategoryID`,`Author`,`Quantity`) VALUES ('" & title_txtbox.Text & "','" & isbn_txtbox.Text & "','" & description_txtbox.Text & "','" & category_cb.SelectedIndex.ToString & "','" & author_txtbox.Text & "','" & qty_txtbox.Text & "')")
        End If

        clearForm()
        BookForm.IterateTable()
        Me.Hide()
        BookForm.Show()

    End Sub

    Private Sub AddBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try
            dt = utils.ExecuteFunction("SELECT * FROM CategoryID")

            category_cb.DataSource = dt
            category_cb.DisplayMember = "CategoryName"
            category_cb.ValueMember = "CategoryID"

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try


    End Sub
End Class