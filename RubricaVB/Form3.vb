Imports System.Data.SqlClient
Imports System.Net
Imports DocumentFormat.OpenXml.Office.Word
Imports DocumentFormat.OpenXml.Office2010.Excel
Imports DocumentFormat.OpenXml.Wordprocessing

Public Class Form3
    Public Property ContattoId As Integer
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Dim city As String
    Dim address As String
    Dim CivicNumber As String
    Dim CAP As String

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show(ContattoId.ToString())
        LoadUserData(ContattoId)
        lvwAbitazioni.Enabled = True
        grpDetails.Enabled = False
    End Sub

    Private Sub LoadUserData(ContattoId)
        Try
            myConn = New SqlConnection("Initial Catalog=RubricaTelefonica;" & "Data Source=(localdb)\MSSQLLocalDB;Integrated Security=SSPI;")
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT ContattoId, Città, Indirizzo, Civico, CAP
                             FROM Contatti
                             INNER JOIN Abitazioni ON Contatti.id = Abitazioni.ContattoId
                             WHERE Contatti.id = @id"
            myCmd.Parameters.AddWithValue("@id", ContattoId)
            myConn.Open()
            myReader = myCmd.ExecuteReader()
            lvwAbitazioni.Items.Clear()
            Do While myReader.Read()
                Dim item As New ListViewItem(myReader("ContattoId").ToString())
                item.SubItems.Add(myReader("Città").ToString())
                item.SubItems.Add(myReader("Indirizzo").ToString())
                item.SubItems.Add(myReader("Civico").ToString())
                item.SubItems.Add(myReader("CAP").ToString())
                lvwAbitazioni.Items.Add(item)
            Loop
        Catch ex As Exception
            MessageBox.Show("Errore durante il caricamento dei dati", "Errore SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            myReader?.Close()
            myConn?.Close()
        End Try
    End Sub

    Private Sub clearFields()
        tbxCity.Clear()
        tbxAddress.Clear()
        tbxCivicNumber.Clear()
        tbxCAP.Clear()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        grpDetails.Enabled = True
        lvwAbitazioni.Enabled = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        city = tbxCity.Text
        address = tbxAddress.Text
        CivicNumber = tbxCivicNumber.Text
        CAP = tbxCAP.Text

        If String.IsNullOrWhiteSpace(city) OrElse String.IsNullOrWhiteSpace(address) OrElse String.IsNullOrWhiteSpace(CivicNumber) OrElse String.IsNullOrWhiteSpace(CAP) Then
            MessageBox.Show("Completa tutti i campi")
            Return
        End If

        ' Aggiungo alla ListView (prima colonna: ContattoId come nel caricamento)
        Dim singleRow As New ListViewItem(ContattoId.ToString())
        singleRow.SubItems.Add(city)
        singleRow.SubItems.Add(address)
        singleRow.SubItems.Add(CivicNumber)
        singleRow.SubItems.Add(CAP)
        lvwAbitazioni.Items.Add(singleRow)

        clearFields()
        grpDetails.Enabled = False
        lvwAbitazioni.Enabled = True

        ' Inserimento nel DB
        Try
            myConn = New SqlConnection("Initial Catalog=RubricaTelefonica;Data Source=(localdb)\MSSQLLocalDB;Integrated Security=SSPI;")
            myCmd = myConn.CreateCommand()
            myCmd.CommandText = "INSERT INTO Abitazioni (ContattoId, Città, Indirizzo, Civico, CAP) VALUES (@ContattoId, @Città, @Indirizzo, @Civico, @CAP)"
            myCmd.Parameters.AddWithValue("@ContattoId", ContattoId)
            myCmd.Parameters.AddWithValue("@Città", city)
            myCmd.Parameters.AddWithValue("@Indirizzo", address)
            myCmd.Parameters.AddWithValue("@Civico", CivicNumber)
            myCmd.Parameters.AddWithValue("@CAP", CAP)
            myConn.Open()
            myCmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Errore durante il salvataggio dei dati: " & ex.Message, "Errore SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            myConn?.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        grpDetails.Enabled = True
        lvwAbitazioni.Enabled = False
    End Sub
End Class