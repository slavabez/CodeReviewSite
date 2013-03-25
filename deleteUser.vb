Public Class deleteUser

    Dim usernamesDataAdapter As New CodeReviewSite.CodeReviewSiteDataSetTableAdapters.usernamesTableAdapter

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ProgressBar1.Value = 10
        Dim username As String = TextBox1.Text
        'First, let's check the user actually exists
        Dim checkIfExists = usernamesDataAdapter.ScalarQueryCheck(username)

        If checkIfExists Is Nothing Then
            'such username doesn't exist
            TextBox2.Text = "Such a Username doesn't exist, please check you entered it correctly..."
        Else
            'such a user exists. Let's check if he's an Admin, and if he is, 
            'then we want to double check with the user to make sure he actually 
            'wants to delete another admin
            Dim checkIfAdmin = usernamesDataAdapter.ScalarQueryCheckIfAdmin(username, True)

            If checkIfAdmin Is Nothing Then
                'Not an Admin, proceed to delete the username
                usernamesDataAdapter.DeleteQueryDeleteUsername(username)
                ProgressBar1.Value = 100
                TextBox2.Text = "The user with username '" & username & "' was deleted successfully"
            Else
                'Count admins, if there is more than one, proceed, if less, stop the user
                'from being able to delete the last ADMIN

                Dim adminCount = usernamesDataAdapter.ScalarQueryCountAdmins
                If adminCount > 1 Then

                    'warn user about deleting an admin
                    Dim reply As DialogResult = MessageBox.Show("You are trying to delete a user who is an Administrator! Are you sure you want to delete him?", "What is this sorcery?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

                    If reply = Windows.Forms.DialogResult.Yes Then
                        'Yes, he is sure he wants to delete the user
                        usernamesDataAdapter.DeleteQueryDeleteUsername(username)
                        ProgressBar1.Value = 100
                        TextBox2.Text = "The user with username '" & username & "' was deleted successfully"
                    Else
                        'No, he doesn't actually want to delete the user
                        'clear the TextBox, clear the ProgressBar
                        TextBox1.Text = ""
                        TextBox2.Text = ""
                        ProgressBar1.Value = 0


                    End If

                Else
                    TextBox2.Text = "OPERATION ABORTED. I am sorry, but there is only one administrator left. The last administrator cannot be deleted."
                End If




                

            End If

        End If

    End Sub
End Class