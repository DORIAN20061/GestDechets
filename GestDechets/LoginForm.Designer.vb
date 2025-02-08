<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TxtNom = New TextBox()
        txtPrenom = New TextBox()
        txtReservation = New TextBox()
        btnSeConnecter = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnAnnuler = New Button()
        txtMotDePasse = New TextBox()
        pnlError = New Panel()
        pnlSuccess = New Panel()
        SuspendLayout()
        ' 
        ' TxtNom
        ' 
        TxtNom.Location = New Point(200, 121)
        TxtNom.Name = "TxtNom"
        TxtNom.Size = New Size(399, 31)
        TxtNom.TabIndex = 0
        ' 
        ' txtPrenom
        ' 
        txtPrenom.Location = New Point(200, 198)
        txtPrenom.Name = "txtPrenom"
        txtPrenom.Size = New Size(399, 31)
        txtPrenom.TabIndex = 1
        ' 
        ' txtReservation
        ' 
        txtReservation.Location = New Point(200, 285)
        txtReservation.Name = "txtReservation"
        txtReservation.Size = New Size(399, 31)
        txtReservation.TabIndex = 2
        ' 
        ' btnSeConnecter
        ' 
        btnSeConnecter.Location = New Point(24, 522)
        btnSeConnecter.Name = "btnSeConnecter"
        btnSeConnecter.Size = New Size(154, 52)
        btnSeConnecter.TabIndex = 4
        btnSeConnecter.Text = "Se connecter "
        btnSeConnecter.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(24, 131)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 25)
        Label1.TabIndex = 5
        Label1.Text = "Nom"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 204)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 25)
        Label2.TabIndex = 6
        Label2.Text = "Prénom"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 291)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 25)
        Label3.TabIndex = 7
        Label3.Text = "Réservation"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(24, 381)
        Label4.Name = "Label4"
        Label4.Size = New Size(125, 25)
        Label4.TabIndex = 8
        Label4.Text = "Mot de passe "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(24, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(220, 51)
        Label5.TabIndex = 9
        Label5.Text = "Connexion"
        ' 
        ' btnAnnuler
        ' 
        btnAnnuler.BackColor = Color.Red
        btnAnnuler.Location = New Point(553, 522)
        btnAnnuler.Name = "btnAnnuler"
        btnAnnuler.Size = New Size(154, 52)
        btnAnnuler.TabIndex = 10
        btnAnnuler.Text = "Annuler"
        btnAnnuler.UseVisualStyleBackColor = False
        ' 
        ' txtMotDePasse
        ' 
        txtMotDePasse.Location = New Point(200, 375)
        txtMotDePasse.Name = "txtMotDePasse"
        txtMotDePasse.Size = New Size(399, 31)
        txtMotDePasse.TabIndex = 3
        ' 
        ' pnlError
        ' 
        pnlError.Location = New Point(376, 12)
        pnlError.Name = "pnlError"
        pnlError.Size = New Size(93, 43)
        pnlError.TabIndex = 11
        ' 
        ' pnlSuccess
        ' 
        pnlSuccess.Location = New Point(506, 12)
        pnlSuccess.Name = "pnlSuccess"
        pnlSuccess.Size = New Size(93, 43)
        pnlSuccess.TabIndex = 12
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(719, 586)
        Controls.Add(pnlSuccess)
        Controls.Add(pnlError)
        Controls.Add(btnAnnuler)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnSeConnecter)
        Controls.Add(txtMotDePasse)
        Controls.Add(txtReservation)
        Controls.Add(txtPrenom)
        Controls.Add(TxtNom)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "GestDECH"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtNom As TextBox
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents txtReservation As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents btnSeConnecter As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents txtMotDePasse As TextBox
    Friend WithEvents pnlError As Panel
    Friend WithEvents pnlSuccess As Panel

End Class
