Public Class Form1
    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Dim l As Livre
        l.ISBN = txtISBN.Text
        l.titre = txtTitre.Text
        l.auteur = txtAuteur.Text
        If AjouterLivre(l) Then
            MessageBox.Show("ajout de livre avec succes")
        Else
            MessageBox.Show("le tableau bibliothèque est saturé")
        End If

    End Sub

    Private Sub btnAfficher_Click(sender As Object, e As EventArgs) Handles btnAfficher.Click
        frm_affichage.Show()
    End Sub

End Class
