Imports System.Data.SqlClient
Imports System.Data
Imports System.Diagnostics
Imports System.Threading

Module SQL_Command

#Region "Main Commands"

    Public Connection_Flag As Boolean
    Public DatabaseName As String = ""
    Public conn As New SqlConnection
    Public cmd As SqlCommand
    Public res As Boolean
    Public conn_str As String = "null"
    Private temp_conn_string

#End Region

#Region "Commands"

    Public Function OpenDB() As Boolean
        Try
            If (conn.State = ConnectionState.Closed) Then
                conn.ConnectionString = conn_str
                conn.Open()
                res = True
            End If
        Catch ex As Exception
            res = False
        End Try
        Return res
    End Function

    Public Function Sql_Connection() As String
        Dim temp As String
        temp = conn.ConnectionString
        Return temp
    End Function

    'Clears RunningId
    Public Sub rm_RunningId()
        RunningId = Nothing
    End Sub
#End Region

#Region "Load"

    Public Function autoSqlConn() As Boolean
        Dim _result As Boolean
        Try
            For Each str As String In Settings.ComboBox1.Items
                Dim conn As New SqlConnection(str)
                Try
                    conn.Open()
                    conn_str = str
                    conn.Close()
                    Exit For
                Catch ex As Exception
                    conn.Close()
                End Try
            Next

            If conn_str Is Nothing Then
                _result = False
            Else
                _result = True
            End If
        Catch ex As Exception
            _result = False
        End Try
        Return _result
    End Function

    Public Sub setSqlConn()
        Try
            conn_str = Settings.ComboBox1.Items(0)
            'Dim load As Settings
            'load.conn_Btn_Click(sender:= e, New EventArgs)
        Catch ex As Exception
            conn_str = Nothing
        End Try
    End Sub

#End Region

#Region "Login Checks "

    'Check if username exist
    Public Function checkUsername(Optional ByVal userInput As String = Nothing) As Boolean
        Dim res As Boolean = False
        Try
            Using conn = New SqlConnection(conn_str)
                conn.Open()
                Dim query As String = "Select EmployeeName From dbo.UserMaster where UserName=@UserName"
                cmd = New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserName", userInput)
                Dim dr As SqlDataReader = cmd.ExecuteReader()
                
                If (dr.Read = True) Then
                    EmployeeName = dr.GetString(0)
                    res = True
                End If
                conn.Close()
            End Using
        Catch ex As Exception
        End Try
        Return res
    End Function

    'Check if Password exist
    Public Function checkUserPass(Optional ByVal userInput As String = Nothing) As Boolean
        Dim res As Boolean = False

        Try
            Using conn = New SqlConnection(conn_str)
                conn.Open()

                Dim query As String = "Select * From dbo.UserMaster where Password=@Password"
                cmd = New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Password", userInput)
                Dim dr As SqlDataReader = cmd.ExecuteReader()
                If (dr.Read = True) Then
                    res = True
                End If
                conn.Close()
            End Using
        Catch ex As Exception
        End Try
        Return res
    End Function

    'Check if UserName and Password Matches
    Public Function checkUser_and_Pass(Optional ByVal _userName As String = Nothing, Optional ByVal _passWord As String = Nothing) As Boolean
        Dim res As Boolean = False

        Try
            Using conn = New SqlConnection(conn_str)
                conn.Open()

                Dim query As String = "Select * From dbo.UserMaster where UserName=@UserName and Password=@Password"
                cmd = New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserName", _userName)
                cmd.Parameters.AddWithValue("@Password", _passWord)
                Dim dr As SqlDataReader = cmd.ExecuteReader()
                If (dr.Read = True) Then
                    res = True
                End If
                conn.Close()
            End Using
        Catch ex As Exception
        End Try
        Return res
    End Function

