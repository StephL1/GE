Public Class LampType



    Dim getty As ADODB.Recordset
    Dim st As String
    Dim gd As String
    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click

        gd$ = "SELECT * FROM Som_Resource_Spec WHERE Line = " + Trim(Str$(whichln)) + " and left(Type_name,4) = 'MA36'"
        Call UpdateButtons()
        LampType2.Show()
        Me.Close()
    End Sub

    Private Sub Button24_Click(sender As System.Object, e As System.EventArgs) Handles Button24.Click
        gd$ = "SELECT * FROM Som_Resource_Spec WHERE Line = " + Trim(Str$(whichln)) + " and left(Type_name,4) = 'MA38'"
        Call UpdateButtons()
        LampType2.Show()
        Me.Close()
    End Sub

    Private Sub Button20_Click(sender As System.Object, e As System.EventArgs) Handles Button20.Click
        gd$ = "SELECT * FROM Som_Resource_Spec WHERE Line = " + Trim(Str$(whichln)) + " and left(Type_name,4) = 'MA46'"
        Call UpdateButtons()
        LampType2.Show()
        Me.Close()
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        gd$ = "SELECT * FROM Som_Resource_Spec WHERE Line = " + Trim(Str$(whichln)) + " and left(Type_name,4) = 'MA56'"
        Call UpdateButtons()
        LampType2.Show()
        Me.Close()
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        gd$ = "SELECT * FROM Som_Resource_Spec WHERE Line = " + Trim(Str$(whichln)) + " and left(Type_name,4) = 'MA64'"
        Call UpdateButtons()
        LampType2.Show()
        Me.Close()
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        gd$ = "SELECT * FROM Som_Resource_Spec WHERE Line = " + Trim(Str$(whichln)) + " and left(Type_name,4) = 'MAR43'"
        Call UpdateButtons()
        LampType2.Show()
        Me.Close()
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        gd$ = "SELECT * FROM Som_Resource_Spec WHERE Line = " + Trim(Str$(whichln)) + " and left(Type_name,4) = 'MAR47'"
        Call UpdateButtons()
        LampType2.Show()
        Me.Close()
    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        gd$ = "SELECT * FROM Som_Resource_Spec WHERE Line = " + Trim(Str$(whichln)) + " and left(Type_name,4) = 'MAR53'"
        Call UpdateButtons()
        LampType2.Show()
        Me.Close()
    End Sub

    Private Sub Button17_Click(sender As System.Object, e As System.EventArgs) Handles Button17.Click
        gd$ = "SELECT * FROM Som_Resource_Spec WHERE Line = " + Trim(Str$(whichln)) + " and left(Type_name,4) = 'MAR63'"
        Call UpdateButtons()
        LampType2.Show()
        Me.Close()
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        gd$ = "SELECT * FROM Som_Resource_Spec WHERE Line = " + Trim(Str$(whichln)) + " and left(Type_name,4) = 'MB36'"
        Call UpdateButtons()
        LampType2.Show()
        Me.Close()
    End Sub

    Private Sub Button26_Click(sender As System.Object, e As System.EventArgs) Handles Button26.Click
        gd$ = "SELECT * FROM Som_Resource_Spec WHERE Line = " + Trim(Str$(whichln)) + " and left(Type_name,4) = 'MB38'"
        Call UpdateButtons()
        LampType2.Show()
        Me.Close()
    End Sub

    Private Sub Button25_Click(sender As System.Object, e As System.EventArgs) Handles Button25.Click
        gd$ = "SELECT * FROM Som_Resource_Spec WHERE Line = " + Trim(Str$(whichln)) + " and left(Type_name,4) = 'MB46'"
        Call UpdateButtons()
        LampType2.Show()
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        gd$ = "SELECT * FROM Som_Resource_Spec WHERE Line = " + Trim(Str$(whichln)) + " and left(Type_name,4) = 'MB56'"
        Call UpdateButtons()
        LampType2.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        gd$ = "SELECT * FROM Som_Resource_Spec WHERE Line = " + Trim(Str$(whichln)) + " and left(Type_name,4) = 'MB64'"
        Call UpdateButtons()
        LampType2.Show()
        Me.Close()
    End Sub

    Private Sub Button19_Click(sender As System.Object, e As System.EventArgs) Handles Button19.Click
        gd$ = "SELECT * FROM Som_Resource_Spec WHERE Line = " + Trim(Str$(whichln)) + " and left(Type_name,4) = 'MBR43'"
        Call UpdateButtons()
        LampType2.Show()
        Me.Close()
    End Sub

    Private Sub Button18_Click(sender As System.Object, e As System.EventArgs) Handles Button18.Click
        gd$ = "SELECT * FROM Som_Resource_Spec WHERE Line = " + Trim(Str$(whichln)) + " and left(Type_name,4) = 'MBR47'"
        Call UpdateButtons()
        LampType2.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        gd$ = "SELECT * FROM Som_Resource_Spec WHERE Line = " + Trim(Str$(whichln)) + " and left(Type_name,4) = 'MBR53'"
        Call UpdateButtons()
        LampType2.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        gd$ = "SELECT * FROM Som_Resource_Spec WHERE Line = " + Trim(Str$(whichln)) + " and left(Type_name,4) = 'MBR63'"
        Call UpdateButtons()
        LampType2.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        gd$ = "SELECT * FROM Som_Resource_Spec WHERE Line = " + Trim(Str$(whichln)) + " and left(Type_name,4) = 'MC'"
        Call UpdateButtons()
        LampType2.Show()
        Me.Close()
    End Sub
    Private Sub UpdateButtons()
        Dim ss As Integer

        st = "Provider=sqloledb.1;" & _
            "Data Source=SOMKYDB01CIGE;Initial Catalog=Som_Database;User Id=som_database;Password=som_pa55w0rd; "

        getty = New ADODB.Recordset
        getty.Open(gd, st, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, )
        ss = getty.RecordCount


        Dim ii As Integer = 1
        'Do While Not getty.EOF And ss = 0      'if returns one record, will be at eof and skid, so I keep for one pass with ss variable
        Do While ii <= ss

            Select Case ii
                Case 1
                    LampType2.Button1.Text = getty.Fields("Type_name").Value
                    LampType2.Button1.Visible = True

                Case 2
                    LampType2.Button2.Text = getty.Fields("Type_name").Value
                    LampType2.Button2.Visible = True

                Case 3
                    LampType2.Button3.Text = getty.Fields("Type_name").Value
                    LampType2.Button3.Visible = True

                Case 4
                    LampType2.Button4.Text = getty.Fields("Type_name").Value
                    LampType2.Button4.Visible = True

                Case 5
                    LampType2.Button5.Text = getty.Fields("Type_name").Value
                    LampType2.Button5.Visible = True

                Case 6
                    LampType2.Button6.Text = getty.Fields("Type_name").Value
                    LampType2.Button6.Visible = True

                Case 7
                    LampType2.Button7.Text = getty.Fields("Type_name").Value
                    LampType2.Button7.Visible = True

                Case 8
                    LampType2.Button8.Text = getty.Fields("Type_name").Value
                    LampType2.Button8.Visible = True

                Case 9
                    LampType2.Button9.Text = getty.Fields("Type_name").Value
                    LampType2.Button9.Visible = True

                Case 10
                    LampType2.Button10.Text = getty.Fields("Type_name").Value
                    LampType2.Button10.Visible = True

                Case 11
                    LampType2.Button11.Text = getty.Fields("Type_name").Value
                    LampType2.Button11.Visible = True

                Case 12
                    LampType2.Button12.Text = getty.Fields("Type_name").Value
                    LampType2.Button12.Visible = True

                Case 13
                    LampType2.Button13.Text = getty.Fields("Type_name").Value
                    LampType2.Button13.Visible = True

                Case 14
                    LampType2.Button14.Text = getty.Fields("Type_name").Value
                    LampType2.Button14.Visible = True

                Case 15
                    LampType2.Button15.Text = getty.Fields("Type_name").Value
                    LampType2.Button15.Visible = True

                Case 16
                    LampType2.Button16.Text = getty.Fields("Type_name").Value
                    LampType2.Button16.Visible = True

                Case 17
                    LampType2.Button17.Text = getty.Fields("Type_name").Value
                    LampType2.Button17.Visible = True

                Case 18
                    LampType2.Button18.Text = getty.Fields("Type_name").Value
                    LampType2.Button18.Visible = True

                Case 19
                    LampType2.Button19.Text = getty.Fields("Type_name").Value
                    LampType2.Button19.Visible = True

                Case 20
                    LampType2.Button20.Text = getty.Fields("Type_name").Value
                    LampType2.Button10.Visible = True

                Case 21
                    LampType2.Button21.Text = getty.Fields("Type_name").Value
                    LampType2.Button21.Visible = True

                Case 22
                    LampType2.Button22.Text = getty.Fields("Type_name").Value
                    LampType2.Button22.Visible = True

                Case 23
                    LampType2.Button23.Text = getty.Fields("Type_name").Value
                    LampType2.Button23.Visible = True

                Case 24
                    LampType2.Button24.Text = getty.Fields("Type_name").Value
                    LampType2.Button24.Visible = True

                Case 25
                    LampType2.Button25.Text = getty.Fields("Type_name").Value
                    LampType2.Button25.Visible = True

                Case 26
                    LampType2.Button26.Text = getty.Fields("Type_name").Value
                    LampType2.Button26.Visible = True

                Case 27
                    LampType2.Button27.Text = getty.Fields("Type_name").Value
                    LampType2.Button27.Visible = True

                Case 28
                    LampType2.Button28.Text = getty.Fields("Type_name").Value
                    LampType2.Button28.Visible = True

                Case 29
                
                    If iip = 29 Then
                        LampType2.Button29.Text = getty.Fields("Type_name").Value
                        LampType2.Button29.Visible = True
                    End If

                Case 30
                    If iip = 29 Then
                        LampType2.Button30.Visible = True

                        LampType2.Button30.Text = getty.Fields("Type_name").Value
                        LampType2.Button30.Text = "Previous Screen"
                        LampType2.Button30.BackColor = Color.DarkOrange

                    End If
                    If iip > 29 Then
                        LampType2.Button30.Visible = True

                        LampType2.Button30.Text = "Next"
                    End If
                Case 31
                    LampType3.Button1.Text = getty.Fields("Type_name").Value
                    LampType2.Button1.Visible = True

                Case 32
                    LampType3.Button2.Text = getty.Fields("Type_name").Value
                    LampType2.Button1.Visible = True

                Case 33
                    LampType3.Button3.Text = getty.Fields("Type_name").Value
                    LampType2.Button1.Visible = True

                Case 34
                    LampType3.Button4.Text = getty.Fields("Type_name").Value
                    LampType2.Button1.Visible = True

                Case 35
                    LampType3.Button5.Text = getty.Fields("Type_name").Value
                    LampType2.Button1.Visible = True

                Case 36
                    LampType3.Button6.Text = getty.Fields("Type_name").Value
                    LampType2.Button1.Visible = True

                Case 37
                    LampType3.Button7.Text = getty.Fields("Type_name").Value
                    LampType2.Button1.Visible = True

                Case 38
                    LampType3.Button8.Text = getty.Fields("Type_name").Value
                    LampType2.Button1.Visible = True

                Case 39
                    LampType3.Button9.Text = getty.Fields("Type_name").Value
                    LampType2.Button1.Visible = True

                Case 40
                    LampType3.Button10.Text = getty.Fields("Type_name").Value
                    LampType2.Button1.Visible = True

                Case 41
                    LampType3.Button11.Text = getty.Fields("Type_name").Value
                    LampType2.Button1.Visible = True

                Case 42
                    LampType3.Button12.Text = getty.Fields("Type_name").Value
                    LampType2.Button1.Visible = True

                Case 43
                    LampType3.Button13.Text = getty.Fields("Type_name").Value
                    LampType2.Button1.Visible = True

                Case 44
                    LampType3.Button14.Text = getty.Fields("Type_name").Value
                    LampType2.Button1.Visible = True

                Case 45
                    LampType3.Button15.Text = getty.Fields("Type_name").Value
                    LampType2.Button1.Visible = True

                Case 46
                    LampType3.Button16.Text = getty.Fields("Type_name").Value
                    LampType2.Button1.Visible = True

                Case 47
                    LampType3.Button17.Text = getty.Fields("Type_name").Value
                    LampType2.Button1.Visible = True

                Case 48
                    LampType3.Button18.Text = getty.Fields("Type_name").Value
                    LampType2.Button1.Visible = True

                Case 49
                    LampType3.Button19.Text = getty.Fields("Type_name").Value
                    LampType2.Button1.Visible = True

                Case 50
                    LampType3.Button20.Text = getty.Fields("Type_name").Value
                    LampType2.Button1.Visible = True

                Case 51
                    LampType3.Button21.Text = getty.Fields("Type_name").Value
                    LampType2.Button1.Visible = True

                Case 52
                    LampType3.Button22.Text = getty.Fields("Type_name").Value
                    LampType2.Button1.Visible = True

                Case 53
                    LampType3.Button23.Text = getty.Fields("Type_name").Value
                    LampType2.Button1.Visible = True

                Case 54
                    LampType3.Button24.Text = getty.Fields("Type_name").Value
                    LampType2.Button1.Visible = True

                Case 55
                    LampType3.Button25.Text = getty.Fields("Type_name").Value
                    LampType2.Button1.Visible = True

                Case 56
                    LampType3.Button26.Text = getty.Fields("Type_name").Value
                    LampType2.Button1.Visible = True

                Case 57
                    LampType3.Button27.Text = getty.Fields("Type_name").Value
                    LampType2.Button1.Visible = True

                Case 58
                    LampType3.Button28.Text = getty.Fields("Type_name").Value
                    LampType2.Button1.Visible = True


            End Select
            getty.MoveNext()
            ii = ii + 1
            'If ss = 1 Then ss = 0

        Loop

        getty.Close()

    End Sub
    Private Sub LampType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'make appropriate button enabled
        Dim ss As Integer
        Dim tempname As String

        gd$ = "SELECT * FROM Som_Resource_Spec WHERE Line = " + Trim(Str$(whichln)) + " order by Type_name"
        st = "Provider=sqloledb.1;" & _
            "Data Source=SOMKYDB01CIGE;Initial Catalog=Som_Database;User Id=som_database;Password=som_pa55w0rd; "

        getty = New ADODB.Recordset
        getty.Open(gd, st, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, )
        ss = getty.RecordCount

        tempname = getty.Fields("Type_name").Value
        If Strings.Left(tempname, 4) = "MA36" Then
            Button21.BackColor = Color.Blue : Button21.Enabled = True
            Do While Strings.Left(tempname, 4) = "MA36" And Not getty.EOF
                tempname = getty.Fields("Type_name").Value
                getty.MoveNext()
            Loop
            If getty.EOF Then GoTo endlampload
        End If


        tempname = getty.Fields("Type_name").Value
        If Strings.Left(tempname, 4) = "MA38" Then
            Button24.BackColor = Color.Blue : Button24.Enabled = True
            Do While Strings.Left(tempname, 4) = "MA38" And Not getty.EOF
                tempname = getty.Fields("Type_name").Value
                getty.MoveNext()
            Loop
            If getty.EOF Then GoTo endlampload
        End If


        tempname = getty.Fields("Type_name").Value
        If Strings.Left(tempname, 4) = "MA46" Then
            Button20.BackColor = Color.Blue : Button20.Enabled = True
            Do While Strings.Left(tempname, 4) = "MA46" And Not getty.EOF
                tempname = getty.Fields("Type_name").Value
                getty.MoveNext()
            Loop
            If getty.EOF Then GoTo endlampload
        End If

        tempname = getty.Fields("Type_name").Value
        If Strings.Left(tempname, 4) = "MA56" Then
            Button10.BackColor = Color.Blue : Button10.Enabled = True
            Do While Strings.Left(tempname, 4) = "MA56" And Not getty.EOF
                tempname = getty.Fields("Type_name").Value
                getty.MoveNext()
            Loop
            If getty.EOF Then GoTo endlampload
        End If

        tempname = getty.Fields("Type_name").Value
        If Strings.Left(tempname, 4) = "MA64" Then
            Button11.BackColor = Color.Blue : Button11.Enabled = True
            Do While Strings.Left(tempname, 4) = "MA64" And Not getty.EOF
                tempname = getty.Fields("Type_name").Value
                getty.MoveNext()
            Loop
            If getty.EOF Then GoTo endlampload
        End If

        tempname = getty.Fields("Type_name").Value
        If Strings.Left(tempname, 5) = "MAR43" Then
            Button12.BackColor = Color.Blue : Button12.Enabled = True
            Do While Strings.Left(tempname, 5) = "MAR43" And Not getty.EOF
                tempname = getty.Fields("Type_name").Value
                getty.MoveNext()
            Loop
            If getty.EOF Then GoTo endlampload
        End If

        tempname = getty.Fields("Type_name").Value
        If Strings.Left(tempname, 5) = "MAR47" Then
            Button13.BackColor = Color.Blue : Button13.Enabled = True
            Do While Strings.Left(tempname, 5) = "MAR47" And Not getty.EOF
                tempname = getty.Fields("Type_name").Value
                getty.MoveNext()
            Loop
            If getty.EOF Then GoTo endlampload
        End If

        tempname = getty.Fields("Type_name").Value
        If Strings.Left(tempname, 5) = "MAR63" Then
            Button17.BackColor = Color.Blue : Button17.Enabled = True
            Do While Strings.Left(tempname, 5) = "MAR63" And Not getty.EOF
                tempname = getty.Fields("Type_name").Value
                getty.MoveNext()
            Loop
            If getty.EOF Then GoTo endlampload
        End If

        tempname = getty.Fields("Type_name").Value
        If Strings.Left(tempname, 4) = "MB36" Then
            Button9.BackColor = Color.Cyan : Button9.Enabled = True
            Button9.ForeColor = Color.Black
            Do While Strings.Left(tempname, 4) = "MB36" And Not getty.EOF
                tempname = getty.Fields("Type_name").Value
                getty.MoveNext()
            Loop
            If getty.EOF Then GoTo endlampload
        End If


        tempname = getty.Fields("Type_name").Value
        If Strings.Left(tempname, 4) = "MB38" Then
            Button26.BackColor = Color.Cyan : Button26.Enabled = True
            Button26.ForeColor = Color.Black
            Do While Strings.Left(tempname, 4) = "MB38" And Not getty.EOF
                tempname = getty.Fields("Type_name").Value
                getty.MoveNext()
            Loop
            If getty.EOF Then GoTo endlampload
        End If


        tempname = getty.Fields("Type_name").Value
        If Strings.Left(tempname, 4) = "MB46" Then
            Button25.BackColor = Color.Cyan : Button25.Enabled = True
            Button25.ForeColor = Color.Black
            Do While Strings.Left(tempname, 4) = "MB46" And Not getty.EOF
                tempname = getty.Fields("Type_name").Value
                getty.MoveNext()
            Loop
            If getty.EOF Then GoTo endlampload
        End If

        tempname = getty.Fields("Type_name").Value
        If Strings.Left(tempname, 4) = "MB56" Then
            Button8.BackColor = Color.Cyan : Button8.Enabled = True
            Button8.ForeColor = Color.Black
            Do While Strings.Left(tempname, 4) = "MB56" And Not getty.EOF
                tempname = getty.Fields("Type_name").Value
                getty.MoveNext()
            Loop
            If getty.EOF Then GoTo endlampload
        End If

        tempname = getty.Fields("Type_name").Value
        If Strings.Left(tempname, 4) = "MB64" Then
            Button7.BackColor = Color.Cyan : Button7.Enabled = True
            Button7.ForeColor = Color.Black
            Do While Strings.Left(tempname, 4) = "MB64" And Not getty.EOF
                tempname = getty.Fields("Type_name").Value
                getty.MoveNext()
            Loop
            If getty.EOF Then GoTo endlampload
        End If

        tempname = getty.Fields("Type_name").Value
        If Strings.Left(tempname, 5) = "MBR43" Then
            Button19.BackColor = Color.Cyan : Button19.Enabled = True
            Button19.ForeColor = Color.Black
            Do While Strings.Left(tempname, 5) = "MBR43" And Not getty.EOF
                tempname = getty.Fields("Type_name").Value
                getty.MoveNext()
            Loop
            If getty.EOF Then GoTo endlampload
        End If

        tempname = getty.Fields("Type_name").Value
        If Strings.Left(tempname, 5) = "MBR47" Then
            Button18.BackColor = Color.Cyan : Button18.Enabled = True
            Button18.ForeColor = Color.Black
            Do While Strings.Left(tempname, 5) = "MBR47" And Not getty.EOF
                tempname = getty.Fields("Type_name").Value
                getty.MoveNext()
            Loop
            If getty.EOF Then GoTo endlampload
        End If

        tempname = getty.Fields("Type_name").Value
        If Strings.Left(tempname, 5) = "MBR53" Then
            Button6.BackColor = Color.Cyan : Button6.Enabled = True
            Button6.ForeColor = Color.Black
            Do While Strings.Left(tempname, 5) = "MBR53" And Not getty.EOF
                tempname = getty.Fields("Type_name").Value
                getty.MoveNext()
            Loop
            If getty.EOF Then GoTo endlampload
        End If

        tempname = getty.Fields("Type_name").Value
        If Strings.Left(tempname, 2) = "MC" And Strings.Left(tempname, 3) <> "MCR" Then
            Button1.BackColor = Color.Blue : Button1.Enabled = True
            Do While Strings.Left(tempname, 2) = "MC" And Not getty.EOF
                tempname = getty.Fields("Type_name").Value
                getty.MoveNext()
            Loop
            If getty.EOF Then GoTo endlampload
        End If

        tempname = getty.Fields("Type_name").Value
        If Strings.Left(tempname, 3) = "MCR" Then
            Button2.BackColor = Color.Blue : Button2.Enabled = True
            Do While Strings.Left(tempname, 3) = "MCR" And Not getty.EOF
                tempname = getty.Fields("Type_name").Value
                getty.MoveNext()
            Loop
            If getty.EOF Then GoTo endlampload
        End If

endlampload:
    End Sub

 

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        gd$ = "SELECT * FROM Som_Resource_Spec WHERE Line = " + Trim(Str$(whichln)) + " and left(Type_name,4) = 'MCR'"
        Call UpdateButtons()
        LampType2.Show()
        Me.Close()

    End Sub
End Class