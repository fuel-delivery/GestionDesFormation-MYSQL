<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAjouterBeneficiaire
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtCode = New System.Windows.Forms.TextBox()
        Me.BtnAnnuler = New System.Windows.Forms.Button()
        Me.BtnAjouter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPrenom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtVille = New System.Windows.Forms.TextBox()
        Me.DateNais = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtCode
        '
        Me.TxtCode.Location = New System.Drawing.Point(248, 82)
        Me.TxtCode.Multiline = True
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.Size = New System.Drawing.Size(86, 29)
        Me.TxtCode.TabIndex = 1
        '
        'BtnAnnuler
        '
        Me.BtnAnnuler.Location = New System.Drawing.Point(490, 389)
        Me.BtnAnnuler.Name = "BtnAnnuler"
        Me.BtnAnnuler.Size = New System.Drawing.Size(84, 29)
        Me.BtnAnnuler.TabIndex = 8
        Me.BtnAnnuler.Text = "&Annuler"
        Me.BtnAnnuler.UseVisualStyleBackColor = True
        '
        'BtnAjouter
        '
        Me.BtnAjouter.Location = New System.Drawing.Point(400, 389)
        Me.BtnAjouter.Name = "BtnAjouter"
        Me.BtnAjouter.Size = New System.Drawing.Size(84, 29)
        Me.BtnAjouter.TabIndex = 7
        Me.BtnAjouter.Text = "&Ajouter"
        Me.BtnAjouter.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(197, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Code :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nom :"
        '
        'TxtNom
        '
        Me.TxtNom.Location = New System.Drawing.Point(248, 139)
        Me.TxtNom.Multiline = True
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(236, 29)
        Me.TxtNom.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(186, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Prénom :"
        '
        'TxtPrenom
        '
        Me.TxtPrenom.Location = New System.Drawing.Point(248, 196)
        Me.TxtPrenom.Multiline = True
        Me.TxtPrenom.Name = "TxtPrenom"
        Me.TxtPrenom.Size = New System.Drawing.Size(236, 29)
        Me.TxtPrenom.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(146, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Date Naissance :"
        '
        'TxtVille
        '
        Me.TxtVille.Location = New System.Drawing.Point(248, 301)
        Me.TxtVille.Multiline = True
        Me.TxtVille.Name = "TxtVille"
        Me.TxtVille.Size = New System.Drawing.Size(180, 29)
        Me.TxtVille.TabIndex = 5
        '
        'DateNais
        '
        Me.DateNais.CustomFormat = "yyyy-MM-dd"
        Me.DateNais.Location = New System.Drawing.Point(248, 253)
        Me.DateNais.Name = "DateNais"
        Me.DateNais.Size = New System.Drawing.Size(200, 20)
        Me.DateNais.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(203, 308)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Ville :"
        '
        'FrmAjouterBeneficiaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 500)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateNais)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtVille)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtPrenom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnAnnuler)
        Me.Controls.Add(Me.BtnAjouter)
        Me.Controls.Add(Me.TxtCode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAjouterBeneficiaire"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmAjouterBeneficiaire"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtCode As TextBox
    Friend WithEvents BtnAnnuler As Button
    Friend WithEvents BtnAjouter As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPrenom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtVille As TextBox
    Friend WithEvents DateNais As DateTimePicker
    Friend WithEvents Label5 As Label
End Class
