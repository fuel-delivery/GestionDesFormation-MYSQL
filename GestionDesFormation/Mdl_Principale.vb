Imports MySql.Data.MySqlClient
Module Mdl_Principale
    Public Class DbConnection
        Dim Connexion As New MySqlConnection("server='***********';
        user='*************';
        password='************';
        database='dbformation'")
        '    Dim Connexion As New MySqlConnection("server='localhost';
        'user='root';
        'password='loveyouCR77@';
        'database='dbformation'")
        Public Function Open() As MySqlConnection
            Try
                Connexion.Open()
            Catch ex As MySqlException
                MsgBox(ex)
            End Try
            Return Connexion
        End Function

        Public Function Close() As MySqlConnection
            Try
                Connexion.Close()
            Catch ex As MySqlException
                MsgBox(ex)
            End Try
            Return Connexion
        End Function
    End Class
    Public Sub ChangerForm(ByVal Panel As Form)
        FrmPrincipale.Panel1.Controls.Clear()
        Panel.TopLevel = False
        FrmPrincipale.Panel1.Controls.Add(Panel)
        Panel.Show()
    End Sub
    Public Function ConnectionInternet() As Boolean

        Try
            Return My.Computer.Network.Ping("www.google.com")
        Catch
            Return False
        End Try

    End Function
End Module
