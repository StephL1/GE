Public Class Selection
   
    'if skid is good, beginning and ending status is same
    'if scrap, scrap everything
    'after buttons are pressed write defects to R10 table 
    'don't keep the button names static, get names from defects spec table and order by rank

    'Public whichln As Integer 'which line are we working on
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim obj As New R10
        'obj.Show()
        'Dim answer As Integer
        Beep()
        Beep()
        Beep()

        'answer = MsgBox("Inspect Skid Number 23-01-025 on Press 1 ", 20, "Press 1")   '20=yes and no, and vcritical sign
        'If answer = 6 Then
        Me.Hide()
        whichln = 1 : R10.ShowDialog()      'Dialog()
        'End If
        Me.Button1.Text = "Press 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & typename(1) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & skidnum(1)
        Me.Button4.Text = "Skip " + skidnum(1)
        'Me.Show()

    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim obj As New R10
        'obj.Show()
        'Dim answer As Integer
        Beep()
        Beep()
        Beep()

        'answer = MsgBox("Inspect Skid Number " + skidnum(1) + " on Press 2 ", 20, "Press 2")  '20=yes and no, and vcritical sign
        'If answer = 6 Then
        Me.Hide()
        whichln = 2 : obj.ShowDialog()

        'End If
        Me.Button5.Text = "Press 2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & typename(2) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & skidnum(2)
        Me.Button8.Text = "Skip " + skidnum(2)
        'Me.Show()

    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim obj As New R10
        'obj.Show()
        'Dim answer As Integer
        Beep()
        Beep()
        Beep()

        'answer = MsgBox("Inspect Skid Number " + skidnum(2) + " on Press 3 ", 20, "Press 3")  '20=yes and no, and vcritical sign
        'If answer = 6 Then
        Me.Hide()
        whichln = 3 : obj.ShowDialog()

        'End If
        Me.Button9.Text = "Press 3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & typename(3) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & skidnum(3)
        Me.Button12.Text = "Skip " + skidnum(3)
        'Me.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim obj As New R10
        Beep()
        Beep()
        Beep()

        'answer = MsgBox("Inspect Skid Number " + skidnum(3) + " on Press 4 ", 20, "Press 4")  '20=yes and no, and vcritical sign
        'If answer = 6 Then
        Me.Hide()
        whichln = 4 : obj.ShowDialog()

        'End If
        Me.Button2.Text = "Press 4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & typename(4) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & skidnum(4)
        Me.Button3.Text = "Skip " + skidnum(4)
        'Me.Show()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim obj As New R10
        'obj.Show()
        'Dim answer As Integer
        Beep()
        Beep()
        Beep()

        'answer = MsgBox("Inspect Skid Number " + skidnum(4) + " on Press 5 ", 20, "Press 5")  '20=yes and no, and vcritical sign
        'If answer = 6 Then
        Me.Hide()
        whichln = 5 : obj.ShowDialog()

        'End If
        Me.Button6.Text = "Press 5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & typename(5) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & skidnum(5)
        Me.Button7.Text = "Skip " + skidnum(5)
        'Me.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim obj As New R10
        'obj.Show()
        'Dim answer As Integer
        Beep()
        Beep()
        Beep()

        'answer = MsgBox("Inspect Skid Number " + skidnum(5) + " on Press 6 ", 20, "Press 6")  '20=yes and no, and vcritical sign
        'If answer = 6 Then
        Me.Hide()
        whichln = 6 : obj.ShowDialog()

        'End If
        Me.Button10.Text = "Press 6" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & typename(6) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & skidnum(6)
        Me.Button11.Text = "Skip " + skidnum(6)
        'Me.Show()

    End Sub

    Private Sub Selection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Button1.Text = "Press 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & typename(1) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & skidnum(1)

        Me.Button5.Text = "Press 2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & typename(2) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & skidnum(2)

        Me.Button9.Text = "Press 3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & typename(3) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & skidnum(3)

        Me.Button2.Text = "Press 4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & typename(4) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & skidnum(4)

        Me.Button6.Text = "Press 5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & typename(5) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & skidnum(5)

        Me.Button10.Text = "Press 6" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & typename(6) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & skidnum(6)

        Me.Button4.Text = "Skip " + skidnum(1)

        Me.Button8.Text = "Skip " + skidnum(2)

        Me.Button12.Text = "Skip " + skidnum(3)

        Me.Button3.Text = "Skip " + skidnum(4)

        Me.Button7.Text = "Skip " + skidnum(5)

        Me.Button11.Text = "Skip " + skidnum(6)

        Me.WindowState = FormWindowState.Maximized
        Timer1.Enabled = True
        Timer1.Interval = 1

        Me.Refresh()


    End Sub

    Private Sub lbltime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltime.Click

    End Sub

    
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'this skid is not going to be audited
        'need to check skipped skid in skids table
        whichln = 1
        'need to put number_inspected =0 in R10 table
        pieces_audited(whichln) = 0
        skip_skidflag = 1
        writeto_database()
        start_newskid()
        Me.Button4.Text = "Skip " + skidnum(1)
        Me.Button1.Text = "Press 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & typename(1) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & skidnum(1)
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbltime.Text = TimeOfDay
        whichhr = Hour(TimeOfDay)
        If Hour(TimeOfDay) = 7 Or Hour(TimeOfDay) = 15 Or Hour(TimeOfDay) = 23 And donetime = 0 Then change_shift()
        If (Hour(TimeOfDay) <> 7 Or Hour(TimeOfDay) <> 15 Or Hour(TimeOfDay) <> 23) Then donetime = 0

    End Sub
    
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        'this skid is not going to be audited
        'need to check skipped skid in skids table
        whichln = 6
        'need to put number_inspected =0 in R10 table
        pieces_audited(whichln) = 0
        skip_skidflag = 1
        writeto_database()
        'Ticket.Print()
        start_newskid()
        Me.Button11.Text = "Skip " + skidnum(6)
        Me.Button10.Text = "Press 6" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & typename(6) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & skidnum(6)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        'this skid is not going to be audited
        'need to check skipped skid in skids table
        whichln = 2
        'need to put number_inspected =0 in R10 table
        pieces_audited(whichln) = 0
        skip_skidflag = 1
        writeto_database()
        'Ticket.Print()
        start_newskid()
        Me.Button8.Text = "Skip " + skidnum(2)
        Me.Button5.Text = "Press 2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & typename(2) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & skidnum(2)
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        'this skid is not going to be audited
        'need to check skipped skid in skids table
        whichln = 3
        'need to put number_inspected =0 in R10 table
        pieces_audited(whichln) = 0
        skip_skidflag = 1
        writeto_database()
        'Ticket.Print()
        start_newskid()
        Me.Button12.Text = "Skip " + skidnum(3)
        Me.Button9.Text = "Press 3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & typename(3) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & skidnum(3)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'this skid is not going to be audited
        'need to check skipped skid in skids table
        whichln = 4
        'need to put number_inspected =0 in R10 table
        pieces_audited(whichln) = 0
        skip_skidflag = 1
        writeto_database()
        'Ticket.Print()
        start_newskid()
        Me.Button3.Text = "Skip " + skidnum(4)
        Me.Button2.Text = "Press 4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & typename(4) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & skidnum(4)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'this skid is not going to be audited
        'need to check skipped skid in skids table
        whichln = 5
        'need to put number_inspected =0 in R10 table
        pieces_audited(whichln) = 0
        skip_skidflag = 1
        writeto_database()
        'Ticket.Print()
        start_newskid()
        Me.Button7.Text = "Skip " + skidnum(5)
        Me.Button6.Text = "Press 5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & typename(5) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & skidnum(5)
    End Sub
End Class
