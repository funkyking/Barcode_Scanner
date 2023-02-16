Public Class Subline_Result_3


    Friend Property _top_lbl() As String
        Get
            Return _top.Text
        End Get
        Set(ByVal value As String)
            _top.Text = value
        End Set

    End Property

    Friend Property _bot_lbl() As String
        Get
            Return _bot.Text
        End Get
        Set(ByVal value As String)
            _bot.Text = value
        End Set

    End Property

    Private Sub Subline_Result_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Me.Dispose()
    End Sub

    'When Event Load
    Private Sub Subline_Result_3_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        closeTimer.Enabled = True
    End Sub

    'Closing the form
    Private Sub closeTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeTimer.Tick
        Me.Dispose()
        Me.Close()
    End Sub
End Class