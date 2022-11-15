Public Class WorkCentre_Topup_Scan_Station_6

    'home_btn = returns to identify model page
    'back_btn = returns to previous form
    'logout_btn = logout (returns to login page)
    'cont_btn = opens next form


    Public part_name_cache As String 'carrying part name

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
            Return part_Id_lbl.Text
        End Get
        Set(ByVal value As String)
            part_Id_lbl.Text = value
        End Set
    End Property

    'Passing station detail
    Friend Property _part_station() As String
        Get
            Return part_station_lbl.Text
        End Get
        Set(ByVal value As String)
            part_station_lbl.Text = value
        End Set
    End Property

    'Carries the part Id
    Friend Property _part_name_cache() As String
        Get
            Return part_name_cache
        End Get
        Set(ByVal value As String)
            part_name_cache = value
        End Set
    End Property

    'cont_btn event
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cont_btn.Click

        'Copy user input
        Dim userInput As String = scn_stn.Text

        'To display either fail or pass
        Dim Pass As New Boolean

        'This is a temporary database to store the sublines (test)
        Dim station_1 As String() = {"stn_1"}
        Dim station_2 As String() = {"stn_2"}
        Dim station_3 As String() = {"stn_3"}
        Dim station_4 As String() = {"stn_4"}

        Dim mdl_sub_ID As String = ""
        If (station_1.Contains(userInput)) Then
            mdl_sub_ID = String.Format("Match !")
            Pass = True
        ElseIf (station_2.Contains(userInput)) Then
            mdl_sub_ID = String.Format("Match !")
            Pass = True
        ElseIf (station_3.Contains(userInput)) Then
            mdl_sub_ID = String.Format("Match !")
            Pass = True
        ElseIf (station_4.Contains(userInput)) Then
            mdl_sub_ID = String.Format("Match !")
            Pass = True
        End If

        'Once we found the data in database, a form is created to display the result if passed or failed
        If (Pass = True) Then
            Dim passed As New Subline_Result_3
            passed.BackColor = Color.LawnGreen
            passed._top_lbl = "Station"
            passed._bot_lbl = mdl_sub_ID
            passed.Show()

            If (passed Is DBNull.Value) Then
                'Creates new form
                Dim form As New WorkCentre_Topup_Scan_Sample_7 'Loads part sample scan (Final)
                form.user = username.Text 'passing username
                form._part = part_Id_lbl.Text 'pass part ID label
                form._subline = sub_lbl.Text 'pass subline label
                form._model = mdl_lbl.Text 'pass model label
                form._station = part_station_lbl.Text 'pass station label
                form._part_name_cache = part_name_cache 'pass the name of the part
                form.Show()
                Me.Close()
            End If
        Else
            Dim failed As New Subline_Result_3
            failed.BackColor = Color.Red
            failed._top_lbl = "Station"
            failed._bot_lbl = "Not Match !"
            failed.Show()
        End If
    End Sub

    'home_btn event
    Private Sub homebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles home_btn.Click
        Dim Home As New Identify_Model_2
        Home.Show()
        Me.Close()
    End Sub

    'back_btn event
    Private Sub back_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_btn.Click
        Dim back As New WorkCentre_Topup_Scan_Part_5
        back.Show()
        Me.Close()
    End Sub

    'logout_btn event
    Private Sub logout_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logout_btn.Click
        Dim logout As New Form1 'Return to Login Screen (Logout)
        logout.Show()
        Me.Close()
    End Sub

    'This calls the enter key to auto execute and open next form
    Private Sub WorkCentre_Topup_Scan_Station_6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (scn_stn.Text IsNot "") Then
            If e.KeyCode = Keys.Enter Then
                Call Button2_Click(sender, e)
            End If
        End If
    End Sub
End Class