Imports System.Data.OleDb

Public Class BOOK_ENTRY
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        provider = "provider= Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "F:\program\pk\MY_LIBRARY\MY_LIBRARY\library.accdbb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "INSERT INTO BOOK_INFO (TYPE,ISBN,TITLE,AUTHOR,SUB,PUB,LAN,EDITION,PUB_DATE,COST,ISSUED)" &
            "VALUES (' " & Me.ComboBox1.Text & " ',' " & Me.TextBox1.Text & " ',' " & Me.TextBox2.Text & " ',' " & Me.TextBox3.Text & " ',' " & Me.ComboBox2.Text & " ',' " & Me.ComboBox3.Text & " ',' " & Me.ComboBox4.Text & " ',' " & Me.TextBox4.Text & " ',' " & Me.ComboBox5.Text & " ',' " & Me.TextBox5.Text & " ',' " & Me.TextBox6.Text & " ')"
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
            TextBox6.Text = ""
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox3.Text = ""
            ComboBox4.Text = ""
            ComboBox5.Text = ""

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class