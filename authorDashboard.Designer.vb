<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class authorDashboard
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.loggedInAs = New System.Windows.Forms.Label()
        Me.btnSubmitArticle = New System.Windows.Forms.Button()
        Me.btnEditArticle = New System.Windows.Forms.Button()
        Me.btnDeleteArticle = New System.Windows.Forms.Button()
        Me.btnComment = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.commentTxtBox = New System.Windows.Forms.TextBox()
        Me.CodeReviewSiteDataSet = New CodeReviewSite.CodeReviewSiteDataSet()
        Me.ArticlesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticlesTableAdapter = New CodeReviewSite.CodeReviewSiteDataSetTableAdapters.articlesTableAdapter()
        Me.TableAdapterManager = New CodeReviewSite.CodeReviewSiteDataSetTableAdapters.TableAdapterManager()
        Me.ArticlesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.privateBox = New System.Windows.Forms.CheckBox()
        Me.articleIDTxtBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ArticleIDToDelete = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.CodeReviewSiteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticlesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticlesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Author's dashboard"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(167, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Logged in as: "
        '
        'loggedInAs
        '
        Me.loggedInAs.AutoSize = True
        Me.loggedInAs.Location = New System.Drawing.Point(248, 13)
        Me.loggedInAs.Name = "loggedInAs"
        Me.loggedInAs.Size = New System.Drawing.Size(53, 13)
        Me.loggedInAs.TabIndex = 2
        Me.loggedInAs.Text = "username"
        '
        'btnSubmitArticle
        '
        Me.btnSubmitArticle.Location = New System.Drawing.Point(12, 192)
        Me.btnSubmitArticle.Name = "btnSubmitArticle"
        Me.btnSubmitArticle.Size = New System.Drawing.Size(139, 23)
        Me.btnSubmitArticle.TabIndex = 3
        Me.btnSubmitArticle.Text = "Submit a New Article"
        Me.btnSubmitArticle.UseVisualStyleBackColor = True
        '
        'btnEditArticle
        '
        Me.btnEditArticle.Location = New System.Drawing.Point(12, 250)
        Me.btnEditArticle.Name = "btnEditArticle"
        Me.btnEditArticle.Size = New System.Drawing.Size(139, 23)
        Me.btnEditArticle.TabIndex = 4
        Me.btnEditArticle.Text = "Edit an Article"
        Me.btnEditArticle.UseVisualStyleBackColor = True
        '
        'btnDeleteArticle
        '
        Me.btnDeleteArticle.Location = New System.Drawing.Point(12, 221)
        Me.btnDeleteArticle.Name = "btnDeleteArticle"
        Me.btnDeleteArticle.Size = New System.Drawing.Size(139, 23)
        Me.btnDeleteArticle.TabIndex = 5
        Me.btnDeleteArticle.Text = "Delete an Article"
        Me.btnDeleteArticle.UseVisualStyleBackColor = True
        '
        'btnComment
        '
        Me.btnComment.Location = New System.Drawing.Point(12, 384)
        Me.btnComment.Name = "btnComment"
        Me.btnComment.Size = New System.Drawing.Size(139, 23)
        Me.btnComment.TabIndex = 6
        Me.btnComment.Text = "Leave a Comment"
        Me.btnComment.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 30)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(289, 156)
        Me.TextBox1.TabIndex = 7
        '
        'commentTxtBox
        '
        Me.commentTxtBox.Location = New System.Drawing.Point(12, 307)
        Me.commentTxtBox.Multiline = True
        Me.commentTxtBox.Name = "commentTxtBox"
        Me.commentTxtBox.Size = New System.Drawing.Size(289, 71)
        Me.commentTxtBox.TabIndex = 8
        '
        'CodeReviewSiteDataSet
        '
        Me.CodeReviewSiteDataSet.DataSetName = "CodeReviewSiteDataSet"
        Me.CodeReviewSiteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArticlesBindingSource
        '
        Me.ArticlesBindingSource.DataMember = "articles"
        Me.ArticlesBindingSource.DataSource = Me.CodeReviewSiteDataSet
        '
        'ArticlesTableAdapter
        '
        Me.ArticlesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.articlesTableAdapter = Me.ArticlesTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.commentsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CodeReviewSite.CodeReviewSiteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usernamesTableAdapter = Nothing
        '
        'ArticlesDataGridView
        '
        Me.ArticlesDataGridView.AutoGenerateColumns = False
        Me.ArticlesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArticlesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1})
        Me.ArticlesDataGridView.DataSource = Me.ArticlesBindingSource
        Me.ArticlesDataGridView.Location = New System.Drawing.Point(316, 30)
        Me.ArticlesDataGridView.Name = "ArticlesDataGridView"
        Me.ArticlesDataGridView.ReadOnly = True
        Me.ArticlesDataGridView.Size = New System.Drawing.Size(390, 348)
        Me.ArticlesDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "username"
        Me.DataGridViewTextBoxColumn2.HeaderText = "username"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "dateCreated"
        Me.DataGridViewTextBoxColumn3.HeaderText = "dateCreated"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "private"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "private"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(316, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Articles Database:"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(319, 384)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(151, 23)
        Me.btnRefresh.TabIndex = 12
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'privateBox
        '
        Me.privateBox.AutoSize = True
        Me.privateBox.Location = New System.Drawing.Point(185, 193)
        Me.privateBox.Name = "privateBox"
        Me.privateBox.Size = New System.Drawing.Size(91, 17)
        Me.privateBox.TabIndex = 13
        Me.privateBox.Text = "Tick if Private"
        Me.privateBox.UseVisualStyleBackColor = True
        '
        'articleIDTxtBox
        '
        Me.articleIDTxtBox.Location = New System.Drawing.Point(237, 281)
        Me.articleIDTxtBox.Name = "articleIDTxtBox"
        Me.articleIDTxtBox.Size = New System.Drawing.Size(59, 20)
        Me.articleIDTxtBox.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "ID of the article to comment on:"
        '
        'ArticleIDToDelete
        '
        Me.ArticleIDToDelete.Location = New System.Drawing.Point(237, 223)
        Me.ArticleIDToDelete.Name = "ArticleIDToDelete"
        Me.ArticleIDToDelete.Size = New System.Drawing.Size(59, 20)
        Me.ArticleIDToDelete.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(170, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Article ID: "
        '
        'authorDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 413)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ArticleIDToDelete)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.articleIDTxtBox)
        Me.Controls.Add(Me.privateBox)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ArticlesDataGridView)
        Me.Controls.Add(Me.commentTxtBox)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnComment)
        Me.Controls.Add(Me.btnDeleteArticle)
        Me.Controls.Add(Me.btnEditArticle)
        Me.Controls.Add(Me.btnSubmitArticle)
        Me.Controls.Add(Me.loggedInAs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "authorDashboard"
        Me.Text = "Author's Dashboard"
        CType(Me.CodeReviewSiteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticlesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticlesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents loggedInAs As System.Windows.Forms.Label
    Friend WithEvents btnSubmitArticle As System.Windows.Forms.Button
    Friend WithEvents btnEditArticle As System.Windows.Forms.Button
    Friend WithEvents btnDeleteArticle As System.Windows.Forms.Button
    Friend WithEvents btnComment As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents commentTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents CodeReviewSiteDataSet As CodeReviewSite.CodeReviewSiteDataSet
    Friend WithEvents ArticlesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticlesTableAdapter As CodeReviewSite.CodeReviewSiteDataSetTableAdapters.articlesTableAdapter
    Friend WithEvents TableAdapterManager As CodeReviewSite.CodeReviewSiteDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ArticlesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents privateBox As System.Windows.Forms.CheckBox
    Friend WithEvents articleIDTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ArticleIDToDelete As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
