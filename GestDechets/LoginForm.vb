Imports MySql.Data.MySqlClient
Public Class LoginForm
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
    Private db As New Database()
    Private Sub btnSeConnecter_Click(sender As Object, e As EventArgs) Handles btnSeConnecter.Click
        ' Récupérer les informations saisies par l'utilisateur
        Dim nom As String = TxtNom.Text
        Dim prenom As String = txtPrenom.Text
        Dim reservation As String = txtReservation.Text
        Dim motDePasse As String = txtMotDePasse.Text

        ' Vérifier que tous les champs sont remplis
        If String.IsNullOrEmpty(nom) Or String.IsNullOrEmpty(prenom) Or String.IsNullOrEmpty(reservation) Or String.IsNullOrEmpty(motDePasse) Then
            pnlError.Visible = True
            pnlSuccess.Visible = False
            Return
        End If

        ' Connexion à la base de données
        Dim connectionString As String = "Server=localhost;Database=gestion_db;Uid=root;Pwd=;"
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Vérifier si l'utilisateur existe déjà
                Dim checkQuery As String = "SELECT COUNT(1) FROM utilisateurs WHERE nom = @nom AND prenom = @prenom AND reservation = @reservation AND mot_de_passe = @mot_de_passe"
                Using checkCommand As New MySqlCommand(checkQuery, connection)
                    checkCommand.Parameters.AddWithValue("@nom", nom)
                    checkCommand.Parameters.AddWithValue("@prenom", prenom)
                    checkCommand.Parameters.AddWithValue("@reservation", reservation)
                    checkCommand.Parameters.AddWithValue("@mot_de_passe", motDePasse)

                    Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
                    If count > 0 Then
                        ' Utilisateur existe déjà
                        pnlError.Visible = True
                        pnlSuccess.Visible = False
                        Return
                    End If
                End Using

                ' Insérer le nouvel utilisateur
                Dim insertQuery As String = "INSERT INTO utilisateurs (nom, prenom, reservation, mot_de_passe) VALUES (@nom, @prenom, @reservation, @mot_de_passe)"
                Using insertCommand As New MySqlCommand(insertQuery, connection)
                    insertCommand.Parameters.AddWithValue("@nom", nom)
                    insertCommand.Parameters.AddWithValue("@prenom", prenom)
                    insertCommand.Parameters.AddWithValue("@reservation", reservation)
                    insertCommand.Parameters.AddWithValue("@mot_de_passe", motDePasse)

                    insertCommand.ExecuteNonQuery()
                End Using

                ' Connexion réussie
                pnlError.Visible = False
                pnlSuccess.Visible = True
                ' Ouvrir le formulaire principal
                Dim mainForm As New MainForm()
                mainForm.Show()
                Me.Hide()

            Catch ex As Exception
                ' Afficher le message d'erreur
                pnlError.Visible = True
                pnlSuccess.Visible = False
            End Try
        End Using
    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        ' Vider les champs de texte
        TxtNom.Clear()
        txtPrenom.Clear()
        txtReservation.Clear()
        txtMotDePasse.Clear()

        ' Masquer les panels d'erreur et de succès
        pnlError.Visible = False
        pnlSuccess.Visible = False
    End Sub
End Class
