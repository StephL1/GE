Public Class frmSummary

    Private Sub frmSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        summary_skid_box.Text = "LINE " + Str(whichln) + "                    SKID NUMBER " + skidnum(whichln)


        Dim num2 As Integer
        num2 = distinctPieces

        Dim num As Integer
        num = 1
        Dim num3 As Integer
        num3 = distinctPieces

        Do

            For Each control As Control In Me.Controls

                If (num Mod 2 <> 0) Then
                    If TypeOf control Is Label Then
                        Dim myLabel As Label = DirectCast(control, Label)
                        myLabel.Text = defectname(whichln, num3)
                        num3 = num3 - 1

                    End If
                End If
                If (num Mod 2 = 0) Then
                    If TypeOf control Is Label Then
                        Dim myLabel As Label = DirectCast(control, Label)
                        myLabel.Text = defects(whichln, num2).ToString()
                        num2 = num2 - 1

                    End If
                End If
                num = num + 1

            Next
        Loop Until num > distinctPieces
        ''might have to change to equal instead of greater than





    End Sub

    Private Sub ShapeContainer1_Load(sender As Object, e As EventArgs) Handles ShapeContainer1.Load

    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub summary_skid_box_TextChanged(sender As Object, e As EventArgs) Handles summary_skid_box.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If pieces_audited(whichln) < MinInsp Then Confirmation.Show() : GoTo egood1
        ''Will message box still need to be displayed?
        status_flag = "Hold"
        writeto_database()
        'Ticket.Print()
        '''docToPrintRed.DefaultPageSettings.PaperSource = docToPrintRed.PrinterSettings.PaperSources.Item(2) 'sets the printer to print from second tray

        '''docToPrintRed.Print() 'prints the red ticket
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
        R10.Close()
        R10Part2.Close()
        R10Part3.Close()
        Selection.Show()
egood1:

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label41_Click(sender As Object, e As EventArgs) Handles Label41.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

    End Sub

    Private Sub Label25_Click_1(sender As Object, e As EventArgs) Handles Label25.Click

    End Sub

    Private Sub Label29_Click(sender As Object, e As EventArgs) Handles Label29.Click

    End Sub

    Private Sub Label33_Click(sender As Object, e As EventArgs) Handles Label33.Click

    End Sub

    Private Sub Label37_Click(sender As Object, e As EventArgs) Handles Label37.Click

    End Sub

    Private Sub Label22_Click_1(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub Label38_Click(sender As Object, e As EventArgs) Handles Label38.Click

    End Sub

    Private Sub Label42_Click(sender As Object, e As EventArgs) Handles Label42.Click

    End Sub


    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub


    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label32_Click(sender As Object, e As EventArgs) Handles Label32.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

   
    Private Sub btngood_Click(sender As Object, e As EventArgs) Handles btngood.Click
        If pieces_audited(whichln) < MinInsp Then Confirmation.Show() : GoTo egood
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
End Class