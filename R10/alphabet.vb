Public Class alphabet

    Dim intia As ADODB.Recordset
    Dim stt As String
    Dim gtd As String


    Private Sub alphabet_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

        
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If People_flag = "A" Then
            gtd$ = "SELECT * FROM Som_Permissions WHERE Permission_level >= " + Trim(Str$(1)) + " and Permission_level <= " + Trim(Str$(4)) + " and left(LastName,1) = 'A' OR left(LastName,1) = 'B' and Permission_level >= " + Trim(Str$(1)) + " and Permission_level <= " + Trim(Str$(4))
        End If
        If People_flag = "O" Then
            gtd$ = "SELECT * FROM Som_Permissions WHERE Permission_level =  " + Trim(Str$(3)) + " and left(LastName,1) = 'A' OR Permission_level =  " + Trim(Str$(3)) + "and left(LastName,1) = 'B' OR Permission_level = " + Trim(Str$(5)) + " and left(LastName,1) = 'A' OR Permission_level = " + Trim(Str$(5)) + " and left(LastName,1) = 'B'"
        End If
        Call updbut()
        Me.Close()
        Operator1.Show()
    End Sub


    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        If People_flag = "A" Then
            gtd$ = "SELECT * FROM Som_Permissions WHERE Permission_level >= " + Trim(Str$(1)) + " and Permission_level <= " + Trim(Str$(4)) + " and left(LastName,1) = 'C' OR left(LastName,1) = 'D' and Permission_level >= " + Trim(Str$(1)) + " and Permission_level <= " + Trim(Str$(4))
        End If
        If People_flag = "O" Then
            gtd$ = "SELECT * FROM Som_Permissions WHERE Permission_level =  " + Trim(Str$(3)) + " and left(LastName,1) = 'C' OR Permission_level =  " + Trim(Str$(3)) + "and left(LastName,1) = 'D' OR Permission_level = " + Trim(Str$(5)) + " and left(LastName,1) = 'C' OR Permission_level = " + Trim(Str$(5)) + " and left(LastName,1) = 'D'"
        End If
        Call updbut()
        Me.Close()
        Operator1.Show()
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click


        If People_flag = "A" Then
            gtd$ = "SELECT * FROM Som_Permissions WHERE Permission_level >= " + Trim(Str$(1)) + " and Permission_level <= " + Trim(Str$(4)) + " and left(LastName,1) = 'E' OR left(LastName,1) = 'F' OR left(LastName,1) = 'G'and Permission_level >= " + Trim(Str$(1)) + " and Permission_level <= " + Trim(Str$(4))
        End If
        If People_flag = "O" Then
            gtd$ = "SELECT * FROM Som_Permissions WHERE Permission_level =  " + Trim(Str$(3)) + " and left(LastName,1) = 'E' OR Permission_level =  " + Trim(Str$(3)) + "and left(LastName,1) = 'F' OR Permission_level =  " + Trim(Str$(3)) + "and left(LastName,1) = 'G' OR Permission_level = " + Trim(Str$(5)) + " and left(LastName,1) = 'E' OR Permission_level = " + Trim(Str$(5)) + " and left(LastName,1) = 'F' OR Permission_level = " + Trim(Str$(5)) + " and left(LastName,1) = 'G'"
        End If
        Call updbut()
        Me.Close()
        Operator1.Show()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
       
        If People_flag = "A" Then
            gtd$ = "SELECT * FROM Som_Permissions WHERE Permission_level >= " + Trim(Str$(1)) + " and Permission_level <= " + Trim(Str$(4)) + " and left(LastName,1) = 'H' OR left(LastName,1) = 'I' OR left(LastName,1) = 'J' and Permission_level >= " + Trim(Str$(1)) + " and Permission_level <= " + Trim(Str$(4))

        End If
        If People_flag = "O" Then
            gtd$ = "SELECT * FROM Som_Permissions WHERE Permission_level =  " + Trim(Str$(3)) + " and left(LastName,1) = 'H' OR Permission_level =  " + Trim(Str$(3)) + "and left(LastName,1) = 'I' OR Permission_level =  " + Trim(Str$(3)) + "and left(LastName,1) = 'J' OR Permission_level = " + Trim(Str$(5)) + " and left(LastName,1) = 'H' OR Permission_level = " + Trim(Str$(5)) + " and left(LastName,1) = 'I' OR Permission_level = " + Trim(Str$(5)) + " and left(LastName,1) = 'J'"

        End If
        Call updbut()
        Me.Close()
        Operator1.Show()
    End Sub


    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        If People_flag = "A" Then
            gtd$ = "SELECT * FROM Som_Permissions WHERE Permission_level >= " + Trim(Str$(1)) + " and Permission_level <= " + Trim(Str$(4)) + " and left(LastName,1) = 'K' OR left(LastName,1) = 'L' OR left(LastName,1) = 'M' and Permission_level >= " + Trim(Str$(1)) + " and Permission_level <= " + Trim(Str$(4))
        End If
        If People_flag = "O" Then
            gtd$ = "SELECT * FROM Som_Permissions WHERE Permission_level =  " + Trim(Str$(3)) + " and left(LastName,1) = 'K' OR Permission_level =  " + Trim(Str$(3)) + "and left(LastName,1) = 'L' OR Permission_level =  " + Trim(Str$(3)) + "and left(LastName,1) = 'M' OR Permission_level = " + Trim(Str$(5)) + " and left(LastName,1) = 'K' OR Permission_level = " + Trim(Str$(5)) + " and left(LastName,1) = 'L' OR Permission_level = " + Trim(Str$(5)) + " and left(LastName,1) = 'M'"
        End If
        Call updbut()
        Me.Close()
        Operator1.Show()
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        If People_flag = "A" Then
            gtd$ = "SELECT * FROM Som_Permissions WHERE Permission_level >= " + Trim(Str$(1)) + " and Permission_level <= " + Trim(Str$(4)) + " and left(LastName,1) = 'N' OR left(LastName,1) = 'O' OR left(LastName,1) = 'P' and Permission_level >= " + Trim(Str$(1)) + " and Permission_level <= " + Trim(Str$(4))
        End If
        If People_flag = "O" Then
            gtd$ = "SELECT * FROM Som_Permissions WHERE Permission_level =  " + Trim(Str$(3)) + " and left(LastName,1) = 'N' OR Permission_level =  " + Trim(Str$(3)) + "and left(LastName,1) = 'O' OR Permission_level =  " + Trim(Str$(3)) + "and left(LastName,1) = 'P' OR Permission_level = " + Trim(Str$(5)) + " and left(LastName,1) = 'N' OR Permission_level = " + Trim(Str$(5)) + " and left(LastName,1) = 'O' OR Permission_level = " + Trim(Str$(5)) + " and left(LastName,1) = 'P'"
        End If
        Call updbut()
        Me.Close()
        Operator1.Show()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If People_flag = "A" Then
            gtd$ = "SELECT * FROM Som_Permissions WHERE Permission_level >= " + Trim(Str$(1)) + " and Permission_level <= " + Trim(Str$(4)) + " and left(LastName,1) = 'Q' OR left(LastName,1) = 'R' and Permission_level >= " + Trim(Str$(1)) + " and Permission_level <= " + Trim(Str$(4))

        End If
        If People_flag = "O" Then
            gtd$ = "SELECT * FROM Som_Permissions WHERE Permission_level =  " + Trim(Str$(3)) + " and left(LastName,1) = 'Q' OR Permission_level =  " + Trim(Str$(3)) + "and left(LastName,1) = 'R' OR Permission_level = " + Trim(Str$(5)) + " and left(LastName,1) = 'Q' OR Permission_level = " + Trim(Str$(5)) + " and left(LastName,1) = 'R'"
        End If
        Call updbut()
        Me.Close()
        Operator1.Show()
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        If People_flag = "A" Then
            gtd$ = "SELECT * FROM Som_Permissions WHERE Permission_level >= " + Trim(Str$(1)) + " and Permission_level <= " + Trim(Str$(4)) + " and left(LastName,1) = 'S' OR left(LastName,1) = 'T' OR left(LastName,1) = 'U' OR left(LastName,1) = 'V' and Permission_level >= " + Trim(Str$(1)) + " and Permission_level <= " + Trim(Str$(4))
        End If
        If People_flag = "O" Then
            gtd$ = "SELECT * FROM Som_Permissions WHERE Permission_level =  " + Trim(Str$(3)) + " and left(LastName,1) = 'S' OR Permission_level =  " + Trim(Str$(3)) + "and left(LastName,1) = 'T' OR Permission_level =  " + Trim(Str$(3)) + "and left(LastName,1) = 'U' OR Permission_level =  " + Trim(Str$(3)) + "and left(LastName,1) = 'V' OR Permission_level = " + Trim(Str$(5)) + " and left(LastName,1) = 'S' OR Permission_level = " + Trim(Str$(5)) + " and left(LastName,1) = 'T' OR Permission_level = " + Trim(Str$(5)) + " and left(LastName,1) = 'U' OR Permission_level = " + Trim(Str$(5)) + " and left(LastName,1) = 'V'"
        End If

        Call updbut()
        Me.Close()
        Operator1.Show()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        If People_flag = "A" Then
            gtd$ = "SELECT * FROM Som_Permissions WHERE Permission_level >= " + Trim(Str$(1)) + " and Permission_level <= " + Trim(Str$(4)) + " and left(LastName,1) = 'W' OR left(LastName,1) = 'X' OR left(LastName,1) = 'Y' OR left(LastName,1) = 'Z' and Permission_level >= " + Trim(Str$(1)) + " and Permission_level <= " + Trim(Str$(4))
        End If
        If People_flag = "O" Then
            gtd$ = "SELECT * FROM Som_Permissions WHERE Permission_level =  " + Trim(Str$(3)) + " and left(LastName,1) = 'W' OR Permission_level =  " + Trim(Str$(3)) + "and left(LastName,1) = 'X' OR Permission_level =  " + Trim(Str$(3)) + "and left(LastName,1) = 'Y' OR Permission_level =  " + Trim(Str$(3)) + "and left(LastName,1) = 'Z' OR Permission_level = " + Trim(Str$(5)) + " and left(LastName,1) = 'W' OR Permission_level = " + Trim(Str$(5)) + " and left(LastName,1) = 'X' OR Permission_level = " + Trim(Str$(5)) + " and left(LastName,1) = 'Y' OR Permission_level = " + Trim(Str$(5)) + " and left(LastName,1) = 'Z'"
        End If

        Call updbut()
        Me.Close()
        Operator1.Show()
    End Sub

    Private Sub updbut()
        Dim ss As Integer

        stt = "Provider=sqloledb.1;" & _
            "Data Source=SOMKYDB01CIGE;Initial Catalog=Som_Database;User Id=som_database;Password=som_pa55w0rd; "

        intia = New ADODB.Recordset
        intia.Open(gtd, stt, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, )
        ss = intia.RecordCount


        Dim iii As Integer = 1
        'Do While Not intia.EOF And ss = 0      'if returns one record, will be at eof and skid, so I keep for one pass with ss variable
        Do While iii <= ss

            Select Case iii
                Case 1
                    Operator1.Button1.Text = intia.Fields("Initials").Value
                Case 2
                    Operator1.Button2.Text = intia.Fields("Initials").Value
                Case 3
                    Operator1.Button3.Text = intia.Fields("Initials").Value
                Case 4
                    Operator1.Button4.Text = intia.Fields("Initials").Value
                Case 5
                    Operator1.Button5.Text = intia.Fields("Initials").Value
                Case 6
                    Operator1.Button6.Text = intia.Fields("Initials").Value
                Case 7
                    Operator1.Button7.Text = intia.Fields("Initials").Value
                Case 8
                    Operator1.Button8.Text = intia.Fields("Initials").Value
                Case 9
                    Operator1.Button9.Text = intia.Fields("Initials").Value
                Case 10
                    Operator1.Button10.Text = intia.Fields("Initials").Value
                Case 11
                    Operator1.Button11.Text = intia.Fields("Initials").Value
                Case 12
                    Operator1.Button12.Text = intia.Fields("Initials").Value
                Case 13
                    Operator1.Button13.Text = intia.Fields("Initials").Value
                Case 14
                    Operator1.Button14.Text = intia.Fields("Initials").Value
                Case 15
                    Operator1.Button15.Text = intia.Fields("Initials").Value
                Case 16
                    Operator1.Button16.Text = intia.Fields("Initials").Value
                Case 17
                    Operator1.Button17.Text = intia.Fields("Initials").Value
                Case 18
                    Operator1.Button18.Text = intia.Fields("Initials").Value
                Case 19
                    Operator1.Button19.Text = intia.Fields("Initials").Value
                Case 20
                    Operator1.Button20.Text = intia.Fields("Initials").Value
                Case 21
                    Operator1.Button21.Text = intia.Fields("Initials").Value
                Case 22
                    Operator1.Button22.Text = intia.Fields("Initials").Value
                Case 23
                    Operator1.Button23.Text = intia.Fields("Initials").Value
                Case 24
                    Operator1.Button24.Text = intia.Fields("Initials").Value


            End Select
            intia.MoveNext()
            iii = iii + 1
            'If ss = 1 Then ss = 0

        Loop

      
        intia.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Close()

    End Sub
End Class