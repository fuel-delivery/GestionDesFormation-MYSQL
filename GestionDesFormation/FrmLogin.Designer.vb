<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtLogin = New System.Windows.Forms.TextBox()
        Me.BtnAnnuler = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(359, 342)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(85, 27)
        Me.BtnLogin.TabIndex = 0
        Me.BtnLogin.Text = "&Se Connecter"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtPassword)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtLogin)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(180, 132)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 202)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(115, 119)
        Me.TxtPassword.Multiline = True
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(180, 32)
        Me.TxtPassword.TabIndex = 5
        Me.TxtPassword.Text = "Fsmi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mot de passe :"
        '
        'TxtLogin
        '
        Me.TxtLogin.Location = New System.Drawing.Point(115, 52)
        Me.TxtLogin.Multiline = True
        Me.TxtLogin.Name = "TxtLogin"
        Me.TxtLogin.Size = New System.Drawing.Size(180, 32)
        Me.TxtLogin.TabIndex = 3
        Me.TxtLogin.Text = "user"
        '
        'BtnAnnuler
        '
        Me.BtnAnnuler.Location = New System.Drawing.Point(452, 342)
        Me.BtnAnnuler.Name = "BtnAnnuler"
        Me.BtnAnnuler.Size = New System.Drawing.Size(60, 27)
        Me.BtnAnnuler.TabIndex = 3
        Me.BtnAnnuler.Text = "&Annuler"
        Me.BtnAnnuler.UseVisualStyleBackColor = True
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 500)
        Me.Controls.Add(Me.BtnAnnuler)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnLogin)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLogin"
        Me.Text = "FrmLogin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtLogin As TextBox
    Friend WithEvents BtnAnnuler As Button
End Class
