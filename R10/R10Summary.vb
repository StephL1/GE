'Jyrone Parker  
Imports System.Runtime.InteropServices
'Imports Microsoft.Office.Interop
Imports System.Net.Mime.MediaTypeNames
Imports System.Data
'Imports ESRI.ArcGIS.Output
'Imports ESRI.ArcGIS.esriSystem
Imports System.Collections
Imports System.Drawing.Printing

Public Class R10

    Dim next_clicked As Boolean 'flag for if the next button is clicked

    Dim i As Integer
    Dim shift As Char
    Dim it As Integer

    Dim original_time

    Dim pksource As PaperSource
    Private WithEvents docToPrintWhite As New Printing.PrintDocument
    Private WithEvents docToPrintRed As New Printing.PrintDocument

    'fake variables for skid ticket
    Public resource_name
    Public resource_number
    Public pieces_per_box
    Public skid_number
    'if skid is good, beginning and ending status is same
    'if scrap, scrap everything
    'after buttons are pressed write defects to R10 table 
    'don't keep the button names static, get names from defects spec table and order by rank

    Private Sub Quit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close() 'simply closes the app

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized 'maximizes the form

        'Move (System.Windows.Forms.Screen.Width - R10.Width) / 2, (Screen.Height = R10.Height) / 2 + 500

        'pieces_audited(whichln) = 0 'intialize to 0
        'pieces_audited(whichln) = 20 'fake initialize


        'fill in heading line and Skid number you are working with
        btnShift.Text = "Shift " + mshift
        btnAuditor.Text = "Auditor " + auditor_id(whichln)
        btnOperator.Text = "Operator " + moperator(whichln)
        btnType.Text = typename(whichln)

        'fill in buttons from defectname(whichln,i)
        'this not working???

        dbutton0.Text = defectname(whichln, 1)
        dbutton1.Text = defectname(whichln, 2)
        dbutton2.Text = defectname(whichln, 3)
        dbutton3.Text = defectname(whichln, 4)
        dbutton4.Text = defectname(whichln, 5)
        dbutton5.Text = defectname(whichln, 6)
        dbutton6.Text = defectname(whichln, 7)
        dbutton7.Text = defectname(whichln, 8)
        dbutton8.Text = defectname(whichln, 9)
        dbutton9.Text = defectname(whichln, 10)
        dbutton10.Text = defectname(whichln, 11)
        dbutton11.Text = defectname(whichln, 12)
        dbutton12.Text = defectname(whichln, 13)
        dbutton13.Text = defectname(whichln, 14)
        dbutton14.Text = defectname(whichln, 15)
        dbutton15.Text = defectname(whichln, 16)

        'status_bar.Text() = "Status "
        skid_box.Text() = "                                                          LINE " + Str(whichln) + "                    SKID NUMBER " + skidnum(whichln)



        lblnumaudit.Text() = pieces_audited(whichln) 'shows number of pieces audited

        resource_name = "Red"

        'info_bar.Text() = "Shift " + shift.ToString() + " " + "auditor " + auditor_id.ToString()

        'changeOver = False


        'before increment, check sensor, see if running same type and fiscal week hasn't changed, changeover equals false, 

        'start 1 at 7 am every monday new fiscal week
        'type name mb348...
        'fix fiscal week routine

    End Sub

    Private Sub broke_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbutton0.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 1) = defects(whichln, 1) + 1
        lblnumaudit.Text = pieces_audited(whichln)
    End Sub

    Private Sub Chipped_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbutton1.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 2) = defects(whichln, 2) + 1
        lblnumaudit.Text = pieces_audited(whichln)
    End Sub

    Private Sub Blister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbutton2.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 3) = defects(whichln, 3) + 1
        lblnumaudit.Text = pieces_audited(whichln)
    End Sub

    Private Sub Innerledge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbutton4.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 5) = defects(whichln, 5) + 1
        lblnumaudit.Text = pieces_audited(whichln)
    End Sub

    Private Sub Key_Seal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbutton5.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 6) = defects(whichln, 6) + 1
        lblnumaudit.Text = pieces_audited(whichln)
    End Sub

    Private Sub Good_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Good.Click

        If pieces_audited(whichln) < MinInsp Then MsgBox("Sample Less than 20") : GoTo egood
        status_flag = "Good"
        writeto_database()

        'Ticket.Print()
        docToPrintWhite.DefaultPageSettings.Landscape = True 'sets the page to print landscape
        docToPrintWhite.Print() 'print the document

        'White print ticket logic
        'PrintDialog1.AllowSomePages = True

        ' Show the help button.
        'PrintDialog1.ShowHelp = True

        ' Set the Document property to the PrintDocument for  
        ' which the PrintPage Event has been handled. To display the 
        ' dialog, either this property or the PrinterSettings property  
        ' must be set 
        'PrintDialog1.Document = docToPrintWhite

        'Dim result As DialogResult = PrintDialog1.ShowDialog()

        ' If the result is OK then print the document. 
        'If (result = DialogResult.OK) Then
        'docToPrintWhite.Print()
        'End If
        start_newskid()
        Me.Dispose()
        R10Part2.Close()
        R10Part3.Close()
        Selection.Show()
        'Me.lblnumaudit.Text = pieces_audited(whichln)

