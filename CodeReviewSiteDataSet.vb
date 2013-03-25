Partial Class CodeReviewSiteDataSet
    Partial Class usernamesDataTable

        Private Sub usernamesDataTable_ColumnChanging(sender As System.Object, e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.usernameColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
