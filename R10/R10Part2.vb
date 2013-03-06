Public Class R10Part2

    Private Sub R10Part2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'fill in heading line and Skid number you are working with
        'will need to make info_bar.text variable from string on r10 screen
        'info_bar.Text="    "
        Me.WindowState = FormWindowState.Maximized 'maximizes the form
        info_bar.Text = "        "  'auditor,etc

        'fill in buttons from defectname(whichln,i) 'defects 16 to 25

        skid_box.Text() = "  "

        'f                                                                      Skid Number 23-6-025"
        'Dim nm As Integer = defectname.GetLength(whichln)
        Dim i As Integer = 0
        Good_to_Start.Text = defectname(whichln, 17)
        Button1.Text = defectname(whichln, 18)
        Button2.Text = defectname(whichln, 19)
        Button3.Text = defectname(whichln, 20)
        Button4.Text = defectname(whichln, 21)
        Button5.Text = defectname(whichln, 22)
        Button6.Text = defectname(whichln, 23)
        Button7.Text = defectname(whichln, 24)
        Button8.Text = defectname(whichln, 25)
        Button9.Text = defectname(whichln, 26)
        Button10.Text = defectname(whichln, 27)
        Button11.Text = defectname(whichln, 28)
        Button13.Text = defectname(whichln, 29)
        Button14.Text = defectname(whichln, 30)
        Button15.Text = defectname(whichln, 31)
        Button16.Text = defectname(whichln, 32)
        Button17.Text = defectname(whichln, 33)
        Button18.Text = defectname(whichln, 34)
        Label1.Text = pieces_audited(whichln)


    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        'hide this screen, but keep variables in tact until we close out the skid
        'FM
        R10.Show()
        Me.Hide()
        R10.lblnumaudit.Text = pieces_audited(whichln)
    End Sub

    Private Sub Good_to_Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Good_to_Start.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 17) = defects(whichln, 17) + 1
        Label1.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(17)

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 18) = defects(whichln, 18) + 1
        Label1.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(18)

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 25) = defects(whichln, 25) + 1
        Label1.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(25)

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 26) = defects(whichln, 26) + 1
        Label1.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(26)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 21) = defects(whichln, 21) + 1
        Label1.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(21)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 22) = defects(whichln, 22) + 1
        Label1.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(22)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 19) = defects(whichln, 19) + 1
        Label1.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(19)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 20) = defects(whichln, 20) + 1
        Label1.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(20)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 23) = defects(whichln, 23) + 1
        Label1.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(23)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 24) = defects(whichln, 24) + 1
        Label1.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(24)

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 27) = defects(whichln, 27) + 1
        Label1.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(27)

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 28) = defects(whichln, 28) + 1
        Label1.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(28)

    End Sub


    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 29) = defects(whichln, 29) + 1
        Label1.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(29)

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click

        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 30) = defects(whichln, 30) + 1
        Label1.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(30)


    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 31) = defects(whichln, 31) + 1
        Label1.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(31)


    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 32) = defects(whichln, 32) + 1
        Label1.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(32)


    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 33) = defects(whichln, 33) + 1
        Label1.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(33)


    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 34) = defects(whichln, 34) + 1
        Label1.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(34)


    End Sub
    Private Sub info_bar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        R10Part3.Show()
        Me.Hide()
        R10Part3.lblnumaudit.Text = pieces_audited(whichln)
    End Sub
End Class