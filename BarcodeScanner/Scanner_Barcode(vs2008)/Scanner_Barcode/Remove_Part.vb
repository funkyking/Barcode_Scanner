Public Class Remove_Part

    'Main Event That Triggered by Enter Key
    Private Sub userInput_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles userInput.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                checkTheDb = chckQry()

                Dim res As Boolean = False
                Dim stn_res As Boolean = False

                rm_RunningId() 'clears runningId

                'Split the String to 3 inputs
                Dim strarr As String() = userInput.Text.Split(" ")
                RunningId = strarr(0)
                PartNo = strarr(1)
                ScannedPartQty = strarr(2)

                stn_res = get_Mstncode_PrtID(PartNo)

                If (stn_res = True) Then
                    res = removeTopUpPart_withRunningID()
                    If (res = True) Then
                        Dim passed As New Subline_Result_3
                        passed.BackColor = Color.LawnGreen
                        passed._top_lbl = "Part Removed"
                        passed._bot_lbl = "ID = " + PartNo
                        passed.Show()
                        PartID = Nothing
                        PartNo = Nothing
                        MasterBOMId = Nothing
                        Me.Close()
                    Else
                        Dim failed As New Subline_Result_3
                        failed.BackColor = Color.Red
                        failed._top_lbl = "Part Haven't TopUp"
                        failed._bot_lbl = "ID = " + PartNo
                        failed.Show()
                        checkTheDb.Dispose() 'Clears old Database
                        userInput.Text = Nothing
                        userInput.Focus()
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    'Close The form
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    'Closes This form
    Private Sub back_pbx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_pbx.Click
        Me.Close()
    End Sub

    'Remove the items in the textbox
    Private Sub rescan_pbx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rescan_pbx.Click
        Try
            userInput.Text = Nothing
            userInput.Focus()
        Catch ex As Exception
            userInput.Text = ""
            userInput.Focus()
        End Try
    End Sub

    Private Sub Remove_Part_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            mdl_lbl.Text = ModelCode
            sub_lbl.Text = LineCode
            username.Text = UserID
        Catch ex As Exception
        End Try
    End Sub
End Class