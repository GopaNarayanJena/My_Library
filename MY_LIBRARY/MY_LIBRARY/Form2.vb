Imports System.Data.OleDb
Public Class U_REG
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=F:\program\pk\MY_LIBRARY\MY_LIBRARY\library.accdb"
        Dim query As String
        If TextBox8.Text = TextBox9.Text Then
            query = "select * from user_prof where user_id = '" & TextBox1.Text & "' OR pWd='" & TextBox8.Text & "';"
            Dim c As Integer
            Dim cmd1 As New OleDbCommand(query, con)
            con.Open()
            Dim reader As OleDbDataReader = cmd1.ExecuteReader()
            While reader.Read()
                c = c + 1
            End While
            reader.Close()
            con.Close()
            If c = 1 Then
                MsgBox("username or password or both already exist")
            Else
                Try
                    query = "INSERT INTO  USER_PROF(LOGIN_NAME,USER_ID,FULL_NAME,PWD,ROLE,OCCUPATION,ADDRESS1,ADDRESS2,ADDRESS3,PHONE,EMAIL,status)" &
                    "VALUES ('" & Me.TextBox1.Text & "','" & Me.TextBox1.Text &
                    "','" & Me.TextBox2.Text & "','" & Me.TextBox8.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text &
                    "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','N')"
                    Dim cmd As OleDbCommand = New OleDbCommand(query, con)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MessageBox.Show("UPDATE SUCCESSFULL")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        Else
            MsgBox("password mismatched")
        End If
    End Sub

    Private Sub U_REG_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FORM1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FORM1.Show()
        Me.Hide()
    End Sub
End Class