
Imports System.Data.OleDb

Public Class BOOK_ISSUE
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        provider = "provider= Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "F:\program\pk\MY_LIBRARY\MY_LIBRARY\library.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "INSERT INTO BOOK_ISSUE (ACC_NO,TYPE,TITTLE,LOGIN_NAME,FULL_NAME,ISSUE_DATE)" &
            "VALUES (' " & Me.TextBox1.Text & " ',' " & Me.TextBox2.Text & " ',' " & Me.TextBox3.Text & " ',' " & Me.TextBox4.Text & " ' ,' " & Me.TextBox5.Text & " ','NOW()')"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        End
    End Sub
End Class