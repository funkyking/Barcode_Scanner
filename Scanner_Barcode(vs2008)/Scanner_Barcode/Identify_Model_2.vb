Imports System.Data.SqlClient
Imports System.Data

Public Class Identify_Model_2

    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

#Region "Data Passing"
    'Passing username credentials
    Friend Property user() As String
        Get
            Return username.Text
        End Get
        Set(ByVal value As String)
            username.Text = value
        End Set
    End Property
#End Region

#Region "Main Events"
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

    'Rescan
    Private Sub rescan_pbx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rescan_pbx.Click
        Try
            model_ID.Text = ""
        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region "Dropdown"
    'settings 
    Private Sub stg_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stg_btn.Click
        Try
            dropdown_pbx_Click(sender, New EventArgs())
            Dim obj As New Settings
            obj.Show()
        Catch ex As Exception
        End Try
    End Sub

    'dropdown menu
    Private Sub dropdown_pbx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dropdown_pbx.Click
        Try
            If (dropdown_pnl.Size = New Size(76, 36)) Then
                dropdown_pnl.Size = New Size(76, 181)
            Else
                dropdown_pnl.Size = New Size(76, 36)
            End If
        Catch ex As Exception
        End Try
    End Sub

    'exit
    Private Sub exit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exit_btn.Click
        Try
            Me.Close()
            Me.Dispose()
            Form1.Dispose()
            GC.Collect()
        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region "Misc"
    'load
    Private Sub Identify_Model_2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            home_btn.Visible = False
            dropdown_pnl.Size = New Size(76, 36)
        Catch ex As Exception
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
#End Region

End Class