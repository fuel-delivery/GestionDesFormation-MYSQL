Imports MySql.Data.MySqlClient
#Region "declare"
Public Class FrmAjouterFormation
    Dim mycmd As New MySqlCommand
    Dim myconnection As New DbConnection
    Dim objreader As MySqlDataReader
#End Region
    Private Sub BtnAnnuler_Click(sender As Object, e As EventArgs) Handles BtnAnnuler.Click
        FrmPrincipale.Size = New Size(715, 485)
        ChangerForm(FrmSuivre)
        Me.Dispose() : FrmPrincipale.Text = "Gestion des Formations"
    End Sub

    Private Sub BtnAjouter_Click(sender As Object, e As EventArgs) Handles BtnAjouter.Click
        Dim NomFormation As String
        If TxtCode.Text = Nothing Or TxtNom.Text = Nothing Then
            MsgBox("Remplir tous les zones de texte.", vbCritical, "Important!")
            If TxtCode.Text = Nothing Then
                TxtCode.Focus() : Exit Sub
            Else
                TxtNom.Focus() : Exit Sub
            End If
        Else
            NomFormation = Chr(34) & TxtNom.Text & Chr(34)
            mycmd.Connection = myconnection.Open
            mycmd.CommandText = "Insert Into T_Formation (CodeF, Libelle)
                            Values ('" & TxtCode.Text.Trim & "'," & NomFormation & ")"

            mycmd.ExecuteNonQuery()
            MsgBox("Se terminer correctement.", vbInformation, "Information")
            mycmd.Dispose() : myconnection.Close()
        End If
        FrmPrincipale.Size = New Size(715, 485)
        ChangerForm(FrmSuivre) : FrmPrincipale.Text = "Gestion des Formations"
        FrmSuivre.Remplir_Combo_Formation()
        Me.Dispose()
    End Sub
End Class