egood:
    End Sub
    Private Sub document_PrintPageWhite(ByVal sender As Object, _
        ByVal e As System.Drawing.Printing.PrintPageEventArgs) _
               Handles docToPrintWhite.PrintPage

        ' Insert code to render the page here. 
        ' This code will be called when the control is drawn. 

        ' The following code will render a simple 
        ' message on the printed document. 
        'fake variables to test ticket
        resource_name = typename(whichln)     '"MB64A4"
        resource_number = resnum(whichln)      '3511129
        skid_number = skidnum(whichln)    '23 - 6 - 25
        shift = mshift     '"C"
        pieces_per_box = pcperbox(whichln)    '1536


        Dim resourcenameFont As New System.Drawing.Font _
            ("Arial", 85, System.Drawing.FontStyle.Regular)
        Dim printFont As New System.Drawing.Font _
            ("Arial", 35, System.Drawing.FontStyle.Regular)

        ' Draw the content.
        e.Graphics.DrawString(resource_name.ToString, resourcenameFont, _
           System.Drawing.Brushes.Black, 15, 410)
        e.Graphics.DrawString(resource_name.ToString, resourcenameFont, _
           System.Drawing.Brushes.Black, 565, 410)

        e.Graphics.DrawString("Resource # " & resource_number.ToString, printFont, _
          System.Drawing.Brushes.Black, 20, 550)
        e.Graphics.DrawString("Resource # " & resource_number.ToString, printFont, _
          System.Drawing.Brushes.Black, 570, 550)

        e.Graphics.DrawString(pieces_per_box.ToString & " Pcs.", printFont, _
          System.Drawing.Brushes.Black, 75, 600)
        e.Graphics.DrawString(pieces_per_box.ToString & " Pcs.", printFont, _
          System.Drawing.Brushes.Black, 625, 600)

        e.Graphics.DrawString("Skid # " & skid_number.ToString, printFont, _
          System.Drawing.Brushes.Black, 10, 650)
        e.Graphics.DrawString("Skid # " & skid_number.ToString, printFont, _
         System.Drawing.Brushes.Black, 550, 650)

        e.Graphics.DrawString("Shift " & shift.ToString, printFont, _
          System.Drawing.Brushes.Black, 10, 700)
        e.Graphics.DrawString("Shift " & shift.ToString, printFont, _
          System.Drawing.Brushes.Black, 550, 700)

        e.Graphics.DrawString("Date " & Date.Today, printFont, _
          System.Drawing.Brushes.Black, 10, 750)
        e.Graphics.DrawString("Date " & Date.Today, printFont, _
         System.Drawing.Brushes.Black, 550, 750)

    End Sub
    Private Sub document_PrintPage(ByVal sender As Object, _
       ByVal e As System.Drawing.Printing.PrintPageEventArgs) _
           Handles docToPrintRed.PrintPage

        ' Insert code to render the page here. 
        ' This code will be called when the control is drawn. 

        ' The following code will render a simple 
        ' message on the printed document. 

        'need to get names for the variables and do formatting, formatting not finished but prints from second tray.

        Dim resourcenameFont As New System.Drawing.Font _
            ("Arial", 20, System.Drawing.FontStyle.Regular)
        Dim printFont As New System.Drawing.Font _
            ("Arial", 50, System.Drawing.FontStyle.Regular)

        ' Draw the content.
        e.Graphics.DrawString("SOMERSET GLASS PLANT", resourcenameFont, _
            System.Drawing.Brushes.Black, 200, 200)
        e.Graphics.DrawString("QUALITY", resourcenameFont, _
            System.Drawing.Brushes.Black, 275, 250)

        e.Graphics.DrawString("HOLD ", printFont, _
           System.Drawing.Brushes.Black, 275, 300)

        e.Graphics.DrawString("____REINSPECT", resourcenameFont, _
           System.Drawing.Brushes.Black, 30, 570)
        e.Graphics.DrawString("____SCRAP", resourcenameFont, _
           System.Drawing.Brushes.Black, 530, 570)

        e.Graphics.DrawString("DEFECTS:________________________________________________", resourcenameFont, _
           System.Drawing.Brushes.Black, 30, 650)
        e.Graphics.DrawString("________________________________________________", resourcenameFont, _
          System.Drawing.Brushes.Black, 30, 675)
        e.Graphics.DrawString("TYPE:_______________________________ ", resourcenameFont, _
          System.Drawing.Brushes.Black, 30, 715)

        e.Graphics.DrawString("SKID #:________________________", resourcenameFont, _
           System.Drawing.Brushes.Black, 30, 750)
    End Sub

    Private Sub pickTray()

        ' Dim paper As IPaper = New Paper
        ' paper.PrinterName = "\\printer\name"

        ' Create a hashtable to store values returned by the tray's enumerator.
        Dim trays As New Hashtable
        ' Dim trayEnum As IEnumNamedID
        ' trayEnum = paper.Trays
        Dim targetTrayID As Short = 0
        Dim trayIdTemp As Integer
        Dim trayNameTemp As String = ""

        'trayEnum returns a TrayID number as the method's return value and assigns a
        ' tray name string to a string variable passed in by reference (trayNameTemp).
        'trayEnum.Reset()
        'trayIdTemp = trayEnum.Next(trayNameTemp)

        'Continue to loop through the tray enumerator and store all returned values in the tray hashtable, storing the
        ' tray IDs as hashtable keys and the tray names as hashtable values.
        ' Once complete, the hashtable contains valid tray IDs and names for all trays supported by the printer driver.
        Do While trayIdTemp > 0
            trays.Add(trayIdTemp, trayNameTemp)
            'trayIdTemp = trayEnum.Next(trayNameTemp)
        Loop

        'Store the current tray ID in case the find routine does not locate the tray name expected.
        'targetTrayID = paper.TrayID

        'Loop through the hashtable searching for a specific tray name. Once found, assign the tray ID
        ' to a variable.
        Dim de As DictionaryEntry
        For Each de In trays
            If de.Value.ToString().Contains("Dummy") Then
                targetTrayID = de.Key
                Exit For
            End If
        Next

        'Assign the matched tray ID to the pPaper.TrayID property. Because the ID was returned
        ' by the tray's enumerator, you can be confident it is a valid TrayID for the current print
        ' driver.
        'paper.TrayID = targetTrayID

    End Sub

    Private Sub Hold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hold.Click
        If pieces_audited(whichln) < MinInsp Then MsgBox("Sample Less than 20") : GoTo egood
        status_flag = "Hold"
        writeto_database()
        'Ticket.Print()
        docToPrintRed.DefaultPageSettings.PaperSource = docToPrintRed.PrinterSettings.PaperSources.Item(2) 'sets the printer to print from second tray

        docToPrintRed.Print() 'prints the red ticket
        'PrintDialog1.AllowSomePages = True

        ' Show the help button.
        'PrintDialog1.ShowHelp = True

        ' Set the Document property to the PrintDocument for  
        ' which the PrintPage Event has been handled. To display the 
        ' dialog, either this property or the PrinterSettings property  
        ' must be set 
        'PrintDialog1.Document = docToPrintRed
        start_newskid()
        Me.Dispose()
        R10Part2.Close()
        R10Part3.Close()
        Selection.Show()
