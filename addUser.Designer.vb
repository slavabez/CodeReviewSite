<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim AdminLabel As System.Windows.Forms.Label
        Dim AuthorLabel As System.Windows.Forms.Label
        Dim FrozenLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addUser))
        Me.CodeReviewSiteDataSet = New CodeReviewSite.CodeReviewSiteDataSet()
        Me.UsernamesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsernamesTableAdapter = New CodeReviewSite.CodeReviewSiteDataSetTableAdapters.usernamesTableAdapter()
        Me.TableAdapterManager = New CodeReviewSite.CodeReviewSiteDataSetTableAdapters.TableAdapterManager()
        Me.UsernamesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.AdminCheckBox = New System.Windows.Forms.CheckBox()
        Me.AuthorCheckBox = New System.Windows.Forms.CheckBox()
        Me.FrozenCheckBox = New System.Windows.Forms.CheckBox()
        Me.UsernamesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        AdminLabel = New System.Windows.Forms.Label()
        AuthorLabel = New System.Windows.Forms.Label()
        FrozenLabel = New System.Windows.Forms.Label()
        CType(Me.CodeReviewSiteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsernamesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsernamesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UsernamesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(8, 31)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(58, 13)
        UsernameLabel.TabIndex = 8
        UsernameLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(8, 57)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 10
        PasswordLabel.Text = "Password:"
        '
        'AdminLabel
        '
        AdminLabel.AutoSize = True
        AdminLabel.Location = New System.Drawing.Point(8, 85)
        AdminLabel.Name = "AdminLabel"
        AdminLabel.Size = New System.Drawing.Size(45, 13)
        AdminLabel.TabIndex = 12
        AdminLabel.Text = "Admin?:"
        '
        'AuthorLabel
        '
        AuthorLabel.AutoSize = True
        AuthorLabel.Location = New System.Drawing.Point(8, 115)
        AuthorLabel.Name = "AuthorLabel"
        AuthorLabel.Size = New System.Drawing.Size(47, 13)
        AuthorLabel.TabIndex = 14
        AuthorLabel.Text = "Author?:"
        '
        'FrozenLabel
        '
        FrozenLabel.AutoSize = True
        FrozenLabel.Location = New System.Drawing.Point(8, 139)
        FrozenLabel.Name = "FrozenLabel"
        FrozenLabel.Size = New System.Drawing.Size(48, 13)
        FrozenLabel.TabIndex = 16
        FrozenLabel.Text = "Frozen?:"
        '
        'CodeReviewSiteDataSet
        '
        Me.CodeReviewSiteDataSet.DataSetName = "CodeReviewSiteDataSet"
        Me.CodeReviewSiteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsernamesBindingSource
        '
        Me.UsernamesBindingSource.DataMember = "usernames"
        Me.UsernamesBindingSource.DataSource = Me.CodeReviewSiteDataSet
        '
        'UsernamesTableAdapter
        '
        Me.UsernamesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = CodeReviewSite.CodeReviewSiteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usernamesTableAdapter = Me.UsernamesTableAdapter
        '
        'UsernamesBindingNavigator
        '
        Me.UsernamesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UsernamesBindingNavigator.BindingSource = Me.UsernamesBindingSource
        Me.UsernamesBindingNavigator.CountItem = Nothing
        Me.UsernamesBindingNavigator.DeleteItem = Nothing
        Me.UsernamesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.ToolStripLabel1, Me.UsernamesBindingNavigatorSaveItem})
        Me.UsernamesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UsernamesBindingNavigator.MoveFirstItem = Nothing
        Me.UsernamesBindingNavigator.MoveLastItem = Nothing
        Me.UsernamesBindingNavigator.MoveNextItem = Nothing
        Me.UsernamesBindingNavigator.MovePreviousItem = Nothing
        Me.UsernamesBindingNavigator.Name = "UsernamesBindingNavigator"
        Me.UsernamesBindingNavigator.PositionItem = Nothing
        Me.UsernamesBindingNavigator.Size = New System.Drawing.Size(421, 25)
        Me.UsernamesBindingNavigator.TabIndex = 7
        Me.UsernamesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsernamesBindingSource, "username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(98, 28)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(104, 20)
        Me.UsernameTextBox.TabIndex = 9
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsernamesBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(98, 54)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(104, 20)
        Me.PasswordTextBox.TabIndex = 11
        '
        'AdminCheckBox
        '
        Me.AdminCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsernamesBindingSource, "admin", True))
        Me.AdminCheckBox.Location = New System.Drawing.Point(98, 80)
        Me.AdminCheckBox.Name = "AdminCheckBox"
        Me.AdminCheckBox.Size = New System.Drawing.Size(187, 24)
        Me.AdminCheckBox.TabIndex = 13
        Me.AdminCheckBox.Text = "Chech if the User is an Admin"
        Me.AdminCheckBox.UseVisualStyleBackColor = True
        '
        'AuthorCheckBox
        '
        Me.AuthorCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsernamesBindingSource, "author", True))
        Me.AuthorCheckBox.Location = New System.Drawing.Point(98, 110)
        Me.AuthorCheckBox.Name = "AuthorCheckBox"
        Me.AuthorCheckBox.Size = New System.Drawing.Size(187, 24)
        Me.AuthorCheckBox.TabIndex = 15
        Me.AuthorCheckBox.Text = "Check if the User is an Author"
        Me.AuthorCheckBox.UseVisualStyleBackColor = True
        '
        'FrozenCheckBox
        '
        Me.FrozenCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsernamesBindingSource, "frozen", True))
        Me.FrozenCheckBox.Location = New System.Drawing.Point(98, 128)
        Me.FrozenCheckBox.Name = "FrozenCheckBox"
        Me.FrozenCheckBox.Size = New System.Drawing.Size(214, 36)
        Me.FrozenCheckBox.TabIndex = 17
        Me.FrozenCheckBox.Text = "Check if you want to Freeze the User. Frozen users cannot login"
        Me.FrozenCheckBox.UseVisualStyleBackColor = True
        '
        'UsernamesBindingNavigatorSaveItem
        '
        Me.UsernamesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UsernamesBindingNavigatorSaveItem.Image = CType(resources.GetObject("UsernamesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UsernamesBindingNavigatorSaveItem.Name = "UsernamesBindingNavigatorSaveItem"
        Me.UsernamesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UsernamesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(360, 22)
        Me.ToolStripLabel1.Text = "Click the Save button once you finish, or Plus button to create New"
        '
        'addUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 195)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(AdminLabel)
        Me.Controls.Add(Me.AdminCheckBox)
        Me.Controls.Add(AuthorLabel)
        Me.Controls.Add(Me.AuthorCheckBox)
        Me.Controls.Add(FrozenLabel)
        Me.Controls.Add(Me.FrozenCheckBox)
        Me.Controls.Add(Me.UsernamesBindingNavigator)
        Me.Name = "addUser"
        Me.Text = "Manage Users"
        CType(Me.CodeReviewSiteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsernamesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsernamesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UsernamesBindingNavigator.ResumeLayout(False)
        Me.UsernamesBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CodeReviewSiteDataSet As CodeReviewSite.CodeReviewSiteDataSet
    Friend WithEvents UsernamesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsernamesTableAdapter As CodeReviewSite.CodeReviewSiteDataSetTableAdapters.usernamesTableAdapter
    Friend WithEvents TableAdapterManager As CodeReviewSite.CodeReviewSiteDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsernamesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdminCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AuthorCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FrozenCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents UsernamesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
End Class
