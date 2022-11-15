Public Class WorkCentre_Topup_Scan_Sample_7

    'home_btn = returns to identify model page
    'back_btn = returns to previous form
    'logout_btn = logout (returns to login page)
    'cont_btn = opens next form

    Dim part_name_cache As String
    'passing username credentials
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

    'Passing part detail
    Friend Property _part() As String
        Get
            Return station_lbl.Text
        End Get
        Set(ByVal value As String)
            station_lbl.Text = value
        End Set
    End Property

    'Passing station ID
    Friend Property _station() As String
        Get
            Return station_lbl.Text
        End Get
        Set(ByVal value As String)
            station_lbl.Text = value
        End Set
    End Property

    Friend Property _part_name_cache() As String
        Get
            Return part_name_cache
        End Get
        Set(ByVal value As String)
            part_name_cache = value
        End Set
    End Property

    'home_btn event
    Private Sub homebtn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles home_btn.Click
        Dim Home As New Identify_Model_2
        Home.Show()
        Me.Close()
    End Sub

    'back_btn event
    Private Sub back_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_btn.Click
        Dim back As New WorkCentre_Topup_Scan_Station_6
        back.Show()
        Me.Close()
    End Sub

    'cont_btn event (displays result)
    Private Sub cont_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cont_btn.Click

        Dim Res As Boolean
        Dim userInput As String = ""
        userInput = scn_part.Text

        'This is a temporary database to store the sublines (test)
        Dim station_1 As String() = {"Wood", "Glue", "Nail"}
        Dim station_2 As String() = {"Led", "LED", "BULB", "Bulb"}
        Dim station_3 As String() = {"Take", "Have", "Give"}
        Dim station_4 As String() = {"Brown", "Green", "Blue"}


        If (userInput IsNot "") Then

            If (station_1.Contains(userInput) Or station_2.Contains(userInput) Or station_3.Contains(userInput) Or station_4.Contains(userInput)) Then
                Res = True
                Dim passed As New Subline_Result_3
                passed._top_lbl = "Part Match"
                passed._bot_lbl = " "
                passed.Show()

            Else
                Dim failed As New Subline_Result_3
                failed.BackColor = Color.Red
                failed._top_lbl = "Part Does"
                failed._bot_lbl = "Not Match"
                failed.Show()
            End If

        End If


        Dim result As New WorkCentre_Topup_Scan_Part_Match_8
        result.Show()
    End Sub

    'logout_btn event
    Private Sub logout_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logout_btn.Click
        Dim logout As New Form1 'Return to Login Screen (Logout)
        logout.Show()
        Me.Close()
    End Sub

    Private Sub WorkCentre_Topup_Scan_Sample_7_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (part_name.Text IsNot "") Then
            If e.KeyCode = Keys.Enter Then
                Call cont_btn_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub WorkCentre_Topup_Scan_Sample_7_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        part_name.Text = part_name_cache
    End Sub
End Class