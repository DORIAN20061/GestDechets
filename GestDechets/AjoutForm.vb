
Imports MySql.Data.MySqlClient

Public Class AjoutForm
    Private db As New Database()
    Private Sub AjoutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        Application.Exit()
    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nomDechet = txtNomDechet.Text
        Dim typeDechet = comboTypeDechet.Text
        Dim quantite = Decimal.Parse(txtQuantite.Text)
        Dim uniteMesure = comboUniteMesure.Text
        Dim lieuCollecte = txtLieuCollecte.Text
        Dim responsable = txtResponsable.Text
        Dim dateCollecte = Date.Now ' Utiliser la date actuelle
        ' Vérifier que tous les champs sont remplis
        If String.IsNullOrEmpty(nomDechet) Or String.IsNullOrEmpty(typeDechet) Or String.IsNullOrEmpty(lieuCollecte) Or String.IsNullOrEmpty(responsable) Then
            MessageBox.Show("Veuillez remplir tous les champs obligatoires.")
            Return
        End If

        ' Insérer le nouvel enregistrement
        Dim insertQuery = "INSERT INTO dechets (nom_dechet, type_dechet, quantite, unite_mesure, date_collecte, lieu_collecte, responsable) VALUES (@nom_dechet, @type_dechet, @quantite, @unite_mesure, @date_collecte, @lieu_collecte, @responsable)"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@nom_dechet", nomDechet),
            New MySqlParameter("@type_dechet", typeDechet),
            New MySqlParameter("@quantite", quantite),
            New MySqlParameter("@unite_mesure", uniteMesure),
            New MySqlParameter("@date_collecte", dateCollecte),
            New MySqlParameter("@lieu_collecte", lieuCollecte),
            New MySqlParameter("@responsable", responsable)
        }

        db.ExecuteNonQuery(insertQuery, parameters)

        ' Enregistrement réussi
        MessageBox.Show("Enregistrement ajouté avec succès!")

        ' Vider les champs de texte
        txtNomDechet.Clear()
        comboTypeDechet.SelectedIndex = -1
        txtQuantite.Clear()
        comboUniteMesure.SelectedIndex = -1
        txtLieuCollecte.Clear()
        txtResponsable.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim mainform As New MainForm
        mainform.Show()
        Me.Hide()
    End Sub
End Class