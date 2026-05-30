<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grpDetails = New System.Windows.Forms.GroupBox()
        Me.tbxCAP = New System.Windows.Forms.TextBox()
        Me.tbxCivicNumber = New System.Windows.Forms.TextBox()
        Me.tbxCity = New System.Windows.Forms.TextBox()
        Me.tbxAddress = New System.Windows.Forms.TextBox()
        Me.lblCap = New System.Windows.Forms.Label()
        Me.lblCivico = New System.Windows.Forms.Label()
        Me.lblIndirizzo = New System.Windows.Forms.Label()
        Me.lblCitta = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAnnulla = New System.Windows.Forms.Button()
        Me.lvwAbitazioni = New System.Windows.Forms.ListView()
        Me.columnContattoID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnCittà = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnIndirizzo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnCivico = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnCAP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grpDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(802, 116)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "Elimina"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModify.Location = New System.Drawing.Point(802, 77)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(75, 23)
        Me.btnModify.TabIndex = 17
        Me.btnModify.Text = "Modifica"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(802, 35)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Aggiungi"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'grpDetails
        '
        Me.grpDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDetails.Controls.Add(Me.tbxCAP)
        Me.grpDetails.Controls.Add(Me.tbxCivicNumber)
        Me.grpDetails.Controls.Add(Me.tbxCity)
        Me.grpDetails.Controls.Add(Me.tbxAddress)
        Me.grpDetails.Controls.Add(Me.lblCap)
        Me.grpDetails.Controls.Add(Me.lblCivico)
        Me.grpDetails.Controls.Add(Me.lblIndirizzo)
        Me.grpDetails.Controls.Add(Me.lblCitta)
        Me.grpDetails.Controls.Add(Me.btnSave)
        Me.grpDetails.Controls.Add(Me.btnAnnulla)
        Me.grpDetails.Location = New System.Drawing.Point(67, 394)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(809, 173)
        Me.grpDetails.TabIndex = 14
        Me.grpDetails.TabStop = False
        Me.grpDetails.Text = "Dettagli"
        '
        'tbxCAP
        '
        Me.tbxCAP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxCAP.Location = New System.Drawing.Point(455, 107)
        Me.tbxCAP.Name = "tbxCAP"
        Me.tbxCAP.Size = New System.Drawing.Size(339, 20)
        Me.tbxCAP.TabIndex = 4
        '
        'tbxCivicNumber
        '
        Me.tbxCivicNumber.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxCivicNumber.Location = New System.Drawing.Point(20, 107)
        Me.tbxCivicNumber.Name = "tbxCivicNumber"
        Me.tbxCivicNumber.Size = New System.Drawing.Size(414, 20)
        Me.tbxCivicNumber.TabIndex = 3
        '
        'tbxCity
        '
        Me.tbxCity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxCity.Location = New System.Drawing.Point(20, 51)
        Me.tbxCity.Name = "tbxCity"
        Me.tbxCity.Size = New System.Drawing.Size(414, 20)
        Me.tbxCity.TabIndex = 1
        '
        'tbxAddress
        '
        Me.tbxAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxAddress.Location = New System.Drawing.Point(455, 51)
        Me.tbxAddress.Name = "tbxAddress"
        Me.tbxAddress.Size = New System.Drawing.Size(339, 20)
        Me.tbxAddress.TabIndex = 2
        '
        'lblCap
        '
        Me.lblCap.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCap.AutoSize = True
        Me.lblCap.Location = New System.Drawing.Point(452, 91)
        Me.lblCap.Name = "lblCap"
        Me.lblCap.Size = New System.Drawing.Size(28, 13)
        Me.lblCap.TabIndex = 14
        Me.lblCap.Text = "CAP"
        '
        'lblCivico
        '
        Me.lblCivico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCivico.AutoSize = True
        Me.lblCivico.Location = New System.Drawing.Point(17, 91)
        Me.lblCivico.Name = "lblCivico"
        Me.lblCivico.Size = New System.Drawing.Size(36, 13)
        Me.lblCivico.TabIndex = 12
        Me.lblCivico.Text = "Civico"
        '
        'lblIndirizzo
        '
        Me.lblIndirizzo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIndirizzo.AutoSize = True
        Me.lblIndirizzo.Location = New System.Drawing.Point(452, 35)
        Me.lblIndirizzo.Name = "lblIndirizzo"
        Me.lblIndirizzo.Size = New System.Drawing.Size(45, 13)
        Me.lblIndirizzo.TabIndex = 13
        Me.lblIndirizzo.Text = "Indirizzo"
        '
        'lblCitta
        '
        Me.lblCitta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCitta.AutoSize = True
        Me.lblCitta.Location = New System.Drawing.Point(17, 35)
        Me.lblCitta.Name = "lblCitta"
        Me.lblCitta.Size = New System.Drawing.Size(28, 13)
        Me.lblCitta.TabIndex = 11
        Me.lblCitta.Text = "Città"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(612, 133)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Salva"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAnnulla
        '
        Me.btnAnnulla.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnnulla.Location = New System.Drawing.Point(719, 133)
        Me.btnAnnulla.Name = "btnAnnulla"
        Me.btnAnnulla.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnulla.TabIndex = 6
        Me.btnAnnulla.Text = "Annulla"
        Me.btnAnnulla.UseVisualStyleBackColor = True
        '
        'lvwAbitazioni
        '
        Me.lvwAbitazioni.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwAbitazioni.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnContattoID, Me.columnCittà, Me.columnIndirizzo, Me.columnCivico, Me.columnCAP})
        Me.lvwAbitazioni.FullRowSelect = True
        Me.lvwAbitazioni.HideSelection = False
        Me.lvwAbitazioni.Location = New System.Drawing.Point(67, 35)
        Me.lvwAbitazioni.Name = "lvwAbitazioni"
        Me.lvwAbitazioni.Size = New System.Drawing.Size(709, 342)
        Me.lvwAbitazioni.TabIndex = 15
        Me.lvwAbitazioni.UseCompatibleStateImageBehavior = False
        Me.lvwAbitazioni.View = System.Windows.Forms.View.Details
        '
        'columnContattoID
        '
        Me.columnContattoID.Text = "ContattoID"
        Me.columnContattoID.Width = 120
        '
        'columnCittà
        '
        Me.columnCittà.Text = "Città"
        Me.columnCittà.Width = 120
        '
        'columnIndirizzo
        '
        Me.columnIndirizzo.Text = "Indirizzo"
        Me.columnIndirizzo.Width = 120
        '
        'columnCivico
        '
        Me.columnCivico.Text = "Civico"
        Me.columnCivico.Width = 120
        '
        'columnCAP
        '
        Me.columnCAP.Text = "Cap"
        Me.columnCAP.Width = 120
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(785, 177)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 570)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.grpDetails)
        Me.Controls.Add(Me.lvwAbitazioni)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.grpDetails.ResumeLayout(False)
        Me.grpDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents btnDelete As Button
    Private WithEvents btnModify As Button
    Private WithEvents btnAdd As Button
    Private WithEvents grpDetails As GroupBox
    Private WithEvents tbxCAP As TextBox
    Private WithEvents tbxCivicNumber As TextBox
    Private WithEvents tbxCity As TextBox
    Private WithEvents tbxAddress As TextBox
    Private WithEvents lblCap As Label
    Private WithEvents lblCivico As Label
    Private WithEvents lblIndirizzo As Label
    Private WithEvents lblCitta As Label
    Private WithEvents btnSave As Button
    Private WithEvents btnAnnulla As Button
    Private WithEvents lvwAbitazioni As ListView
    Private WithEvents columnContattoID As ColumnHeader
    Private WithEvents columnCittà As ColumnHeader
    Private WithEvents columnIndirizzo As ColumnHeader
    Private WithEvents columnCivico As ColumnHeader
    Private WithEvents columnCAP As ColumnHeader
    Friend WithEvents Button1 As Button
End Class
