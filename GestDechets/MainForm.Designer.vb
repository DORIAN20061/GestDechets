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
        ButtonSupp = New Button()
        ButtonRecher = New Button()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel6 = New Panel()
        Button1 = New Button()
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
        ButtonAjouter.Location = New Point(139, 234)
        ButtonAjouter.Name = "ButtonAjouter"
        ButtonAjouter.Size = New Size(282, 140)
        ButtonAjouter.TabIndex = 2
        ButtonAjouter.Text = "Ajouter"
        ButtonAjouter.UseVisualStyleBackColor = True
        ' 
        ' ButtonModifier
        ' 
        ButtonModifier.Font = New Font("Times New Roman", 11F)
        ButtonModifier.Location = New Point(139, 487)
        ButtonModifier.Name = "ButtonModifier"
        ButtonModifier.Size = New Size(282, 140)
        ButtonModifier.TabIndex = 3
        ButtonModifier.Text = "Modifier"
        ButtonModifier.UseVisualStyleBackColor = True
        ' 
        ' ButtonSupp
        ' 
        ButtonSupp.Font = New Font("Times New Roman", 11F)
        ButtonSupp.Location = New Point(630, 234)
        ButtonSupp.Name = "ButtonSupp"
        ButtonSupp.Size = New Size(282, 140)
        ButtonSupp.TabIndex = 4
        ButtonSupp.Text = "Supprimer"
        ButtonSupp.UseVisualStyleBackColor = True
        ' 
        ' ButtonRecher
        ' 
        ButtonRecher.Font = New Font("Times New Roman", 11F)
        ButtonRecher.Location = New Point(630, 497)
        ButtonRecher.Name = "ButtonRecher"
        ButtonRecher.Size = New Size(282, 140)
        ButtonRecher.TabIndex = 5
        ButtonRecher.Text = "Rechercher "
        ButtonRecher.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Center
        Panel2.Location = New Point(161, 519)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(65, 73)
        Panel2.TabIndex = 6
        ' 
        ' Panel3
        ' 
        Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), Image)
        Panel3.BackgroundImageLayout = ImageLayout.Center
        Panel3.Location = New Point(648, 272)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(56, 73)
        Panel3.TabIndex = 7
        ' 
        ' Panel4
        ' 
        Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), Image)
        Panel4.BackgroundImageLayout = ImageLayout.Center
        Panel4.Location = New Point(648, 543)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(56, 68)
        Panel4.TabIndex = 8
        ' 
        ' Panel6
        ' 
        Panel6.BackgroundImage = CType(resources.GetObject("Panel6.BackgroundImage"), Image)
        Panel6.BackgroundImageLayout = ImageLayout.Center
        Panel6.Location = New Point(161, 272)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(65, 73)
        Panel6.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.Font = New Font("Times New Roman", 11F)
        Button1.Location = New Point(916, 738)
        Button1.Name = "Button1"
        Button1.Size = New Size(177, 72)
        Button1.TabIndex = 9
        Button1.Text = "Close"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1088, 807)
        Controls.Add(Button1)
        Controls.Add(Panel6)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(ButtonRecher)
        Controls.Add(ButtonSupp)
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
    Friend WithEvents ButtonSupp As Button
    Friend WithEvents ButtonRecher As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button1 As Button
End Class
