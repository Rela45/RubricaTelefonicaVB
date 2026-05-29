Imports System.IO
Imports System.Xml.Serialization
Imports DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing

Public Enum ModeSetting
    Testo
    Excel
    SQL
End Enum
Public Class Form2

    'Private mSettings As New SettingsData

    Private Sub btnForm2Save_Click(sender As Object, e As EventArgs) Handles btnForm2Save.Click

        Dim settings As New SettingsData

        settings.Fullscreen = chkFullScreen.Checked

        If cboModeSettings.SelectedIndex > 0 Then

            settings.SelectedMode = CType([Enum].Parse(GetType(ModeSetting), cboModeSettings.SelectedItem.ToString()), ModeSetting)

        Else

            settings.SelectedMode = Nothing

        End If

        Dim xs As New XmlSerializer(GetType(SettingsData))

        Using fs As New FileStream("Settings.xml", FileMode.Create)

            xs.Serialize(fs, settings)

        End Using
       MessageBox.Show("Attenzione: sto per riavviare l'applicativo","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Me.Close()

        Application.Restart()
    End Sub

    Private Sub btnForm2Annulla_Click(sender As Object, e As EventArgs) Handles btnForm2Annulla.Click
        Me.Close()
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cboModeSettings.Items.Clear()

        cboModeSettings.Items.Add("")

        For Each mode As ModeSetting In [Enum].GetValues(GetType(ModeSetting))

            cboModeSettings.Items.Add(mode.ToString())

        Next

        If File.Exists("Settings.xml") Then

            Dim xs As New XmlSerializer(GetType(SettingsData))

            Using fs As New FileStream("Settings.xml", FileMode.Open)

                Dim settings As SettingsData = CType(xs.Deserialize(fs), SettingsData)

                chkFullScreen.Checked = settings.Fullscreen

                If settings.SelectedMode.HasValue Then

                    cboModeSettings.SelectedItem = settings.SelectedMode.Value.ToString()

                Else

                    cboModeSettings.SelectedIndex = 0

                End If

            End Using

        End If
        'Dim valoreCbo As ModeSetting = mSettings.SelectedMode
        'If Not valoreCbo <> Nothing Then
        '    cboModeSettings.SelectedItem = valoreCbo
        'End If
        ''prima vedi quale elemento dell'enum è salvato nei sttaggi  
        ''in base all'elemento salvato nei settaggi vai a selezionarlo nella cbo
    End Sub
    Private Sub chkFullScreen_CheckedChanged(sender As Object, e As EventArgs) Handles chkFullScreen.CheckedChanged
        'Form1.Size = New Size
    End Sub

    Private Sub cboModeSettings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboModeSettings.SelectedIndexChanged

    End Sub
End Class

Public Class SettingsData
    Public Property Fullscreen As Boolean
    Public Property SelectedMode As ModeSetting?
End Class