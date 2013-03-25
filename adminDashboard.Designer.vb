<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminDashboard))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdminDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AuthorDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FrozenDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.InvalidAttemptsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernamesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodeReviewSiteDataSet = New CodeReviewSite.CodeReviewSiteDataSet()
        Me.addUserBtn = New System.Windows.Forms.Button()
        Me.btnGoToContentManagement = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.UsernamesTableAdapter = New CodeReviewSite.CodeReviewSiteDataSetTableAdapters.usernamesTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsernamesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodeReviewSiteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "List of all users"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.AdminDataGridViewCheckBoxColumn, Me.AuthorDataGridViewCheckBoxColumn, Me.FrozenDataGridViewCheckBoxColumn, Me.InvalidAttemptsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.UsernamesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 124)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(541, 359)
        Me.DataGridView1.TabIndex = 2
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AdminDataGridViewCheckBoxColumn
        '
        Me.AdminDataGridViewCheckBoxColumn.DataPropertyName = "admin"
        Me.AdminDataGridViewCheckBoxColumn.HeaderText = "admin"
        Me.AdminDataGridViewCheckBoxColumn.Name = "AdminDataGridViewCheckBoxColumn"
        Me.AdminDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'AuthorDataGridViewCheckBoxColumn
        '
        Me.AuthorDataGridViewCheckBoxColumn.DataPropertyName = "author"
        Me.AuthorDataGridViewCheckBoxColumn.HeaderText = "author"
        Me.AuthorDataGridViewCheckBoxColumn.Name = "AuthorDataGridViewCheckBoxColumn"
        Me.AuthorDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'FrozenDataGridViewCheckBoxColumn
        '
        Me.FrozenDataGridViewCheckBoxColumn.DataPropertyName = "frozen"
        Me.FrozenDataGridViewCheckBoxColumn.HeaderText = "frozen"
        Me.FrozenDataGridViewCheckBoxColumn.Name = "FrozenDataGridViewCheckBoxColumn"
        Me.FrozenDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'InvalidAttemptsDataGridViewTextBoxColumn
        '
        Me.InvalidAttemptsDataGridViewTextBoxColumn.DataPropertyName = "invalidAttempts"
        Me.InvalidAttemptsDataGridViewTextBoxColumn.HeaderText = "invalidAttempts"
        Me.InvalidAttemptsDataGridViewTextBoxColumn.Name = "InvalidAttemptsDataGridViewTextBoxColumn"
        Me.InvalidAttemptsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsernamesBindingSource
        '
        Me.UsernamesBindingSource.DataMember = "usernames"
        Me.UsernamesBindingSource.DataSource = Me.CodeReviewSiteDataSet
        '
        'CodeReviewSiteDataSet
        '
        Me.CodeReviewSiteDataSet.DataSetName = "CodeReviewSiteDataSet"
        Me.CodeReviewSiteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'addUserBtn
        '
        Me.addUserBtn.Location = New System.Drawing.Point(560, 124)
        Me.addUserBtn.Name = "addUserBtn"
        Me.addUserBtn.Size = New System.Drawing.Size(181, 30)
        Me.addUserBtn.TabIndex = 3
        Me.addUserBtn.Text = "Add a New User"
        Me.addUserBtn.UseVisualStyleBackColor = True
        '
        'btnGoToContentManagement
        '
        Me.btnGoToContentManagement.Location = New System.Drawing.Point(560, 453)
        Me.btnGoToContentManagement.Name = "btnGoToContentManagement"
        Me.btnGoToContentManagement.Size = New System.Drawing.Size(181, 30)
        Me.btnGoToContentManagement.TabIndex = 5
        Me.btnGoToContentManagement.Text = "Go to Content Management"
        Me.btnGoToContentManagement.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(560, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(181, 29)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Refresh Data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(560, 160)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(181, 30)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Delete a User"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'UsernamesTableAdapter
        '
        Me.UsernamesTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(82, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(592, 84)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'adminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 495)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnGoToContentManagement)
        Me.Controls.Add(Me.addUserBtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "adminDashboard"
        Me.Text = "Admin's Dashboard"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsernamesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodeReviewSiteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CodeReviewSiteDataSet As CodeReviewSite.CodeReviewSiteDataSet
    Friend WithEvents UsernamesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsernamesTableAdapter As CodeReviewSite.CodeReviewSiteDataSetTableAdapters.usernamesTableAdapter
    Friend WithEvents UsernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdminDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents AuthorDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FrozenDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents InvalidAttemptsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents addUserBtn As System.Windows.Forms.Button
    Friend WithEvents btnGoToContentManagement As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
