<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        ISBN = New Label()
        txtISBN = New TextBox()
        auteur = New Label()
        titre = New Label()
        txtAuteur = New TextBox()
        txtTitre = New TextBox()
        btnAjouter = New Button()
        btnAfficher = New Button()
        SuspendLayout()
        ' 
        ' ISBN
        ' 
        ISBN.AutoSize = True
        ISBN.BackColor = Color.PapayaWhip
        ISBN.Font = New Font("Tempus Sans ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ISBN.Location = New Point(131, 63)
        ISBN.Name = "ISBN"
        ISBN.Size = New Size(65, 30)
        ISBN.TabIndex = 0
        ISBN.Text = "ISBN"
        ' 
        ' txtISBN
        ' 
        txtISBN.Location = New Point(338, 66)
        txtISBN.Name = "txtISBN"
        txtISBN.Size = New Size(250, 27)
        txtISBN.TabIndex = 1
        ' 
        ' auteur
        ' 
        auteur.AutoSize = True
        auteur.BackColor = Color.PapayaWhip
        auteur.Font = New Font("Tempus Sans ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        auteur.Location = New Point(131, 251)
        auteur.Name = "auteur"
        auteur.Size = New Size(89, 30)
        auteur.TabIndex = 2
        auteur.Text = "Auteur"
        ' 
        ' titre
        ' 
        titre.AutoSize = True
        titre.BackColor = Color.PapayaWhip
        titre.Font = New Font("Tempus Sans ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        titre.Location = New Point(131, 153)
        titre.Name = "titre"
        titre.Size = New Size(63, 30)
        titre.TabIndex = 3
        titre.Text = "Titre"
        ' 
        ' txtAuteur
        ' 
        txtAuteur.Location = New Point(338, 254)
        txtAuteur.Name = "txtAuteur"
        txtAuteur.Size = New Size(250, 27)
        txtAuteur.TabIndex = 4
        ' 
        ' txtTitre
        ' 
        txtTitre.Location = New Point(338, 153)
        txtTitre.Name = "txtTitre"
        txtTitre.Size = New Size(250, 27)
        txtTitre.TabIndex = 5
        ' 
        ' btnAjouter
        ' 
        btnAjouter.BackColor = Color.Black
        btnAjouter.Font = New Font("Tempus Sans ITC", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnAjouter.ForeColor = Color.PapayaWhip
        btnAjouter.Location = New Point(86, 345)
        btnAjouter.Name = "btnAjouter"
        btnAjouter.Size = New Size(281, 61)
        btnAjouter.TabIndex = 6
        btnAjouter.Text = "Ajouter"
        btnAjouter.UseVisualStyleBackColor = False
        ' 
        ' btnAfficher
        ' 
        btnAfficher.BackColor = Color.Black
        btnAfficher.Font = New Font("Tempus Sans ITC", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnAfficher.ForeColor = Color.PapayaWhip
        btnAfficher.Location = New Point(436, 345)
        btnAfficher.Name = "btnAfficher"
        btnAfficher.Size = New Size(281, 61)
        btnAfficher.TabIndex = 7
        btnAfficher.Text = "Afficher"
        btnAfficher.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(btnAfficher)
        Controls.Add(btnAjouter)
        Controls.Add(txtTitre)
        Controls.Add(txtAuteur)
        Controls.Add(titre)
        Controls.Add(auteur)
        Controls.Add(txtISBN)
        Controls.Add(ISBN)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ISBN As Label
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents auteur As Label
    Friend WithEvents titre As Label
    Friend WithEvents txtAuteur As TextBox
    Friend WithEvents txtTitre As TextBox
    Friend WithEvents btnAjouter As Button
    Friend WithEvents btnAfficher As Button

End Class
