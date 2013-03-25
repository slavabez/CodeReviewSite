<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userDashboard
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
        Me.CodeReviewSiteDataSet = New CodeReviewSite.CodeReviewSiteDataSet()
        Me.ArticlesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticlesTableAdapter = New CodeReviewSite.CodeReviewSiteDataSetTableAdapters.articlesTableAdapter()
        Me.TableAdapterManager = New CodeReviewSite.CodeReviewSiteDataSetTableAdapters.TableAdapterManager()
        Me.ArticlesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.articleIDtxtBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnComment = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
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
        Me.Label1.Size = New System.Drawing.Size(345, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hello there! Here's a list of articles, you can comment on any if you want"
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
        Me.ArticlesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.ArticlesDataGridView.DataSource = Me.ArticlesBindingSource
        Me.ArticlesDataGridView.Location = New System.Drawing.Point(18, 45)
        Me.ArticlesDataGridView.Name = "ArticlesDataGridView"
        Me.ArticlesDataGridView.ReadOnly = True
        Me.ArticlesDataGridView.Size = New System.Drawing.Size(248, 281)
        Me.ArticlesDataGridView.TabIndex = 2
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
        'articleIDtxtBox
        '
        Me.articleIDtxtBox.Location = New System.Drawing.Point(456, 48)
        Me.articleIDtxtBox.Name = "articleIDtxtBox"
        Me.articleIDtxtBox.Size = New System.Drawing.Size(100, 20)
        Me.articleIDtxtBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(289, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ID of the article to comment on:  "
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(292, 74)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(264, 222)
        Me.TextBox2.TabIndex = 5
        '
        'btnComment
        '
        Me.btnComment.Location = New System.Drawing.Point(292, 302)
        Me.btnComment.Name = "btnComment"
        Me.btnComment.Size = New System.Drawing.Size(124, 23)
        Me.btnComment.TabIndex = 6
        Me.btnComment.Text = "Leave a Comment"
        Me.btnComment.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(402, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Logged in as: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(482, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 8
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(432, 302)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(124, 23)
        Me.btnRefresh.TabIndex = 9
        Me.btnRefresh.Text = "Refresh View"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'userDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 342)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnComment)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.articleIDtxtBox)
        Me.Controls.Add(Me.ArticlesDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Name = "userDashboard"
        Me.Text = "User's Dashboard"
        CType(Me.CodeReviewSiteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticlesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticlesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CodeReviewSiteDataSet As CodeReviewSite.CodeReviewSiteDataSet
    Friend WithEvents ArticlesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticlesTableAdapter As CodeReviewSite.CodeReviewSiteDataSetTableAdapters.articlesTableAdapter
    Friend WithEvents TableAdapterManager As CodeReviewSite.CodeReviewSiteDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ArticlesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents articleIDtxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btnComment As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
End Class
