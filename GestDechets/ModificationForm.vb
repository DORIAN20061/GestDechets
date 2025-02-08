Imports MySql.Data.MySqlClient

Public Class ModificationForm
    Private db As New Database()
    Private selectedId As Integer = 0
    Private dateCollecte As Object

    Private Sub LoadRecords()
        Dim query As String = "SELECT * FROM dechets"
        Dim dataTable As DataTable = db.ExecuteQuery(query, Nothing)
        DataGridView1.DataSource = dataTable
    End Sub
    Private Sub MainToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Dim mainform As New MainForm
        mainform.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub ButtonSupprimer_Click(sender As Object, e As EventArgs) Handles ButtonSupprimer.Click
        Dim del As New SuppressionForm
        del.Show()
        Me.Hide()

    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Sélectionner l'ID de l'enregistrement
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            selectedId = Convert.ToInt32(row.Cells("id").Value)
            DisplayRecord(selectedId)
        End If
    End Sub

    Private Sub DisplayRecord(id As Integer)
        ' Récupérer les informations de l'enregistrement sélectionné
        Dim query As String = "SELECT * FROM dechets WHERE id = @id"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@id", id)
        }
        Dim dataTable As DataTable = db.ExecuteQuery(query, parameters)

        If dataTable.Rows.Count > 0 Then
            Dim row As DataRow = dataTable.Rows(0)
            txtNomDechet.Text = row("nom_dechet").ToString()
            comboTypeDechet.Text = row("type_dechet").ToString()
            txtQuantite.Text = row("quantite").ToString()
            comboUniteMesure.Text = row("unite_mesure").ToString()
            txtLieuCollecte.Text = row("lieu_collecte").ToString()
            'comboEtatDechet.Text = row("etat_dechet").ToString()
            'txtRemarques.Text = row("remarques").ToString()
            txtResponsable.Text = row("responsable").ToString()
            ' Ajoutez ici le code pour afficher la photo si nécessaire
        End If
    End Sub
    Private Sub ModificationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Charger les enregistrements dans le DataGridView
        LoadRecords()
    End Sub

    Private Sub ButtonModifier_Click(sender As Object, e As EventArgs) Handles ButtonModifier.Click
        ' Récupérer les informations modifiées
        Dim nomDechet As String = txtNomDechet.Text
        Dim typeDechet As String = comboTypeDechet.Text
        Dim quantite As Decimal = Decimal.Parse(txtQuantite.Text)
        Dim uniteMesure As String = comboUniteMesure.Text
        Dim lieuCollecte As String = txtLieuCollecte.Text
        'Dim etatDechet As String = comboEtatDechet.Text
        'Dim remarques As String = txtRemarques.Text
        Dim responsable As String = txtResponsable.Text
        ' Ajoutez ici le code pour récupérer la photo si nécessaire

        ' Utiliser la date actuelle pour la colonne date_collecte
        Dim dateCollecte As Date = Date.Now

        ' Mettre à jour l'enregistrement
        Dim updateQuery As String = "UPDATE dechets SET nom_dechet = @nom_dechet, type_dechet = @type_dechet, quantite = @quantite, unite_mesure = @unite_mesure, date_collecte = @date_collecte, lieu_collecte = @lieu_collecte, responsable = @responsable WHERE id = @id"
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@nom_dechet", nomDechet),
            New MySqlParameter("@type_dechet", typeDechet),
            New MySqlParameter("@quantite", quantite),
            New MySqlParameter("@unite_mesure", uniteMesure),
            New MySqlParameter("@date_collecte", dateCollecte),
            New MySqlParameter("@lieu_collecte", lieuCollecte),
            New MySqlParameter("@responsable", responsable),
            New MySqlParameter("@id", selectedId)
        }

        db.ExecuteNonQuery(updateQuery, parameters)

        ' Modification réussie
        MessageBox.Show("Enregistrement modifié avec succès!")
        LoadRecords()
    End Sub

    Private Sub txtNomDechet_TextChanged(sender As Object, e As EventArgs) Handles txtNomDechet.TextChanged

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub ButtonAnnuler_Click(sender As Object, e As EventArgs) Handles ButtonAnnuler.Click
        Dim mainForm As New MainForm
        mainForm.Show()
        Me.Hide()
    End Sub
End Class