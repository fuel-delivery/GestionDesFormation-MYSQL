Imports GestionDesFormation.My
Imports MySql.Data.MySqlClient
Public Class FrmSuivre
    'Private Sub BtnAjouterBeneficiaire_Click(sender As Object, e As EventArgs)
    '    FrmPrincipale.Size = New Size(525, 430)
    '    ChangerForm(FrmAjouterBeneficiaire)
    'End Sub
#Region "declare"
    Dim CodeBChoisie As String
    Dim CodeFchoisie As String
    Dim mycmd As New MySqlCommand
    Dim myconnection As New DbConnection
    Dim objreader As MySqlDataReader
#End Region
    Private Sub FrmSuivre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Remplir_Combo_Beneficiaire()
        Remplir_Combo_Formation()
    End Sub

    Private Sub BtnAjouterFormation_Click_1(sender As Object, e As EventArgs) Handles BtnAjouterFormation.Click
        'FrmPrincipale.Size = New Size(425, 220)
        ChangerForm(FrmAjouterFormation) : FrmPrincipale.Text = "Ajouter une Formation"
    End Sub

    Private Sub BtnAjouter_Click(sender As Object, e As EventArgs) Handles BtnAjouter.Click
        CodeBChoisie = Beneficiaire_choisie(CmbBeneficiaire.SelectedItem.ToString)
        CodeFchoisie = CmbFormation.SelectedItem.ToString
        If CheckDoubleFormation() = False Then
            mycmd.Connection = myconnection.Open
            mycmd.CommandText = "Insert Into T_Suivre (CodeF, CodeB, DateDebut , DateFin)
                            Values ('" & CodeFchoisie & "','" & CodeBChoisie & "','" & DateDebutF.Value.ToString("yyyy-MM-dd") & "','" & DateFinF.Value.ToString("yyyy-MM-dd") & "')"
            mycmd.ExecuteNonQuery()
            mycmd.Dispose() : myconnection.Close()
            Remplir_Liste_Suivre(CodeBChoisie, "")
            CmbFormation.SelectedIndex = -1
            DateDebutF.Value = Date.Now
            DateFinF.Value = Date.Now
        Else
            CmbFormation.SelectedIndex = -1
        End If
    End Sub
    Sub Remplir_Combo_Formation()
        mycmd.Connection = myconnection.Open
        mycmd.CommandText = "Select * From T_Formation"
        objreader = mycmd.ExecuteReader
        'Lire les enregistrements du DR2
        Dim I As Integer = 0
        CmbFormation.Items.Clear()
        Do While objreader.Read() = True
            CmbFormation.Items.Add(objreader("CodeF"))
            I = I + 1
        Loop
        mycmd.Dispose() : objreader.Close() : myconnection.Close()
    End Sub
    Function CheckDoubleFormation() As Boolean
        Dim ExistDeja As Boolean = False
        mycmd.Connection = myconnection.Open
        mycmd.CommandText = "Select * From T_Suivre Where T_Suivre.CodeB='" & CodeBChoisie & "' And T_Suivre.CodeF='" & CodeFchoisie & "'"
        objreader = mycmd.ExecuteReader
        If objreader.HasRows = True Then
            MsgBox("Le Beneficiaire " & CmbBeneficiaire.SelectedItem & "  participe déjà à cette formation (" & LblFormation.Text & ").", vbCritical, "Important!")
            ExistDeja = True
        End If
        mycmd.Dispose() : objreader.Close() : myconnection.Close()
        Return ExistDeja
    End Function
    Private Function Beneficiaire_choisie(ByVal Beneficiare As String) As String
        Dim CodeBChoisie As String = ""
        If Beneficiare = "" Then
            Return CodeBChoisie
            Exit Function
        End If
        myconnection.Close()
        Dim cmd1 As New MySqlCommand
        Dim objreader1 As MySqlDataReader

        cmd1.Connection = myconnection.Open
        cmd1.CommandText = "Select * From T_Beneficiaire"
        objreader1 = cmd1.ExecuteReader
        Do While objreader1.Read()
            If Beneficiare = (objreader1("Nom").ToString + Space(1) + objreader1("Prenom").ToString) Then
                CodeBChoisie = objreader1("CodeB").ToString
            Else

            End If
        Loop
        cmd1.Dispose() : objreader1.Close() : myconnection.Close()
        Return CodeBChoisie
    End Function
    Sub Remplir_Combo_Beneficiaire()
        mycmd.Connection = myconnection.Open
        mycmd.CommandText = "Select * From T_Beneficiaire"
        objreader = mycmd.ExecuteReader
        'Lire les enregistrements du DR2
        Dim I As Integer = 0
        CmbBeneficiaire.Items.Clear()
        Do While objreader.Read() = True
            CmbBeneficiaire.Items.Add(objreader("Nom") + Space(1) + objreader("Prenom"))
            I = I + 1
        Loop
        mycmd.Dispose() : objreader.Close() : myconnection.Close()
    End Sub
    Sub Remplir_Lbl_Formation()
        mycmd.Connection = myconnection.Open
        mycmd.CommandText = "Select Libelle From T_Formation Where CodeF= '" & CmbFormation.SelectedItem.ToString & "'"
        objreader = mycmd.ExecuteReader
        objreader.Read()
        LblFormation.Text = objreader("Libelle").ToString()
        mycmd.Dispose() : objreader.Close() : myconnection.Close()
    End Sub

    Private Sub CmbFormation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbFormation.SelectedIndexChanged
        If CmbFormation.SelectedIndex >= 0 Then
            Remplir_Lbl_Formation()
            Dim Bchoisie As String = ""
            If CmbBeneficiaire.SelectedIndex > -1 Then
                Bchoisie = CmbBeneficiaire.SelectedItem.ToString()
            End If
            Remplir_Liste_Suivre(Beneficiaire_choisie(Bchoisie), CmbFormation.SelectedItem)
            Else
                LblFormation.Text = Nothing
        End If

    End Sub
    Sub Remplir_Liste_Suivre(ByVal Bchoisie As String, ByVal Fchoisie As String)
        Dim Commandtxt As String = ""
        If Fchoisie = "" And Bchoisie = "" Then
            Commandtxt = "SELECT T_Suivre.CodeB, T_Beneficiaire.Nom, T_Formation.Libelle, T_Suivre.DateDebut, T_Suivre.DateFin
