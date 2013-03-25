'Visual Basic.Net JingCai Programming 100 Examples
'Author: Yong Zhang
'Publisher: Water Publisher China
'ISBN: 750841156
'found online at http://www.java2s.com/Tutorial/VB/0400__Socket-Network/TcpListenerbasedWebserver.htm
'edited by PNP to work as simple, non-threaded, example
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports System.Text
Imports System.IO
Imports CodeReviewSite.Login
Imports CodeReviewSite.contentManagement
Imports System.Text.RegularExpressions

Module Webserver

    Private server As WebServer = New WebServer
    Public serverIP As IPAddress
    Private trustedAddresses As List(Of String) = New List(Of String)
    Private loginStuff As New Login
    Private cm As New contentManagement
    Private db As New databaseConnection
    Private isLoggedIn As Boolean = False
    Private isAuthororAdmin As Boolean = False
    Private loggedInUsername As String

    'to add to submit a comment
    Private addCommentForm As String = "<form action =""\submit_comment"" method=""post""><legend>New Comment</legend>Leave a comment: <input type=""text"" name=""commentContent""/><br/>Article ID to comment on: <input type=""text"" name=""articleID""/><br/><input type=""submit"" value=""Submit""/></form>"""
    Private addArticleForm As String = "<form action =""\submit_article"" method=""post""><legend>New Article</legend>Submit a New Article: <input type=""text"" name=""articleContent""/><br/><input type=""submit"" value=""Submit""/></form>"""





    Sub Main()
        server.serve()
        db.connect()

    End Sub

    Public Sub openAddressOfTheServer()
        Dim address As String
        ' Dim hostName As String = Dns.GetHostName()
        'creating a valid address to go to the server's webpage
        address = "http://" + serverIP.ToString + ":8080"
        'opening that address using the default browser
        System.Diagnostics.Process.Start(address)

    End Sub


    Public Class WebServer
        Private tcpListener As System.Net.Sockets.TcpListener
        Private clientSocket As System.Net.Sockets.Socket

        ' Set WWW Root Path
        Dim rootPath As String = "www\"
        ' Set default page
        Dim defaultPage As String = "index.html"



        Public Sub serve()
            Dim hostName As String = Dns.GetHostName()


            'This FOR loop assigns the first IPv4 address it can find
            For value As Integer = 0 To Dns.GetHostEntry(hostName).AddressList.Length
                If (checkIfIPp4(Dns.GetHostEntry(hostName).AddressList(value))) = True Then
                    serverIP = Dns.GetHostEntry(hostName).AddressList(value)
                    Exit For
                End If
            Next


            Dim Port As String = "8080"

            tcpListener = New TcpListener(serverIP, Int32.Parse(Port))
            tcpListener.Start()
            Console.WriteLine("Web server started at: " & hostName & " " & serverIP.ToString() & ":" & Port)
            While (True)
                clientSocket = tcpListener.AcceptSocket()
                ' Socket Information
                Dim clientInfo As IPEndPoint = CType(clientSocket.RemoteEndPoint, IPEndPoint)
                Console.WriteLine("Client: " + clientInfo.Address.ToString() + ":" + clientInfo.Port.ToString())
                ProcessRequest()
            End While
        End Sub

        Function checkIfIPp4(ByVal address As IPAddress) As Boolean

            Dim addressAsString = address.ToString

            If (IPAddress.TryParse(addressAsString, address)) Then
                Select Case address.AddressFamily
                    Case System.Net.Sockets.AddressFamily.InterNetwork
                        'Haha, we have an IPv4 address
                        Return True
                    Case System.Net.Sockets.AddressFamily.InterNetworkV6
                        'Haha, we have an IPv6 address
                        Return False
                    Case Else
                        'Hm, we have something that isn't even an IP address...
                        Return False
                End Select

            End If

            Return False

        End Function

        Protected Sub ProcessRequest()
            Dim recvBytes(1024) As Byte
            Dim htmlReq As String = Nothing
            Dim bytes As Int32



            ' Receive HTTP Request from Web Browser
            'Some browsers send empty requests sometimes, in addition to the real requests.
            Dim tries As Integer = 10
            While tries > 0
                bytes = clientSocket.Receive(recvBytes, 0, clientSocket.Available, SocketFlags.None)
                If bytes > 0 Then
                    tries = 0
                Else
                    tries = tries - 1
                    Console.WriteLine("Failed again, retry")
                    'Pause for a moment (50 milliseconds) to wait for the next request
                    Thread.Sleep(50)
                End If
            End While

            htmlReq = Encoding.ASCII.GetString(recvBytes, 0, bytes)
            Console.WriteLine("HTTP Request: ")
            Console.WriteLine(htmlReq)
            Dim filename As String = "C:\Users\bezga_000\log.txt"
            Dim logWriter As New System.IO.StreamWriter(filename, False)


            logWriter.WriteLine(htmlReq)
            logWriter.Close()

            'Now that we have the HTTP request, let's analyse it.
            'First, let's check if it is a GET or a POST request.

            Dim strArray() As String
            Dim strRequest As String

            strArray = htmlReq.Trim.Split(" ")

            ' Determine the HTTP method (GET only)
            If strArray(0).Trim().ToUpper.Equals("GET") Then
                strRequest = strArray(1).Trim

                If (strRequest.StartsWith("/")) Then
                    strRequest = strRequest.Substring(1)
                End If

                If (strRequest.EndsWith("/") Or strRequest.Equals("")) Then
                    strRequest = strRequest & defaultPage
                End If

                strRequest = rootPath & strRequest
                sendHTMLResponse(strRequest)
            ElseIf strArray(0).Trim().ToUpper.Equals("POST") Then
                'Ladies and Getlemen, we have a POST request!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                'Deal with the post request here
                strRequest = strArray(1).Trim

                If (strRequest.StartsWith("/")) Then
                    strRequest = strRequest.Substring(1)

                    If (strRequest = "login") Then
                        'example, testing the requests
                        Dim usernameStart As Integer = htmlReq.IndexOf("username")
                        Dim usernameStop As Integer = htmlReq.IndexOf("&") - usernameStart
                        Dim passwordStart As Integer = htmlReq.IndexOf("password")
                        Dim passwordStop As Integer = htmlReq.Length - passwordStart
                        Dim usernameString As String = htmlReq.Substring(usernameStart, usernameStop)
                        Dim passwordString As String = htmlReq.Substring(passwordStart, passwordStop)


                        'okay, username string is this atm 'username=***'
                        'let's split it. Same with the password String

                        Dim usrnStrArr() As String = usernameString.Split("=")
                        Dim passwStrArr() As String = passwordString.Split("=")

                        'Splitted successfully, these are the username and the password!
                        Dim username = usrnStrArr(1)
                        Dim password = passwStrArr(1)

                        'Now that we have them extracted, let's login using them
                        Dim login As usernameClass = loginStuff.loginProcedure(username, password)

                        If (login = usernameClass.adminUser Or login = usernameClass.authorUser) Then

                            'valid user, let's tell him his login was successful
                            sendHttpResponseAsString(generateHTMLPage("Login successful, congrats! Click <a href='\show_articles'>here</a> to continue"))
                            isLoggedIn = True
                            isAuthororAdmin = True
                            loggedInUsername = username
                        ElseIf (login = usernameClass.regularUser) Then
                            sendHttpResponseAsString(generateHTMLPage("Login successful, congrats! Click <a href='\show_articles'>here</a> to continue"))
                            isLoggedIn = True
                            loggedInUsername = username
                        ElseIf (login = usernameClass.wrongPass) Then
                            'wrong password
                            sendHttpResponseAsString(generateHTMLErrorPage("Wrong password, go back and try again"))
                        ElseIf (login = usernameClass.userFrozen) Then
                            'user is frozen
                            sendHttpResponseAsString(generateHTMLErrorPage("Your user appears to be frozen. Please contact the administrator"))
                        ElseIf (login = usernameClass.userDoesntExist) Then
                            'such a user doesn't exist
                            sendHttpResponseAsString(generateHTMLErrorPage("The user you specified doesn't exist"))
                        ElseIf (login = usernameClass.unauthorisedUser) Then
                            'unauthorised user
                            sendHttpResponseAsString(generateHTMLErrorPage("Unauthorised user!"))
                        End If

                    ElseIf (strRequest = "submit_comment") Then

                        'example, testing the requests
                        Dim commentStart As Integer = htmlReq.IndexOf("commentContent")
                        Dim commentStop As Integer = htmlReq.IndexOf("&") - commentStart
                        Dim articleIDStart As Integer = htmlReq.IndexOf("articleID")
                        Dim articleIDStop As Integer = htmlReq.Length - articleIDStart
                        Dim commentString As String = htmlReq.Substring(commentStart, commentStop)
                        Dim articleIDString As String = htmlReq.Substring(articleIDStart, articleIDStop)


                        'okay, username string is this atm 'username=***'
                        'let's split it. Same with the password String

                        Dim commentStrArr() As String = commentString.Split("=")
                        Dim articleIDStrArr() As String = articleIDString.Split("=")

                        'Splitted successfully, these are the username and the password!
                        Dim CommentContent As String = commentStrArr(1)
                        Dim ArticleID = articleIDStrArr(1)

                        cm.createANewComment(CommentContent, loggedInUsername, Integer.Parse(ArticleID))
                        sendHttpResponseAsString(generateHTMLPage("Comment submitted successfully! Click <a href='\show_articles'>here</a> to continue"))

                    ElseIf (strRequest = "submit_article") Then

                        'example, testing the requests
                        Dim articleStart As Integer = htmlReq.IndexOf("articleContent")
                        Dim articleStop As Integer = htmlReq.Length - articleStart

                        Dim articleContentString As String = htmlReq.Substring(articleStart, articleStop)

                        'okay, the string is this atm 'articleContent=***'
                        'let's split it. Same with the password String

                        Dim articleStrArr() As String = articleContentString.Split("=")

                        'Splitted successfully, these are the username and the password!
                        Dim articleContent As String = articleStrArr(1)


                        cm.createANewArticle(articleContent, loggedInUsername, False)

                        sendHttpResponseAsString(generateHTMLPage("Comment submitted successfully! Click <a href='\show_articles'>here</a> to continue"))


                    End If

                    If (strRequest.EndsWith("/") Or strRequest.Equals("")) Then
                        strRequest = strRequest & defaultPage
                    End If

                End If

            Else
                'some kind of error
                strRequest = rootPath & "Error\400.html"
                sendHTMLResponse(strRequest)


            End If

            clientSocket.Close()
        End Sub

        ' Send HTTP Response
        Private Sub sendHTMLResponse(ByVal httpRequest As String)
            ' Get the file content of HTTP Request
            Dim streamReader As FileStream
            Dim response As String
            'we're gonna use regular expressions to find if the user wants to access the articles
            Dim txt As String = "www\content\articles\5"

            Dim re1 As String = "(www)"   'Word 1
            Dim re2 As String = "(.)"    'Any Single Character 1
            Dim re3 As String = "(content)"   'Word 2
            Dim re4 As String = "(.)"    'Any Single Character 2
            Dim re5 As String = "(articles)"  'Word 3
            Dim re6 As String = "(.)"    'Any Single Character 3
            Dim re7 As String = "(\d+)"   'Integer Number 1

            Dim r As Regex = New Regex(re1 + re2 + re3 + re4 + re5 + re6 + re7, RegexOptions.IgnoreCase Or RegexOptions.Singleline)
            
            Dim m As Match = r.Match(httpRequest)

            If (m.Success) Then
                'we have a reqest to the www\content\articles\*number*
                'let's extract the number of the article requested
                Dim id As Integer = Integer.Parse(httpRequest.Last)

                'send a response as a generated page
                Dim pageToSend As String = Me.generateHTMLPage(cm.createASingleArticleWithWithComments(id, isLoggedIn))
                Dim pageByte() As Byte = Encoding.ASCII.GetBytes(pageToSend)

                Dim htmlHeader1 As String = _
              "HTTP/1.0 " & "show articles" & ControlChars.CrLf & _
              "Server: WebServer 1.0" & ControlChars.CrLf & _
              "Content-Length: " & pageToSend.Length & ControlChars.CrLf & _
              "Content-Type: " & "text/html" & _
               ControlChars.CrLf & ControlChars.CrLf

                ' The content Length of HTML Header
                Dim headerByte1() As Byte = Encoding.ASCII.GetBytes(htmlHeader1)

                ' Send HTML Header back to Web Browser
                clientSocket.Send(headerByte1, 0, headerByte1.Length, SocketFlags.None)

                ' Send HTML Content back to Web Browser
                clientSocket.Send(pageByte, 0, pageByte.Length, SocketFlags.None)
                Exit Sub

            Else

                If httpRequest = "www\show_articles" Then
                    'send a response as a generated page
                    Dim pageToSend As String = Me.generateHTMLPage(cm.createAllArticlesView(isLoggedIn))
                    Dim pageByte() As Byte = Encoding.ASCII.GetBytes(pageToSend)

                    Dim htmlHeader1 As String = _
                  "HTTP/1.0 " & "show articles" & ControlChars.CrLf & _
                  "Server: WebServer 1.0" & ControlChars.CrLf & _
                  "Content-Length: " & pageToSend.Length & ControlChars.CrLf & _
                  "Content-Type: " & "text/html" & _
                   ControlChars.CrLf & ControlChars.CrLf

                    ' The content Length of HTML Header
                    Dim headerByte1() As Byte = Encoding.ASCII.GetBytes(htmlHeader1)

                    ' Send HTML Header back to Web Browser
                    clientSocket.Send(headerByte1, 0, headerByte1.Length, SocketFlags.None)

                    ' Send HTML Content back to Web Browser
                    clientSocket.Send(pageByte, 0, pageByte.Length, SocketFlags.None)
                    Exit Sub

                ElseIf httpRequest = "www\logout" Then

                    isLoggedIn = False


                End If
                If Not File.Exists(httpRequest) Then
                    httpRequest = rootPath & "Error\400.html" 'should really be 404.html
                    response = "404 Not Found"

                Else
                    response = "200 OK"
                End If

                streamReader = New FileStream(httpRequest, IO.FileMode.Open, IO.FileAccess.Read)
                Dim len As Integer = streamReader.Length
                Dim strBuff(len) As Byte
                streamReader.Read(strBuff, 0, len)
                streamReader.Close()
                streamReader = Nothing

                ' Set HTML Header
                Dim htmlHeader As String = _
                  "HTTP/1.0 " & response & ControlChars.CrLf & _
                  "Server: WebServer 1.0" & ControlChars.CrLf & _
                  "Content-Length: " & len & ControlChars.CrLf & _
                  "Content-Type: " & getContentType(httpRequest) & _
                   ControlChars.CrLf & ControlChars.CrLf

                ' The content Length of HTML Header
                Dim headerByte() As Byte = Encoding.ASCII.GetBytes(htmlHeader)
                Console.WriteLine("HTML Header: " & ControlChars.CrLf & htmlHeader)
                ' Send HTML Header back to Web Browser
                clientSocket.Send(headerByte, 0, headerByte.Length, SocketFlags.None)

                ' Send HTML Content back to Web Browser
                clientSocket.Send(strBuff, 0, len, SocketFlags.None)

            End If

            


        End Sub

        'we use this method when we want to send a String (e.g. a page generated on the fly, as opposed to a file. To send a file use the other sendHttpRequest Sub)

        Sub sendHttpResponseAsString(ByVal response As String)
            ' Get the file content of HTTP Request


            ' Set HTML Header
            Dim htmlHeader As String = _
              "HTTP/1.0 " & response & ControlChars.CrLf & _
              "Server: WebServer 1.0" & ControlChars.CrLf & _
              "Content-Length: " & response.Length & ControlChars.CrLf & _
              "Content-Type: " & "text/html" & _
               ControlChars.CrLf & ControlChars.CrLf


            ' The content Length of HTML Header
            Dim headerByte() As Byte = Encoding.ASCII.GetBytes(htmlHeader)
            Console.WriteLine("HTML Header: " & ControlChars.CrLf & htmlHeader)

            ' the content of the page as bytes
            Dim contentByte() As Byte = Encoding.ASCII.GetBytes(response)


            ' Send HTML Header back to Web Browser
            clientSocket.Send(headerByte, 0, headerByte.Length, SocketFlags.None)


            ' Send HTML Content back to Web Browser
            clientSocket.Send(contentByte, 0, contentByte.Length, SocketFlags.None)

        End Sub

        ' Get Content Type
        Private Function getContentType(ByVal httpRequest As String) As String
            If (httpRequest.EndsWith("html")) Then
                Return "text/html"
            ElseIf (httpRequest.EndsWith("htm")) Then
                Return "text/html"
            ElseIf (httpRequest.EndsWith("txt")) Then
                Return "text/plain"
            ElseIf (httpRequest.EndsWith("gif")) Then
                Return "image/gif"
            ElseIf (httpRequest.EndsWith("jpg")) Then
                Return "image/jpeg"
            ElseIf (httpRequest.EndsWith("jpeg")) Then
                Return "image/jpeg"
            ElseIf (httpRequest.EndsWith("pdf")) Then
                Return "application/pdf"
            ElseIf (httpRequest.EndsWith("pdf")) Then
                Return "application/pdf"
            ElseIf (httpRequest.EndsWith("doc")) Then
                Return "application/msword"
            ElseIf (httpRequest.EndsWith("xls")) Then
                Return "application/vnd.ms-excel"
            ElseIf (httpRequest.EndsWith("ppt")) Then
                Return "application/vnd.ms-powerpoint"
            Else
                Return "text/plain"
            End If
        End Function

        'Adds to logged in IP addresses, used for verification later. Use upon login
        Sub addToTrusted(ByRef address As String)
            trustedAddresses.Add(address)
        End Sub

        'Removes from logged in IP addresses. Use upon logoff
        Sub removeFromTrusted(ByRef address As String)
            trustedAddresses.Remove(address)
        End Sub


        'This function simply generates a simple page with the error
        Function generateHTMLErrorPage(ByVal errorMsg As String) As String
            Dim output As String = "<html><body><h1>Code Review Site</h1></br><p>" & errorMsg & "</p></body></html>"
            Return output
        End Function

        'generates an html page with some content
        Function generateHTMLPage(ByVal content As String) As String
            If (isLoggedIn) Then
                Dim output As String = "<html><body><h1><a href=""www/index.html"">Code Review Site</a></h1></br><p>" & content & "</p>" & addArticleForm & addCommentForm & "</body></html>"
                Return output
            Else
                Dim output As String = "<html><body><h1>Code Review Site</h1></br><p>" & content & "</p></body></html>"
                Return output
            End If
            
        End Function


        ' Send HTTP Response
        Private Sub sendHTMLPage(ByVal page As String)


            ' The content Length of HTML Header
            Dim headerByte() As Byte = Encoding.ASCII.GetBytes(page)
            Console.WriteLine("HTML Header: " & ControlChars.CrLf & page)

            ' the content of the content
            Dim contentByte() As Byte = Encoding.ASCII.GetBytes(page)


            ' Set HTML Header
            Dim htmlHeader As String = _
              "HTTP/1.0 " & ControlChars.CrLf & _
              "Server: WebServer 1.0" & ControlChars.CrLf & _
              "Content-Length: " & headerByte.Length() & ControlChars.CrLf & _
              "Content-Type: " & getContentType(page) & _
               ControlChars.CrLf & ControlChars.CrLf


            ' Send HTML Header back to Web Browser
            clientSocket.Send(headerByte, 0, headerByte.Length, SocketFlags.None)



        End Sub




    End Class
End Module