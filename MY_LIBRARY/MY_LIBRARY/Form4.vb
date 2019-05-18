Imports System.Data.OleDb
Public Class USER_CONFIRM
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=F:\program\pk\MY_LIBRARY\MY_LIBRARY\library.accdb"
        Dim query As String
        query = "update user_prof set status='O' WHERE STATUS='N'"
        Dim cmd As OleDbCommand = New OleDbCommand(query, con)
        con.Open()
        cmd.ExecuteNonQuery()
        MsgBox("useer confirmed")
        con.Close()
    End Sub

    Private Sub USER_CONFIRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=F:\program\pk\MY_LIBRARY\MY_LIBRARY\library.accdb"
        Dim query As String
        query = "select * from user_prof WHERE status='N'"
        Dim cmd As New OleDbDataAdapter(query, con)
        Dim dr As New DataSet
        Try
            con.Open()
            cmd.Fill(dr, "user_prof")
            DataGridView1.DataSource = dr.Tables(0)
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class