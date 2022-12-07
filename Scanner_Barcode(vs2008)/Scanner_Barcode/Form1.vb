Imports System.Data.SqlClient
Imports System.Data

Public Class Form1

    Dim conn As SqlConnection
    Dim cmd As SqlCommand

    Private Sub Form1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        Label9.Text = DatabaseName
    End Sub


    'form load (start)
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            userID.Focus()
            If (conn_str = "null") Then
                Label9.Text = "Not Connected to Database"
            Else
                Label9.Text = DatabaseName
            End If
        Catch ex As Exception
        End Try
    End Sub

    'login_btn event
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login_btn.Click

        conn = New SqlConnection(conn_str)
        'Declaring the Column and Row to check if variables exist
        Dim query As String = "Select * From dbo.UserMaster where UserName = @UserName and Password = @Password"
        conn.Open()
        cmd = New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@UserName", userID.Text)
        cmd.Parameters.AddWithValue("@Password", userPass.Text)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader()
        If dr.Read = True Then
            'user_found_lbl.Text = "✓"
            Dim _Identify_Model As New Identify_Model_2
            _Identify_Model.user = userID.Text
            _Identify_Model.Show()
            Me.Hide()
        Else
            user_found_lbl.Visible = True
            user_found_lbl.Text = "Invalid Credentials"
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

    'settings
    Private Sub settings_pbx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settings_pbx.Click
        Settings.Show()
    End Sub


    'Clears the chat inputbox for the user to type
    Private Sub userID_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles userID.GotFocus
        user_found_lbl.Visible = False
    End Sub

    Private Sub userPass_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles userPass.GotFocus
        user_found_lbl.Visible = False
    End Sub

End Class
