Imports System.Net
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports CodeReviewSite.CodeReviewSiteDataSetTableAdapters





Public Enum usernameClass
    'this class will show what reply you get. Makes life a bit easier with enums
    adminUser = 6
    authorUser = 5
    regularUser = 4
    unauthorisedUser = 3
    userDoesntExist = 2
    userFrozen = 1
    wrongPass = 0


End Enum


Public Class Login

    Public usernameLoggedIn As String = Nothing

    'user for DB access
    Dim usernamesDataAdapter As New CodeReviewSite.CodeReviewSiteDataSetTableAdapters.usernamesTableAdapter

    'This function will take care of loggin in and returning the kind if user the user is using usernameClass enumerated values
    Public Function loginProcedure(ByRef username As String, ByRef password As String) As usernameClass

        Dim login = usernamesDataAdapter.ScalarQueryLogin(username, password)

        If login Is Nothing Then

            Dim checkIfExists = usernamesDataAdapter.ScalarQueryCheck(username)

            If checkIfExists Is Nothing Then
                'the user doesn't exist
                'MsgBox("The user with the entered username does not exist")
                Return usernameClass.userDoesntExist

            Else
                'the user does exist, decrease his invalidAttempts.
                'If invalid attempts are equal to zero or less, then freeze the account
                Dim checkIfFrozen = usernamesDataAdapter.ScalarQueryCheckIsFrozen(username, True)

                If checkIfFrozen Is Nothing Then
                    'The account is not frozen, decrease the number of invalidAttempts, freeze if neccessary
                    usernamesDataAdapter.UpdateQueryDecreaseInvalidAttemptsByOne(username)

                    'check if invalidAttempts = 0
                    Dim checkIfZero = usernamesDataAdapter.ScalarQueryCheckInvalidAttempts(username, 0)
                    Dim checkIfThisIsAdmin = usernamesDataAdapter.ScalarQueryCheckIfAdmin(username, True)
                    If checkIfThisIsAdmin Is Nothing Then
                        'not an admin, proceed to freeze
                        If checkIfZero Is Nothing Then
                            'the invalidAttempts field is not equal to zero, do nothing
                        Else
                            'the invalidAttemots field is equal to zero, proceed to Freeze this account
                            usernamesDataAdapter.UpdateQuerySetToFrozen(username)
                        End If
                    Else
                        'is admin, let's first check if he is the last admin
                        Dim numberOfNonFrozenAdminsLeft As Integer = usernamesDataAdapter.returnNumberOfNonFrozenAdmins()
                        If (numberOfNonFrozenAdminsLeft < 2) Then
                            '1 admin left, don't freeze
                            MsgBox("Looks like you are the last non-frozen admin...")
                        Else
                            'more than 1 admin left, freeze!
                            usernamesDataAdapter.UpdateQuerySetToFrozen(username)
                        End If
                    End If


                Else
                    'The account is Frozen, display the requred prompt
                    'MsgBox("Your username has been frozen to prevent your account from being hacked. Please contact your Administrator.")
                    Return usernameClass.userFrozen
                End If

            End If

            'MessageBox.Show("Wrong password. Note that your account will get frozen if you enter a wrong password three times.")
            Return usernameClass.wrongPass

        Else
            'Logged in successfully, such user exists
            'Now let's check whether the user is an admin. If he's an admin, he can't be frozen
            'A non-admin user that is frozen shouldn't be loggedin



                Dim checkIfFrozen = usernamesDataAdapter.ScalarQueryCheckIsFrozen(username, True)
                If checkIfFrozen Is Nothing Then
                    'not frozen. Now let's check if the user is an Author

                Dim checkIfAdmin = usernamesDataAdapter.ScalarQueryCheckIfAdmin(username, True)
                If checkIfAdmin Is Nothing Then
                    'not an admin

                    Dim checkIfAuthor = usernamesDataAdapter.ScalarQueryCheckIfAuthor(username, True)
                    If checkIfAuthor Is Nothing Then
                        'not an Author, log his in as a standard user
                        'MsgBox("Welcome, " & username & ". You have successfully logged in as a User, now taking you to your Dashboard.")
                        usernameLoggedIn = username
                        restoreinvalidAttempts(username)
                        Return usernameClass.regularUser
                    Else
                        'Author, log him into the Author dashboard
                        'MsgBox("Welcome, " & username & ". You have successfully logged in as an Author, now taking you to your Dashboard.")
                        usernameLoggedIn = username
                        restoreinvalidAttempts(username)
                        Return usernameClass.authorUser
                    End If
                Else
                    'Admin user
                    usernameLoggedIn = username
                    restoreinvalidAttempts(username)
                    Return usernameClass.adminUser
                End If
                'Frozen user
                'MsgBox("It looks like your username has been frozen due to security reasons. Please contact an Administrator.")
                Return usernameClass.userFrozen
            End If


            
            End If


            'Login was successful, restore number of invalid attempts back to 3
            restoreinvalidAttempts(username)

        Return usernameClass.unauthorisedUser


    End Function

    'restores the number of invalid attempts. Make sure such login exists, otherwise will do nothing
    Sub restoreinvalidAttempts(ByRef username As String)
        usernamesDataAdapter.UpdateQueryRefreshInvalidAttempts(username)
    End Sub

    Function getLoggedInUsername() As String
        Return usernameLoggedIn
    End Function

End Class
