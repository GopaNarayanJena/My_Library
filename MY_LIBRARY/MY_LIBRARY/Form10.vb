Imports System.Data.OleDb
Public Class user_profile
    Private Sub user_profile_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ADMIN_TYPE.Show()
        Me.Hide()
    End Sub

    Private Sub user_profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=F:\program\pk\MY_LIBRARY\MY_LIBRARY\library.accdb"
        Dim query As String
        query = "select * from user_prof'"
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