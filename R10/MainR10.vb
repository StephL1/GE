Module MainR10
    Public pieces_audited(6) As Integer
    Public whichln As Integer 'which line are we working on
    Public skidnum(6) As String
    Public fiscalwk           'what fiscal week are we on
    Public resnum(6) As Integer
    Public typename(6) As String
    Public mshift
    Public pcperbox(6) As Integer
    Public boxperskid(6) As Integer
    Dim i, mrow As Integer
    Public auditor_id(6) As String
    Public moperator(6) As String
    Public mline As Integer             'counter
    Public ifile As String
    Public mfile As String
    Public defectname(6, 60)
    Public defects(6, 60) As Integer
    Public skip_skidflag As Integer
    Public rstadd As ADODB.Recordset
    Public strcnn2 As String
    Public getd As String
    Dim fileReader As String
    Dim firstday As Date
    Dim tdate As Date
    Public donetime            'flag that we have change shift
    Public iip As Integer   'flag to go to lamptype 3 screen
    Public people_flag As String  'flag to determine auditor or operator
    Public status_flag As String     'flag to indicate if skid was good or hold
    Public start001(6) As DateTime      'when skid 001 began 
    Public lastmondayat7 As Date
    Public shiftrot(380, 5)         'array to hold shifts
    Public whichhr
    Public MinInsp As Integer
    Public distinctDefect(60) As Boolean
    Public distinctPieces As Integer
    Public total_num_defects As Integer


    Sub main()
        Dim mline, i As Integer
        Dim flen As Integer
        Dim istr(6) As String
        Dim rmdata As Integer           ' there will be 6 sequential pieces of data shift, auditor, operator, and type, skidnum, last time skid started at 001
        Dim dat As String
        Dim rstadd As ADODB.Recordset
        Dim strcnn2 As String
        Dim getd As String
        Dim temptype

        'startup - initialize all variables, will need to make module with main subroutine and start application
        'change_shift()

        'open all 6 info_ lines to get variables when program starts up
        'ifile = "c:\quality_parameters\line"        '

        For mline = 1 To 1
            'ifile = "q:\gcommon\quality\quality_parameters\line" + Trim(Str(i)) + "\info_" + Trim(Str(i)) + ".txt"
            ifile = "c:\quality_parameters\line" + Trim(Str(mline)) + "\info_" + Trim(Str(mline)) + ".txt"
            fileReader = My.Computer.FileSystem.ReadAllText(ifile)
            'MsgBox(fileReader)
            flen = Len(fileReader)
            rmdata = 1
            dat = ""
            For i = 1 To flen
15610:          If Mid$(fileReader, i, 1) = Chr(13) Then istr(rmdata) = dat$ : rmdata = rmdata + 1 : i = i + 2 : dat$ = "" : If rmdata > 6 Then i = flen : GoTo 15630
15620:          dat$ = dat$ + Mid$(fileReader, i, 1)
15630:      Next
            mshift = istr(1)
            auditor_id(mline) = Trim(istr(2))
            moperator(mline) = Trim(istr(3))
            typename(mline) = Trim(istr(4))
            skidnum(mline) = Trim(istr(5))
            start001(mline) = Convert.ToDateTime(istr(6))
            FileClose()

            'get resournum for typename
            getd$ = "SELECT * FROM Som_Resource_Spec where Type_name = '" + typename(mline) + "'"
            ' Open connection.
            strcnn2 = "Provider=sqloledb.1;" & _
              "Data Source=SOMKYDB01CIGE;Initial Catalog=Som_Database;User Id=som_database;Password=som_pa55w0rd; "
otable:
            ' Open table.
            rstadd = New ADODB.Recordset

