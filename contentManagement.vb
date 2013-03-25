Imports CodeReviewSite
Imports System.IO
Imports System.Text
Imports CodeReviewSite.CodeReviewSiteDataSetTableAdapters

Public Class contentManagement

    Dim db As New databaseConnection
    'this class will be used to add/delete/manage articles and comments
    'This central class will be accessible by the web-server and the application

    Dim usernamesDataAdapter As New CodeReviewSiteDataSetTableAdapters.usernamesTableAdapter
    Private addCommentForm As String = "<form action =""\submit_comment"" method=""post"">Leave a comment: <input type=""text"" name=""comment""/><br/>Article ID to comment on: <input type=""text"" name=""articleID""/><br/><input type=""submit"" value=""Submit""/></form>"""




    Public Sub createDirectoriesForEachUser()

        Dim pathToContent As String = "content/users/"
        'numer of users
        Dim numberOfUsers As Integer = usernamesDataAdapter.ScalarQueryReturnNumberOfUsers
        Dim users(numberOfUsers) As String
        Dim int As Integer = 0
        Dim selectedUser As String




        'first let's check the main directory exists
        If (Not System.IO.Directory.Exists(pathToContent)) Then
            System.IO.Directory.CreateDirectory(pathToContent)
        End If
        db.connect()

        Dim sqlSelect As String = "SELECT username FROM usernames"

        Dim usernamesDS As New DataSet
        usernamesDS = db.sqlSelectQuery(sqlSelect)
        

        'looping through each username, making sure directories are created if non-existant
        For value As Integer = 0 To numberOfUsers - 1
            'assign the name of the user to the string
            selectedUser = usernamesDS.Tables("Results").Rows(value).Item(0)
            'now create all the neccessary directories etc.
            'setting up the two paths
            Dim articlesPath As String = pathToContent & selectedUser & "/articles"
            Dim commentsPath As String = pathToContent & selectedUser & "/comments"
            'if paths do't exist, create them
            If (Not System.IO.Directory.Exists(articlesPath)) Then
                System.IO.Directory.CreateDirectory(articlesPath)
            End If
            If (Not System.IO.Directory.Exists(commentsPath)) Then
                System.IO.Directory.CreateDirectory(commentsPath)
            End If
        Next



    End Sub

    Function numberOfUsernames() As Integer
        Dim number As Integer = usernamesDataAdapter.ScalarQueryReturnNumberOfUsers
        Return number
    End Function

    Sub createDirectoriesForANewUser(ByVal username As String)
        'creating directories for coments and articles
        If (Not System.IO.Directory.Exists("content/users/" & username & "/articles")) Then
            System.IO.Directory.CreateDirectory("content/users/" & username & "/articles")
        End If
        If (Not System.IO.Directory.Exists("content/users/" & username & "/comments")) Then
            System.IO.Directory.CreateDirectory("content/users/" & username & "/comments")
        End If

    End Sub

    Sub deleteDirectoriesForAUser(ByVal username As String)
        'first delete sub directories
        If (System.IO.Directory.Exists("content/users/" & username & "/articles")) Then
            System.IO.Directory.Delete("content/users/" & username & "/articles")
        End If
        If (System.IO.Directory.Exists("content/users/" & username & "/comments")) Then
            System.IO.Directory.Delete("content/users/" & username & "/comments")
        End If
        'now delete the main folder for the user
        If (System.IO.Directory.Exists("content/users/" & username)) Then
            System.IO.Directory.Delete("content/users/" & username)
        End If

    End Sub

    Sub createANewArticle(ByVal content As String, ByVal authorName As String, ByVal isPrivate As Boolean)
        'update the database
        usernamesDataAdapter.InsertArticleByUsernameAndPrivate(authorName, isPrivate)
        'find out what ID the article was assigned
        Dim generatedID As Integer = usernamesDataAdapter.SelectLastArticleIDFromThatAuthor(authorName)
        'now we can create the actual file



        'finally, let's create a file with that article
        Dim fileName As String = generatedID & ".art"
        Dim path As String = "content/users/" & authorName & "/articles/" & fileName
        'false means it's overwritten
        Dim wr As New System.IO.StreamWriter(path, False)
        wr.WriteLine(content)
        wr.Close()

        MsgBox("Article submitted successfully!")

    End Sub

    Sub createANewComment(ByVal content As String, ByVal authorName As String, ByVal articleID As Integer)
        'update the DB
        usernamesDataAdapter.InsertQueryAddNewCommentByUsrnmArticleID(authorName, articleID)
        'find out what ID the comment got
        Dim generatedID As Integer = usernamesDataAdapter.ScalarQueryGetLastCommentIDFromThatAuthor(authorName)
        'now let's create the actual comment

        Dim fileName As String = generatedID & ".comm"
        Dim path As String = "content/users/" & authorName & "/comments/" & fileName
        'false means it's overwritten
        Dim wr As New System.IO.StreamWriter(path, False)
        wr.WriteLine(content)
        wr.Close()

        MsgBox("Comment submitted successfully!")

    End Sub

    Function loadArticle(ByVal articleID As Integer) As String
        'first let's find who wrote the article (so we know where to look for it)
        Dim author As String = usernamesDataAdapter.findAuthorOfArticleID(articleID)
        'now that we have the author name, we know which folder to look into
        'path of the article file
        Dim filePath As String = "content/users/" & author & "/articles/" & articleID & ".art"
        Dim fileContents As String
        Try
            Using sr As New StreamReader(filePath)
                'reading the file...
                fileContents = sr.ReadToEnd()
            End Using
        Catch e As Exception
            MsgBox("File couldn't be read...")
            fileContents = "File couldn't be read..."
        End Try

        Return fileContents

    End Function

    Function checkIfAuthor(ByVal username As String, ByVal articleID As Integer) As Boolean
        'checking if the username is the author of the article
        Dim check = usernamesDataAdapter.ScalarQueryCheckIfAuthorOfArticle(username, articleID)

        If check Is Nothing Then
            'the username IS NOT the author
            Return False
        Else
            'the username IS the author
            Return True
        End If
    End Function

    Sub deleteArticle(ByVal articleID As Integer)
        'let's first determine who the author is
        Dim author As String = usernamesDataAdapter.findAuthorOfArticleID(articleID)

        'let's first delete it from the DB
        usernamesDataAdapter.DeleteArticleById(articleID)

        'now let's delete the file
        Dim path As String = "content/users/" & author & "/articles/" & articleID & ".art"

        If System.IO.File.Exists(path) = True Then

            System.IO.File.Delete(path)
            MsgBox("Article Deleted")
        Else
            MsgBox("File not found...")
        End If

    End Sub

    Sub overwriteArticle(ByVal articleID As Integer, ByVal content As String)
        'Editing the article. Essentially just editing the contents

        'let's first determine who the author is
        Dim author As String = usernamesDataAdapter.findAuthorOfArticleID(articleID)


        'now let's overwrite the file
        Dim path As String = "content/users/" & author & "/articles/" & articleID & ".art"

        
        'false means it's overwritten
        Dim wr As New System.IO.StreamWriter(path, False)
        wr.WriteLine(content)
        wr.Close()

        MsgBox("Article overwritten successfully!")
    End Sub

    Function loadComment(ByVal articleID As Integer) As String
        'first let's find who wrote the article (so we know where to look for it)
        Dim author As String = usernamesDataAdapter.FindAuthorOfCommentById(articleID)
        'now that we have the author name, we know which folder to look into
        'path of the article file
        Dim filePath As String = "content/users/" & author & "/comments/" & articleID & ".comm"
        Dim fileContents As String
        Try
            Using sr As New StreamReader(filePath)
                'reading the file...
                fileContents = sr.ReadToEnd()
            End Using
        Catch e As Exception
            MsgBox("File couldn't be read...")
            fileContents = "File couldn't be read..."
        End Try

        Return fileContents

    End Function

    Sub deleteComment(ByVal commentID As Integer)
        'let's first determine who the author is
        Dim author As String = usernamesDataAdapter.FindAuthorOfCommentById(commentID)

        'let's first delete it from the DB
        usernamesDataAdapter.DeleteCommentById(commentID)

        'now let's delete the file
        Dim path As String = "content/users/" & author & "/comments/" & commentID & ".comm"

        If System.IO.File.Exists(path) = True Then

            System.IO.File.Delete(path)
            MsgBox("Comment Deleted")
        Else
            MsgBox("File not found...")
        End If

    End Sub

    Sub overwriteComment(ByVal CommentID As Integer, ByVal content As String)
        'Editing the comment. Essentially just editing the contents

        'let's first determine who the author is
        Dim author As String = usernamesDataAdapter.FindAuthorOfCommentById(CommentID)


        'now let's overwrite the file
        'determining path to the file
        Dim path As String = "content/users/" & author & "/comments/" & CommentID & ".comm"


        'false means it's overwritten (as opposed to adding to the file)
        Dim wr As New System.IO.StreamWriter(path, False)
        wr.WriteLine(content)
        wr.Close()

        MsgBox("Comment overwritten successfully!")
    End Sub

    Function createAllArticlesView(ByVal showPrivate As Boolean) As String
        'this function should create an assembly of all articles in a single html format string
        'we'll begin by getting the content of all articles
        Dim numbOfArticles As Integer = usernamesDataAdapter.GetNumberOfArticles()


        db.connect()

        db.resetDataSet()


        Dim sqlSelect As String = "SELECT * FROM articles"
        'dataSet with all the articles
        Dim artDS As New DataSet
        artDS.Reset()
        artDS = db.sqlSelectQuery(sqlSelect)
        'For each article, we want a string that looks like this:
        '<p>Article by: <strong>*username*</strong></p></br>*content*</br><a ref="*articles/username/ID*">View comments</a>
        
        'let's create those template strings
        Dim auxStrings() As String = {"<p>Article by: <strong>", "</strong></p></br>", "</br><a href=", Char.ToString(Chr(34)), "/content/articles/", "id", ">View comments</a><hr>"}
        Dim author As String
        Dim id As String
        Dim content As String
        Dim compiledString As String = ""



        For value As Integer = 0 To numbOfArticles - 1
            'let's see if it's hidden or not (private)
            Dim isPrivate As Boolean
            If (artDS.Tables("Results").Rows(value).Item(3) = True) Then
                isPrivate = True
            Else
                isPrivate = False
            End If

            If isPrivate = True And showPrivate = False Then
                'don't add the article
            Else
                'add the article

                'assign the name of the user to the string
                'selectedUser = usernamesDS.Tables("Results").Rows(value).Item(0)
                'ID of the article
                id = artDS.Tables("Results").Rows(value).Item(0)
                'username of the autor
                author = artDS.Tables("Results").Rows(value).Item(1)

                content = Me.loadArticle(Integer.Parse(id))

                compiledString = compiledString & auxStrings(0) & author & auxStrings(1) & content & auxStrings(2) & auxStrings(3) & auxStrings(4) & id & auxStrings(3) & auxStrings(6)

            End If
            
        Next
        db.closeConnection()


        Return compiledString

    End Function


    Function createASingleArticleWithWithComments(ByVal articleID As Integer, ByVal showPrivate As Boolean)
        'we want to assemble an html page containing the article and all of the comments below it that are linked to that particular article
        db.connect()

        Dim content As String = ""
        Dim isArticlePrivate As Boolean = usernamesDataAdapter.getPrivateByArticleID(articleID)

        If (isArticlePrivate = True) And (showPrivate = False) Then
            db.closeConnection()

            Return "Sorry, the article you requested is private, you need to be logged in to see it..."
        Else


            Dim articleContent As String = loadArticle(articleID)
            'determine how many comments the article has
            Dim numOfComments As Integer = usernamesDataAdapter.getNumberOfCommentsForThatArticleID(articleID)

            content = "<h2>Article View</h2>" & content & articleContent & "<hr>"

            'now let's extract the data about that article's comments
            db.resetDataSet()

            Dim sqlSelect As String = "SELECT ID, username FROM comments WHERE articleID = (" & articleID & ")"
            'dataSet with all the articles
            Dim artDS As New DataSet
            artDS.Reset()
            artDS = db.sqlSelectQuery(sqlSelect)

            If artDS Is Nothing Then
                MsgBox("Data not found in the database")
                Return "Database Error"
            Else
                For value As Integer = 0 To numOfComments - 1

                    'getting ID of the comment
                    Dim id As Integer = Integer.Parse(artDS.Tables("Results").Rows(value).Item(0))

                    'getting the author
                    Dim author As String = artDS.Tables("Results").Rows(value).Item(1)

                    'getting content of the comment
                    Dim commentContent As String = loadComment(id)


                    'compiledString = compiledString & auxStrings(0) & author & auxStrings(1) & content & auxStrings(2) & auxStrings(3) & auxStrings(4) & author & auxStrings(5) & id & auxStrings(3) & auxStrings(6)
                    'now add the comment to the output string

                    content = content & "<p>Comment by: <strong>" & author & "</strong></p>" & commentContent & "<br>"

                Next
            End If

            '<p>Article by: <strong>*username*</strong></p></br>*content*</br><hr><p>Comments</p>
            'then for each comment
            '<p>Comment by: <strong>*username*</strong></p>*content*<br>

            'let's create those template strings
            db.closeConnection()

            'content = content & addCommentForm
            Return content
        End If
    End Function
End Class
