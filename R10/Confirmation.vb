Public Class Confirmation

    Private Sub ok_Click(sender As System.Object, e As System.EventArgs) Handles ok.Click
        ''
        ''Dim obj As New R10
        ''obj.Show()
        Me.Close()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sampletext As String
        sampletext = "Sample less than " + MinInsp
        Label1.Text = sampletext
    End Sub
End Class