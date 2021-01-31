Imports GestionDesFormation.My
Imports MySql.Data.MySqlClient
Public NotInheritable Class EcranDemarrage
    Dim myconnection As New MySqlConnection
    Private Sub EcranDemarrage_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Erreur As String
        Dim Internet As Boolean = False
        Internet = ConnectionInternet()
        Do While Internet = False
            PBoxLoading.Image = My.Resources.no_network_48px
            Erreur = MsgBox("Pas du connexion internet!" & vbCrLf & "Vérifiez votre connexion Internet et réessayez.", vbCritical + vbRetryCancel, "Erreur")
            If Erreur = vbRetry Then
                Internet = ConnectionInternet()
            Else
                Exit Sub
            End If
        Loop
        Timer1.Interval = 5000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Timer1.Enabled = False
        FrmPrincipale.ShowDialog()
    End Sub
End Class
