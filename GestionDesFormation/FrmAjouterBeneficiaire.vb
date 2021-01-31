Imports MySql.Data.MySqlClient
Imports Microsoft.SqlServer.Server

Public Class FrmAjouterBeneficiaire
#Region "declare"
    Dim mycmd As New MySqlCommand
    Dim myconnection As New DbConnection
    Dim objreader As MySqlDataReader
#End Region
    Private Sub BtnAnnuler_Click(sender As Object, e As EventArgs) Handles BtnAnnuler.Click
        'FrmPrincipale.Size = New Size(715, 485)
        ChangerForm(FrmGestionBeneficiaire) : FrmPrincipale.Text = "Gestion des Beneficiaires"
        Me.Dispose()
    End Sub

    Private Sub BtnAjouter_Click(sender As Object, e As EventArgs) Handles BtnAjouter.Click
        'DateNais.Format = DateTimePickerFormat.Custom
        'DateNais.CustomFormat = "yyyy-MM-dd"
        mycmd.Connection = myconnection.Open
        mycmd.CommandText = "Insert Into T_Beneficiaire (CodeB, Nom, Prenom, Ville, Date_nais)
                            Values ('" & TxtCode.Text & "','" & TxtNom.Text & "',
                                    '" & TxtPrenom.Text & "','" & TxtVille.Text & "','" & DateNais.Value.ToString("yyyy-MM-dd") & "')"
        'DateNais.Format = DateTimePickerFormat.Long
        mycmd.ExecuteNonQuery()
        objreader.Close() : mycmd.Dispose()
        myconnection.close()
        MsgBox("Ajouté avec succès.", MsgBoxStyle.Information, "Notification")
        'FrmPrincipale.Size = New Size(730, 485)
        ChangerForm(FrmGestionBeneficiaire) : FrmPrincipale.Text = "Gestion des Beneficiaires"
        FrmGestionBeneficiaire.Remplir_Liste_Beneficiaires()
        Me.Dispose()
    End Sub
    Private Sub TxtCode_LostFocus(sender As Object, e As EventArgs) Handles TxtCode.LostFocus
        mycmd.Connection = myconnection.Open
        mycmd.CommandText = "Select CodeB From T_Beneficiaire Where CodeB='" & TxtCode.Text.Trim & "'"
        objreader = mycmd.ExecuteReader
        objreader.Read()

        If objreader.HasRows = True Then
            MsgBox("le code existe déjà.", vbCritical, "Erreur")
            TxtCode.Text = Nothing : TxtCode.Focus()

        End If
        objreader.Close() : mycmd.Dispose() : myconnection.Close()
    End Sub

End Class