200:        ''   rstadd.Open(getd, strcnn2, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, )     ', , , adCmdText)

            ''i = rstadd.RecordCount
            ''If i = 0 Then MsgBox("This Glass Type does not exist in Database. Please contact Quality Manager.", , "ERROR") : End

            ''resnum(mline) = rstadd.Fields("Resource_number").Value
            ''pcperbox(mline) = rstadd.Fields("Pcs_per_box").Value
            ''boxperskid(mline) = rstadd.Fields("Boxes_per_skid").Value
            ''rstadd.Close()

            'get defects for this resourcenumber
            getd$ = "SELECT * FROM Som_Defects_Spec WHERE Resource_number = " + Trim(Str$(resnum(mline))) + " and Line = " + Trim(Str$(mline)) + " ORDER by Defect_rank"

            ' Open connection.
            strcnn2 = "Provider=sqloledb.1;" & _
              "Data Source=SOMKYDB01CIGE;Initial Catalog=Som_Database;User Id=som_database;Password=som_pa55w0rd; "
            ' Open table.
            ''rstadd = New ADODB.Recordset
            ''rstadd.Open(getd, strcnn2, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, )     ', , , adCmdText)

            ''i = rstadd.RecordCount
            ''If i = 0 Then MsgBox("NO DEFECTS are found for the Glass Type  " + typename(mline) + ". Please contact Quality Manager.", , "ERROR") : End


            i = 2 'start filling defect array with placement 2, 1=Good
            defectname(mline, 1) = "Good"

            'get defects by rank order for this type and line
            'from Som_Defects_Spec
            ''Do While Not rstadd.EOF Or i = 61
            ''    temptype = rstadd.Fields("Meas_type").Value
            ''    If Trim(temptype) = "R10" Then defectname(mline, i) = rstadd.Fields("Defect_name").Value : i = i + 1
            ''    rstadd.MoveNext()
            ''Loop
            ''rstadd.Close()

        Next mline

        ' GoTo endread
fillinshift:
        'fill in shiftrot array for auto shift change
        ''        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("c:\quality_parameters\ProductionMaster_shift.csv")
        ''            MyReader.TextFieldType = FileIO.FieldType.Delimited
        ''            MyReader.SetDelimiters(",")
        ''            Dim currentRow As String()
        ''            While Not MyReader.EndOfData
        ''                Try
        ''                    For i = 1 To 2              'read in first 2 rows
        ''                        currentRow = MyReader.ReadFields()
        ''                    Next i
        ''                    mrow = 1
        ''getnextrow:
        ''                    currentRow = MyReader.ReadFields()
        ''                    Dim currentField As String
        ''                    i = 1
        ''                    For Each currentField In currentRow
        ''                        'MsgBox(currentField)
        ''                        shiftrot(mrow, i) = currentField
        ''                        If shiftrot(mrow, i) = "" Then
        ''                            'end of file
        ''                            GoTo endread
        ''                        End If
        ''                        i = i + 1
        ''                        If i = 6 Then mrow = mrow + 1 : GoTo getnextrow
        ''                    Next
        ''                Catch ex As Microsoft.VisualBasic.
        ''                            FileIO.MalformedLineException
        ''                    MsgBox("Line " & ex.Message &
        ''                    "is not valid and will be skipped.")
        ''                End Try

        ''            End While
        ''        End Using
endread:
        FileClose()

        'read in minnumber to inpect
        ifile = "c:\quality_parameters\MinNumberR10Inspection.txt"
        fileReader = My.Computer.FileSystem.ReadAllText(ifile)
        MinInsp = Val(fileReader)
        FileClose()

        Selection.ShowDialog()

    End Sub
    Sub writeto_database()
        Dim findfirst As Integer
        Dim i As Integer
        Dim merror

        Dim rstadd As ADODB.Recordset
        Dim strcnn2 As String
        Dim getd As String
        Dim addflag As Integer

        addflag = 0

        On Error GoTo merr

        ' Open connection.
        strcnn2 = "Provider=sqloledb.1;" & _
         "Data Source=SOMKYDB01CIGE;Initial Catalog=Som_Database;User Id=som_database;Password=som_pa55w0rd; "
