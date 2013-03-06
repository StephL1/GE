Public Class Form1


    ' Declare the PrintDocument object. 
    Private WithEvents docToPrint As New Printing.PrintDocument

    ' This method will set properties on the PrintDialog object and 
    ' then display the dialog. 
    Private Sub Button1_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles Button1.Click

        ' Allow the user to choose the page range he or she would 
        ' like to print.
        PrintDialog1.AllowSomePages = True

        ' Show the help button.
        PrintDialog1.ShowHelp = True

        ' Set the Document property to the PrintDocument for  
        ' which the PrintPage Event has been handled. To display the 
        ' dialog, either this property or the PrinterSettings property  
        ' must be set 
        PrintDialog1.Document = docToPrint

        Dim result As DialogResult = PrintDialog1.ShowDialog()

        ' If the result is OK then print the document. 
        If (result = DialogResult.OK) Then
            docToPrint.Print()
        End If

    End Sub

    ' The PrintDialog will print the document 
    ' by handling the document's PrintPage event. 
    Private Sub document_PrintPage(ByVal sender As Object, _
       ByVal e As System.Drawing.Printing.PrintPageEventArgs) _
           Handles docToPrint.PrintPage

        ' Insert code to render the page here. 
        ' This code will be called when the control is drawn. 

        ' The following code will render a simple 
        ' message on the printed document. 
        
        Dim resourcenameFont As New System.Drawing.Font _
            ("Arial", 85, System.Drawing.FontStyle.Regular)
        Dim printFont As New System.Drawing.Font _
            ("Arial", 35, System.Drawing.FontStyle.Regular)

        ' Draw the content.
        e.Graphics.DrawString(resource_name.Text, resourcenameFont, _
            System.Drawing.Brushes.Black, 15, 10)
        e.Graphics.DrawString(resource_name.Text, resourcenameFont, _
            System.Drawing.Brushes.Black, 515, 10)

        e.Graphics.DrawString("Resource # " & resource_number.Text, printFont, _
           System.Drawing.Brushes.Black, 20, 150)
        e.Graphics.DrawString("Resource # " & resource_number.Text, printFont, _
           System.Drawing.Brushes.Black, 520, 150)

        e.Graphics.DrawString(pieces_per_box.Text & " Pcs.", printFont, _
           System.Drawing.Brushes.Black, 30, 200)
        e.Graphics.DrawString(pieces_per_box.Text & " Pcs.", printFont, _
           System.Drawing.Brushes.Black, 530, 200)

        e.Graphics.DrawString("Skid # " & skid_number.Text, printFont, _
           System.Drawing.Brushes.Black, 10, 250)
        e.Graphics.DrawString("Skid # " & skid_number.Text, printFont, _
          System.Drawing.Brushes.Black, 500, 250)

        e.Graphics.DrawString("Shift " & shift.Text, printFont, _
           System.Drawing.Brushes.Black, 10, 300)
        e.Graphics.DrawString("Shift " & shift.Text, printFont, _
           System.Drawing.Brushes.Black, 500, 350)

        e.Graphics.DrawString("Date " & _date.Text, printFont, _
           System.Drawing.Brushes.Black, 10, 400)
        e.Graphics.DrawString("Date " & _date.Text, printFont, _
          System.Drawing.Brushes.Black, 500, 400)





    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
