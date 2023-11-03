Imports System.Data.OleDb

Public Class utils
    Dim db_connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\git\libapp\LibApp\DB\Books97.accdb")

    Dim db_command As New OleDbCommand
    Dim db_adapter As New OleDbDataAdapter
    Dim db_reader As OleDbDataReader
    Dim dt As New DataTable
    Dim qry_str As String


    Function ClearConnection()
        db_connection.Close()
        dt.Dispose()
        db_adapter.Dispose()
    End Function


    Public Function DataExist(ByVal check_str As String) As Integer

        Try
            db_connection.Open()
            db_command.Connection = db_connection
            db_command.CommandText = check_str
            db_adapter.SelectCommand = db_command
            dt.Clear()
            db_adapter.Fill(dt)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            ClearConnection()

        End Try

        Return dt.Rows.Count
    End Function


    Public Function ManipulateDB(ByVal str_qry As String)

        Try

            db_connection.Open()
            db_command.CommandText = str_qry
            db_command.Connection = db_connection
            '   db_adapter.SelectCommand = db_command


            '  If (db_command.ExecuteNonQuery() > 0) Then
            MsgBox("Data Saved !")
            ' End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            ClearConnection()
        End Try

    End Function


    Public Function ExecuteFunction(ByVal qry_str As String) As DataTable

        Try
            db_connection.Open()
            db_command.Connection = db_connection
            db_command.CommandText = qry_str
            db_adapter.SelectCommand = db_command
            dt.Clear()
            db_adapter.Fill(dt)





        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            ClearConnection()
        End Try


        Return dt


    End Function



End Class