#End Region

    'Fast Scan= ModelScan(First Scan)-> StationScan(Third Scan)-> ScanPart(Second Scan)
    'Slow Scan= ModelScan(First Scan)-> ScanPart(Second Scan)-> StationScan(Third Scan)-> RescanPart(Fourth Scan)-> LastScan(Rescan Part)

#Region "First Scan / Scan Subline & Model "

    'Function to return ModelID And MasterModelID given ModelCode/ModeName
    Public Function GetModelId(Optional ByVal ValueFromFunc As String = Nothing) As String
        Try


            Dim returnValue As String = ValueFromFunc 'Model Name
            Using conn = New SqlConnection(conn_str)
                conn.Open()

                Dim query As String = "Select * From dbo.Model WHERE ModelCode = '" & returnValue.Trim & "'"
                cmd = New SqlCommand(query, conn)
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                ModelID = dt.Rows(0)("ModelID").ToString
                MasterModelID = dt.Rows(0)("MasterModelID").ToString

                'DataGrid1.DataSource = dt

                'Dim temp As String = returnValue

                'temp = String.Format("ModelCode = '{0}'", temp)

                ''DataTable.Rows(RowNo).ItemArray(columnNo).ToString()
                'Dim row() As DataRow = dt.Select(temp)
                'If row.Count > 0 Then
                '    ModelID = row(0)("ModelID").ToString
                '    MasterModelID = row(0)("MasterModelID").ToString
                '    returnValue = temp
                'End If
                conn.Close()
            End Using
        Catch ex As Exception
            conn.Close()
        End Try
        Return ModelID
    End Function

    'Function to return lineID given LineCode/LineName
    Public Function GetLineID(Optional ByVal ValueFromFunc As String = Nothing) As String
        Dim returnValue As String = ValueFromFunc 'LineCode/LineName
        Using conn = New SqlConnection(conn_str)
            conn.Open()

            Dim query As String = "Select * From dbo.Line"
            cmd = New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            'DataGrid2.DataSource = dt

            Dim temp As String = returnValue

            temp = String.Format("LineCode = '{0}'", temp)

            'DataTable.Rows(RowNo).ItemArray(columnNo).ToString()
            Dim row() As DataRow = dt.Select(temp)
            If row.Count > 0 Then
                temp = row(0).Item("LineID").ToString
                returnValue = temp
            End If
            conn.Close()
        End Using
        LineID = returnValue 'Passing to Main function
        Return LineID
    End Function

    'Function to check if Model and Line ID Matches
    Public Function Model_and_Line_Check(ByVal ModelID, ByVal LineID) As Boolean
        Dim res As Boolean = False

        Try
            conn = New SqlConnection(conn_str)
            Dim query As String = "Select * From dbo.MasterBOM where ModelID=@ModelID and LineID=@LineID and MasterModelID=@MasterModelID"
            conn.Open()
            cmd = New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ModelID", ModelID)
            cmd.Parameters.AddWithValue("@LineID", LineID)
            cmd.Parameters.AddWithValue("@MasterModelID", MasterModelID)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                res = True
            End If
            conn.Close()
        Catch ex As Exception
            conn.Close()
        End Try
        Return res
    End Function

    'Function to get ScheduleID and ProductionId
    'This will check if the ProductionStatus = "Started". Else it will not run at all
    Public Function GetScheduleID_and_ProductionId() As Boolean
        Dim res As Boolean = False

        Try
            conn = New SqlConnection(conn_str)
            conn.Open()
            Dim query As String = String.Format("Select * From [dbo].[Schedule] Where LineID=@LineID and MasterModelID=@MasterModelID and ModelID=@ModelID and ProductionStatus=@ProductionStatus")
            cmd = New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ModelID", ModelID)
            cmd.Parameters.AddWithValue("@LineID", LineID)
            cmd.Parameters.AddWithValue("@MasterModelID", MasterModelID)
            cmd.Parameters.AddWithValue("@ProductionStatus", ProductionStatus)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If (dr.Read = True) Then
                Dim row As DataRow() = dt.Select("[MasterModelID] = '" & MasterModelID & "' AND [ProductionStatus] = '" & ProductionStatus & "' AND [ModelID] = '" & ModelID & "' AND [LineID] = '" & LineID & "'")
                If row.Count > 0 Then
                    ScheduleID = row(0).Item("ScheduleID").ToString
                    ProductionId = row(0).Item("ProductionId").ToString
                    res = True
                End If
            End If
            conn.Close()
        Catch ex As Exception
            conn.Close()
        End Try
        Return res
    End Function

