Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices

Public Class printer
    Dim excel As Microsoft.Office.Interop.Excel.Application 'opening up the excel document

    Dim wb As Microsoft.Office.Interop.Excel.Workbook 'opening up the workbook for manipulation
    Dim oSheet As Excel.Worksheet
    Dim boxes_on_skid As Integer
    Dim status As String
    Dim auditor As String
    Dim good_boxes As Integer
    Dim skid_moved_in As Integer
    Dim boxes_moved_in As Integer





    Private Sub printer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try

            excel = New Microsoft.Office.Interop.Excel.Application
            wb = excel.Workbooks.Open("C:\\Users\Jyrone\Dropbox\GE\GE\Database_Layout") 'opening the file
            'TODO make this flexible for later use
            excel.Visible = False

            wb.Activate()

        Catch ex As COMException 'error handling
            MessageBox.Show("Error accessing Excel: " + ex.ToString())

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.ToString())
        End Try
        oSheet = wb.ActiveSheet
        bos.Text() = oSheet.Cells(10, 6)
        'grabs the value from excel file for the boxes on the skid
        gb.Text() = oSheet.Cells(13, 6)
        'grabs the value from excel file for the good boxes
        stat.Items.Add("Good") 'populate the status combo box with options 
        stat.Items.Add("Hold")
        stat.Items.Add("Scrap")

        audit.Items.Add(oSheet.Cells(20, 6).ToString()) 'Gets Auditor name from excel file
        skid_moved_in = oSheet.Cells(12, 6) 'from table
        boxes_moved_in = oSheet.Cells(9, 6)
        bmi.Text() = boxes_moved_in
        snmi.Text() = skid_moved_in


    End Sub

    Private Sub print_Click(sender As System.Object, e As System.EventArgs) Handles print.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

    End Sub
End Class