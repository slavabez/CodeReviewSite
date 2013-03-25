Imports System.Data.OleDb


Public Class databaseConnection

    Dim con As New OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String

    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet


    Sub connect()
        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = C:\Users\bezga_000\Java\Android\CodeReviewSite\bin\Debug\CodeReviewSite.accdb;Jet OLEDB:Database Password=Starcraft2;"

        con.ConnectionString = dbProvider & dbSource
        con.Open()
    End Sub

    Function sqlSelectQuery(ByVal sql As String)
        da = New OleDbDataAdapter(sql, con)
        da.Fill(ds, "Results")

        Return ds
    End Function

    Sub resetDataSet()
        ds.Reset()

    End Sub

    Sub closeConnection()
        con.Close()

    End Sub


End Class
