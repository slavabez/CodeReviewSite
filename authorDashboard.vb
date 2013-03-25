Imports CodeReviewSite.contentManagement
Imports CodeReviewSite.Login
Public Class authorDashboard
    Dim currentUser As String

    Dim cm As New contentManagement
    Private Sub ArticlesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ArticlesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CodeReviewSiteDataSet)

    End Sub

    Private Sub authorDashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CodeReviewSiteDataSet.articles' table. You can move, or remove it, as needed.
        Me.ArticlesTableAdapter.Fill(Me.CodeReviewSiteDataSet.articles)

        loggedInAs.Text = currentUser

    End Sub

    Private Sub btnSubmitArticle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmitArticle.Click
        Dim content As String = TextBox1.Text

        Dim isPrivate As Boolean = privateBox.Checked
        cm.createANewArticle(content, currentUser, isPrivate)

        btnRefresh.PerformClick()


    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        ArticlesTableAdapter.Dispose()
        ArticlesTableAdapter.Fill(Me.CodeReviewSiteDataSet.articles)
    End Sub

    Private Sub btnComment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComment.Click
        Dim content As String = commentTxtBox.Text
        Dim articleID As Integer = Integer.Parse(articleIDTxtBox.Text)


        cm.createANewComment(content, currentUser, articleID)


    End Sub

    Private Sub btnEditArticle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditArticle.Click
        EditArticle.Show()
    End Sub

    Private Sub btnDeleteArticle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteArticle.Click
        'deleting an article
        Dim articleID As Integer = Integer.Parse(ArticleIDToDelete.Text)
        'first check if the user is the author
        If cm.checkIfAuthor(currentUser, articleID) Then
            'user is the author
            cm.deleteArticle(articleID)
        Else
            'user is not the author
            MsgBox("That's not your article, I'm afraid I can't delete that...")
        End If
    End Sub

    Sub setUser(ByVal username As String)
        Me.currentUser = username
    End Sub

    Private Sub ArticleIDToDelete_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArticleIDToDelete.TextChanged
        If ArticleIDToDelete.Text Is Nothing Then
            btnDeleteArticle.Enabled = False
        End If
    End Sub
End Class