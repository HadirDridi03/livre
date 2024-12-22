Module gestion_livre
    Public Structure Livre
        Dim ISBN As Integer
        Dim titre As String
        Dim auteur As String
    End Structure
    Public Bibliotheque(100) As Livre
    Dim Nb As Integer = 0
    Function AjouterLivre(l As Livre) As Boolean
        If Nb < Bibliotheque.Length Then
            Bibliotheque(Nb) = l
            Nb += 1
            Return True
        Else
            Return False
        End If
    End Function
    Sub afficher_Livre(l1 As ListBox, l2 As ListBox, l3 As ListBox)
        For i As Integer = 0 To Nb - 1
            l1.Items.Add(Bibliotheque(i).ISBN)
            l2.Items.Add(Bibliotheque(i).titre)
            l3.Items.Add(Bibliotheque(i).auteur)
        Next

    End Sub
    Sub afficher2_livre(dgv_livre As DataGridView)
        For i As Integer = 0 To Nb - 1
            Dim livre As Livre = Bibliotheque(i)
            dgv_livre.Rows.Add(livre.ISBN, livre.auteur, livre.titre)
        Next
    End Sub
    Function ObtenirListeLivres() As List(Of Livre)
        Dim Livres As New List(Of Livre)
        For i As Integer = 0 To Nb - 1
            Livres.Add(Bibliotheque(i))
        Next
        Return Livres
    End Function
End Module
