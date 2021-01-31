Public Class FrmAdmin
    Private Sub LblGestionBeneficiaire_Click(sender As Object, e As EventArgs) Handles LblGestionBeneficiaire.Click
        'FrmPrincipale.Size = New Size(715, 485)
        ChangerForm(FrmGestionBeneficiaire)
        FrmPrincipale.Text = "Gestion des Beneficiaires"
    End Sub

    Private Sub LblGestionFormation_Click(sender As Object, e As EventArgs) Handles LblGestionFormation.Click
        'FrmPrincipale.Size = New Size(715, 485)
        ChangerForm(FrmSuivre)
        FrmPrincipale.Text = "Gestion des Formations"
    End Sub

    Private Sub LblFermer_Click(sender As Object, e As EventArgs) Handles LblFermer.Click
        Me.Dispose() : FrmPrincipale.Dispose()
    End Sub
End Class