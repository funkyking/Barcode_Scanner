Public Class choose_option_4

    'home_btn = returns to identify model page
    'back_btn = returns to previous form
    'topup_btn = opens topup form
    'logout_btn = logout (returns to login page)

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

    'home_btn event
    Private Sub homebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles home_btn.Click
        Dim Home As New Identify_Model_2
        Home.Show()
        Me.Close()
    End Sub

    'logout_btn event
    Private Sub logout_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logout_btn.Click
        Dim logout As New Form1 'Return to Login Screen (Logout)
        logout.Show()
        Me.Close()
    End Sub

    'back_btn_event
    Private Sub back_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_btn.Click
        Dim back As New Identify_Model_2
        back.Show()
        Me.Close()
    End Sub
End Class