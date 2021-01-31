<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAjouterFormation
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCode = New System.Windows.Forms.TextBox()
        Me.BtnAnnuler = New System.Windows.Forms.Button()
        Me.BtnAjouter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(249, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nom :"
        '
        'TxtNom
        '
        Me.TxtNom.Location = New System.Drawing.Point(302, 236)
        Me.TxtNom.Multiline = True
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(236, 29)
        Me.TxtNom.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(182, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Code du Formation :"
        '
        'TxtCode
        '
        Me.TxtCode.Location = New System.Drawing.Point(302, 179)
        Me.TxtCode.Multiline = True
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.Size = New System.Drawing.Size(86, 29)
        Me.TxtCode.TabIndex = 1
        '
        'BtnAnnuler
        '
        Me.BtnAnnuler.Location = New System.Drawing.Point(455, 293)
        Me.BtnAnnuler.Name = "BtnAnnuler"
        Me.BtnAnnuler.Size = New System.Drawing.Size(84, 29)
        Me.BtnAnnuler.TabIndex = 4
        Me.BtnAnnuler.Text = "&Annuler"
        Me.BtnAnnuler.UseVisualStyleBackColor = True
        '
        'BtnAjouter
        '
        Me.BtnAjouter.Location = New System.Drawing.Point(365, 293)
        Me.BtnAjouter.Name = "BtnAjouter"
        Me.BtnAjouter.Size = New System.Drawing.Size(84, 29)
        Me.BtnAjouter.TabIndex = 3
        Me.BtnAjouter.Text = "&Ajouter"
        Me.BtnAjouter.UseVisualStyleBackColor = True
        '
        'FrmAjouterFormation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 500)
        Me.Controls.Add(Me.BtnAnnuler)
        Me.Controls.Add(Me.BtnAjouter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtCode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAjouterFormation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmAjouterFormation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCode As TextBox
    Friend WithEvents BtnAnnuler As Button
    Friend WithEvents BtnAjouter As Button
End Class
