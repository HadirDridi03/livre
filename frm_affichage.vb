Public Class frm_affichage
    Private Sub frm_affichage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        afficher_Livre(lst_isbn, lst_titre, lst_auteur)
    End Sub
End Class