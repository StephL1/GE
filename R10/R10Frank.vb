
Private Sub btnOperator_Click(sender As System.Object, e As System.EventArgs)

End Sub
Private Sub skid_box_TextChanged(sender As System.Object, e As System.EventArgs)

End Sub

Private Sub btnOperator_Click(sender As System.Object, e As System.EventArgs)

End Sub
'Jyrone Parker  
Imports System.Runtime.InteropServices
Imports Microsoft.Office.Interop
Imports System.Net.Mime.MediaTypeNames
Imports System.Data
'Imports ESRI.ArcGIS.Output
'Imports ESRI.ArcGIS.esriSystem
Imports System.Collections

Public Class R10

    'Dim pieces_audited As Integer
   
    Dim next_clicked As Boolean 'flag for if the next button is clicked


    Dim i As Integer
    Dim auditor_id As String
    Dim skid_number As Integer
    Dim shift As Char
    Dim it As Integer

    Dim defects(32) As Integer
    Dim original_time

    Private WithEvents docToPrintWhite As New Printing.PrintDocument
    Private WithEvents docToPrintRed As New Printing.PrintDocument

    'fake variables for skid ticket
    Public resource_name
    Public resource_number
    Public pieces_per_box

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

        pieces_audited = 0 'intialize to 0
        pieces_audited = 20 'fake initialize


        'fill in heading line and Skid number you are working with
        btnShift.Text = "Shift " + mshift

        ''FM
        btnShift.Text = " Shift A"
        'btnAuditor.Text = "Auditor " + auditor_id(whichln)
        'btnOperator.Text = "Operator " + moperator(whichln)
        'btnType.Text = TypeName(whichln)

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
        skid_box.Text() = "                                                                        Skid Number 23-6-025"



        pieces.Text() = pieces_audited 'shows number of pieces audited



        'info_bar.Text() = "Shift " + shift.ToString() + " " + "auditor " + auditor_id.ToString()

        'changeOver = False


        'before increment, check sensor, see if running same type and fiscal week hasn't changed, changeover equals false, 

        'start 1 at 7 am every monday new fiscal week
        'type name mb348...
        'fix fiscal week routine

    End Sub

    Private Sub broke_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbutton0.Click
        pieces_audited = pieces_audited + 1
        defects(1) = defects(1) + 1
        pieces.Text = pieces_audited
    End Sub

    Private Sub Chipped_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbutton1.Click
        pieces_audited = pieces_audited + 1
        defects(2) = defects(2) + 1
        pieces.Text = pieces_audited
    End Sub

    Private Sub Blister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbutton2.Click
        pieces_audited = pieces_audited + 1
        defects(3) = defects(3) + 1
        pieces.Text = pieces_audited
    End Sub

    Private Sub Innerledge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbutton4.Click
        pieces_audited = pieces_audited + 1
        defects(4) = defects(4) + 1
        pieces.Text = pieces_audited
    End Sub

    Private Sub Key_Seal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbutton5.Click
        pieces_audited = pieces_audited + 1
        defects(5) = defects(5) + 1
        pieces.Text = pieces_audited
    End Sub

    Private Sub Good_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Good.Click
        ' If pieces_audited < 20 Then MsgBox("Sample Less than 20") : GoTo egood
        writeto_database()

        'Ticket.Print()

        'White print ticket logic
        PrintDialog1.AllowSomePages = True

        ' Show the help button.
        PrintDialog1.ShowHelp = True

        ' Set the Document property to the PrintDocument for  
        ' which the PrintPage Event has been handled. To display the 
        ' dialog, either this property or the PrinterSettings property  
        ' must be set 
        PrintDialog1.Document = docToPrintWhite

        Dim result As DialogResult = PrintDialog1.ShowDialog()

        ' If the result is OK then print the document. 
        If (result = DialogResult.OK) Then
            docToPrintWhite.Print()
        End If
        start_newskid()

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
        resource_name = "MB64A4"
        resource_number = 3511129
        'skid_number = 23-6-025
        'shift = "C"
        pieces_per_box = 1536

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

    Private Sub pickTray()

        ' Dim paper As IPaper = New Paper
        ' paper.PrinterName = "\\printer\name"

        ' Create a hashtable to store values returned by the tray's enumerator.
        ' Dim trays As New Hashtable
        ' Dim trayEnum As IEnumNamedID
        ' trayEnum = paper.Trays
        'Dim targetTrayID As Short = 0
        'Dim trayIdTemp As Integer
        'Dim trayNameTemp As String = ""

        'trayEnum returns a TrayID number as the method's return value and assigns a
        ' tray name string to a string variable passed in by reference (trayNameTemp).
        'trayEnum.Reset()
        'trayIdTemp = trayEnum.Next(trayNameTemp)

        'Continue to loop through the tray enumerator and store all returned values in the tray hashtable, storing the
        ' tray IDs as hashtable keys and the tray names as hashtable values.
        ' Once complete, the hashtable contains valid tray IDs and names for all trays supported by the printer driver.
        'Do While trayIdTemp > 0
        'trays.Add(trayIdTemp, trayNameTemp)
        'trayIdTemp = trayEnum.Next(trayNameTemp)
        'Loop

        'Store the current tray ID in case the find routine does not locate the tray name expected.
        'targetTrayID = paper.TrayID

        'Loop through the hashtable searching for a specific tray name. Once found, assign the tray ID
        ' to a variable.
        'Dim de As DictionaryEntry
        'For Each de In trays
        'If de.Value.ToString().Contains("Dummy") Then
        'targetTrayID = de.Key
        'Exit For
        'End If
        'Next

        'Assign the matched tray ID to the pPaper.TrayID property. Because the ID was returned
        ' by the tray's enumerator, you can be confident it is a valid TrayID for the current print
        ' driver.
        'paper.TrayID = targetTrayID

    End Sub

    Private Sub Hold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hold.Click
        'Writeto_database()
        'Ticket.Print()
        
        PrintDialog1.AllowSomePages = True

        ' Show the help button.
        PrintDialog1.ShowHelp = True

        ' Set the Document property to the PrintDocument for  
        ' which the PrintPage Event has been handled. To display the 
        ' dialog, either this property or the PrinterSettings property  
        ' must be set 
        PrintDialog1.Document = docToPrintRed
        start_newskid()

    End Sub
    Private Sub document_PrintPageRed(ByVal sender As Object, _
         ByVal e As System.Drawing.Printing.PrintPageEventArgs) _
                Handles docToPrintRed.PrintPage
        pickTray() 'Decide Tray

        ' Insert code to render the page here. 
        ' This code will be called when the control is drawn. 

        ' The following code will render a simple 
        ' message on the printed document. 

        Dim resourcenameFont As New System.Drawing.Font _
           ("Arial", 85, System.Drawing.FontStyle.Regular)
        Dim printFont As New System.Drawing.Font _
           ("Arial", 35, System.Drawing.FontStyle.Regular)

        ' Draw the content.
        e.Graphics.DrawString(resource_name.ToString, resourcenameFont, _
           System.Drawing.Brushes.Black, 15, 500)
        e.Graphics.DrawString(resource_name.ToString, resourcenameFont, _
           System.Drawing.Brushes.Black, 545, 500)

        e.Graphics.DrawString("Resource # " & resource_number.ToString, printFont, _
            System.Drawing.Brushes.Black, 20, 550)
        e.Graphics.DrawString("Resource # " & resource_number.ToString, printFont, _
          System.Drawing.Brushes.Black, 550, 550)

        e.Graphics.DrawString(pieces_per_box.ToString & " Pcs.", printFont, _
            System.Drawing.Brushes.Black, 30, 600)
        e.Graphics.DrawString(pieces_per_box.ToString & " Pcs.", printFont, _
             System.Drawing.Brushes.Black, 560, 600)

        e.Graphics.DrawString("Skid # " & skid_number.ToString, printFont, _
          System.Drawing.Brushes.Black, 10, 750)
        e.Graphics.DrawString("Skid # " & skid_number.ToString, printFont, _
         System.Drawing.Brushes.Black, 530, 750)

        e.Graphics.DrawString("Shift " & shift.ToString, printFont, _
          System.Drawing.Brushes.Black, 10, 850)
        e.Graphics.DrawString("Shift " & shift.ToString, printFont, _
         System.Drawing.Brushes.Black, 530, 850)

        e.Graphics.DrawString("Date " & Date.Today, printFont, _
          System.Drawing.Brushes.Black, 10, 900)
        e.Graphics.DrawString("Date " & Date.Today, printFont, _
         System.Drawing.Brushes.Black, 530, 900)

    End Sub

    Private Sub Matchline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbutton8.Click
        pieces_audited = pieces_audited + 1
        defects(8) = defects(8) + 1
        pieces.Text = pieces_audited
    End Sub

    Private Sub btnShift_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShift.Click
        ChooseShift1.Show()
        'make a form with a 4 buttons
        'please choose Shift A, B, C, D
        'replace appropriate variables and update Heading on Screen

    End Sub

    Private Sub btnType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnType.Click
        Operator.Show()
        'query som_resource_spec for all the possible type names for this line
    End Operator

    Sub start_newskid()

        'write to R10 datatable
        fiscalweek()



        'write to appropriate fields in R10 table
        'r10.Line=whichln
        'r10.Resource_number=resnum(whichln)
        'r10.Type_name=typename(whichln)
        'r10.skid_number=skidnum(whichln)
        'r10.Date_entered = Now
        original_time = Now


        'r10.shift=mshift

        'write to appropriate fields in skids table
        'skids.Line=whichln
        'skids.Resource_number=resnum(whichln)
        'skids.Type_name=typename(whichln)
        'skids.skid_number=skidnum(whichln)
        'skids.Pcs_per_box=pcperbox(whichln)
        'skids.Boxes_per_skid=boxperskid(whichln)
        'skids.Skid_start_time=now
        pieces_audited = 0


    End Sub
    Sub fiscalweek()
        'skid number example  = "01-1-001"
        'two digit fiscal week - one digit line - three digit skid number
        Dim firstday As Date
        Dim tdate As Date
        'Dim fiscalwk As Integer

        firstday = "01/02/2012"                'Date(2012,01,02)
        tdate = Now
        ' fiscalwk=INT((DATE(YEAR(firstday),MONTH(firstday),DAY(firstday))-tdate)/7)+1)

        'If Today Is Not vbMonday Then
        GoTo endfiscal
        ' Else
        'If donefiscal = 1 Then GoTo endfiscal
        'If TimeOfDay = 7 am then
        '   start_newskid = Val(Left$(skidnum(whichln), 2)) + 1
        '  end_newskid = Val(Right$(skidnum(whichln), 3)) + 1
        ' newskid = start_newskid() + "-" + Str(whichln) + "-" + end_newskid
        'skidnum(whichln) = newskid
        'donefiscal(whichln) = 1
        'End If

        'End If
