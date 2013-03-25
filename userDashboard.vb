Imports CodeReviewSite.contentManagement

Public Class userDashboard
    Dim currentUser As String
    Dim cm As New contentManagement


    Sub setUser(ByVal username As String)
        Me.currentUser = username
    End Sub

    Private Sub ArticlesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ArticlesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CodeReviewSiteDataSet)

    End Sub

    Private Sub userDashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CodeReviewSiteDataSet.articles' table. You can move, or remove it, as needed.
        Me.ArticlesTableAdapter.Fill(Me.CodeReviewSiteDataSet.articles)

        Label4.Text = Me.currentUser

    End Sub

    Private Sub btnComment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComment.Click
        Dim articleID As Integer = Integer.Parse(articleIDtxtBox.Text)
        Dim content As String = TextBox2.Text

        cm.createANewComment(content, currentUser, articleID)

        btnRefresh.PerformClick()


    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        'refresh
        Me.TableAdapterManager.Dispose()
        Me.TableAdapterManager.UpdateAll(Me.CodeReviewSiteDataSet)
    End Sub
End Class