otable:
        ' Open table.
        rstadd = New ADODB.Recordset
        getd$ = "SELECT * FROM Som_Defects_R10 where Skid_number = '" + skidnum(whichln) + "'"

200:    rstadd.Open(getd, strcnn2, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, )     ', , , adCmdText)

        i = rstadd.RecordCount

        If skip_skidflag = 1 Then        'SKIP skid was chosen, come backfor f
            rstadd.Fields("Number_inspected").Value = pieces_audited(whichln)
            rstadd.Update()
            rstadd.Close()
            ' Open table.
            rstadd = New ADODB.Recordset
            getd$ = "SELECT * FROM Som_Skids where Skid_number = '" + skidnum(whichln) + "'"
            rstadd.Open(getd, strcnn2, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, )     ', , , adCmdText)
            i = rstadd.RecordCount
            rstadd.Fields("Skid_skipped").Value = True
            rstadd.Fields("Skid_end_time").Value = Now
            rstadd.Fields("Shift").Value = mshift
            rstadd.Fields("Auditor_ID").Value = auditor_id(mline)
            rstadd.Update()
            skip_skidflag = 0
            GoTo endwrite

        End If

        GoTo esub
merr:
        merror = Err()
        Resume Next

        'find skid number in R10 table
        'find skid and line number and write one line per defect
        'the first row will be the row which contains the skid number
        'write your first defect to this row
        'continue with the other rows
esub:
        findfirst = 0
        For i = 1 To 32
            If defects(whichln, i) <> 0 Then
                'find row that is started first
                'add number inspected, defect name, defect number
                If findfirst = 0 Then
                    rstadd.Fields("Number_inspected").Value = pieces_audited(whichln)
                    rstadd.Fields("Defect_name").Value = defectname(whichln, i)
                    rstadd.Fields("Defect_number").Value = defects(whichln, i)
                    rstadd.Fields("Shift").Value = mshift
                    'rstadd.Update()
                    findfirst = 1
                Else
                    'need to add new records
                    ''If addflag = 0 Then
                    rstadd.AddNew()
                    rstadd.Fields("Line").Value = whichln
                    rstadd.Fields("Resource_number").Value = resnum(whichln)
                    rstadd.Fields("Type_name").Value = typename(whichln)
                    rstadd.Fields("Skid_number").Value = skidnum(whichln)
                    rstadd.Fields("Date_entered").Value = Now    'original_time                 'Now or original now, will ask Aaron
                    rstadd.Fields("Shift").Value = mshift
                    rstadd.Fields("Number_inspected").Value = pieces_audited(whichln)
                    rstadd.Fields("Defect_name").Value = defectname(whichln, i)
                    rstadd.Fields("Defect_number").Value = defects(whichln, i)
                    rstadd.Fields("Inspector").Value = "sll"
                    addflag = 1
                    'rstadd.Update()
                    'End If

                End If
            End If

        Next
        rstadd.Update()

        'write data to skids
        rstadd = New ADODB.Recordset
        getd$ = "SELECT * FROM Som_Skids where Skid_number = '" + skidnum(whichln) + "'"
        rstadd.Open(getd, strcnn2, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, )     ', , , adCmdText)
        i = rstadd.RecordCount
        rstadd.Fields("Skid_skipped").Value = False
        rstadd.Fields("Skid_end_time").Value = Now
        rstadd.Fields("Shift").Value = mshift
        rstadd.Fields("Auditor_ID").Value = auditor_id(mline)
        rstadd.Fields("Orig_status").Value = status_flag
        rstadd.Update()

endwrite:
        rstadd.Close()

        'reinitalize defects array
        For i = 1 To 32
            defects(whichln, i) = 0
        Next
        status_flag = ""
    End Sub

    Sub start_newskid()
        Dim newd
        newd = DateAdd("n", -1, Now())
        'write to R10 datatable
        fiscalweek()
        On Error GoTo merr2

        ' Open connection.
        strcnn2 = "Provider=sqloledb.1;" & _
         "Data Source=SOMKYDB01CIGE;Initial Catalog=Som_Database;User Id=som_database;Password=som_pa55w0rd; "
