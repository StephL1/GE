Public Class Selection

    'if skid is good, beginning and ending status is same
    'if scrap, scrap everything
    'after buttons are pressed write defects to R10 table 
    'don't keep the button names static, get names from defects spec table and order by rank

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim obj As New R10
        'obj.Show()
        Dim answer As Integer
        Beep()
        Beep()
        Beep()

        answer = MsgBox("Inspect Skid Number " + skidnum(0) + " on Press 1 ", 20, "Press 1")  '20=yes and no, and vcritical sign
        If answer = 6 Then
            Me.Hide()
            whichln = 1 : obj.ShowDialog()

        End If

        Me.Show()

    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim obj As New R10
        'obj.Show()
        Dim answer As Integer
        Beep()
        Beep()
        Beep()

        answer = MsgBox("Inspect Skid Number " + skidnum(1) + " on Press 2 ", 20, "Press 2")  '20=yes and no, and vcritical sign
        If answer = 6 Then
            Me.Hide()
            whichln = 2 : obj.ShowDialog()

        End If

        Me.Show()



    End Sub



    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim obj As New R10
        'obj.Show()
        Dim answer As Integer
        Beep()
        Beep()
        Beep()

        answer = MsgBox("Inspect Skid Number " + skidnum(2) + " on Press 3 ", 20, "Press 3")  '20=yes and no, and vcritical sign
        If answer = 6 Then
            Me.Hide()
            whichln = 3 : obj.ShowDialog()

        End If

        Me.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim obj As New R10
        'obj.Show()
        Dim answer As Integer
        Beep()
        Beep()
        Beep()

        answer = MsgBox("Inspect Skid Number " + skidnum(3) + " on Press 4 ", 20, "Press 4")  '20=yes and no, and vcritical sign
        If answer = 6 Then
            Me.Hide()
            whichln = 4 : obj.ShowDialog()

        End If

        Me.Show()


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim obj As New R10
        'obj.Show()
        Dim answer As Integer
        Beep()
        Beep()
        Beep()

        answer = MsgBox("Inspect Skid Number " + skidnum(4) + " on Press 5 ", 20, "Press 5")  '20=yes and no, and vcritical sign
        If answer = 6 Then
            Me.Hide()
            whichln = 5 : obj.ShowDialog()

        End If

        Me.Show()


    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim obj As New R10
        'obj.Show()
        Dim answer As Integer
        Beep()
        Beep()
        Beep()

        answer = MsgBox("Inspect Skid Number " + skidnum(5) + " on Press 6 ", 20, "Press 6")  '20=yes and no, and vcritical sign
        If answer = 6 Then
            Me.Hide()
            whichln = 6 : obj.ShowDialog()

        End If

        Me.Show()

    End Sub
    Private Sub UpdatePressButtons(ByVal t_name() As String, ByVal s_num() As String)

        'FM      
        Button1.Text = "Press 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & t_name(0) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & s_num(0)

        Button5.Text = "Press 2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & t_name(1) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & s_num(1)

        Button9.Text = "Press 3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & t_name(2) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & s_num(2)

        Button2.Text = "Press 4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & t_name(3) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & s_num(3)

        Button6.Text = "Press 5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & t_name(4) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & s_num(4)

        Button10.Text = "Press 6" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & t_name(5) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & s_num(5)

        Me.Button4.Text = "Skip " + s_num(0)

        Me.Button8.Text = "Skip " + s_num(1)

        Me.Button12.Text = "Skip " + s_num(2)

        Me.Button3.Text = "Skip " + s_num(3)

        Me.Button7.Text = "Skip " + s_num(4)

        Me.Button11.Text = "Skip " + s_num(5)

    End Sub

    Private Sub Selection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'FM
        Call UpdatePressButtons(typename, skidnum)


        Me.WindowState = FormWindowState.Maximized
        Timer1.Enabled = True
        Timer1.Interval = 1

        Show()


    End Sub

    Private Sub lbltime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltime.Click

    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'this skid is not going to be audited
        'need to check skipped skid in skid database
        ' Writeto_database()
        'Ticket.Print()
        'start_newskid()

    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbltime.Text = TimeOfDay

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click

    End Sub
End Class
