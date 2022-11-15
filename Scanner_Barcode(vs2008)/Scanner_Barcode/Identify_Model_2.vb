Public Class Identify_Model_2

    'model_image = picturebox
    'cont_btn = continue button
    'rescan_btn = rescan button
    'model_ID = subline & model textbox (your input textbox)
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

    'logout button event
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim logout As New Form1 'Return to Login Screen (Logout)
        logout.Show()
        Me.Close()
    End Sub

    'Continue button event
    Private Sub Cont_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cont_btn.Click
        If (mdl_sub_ID.Text IsNot Nothing) Then
            Dim form As New choose_option_4
            form._model = model_ID.Text 'Passing model to form

            Dim line As String = String.Format("Subline {0}", Mid(mdl_sub_ID.Text, 1, 1))
            form._subline = line 'Passing the subline detail

            form.user = username.Text 'sending username value to next form
            form.Show()
            Me.Close()
        Else
            MessageBox.Show("Invalid Model")
        End If
        
    End Sub

    'Scan button event
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scan_btn.Click
        'Copy user input
        Dim userInput As String = model_ID.Text

        'To display either fail or pass
        Dim Pass As New Boolean

        'This is a temporary database to store the sublines (test)
        Dim subline_1 As String() = {"Table", "Chair"}
        Dim subline_2 As String() = {"Led", "LED", "BULB", "Bulb"}
        Dim subline_3 As String() = {"Take", "Have", "Give"}
        Dim subline_4 As String() = {"Brown", "Green", "Blue"}

        If (subline_1.Contains(userInput)) Then
            mdl_sub_ID.Text = String.Format("1 ,{0} ", userInput)
            Pass = True
        ElseIf (subline_2.Contains(userInput)) Then
            mdl_sub_ID.Text = String.Format("2 , {0} ", userInput)
            Pass = True
        ElseIf (subline_3.Contains(userInput)) Then
            mdl_sub_ID.Text = String.Format("3 , {0} ", userInput)
            Pass = True
        ElseIf (subline_4.Contains(userInput)) Then
            mdl_sub_ID.Text = String.Format("4 , {0} ", userInput)
            Pass = True
        End If

        'Once we found the data in database, a form is created to display the result if passed or failed
        If (Pass = True) Then
            Dim passed As New Subline_Result_3
            passed.BackColor = Color.LawnGreen
            Dim res As String = Mid(mdl_sub_ID.Text, 1, 1) 'Displays only the front 1 character which is (1 or 2 or .....)
            passed._top_lbl = "Station && Model" 'top Label
            passed._bot_lbl = res 'bottom label
            passed.Show()
        Else
            Dim failed As New Subline_Result_3
            failed._top_lbl = "Station && Model"
            failed.BackColor = Color.Red
            failed._bot_lbl = "Not Found"
            failed.Show()
        End If
        
    End Sub

    'Rescan button event
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rescan_btn.Click
        model_ID.Text = ""
        model_img = Nothing
    End Sub
End Class