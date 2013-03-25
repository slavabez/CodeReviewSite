Imports System.Threading
Imports System.Net
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports CodeReviewSite


Public Class dashboard

    Dim serverThread As Thread
    Dim loginStuff As New Login
    Dim contentManagementStuff As New contentManagement
    Dim db As New databaseConnection


    Dim dataSet As New CodeReviewSiteDataSet()

    Dim usernamesDataAdapter As New CodeReviewSite.CodeReviewSiteDataSetTableAdapters.usernamesTableAdapter




    Private Sub dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'initialises and starts the Web Server
        serverThread = New Thread(AddressOf Webserver.Main)
        serverThread.Start()

        contentManagementStuff.createDirectoriesForEachUser()

        contentManagementStuff.deleteDirectoriesForAUser("frozen")

        db.connect()

        

    End Sub

    Private Sub LblLinkToPortfolios_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LblLinkToPortfolios.LinkClicked
        'Opens the address in the default browser
        Webserver.openAddressOfTheServer()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usrnBox.TextChanged
        'Only if there's something in BOTH the username and the password field the login button will be displayed
        If usrnBox.Text.Length > 0 Then
            If pswdTxtBox.Text.Length > 0 Then
                btnLogin.Enabled = True
            Else
                btnLogin.Enabled = False
            End If
        Else
            btnLogin.Enabled = False
        End If
    End Sub

    Private Sub pswdTxtBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pswdTxtBox.TextChanged
        'Only if there's something in BOTH the username and the password field the login button will be displayed
        If usrnBox.Text.Length > 0 Then
            If pswdTxtBox.Text.Length > 0 Then
                btnLogin.Enabled = True
            Else
                btnLogin.Enabled = False
            End If
        Else
            btnLogin.Enabled = False
        End If
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        
        Dim username As String = usrnBox.Text
        Dim password As String = pswdTxtBox.Text

        Dim userType As usernameClass = loginStuff.loginProcedure(username, password)


        If userType = usernameClass.adminUser Then
            Me.loginAsAdmin(username)
        ElseIf userType = usernameClass.authorUser Then
            Me.loginAsAuthor(username)
        ElseIf userType = usernameClass.regularUser Then
            Me.loginAsRegularUser(username)
        ElseIf userType = usernameClass.unauthorisedUser Then
            MsgBox("Wrong password!")
        ElseIf userType = usernameClass.userDoesntExist Then
            MsgBox("User specified does not exist")
        ElseIf userType = usernameClass.userFrozen Then
            MsgBox("The user you specified is currently frozen due to a security risk. Please contact a system administrator")
        ElseIf userType = usernameClass.wrongPass Then
            MsgBox("Wrong password!")
        Else
            MsgBox("Some kind of error occured... Try again")
        End If




    End Sub

    

    Private Sub exitBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitBtn.Click
        serverThread.Abort()

        Me.Close()

    End Sub

    Private Sub dashboard_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            If btnLogin.Enabled Then
                btnLogin.PerformClick()
            End If
        End If


    End Sub

    Private Sub dashboard_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            If btnLogin.Enabled Then
                btnLogin.PerformClick()

            End If
        End If
    End Sub

    Private Sub loginAsAdmin(ByVal username As String)
        adminDashboard.setUser(username)
        adminDashboard.Show()

        Me.Hide()
    End Sub

    Private Sub loginAsAuthor(ByVal username As String)
        authorDashboard.setUser(username)
        authorDashboard.Show()

        Me.Hide()
    End Sub

    Private Sub loginAsRegularUser(ByVal username As String)
        userDashboard.setUser(username)
        userDashboard.Show()

        Me.Hide()
    End Sub
End Class
