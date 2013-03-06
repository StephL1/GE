Public Class ChooseShift1
    
    Private Sub ChooseShift1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim writevar
        Dim ifile
        Dim s As Integer = 1

        mshift = "A"
        R10.btnShift.Text = "Shift A"
        
        For s = 1 To 6
            'ifile = "q:\gcommon\quality\quality_parameters\line" + Trim(Str(i)) + "\info_" + Trim(Str(i)) + ".txt"
            ifile = "c:\quality_parameters\line" + Trim(Str(s)) + "\info_" + Trim(Str(s)) + ".txt"
            writevar = mshift + vbCrLf + auditor_id(s) + vbCrLf + moperator(s) + vbCrLf + typename(s) + vbCrLf + skidnum(s) + vbCrLf
            My.Computer.FileSystem.WriteAllText(ifile, writevar, vbFalse)
            FileClose()
        Next s

        Me.Close()



    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim writevar
        Dim ifile
        Dim s As Integer = 1

        mshift = "B"
        R10.btnShift.Text = "Shift B"
        For s = 1 To 6
            'ifile = "q:\gcommon\quality\quality_parameters\line" + Trim(Str(i)) + "\info_" + Trim(Str(i)) + ".txt"
            ifile = "c:\quality_parameters\line" + Trim(Str(s)) + "\info_" + Trim(Str(s)) + ".txt"
            writevar = mshift + vbCrLf + auditor_id(s) + vbCrLf + moperator(s) + vbCrLf + typename(s) + vbCrLf + skidnum(s) + vbCrLf
            My.Computer.FileSystem.WriteAllText(ifile, writevar, vbFalse)
            FileClose()
        Next s
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim writevar
        Dim ifile
        Dim s As Integer = 1
        mshift = "C"
        R10.btnShift.Text = "Shift C"
        For s = 1 To 6
            'ifile = "q:\gcommon\quality\quality_parameters\line" + Trim(Str(i)) + "\info_" + Trim(Str(i)) + ".txt"
            ifile = "c:\quality_parameters\line" + Trim(Str(s)) + "\info_" + Trim(Str(s)) + ".txt"
            writevar = mshift + vbCrLf + auditor_id(s) + vbCrLf + moperator(s) + vbCrLf + typename(s) + vbCrLf + skidnum(s) + vbCrLf
            My.Computer.FileSystem.WriteAllText(ifile, writevar, vbFalse)
            FileClose()
        Next s

        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim writevar
        Dim ifile
        Dim s As Integer = 1

        mshift = "D"
        R10.btnShift.Text = "Shift D"
        For s = 1 To 6
            'ifile = "q:\gcommon\quality\quality_parameters\line" + Trim(Str(i)) + "\info_" + Trim(Str(i)) + ".txt"
            ifile = "c:\quality_parameters\line" + Trim(Str(s)) + "\info_" + Trim(Str(s)) + ".txt"
            writevar = mshift + vbCrLf + auditor_id(s) + vbCrLf + moperator(s) + vbCrLf + typename(s) + vbCrLf + skidnum(s) + vbCrLf
            My.Computer.FileSystem.WriteAllText(ifile, writevar, vbFalse)
            FileClose()
        Next s
        Me.Close()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()

    End Sub
End Class