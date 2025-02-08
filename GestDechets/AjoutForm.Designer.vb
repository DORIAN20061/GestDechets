<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AjoutForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AjoutForm))
        Label1 = New Label()
        Panel1 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        btnF = New Button()
        Panel5 = New Panel()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtNomDechet = New TextBox()
        txtLieuCollecte = New TextBox()
        txtResponsable = New TextBox()
        txtQuantite = New TextBox()
        comboUniteMesure = New ComboBox()
        comboTypeDechet = New ComboBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 19F)
        Label1.Location = New Point(409, 96)
        Label1.Name = "Label1"
        Label1.Size = New Size(337, 43)
        Label1.TabIndex = 0
        Label1.Text = "Ajouter des Déchets "
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.MenuHighlight
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(btnF)
        Panel1.Location = New Point(3, 646)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1075, 97)
        Panel1.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Lime
        Button2.Location = New Point(460, 22)
        Button2.Name = "Button2"
        Button2.Size = New Size(154, 52)
        Button2.TabIndex = 13
        Button2.Text = "Revenir"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Lime
        Button1.Location = New Point(23, 28)
        Button1.Name = "Button1"
        Button1.Size = New Size(154, 52)
        Button1.TabIndex = 12
        Button1.Text = "Soumettre"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnF
        ' 
        btnF.BackColor = Color.Red
        btnF.Location = New Point(909, 28)
        btnF.Name = "btnF"
        btnF.Size = New Size(154, 52)
        btnF.TabIndex = 11
        btnF.Text = "Fermer"
        btnF.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), Image)
        Panel5.ForeColor = SystemColors.ActiveCaption
        Panel5.Location = New Point(26, 11)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(219, 82)
        Panel5.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 226)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 25)
        Label2.TabIndex = 3
        Label2.Text = "Nom du déchet"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(26, 332)
        Label3.Name = "Label3"
        Label3.Size = New Size(142, 25)
        Label3.TabIndex = 4
        Label3.Text = "Type de Déchets"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(26, 445)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 25)
        Label4.TabIndex = 5
        Label4.Text = "Quantité"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(514, 223)
        Label5.Name = "Label5"
        Label5.Size = New Size(135, 25)
        Label5.TabIndex = 6
        Label5.Text = "Unité de mesue"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(514, 332)
        Label6.Name = "Label6"
        Label6.Size = New Size(132, 25)
        Label6.TabIndex = 7
        Label6.Text = "Lieu de collecte"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(514, 439)
        Label7.Name = "Label7"
        Label7.Size = New Size(112, 25)
        Label7.TabIndex = 8
        Label7.Text = "Responsable"
        ' 
        ' txtNomDechet
        ' 
        txtNomDechet.Location = New Point(198, 223)
        txtNomDechet.Name = "txtNomDechet"
        txtNomDechet.Size = New Size(237, 31)
        txtNomDechet.TabIndex = 9
        ' 
        ' txtLieuCollecte
        ' 
        txtLieuCollecte.Location = New Point(664, 326)
        txtLieuCollecte.Name = "txtLieuCollecte"
        txtLieuCollecte.Size = New Size(237, 31)
        txtLieuCollecte.TabIndex = 11
        ' 
        ' txtResponsable
        ' 
        txtResponsable.Location = New Point(664, 442)
        txtResponsable.Name = "txtResponsable"
        txtResponsable.Size = New Size(237, 31)
        txtResponsable.TabIndex = 12
        ' 
        ' txtQuantite
        ' 
        txtQuantite.Location = New Point(198, 436)
        txtQuantite.Name = "txtQuantite"
        txtQuantite.Size = New Size(237, 31)
        txtQuantite.TabIndex = 13
        ' 
        ' comboUniteMesure
        ' 
        comboUniteMesure.FormattingEnabled = True
        comboUniteMesure.Items.AddRange(New Object() {"KG ", "G"})
        comboUniteMesure.Location = New Point(664, 223)
        comboUniteMesure.Name = "comboUniteMesure"
        comboUniteMesure.Size = New Size(237, 33)
        comboUniteMesure.TabIndex = 24
        ' 
        ' comboTypeDechet
        ' 
        comboTypeDechet.FormattingEnabled = True
        comboTypeDechet.Items.AddRange(New Object() {"Organiques", "Plastiques", "Papier "})
        comboTypeDechet.Location = New Point(198, 332)
        comboTypeDechet.Name = "comboTypeDechet"
        comboTypeDechet.Size = New Size(237, 33)
        comboTypeDechet.TabIndex = 25
        ' 
        ' AjoutForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1078, 738)
        Controls.Add(comboTypeDechet)
        Controls.Add(comboUniteMesure)
        Controls.Add(txtQuantite)
        Controls.Add(txtResponsable)
        Controls.Add(txtLieuCollecte)
        Controls.Add(txtNomDechet)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel5)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Name = "AjoutForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AjoutForm"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnF As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNomDechet As TextBox
    Friend WithEvents txtLieuCollecte As TextBox
    Friend WithEvents txtResponsable As TextBox
    Friend WithEvents txtQuantite As TextBox
    Friend WithEvents comboUniteMesure As ComboBox
    Friend WithEvents comboTypeDechet As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
