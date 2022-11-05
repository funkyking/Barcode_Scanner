Public Class Scan_SublineResult
    Public Property Subline_Station
    Private Sub Scan_SublineResult_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.Close()
    End Sub

    Private Sub sublineStn_Click(sender As Object, e As EventArgs) Handles sublineStn.Click
        sublineStn.Text = Subline_Station
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Scan_SublineResult_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        Me.Close()
    End Sub
End Class