otable:
        ' Open table.
        rstadd = New ADODB.Recordset
        getd$ = "SELECT * FROM Som_Defects_R10"     ' where Date_entered > '" + Str$(newd) + "'"""
        'getd$ = "SELECT * FROM " + Table$ + " WHERE dt_evnt_strt > '" + Str$(newd) + "' ORDER by dt_evnt_strt"

200:    rstadd.Open(getd, strcnn2, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, )

        i = rstadd.RecordCount
        'write to appropriate fields in R10 table
        rstadd.AddNew()
        rstadd.Fields("Line").Value = whichln
        rstadd.Fields("Resource_number").Value = resnum(whichln)
        rstadd.Fields("Type_name").Value = typename(whichln)
        rstadd.Fields("Skid_number").Value = skidnum(whichln)
        rstadd.Fields("Date_entered").Value = Now    'original_time                 'Now or original now, will ask Aaron
        rstadd.Fields("Defect_name").Value = "9999"                                 'default for new skid, before actual inspection has taken place 
        'original_time = Now
        rstadd.Update()
        rstadd.Close()

        'write to appropriate fields in skids table
        ' Open connection.
        strcnn2 = "Provider=sqloledb.1;" & _
         "Data Source=SOMKYDB01CIGE;Initial Catalog=Som_Database;User Id=som_database;Password=som_pa55w0rd; "

        ' Open table.
        rstadd = New ADODB.Recordset
        getd$ = "SELECT * FROM Som_Skids"           ' where Date_entered > '" + +Str$(newd) + "'"

        rstadd.Open(getd, strcnn2, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, )

        i = rstadd.RecordCount
        'write to appropriate fields in Skids table
        rstadd.AddNew()
        rstadd.Fields("Line").Value = whichln
        rstadd.Fields("Resource_number").Value = resnum(whichln)
        rstadd.Fields("Type_name").Value = typename(whichln)
        rstadd.Fields("Skid_number").Value = skidnum(whichln)
        'original_time = Now
        rstadd.Fields("Pcs_per_box").Value = pcperbox(whichln)
        rstadd.Fields("Boxes_per_skid").Value = boxperskid(whichln)
        rstadd.Fields("Boxes_on_skid").Value = boxperskid(whichln)
        rstadd.Fields("Skid_start_time").Value = Now

        rstadd.Update()
        rstadd.Close()

        'write new skid number to quality parameter files on Q
        write_parameters()

        'reinitalize variables for next audit for this line
        pieces_audited(whichln) = 0
        GoTo estart

merr2:
        Resume Next

