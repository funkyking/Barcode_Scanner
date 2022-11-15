Public Class WorkCentre_Topup_Scan_Part_5
    'This one gets the part station ID'

    'home_btn = returns to identify model page
    'back_btn = returns to previous form
    'logout_btn = logout (returns to login page)
    'cont_btn = opens next form

    Public temp As String 'temporary string to send value to next form
    Public part_name_temp As String 'This one is cached and moved up until last station

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

    'Cont_btn event
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cont_btn.Click
        'Copy user input
        Dim userInput As String = part_ID.Text
        part_name_temp = part_ID.Text

        'To display either fail or pass
        Dim Pass As New Boolean

        'This is a temporary database to store the sublines (test)
        Dim E1 As String() = {"Wood", "Glue", "Nail"}
        Dim E2 As String() = {"Led", "LED", "BULB", "Bulb"}
        Dim E3 As String() = {"Take", "Have", "Give"}
        Dim E4 As String() = {"Brown", "Green", "Blue"}

        Dim mdl_sub_ID As String = ""
        If (E1.Contains(userInput)) Then
            mdl_sub_ID = String.Format("E1")
            Pass = True
        ElseIf (E2.Contains(userInput)) Then
            mdl_sub_ID = String.Format("E2")
            Pass = True
        ElseIf (E3.Contains(userInput)) Then
            mdl_sub_ID = String.Format("E3")
            Pass = True
        ElseIf (E4.Contains(userInput)) Then
            mdl_sub_ID = String.Format("E4")
            Pass = True
        End If
        temp = mdl_sub_ID 'passing the value to main, use for next form

        'Once we found the data in database, a form is created to display the result if passed or failed
        If (Pass = True) Then
            Dim passed As New Subline_Result_3
            passed.BackColor = Color.LawnGreen
            passed._top_lbl = "Part Station"
            passed._bot_lbl = String.Format("{0}", mdl_sub_ID)
            passed.Show()

            'Creates new form
            Dim form As New WorkCentre_Topup_Scan_Station_6
            form.user = username.Text 'pass username label
            form._part = part_ID.Text 'pass part ID label
            form._subline = sub_lbl.Text 'pass subline label
            form._model = mdl_lbl.Text 'pass model label
            form._part_station = temp 'pass part station label
            form.part_name_cache = part_name_temp 'sends the name of the part
            form.Show()
            Me.Close()
        Else
            Dim failed As New Subline_Result_3
            failed.BackColor = Color.Red
            failed._top_lbl = "Part"
            failed._bot_lbl = "Not Found"
            failed.Show()
        End If
    End Sub

    'back_btn event
    Private Sub backbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_btn.Click
        Dim back As New choose_option_4
        back.Show()
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

    'auto hit enter
    Private Sub WorkCentre_Topup_Scan_Part_5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (part_ID.Text IsNot "") Then
            If e.KeyCode = Keys.Enter Then
                Call Button2_Click(sender, e)
            End If
        End If

    End Sub
End Class