Imports System.Data.OleDb
Public Class PUBLISHER_ENTRY
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        provider = "provider= Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=F:\program\pk\MY_LIBRARY\MY_LIBRARY\library.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "INSERT INTO PUBLISHER (PUB_NAME,ADDRESS1,ADDRESS2,ADDRESS3,CITY,STATE,COUNTRY,PIN_CODE,PHONE,FAX,EMAIL)" &
            "VALUES (' " & Me.TextBox1.Text & " ',' " & Me.TextBox2.Text & " ',' " & Me.TextBox3.Text & " ',' " & Me.TextBox4.Text & " ',' " & Me.TextBox5.Text & " ',' " & Me.TextBox6.Text & " ',' " & Me.TextBox7.Text & " ',' " & Me.TextBox8.Text & " ',' " & Me.TextBox9.Text & " ',' " & Me.TextBox10.Text & " ',' " & Me.TextBox11.Text & " ')"
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
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            TextBox10.Text = ""
            TextBox11.Text = ""

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

End Class