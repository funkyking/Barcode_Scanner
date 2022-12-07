Imports System.Data.SqlClient
Imports System.Data

Public Class Identify_Model_2

    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader


    'Passing username credentials
    Friend Property user() As String
        Get
            Return username.Text
        End Get
        Set(ByVal value As String)
            username.Text = value
        End Set
    End Property

    'Continue button event
    Private Sub Cont_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cont_btn.Click
        Try
            If (model_ID.Text IsNot Nothing) Then

                Dim userInput As String = model_ID.Text
                Dim form As New choose_option_4
                form._model = userInput.Split(",")(1) 'Name of the Model

                Dim line As String = userInput.Substring(0, userInput.IndexOf(","))
                form._subline = line 'Passing the subline detail

                form.user = username.Text 'sending username value to next form
                form.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid Model")
            End If

        Catch ex As Exception

        End Try
        
    End Sub

    'Once user scan it triggers this (same as scan)
    Private Sub model_ID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles model_ID.KeyDown
        Try
            Dim res As Boolean 'Check if input matches database

            If e.KeyCode = Keys.Enter Then
                Dim userInput As String = model_ID.Text

                'Given Variable
                Dim _LineCode As String = userInput.Substring(0, userInput.IndexOf(",")) 'Subline (num)
                Dim _ModelCode As String = userInput.Split(",")(1) 'Name of the Model

                'Finding Variables
                Dim _LineID As String = "" 'Id of the Subline
                Dim _ModelID As String = "" 'Id of the Model

                _LineID = GetLineID(_LineCode)
                _ModelID = GetModelId(_ModelCode)
                res = Model_and_Line_Check(_ModelID, _LineID)

                If (res = True) Then
                    Dim passed As New Subline_Result_3
                    passed.BackColor = Color.LawnGreen
                    passed._top_lbl = "Station && Model" 'top Label
                    passed._bot_lbl = "Found" 'bottom label
                    passed.Show()
                    Cont_btn_Click(sender, New EventArgs())
                Else
                    Dim failed As New Subline_Result_3
                    failed._top_lbl = "Station && Model"
                    failed.BackColor = Color.Red
                    failed._bot_lbl = "Not Found"
                    failed.Show()
                End If
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Log out
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logout_pbx.Click
        Try
            Dim logout As New Form1 'Return to Login Screen (Logout)
            logout.Show()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    'Rescan
    Private Sub rescan_pbx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rescan_pbx.Click
        Try
            model_ID.Text = ""
        Catch ex As Exception
        End Try
    End Sub

    'settings
    Private Sub settings_pbx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settings_pbx.Click
        Settings.Show()
    End Sub

End Class