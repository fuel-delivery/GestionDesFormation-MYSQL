Imports System.ComponentModel

Public Class FrmPrincipale
    Private Sub FrmPrincipale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Size = New Size(410, 290)
        ChangerForm(FrmLogin)
        Me.Text = "Gestion des Formation - Login"
    End Sub
    Private Sub FrmPrincipale_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        EcranDemarrage.Close()
    End Sub

End Class
