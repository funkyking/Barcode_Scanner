Public Class Form1

    'userID = username field (txtbox)
    'userPass = password field (txtbox)
    'login_btn = login (button)
    'qr_login = qr login / validate (button)
    'forgot_password_link = hyperlink redirect to forget password page (not working atm / no database)

    'login_btn event
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login_btn.Click

        'Temporary database for usernames
        Dim s1 As String() = {"Charlie", "James", "Tim Cook"}
        Dim userNameInput As String = userID.Text
        Dim userPassWord As String = "123"

        If (s1.Contains(userNameInput) And userPass.Text.Contains(userPassWord)) Then
            Dim _Identify_Model As New Identify_Model_2
            _Identify_Model.user = userID.Text
            _Identify_Model.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid Credentials")
        End If

    End Sub

    'qr_login button event
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qr_login.Click
        Dim Scan_Model_Subline As New Identify_Model_2 'Qr Code Login
        Scan_Model_Subline.Show()
        Me.Close()
    End Sub

    'auto inputs into qr code field
    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = ChrW(13) Then
            MsgBox(TextBox3.Text, MsgBoxStyle.Information)
            TextBox3.Text = ""
        End If
    End Sub

End Class
