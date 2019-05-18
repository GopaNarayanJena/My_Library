Imports System.Data.OleDb
Public Class FORM1
    Dim usr, pwd As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        U_REG.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=F:\program\pk\MY_LIBRARY\MY_LIBRARY\library.accdb"
        Dim str As String = "select * from user_prof where user_id = '" & TextBox1.Text & "' and PWD ='" & TextBox2.Text & "'"
        Dim c As Integer
        Dim cmd As New OleDbCommand(str, con)
        Try
            con.Open()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            While reader.Read()
                c = c + 1
            End While
            reader.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If c = 1 Then
            ADMIN_TYPE.Show()
            Me.Hide()
        Else
            MsgBox("invalid USERNAME and PASSWORD ")
        End If
    End Sub
End Class
