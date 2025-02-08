<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Label1 = New Label()
        Panel1 = New Panel()
        Panel5 = New Panel()
        ButtonAjouter = New Button()
        ButtonModifier = New Button()
        Panel2 = New Panel()
        Panel6 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 16F, FontStyle.Bold)
        Label1.Location = New Point(239, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(733, 36)
        Label1.TabIndex = 0
        Label1.Text = "Bienvenue sur le Gestionnaire de déchets de KEYCE"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.MenuHighlight
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(3, -7)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1090, 178)
        Panel1.TabIndex = 1
        ' 
        ' Panel5
        ' 
        Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), Image)
        Panel5.ForeColor = SystemColors.ActiveCaption
        Panel5.Location = New Point(26, 19)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(219, 82)
        Panel5.TabIndex = 1
        ' 
        ' ButtonAjouter
        ' 
        ButtonAjouter.Font = New Font("Times New Roman", 11F)
        ButtonAjouter.Location = New Point(119, 374)
        ButtonAjouter.Name = "ButtonAjouter"
        ButtonAjouter.Size = New Size(341, 168)
        ButtonAjouter.TabIndex = 2
        ButtonAjouter.Text = "Ajouter"
        ButtonAjouter.UseVisualStyleBackColor = True
        ' 
        ' ButtonModifier
        ' 
        ButtonModifier.Font = New Font("Times New Roman", 11F)
        ButtonModifier.Location = New Point(584, 374)
        ButtonModifier.Name = "ButtonModifier"
        ButtonModifier.Size = New Size(319, 168)
        ButtonModifier.TabIndex = 3
        ButtonModifier.Text = "Modifier"
        ButtonModifier.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Center
        Panel2.Location = New Point(609, 420)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(78, 73)
        Panel2.TabIndex = 6
        ' 
        ' Panel6
        ' 
        Panel6.BackgroundImage = CType(resources.GetObject("Panel6.BackgroundImage"), Image)
        Panel6.BackgroundImageLayout = ImageLayout.Center
        Panel6.Location = New Point(153, 420)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(78, 68)
        Panel6.TabIndex = 7
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1096, 807)
        Controls.Add(Panel6)
        Controls.Add(Panel2)
        Controls.Add(ButtonModifier)
        Controls.Add(ButtonAjouter)
        Controls.Add(Panel1)
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MainForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonAjouter As Button
    Friend WithEvents ButtonModifier As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
End Class
