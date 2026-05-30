Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Runtime.Remoting.Lifetime
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Xml.Serialization
Imports System.Xml.Xsl
Imports ClosedXML.Excel
Imports DocumentFormat.OpenXml.Bibliography
Imports DocumentFormat.OpenXml.Drawing.Diagrams
Imports DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing
Imports DocumentFormat.OpenXml.Spreadsheet
Imports DocumentFormat.OpenXml.Wordprocessing
Imports Microsoft.VisualBasic.Logging



Public Class Form1
    Dim name As String = " "
    Dim surname As String = " "
    Dim mail As String = " "
    Dim cellularNumber As String = " "
    Dim id As Integer
    Dim selectedRowToModify As ListViewItem = Nothing
    Dim exePath As String = Application.StartupPath 'restituisce in string il path della cartella dell'eseguibile
    Dim open As New OpenFileDialog()
    Dim settings As SettingsData

    Dim selectedContactId As Integer

    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String

    'Private Sub GetUserInfo()
    '    Dim ctx As New ContextMenu
    '    Dim i1 As New MenuItem("Informazioni Utente")
    '    AddHandler i1.Click, AddressOf ContextMenuHandler
    '    ctx.MenuItems.Add(i1)
    '    Me.lvwRubricaTelefonica.ContextMenu = ctx
    'End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim xs As New XmlSerializer(GetType(SettingsData))
        Using fs As New FileStream("Settings.xml", FileMode.Open)

            settings = CType(xs.Deserialize(fs), SettingsData)

        End Using

        If settings.Fullscreen = True Then
            Me.WindowState = FormWindowState.Maximized
        End If

        If Not settings.SelectedMode.HasValue Then

            btnImport.Enabled = False
            btnExport.Enabled = False

        End If
        Rubrica_Load()



        Enable_Rubrica()
    End Sub


    ''' <summary>
    ''' Carica la rubrica importando la lista scelta dalle impostazioni
    ''' </summary>
    Private Sub Rubrica_Load()
#Region "testo"
        If settings.SelectedMode.HasValue AndAlso settings.SelectedMode.Value = ModeSetting.Testo Then

            Dim textPath As String = Path.Combine(exePath, "Rubrica.txt") 'combina la stringa del path dell'exe con quella da cercare
            If File.Exists(textPath) Then

                lvwRubricaTelefonica.Items.Clear()
                Using reader As New StreamReader(textPath) 'lettore 

                    While Not reader.EndOfStream

                        Dim line As String = reader.ReadLine()  'lettura della riga sul file di testo
                        Dim parts() As String = line.Split(";"c) 'divisione in parti della riga di testo, questo mi permette di gestire singolarmente i dati ed inserirli nelle giuste colonne
                        Dim item As New ListViewItem(parts(0)) 'inserimento nella lista 
                        For i As Integer = 1 To parts.Length - 1 'inserimento nella lista nelle colonne successive
                            If i = 4 Then
                                id = parts(i)
                            End If
                            item.SubItems.Add(parts(i))
                        Next

                        lvwRubricaTelefonica.Items.Add(item)

                    End While
                End Using
            Else
                MessageBox.Show("Warning", "Non è stato trovato alcun file Rubrica.txt", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
#End Region
#Region "excel"
        If settings.SelectedMode.HasValue AndAlso settings.SelectedMode.Value = ModeSetting.Excel Then

            Dim ExcelPath As String = Path.Combine(exePath, "Rubrica.xlsx")

            If File.Exists(ExcelPath) Then

                lvwRubricaTelefonica.Items.Clear()
                Using reader As New StreamReader("Rubrica.xlsx") 'lettore 
                    Dim wb As New XLWorkbook(ExcelPath)  'con questo prendo l'intero file excel
                    Dim ws = wb.Worksheet(1) 'con questo prendo in considerazione soltanto il primo foglio
                    For Each row In ws.RowsUsed().Skip(1)   'ciclo su tutte le righe tranne la prima
                        Dim item As New ListViewItem(
                            row.Cell(1).GetString())
                        item.SubItems.Add(row.Cell(2).GetString())
                        item.SubItems.Add(row.Cell(3).GetString())
                        item.SubItems.Add(row.Cell(4).GetString())
                        lvwRubricaTelefonica.Items.Add(item)
                    Next
                End Using
            Else
                MessageBox.Show("Warning", "Non è stato trovato alcun file Rubrica.xlsx", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
#End Region
#Region "SQL"
        If settings.SelectedMode.HasValue AndAlso settings.SelectedMode.Value = ModeSetting.SQL Then
            btnImport.Enabled = False
            btnExport.Enabled = False
            Try
                myConn = New SqlConnection("Initial Catalog=RubricaTelefonica;" &
                "Data Source=(localdb)\MSSQLLocalDB;Integrated Security=SSPI;")

                myCmd = myConn.CreateCommand
                myCmd.CommandText = "SELECT * FROM Contatti;"

                myConn.Open()

                myReader = myCmd.ExecuteReader()

                lvwRubricaTelefonica.Items.Clear()

                Do While myReader.Read()

                    Dim item As New ListViewItem(myReader("Nome").ToString())
                    item.SubItems.Add(myReader("Cognome").ToString())
                    item.SubItems.Add(myReader("Mail").ToString())
                    item.SubItems.Add(myReader("Cellulare").ToString())
                    item.SubItems.Add(myReader("id").ToString())
                    lvwRubricaTelefonica.Items.Add(item)
                    id += 1
                Loop
            Catch ex As Exception
                MessageBox.Show("Errore durante il caricamento dei dati", "Errore SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            myReader.Close()

            myConn.Close()
        End If
#End Region
    End Sub
    Private Sub Enable_Rubrica()
        lvwRubricaTelefonica.Enabled = True
        grpDetails.Enabled = False
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lvwRubricaTelefonica.Enabled = False
        grpDetails.Enabled = True

    End Sub

    Private Sub ClearTextBox()
        tbxName.Clear()
        tbxSurname.Clear()
        tbxMail.Clear()
        tbxCellNum.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        name = tbxName.Text
        surname = tbxSurname.Text
        mail = tbxMail.Text
        cellularNumber = tbxCellNum.Text
        If selectedRowToModify Is Nothing Then

            name = tbxName.Text
            surname = tbxSurname.Text
            mail = tbxMail.Text
            cellularNumber = tbxCellNum.Text

            If Not String.IsNullOrEmpty(name) AndAlso
            Not String.IsNullOrEmpty(mail) AndAlso
            Not String.IsNullOrEmpty(surname) AndAlso
            Not String.IsNullOrEmpty(cellularNumber) Then

                Dim singleRow As New ListViewItem(name)
                singleRow.SubItems.Add(surname)
                singleRow.SubItems.Add(mail)
                singleRow.SubItems.Add(cellularNumber)
                singleRow.SubItems.Add(id.ToString() + 1)
                id += 1

                lvwRubricaTelefonica.Items.Add(singleRow)



                Try
                    myConn = New SqlConnection("Initial Catalog=RubricaTelefonica;Data Source=(localdb)\MSSQLLocalDB;Integrated Security=SSPI;")
                    myCmd = myConn.CreateCommand()
                    myCmd.CommandText = "INSERT INTO Contatti (Nome, Cognome, Mail, Cellulare) VALUES (@Name, @Surname, @Mail, @Cellular)"
                    myCmd.Parameters.AddWithValue("@Name", name)
                    myCmd.Parameters.AddWithValue("@Surname", surname)
                    myCmd.Parameters.AddWithValue("@Mail", mail)
                    myCmd.Parameters.AddWithValue("@Cellular", cellularNumber)
                    myConn.Open()
                    myCmd.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Errore durante il salvataggio dei dati: " & ex.Message, "Errore SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    myConn?.Close()
                End Try
                ClearTextBox()

            Else

                MessageBox.Show("Completa tutti i campi")

            End If
        Else

            selectedRowToModify.Text = name
            selectedRowToModify.SubItems(1).Text = surname
            selectedRowToModify.SubItems(2).Text = mail
            selectedRowToModify.SubItems(3).Text = cellularNumber

            selectedRowToModify = Nothing
        End If

        Enable_Rubrica()

    End Sub

    Private Sub btnAnnulla_Click(sender As Object, e As EventArgs) Handles btnAnnulla.Click
        tbxName.Clear()
        tbxSurname.Clear()
        tbxMail.Clear()
        tbxCellNum.Clear()
        Enable_Rubrica()
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        If lvwRubricaTelefonica.SelectedItems.Count > 0 Then

            selectedRowToModify = lvwRubricaTelefonica.SelectedItems(0)
            tbxName.Text = selectedRowToModify.Text
            tbxSurname.Text = selectedRowToModify.SubItems(1).Text
            tbxMail.Text = selectedRowToModify.SubItems(2).Text
            tbxCellNum.Text = selectedRowToModify.SubItems(3).Text
            lvwRubricaTelefonica.Enabled = False
            grpDetails.Enabled = True

        Else
            MessageBox.Show("Devi selezionare almeno un campo")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lvwRubricaTelefonica.SelectedItems.Count > 0 Then

            Dim selectedRowToDelete As ListViewItem = lvwRubricaTelefonica.SelectedItems(0)
            lvwRubricaTelefonica.Items.Remove(selectedRowToDelete)

        Else
            MessageBox.Show("Devi selezionare almeno un campo nella rubrica")
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        Dim save As New SaveFileDialog() 'apre finestra popup windows che serve per salvare il file
        save.Filter = "File di testo|*.txt"
        If save.ShowDialog() = DialogResult.OK Then

            Using writer As New StreamWriter(save.FileName) 'avvenuto salvataggio del nome del file

                For Each item As ListViewItem In lvwRubricaTelefonica.Items 'scorrimento di ogni riga della lista

                    Dim riga As String = item.Text

                    For i As Integer = 1 To item.SubItems.Count - 1 'separazione tramite ; dei valori dati
                        riga &= " ; " & item.SubItems(i).Text
                    Next

                    writer.WriteLine(riga) 'scrittura sul file

                Next
            End Using
        End If

    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        '  If Form2.
        'ImportFromText() Then
        'End If

    End Sub
    Private Sub ImportFromText()
        open.Filter = "File di testo|*.txt|File Excel|*.xlsx|Tutti i file|*.*"   'filtro di ricerca dei file da selezionare

        If open.ShowDialog() = DialogResult.OK Then 'controllo scelta utente

            lvwRubricaTelefonica.Items.Clear()

            Using reader As New StreamReader(open.FileName)

                While Not reader.EndOfStream

                    Dim line As String = reader.ReadLine()  'lettura della riga sul file di testo
                    Dim parts() As String = line.Split(";"c) 'divisione in parti della riga di testo, questo mi permette di gestire singolarmente i dati ed inserirli nelle giuste colonne

                    Dim item As New ListViewItem(parts(0)) 'inserimento nella lista degli elementi

                    For i As Integer = 1 To parts.Length - 1 'inserimento nella lista nelle colonne successive
                        item.SubItems.Add(parts(i))
                    Next

                    lvwRubricaTelefonica.Items.Add(item)

                End While

            End Using

        End If
    End Sub

    Private Sub ImportFromExcel()
        If Form2.cboModeSettings.Text = "Excel" Then
            Dim ExcelPath As String = Path.Combine(exePath, "Rubrica.xlsx")

            If File.Exists(ExcelPath) Then

                lvwRubricaTelefonica.Items.Clear()
                Using reader As New StreamReader("Rubrica.xlsx") 'lettore 
                    Dim wb As New XLWorkbook(ExcelPath)  'con questo prendo l'intero file excel
                    Dim ws = wb.Worksheet(1) 'con questo prendo in considerazione soltanto il primo foglio
                    For Each row In ws.RowsUsed().Skip(1)   'ciclo su tutte le righe tranne la prima
                        Dim item As New ListViewItem(
                            row.Cell(1).GetString())
                        item.SubItems.Add(row.Cell(2).GetString())
                        item.SubItems.Add(row.Cell(3).GetString())
                        item.SubItems.Add(row.Cell(4).GetString())
                        lvwRubricaTelefonica.Items.Add(item)
                    Next
                End Using
            Else
                MessageBox.Show("Warning", "Non è stato trovato alcun file Rubrica.xlsx", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub ImpostazioniToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImpostazioniToolStripMenuItem.Click
        Form2.ShowDialog()
    End Sub

    Private Sub ApriFormUtenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApriFormUtenteToolStripMenuItem.Click
        If lvwRubricaTelefonica.SelectedItems.Count > 0 Then
            Dim item As ListViewItem = lvwRubricaTelefonica.SelectedItems(0)
            Dim idIndex As Integer = lvwRubricaTelefonica.Columns.IndexOf(columnID)
            selectedContactId = CInt(item.SubItems(idIndex).Text)
            Dim Form3 As New Form3()
            Form3.ContattoId = selectedContactId
            Form3.ShowDialog()
        Else
            MessageBox.Show("Devi selezionare almeno un utente", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    '======================FUNZIONANTE SOTTO =========================

    ''' <summary>
    ''' Permette l'apertura del menustrip solo se è selezionato un parametro della listview
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    'Private Sub lvwRubricaTelefonica_MouseDown(sender As Object, e As MouseEventArgs) Handles lvwRubricaTelefonica.MouseDown
    '    If e.Button = MouseButtons.Right Then
    '        Dim item As ListViewItem = lvwRubricaTelefonica.GetItemAt(e.X, e.Y) 'prendo l'item sulla riga selezionata
    '        If item IsNot Nothing Then
    '            item.Selected = True
    '            Dim idIndex As Integer = lvwRubricaTelefonica.Columns.IndexOf(columnID)
    '            selectedContactId = CInt(item.SubItems(idIndex).Text)
    '            Dim Form3 As New Form3()
    '            Form3.ContattoId = selectedContactId
    '            Form3.ShowDialog()
    '        End If
    '    End If
    'End Sub


End Class
