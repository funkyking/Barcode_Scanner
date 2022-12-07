Public Class choose_option_4


    'Passing username credentials
    Friend Property user() As String
        Get
            Return username.Text
        End Get
        Set(ByVal value As String)
            username.Text = value
        End Set
    End Property

    'Passing Model ID
    Friend Property _model() As String
        Get
            Return mdl_lbl.Text
        End Get
        Set(ByVal value As String)
            mdl_lbl.Text = value
        End Set
    End Property

    'Passing Subline detail
    Friend Property _subline() As String
        Get
            Return sub_lbl.Text
        End Get
        Set(ByVal value As String)
            sub_lbl.Text = value
        End Set
    End Property

    'topup_btn event (triggers to open topup form)
    Private Sub topup_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles topup_btn.Click
        Dim form As New WorkCentre_Topup_Scan_Part_5
        form.user = username.Text 'passing username to another form
        form._model = mdl_lbl.Text 'pass model
        form._subline = sub_lbl.Text 'pass subline
        form.Show()
        Me.Close()
    End Sub

    'logout
    Private Sub logout_pbx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logout_pbx.Click
        Dim logout As New Form1 'Return to Login Screen (Logout)
        logout.Show()
        Me.Close()
    End Sub

    'settings
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Settings.Show()
    End Sub

    'back
    Private Sub back_pbx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_pbx.Click
        Try
            Dim back As New Identify_Model_2
            back.username.Text = username.Text
            back.Show()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    'home
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Try
            Dim Home As New Identify_Model_2
            Home.user = username.Text
            Home.Show()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub
End Class