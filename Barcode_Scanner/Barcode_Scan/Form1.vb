Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '/* Temporary Database For Usernames */
        Dim s1 As String() = {"Charlie", "James", "Tim Cook"}
        Dim userNameInput As String = userID.Text
        Dim userPassWord As String = "123"

        If (s1.Contains(userNameInput) And userPass.Text.Contains(userPassWord)) Then
            Dim OBJ As New Scan
            OBJ.username = userID.Text
            OBJ.Show()
            Me.Close
        Else
            MessageBox.Show("Invalid Credentials")
        End If
    End Sub

End Class
