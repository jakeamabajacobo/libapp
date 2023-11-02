Public Class AddBook

    Dim utils As New utils
    Dim dt As New DataTable

    Function refform()
        title_txtbox.Text = ""
        author_txtbox.Text = ""
        category_txtbox.Text = ""
        description_txtbox.Text = ""
        isbn_txtbox.Text = ""
        qty_txtbox.Text = ""

        Me.Hide()
        MainForm.Show()
    End Function

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        refform()


    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click


        '`ID`='" & BookForm.dt_grid.CurrentRow.Cells(0).Value & "'  AND 


        If utils.DataExist("SELECT * FROM  `Books` WHERE `ISBN`=" & Convert.ToInt32(isbn_txtbox.Text) & "") > 0 Then
            'existing
            utils.ManipulateDB("UPDATE `Books` SET `Title`='" & title_txtbox.Text & "',`Description`='" & description_txtbox.Text & "',`CategoryID`='" & category_txtbox.Text & "',`Author`='" & author_txtbox.Text & "',`Quantity`='" & qty_txtbox.Text & "'")
            refform()

        Else
            'new data
            utils.ManipulateDB("INSERT INTO  `Books` (`Title`,`ISBN`,`Description`,`CategoryID`,`Author`,`Quantity`) VALUES ('" & title_txtbox.Text & "','" & isbn_txtbox.Text & "','" & description_txtbox.Text & "','" & category_txtbox.Text & "','" & author_txtbox.Text & "','" & qty_txtbox.Text & "')")
            refform()

        End If







    End Sub
End Class