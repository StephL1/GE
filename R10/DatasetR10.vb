Partial Class DatasetR10
    Partial Class Som_Customer_ReturnsDataTable

        Private Sub Som_Customer_ReturnsDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.LineColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class Som_Defects_SpecDataTable

        Private Sub Som_Defects_SpecDataTable_Som_Defects_SpecRowChanging(ByVal sender As System.Object, ByVal e As Som_Defects_SpecRowChangeEvent) Handles Me.Som_Defects_SpecRowChanging

        End Sub

    End Class

End Class
