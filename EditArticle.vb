Imports CodeReviewSite.contentManagement

Public Class EditArticle
    Dim cm As New contentManagement
    Dim currentUser As String = authorDashboard.loggedInAs.Text
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'let's determine if the user is the author. If yes, let him open the file
        'otherwise nope
        Dim articleID As Integer = Integer.Parse(articleIDTxtBox.Text)

        If cm.checkIfAuthor(currentUser, articleID) Then
            TextBox1.Text = cm.loadArticle(articleID)
        Else
            TextBox1.Text = "Sorry, but you are not the author of that article, I'm afraid I can't let you edit it..."
        End If

        

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'here we want to save the article again to a new one
        'again, first check if the author is the owner (he might have changed the article ID)
        Dim articleID As Integer = Integer.Parse(articleIDTxtBox.Text)
        Dim content As String = TextBox1.Text

        If cm.checkIfAuthor(currentUser, articleID) Then
            cm.overwriteArticle(articleID, content)
        Else
            TextBox1.Text = "Sorry, but you are not the author of that article, I'm afraid I can't let you overwrite it..."
        End If

    End Sub
End Class