FROM T_Formation INNER JOIN (T_Beneficiaire INNER JOIN T_Suivre ON T_Beneficiaire.CodeB = T_Suivre.CodeB) ON T_Formation.CodeF = T_Suivre.CodeF;"
        ElseIf Fchoisie = "" Then
            Commandtxt = "SELECT T_Suivre.CodeB, T_Beneficiaire.Nom, T_Formation.Libelle, T_Suivre.DateDebut, T_Suivre.DateFin
FROM T_Formation INNER JOIN (T_Beneficiaire INNER JOIN T_Suivre ON T_Beneficiaire.CodeB = T_Suivre.CodeB) ON T_Formation.CodeF = T_Suivre.CodeF
WHERE (((T_Suivre.CodeB)='" & Bchoisie & "') AND (T_Suivre.CodeB=T_Beneficiaire.CodeB));"
        ElseIf Bchoisie = "" Then
            Commandtxt = "SELECT T_Suivre.CodeB, T_Beneficiaire.Nom, T_Formation.Libelle, T_Suivre.DateDebut, T_Suivre.DateFin
FROM T_Formation INNER JOIN (T_Beneficiaire INNER JOIN T_Suivre ON T_Beneficiaire.CodeB = T_Suivre.CodeB) ON T_Formation.CodeF = T_Suivre.CodeF
WHERE ((T_Suivre.CodeB=T_Beneficiaire.CodeB) AND (T_Suivre.CodeF='" & Fchoisie & "'));"
        Else
            Commandtxt = "SELECT T_Suivre.CodeB, T_Beneficiaire.Nom, T_Formation.Libelle, T_Suivre.DateDebut, T_Suivre.DateFin
FROM T_Formation INNER JOIN (T_Beneficiaire INNER JOIN T_Suivre ON T_Beneficiaire.CodeB = T_Suivre.CodeB) ON T_Formation.CodeF = T_Suivre.CodeF
WHERE (((T_Suivre.CodeB)='" & Bchoisie & "') AND (T_Suivre.CodeB=T_Beneficiaire.CodeB) AND (T_Suivre.CodeF='" & Fchoisie & "'));"
        End If
        mycmd.Connection = myconnection.Open
        mycmd.CommandText = Commandtxt
        objreader = mycmd.ExecuteReader
        If objreader.HasRows = False Then
            DGV_Suivre.Rows.Clear()
            mycmd.Dispose() : objreader.Close() : myconnection.Close()
            Exit Sub
        End If
        Dim I As Integer = 0
        'Initialiser et vider l'objet DataGridView
        DGV_Suivre.Rows.Clear()
        Do While objreader.Read() = True
            With DGV_Suivre
                .Rows.Add()  'Ajouter une nouvelle Ligne
                .Item("Col_CodeB", I).Value = objreader("CodeB")
                .Item("Col_Nom", I).Value = objreader("Nom")
                .Item("Col_Libelle", I).Value = objreader("Libelle")
                .Item("Col_DateDebut", I).Value = FormatDateTime(objreader("DateDebut"), DateFormat.ShortDate)
                .Item("Col_DateFin", I).Value = FormatDateTime(objreader("DateFin"), DateFormat.ShortDate)
                I = I + 1
            End With
        Loop
        mycmd.Dispose() : objreader.Close() : myconnection.Close()
    End Sub
    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        'FrmPrincipale.Size = New Size(495, 475)
        ChangerForm(FrmAdmin) : FrmPrincipale.Text = "Gestion des Formations - Admin: " + MySettings.Default.AdminName
        Me.Dispose()
    End Sub

    Private Sub CmbBeneficiaire_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBeneficiaire.SelectedIndexChanged
        If CmbBeneficiaire.SelectedIndex > -1 Then
            Remplir_Liste_Suivre(Beneficiaire_choisie(CmbBeneficiaire.SelectedItem.ToString), CmbFormation.SelectedItem)
        End If
        CmbFormation.SelectedIndex = -1
        DateDebutF.Value = Date.Now
        DateFinF.Value = Date.Now

    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        CmbBeneficiaire.SelectedIndex = -1 : CmbFormation.SelectedIndex = -1
        LblFormation.Text = "" : DGV_Suivre.Rows.Clear()
        DateDebutF.Value = Date.Now : DateFinF.Value = Date.Now

    End Sub
End Class