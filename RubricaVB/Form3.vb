Imports DocumentFormat.OpenXml.Office.Word
Imports DocumentFormat.OpenXml.Office2010.Excel
Imports DocumentFormat.OpenXml.Wordprocessing
Imports System.Data.SqlClient

Public Class Form3
    Public Property ContattoId
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show(ContattoId)
        LoadUserData(ContattoId)
        lvwAbitazioni.Enabled = True
        grpDetails.Enabled = False
    End Sub


    Private Sub LoadUserData(ContattoId)

        Try
            myConn = New SqlConnection("Initial Catalog=RubricaTelefonica;" & "Data Source=localhost;Integrated Security=SSPI;")
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
End Class