#End Region

#Region "Second Scan / Scan Part & AssemblyQty "

    'STEP 1'
    'This is the part where you input PartNo and AssemblyQty (eg: K1KY03BA0799,300) 
    'Get Part ID from part.dbo
    Public Function GetPartID() As Boolean
        Try
            Using conn = New SqlConnection(conn_str)
                Dim query As String = "Select * From dbo.Part"
                cmd = New SqlCommand(query, conn)
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                Dim temp As String = PartNo

                temp = String.Format("PartNo = '{0}'", temp)
                Dim row() As DataRow = dt.Select(temp)
                If row.Count > 0 Then
                    temp = row(0).Item("PartID").ToString
                    PartID = temp
                    Return True
                Else : Return False
                End If
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    'Check if PartID is in PartID column or OrPartID1 or orPartID2
    Public Sub CheckPartID()
        Try
            Dim temp As String = PartID
            Using conn = New SqlConnection(conn_str)
                conn.Open()
                Dim dr As SqlDataReader

                Dim query = "Select * from dbo.MasterBOM where PartID=@PartID"
                cmd = New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@PartID", temp)
                dr = cmd.ExecuteReader()
                If (dr.Read = True) Then
                    PartID = temp
                End If
                If (dr.Read = False) Then
                    Dim query1 = "Select * from dbo.MasterBOM where OrPartID1=@OrPartID1"
                    Dim cmd1 = New SqlCommand(query1, conn)
                    cmd1.Parameters.AddWithValue("@OrPartID1", temp)
                    dr = cmd1.ExecuteReader()
                    If (dr.Read = True) Then
                        OrPartID1 = temp
                        OrPartID1_bool = True
                    End If
                    If (dr.Read = False) Then
                        Dim query2 = "Select * from dbo.MasterBOM where OrPartID2=@OrPartID2"
                        Dim cmd2 = New SqlCommand(query2, conn)
                        cmd2.Parameters.AddWithValue("@OrPartID2", temp)
                        dr = cmd2.ExecuteReader()
                        If (dr.Read = True) Then
                            OrPartID2 = temp
                            OrPartID2_bool = True
                        End If
                        If (dr.Read = False) Then
                            Dim query3 = "Select * from dbo.MasterBOM where OrPartID3=@OrPartID3"
                            Dim cmd3 = New SqlCommand(query3, conn)
                            cmd3.Parameters.AddWithValue("@OrPartID3", temp)
                            dr = cmd3.ExecuteReader()
                            If (dr.Read = True) Then
                                OrPartID3 = temp
                                OrPartID3_bool = True
                            End If
                        End If
                    End If
                End If
            End Using
        Catch ex As Exception
        End Try
    End Sub

    'Get MasterStationID And AssemblyRef(using LineID , PartID and ModelID) from dbo.MasterBOM
    Public Function GetMasterStationID() As String
        Dim rtnVal As String = ""
        Dim temp_str As String = ""
        Dim tmp As String = ""
        Try

            Using conn = New SqlConnection(conn_str)
                conn.Open()

                Dim temp_partID As String = PartID

                Dim query As String = "Select Top 1 MasterStationId FROM dbo.MasterBOM WHERE "
                query += "ModelID='" & ModelID & "' " 'And MasterModelID='" & MasterModelID & "' "
                query += "And LineID='" & LineID & "' "
                query += "And PartID='" & temp_partID & "' "
                query += "or OrPartID1='" & temp_partID & "' "
                query += "or OrPartID2='" & temp_partID & "' "
                query += "or OrPartID3='" & temp_partID & "'"


                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(query, conn)
                da.Fill(dt)
                'Dim row() As DataRow = dt.Select("MasterStationId") 'MasterStationId = dr("MasterStationId").ToString
                For Each station As DataRow In dt.Rows() 'dr("MasterStationId")
                    temp_str = station.Item("MasterStationId").ToString()
                    tmp = GetMasterStationCode(temp_str)
                    rtnVal += tmp + ", "
                Next
                'station_List.Add(tmp)
                conn.Close()
            End Using
        Catch ex As Exception
            conn.Close()
        End Try
        Return rtnVal
    End Function

    'Get Master Station Code (eg, E1, E2, ...)
    Public Function GetMasterStationCode(ByRef userinput As String) As String
        Dim rtVal As String = ""
        Try
            Using conn = New SqlConnection(conn_str)
                conn.Open()
                Dim query As String = "Select * From dbo.MasterStation where MasterStationId=@MasterStationId and LineID=@LineID"
                cmd = New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@MasterStationId", userinput)
                cmd.Parameters.AddWithValue("@LineID", LineID)
                Dim dr As SqlDataReader = cmd.ExecuteReader()
                dr.Read()
                If (dr.Read = True) Then
                    'MasterStationCode = dr("MasterStationCode").ToString
                    rtVal = dr("MasterStationCode").ToString
                End If
                conn.Close()
            End Using
        Catch ex As Exception
            conn.Close()
        End Try
        Return rtVal
    End Function

    'Just Make Sure MasterStationCode exists
    Public Function CheckMasterStationCode() As Boolean
        Dim res As Boolean
        Try
            Using conn = New SqlConnection(conn_str)
                conn.Open()
                Dim query As String = "Select * From dbo.MasterStation where MasterStationCode=@MasterStationCode"
                cmd = New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@MasterStationCode", MasterStationCode)
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader()
                If (dr.Read = True) Then
                    res = True
                Else
                    res = False
                End If
                conn.Close()
            End Using
        Catch ex As Exception
            conn.Close()
        End Try
        Return res
    End Function

    'Checks if the Item has been Scanned before. If true User is unable to Proceed.
    Public Function CheckRunningId() As Boolean
        Dim Res As Boolean
        Dim query As String
        Try
            Using conn = New SqlConnection(conn_str)
                conn.Open()
                query = "Select Count(*) From dbo.ProductionStation where RunningId='" & RunningId & "' and PartID='" & PartID & "'" 'Qty=@Qty
                cmd = New SqlCommand(query, conn)
                'cmd.Parameters.AddWithValue("@RunningId", RunningId)
                'cmd.Parameters.AddWithValue("@PartID", PartID)
                'cmd.Parameters.AddWithValue("@Qty", ScannedPartQty)
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader()
                If (dr.Read) Then
                    If dr.Item(0).ToString > 0 Then
                        Res = False
                    Else
                        Res = True
                    End If
                Else
                    Res = False
                End If
                conn.Close()
            End Using
        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message)
        End Try
        Return Res
    End Function

