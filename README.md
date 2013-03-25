CodeReviewSite
==============

Business Programming CW
==============

Finished now.

###

Here's some description of the applicaton:
* The application allows users to publish articles to the system. Three types of users are supported: Administrators, Authors and Regular Users.
    * Administrators can add/modify/delete users, as well as content (articles and comments)
	* Authors can publish new articles to the system. Authors can also modify their own articles (delete or edit), but not content of other authors.
	* Regular Users can comment on articles. To leave a comment ID of the comment needs to be specified. 
* Articles can have comments associated with them. All articles can be displayed by going to the address using the browser (****/show_articles). All articles will be displayed. To display comments associated with the article, click on the link associated with it. Alternatively, if you know the ID of the articles you can go to this addreess in roder to view the articles and comments associated with it: *****/content/articles/(id), for example, if the ID is 5, then the address is ***/content/articles/5
* Logging into the system will display your Dashboard, depending on what type of user you are. Data and Meta-data is stored in the database that needs to be in the same directory as the executable file. Connection string for the database needs to be changed because the connection string of the database has the exact location of the ACCESS database.

###

Still buggy, check the last commit.
The executable file is in the bin/Debug/CodeReview.exe
Articles and Content is stored 