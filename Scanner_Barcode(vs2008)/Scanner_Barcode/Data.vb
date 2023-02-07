Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

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
    Public ScannedPartQty As String = "0"
    Public AssemblyRef As String
    Public ProductionStationId As String 'Final UUID Output After Scan
    Public RunningId As String

    
    'Creates a public LogBook
    Public logTable As DataTable

    Public Function createLogBook() As DataTable
        Dim dt As New DataTable

        If (dt.Columns.Contains("RunningId") = False) Then
            ' Create columns in the DataTable.
            dt.Columns.Add("RunningId", GetType(String))
            dt.Columns.Add("UserID", GetType(String))
            dt.Columns.Add("PartNo", GetType(String))
            dt.Columns.Add("PartId", GetType(String))
            dt.Columns.Add("ScannedPartQty", GetType(String))
            dt.Columns.Add("ModelID", GetType(String))
            dt.Columns.Add("LineID", GetType(String))
            dt.Columns.Add("ProductionId", GetType(String))

        End If
        Return dt
    End Function

    Public Function updateLogBook(ByVal dt As DataTable) As DataTable
        Try
            ' Add rows with those columns filled in the DataTable.
            dt.Rows.Add(RunningId, UserID, PartNo, PartID, ScannedPartQty, ModelID, LineID, ProductionId)
        Catch ex As Exception
        End Try
        Return dt
    End Function

    'Simple function to delay the code process
    Public Sub wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub


End Module
