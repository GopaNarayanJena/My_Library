Public Class ADMIN_TYPE
    Private Sub ADMIN_TYPE_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FORM1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            user_profile.Show()
        ElseIf RadioButton2.Checked = True
            BOOK_ISSUE.Show()
        ElseIf RadioButton3.Checked = True
            BOOK_SEARCH.Show()
        ElseIf RadioButton4.Checked = True
            BOOK_ENTRY.Show()
        ElseIf RadioButton5.Checked = True
            BOOK_ISSUE.Show()
        ElseIf RadioButton6.Checked = True
            USER_CONFIRM.Show()
        ElseIf RadioButton7.Checked = True
            PUBLISHER_ENTRY.Show()
        ElseIf RadioButton8.Checked = True

        ElseIf RadioButton9.Checked = True
            REPORT.Show()
        End If
        Me.Hide()
    End Sub
End Class