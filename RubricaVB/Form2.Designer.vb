<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnForm2Save = New System.Windows.Forms.Button()
        Me.btnForm2Annulla = New System.Windows.Forms.Button()
        Me.chkFullScreen = New System.Windows.Forms.CheckBox()
        Me.cboModeSettings = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnForm2Save
        '
        Me.btnForm2Save.Location = New System.Drawing.Point(12, 235)
        Me.btnForm2Save.Name = "btnForm2Save"
        Me.btnForm2Save.Size = New System.Drawing.Size(119, 23)
        Me.btnForm2Save.TabIndex = 0
        Me.btnForm2Save.Text = "Salva"
        Me.btnForm2Save.UseVisualStyleBackColor = True
        '
        'btnForm2Annulla
        '
        Me.btnForm2Annulla.Location = New System.Drawing.Point(175, 235)
        Me.btnForm2Annulla.Name = "btnForm2Annulla"
        Me.btnForm2Annulla.Size = New System.Drawing.Size(110, 23)
        Me.btnForm2Annulla.TabIndex = 1
        Me.btnForm2Annulla.Text = "Annulla"
        Me.btnForm2Annulla.UseVisualStyleBackColor = True
        '
        'chkFullScreen
        '
        Me.chkFullScreen.AutoSize = True
        Me.chkFullScreen.Location = New System.Drawing.Point(175, 29)
        Me.chkFullScreen.Name = "chkFullScreen"
        Me.chkFullScreen.Size = New System.Drawing.Size(98, 17)
        Me.chkFullScreen.TabIndex = 2
        Me.chkFullScreen.Text = "Schermo Intero"
        Me.chkFullScreen.UseVisualStyleBackColor = True
        '
        'cboModeSettings
        '
        Me.cboModeSettings.FormattingEnabled = True
        Me.cboModeSettings.Location = New System.Drawing.Point(10, 29)
        Me.cboModeSettings.Name = "cboModeSettings"
        Me.cboModeSettings.Size = New System.Drawing.Size(121, 21)
        Me.cboModeSettings.TabIndex = 3
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 289)
        Me.Controls.Add(Me.cboModeSettings)
        Me.Controls.Add(Me.chkFullScreen)
        Me.Controls.Add(Me.btnForm2Annulla)
        Me.Controls.Add(Me.btnForm2Save)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnForm2Save As Button
    Friend WithEvents btnForm2Annulla As Button
    Friend WithEvents chkFullScreen As CheckBox
    Friend WithEvents cboModeSettings As ComboBox
End Class
