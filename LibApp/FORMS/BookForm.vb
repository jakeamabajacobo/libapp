Imports System.Data.OleDb

Public Class BookForm

    Dim db_connection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\git\libapp\LibApp\DB\Books97.accdb")
    Dim qry_str As String
    Dim db_command As New OleDbCommand
    Dim db_adapter As New OleDbDataAdapter
    Dim dt As New DataTable



    Private Sub BookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try
            db_connection.Open()
            qry_str = "SELECT ID,Title,Description,Author,Quantity,ISBN FROM Books"
            db_command.Connection = db_connection
            db_command.CommandText = qry_str
            db_adapter.SelectCommand = db_command
            dt.Clear()
            db_adapter.Fill(dt)
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
            db_connection.Close()
            dt.Dispose()
            db_adapter.Dispose()



        End Try
    End Sub

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click

    End Sub
End Class