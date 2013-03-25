Imports CodeReviewSite.contentManagement

Public Class adminDashContentControl

    Dim cm As New contentManagement

    Private Sub CommentsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CommentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CodeReviewSiteDataSet)

    End Sub

    Private Sub adminDashContentControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CodeReviewSiteDataSet.articles' table. You can move, or remove it, as needed.
        Me.ArticlesTableAdapter.Fill(Me.CodeReviewSiteDataSet.articles)
        'TODO: This line of code loads data into the 'CodeReviewSiteDataSet.comments' table. You can move, or remove it, as needed.
        Me.CommentsTableAdapter.Fill(Me.CodeReviewSiteDataSet.comments)
        Me.lblLoggedInAs.Text = adminDashboard.currentUser

    End Sub

    Private Sub btnOpenArticle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenArticle.Click
        'open the article with that ID
        Dim articleId As Integer = Integer.Parse(articleIDTxtBox.Text)

        articleTxtBox.Text = cm.loadArticle(articleId)

    End Sub

    Private Sub btnOverwriteArticle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOverwriteArticle.Click
        Dim articleId As Integer = Integer.Parse(articleIDTxtBox.Text)
        Dim content As String = articleTxtBox.Text

        cm.overwriteArticle(articleId, content)


    End Sub

    Private Sub btnAddArticle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddArticle.Click
        Dim content As String = articleTxtBox.Text
        Dim isPrivate As Boolean = privateBox.Checked

        cm.createANewArticle(content, adminDashboard.currentUser, isPrivate)
        btnArticleRefresh.PerformClick()

    End Sub

    Private Sub btnArticleRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArticleRefresh.Click
        'refreshing the table
        Me.ArticlesTableAdapter.Dispose()
        Me.ArticlesTableAdapter.Fill(Me.CodeReviewSiteDataSet.articles)
    End Sub

    Private Sub btnDeleteArticle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteArticle.Click
        Dim articleId As Integer = Integer.Parse(articleIDTxtBox.Text)

        cm.deleteArticle(articleId)
        btnArticleRefresh.PerformClick()
    End Sub

    Private Sub btnEditComment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditComment.Click
        Dim commentID As Integer = Integer.Parse(commentIDTxtBox.Text)

        CommentTxtBox.Text = cm.loadComment(commentID)

    End Sub

    Private Sub btnDeleteComment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteComment.Click
        Dim commentID As Integer = Integer.Parse(commentIDTxtBox.Text)

        cm.deleteComment(commentID)
        btnCommentRefresh.PerformClick()



    End Sub

    Private Sub btnCommentRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommentRefresh.Click
        'refreshing the comments DB view
        Me.CommentsTableAdapter.Dispose()
        Me.CommentsTableAdapter.Fill(Me.CodeReviewSiteDataSet.comments)
    End Sub

    Private Sub btnOverwriteComment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOverwriteComment.Click
        Dim commentID As Integer = Integer.Parse(commentIDTxtBox.Text)
        Dim content As String = CommentTxtBox.Text

        cm.overwriteComment(commentID, content)

    End Sub

    Private Sub btnAddComment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddComment.Click
        'the article on which to comment on
        Dim articleId As Integer = Integer.Parse(articleIdToCommentOnTxtBox.Text)
        Dim content As String = CommentTxtBox.Text

        cm.createANewComment(content, adminDashboard.currentUser, articleId)

        btnCommentRefresh.PerformClick()


    End Sub
End Class