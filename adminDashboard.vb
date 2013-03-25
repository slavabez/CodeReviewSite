Public Class adminDashboard

    Public currentUser As String

    Private Sub adminDashboard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CodeReviewSiteDataSet.usernames' table. You can move, or remove it, as needed.
        Me.UsernamesTableAdapter.Fill(Me.CodeReviewSiteDataSet.usernames)
        'TODO: This line of code loads data into the 'CodeReviewSiteDataSet.usernames' table. You can move, or remove it, as needed.
        Me.UsernamesTableAdapter.Fill(Me.CodeReviewSiteDataSet.usernames)

    End Sub

    Private Sub AdminViewSelectToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.UsernamesTableAdapter.adminViewSelect(Me.CodeReviewSiteDataSet.usernames)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub AdminViewSelect1ToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.UsernamesTableAdapter.adminViewSelect1(Me.CodeReviewSiteDataSet.usernames)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.UsernamesTableAdapter.FillBy(Me.CodeReviewSiteDataSet.usernames)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub AdminViewSelect1ToolStrip_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub AdminViewSelectToolStripButton_Click_1(sender As System.Object, e As System.EventArgs)
        Try
            Me.UsernamesTableAdapter.adminViewSelect(Me.CodeReviewSiteDataSet.usernames)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub AdminViewSelect1ToolStripButton_Click_1(sender As System.Object, e As System.EventArgs)
        Try
            Me.UsernamesTableAdapter.adminViewSelect1(Me.CodeReviewSiteDataSet.usernames)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub addUserBtn_Click(sender As System.Object, e As System.EventArgs) Handles addUserBtn.Click
        addUser.Show()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ' DataGridView1.Enabled = False
        ' DataGridView1.Refresh()
        ' DataGridView1.Update()
        ' DataGridView1.Enabled = True
        ' Me.UsernamesTableAdapter.Fill(Me.CodeReviewSiteDataSet.usernames)
        Me.UsernamesTableAdapter.Dispose()
        Me.UsernamesTableAdapter.Fill(Me.CodeReviewSiteDataSet.usernames)



    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        deleteUser.Show()

    End Sub

    Private Sub btnGoToContentManagement_Click(sender As System.Object, e As System.EventArgs) Handles btnGoToContentManagement.Click
        adminDashContentControl.Show()
    End Sub

    Sub setUser(ByVal username As String)
        Me.currentUser = username
    End Sub
End Class