<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGestionBeneficiaire
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGV_Beneficiaires = New System.Windows.Forms.DataGridView()
        Me.Col_CodeB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Prenom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Date_nais = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Ville = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnRechercher = New System.Windows.Forms.Button()
        Me.RdbTous = New System.Windows.Forms.RadioButton()
        Me.RdbVille = New System.Windows.Forms.RadioButton()
        Me.TxtRechercher = New System.Windows.Forms.TextBox()
        Me.RdbNom = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnImprimer = New System.Windows.Forms.Button()
        Me.BtnSupprimer = New System.Windows.Forms.Button()
        Me.BtnModifier = New System.Windows.Forms.Button()
        Me.BtnAjouter = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_Beneficiaires, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGV_Beneficiaires)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 113)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(589, 382)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Liste :"
        '
        'DGV_Beneficiaires
        '
        Me.DGV_Beneficiaires.AllowUserToAddRows = False
        Me.DGV_Beneficiaires.AllowUserToDeleteRows = False
        Me.DGV_Beneficiaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Beneficiaires.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_CodeB, Me.Col_Nom, Me.Col_Prenom, Me.Col_Date_nais, Me.Col_Ville})
        Me.DGV_Beneficiaires.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Beneficiaires.Location = New System.Drawing.Point(3, 16)
        Me.DGV_Beneficiaires.Name = "DGV_Beneficiaires"
        Me.DGV_Beneficiaires.ReadOnly = True
        Me.DGV_Beneficiaires.Size = New System.Drawing.Size(583, 363)
        Me.DGV_Beneficiaires.TabIndex = 0
        '
        'Col_CodeB
        '
        Me.Col_CodeB.HeaderText = "Code"
        Me.Col_CodeB.Name = "Col_CodeB"
        Me.Col_CodeB.ReadOnly = True
        '
        'Col_Nom
        '
        Me.Col_Nom.HeaderText = "Nom"
        Me.Col_Nom.Name = "Col_Nom"
        Me.Col_Nom.ReadOnly = True
        '
        'Col_Prenom
        '
        Me.Col_Prenom.HeaderText = "Prénom"
        Me.Col_Prenom.Name = "Col_Prenom"
        Me.Col_Prenom.ReadOnly = True
        '
        'Col_Date_nais
        '
        Me.Col_Date_nais.HeaderText = "Date Naissance"
        Me.Col_Date_nais.Name = "Col_Date_nais"
        Me.Col_Date_nais.ReadOnly = True
        '
        'Col_Ville
        '
        Me.Col_Ville.HeaderText = "Ville"
        Me.Col_Ville.Name = "Col_Ville"
        Me.Col_Ville.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnRechercher)
        Me.GroupBox3.Controls.Add(Me.RdbTous)
        Me.GroupBox3.Controls.Add(Me.RdbVille)
        Me.GroupBox3.Controls.Add(Me.TxtRechercher)
        Me.GroupBox3.Controls.Add(Me.RdbNom)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(710, 100)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rechercher par :"
        '
        'BtnRechercher
        '
        Me.BtnRechercher.Location = New System.Drawing.Point(573, 34)
        Me.BtnRechercher.Name = "BtnRechercher"
        Me.BtnRechercher.Size = New System.Drawing.Size(90, 33)
        Me.BtnRechercher.TabIndex = 0
        Me.BtnRechercher.Text = "Rechercher"
        Me.BtnRechercher.UseVisualStyleBackColor = True
        '
        'RdbTous
        '
        Me.RdbTous.AutoSize = True
        Me.RdbTous.Location = New System.Drawing.Point(47, 19)
        Me.RdbTous.Name = "RdbTous"
        Me.RdbTous.Size = New System.Drawing.Size(49, 17)
        Me.RdbTous.TabIndex = 1
        Me.RdbTous.TabStop = True
        Me.RdbTous.Text = "Tous"
        Me.RdbTous.UseVisualStyleBackColor = True
        '
        'RdbVille
        '
        Me.RdbVille.AutoSize = True
        Me.RdbVille.Location = New System.Drawing.Point(47, 65)
        Me.RdbVille.Name = "RdbVille"
        Me.RdbVille.Size = New System.Drawing.Size(44, 17)
        Me.RdbVille.TabIndex = 3
        Me.RdbVille.TabStop = True
        Me.RdbVille.Text = "Ville"
        Me.RdbVille.UseVisualStyleBackColor = True
        '
        'TxtRechercher
        '
        Me.TxtRechercher.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TxtRechercher.Location = New System.Drawing.Point(162, 35)
        Me.TxtRechercher.Multiline = True
        Me.TxtRechercher.Name = "TxtRechercher"
        Me.TxtRechercher.Size = New System.Drawing.Size(350, 30)
        Me.TxtRechercher.TabIndex = 4
        '
        'RdbNom
        '
        Me.RdbNom.AutoSize = True
        Me.RdbNom.Location = New System.Drawing.Point(47, 42)
        Me.RdbNom.Name = "RdbNom"
        Me.RdbNom.Size = New System.Drawing.Size(47, 17)
        Me.RdbNom.TabIndex = 2
        Me.RdbNom.TabStop = True
        Me.RdbNom.Text = "Nom"
        Me.RdbNom.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnImprimer)
        Me.GroupBox1.Controls.Add(Me.BtnSupprimer)
        Me.GroupBox1.Controls.Add(Me.BtnModifier)
        Me.GroupBox1.Controls.Add(Me.BtnAjouter)
        Me.GroupBox1.Location = New System.Drawing.Point(599, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(115, 327)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'BtnImprimer
        '
        Me.BtnImprimer.Location = New System.Drawing.Point(15, 154)
        Me.BtnImprimer.Name = "BtnImprimer"
        Me.BtnImprimer.Size = New System.Drawing.Size(84, 29)
        Me.BtnImprimer.TabIndex = 9
        Me.BtnImprimer.Text = "&Imprimer"
        Me.BtnImprimer.UseVisualStyleBackColor = True
        '
        'BtnSupprimer
        '
        Me.BtnSupprimer.Location = New System.Drawing.Point(15, 100)
        Me.BtnSupprimer.Name = "BtnSupprimer"
        Me.BtnSupprimer.Size = New System.Drawing.Size(84, 29)
        Me.BtnSupprimer.TabIndex = 8
        Me.BtnSupprimer.Text = "&Supprimer"
        Me.BtnSupprimer.UseVisualStyleBackColor = True
        '
        'BtnModifier
        '
        Me.BtnModifier.CausesValidation = False
        Me.BtnModifier.Location = New System.Drawing.Point(15, 65)
        Me.BtnModifier.Name = "BtnModifier"
        Me.BtnModifier.Size = New System.Drawing.Size(84, 29)
        Me.BtnModifier.TabIndex = 7
        Me.BtnModifier.Text = "&Modifier"
        Me.BtnModifier.UseVisualStyleBackColor = True
        '
        'BtnAjouter
        '
        Me.BtnAjouter.CausesValidation = False
        Me.BtnAjouter.Location = New System.Drawing.Point(15, 30)
        Me.BtnAjouter.Name = "BtnAjouter"
        Me.BtnAjouter.Size = New System.Drawing.Size(84, 29)
        Me.BtnAjouter.TabIndex = 6
        Me.BtnAjouter.TabStop = False
        Me.BtnAjouter.Text = "&Ajouter"
        Me.BtnAjouter.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        Me.BtnFermer.Location = New System.Drawing.Point(607, 453)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(96, 29)
        Me.BtnFermer.TabIndex = 11
        Me.BtnFermer.Text = "&Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'FrmGestionBeneficiaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnFermer)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGestionBeneficiaire"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV_Beneficiaires, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtRechercher As TextBox
    Friend WithEvents RdbNom As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnRechercher As Button
    Friend WithEvents RdbTous As RadioButton
    Friend WithEvents RdbVille As RadioButton
    Friend WithEvents DGV_Beneficiaires As DataGridView
    Friend WithEvents BtnFermer As Button
    Friend WithEvents BtnImprimer As Button
    Friend WithEvents Col_CodeB As DataGridViewTextBoxColumn
    Friend WithEvents Col_Nom As DataGridViewTextBoxColumn
    Friend WithEvents Col_Prenom As DataGridViewTextBoxColumn
    Friend WithEvents Col_Date_nais As DataGridViewTextBoxColumn
    Friend WithEvents Col_Ville As DataGridViewTextBoxColumn
    Friend WithEvents BtnAjouter As Button
    Friend WithEvents BtnModifier As Button
    Friend WithEvents BtnSupprimer As Button
End Class