estart:
    End Sub
    Sub fiscalweek()
        'skid number example  = "01-1-001"
        'two digit fiscal week - one digit line - three digit skid number

        'Dim fiscal                             'temp week storage
        Dim tempskid As Integer
        Dim tempskid2 As String
        Dim tempdate
        Dim sevenamtime

        sevenamtime = #7:00:00 AM#

        'what is our fiscal week
        fileReader = My.Computer.FileSystem.ReadAllText("C:\quality_parameters\FirstDayOfYear_FiscalWk.txt")
        firstday = Convert.ToDateTime(fileReader)
        tdate = Now
        fiscalwk = Format(Int(DateDiff("w", firstday, tdate) + 1), "0#")
        If Val(fiscalwk) > 52 Then MsgBox("Please update First Day of First Fiscal Week. The wrong date is being used.", , "ERROR") : End '20=yes and no, and vcritical sign

        'is the last time we reset to skid 1 > last mondayat7
        lastmondayat7 = DateAdd(DateInterval.Day, -(DatePart(DateInterval.Weekday, Now()) - 1), Now()) 'gives sunday, need to add 1 day
        lastmondayat7 = DateAdd("d", 1, lastmondayat7)
        tempdate = Format(lastmondayat7, "MM/dd/yyyy") + " " + sevenamtime
        lastmondayat7 = Convert.ToDateTime(tempdate)

        If start001(whichln) >= lastmondayat7 Then
            'increment skid by 1
            tempskid = Val(Right$(skidnum(whichln), 3) + 1)
            If tempskid < 100 Then tempskid2 = "0" + Trim(Str(tempskid))
            If tempskid < 10 Then tempskid2 = "00" + Trim(Str(tempskid))
            skidnum(whichln) = fiscalwk + "-" + Trim(Str(whichln)) + "-" + tempskid2
        Else
            'need to start with skid 1 
            skidnum(whichln) = fiscalwk + "-" + Trim(Str(whichln)) + "-001"      'starting back to 1st skid of fiscal week
            'write datetime stamp to file
            start001(whichln) = Now
            write_parameters()

        End If

    End Sub

    Sub write_parameters()
        Dim writevar
        Dim ifile
        Dim tempdate

        tempdate = Convert.ToString(start001(whichln))

        'ifile = "q:\gcommon\quality\quality_parameters\line" + Trim(Str(i)) + "\info_" + Trim(Str(i)) + ".txt"
        ifile = "c:\quality_parameters\line" + Trim(Str(whichln)) + "\info_" + Trim(Str(whichln)) + ".txt"

        writevar = mshift + vbCrLf + auditor_id(whichln) + vbCrLf + moperator(whichln) + vbCrLf + typename(whichln) + vbCrLf + skidnum(whichln) + vbCrLf + start001(whichln) + vbCrLf
        My.Computer.FileSystem.WriteAllText(ifile, writevar, vbFalse)
        FileClose()
    End Sub
    Sub change_shift()
        'automatically changes shift based on time

        Dim CurrDatTim As Date = Now   ' Current date and time.
        Dim searchdate As Date = CurrDatTim.Date   ' At midnight.
        Dim finddate
        Dim n As Integer
        Dim writevar
        Dim mlen

        If donetime = 1 Then GoTo endchg

MSTART:
        finddate = Trim(Left(Convert.ToString(searchdate), 10))
        mlen = Len(finddate)
        If mlen = 9 Then
            finddate = Left(finddate, 5) + Right(finddate, 2)
        Else
            finddate = Left(finddate, 6) + Right(finddate, 2)
        End If
        whichhr = Hour(TimeOfDay)
        For n = 1 To 370
            If finddate = shiftrot(n, 1) Then
                If whichhr = 7 Then mshift = shiftrot(n, 2) : donetime = 1
                If whichhr = 15 Then mshift = shiftrot(n, 3) : donetime = 1
                If whichhr = 23 Then mshift = shiftrot(n, 4) : donetime = 1
                GoTo contchg
            End If
        Next
contchg:
        ''If donetime = 0 Then
        ''    'we did not find the date in our array, something wrong
        ''    MsgBox("Error- Auto Shift Change not working. Please check PRODUCTIONMASTER File", vbOKOnly, "ERROR")
        ''    GoTo endchg
        ''End If

        'write to quality parameter files
        'ifile = "q:\gcommon\quality\quality_parameters\line" + Trim(Str(i)) + "\info_" + Trim(Str(i)) + ".txt"
        For n = 1 To 6
            ifile = "c:\quality_parameters\line" + Trim(Str(n)) + "\info_" + Trim(Str(n)) + ".txt"
            writevar = mshift + vbCrLf + auditor_id(n) + vbCrLf + moperator(n) + vbCrLf + typename(n) + vbCrLf + skidnum(n) + vbCrLf + start001(n) + vbCrLf
            My.Computer.FileSystem.WriteAllText(ifile, writevar, vbFalse)
            FileClose()
        Next
        R10.btnShift.Text = "Shift " + mshift
endchg:
        donetime = 1
    End Sub

    Public Sub Distinct_Pieces_Audited(i As Integer)

        If (Not distinctDefect(i)) Then
            distinctPieces = distinctPieces + 1
        End If
        distinctDefect(i) = True

    End Sub
End Module
