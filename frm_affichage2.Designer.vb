<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_affichage2
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
        DataGridView1 = New DataGridView()
        ISBN = New DataGridViewTextBoxColumn()
        titre = New DataGridViewTextBoxColumn()
        auteur = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ISBN, titre, auteur})
        DataGridView1.Location = New Point(177, 128)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(423, 73)
        DataGridView1.TabIndex = 0
        ' 
        ' ISBN
        ' 
        ISBN.HeaderText = "ISBN"
        ISBN.MinimumWidth = 6
        ISBN.Name = "ISBN"
        ISBN.Width = 125
        ' 
        ' titre
        ' 
        titre.HeaderText = "titre"
        titre.MinimumWidth = 6
        titre.Name = "titre"
        titre.Width = 125
        ' 
        ' auteur
        ' 
        auteur.HeaderText = "auteur"
        auteur.MinimumWidth = 6
        auteur.Name = "auteur"
        auteur.Width = 125
        ' 
        ' frm_affichage2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Name = "frm_affichage2"
        Text = "frm_affichage2"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ISBN As DataGridViewTextBoxColumn
    Friend WithEvents titre As DataGridViewTextBoxColumn
    Friend WithEvents auteur As DataGridViewTextBoxColumn
End Class
