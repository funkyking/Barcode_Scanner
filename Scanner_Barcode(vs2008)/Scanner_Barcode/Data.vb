Module Data

    'Storing Details
    Public UserID As String
    Public UserPass As String
    Public ModelCode As String 'Subline
    Public LineCode As String 'Subline Detail

    'Storing the Crucial Details
    Public PartID As String
    Public PartNo As String
    Public ModelID As String
    Public LineID As String
    Public MasterStationId As String
    Public MasterStationCode As String
    Public ProductionId As String
    Public ScheduleID As String
    Public MasterModelID As String
    Public MasterBOMId As String
    Public ModelQty As String 'This is during part Scan
    Public ProductionStatus As String = "Started" 'Only Started Status is able to Continue
    Public ActualQty As String = "0"
    Public AssemblyRef As String
    Public FinalTopUpId As String




    'Simple function to delay the code process
    Public Sub wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub


End Module
