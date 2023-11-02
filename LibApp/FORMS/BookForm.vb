Imports System.Data.OleDb

Public Class BookForm

    Dim utils As New utils
    Dim dt As New DataTable



    Private Sub BookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Try

            dt = utils.ExecuteFunction("SELECT ID,Title,Description,Author,Quantity,ISBN FROM Books")
            dt_grid.Rows.Clear()

            dt_grid.DataSource = dt
            dt_grid.AllowUserToResizeColumns = False
            dt_grid.AllowUserToAddRows = False

            dt_grid.Columns(0).HeaderText = "ID"
            dt_grid.Columns(1).HeaderText = "TITLE"
            dt_grid.Columns(2).HeaderText = "DESCRIPTION"
            dt_grid.Columns(3).HeaderText = "AUTHOR"
            dt_grid.Columns(4).HeaderText = "QTY"
            dt_grid.Columns(5).HeaderText = "ISBN"



        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            dt.Dispose()
        End Try
    End Sub

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        AddBook.Show()



    End Sub

    Private Sub dt_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_grid.CellClick

    End Sub
End Class