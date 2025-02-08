<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificationForm))
        Panel1 = New Panel()
        Button1 = New Button()
        Label1 = New Label()
        Panel5 = New Panel()
        ButtonModifier = New Button()
        ButtonSupprimer = New Button()
        ButtonAnnuler = New Button()
        DataGridView1 = New DataGridView()
        comboTypeDechet = New ComboBox()
        comboUniteMesure = New ComboBox()
        txtQuantite = New TextBox()
        txtResponsable = New TextBox()
        txtLieuCollecte = New TextBox()
        txtNomDechet = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        MenuStrip1 = New MenuStrip()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.MenuHighlight
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(2, 921)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1526, 123)
        Panel1.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.Location = New Point(1338, 55)
        Button1.Name = "Button1"
        Button1.Size = New Size(174, 55)
        Button1.TabIndex = 7
        Button1.Text = "Fermer"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(320, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(293, 36)
        Label1.TabIndex = 3
        Label1.Text = "Modifier des Déchets "
        ' 
        ' Panel5
        ' 
        Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), Image)
        Panel5.ForeColor = SystemColors.ActiveCaption
        Panel5.Location = New Point(2, 3)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(216, 104)
        Panel5.TabIndex = 6
        ' 
        ' ButtonModifier
        ' 
        ButtonModifier.Location = New Point(24, 868)
        ButtonModifier.Name = "ButtonModifier"
        ButtonModifier.Size = New Size(112, 34)
        ButtonModifier.TabIndex = 7
        ButtonModifier.Text = "Modifier"
        ButtonModifier.UseVisualStyleBackColor = True
        ' 
        ' ButtonSupprimer
        ' 
        ButtonSupprimer.Location = New Point(173, 868)
        ButtonSupprimer.Name = "ButtonSupprimer"
        ButtonSupprimer.Size = New Size(112, 34)
        ButtonSupprimer.TabIndex = 8
        ButtonSupprimer.Text = "Supprimer"
        ButtonSupprimer.UseVisualStyleBackColor = True
        ' 
        ' ButtonAnnuler
        ' 
        ButtonAnnuler.BackColor = Color.LimeGreen
        ButtonAnnuler.Location = New Point(332, 868)
        ButtonAnnuler.Name = "ButtonAnnuler"
        ButtonAnnuler.Size = New Size(112, 34)
        ButtonAnnuler.TabIndex = 9
        ButtonAnnuler.Text = "Revenir"
        ButtonAnnuler.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(36, 159)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(1164, 290)
        DataGridView1.TabIndex = 13
        ' 
        ' comboTypeDechet
        ' 
        comboTypeDechet.FormattingEnabled = True
        comboTypeDechet.Items.AddRange(New Object() {"Organiques", "Plastiques"})
        comboTypeDechet.Location = New Point(208, 599)
        comboTypeDechet.Name = "comboTypeDechet"
        comboTypeDechet.Size = New Size(237, 33)
        comboTypeDechet.TabIndex = 37
        ' 
        ' comboUniteMesure
        ' 
        comboUniteMesure.FormattingEnabled = True
        comboUniteMesure.Location = New Point(674, 490)
        comboUniteMesure.Name = "comboUniteMesure"
        comboUniteMesure.Size = New Size(237, 33)
        comboUniteMesure.TabIndex = 36
        ' 
        ' txtQuantite
        ' 
        txtQuantite.Location = New Point(208, 703)
        txtQuantite.Name = "txtQuantite"
        txtQuantite.Size = New Size(237, 31)
        txtQuantite.TabIndex = 35
        ' 
        ' txtResponsable
        ' 
        txtResponsable.Location = New Point(674, 709)
        txtResponsable.Name = "txtResponsable"
        txtResponsable.Size = New Size(237, 31)
        txtResponsable.TabIndex = 34
        ' 
        ' txtLieuCollecte
        ' 
        txtLieuCollecte.Location = New Point(674, 593)
        txtLieuCollecte.Name = "txtLieuCollecte"
        txtLieuCollecte.Size = New Size(237, 31)
        txtLieuCollecte.TabIndex = 33
        ' 
        ' txtNomDechet
        ' 
        txtNomDechet.Location = New Point(208, 490)
        txtNomDechet.Name = "txtNomDechet"
        txtNomDechet.Size = New Size(237, 31)
        txtNomDechet.TabIndex = 32
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(524, 706)
        Label7.Name = "Label7"
        Label7.Size = New Size(112, 25)
        Label7.TabIndex = 31
        Label7.Text = "Responsable"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(524, 599)
        Label6.Name = "Label6"
        Label6.Size = New Size(132, 25)
        Label6.TabIndex = 30
        Label6.Text = "Lieu de collecte"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(524, 490)
        Label5.Name = "Label5"
        Label5.Size = New Size(135, 25)
        Label5.TabIndex = 29
        Label5.Text = "Unité de mesue"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(36, 712)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 25)
        Label4.TabIndex = 28
        Label4.Text = "Quantité"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(36, 599)
        Label3.Name = "Label3"
        Label3.Size = New Size(142, 25)
        Label3.TabIndex = 27
        Label3.Text = "Type de Déchets"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(36, 493)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 25)
        Label2.TabIndex = 26
        Label2.Text = "Nom du déchet"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1526, 24)
        MenuStrip1.TabIndex = 38
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ModificationForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1526, 1043)
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
        Controls.Add(DataGridView1)
        Controls.Add(ButtonAnnuler)
        Controls.Add(ButtonSupprimer)
        Controls.Add(ButtonModifier)
        Controls.Add(Panel5)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "ModificationForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ModificationForm"
        Panel1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonModifier As Button
    Friend WithEvents ButtonSupprimer As Button
    Friend WithEvents ButtonAnnuler As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents comboTypeDechet As ComboBox
    Friend WithEvents comboUniteMesure As ComboBox
    Friend WithEvents txtQuantite As TextBox
    Friend WithEvents txtResponsable As TextBox
    Friend WithEvents txtLieuCollecte As TextBox
    Friend WithEvents txtNomDechet As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
