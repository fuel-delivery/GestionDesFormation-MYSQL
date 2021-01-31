<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSuivre
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnImprimer = New System.Windows.Forms.Button()
        Me.BtnSupprimer = New System.Windows.Forms.Button()
        Me.BtnModifier = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGV_Suivre = New System.Windows.Forms.DataGridView()
        Me.Col_CodeB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Libelle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_DateDebut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_DateFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnAjouter = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnAjouterFormation = New System.Windows.Forms.Button()
        Me.DateFinF = New System.Windows.Forms.DateTimePicker()
        Me.DateDebutF = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblFormation = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbFormation = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbBeneficiaire = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_Suivre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnImprimer)
        Me.GroupBox1.Controls.Add(Me.BtnSupprimer)
        Me.GroupBox1.Controls.Add(Me.BtnModifier)
        Me.GroupBox1.Location = New System.Drawing.Point(589, 173)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(127, 272)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'BtnImprimer
        '
        Me.BtnImprimer.Location = New System.Drawing.Point(21, 130)
        Me.BtnImprimer.Name = "BtnImprimer"
        Me.BtnImprimer.Size = New System.Drawing.Size(84, 29)
        Me.BtnImprimer.TabIndex = 10
        Me.BtnImprimer.Text = "&Imprimer"
        Me.BtnImprimer.UseVisualStyleBackColor = True
        '
        'BtnSupprimer
        '
        Me.BtnSupprimer.Location = New System.Drawing.Point(21, 76)
        Me.BtnSupprimer.Name = "BtnSupprimer"
        Me.BtnSupprimer.Size = New System.Drawing.Size(84, 29)
        Me.BtnSupprimer.TabIndex = 9
        Me.BtnSupprimer.Text = "&Supprimer"
        Me.BtnSupprimer.UseVisualStyleBackColor = True
        '
        'BtnModifier
        '
        Me.BtnModifier.Location = New System.Drawing.Point(21, 41)
        Me.BtnModifier.Name = "BtnModifier"
        Me.BtnModifier.Size = New System.Drawing.Size(84, 29)
        Me.BtnModifier.TabIndex = 8
        Me.BtnModifier.Text = "&Modifier"
        Me.BtnModifier.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        Me.BtnFermer.Location = New System.Drawing.Point(603, 452)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(96, 29)
        Me.BtnFermer.TabIndex = 11
        Me.BtnFermer.Text = "&Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGV_Suivre)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 173)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(578, 320)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Liste :"
        '
        'DGV_Suivre
        '
        Me.DGV_Suivre.AllowUserToAddRows = False
        Me.DGV_Suivre.AllowUserToDeleteRows = False
        Me.DGV_Suivre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Suivre.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_CodeB, Me.Col_Nom, Me.Col_Libelle, Me.Col_DateDebut, Me.Col_DateFin})
        Me.DGV_Suivre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Suivre.Location = New System.Drawing.Point(3, 16)
        Me.DGV_Suivre.Name = "DGV_Suivre"
        Me.DGV_Suivre.ReadOnly = True
        Me.DGV_Suivre.Size = New System.Drawing.Size(572, 301)
        Me.DGV_Suivre.TabIndex = 1
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
        'Col_Libelle
        '
        Me.Col_Libelle.HeaderText = "Formation"
        Me.Col_Libelle.Name = "Col_Libelle"
        Me.Col_Libelle.ReadOnly = True
        '
        'Col_DateDebut
        '
        Me.Col_DateDebut.HeaderText = "Date Debut"
        Me.Col_DateDebut.Name = "Col_DateDebut"
        Me.Col_DateDebut.ReadOnly = True
        '
        'Col_DateFin
        '
        Me.Col_DateFin.HeaderText = "Date Fin"
        Me.Col_DateFin.Name = "Col_DateFin"
        Me.Col_DateFin.ReadOnly = True
        '
        'BtnAjouter
        '
        Me.BtnAjouter.Location = New System.Drawing.Point(512, 110)
        Me.BtnAjouter.Name = "BtnAjouter"
        Me.BtnAjouter.Size = New System.Drawing.Size(84, 29)
        Me.BtnAjouter.TabIndex = 7
        Me.BtnAjouter.Text = "&Ajouter"
        Me.BtnAjouter.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnReset)
        Me.GroupBox3.Controls.Add(Me.BtnAjouterFormation)
        Me.GroupBox3.Controls.Add(Me.DateFinF)
        Me.GroupBox3.Controls.Add(Me.DateDebutF)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.BtnAjouter)
        Me.GroupBox3.Controls.Add(Me.LblFormation)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.CmbFormation)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.CmbBeneficiaire)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(711, 169)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(602, 112)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(65, 24)
        Me.BtnReset.TabIndex = 24
        Me.BtnReset.Text = "&Réinitialiser"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'BtnAjouterFormation
        '
        Me.BtnAjouterFormation.Location = New System.Drawing.Point(223, 70)
        Me.BtnAjouterFormation.Name = "BtnAjouterFormation"
        Me.BtnAjouterFormation.Size = New System.Drawing.Size(25, 22)
        Me.BtnAjouterFormation.TabIndex = 23
        Me.BtnAjouterFormation.Text = "..."
        Me.BtnAjouterFormation.UseVisualStyleBackColor = True
        '
        'DateFinF
        '
        Me.DateFinF.Location = New System.Drawing.Point(475, 71)
        Me.DateFinF.Name = "DateFinF"
        Me.DateFinF.Size = New System.Drawing.Size(200, 20)
        Me.DateFinF.TabIndex = 6
        '
        'DateDebutF
        '
        Me.DateDebutF.Location = New System.Drawing.Point(475, 29)
        Me.DateDebutF.Name = "DateDebutF"
        Me.DateDebutF.Size = New System.Drawing.Size(200, 20)
        Me.DateDebutF.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(406, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Date Fin :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(391, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Date Debut :"
        '
        'LblFormation
        '
        Me.LblFormation.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblFormation.Location = New System.Drawing.Point(147, 112)
        Me.LblFormation.Name = "LblFormation"
        Me.LblFormation.Size = New System.Drawing.Size(250, 25)
        Me.LblFormation.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(79, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Formation :"
        '
        'CmbFormation
        '
        Me.CmbFormation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFormation.FormattingEnabled = True
        Me.CmbFormation.Location = New System.Drawing.Point(147, 71)
        Me.CmbFormation.Name = "CmbFormation"
        Me.CmbFormation.Size = New System.Drawing.Size(69, 21)
        Me.CmbFormation.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Code du Formation :"
        '
        'CmbBeneficiaire
        '
        Me.CmbBeneficiaire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBeneficiaire.FormattingEnabled = True
        Me.CmbBeneficiaire.Location = New System.Drawing.Point(147, 29)
        Me.CmbBeneficiaire.Name = "CmbBeneficiaire"
        Me.CmbBeneficiaire.Size = New System.Drawing.Size(190, 21)
        Me.CmbBeneficiaire.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nom :"
        '
        'FrmSuivre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnFermer)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSuivre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV_Suivre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnFermer As Button
    Friend WithEvents BtnImprimer As Button
    Friend WithEvents BtnSupprimer As Button
    Friend WithEvents BtnModifier As Button
    Friend WithEvents BtnAjouter As Button
    Friend WithEvents DGV_Suivre As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DateFinF As DateTimePicker
    Friend WithEvents DateDebutF As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LblFormation As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CmbFormation As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbBeneficiaire As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnAjouterFormation As Button
    Friend WithEvents Col_CodeB As DataGridViewTextBoxColumn
    Friend WithEvents Col_Nom As DataGridViewTextBoxColumn
    Friend WithEvents Col_Libelle As DataGridViewTextBoxColumn
    Friend WithEvents Col_DateDebut As DataGridViewTextBoxColumn
    Friend WithEvents Col_DateFin As DataGridViewTextBoxColumn
    Friend WithEvents BtnReset As Button
End Class
