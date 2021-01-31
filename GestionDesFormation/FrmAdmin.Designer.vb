<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAdmin
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblGestionBeneficiaire = New System.Windows.Forms.Label()
        Me.LblGestionFormation = New System.Windows.Forms.Label()
        Me.LblFermer = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(204, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Administration"
        '
        'LblGestionBeneficiaire
        '
        Me.LblGestionBeneficiaire.AutoSize = True
        Me.LblGestionBeneficiaire.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGestionBeneficiaire.Location = New System.Drawing.Point(272, 220)
        Me.LblGestionBeneficiaire.Name = "LblGestionBeneficiaire"
        Me.LblGestionBeneficiaire.Size = New System.Drawing.Size(176, 19)
        Me.LblGestionBeneficiaire.TabIndex = 1
        Me.LblGestionBeneficiaire.Text = "&Gestion Des Beneficiaires"
        '
        'LblGestionFormation
        '
        Me.LblGestionFormation.AutoSize = True
        Me.LblGestionFormation.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGestionFormation.Location = New System.Drawing.Point(281, 279)
        Me.LblGestionFormation.Name = "LblGestionFormation"
        Me.LblGestionFormation.Size = New System.Drawing.Size(160, 19)
        Me.LblGestionFormation.TabIndex = 2
        Me.LblGestionFormation.Text = "&Gestion Des Formation"
        '
        'LblFermer
        '
        Me.LblFermer.AutoSize = True
        Me.LblFermer.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFermer.Location = New System.Drawing.Point(332, 332)
        Me.LblFermer.Name = "LblFermer"
        Me.LblFermer.Size = New System.Drawing.Size(55, 19)
        Me.LblFermer.TabIndex = 3
        Me.LblFermer.Text = "&Fermer"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(208, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 219)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu : "
        '
        'FrmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 500)
        Me.Controls.Add(Me.LblFermer)
        Me.Controls.Add(Me.LblGestionFormation)
        Me.Controls.Add(Me.LblGestionBeneficiaire)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAdmin"
        Me.Text = "Administration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LblGestionBeneficiaire As Label
    Friend WithEvents LblGestionFormation As Label
    Friend WithEvents LblFermer As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
