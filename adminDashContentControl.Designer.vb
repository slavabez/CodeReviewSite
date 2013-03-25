<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminDashContentControl
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
        Me.CommentsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodeReviewSiteDataSet = New CodeReviewSite.CodeReviewSiteDataSet()
        Me.ArticlesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ArticlesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDeleteArticle = New System.Windows.Forms.Button()
        Me.btnOpenArticle = New System.Windows.Forms.Button()
        Me.btnAddArticle = New System.Windows.Forms.Button()
        Me.btnAddComment = New System.Windows.Forms.Button()
        Me.btnEditComment = New System.Windows.Forms.Button()
        Me.btnDeleteComment = New System.Windows.Forms.Button()
        Me.btnArticleRefresh = New System.Windows.Forms.Button()
        Me.btnCommentRefresh = New System.Windows.Forms.Button()
        Me.articleIDTxtBox = New System.Windows.Forms.TextBox()
        Me.commentIDTxtBox = New System.Windows.Forms.TextBox()
        Me.CommentsTableAdapter = New CodeReviewSite.CodeReviewSiteDataSetTableAdapters.commentsTableAdapter()
        Me.TableAdapterManager = New CodeReviewSite.CodeReviewSiteDataSetTableAdapters.TableAdapterManager()
        Me.ArticlesTableAdapter = New CodeReviewSite.CodeReviewSiteDataSetTableAdapters.articlesTableAdapter()
        Me.ArticlesTableAdapter1 = New CodeReviewSite.CodeReviewSiteDataSetTableAdapters.articlesTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLoggedInAs = New System.Windows.Forms.Label()
        Me.articleTxtBox = New System.Windows.Forms.TextBox()
        Me.btnOverwriteArticle = New System.Windows.Forms.Button()
        Me.CommentTxtBox = New System.Windows.Forms.TextBox()
        Me.btnOverwriteComment = New System.Windows.Forms.Button()
        Me.privateBox = New System.Windows.Forms.CheckBox()
        Me.articleIdToCommentOnTxtBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.CommentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodeReviewSiteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticlesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticlesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CommentsDataGridView
        '
        Me.CommentsDataGridView.AutoGenerateColumns = False
        Me.CommentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CommentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.CommentsDataGridView.DataSource = Me.CommentsBindingSource
        Me.CommentsDataGridView.Location = New System.Drawing.Point(12, 271)
        Me.CommentsDataGridView.Name = "CommentsDataGridView"
        Me.CommentsDataGridView.ReadOnly = True
        Me.CommentsDataGridView.Size = New System.Drawing.Size(450, 220)
        Me.CommentsDataGridView.TabIndex = 1
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "articleID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "articleID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "dateCreated"
        Me.DataGridViewTextBoxColumn4.HeaderText = "dateCreated"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'CommentsBindingSource
        '
        Me.CommentsBindingSource.DataMember = "comments"
        Me.CommentsBindingSource.DataSource = Me.CodeReviewSiteDataSet
        '
        'CodeReviewSiteDataSet
        '
        Me.CodeReviewSiteDataSet.DataSetName = "CodeReviewSiteDataSet"
        Me.CodeReviewSiteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArticlesDataGridView
        '
        Me.ArticlesDataGridView.AllowUserToResizeColumns = False
        Me.ArticlesDataGridView.AutoGenerateColumns = False
        Me.ArticlesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArticlesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewCheckBoxColumn1})
        Me.ArticlesDataGridView.DataSource = Me.ArticlesBindingSource
        Me.ArticlesDataGridView.Location = New System.Drawing.Point(12, 26)
        Me.ArticlesDataGridView.Name = "ArticlesDataGridView"
        Me.ArticlesDataGridView.ReadOnly = True
        Me.ArticlesDataGridView.Size = New System.Drawing.Size(450, 220)
        Me.ArticlesDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "username"
        Me.DataGridViewTextBoxColumn6.HeaderText = "username"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "dateCreated"
        Me.DataGridViewTextBoxColumn7.HeaderText = "dateCreated"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "private"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "private"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'ArticlesBindingSource
        '
        Me.ArticlesBindingSource.DataMember = "articles"
        Me.ArticlesBindingSource.DataSource = Me.CodeReviewSiteDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Articles"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 253)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Comments"
        '
        'btnDeleteArticle
        '
        Me.btnDeleteArticle.Location = New System.Drawing.Point(468, 194)
        Me.btnDeleteArticle.Name = "btnDeleteArticle"
        Me.btnDeleteArticle.Size = New System.Drawing.Size(319, 23)
        Me.btnDeleteArticle.TabIndex = 5
        Me.btnDeleteArticle.Text = "Delete an Article"
        Me.btnDeleteArticle.UseVisualStyleBackColor = True
        '
        'btnOpenArticle
        '
        Me.btnOpenArticle.Location = New System.Drawing.Point(468, 136)
        Me.btnOpenArticle.Name = "btnOpenArticle"
        Me.btnOpenArticle.Size = New System.Drawing.Size(172, 23)
        Me.btnOpenArticle.TabIndex = 6
        Me.btnOpenArticle.Text = "Open an Article"
        Me.btnOpenArticle.UseVisualStyleBackColor = True
        '
        'btnAddArticle
        '
        Me.btnAddArticle.Location = New System.Drawing.Point(468, 165)
        Me.btnAddArticle.Name = "btnAddArticle"
        Me.btnAddArticle.Size = New System.Drawing.Size(221, 23)
        Me.btnAddArticle.TabIndex = 7
        Me.btnAddArticle.Text = "Add an Article"
        Me.btnAddArticle.UseVisualStyleBackColor = True
        '
        'btnAddComment
        '
        Me.btnAddComment.Location = New System.Drawing.Point(469, 410)
        Me.btnAddComment.Name = "btnAddComment"
        Me.btnAddComment.Size = New System.Drawing.Size(172, 23)
        Me.btnAddComment.TabIndex = 10
        Me.btnAddComment.Text = "Add a Comment"
        Me.btnAddComment.UseVisualStyleBackColor = True
        '
        'btnEditComment
        '
        Me.btnEditComment.Location = New System.Drawing.Point(469, 381)
        Me.btnEditComment.Name = "btnEditComment"
        Me.btnEditComment.Size = New System.Drawing.Size(172, 23)
        Me.btnEditComment.TabIndex = 9
        Me.btnEditComment.Text = "Open a Comment"
        Me.btnEditComment.UseVisualStyleBackColor = True
        '
        'btnDeleteComment
        '
        Me.btnDeleteComment.Location = New System.Drawing.Point(469, 439)
        Me.btnDeleteComment.Name = "btnDeleteComment"
        Me.btnDeleteComment.Size = New System.Drawing.Size(317, 23)
        Me.btnDeleteComment.TabIndex = 8
        Me.btnDeleteComment.Text = "Delete a Comment"
        Me.btnDeleteComment.UseVisualStyleBackColor = True
        '
        'btnArticleRefresh
        '
        Me.btnArticleRefresh.Location = New System.Drawing.Point(468, 223)
        Me.btnArticleRefresh.Name = "btnArticleRefresh"
        Me.btnArticleRefresh.Size = New System.Drawing.Size(319, 23)
        Me.btnArticleRefresh.TabIndex = 11
        Me.btnArticleRefresh.Text = "Refresh Table"
        Me.btnArticleRefresh.UseVisualStyleBackColor = True
        '
        'btnCommentRefresh
        '
        Me.btnCommentRefresh.Location = New System.Drawing.Point(469, 468)
        Me.btnCommentRefresh.Name = "btnCommentRefresh"
        Me.btnCommentRefresh.Size = New System.Drawing.Size(317, 23)
        Me.btnCommentRefresh.TabIndex = 12
        Me.btnCommentRefresh.Text = "Refresh Table"
        Me.btnCommentRefresh.UseVisualStyleBackColor = True
        '
        'articleIDTxtBox
        '
        Me.articleIDTxtBox.Location = New System.Drawing.Point(469, 26)
        Me.articleIDTxtBox.Name = "articleIDTxtBox"
        Me.articleIDTxtBox.Size = New System.Drawing.Size(317, 20)
        Me.articleIDTxtBox.TabIndex = 13
        Me.articleIDTxtBox.Text = "type ID of the article here..."
        '
        'commentIDTxtBox
        '
        Me.commentIDTxtBox.Location = New System.Drawing.Point(470, 271)
        Me.commentIDTxtBox.Name = "commentIDTxtBox"
        Me.commentIDTxtBox.Size = New System.Drawing.Size(316, 20)
        Me.commentIDTxtBox.TabIndex = 14
        Me.commentIDTxtBox.Text = "type ID of the comment here..."
        '
        'CommentsTableAdapter
        '
        Me.CommentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.articlesTableAdapter = Me.ArticlesTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.commentsTableAdapter = Me.CommentsTableAdapter
        Me.TableAdapterManager.UpdateOrder = CodeReviewSite.CodeReviewSiteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usernamesTableAdapter = Nothing
        '
        'ArticlesTableAdapter
        '
        Me.ArticlesTableAdapter.ClearBeforeFill = True
        '
        'ArticlesTableAdapter1
        '
        Me.ArticlesTableAdapter1.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(496, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Logged in as: "
        '
        'lblLoggedInAs
        '
        Me.lblLoggedInAs.AutoSize = True
        Me.lblLoggedInAs.Location = New System.Drawing.Point(577, 7)
        Me.lblLoggedInAs.Name = "lblLoggedInAs"
        Me.lblLoggedInAs.Size = New System.Drawing.Size(0, 13)
        Me.lblLoggedInAs.TabIndex = 16
        '
        'articleTxtBox
        '
        Me.articleTxtBox.Location = New System.Drawing.Point(469, 53)
        Me.articleTxtBox.Multiline = True
        Me.articleTxtBox.Name = "articleTxtBox"
        Me.articleTxtBox.Size = New System.Drawing.Size(318, 77)
        Me.articleTxtBox.TabIndex = 17
        '
        'btnOverwriteArticle
        '
        Me.btnOverwriteArticle.Location = New System.Drawing.Point(646, 136)
        Me.btnOverwriteArticle.Name = "btnOverwriteArticle"
        Me.btnOverwriteArticle.Size = New System.Drawing.Size(141, 23)
        Me.btnOverwriteArticle.TabIndex = 18
        Me.btnOverwriteArticle.Text = "Overwrite article"
        Me.btnOverwriteArticle.UseVisualStyleBackColor = True
        '
        'CommentTxtBox
        '
        Me.CommentTxtBox.Location = New System.Drawing.Point(468, 298)
        Me.CommentTxtBox.Multiline = True
        Me.CommentTxtBox.Name = "CommentTxtBox"
        Me.CommentTxtBox.Size = New System.Drawing.Size(318, 77)
        Me.CommentTxtBox.TabIndex = 19
        '
        'btnOverwriteComment
        '
        Me.btnOverwriteComment.Location = New System.Drawing.Point(645, 381)
        Me.btnOverwriteComment.Name = "btnOverwriteComment"
        Me.btnOverwriteComment.Size = New System.Drawing.Size(141, 23)
        Me.btnOverwriteComment.TabIndex = 20
        Me.btnOverwriteComment.Text = "Overwrite comment"
        Me.btnOverwriteComment.UseVisualStyleBackColor = True
        '
        'privateBox
        '
        Me.privateBox.AutoSize = True
        Me.privateBox.Location = New System.Drawing.Point(695, 169)
        Me.privateBox.Name = "privateBox"
        Me.privateBox.Size = New System.Drawing.Size(91, 17)
        Me.privateBox.TabIndex = 21
        Me.privateBox.Text = "Tick if Private"
        Me.privateBox.UseVisualStyleBackColor = True
        '
        'articleIdToCommentOnTxtBox
        '
        Me.articleIdToCommentOnTxtBox.Location = New System.Drawing.Point(716, 412)
        Me.articleIdToCommentOnTxtBox.Name = "articleIdToCommentOnTxtBox"
        Me.articleIdToCommentOnTxtBox.Size = New System.Drawing.Size(70, 20)
        Me.articleIdToCommentOnTxtBox.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(657, 415)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Article ID:"
        '
        'adminDashContentControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 511)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.articleIdToCommentOnTxtBox)
        Me.Controls.Add(Me.privateBox)
        Me.Controls.Add(Me.btnOverwriteComment)
        Me.Controls.Add(Me.CommentTxtBox)
        Me.Controls.Add(Me.btnOverwriteArticle)
        Me.Controls.Add(Me.articleTxtBox)
        Me.Controls.Add(Me.lblLoggedInAs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.commentIDTxtBox)
        Me.Controls.Add(Me.articleIDTxtBox)
        Me.Controls.Add(Me.btnCommentRefresh)
        Me.Controls.Add(Me.btnArticleRefresh)
        Me.Controls.Add(Me.btnAddComment)
        Me.Controls.Add(Me.btnEditComment)
        Me.Controls.Add(Me.btnDeleteComment)
        Me.Controls.Add(Me.btnAddArticle)
        Me.Controls.Add(Me.btnOpenArticle)
        Me.Controls.Add(Me.btnDeleteArticle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ArticlesDataGridView)
        Me.Controls.Add(Me.CommentsDataGridView)
        Me.Name = "adminDashContentControl"
        Me.Text = "Content Managmenet and Control"
        CType(Me.CommentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodeReviewSiteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticlesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticlesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CodeReviewSiteDataSet As CodeReviewSite.CodeReviewSiteDataSet
    Friend WithEvents CommentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CommentsTableAdapter As CodeReviewSite.CodeReviewSiteDataSetTableAdapters.commentsTableAdapter
    Friend WithEvents TableAdapterManager As CodeReviewSite.CodeReviewSiteDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ArticlesTableAdapter As CodeReviewSite.CodeReviewSiteDataSetTableAdapters.articlesTableAdapter
    Friend WithEvents CommentsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArticlesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticlesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnDeleteArticle As System.Windows.Forms.Button
    Friend WithEvents btnOpenArticle As System.Windows.Forms.Button
    Friend WithEvents btnAddArticle As System.Windows.Forms.Button
    Friend WithEvents btnAddComment As System.Windows.Forms.Button
    Friend WithEvents btnEditComment As System.Windows.Forms.Button
    Friend WithEvents btnDeleteComment As System.Windows.Forms.Button
    Friend WithEvents btnArticleRefresh As System.Windows.Forms.Button
    Friend WithEvents btnCommentRefresh As System.Windows.Forms.Button
    Friend WithEvents ArticlesTableAdapter1 As CodeReviewSite.CodeReviewSiteDataSetTableAdapters.articlesTableAdapter
    Friend WithEvents articleIDTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents commentIDTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblLoggedInAs As System.Windows.Forms.Label
    Friend WithEvents articleTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents btnOverwriteArticle As System.Windows.Forms.Button
    Friend WithEvents CommentTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents btnOverwriteComment As System.Windows.Forms.Button
    Friend WithEvents privateBox As System.Windows.Forms.CheckBox
    Friend WithEvents articleIdToCommentOnTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
