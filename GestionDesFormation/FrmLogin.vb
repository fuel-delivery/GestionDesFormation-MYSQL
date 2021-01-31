Imports GestionDesFormation.My
Imports MySql.Data.MySqlClient
Public Class FrmLogin
#Region "declare"
    Dim mycmd As New MySqlCommand
    Dim myconnection As New DbConnection
    Dim objreader As MySqlDataReader
#End Region
    Private Sub BtnAnnuler_Click(sender As Object, e As EventArgs) Handles BtnAnnuler.Click
        Me.Dispose() : FrmPrincipale.Dispose()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        mycmd.Connection = myconnection.Open
        mycmd.CommandText = "Select * FROM T_Admin WHERE Login='" & TxtLogin.Text & "'"
        objreader = mycmd.ExecuteReader

        objreader.Read()
        If objreader.HasRows = True Then
            If objreader("Password") <> TxtPassword.Text Then
                MsgBox("Le mot de passe n'est pas correct!", vbCritical, "Erreur")
                objreader.Close() : mycmd.Dispose() : myconnection.Close()
                Exit Sub
            Else
                MySettings.Default.AdminName = objreader("Nom") + Space(1) + objreader("Prenom")
                ChangerForm(FrmAdmin) : FrmPrincipale.Text = "Gestion des Formations - Admin: " + MySettings.Default.AdminName : Me.Dispose()
            End If
        Else
            MsgBox("Nom d'utilisateur et mot de passe incorrects", vbCritical, "Erreur")
            objreader.Close() : mycmd.Dispose() : myconnection.Close()
            Exit Sub
        End If
        objreader.Close() : mycmd.Dispose() : myconnection.Close()
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            myconnection.Open()
        Catch
            EcranDemarrage.Hide()
            MsgBox("Vous êtes connecté à la base de données.", vbInformation, "Notification")
            myconnection.Close()
        End Try
        TxtLogin.Focus()
    End Sub
End Class