#End Region

#Region "Third Scan / Scan Station "

    'STEP 2'
    'Check if userInput = MasterBOMId is found in the database
    'Added extra function for OrPartd 1,2,3
    Public Function CheckStation(Optional ByRef userInput As String = Nothing) As Boolean
        Dim result As Boolean = False
        Try
            Using conn = New SqlConnection(conn_str)
                conn.Open()

                Dim query = "Select MasterStationId FROM dbo.MasterStation WHERE"

                query += " MasterStationCode='" & userInput & "' "
                query += "And LineID='" & LineID & "'"

                cmd = New SqlCommand(query, conn)
                Dim dr As SqlDataReader = cmd.ExecuteReader()
                dr.Read()
                If (dr.Read = True) Then
                    MasterStationId = dr("MasterStationId").ToString
                    result = True
                Else
                    result = False
                End If

                'Dim query As String = "Select * From dbo.MasterBOM where MasterBOMId=@MasterBOMId and MasterModelID=@MasterModelID and LineID=@LineID and MasterStationID=@MasterStationID and ModelID=@ModelID and PartID=@PartID"
                'cmd = New SqlCommand(query, conn)
                'cmd.Parameters.AddWithValue("@MasterBOMId", userInput)
                'cmd.Parameters.AddWithValue("@MasterModelID", MasterModelID)
                'cmd.Parameters.AddWithValue("@LineID", LineID)
                'cmd.Parameters.AddWithValue("@ModelID", ModelID)
                'cmd.Parameters.AddWithValue("@PartID", PartID)
                'cmd.Parameters.AddWithValue("@MasterStationID", MasterStationId)
                'Dim dr As SqlDataReader
                'dr = cmd.ExecuteReader()
                'dr.Read()
                'If (dr.Read = True) Then
                '    res = True
                '    MasterBOMId = userInput
                '    PartID = temp_PartID
                'End If
            End Using
        Catch ex As Exception
        End Try
        Return result
    End Function

    'Only Check if Station Matches MasterBOMId
    Public Function getMasterBOMId() As Boolean
        Dim result As Boolean
        Try
            Using conn = New SqlConnection(conn_str)
                conn.Open()
                Dim temp_partID As String = PartID

                Dim query As String = "Select MasterBOMId FROM dbo.MasterBOM WHERE PartID=@Part OR OrPartID1=@Part OR OrPartID2=@Part OR OrPartID3=@Part"
                query += " And LineID='" & LineID & "' "
                query += "And ModelID='" & ModelID & "' "
                query += "And MasterModelID='" & MasterModelID & "' "
                query += "And MasterStationID='" & MasterStationId & "'"

                cmd = New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Part", temp_partID)
                Dim dr As SqlDataReader = cmd.ExecuteReader()
                dr.Read()
                If (dr.Read = True) Then
                    result = True
                    MasterBOMId = dr("MasterBOMId").ToString
                Else
                    result = False
                End If

                'Dim query As String = "Select * From dbo.MasterBOM where MasterBOMId=@MasterBOMId and LineID=@LineID"
                'cmd = New SqlCommand(query, conn)
                'cmd.Parameters.AddWithValue("@MasterBOMId", userInput)
                'cmd.Parameters.AddWithValue("@LineID", LineID)
                'Dim dr As SqlDataReader
                'dr = cmd.ExecuteReader()
                'If (dr.Read = True) Then
                '    result = True
                '    MasterBOMId = userInput
                'End If
                'conn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return result
    End Function

