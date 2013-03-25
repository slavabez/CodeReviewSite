Public Class addUser

    Private Sub UsernamesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.UsernamesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CodeReviewSiteDataSet)

    End Sub


    Private Sub UsernamesBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs) Handles UsernamesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsernamesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CodeReviewSiteDataSet)

    End Sub

    Private Sub addUser_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CodeReviewSiteDataSet.usernames' table. You can move, or remove it, as needed.
        Me.UsernamesTableAdapter.Fill(Me.CodeReviewSiteDataSet.usernames)
        BindingNavigatorAddNewItem.PerformClick()

    End Sub
End Class