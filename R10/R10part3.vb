Public Class R10Part3

    Private Sub R10Part2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'fill in heading line and Skid number you are working with
        'will need to make info_bar.text variable from string on r10 screen
        'info_bar.Text="    "
        Me.WindowState = FormWindowState.Maximized 'maximizes the form
        info_bar.Text = "        "  'auditor,etc

        'fill in buttons from defectname(whichln,i) 'defects 16 to 25

        skid_box.Text() = "  "


        Button1.Text = defectname(whichln, 35)
        Button2.Text = defectname(whichln, 36)
        Button3.Text = defectname(whichln, 37)
        Button4.Text = defectname(whichln, 38)
        Button5.Text = defectname(whichln, 39)
        Button6.Text = defectname(whichln, 40)
        Button7.Text = defectname(whichln, 41)
        Button8.Text = defectname(whichln, 42)
        Button9.Text = defectname(whichln, 43)
        Button10.Text = defectname(whichln, 44)
        Button11.Text = defectname(whichln, 45)
        Button12.Text = defectname(whichln, 46)
        Button13.Text = defectname(whichln, 47)
        Button14.Text = defectname(whichln, 48)
        Button15.Text = defectname(whichln, 49)

        lblnumaudit.Text = pieces_audited(whichln)


    End Sub


    'hide this screen, but keep variables in tact until we close out the skid
    'FM



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 35) = defects(whichln, 35) + 1
        lblnumaudit.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(35)

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 36) = defects(whichln, 36) + 1
        lblnumaudit.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(36)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 37) = defects(whichln, 37) + 1
        lblnumaudit.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(37)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 38) = defects(whichln, 38) + 1
        lblnumaudit.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(38)

    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 39) = defects(whichln, 39) + 1
        lblnumaudit.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(39)

    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 40) = defects(whichln, 40) + 1
        lblnumaudit.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(40)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 41) = defects(whichln, 41) + 1
        lblnumaudit.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(41)

    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 42) = defects(whichln, 42) + 1
        lblnumaudit.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(42)

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 43) = defects(whichln, 43) + 1
        lblnumaudit.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(43)

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 44) = defects(whichln, 44) + 1
        lblnumaudit.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(44)

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 45) = defects(whichln, 45) + 1
        lblnumaudit.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(45)

    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 46) = defects(whichln, 46) + 1
        lblnumaudit.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(46)

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 47) = defects(whichln, 47) + 1
        lblnumaudit.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(47)

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 48) = defects(whichln, 48) + 1
        lblnumaudit.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(48)

    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 49) = defects(whichln, 49) + 1
        lblnumaudit.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(49)

    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 50) = defects(whichln, 50) + 1
        lblnumaudit.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(50)

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 51) = defects(whichln, 51) + 1
        lblnumaudit.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(51)

    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        pieces_audited(whichln) = pieces_audited(whichln) + 1
        defects(whichln, 52) = defects(whichln, 52) + 1
        lblnumaudit.Text = pieces_audited(whichln)
        Distinct_Pieces_Audited(52)

    End Sub
    Private Sub info_bar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles info_bar.TextChanged

    End Sub



    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        R10Part2.Show()
        Me.Hide()
        R10Part2.Label1.Text = pieces_audited(whichln)
    End Sub

End Class