endfiscal:
    End Sub

    Private Sub Ticket_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles Ticket.PrintPage

    End Sub

    Private Function getdata() As Object
        Throw New NotImplementedException
    End Function

    Private Sub pieces_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pieces.TextChanged

    End Sub

    Private Sub btnAuditor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAuditor.Click
        Auditor.Show()

    End Sub

    Private Sub dbutton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbutton6.Click
        pieces_audited = pieces_audited + 1
        defects(6) = defects(6) + 1
        pieces.Text = pieces_audited
    End Sub
    Private Sub dbutton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbutton7.Click
        pieces_audited = pieces_audited + 1
        defects(7) = defects(7) + 1
        pieces.Text = pieces_audited
    End Sub
    Private Sub dbutton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbutton9.Click
        pieces_audited = pieces_audited + 1
        defects(9) = defects(9) + 1
        pieces.Text = pieces_audited
    End Sub
    Private Sub dbutton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbutton10.Click
        pieces_audited = pieces_audited + 1
        defects(10) = defects(10) + 1
        pieces.Text = pieces_audited
    End Sub

    Private Sub dbutton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbutton11.Click
        pieces_audited = pieces_audited + 1
        defects(11) = defects(11) + 1
        pieces.Text = pieces_audited
    End Sub

    Private Sub dbutton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbutton12.Click
        pieces_audited = pieces_audited + 1
        defects(12) = defects(12) + 1
        pieces.Text = pieces_audited
    End Sub
    Private Sub dbutton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbutton13.Click
        pieces_audited = pieces_audited + 1
        defects(13) = defects(13) + 1
        pieces.Text = pieces_audited
    End Sub

    Private Sub dbutton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbutton14.Click
        pieces_audited = pieces_audited + 1
        defects(14) = defects(14) + 1
        pieces.Text = End
    pieces_audited Sub

    Private Sub dbutton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbutton15.Click
        pieces_audited = pieces_audited + 1
        defects(15) = defects(15) + 1
        pieces.Text = pieces_audited
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'FM
        If pieces_audited > 0 Then
            If MessageBox.Show("Are you sure? You will lose audit.", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                Selection.Show()
                Me.Close()

            End If


        End If
        'go back to selection screen
    End Sub


    Private Sub _next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _next.Click
        'FM
        R10Part2.Show()
        Me.Hide()

    End Sub
