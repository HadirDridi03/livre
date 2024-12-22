<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_affichage
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
        lst_isbn = New ListBox()
        lst_titre = New ListBox()
        lst_auteur = New ListBox()
        btnAfficher = New Button()
        btnAjouter = New Button()
        SuspendLayout()
        ' 
        ' lst_isbn
        ' 
        lst_isbn.BackColor = SystemColors.ButtonHighlight
        lst_isbn.Font = New Font("Tempus Sans ITC", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lst_isbn.ForeColor = SystemColors.ActiveCaptionText
        lst_isbn.FormattingEnabled = True
        lst_isbn.ItemHeight = 26
        lst_isbn.Location = New Point(22, 12)
        lst_isbn.Name = "lst_isbn"
        lst_isbn.Size = New Size(223, 316)
        lst_isbn.TabIndex = 0
        ' 
        ' lst_titre
        ' 
        lst_titre.Font = New Font("Tempus Sans ITC", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lst_titre.FormattingEnabled = True
        lst_titre.ItemHeight = 26
        lst_titre.Location = New Point(290, 12)
        lst_titre.Name = "lst_titre"
        lst_titre.Size = New Size(223, 316)
        lst_titre.TabIndex = 1
        ' 
        ' lst_auteur
        ' 
        lst_auteur.Font = New Font("Tempus Sans ITC", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lst_auteur.FormattingEnabled = True
        lst_auteur.ItemHeight = 26
        lst_auteur.Location = New Point(554, 12)
        lst_auteur.Name = "lst_auteur"
        lst_auteur.Size = New Size(223, 316)
        lst_auteur.TabIndex = 2
        ' 
        ' btnAfficher
        ' 
        btnAfficher.BackColor = SystemColors.ActiveCaptionText
        btnAfficher.Font = New Font("Tempus Sans ITC", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAfficher.ForeColor = Color.PapayaWhip
        btnAfficher.Location = New Point(169, 365)
        btnAfficher.Name = "btnAfficher"
        btnAfficher.Size = New Size(170, 47)
        btnAfficher.TabIndex = 3
        btnAfficher.Text = "Afficher"
        btnAfficher.UseVisualStyleBackColor = False
        ' 
        ' btnAjouter
        ' 
        btnAjouter.BackColor = SystemColors.ActiveCaptionText
        btnAjouter.Font = New Font("Tempus Sans ITC", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAjouter.ForeColor = Color.PapayaWhip
        btnAjouter.Location = New Point(439, 365)
        btnAjouter.Name = "btnAjouter"
        btnAjouter.Size = New Size(170, 47)
        btnAjouter.TabIndex = 4
        btnAjouter.Text = "Ajouter"
        btnAjouter.UseVisualStyleBackColor = False
        ' 
        ' frm_affichage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnAjouter)
        Controls.Add(btnAfficher)
        Controls.Add(lst_auteur)
        Controls.Add(lst_titre)
        Controls.Add(lst_isbn)
        Name = "frm_affichage"
        Text = "frm_affichage"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lst_isbn As ListBox
    Friend WithEvents lst_titre As ListBox
    Friend WithEvents lst_auteur As ListBox
    Friend WithEvents btnAfficher As Button
    Friend WithEvents btnAjouter As Button
End Class