#End Region

#Region "Fourth Scan / Rescan Part "

    'Step 3
    'Scan Part
    Public Function checkPartandStation(Optional ByRef userInput As String = Nothing) As Boolean
        Dim res As Boolean = False

        Try
            Using conn = New SqlConnection(conn_str)
                conn.Open()
                Dim query As String = "Select * From dbo.MasterBOM where MasterBOMId=@MasterBOMId and MasterModelID=@MasterModelID and LineID=@LineID and MasterStationID=@MasterStationID and ModelID=@ModelID and PartID=@PartID"
                cmd = New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@MasterBOMId", userInput)
                cmd.Parameters.AddWithValue("@MasterModelID", MasterModelID)
                cmd.Parameters.AddWithValue("@LineID", LineID)
                cmd.Parameters.AddWithValue("@ModelID", ModelID)
                cmd.Parameters.AddWithValue("@PartID", PartID)
                cmd.Parameters.AddWithValue("@MasterStationID", MasterStationId)
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader()

                If (dr.Read = True) Then
                    res = True
                End If
            End Using
        Catch ex As Exception
        End Try
        Return res
    End Function


#End Region

#Region "Last Scan"

    'Generate a UUID for the current top up Session
    Public Function GetFinalProductionId() As String
        Dim temp As String = ""
        Try
            Dim myuuid As Guid = Guid.NewGuid()
            temp = myuuid.ToString.ToUpper()
        Catch ex As Exception
        End Try
        Return temp
    End Function

    'This will insert the data after finishing the topup process into the dbo.ProductionStation table
    Public Function UpdateProductionStation() As Boolean
        Dim res As Boolean = False
        Try
            Using conn = New SqlConnection(conn_str)
                conn.Open()

                'Current Time
                Dim temp_time As String = getTime() 'System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                Dim _status As String = "1"
                Dim query As String = "Insert into dbo.ProductionStation (ProductionStationId, ScheduleID, MasterBOMId, ProductionId, PartID, Qty, TDate, Status, RunningId, UserName) values(@ProductionStationId, @ScheduleID, @MasterBOMId, @ProductionId, @PartID, @Qty, @TDate, @Status, @RunningId, @UserName)"
                Dim Qty As Int32 = Convert.ToInt32(ScannedPartQty)

                'Data insert based on where the values are stored.
                'Some names might not match the datatable
                cmd = New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ProductionStationId", ProductionStationId)
                cmd.Parameters.AddWithValue("@ScheduleID", ScheduleID)
                cmd.Parameters.AddWithValue("@MasterBOMId", MasterBOMId)
                cmd.Parameters.AddWithValue("@ProductionId", ProductionId)
                cmd.Parameters.AddWithValue("@PartID", PartID)
                cmd.Parameters.AddWithValue("@Qty", Qty)
                cmd.Parameters.AddWithValue("@TDate", temp_time)
                cmd.Parameters.AddWithValue("@Status", _status)
                cmd.Parameters.AddWithValue("@RunningId", RunningId)
                cmd.Parameters.AddWithValue("@UserName", UserID)

                'Execute the Insert data
                Dim i As Integer = cmd.ExecuteNonQuery()

                If (i = 0) Then
                    res = False
                Else
                    res = True
                End If
                conn.Close()
            End Using
        Catch ex As Exception
            conn.Close()
        End Try
        Return res
    End Function



