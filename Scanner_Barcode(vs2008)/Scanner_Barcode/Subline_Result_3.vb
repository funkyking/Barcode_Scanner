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
        Me.Close()
    End Sub
End Class