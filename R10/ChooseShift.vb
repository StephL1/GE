Public Class ChooseShift

    Private Sub ChooseShift_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetAuditor.Som_Permissions' table. You can move, or remove it, as needed.
        'Me.Som_PermissionsTableAdapter.Fill(Me.DataSetAuditor.Som_Permissions)
        Try
            Me.Som_PermissionsTableAdapter.FillByPermission1(Me.DataSetAuditor.Som_Permissions)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SomPermissionsBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SomPermissionsBindingSource.CurrentChanged

    End Sub

    Private Sub FillByPermission1ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByPermission1ToolStripButton.Click
        Try
            Me.Som_PermissionsTableAdapter.FillByPermission1(Me.DataSetAuditor.Som_Permissions)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByPermission1ToolStrip_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles FillByPermission1ToolStrip.ItemClicked

    End Sub
End Class