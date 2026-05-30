<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grpDetails = New System.Windows.Forms.GroupBox()
        Me.tbxCellNum = New System.Windows.Forms.TextBox()
        Me.tbxName = New System.Windows.Forms.TextBox()
        Me.tbxMail = New System.Windows.Forms.TextBox()
        Me.tbxSurname = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAnnulla = New System.Windows.Forms.Button()
        Me.lvwRubricaTelefonica = New System.Windows.Forms.ListView()
        Me.columnName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnSurname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnMail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnTelNum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStripOpenForm = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ApriFormUtenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpostazioniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpDetails.SuspendLayout()
        Me.MenuStripOpenForm.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(761, 111)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Elimina"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModify.Location = New System.Drawing.Point(761, 72)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(75, 23)
        Me.btnModify.TabIndex = 8
        Me.btnModify.Text = "Modifica"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(761, 30)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Aggiungi"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'grpDetails
        '
        Me.grpDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDetails.Controls.Add(Me.tbxCellNum)
        Me.grpDetails.Controls.Add(Me.tbxName)
        Me.grpDetails.Controls.Add(Me.tbxMail)
        Me.grpDetails.Controls.Add(Me.tbxSurname)
        Me.grpDetails.Controls.Add(Me.label4)
        Me.grpDetails.Controls.Add(Me.label2)
        Me.grpDetails.Controls.Add(Me.label3)
        Me.grpDetails.Controls.Add(Me.label1)
        Me.grpDetails.Controls.Add(Me.btnSave)
        Me.grpDetails.Controls.Add(Me.btnAnnulla)
        Me.grpDetails.Location = New System.Drawing.Point(26, 389)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(809, 173)
        Me.grpDetails.TabIndex = 2
        Me.grpDetails.TabStop = False
        Me.grpDetails.Text = "Dettagli"
        '
        'tbxCellNum
        '
        Me.tbxCellNum.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxCellNum.Location = New System.Drawing.Point(455, 107)
        Me.tbxCellNum.Name = "tbxCellNum"
        Me.tbxCellNum.Size = New System.Drawing.Size(339, 20)
        Me.tbxCellNum.TabIndex = 4
        '
        'tbxName
        '
        Me.tbxName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxName.Location = New System.Drawing.Point(20, 51)
        Me.tbxName.Name = "tbxName"
        Me.tbxName.Size = New System.Drawing.Size(414, 20)
        Me.tbxName.TabIndex = 1
        '
        'tbxMail
        '
        Me.tbxMail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxMail.Location = New System.Drawing.Point(20, 107)
        Me.tbxMail.Name = "tbxMail"
        Me.tbxMail.Size = New System.Drawing.Size(414, 20)
        Me.tbxMail.TabIndex = 3
        '
        'tbxSurname
        '
        Me.tbxSurname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxSurname.Location = New System.Drawing.Point(455, 51)
        Me.tbxSurname.Name = "tbxSurname"
        Me.tbxSurname.Size = New System.Drawing.Size(339, 20)
        Me.tbxSurname.TabIndex = 2
        '
        'label4
        '
        Me.label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(452, 91)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(68, 13)
        Me.label4.TabIndex = 14
        Me.label4.Text = "N.Telefonico"
        '
        'label2
        '
        Me.label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(17, 91)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(26, 13)
        Me.label2.TabIndex = 12
        Me.label2.Text = "Mail"
        '
        'label3
        '
        Me.label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(452, 35)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(52, 13)
        Me.label3.TabIndex = 13
        Me.label3.Text = "Cognome"
        '
        'label1
        '
        Me.label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(17, 35)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(35, 13)
        Me.label1.TabIndex = 11
        Me.label1.Text = "Nome"
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
        'lvwRubricaTelefonica
        '
        Me.lvwRubricaTelefonica.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwRubricaTelefonica.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnName, Me.columnSurname, Me.columnMail, Me.columnTelNum, Me.columnID})
        Me.lvwRubricaTelefonica.ContextMenuStrip = Me.MenuStripOpenForm
        Me.lvwRubricaTelefonica.FullRowSelect = True
        Me.lvwRubricaTelefonica.HideSelection = False
        Me.lvwRubricaTelefonica.Location = New System.Drawing.Point(26, 30)
        Me.lvwRubricaTelefonica.Name = "lvwRubricaTelefonica"
        Me.lvwRubricaTelefonica.Size = New System.Drawing.Size(709, 342)
        Me.lvwRubricaTelefonica.TabIndex = 5
        Me.lvwRubricaTelefonica.UseCompatibleStateImageBehavior = False
        Me.lvwRubricaTelefonica.View = System.Windows.Forms.View.Details
        '
        'columnName
        '
        Me.columnName.Text = "Nome"
        Me.columnName.Width = 120
        '
        'columnSurname
        '
        Me.columnSurname.Text = "Cognome"
        Me.columnSurname.Width = 120
        '
        'columnMail
        '
        Me.columnMail.Text = "Mail"
        Me.columnMail.Width = 120
        '
        'columnTelNum
        '
        Me.columnTelNum.Text = "N.Telefono"
        Me.columnTelNum.Width = 120
        '
        'columnID
        '
        Me.columnID.Text = "Chiave"
        Me.columnID.Width = 120
        '
        'MenuStripOpenForm
        '
        Me.MenuStripOpenForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApriFormUtenteToolStripMenuItem})
        Me.MenuStripOpenForm.Name = "ContextMenuStrip1"
        Me.MenuStripOpenForm.Size = New System.Drawing.Size(166, 26)
        '
        'ApriFormUtenteToolStripMenuItem
        '
        Me.ApriFormUtenteToolStripMenuItem.Name = "ApriFormUtenteToolStripMenuItem"
        Me.ApriFormUtenteToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ApriFormUtenteToolStripMenuItem.Text = "Apri Form Utente"
        '
        'btnExport
        '
        Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExport.Location = New System.Drawing.Point(760, 212)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 10
        Me.btnExport.Text = "Esporta"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImport.Location = New System.Drawing.Point(761, 170)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(75, 23)
        Me.btnImport.TabIndex = 11
        Me.btnImport.Text = "Importa"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(13, -1)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(45, 24)
        Me.MenuStrip2.TabIndex = 13
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImpostazioniToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ImpostazioniToolStripMenuItem
        '
        Me.ImpostazioniToolStripMenuItem.Name = "ImpostazioniToolStripMenuItem"
        Me.ImpostazioniToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ImpostazioniToolStripMenuItem.Text = "Impostazioni"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 601)
        Me.ContextMenuStrip = Me.MenuStripOpenForm
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.grpDetails)
        Me.Controls.Add(Me.lvwRubricaTelefonica)
        Me.Controls.Add(Me.MenuStrip2)
        Me.name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Form1"
        Me.grpDetails.ResumeLayout(False)
        Me.grpDetails.PerformLayout()
        Me.MenuStripOpenForm.ResumeLayout(False)
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnDelete As Button
    Private WithEvents btnModify As Button
    Private WithEvents btnAdd As Button
    Private WithEvents grpDetails As GroupBox
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents tbxCellNum As TextBox
    Private WithEvents tbxSurname As TextBox
    Private WithEvents tbxMail As TextBox
    Private WithEvents tbxName As TextBox
    Private WithEvents btnSave As Button
    Private WithEvents btnAnnulla As Button
    Private WithEvents lvwRubricaTelefonica As ListView
    Private WithEvents columnName As ColumnHeader
    Private WithEvents columnSurname As ColumnHeader
    Private WithEvents columnMail As ColumnHeader
    Private WithEvents columnTelNum As ColumnHeader
    Private WithEvents columnID As ColumnHeader
    Private WithEvents btnExport As Button
    Private WithEvents btnImport As Button
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImpostazioniToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStripOpenForm As ContextMenuStrip
    Friend WithEvents ApriFormUtenteToolStripMenuItem As ToolStripMenuItem
End Class