#End Region

#Region "New Using Functions"

    'Time
    Public Function getTime() As String
        Dim timeRes As String = ""
        Try
            Dim zone As TimeZone = TimeZone.CurrentTimeZone
            Dim local As DateTime = zone.ToLocalTime(DateTime.Now)
            timeRes = local.ToString("yyyy/MM/dd HH:mm:ss")
        Catch ex As Exception
        End Try
        Return timeRes
    End Function

    'Create LogTable of Parts, Models And Stations
    Public Function chckQry() As DataTable
        Dim dt As New DataTable
        Try
            Dim temp_modelID = ModelID '6778CF19-DDE7-47B7-B2EF-5686212396E2
            Dim temp_LineID = LineID 'A0EFE197-E2D5-40F4-93E0-51B15D30312Dl
            Dim temp_PartID = PartID
            Using conn = New SqlConnection(conn_str)
                'conn.Open()
                Dim query As String = "SELECT [MasterBOMId],"
                query += "(SELECT Top 1 [MasterStationCode] FROM [PCC].[dbo].[MasterStation] WHERE [MasterStationId] = [MasterBOM].[MasterStationId]) AS [MasterStationCode],"
                query += "(Select [PartNo] From [PCC].[Dbo].[Part] Where [Part].[PartID] = [PCC].[dbo].[MasterBOM].[PartID]) AS [PartNo],"
                query += "(SELECT [PartNo] FROM [PCC].[dbo].[Part] WHERE [Part].[PartID] = [PCC].[dbo].[MasterBOM].[OrPartID1]) AS [OrPartNo1],"
                query += "(SELECT [PartNo] FROM [PCC].[dbo].[Part] WHERE [Part].[PartID] = [PCC].[dbo].[MasterBOM].[OrPartID2]) AS [OrPartNo2],"
                query += "(SELECT [PartNo] FROM [PCC].[dbo].[Part] WHERE [Part].[PartID] = [PCC].[dbo].[MasterBOM].[OrPartID3]) AS [OrPartNo3],"
                query += "[PartID],[ModelID],[OrPartID1],[OrPartID2],[OrPartID3],[MasterStationId]"
                query += "From [PCC].[Dbo].[MasterBOM] "
                query += "Where LineID = '" & temp_LineID & "' And ModelID = '" & temp_modelID & "' "
                'query += "And PartID = '" & temp_PartID & "' or OrPartID1 = '" & temp_PartID & "' "
                'query += "or OrPartID2 = '" & temp_PartID & "' or OrPartID3 = '" & temp_PartID & "'"

                'query += "Convert(uniqueidentifier,[LineID]) = '" & temp_LineID & "' And CONVERT(uniqueidentifier,[ModelID]) = '" & temp_modelID & "' "
                'query += "WHERE CONVERT(uniqueidentifier,[ModelID]) = '" & temp_modelID & "' "
                'query += "AND Convert(uniqueidentifier,[LineID]) = '" & temp_LineID & "'"


                Dim da As New SqlDataAdapter(query, conn)
                da.Fill(dt)
            End Using
        Catch ex As SqlException
            'MessageBox.Show(ex.Message)
        End Try
        Return dt
    End Function

    'Part Scan
    Public Function prtScan(ByRef _part As String) As String
        Dim testStr As String = ""
        Try
            testStr = ""
            For Each station As DataRow In checkTheDb.Rows() 'checkTheDb.Select(query)
                testStr += station("StationCode").ToString
                testStr += ", "
            Next
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Return testStr
    End Function

    'Gets = MasterStationCode and PartID
    Public Function get_Mstncode_PrtID(ByRef _PartNo As String) As Boolean
        station_List = ""
        Try
            'tmpStationDT = checkTheDb.Clone
            'User Input is PartNo
            Dim query As String = String.Format("ModelID = '{1}' AND PartNo = '{0}' OR OrPartNo1 = '{0}' OR OrPartNo2 = '{0}' OR OrPartNo3 = '{0}'", _PartNo, ModelID)
            Dim foundRows() As DataRow = checkTheDb.Select(query)
            For Each row As DataRow In foundRows
                station_List += row.Item("MasterStationCode").ToString
                station_List += "," + " "

                If _PartNo = row.Item("PartNo").ToString Then
                    PartID = row.Item("PartID").ToString
                ElseIf _PartNo = row.Item("OrPartNo1").ToString Then
                    PartID = row.Item("OrPartID1").ToString
                ElseIf _PartNo = row.Item("OrPartNo2").ToString Then
                    PartID = row.Item("OrPartID2").ToString
                ElseIf _PartNo = row.Item("OrPartNo3").ToString Then
                    PartID = row.Item("OrPartID3").ToString
                End If
            Next
            station_List = station_List.Trim().Substring(0, station_List.Length - 2)
            Return True



            'For Each Item As DataRow In checkTheDb.Select("[PartNo]='" & _PartNo & "'")
            '    temp += Item.Item("MasterStationCode").ToString
            '    temp += ","
            '    If _PartNo = Item.Item("PartNo").ToString Then
            '        PartID = Item.Item("PartID").ToString
            '    End If
            'Next

            'For Each item As DataRow In checkTheDb.Select(query) '"[PartNo]='" & _PartNo & "'"
            '    temp += item.Item("StationCode").ToString 
            '    temp += ","
            '    ''To get PartId which is Which
            '    'If _PartNo = item.Item("PartNo").ToString Then
            '    '    PartID = item.Item("PartID").ToString
            '    'ElseIf _PartNo = item.Item("PartID").ToString Then

            '    'End If
            '    'tmpStationDt.Rows.Add(item)
            'Next

            'For Each rw As DataRow In tmpStationDt.Select("[StationCode]='" & 12 & "'")
            '    'Buat dekt function lain
            '    'to get BOMID, Stationid and the rest.
            'Next

        Catch ex As Exception
            Return False
        End Try
    End Function

    'Get MasterBomId
    Public Function get_MstBOMID_(ByRef _MasterStationCode) As Boolean
        Dim res As Boolean = False
        Try
            Dim query As String = String.Format("MasterStationCode = '{0}' AND PartNo = '{1}' OR OrPartNo1 = '{1}' OR OrPartNo2 = '{1}' OR OrPartNo3 = '{1}'", _MasterStationCode, PartNo)
            Dim foundRows() As DataRow = checkTheDb.Select(query)
            If foundRows.Count > 0 Then
                For Each row As DataRow In foundRows
                    If _MasterStationCode = row.Item("MasterStationCode").ToString Then
                        MasterBOMId = row.Item("MasterBOMId").ToString
                    End If
                    res = True
                Next
            End If
        Catch ex As Exception
        End Try
        Return res
    End Function

    'Remove Part TopUp Status From [ProductionStatus] Table
    'Used when user wants to TopUp to another subline or Remove The Part.
    Public Function removeTopUpPart_withRunningID() As Boolean
        Dim _Result As Boolean
        Dim PartID_guid As Guid = New Guid(PartID)
        Try
            Using conn = New SqlConnection(conn_str)
                Dim query = "Delete FROM ProductionStation WHERE RunningId = @RunningId AND PartID = @PartId"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("RunningId", RunningId)
                    cmd.Parameters.AddWithValue("@PartID", PartID_guid)
                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        _Result = True
                    Else
                        _Result = False
                    End If
                End Using
                conn.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return _Result
    End Function