egood:
    End Sub
    Private Sub document_PrintPageRed(ByVal sender As Object, _
         ByVal e As System.Drawing.Printing.PrintPageEventArgs) _
                Handles docToPrintRed.PrintPage
        pickTray() 'Decide Tray

        ' Insert code to render the page here. 
        ' This code will be called when the control is drawn. 

        ' The following code will render a simple 
        ' message on the printed document. 

        'resource_name = typename(whichln)     '"MB64A4"
        resource_number = resnum(whichln)      '3511129
        'skid_number = skidnum(whichln)    '23 - 6 - 25
        'shift = mshift     '"C"
        'pieces_per_box = pcperbox(whichln)    '1536

        Dim resourcenameFont As New System.Drawing.Font _
            ("Arial", 20, System.Drawing.FontStyle.Regular)
        Dim printFont As New System.Drawing.Font _
            ("Arial", 50, System.Drawing.FontStyle.Regular)

        ' Draw the content.
        e.Graphics.DrawString("SOMERSET GLASS PLANT", resourcenameFont, _
            System.Drawing.Brushes.Black, 200, 200)
        e.Graphics.DrawString("QUALITY", resourcenameFont, _
            System.Drawing.Brushes.Black, 275, 250)

        e.Graphics.DrawString("HOLD ", printFont, _
           System.Drawing.Brushes.Black, 275, 300)

        e.Graphics.DrawString("____REINSPECT", resourcenameFont, _
           System.Drawing.Brushes.Black, 30, 570)
        e.Graphics.DrawString("____SCRAP", resourcenameFont, _
           System.Drawing.Brushes.Black, 530, 570)

        e.Graphics.DrawString("DEFECTS:________________________________________________", resourcenameFont, _
           System.Drawing.Brushes.Black, 30, 650)
        e.Graphics.DrawString("________________________________________________", resourcenameFont, _
          System.Drawing.Brushes.Black, 30, 675)
        e.Graphics.DrawString("TYPE:_______________________________ ", resourcenameFont, _
          System.Drawing.Brushes.Black, 30, 715)

        e.Graphics.DrawString("SKID #:________________________", resourcenameFont, _
           System.Drawing.Brushes.Black, 30, 750)


    End Sub

    Private Sub Matchline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbutton8.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 9) = defects(whichln, 9) + 1
        lblnumaudit.Text = pieces_audited(whichln)
    End Sub

    Private Sub btnShift_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShift.Click

        ChooseShift1.Show()

    End Sub

    Private Sub btnType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnType.Click
        'query som_resource_spec for all the possible type names for this line
        LampType.Show()

    End Sub

    Private Sub Ticket_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles Ticket.PrintPage

    End Sub

    Private Function getdata() As Object
        Throw New NotImplementedException
    End Function

    Private Sub pieces_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnAuditor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAuditor.Click
        '
        people_flag = "A"
        alphabet.Show()

        Operator1.Button1.BackColor = System.Drawing.Color.Cyan
        Operator1.Button2.BackColor = System.Drawing.Color.Cyan
        Operator1.Button3.BackColor = System.Drawing.Color.Cyan
        Operator1.Button4.BackColor = System.Drawing.Color.Cyan
        Operator1.Button5.BackColor = System.Drawing.Color.Cyan
        Operator1.Button6.BackColor = System.Drawing.Color.Cyan
        Operator1.Button7.BackColor = System.Drawing.Color.Cyan
        Operator1.Button8.BackColor = System.Drawing.Color.Cyan
        Operator1.Button9.BackColor = System.Drawing.Color.Cyan
        Operator1.Button10.BackColor = System.Drawing.Color.Cyan
        Operator1.Button11.BackColor = System.Drawing.Color.Cyan
        Operator1.Button12.BackColor = System.Drawing.Color.Cyan
        Operator1.Button13.BackColor = System.Drawing.Color.Cyan
        Operator1.Button14.BackColor = System.Drawing.Color.Cyan
        Operator1.Button15.BackColor = System.Drawing.Color.Cyan
        Operator1.Button16.BackColor = System.Drawing.Color.Cyan
        Operator1.Button17.BackColor = System.Drawing.Color.Cyan
        Operator1.Button18.BackColor = System.Drawing.Color.Cyan
        Operator1.Button19.BackColor = System.Drawing.Color.Cyan
        Operator1.Button20.BackColor = System.Drawing.Color.Cyan
        Operator1.Button21.BackColor = System.Drawing.Color.Cyan
        Operator1.Button22.BackColor = System.Drawing.Color.Cyan
        Operator1.Button23.BackColor = System.Drawing.Color.Cyan
        'Operator1.Button24.BackColor = System.Drawing.Color.Cyan

        Operator1.Button1.ForeColor = System.Drawing.Color.Black
        Operator1.Button2.ForeColor = System.Drawing.Color.Black
        Operator1.Button3.ForeColor = System.Drawing.Color.Black
        Operator1.Button4.ForeColor = System.Drawing.Color.Black
        Operator1.Button5.ForeColor = System.Drawing.Color.Black
        Operator1.Button6.ForeColor = System.Drawing.Color.Black
        Operator1.Button7.ForeColor = System.Drawing.Color.Black
        Operator1.Button8.ForeColor = System.Drawing.Color.Black
        Operator1.Button9.ForeColor = System.Drawing.Color.Black
        Operator1.Button10.ForeColor = System.Drawing.Color.Black
        Operator1.Button11.ForeColor = System.Drawing.Color.Black
        Operator1.Button12.ForeColor = System.Drawing.Color.Black
        Operator1.Button13.ForeColor = System.Drawing.Color.Black
        Operator1.Button14.ForeColor = System.Drawing.Color.Black
        Operator1.Button15.ForeColor = System.Drawing.Color.Black
        Operator1.Button16.ForeColor = System.Drawing.Color.Black
        Operator1.Button17.ForeColor = System.Drawing.Color.Black
        Operator1.Button18.ForeColor = System.Drawing.Color.Black
        Operator1.Button19.ForeColor = System.Drawing.Color.Black
        Operator1.Button20.ForeColor = System.Drawing.Color.Black
        Operator1.Button21.ForeColor = System.Drawing.Color.Black
        Operator1.Button22.ForeColor = System.Drawing.Color.Black
        Operator1.Button23.ForeColor = System.Drawing.Color.Black
        'Operator1.Button24.ForeColor = System.Drawing.Color.Black





        'Dim getin As ADODB.Recordset
        'Dim sti As String
        'Dim getdd As String

        ''get intials with permission level 1
        'getdd$ = "SELECT * FROM Som_Permissions WHERE Permission_level = " + Trim(Str$(1))
        'sti = "Provider=sqloledb.1;" & _
        '  "Data Source=SOMKYDB01CIGE;Initial Catalog=Som_Database;User Id=som_database;Password=som_pa55w0rd; "
        'getin = New ADODB.Recordset
        'getin.Open(getdd, sti, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, )

        'Dim recco As Integer
        'recco = getin.RecordCount


        'Dim ii As Int16 = 1
        'Do While Not getin.EOF

        '    Select Case ii
        '        Case 1
        '            Auditor.Button1.Text = getin.Fields("Initials").Value
        '        Case 2
        '            Auditor.Button2.Text = getin.Fields("Initials").Value
        '        Case 3
        '            Auditor.Button3.Text = getin.Fields("Initials").Value
        '        Case 4
        '            Auditor.Button4.Text = getin.Fields("Initials").Value
        '        Case 5
        '            Auditor.Button5.Text = getin.Fields("Initials").Value
        '        Case 6
        '            Auditor.Button6.Text = getin.Fields("Initials").Value
        '        Case 7
        '            Auditor.Button7.Text = getin.Fields("Initials").Value
        '        Case 8
        '            Auditor.Button8.Text = getin.Fields("Initials").Value
        '        Case 9
        '            Auditor.Button9.Text = getin.Fields("Initials").Value
        '        Case 10
        '            Auditor.Button10.Text = getin.Fields("Initials").Value
        '        Case 11
        '            Auditor.Button11.Text = getin.Fields("Initials").Value
        '        Case 12
        '            Auditor.Button12.Text = getin.Fields("Initials").Value
        '        Case 13
        '            Auditor.Button13.Text = getin.Fields("Initials").Value
        '        Case 14
        '            Auditor.Button14.Text = getin.Fields("Initials").Value
        '        Case 15
        '            Auditor.Button15.Text = getin.Fields("Initials").Value
        '        Case 16
        '            Auditor.Button16.Text = getin.Fields("Initials").Value
        '        Case 17
        '            Auditor.Button17.Text = getin.Fields("Initials").Value
        '        Case 18
        '            Auditor.Button18.Text = getin.Fields("Initials").Value
        '        Case 19
        '            Auditor.Button19.Text = getin.Fields("Initials").Value
        '        Case 20
        '            Auditor.Button20.Text = getin.Fields("Initials").Value
        '        Case 21
        '            Auditor.Button21.Text = getin.Fields("Initials").Value
        '        Case 22
        '            Auditor.Button22.Text = getin.Fields("Initials").Value
        '        Case 23
        '            Auditor.Button23.Text = getin.Fields("Initials").Value
        '        Case 24
        '            Auditor.Button24.Text = getin.Fields("Initials").Value
        '    End Select

        '    getin.MoveNext()
        '    ii = ii + 1
        'Loop

        'getin.Close()


    End Sub


    Private Sub dbutton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbutton6.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 7) = defects(whichln, 7) + 1
        lblnumaudit.Text = pieces_audited(whichln)
    End Sub
    Private Sub dbutton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbutton7.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 8) = defects(whichln, 8) + 1
        lblnumaudit.Text = pieces_audited(whichln)
    End Sub
    Private Sub dbutton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbutton9.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 10) = defects(whichln, 10) + 1
        lblnumaudit.Text = pieces_audited(whichln)
    End Sub
    Private Sub dbutton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbutton10.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 11) = defects(whichln, 11) + 1
        lblnumaudit.Text = pieces_audited(whichln)
    End Sub

    Private Sub dbutton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbutton11.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 12) = defects(whichln, 12) + 1
        lblnumaudit.Text = pieces_audited(whichln)
    End Sub

    Private Sub dbutton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbutton12.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 13) = defects(whichln, 13) + 1
        lblnumaudit.Text = pieces_audited(whichln)
    End Sub
    Private Sub dbutton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbutton13.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 14) = defects(whichln, 14) + 1
        lblnumaudit.Text = pieces_audited(whichln)
    End Sub

    Private Sub dbutton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbutton14.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 15) = defects(whichln, 15) + 1
        lblnumaudit.Text = pieces_audited(whichln)
    End Sub

    Private Sub dbutton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbutton15.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 16) = defects(whichln, 16) + 1
        lblnumaudit.Text = pieces_audited(whichln)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'FM
        'If pieces_audited(whichln) > 0 Then
        'If MessageBox.Show("Are you sure? You will lose audit.", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

        'Me.Close()

        'End If

        Selection.Show()
        Me.Close()
        R10Part2.Close()
        R10Part3.Close()
        'End If
        ''go back to selection screen
    End Sub


    Private Sub _next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _next.Click
        'FM
        R10Part2.Show()
        R10Part2.Label1.Text = pieces_audited(whichln)


    End Sub

   

    Private Sub btnOperator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOperator.Click
        people_flag = "O"
        alphabet.Show()
        Operator1.Button1.BackColor = System.Drawing.Color.Blue
        Operator1.Button2.BackColor = System.Drawing.Color.Blue
        Operator1.Button3.BackColor = System.Drawing.Color.Blue
        Operator1.Button4.BackColor = System.Drawing.Color.Blue
        Operator1.Button5.BackColor = System.Drawing.Color.Blue
        Operator1.Button6.BackColor = System.Drawing.Color.Blue

        Operator1.Button7.BackColor = System.Drawing.Color.Blue
        Operator1.Button8.BackColor = System.Drawing.Color.Blue
        Operator1.Button9.BackColor = System.Drawing.Color.Blue
        Operator1.Button10.BackColor = System.Drawing.Color.Blue
        Operator1.Button11.BackColor = System.Drawing.Color.Blue
        Operator1.Button12.BackColor = System.Drawing.Color.Blue
        Operator1.Button13.BackColor = System.Drawing.Color.Blue
        Operator1.Button14.BackColor = System.Drawing.Color.Blue
        Operator1.Button15.BackColor = System.Drawing.Color.Blue
        Operator1.Button16.BackColor = System.Drawing.Color.Blue
        Operator1.Button17.BackColor = System.Drawing.Color.Blue
        Operator1.Button18.BackColor = System.Drawing.Color.Blue
        Operator1.Button19.BackColor = System.Drawing.Color.Blue
        Operator1.Button20.BackColor = System.Drawing.Color.Blue
        Operator1.Button21.BackColor = System.Drawing.Color.Blue
        Operator1.Button22.BackColor = System.Drawing.Color.Blue
        Operator1.Button23.BackColor = System.Drawing.Color.Blue
        'Operator1.Button24.BackColor = System.Drawing.Color.Blue

        Operator1.Button1.ForeColor = System.Drawing.Color.White
        Operator1.Button2.ForeColor = System.Drawing.Color.White
        Operator1.Button3.ForeColor = System.Drawing.Color.White
        Operator1.Button4.ForeColor = System.Drawing.Color.White
        Operator1.Button5.ForeColor = System.Drawing.Color.White
        Operator1.Button6.ForeColor = System.Drawing.Color.White
        Operator1.Button7.ForeColor = System.Drawing.Color.White
        Operator1.Button8.ForeColor = System.Drawing.Color.White
        Operator1.Button9.ForeColor = System.Drawing.Color.White
        Operator1.Button10.ForeColor = System.Drawing.Color.White
        Operator1.Button11.ForeColor = System.Drawing.Color.White
        Operator1.Button12.ForeColor = System.Drawing.Color.White
        Operator1.Button13.ForeColor = System.Drawing.Color.White
        Operator1.Button14.ForeColor = System.Drawing.Color.White
        Operator1.Button15.ForeColor = System.Drawing.Color.White
        Operator1.Button16.ForeColor = System.Drawing.Color.White
        Operator1.Button17.ForeColor = System.Drawing.Color.White
        Operator1.Button18.ForeColor = System.Drawing.Color.White
        Operator1.Button19.ForeColor = System.Drawing.Color.White
        Operator1.Button20.ForeColor = System.Drawing.Color.White
        Operator1.Button21.ForeColor = System.Drawing.Color.White
        Operator1.Button22.ForeColor = System.Drawing.Color.White
        Operator1.Button23.ForeColor = System.Drawing.Color.White
        'Operator1.Button24.ForeColor = System.Drawing.Color.White


    End Sub

    Private Sub lblnumaudit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dbutton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbutton3.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 4) = defects(whichln, 4) + 1
        lblnumaudit.Text = pieces_audited(whichln)
    End Sub

  
End Class
