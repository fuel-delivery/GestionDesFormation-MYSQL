Imports GestionDesFormation.My
Imports MySql.Data.MySqlClient
Public Class FrmGestionBeneficiaire
#Region "declare"
    Dim mycmd As New MySqlCommand
    Dim myconnection As New DbConnection
    Dim objreader As MySqlDataReader
#End Region

    Private Sub BtnAjouter_Click(sender As Object, e As EventArgs) Handles BtnAjouter.Click
        'FrmPrincipale.Size = New Size(525, 430)
        ChangerForm(FrmAjouterBeneficiaire) : FrmPrincipale.Text = "Ajouter Un Beneficiaire"
    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        'FrmPrincipale.Size = New Size(495, 475)
        ChangerForm(FrmAdmin) : FrmPrincipale.Text = "Gestion des Formations - Admin: " + MySettings.Default.AdminName
        myconnection.Close()
        Me.Dispose()
    End Sub

    Private Sub FrmGestionBeneficiaire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Remplir_Liste_Beneficiaires()
    End Sub
    Public Sub Remplir_Liste_Beneficiaires()
        mycmd.Connection = myconnection.Open
        mycmd.CommandText = "Select * From T_Beneficiaire"
        objreader = mycmd.ExecuteReader
        If objreader.HasRows = True Then
            BtnImprimer.Visible = True : BtnModifier.Visible = True : BtnSupprimer.Visible = True
        Else
            DGV_Beneficiaires.Rows.Clear()
            mycmd.Dispose() : objreader.Close() : myconnection.Close()
            MsgBox("Il n'y a pas de données dans la base de données!", vbInformation, "Information")
            BtnImprimer.Visible = False : BtnModifier.Visible = False : BtnSupprimer.Visible = False
            Exit Sub
        End If
        'Lire les enregistrements du DR2
        Dim I As Integer = 0
        'Initialiser et vider l'objet DataGridView
        DGV_Beneficiaires.Rows.Clear()
        Do While objreader.Read() = True
            With DGV_Beneficiaires
                .Rows.Add()  'Ajouter une nouvelle Ligne
                .Item("Col_CodeB", I).Value = objreader("CodeB")
                .Item("Col_Nom", I).Value = objreader("Nom")
                .Item("Col_Prenom", I).Value = objreader("Prenom")
                .Item("Col_Date_nais", I).Value = FormatDateTime(objreader("Date_nais"), DateFormat.ShortDate)
                .Item("Col_Ville", I).Value = objreader("Ville")
                I = I + 1
            End With
        Loop
        mycmd.Dispose() : objreader.Close() : myconnection.Close()
    End Sub

    Private Sub BtnSupprimer_Click(sender As Object, e As EventArgs) Handles BtnSupprimer.Click
        Dim BeneficiaireChoisie As String
        BeneficiaireChoisie = DGV_Beneficiaires.Item(Col_CodeB.Index, DGV_Beneficiaires.CurrentCell.RowIndex).Value
        Dim Msg As String = "êtes-vous sûr de vouloir supprimer le bénéficiaire qui a le code: '" & BeneficiaireChoisie & "'"
        If MsgBox(Msg, vbInformation + MsgBoxStyle.YesNo, "Confirmation de la suppression") = MsgBoxResult.Yes Then
            mycmd.Connection = myconnection.Open
            mycmd.CommandText = ("DELETE FROM T_Beneficiaire WHERE CodeB='" & BeneficiaireChoisie & "'")
            mycmd.ExecuteNonQuery()
            mycmd.Dispose() : myconnection.Close()

            For Each row As DataGridViewRow In DGV_Beneficiaires.SelectedRows
                DGV_Beneficiaires.Rows.Remove(row)
            Next
        End If
    End Sub

    Private Sub BtnRechercher_Click(sender As Object, e As EventArgs) Handles BtnRechercher.Click
        If TxtRechercher.Text <> Nothing Then
            If RdbVille.Checked = True Then
                Remplir_ListeB_Critere("Ville", TxtRechercher.Text)
            ElseIf RdbNom.Checked = True Then
                Remplir_ListeB_Critere("Nom", TxtRechercher.Text)
            End If
        End If
    End Sub
    Sub Remplir_ListeB_Critere(ByVal Critere As String, ByVal Donner As String)
        mycmd.Connection = myconnection.Open
        Donner = "%" + Donner.Trim + "%"
        mycmd.CommandText = "SELECT T_Beneficiaire.CodeB, T_Beneficiaire.Nom, T_Beneficiaire.Prenom, T_Beneficiaire.Date_nais, T_Beneficiaire.Ville FROM T_Beneficiaire WHERE T_Beneficiaire." & Critere & " LIKE '" & Donner & "';"
        objreader = mycmd.ExecuteReader
        If objreader.HasRows = True Then
            BtnImprimer.Visible = True : BtnModifier.Visible = True : BtnSupprimer.Visible = True
        Else
            DGV_Beneficiaires.Rows.Clear()
            mycmd.Dispose() : objreader.Close() : myconnection.Close()
            Dim Crtr As String = ""
            Select Case Critere
                Case "Ville"
                    Crtr = "La ville"
                Case "Nom"
                    Crtr = "Le nom"
            End Select
            MsgBox(Crtr & " que vous avez entré n'existe pas !", vbInformation, "Information")
            BtnImprimer.Visible = False : BtnModifier.Visible = False : BtnSupprimer.Visible = False
            Exit Sub
        End If
        'Lire les enregistrements du DR2
        Dim I As Integer = 0
        'Initialiser et vider l'objet DataGridView
        DGV_Beneficiaires.Rows.Clear()
        Do While objreader.Read() = True
            With DGV_Beneficiaires
                .Rows.Add()  'Ajouter une nouvelle Ligne
                .Item("Col_CodeB", I).Value = objreader("CodeB")
                .Item("Col_Nom", I).Value = objreader("Nom")
                .Item("Col_Prenom", I).Value = objreader("Prenom")
                .Item("Col_Date_nais", I).Value = FormatDateTime(objreader("Date_nais"), DateFormat.ShortDate)
                .Item("Col_Ville", I).Value = objreader("Ville")
                I = I + 1
            End With
        Loop
        mycmd.Dispose() : objreader.Close() : myconnection.Close()
    End Sub

    Private Sub RdbTous_CheckedChanged(sender As Object, e As EventArgs) Handles RdbTous.CheckedChanged
        If RdbTous.Checked = True Then
            TxtRechercher.Text = Nothing : TxtRechercher.Enabled = False
            Remplir_Liste_Beneficiaires()
        Else
            TxtRechercher.Text = Nothing : TxtRechercher.Enabled = True
        End If
    End Sub

    Private Sub RdbNom_CheckedChanged(sender As Object, e As EventArgs) Handles RdbNom.CheckedChanged
        TxtRechercher.Text = Nothing
        If RdbNom.Checked = True Then TxtRechercher.Focus()
    End Sub

    Private Sub RdbVille_CheckedChanged(sender As Object, e As EventArgs) Handles RdbVille.CheckedChanged
        TxtRechercher.Text = Nothing
        If RdbVille.Checked = True Then TxtRechercher.Focus()
    End Sub

    Private Sub BtnModifier_Click(sender As Object, e As EventArgs) Handles BtnModifier.Click
        'Dim BeneficiaireChoisie As String
        'BeneficiaireChoisie = DGV_Beneficiaires.Item(Col_CodeB.Index, DGV_Beneficiaires.CurrentCell.RowIndex).Value
        'Dim CmdModifier As New OleDbCommand
        'CmdModifier.CommandText = ("DELETE FROM T_Beneficiaire WHERE CodeB='" & BeneficiaireChoisie & "'")
        'CmdModifier.Connection = CN
        'CmdModifier.ExecuteNonQuery()
        'CmdModifier.Dispose()
        'For Each row As DataGridViewRow In DGV_Beneficiaires.SelectedRows
        '    DGV_Beneficiaires.Rows.Remove(row)
        'Next
    End Sub

    Private Sub DGV_Beneficiaires_SelectionChanged(sender As Object, e As EventArgs) Handles DGV_Beneficiaires.SelectionChanged
        With DGV_Beneficiaires
            If .SelectedRows.Count > 1 Then
                .SelectedRows(.SelectedRows.Count - 1).Selected = False
            End If
        End With
    End Sub
End Class