#End Region

#Region " Testing Area "

    'testing
    Public Sub testing()
        Using conn = New SqlConnection(conn_str)
            conn.Open()


            Dim query As String = "Insert into dbo.testing values(@name, @age)"
            Dim test As String = "James"
            Dim test2 As String = "10"

            cmd = New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@name", test)
            cmd.Parameters.AddWithValue("@age", test2)


            'Execute the Insert data
            cmd.ExecuteNonQuery()
            conn.Close()

        End Using
    End Sub

    'Test Connection
    Public Function TestSqlConn() As Boolean
        Dim _result As Boolean = False
        Dim connThread As Thread = New Thread(AddressOf CheckConnections)
        connThread.Start()
        If connThread.Join(100000) Then
            If Not String.IsNullOrEmpty(conn_str) Then
                _result = True
            End If
        Else
            connThread.Abort()
        End If
        Return _result
    End Function

    'This is the Follow up Function of TestSqlConn
    Private Sub CheckConnections()
        For Each str As String In Settings.ComboBox1.Items
            temp_conn_string = str
            Dim Task1 As Thread = New Thread(AddressOf testConnFast)
            Task1.Start()
            If (Task1.Join(1000)) Then
                If Not String.IsNullOrEmpty(conn_str) Then
                    Exit For
                End If
            End If

            'Dim conn As New SqlConnection(str)
            'Try
            '    conn.Open()
            '    If (conn.State = ConnectionState.Open) Then
            '        conn_str = str
            '        conn.Close()
            '        Exit For
            '        'ElseIf (conn.State = ConnectionState.Connecting) Then
            '        '    conn.Close()
            '        '    Exit Try
            '    End If
            'Catch ex As Exception
            '    conn.Close()
            'End Try
        Next
    End Sub

    Private Sub testConnFast()
        Dim conn As New SqlConnection(temp_conn_string)
        Try
            conn.Open()
            If (conn.State = ConnectionState.Open) Then
                conn_str = temp_conn_string
                conn.Close()
                Exit Try
            End If
        Catch ex As Exception
            conn.Close()
        End Try
    End Sub

#End Region

End Module
