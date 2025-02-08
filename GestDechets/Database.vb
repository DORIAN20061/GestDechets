Imports MySql.Data.MySqlClient


Public Class Database
    Private connectionString As String = "Server=localhost;Database=gestion_db;Uid=root;Pwd=;"

    ' Méthode pour ouvrir une connexion à la base de données
    Public Function OpenConnection() As MySqlConnection
        Dim connection As New MySqlConnection(connectionString)
        Try
            connection.Open()
            Return connection
        Catch ex As Exception
            Throw New Exception("Erreur lors de l'ouverture de la connexion à la base de données: " & ex.Message)
        End Try
    End Function

    ' Méthode pour exécuter une requête SQL et retourner un DataTable
    Public Function ExecuteQuery(query As String, parameters As List(Of MySqlParameter)) As DataTable
        Dim dataTable As New DataTable()
        Using connection As MySqlConnection = OpenConnection()
            Using command As New MySqlCommand(query, connection)
                If parameters IsNot Nothing Then
                    command.Parameters.AddRange(parameters.ToArray())
                End If
                Using adapter As New MySqlDataAdapter(command)
                    adapter.Fill(dataTable)
                End Using
            End Using
        End Using
        Return dataTable
    End Function

    ' Méthode pour exécuter une requête SQL sans retourner de résultats
    Public Sub ExecuteNonQuery(query As String, parameters As List(Of MySqlParameter))
        Using connection As MySqlConnection = OpenConnection()
            Using command As New MySqlCommand(query, connection)
                If parameters IsNot Nothing Then
                    command.Parameters.AddRange(parameters.ToArray())
                End If
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
