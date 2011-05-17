﻿'Kristof
Public Class NewGame
    Private loaded As Boolean = False
    Private objCreatePlayer() As CreatePlayer
    Private checked As Boolean
    Public lvl As String
    Private filename As String
    Public Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        'creeer players
        Dim i As Int16
            player.Clear()
            For i = 0 To CType(nudPlayers.Value - 1, Int16)
                If objCreatePlayer(i).check.Checked Then
                    checked = True
                Else
                    checked = False
                End If
                player.Add(New Players(objCreatePlayer(i).tekst.Text, objCreatePlayer(i).btn.BackColor, checked, False, 0, False, False))
        Next
        lvl = TxtLevel.Text
            Me.Hide()
            Form1.Show()

    End Sub

    Public Sub playersAanpassen(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudPlayers.ValueChanged
        Dim i As Integer
        Do Until loaded = True
            For i = 0 To CType(nudPlayers.Maximum - 1, Int16)
                Dim txt As New TextBox
                Dim lbl As New Label
                Dim btn As New Button
                Dim check As New CheckBox
                Randomize()
                txt.Text = "Player " + (i + 1).ToString
                check.Text = "Computer"
                btn.BackColor = Color.FromArgb(CInt(Rnd() * 255), CInt(Rnd() * 255), CInt(Rnd() * 255), CInt(Rnd() * 255))
                ReDim Preserve objCreatePlayer(i)
                objCreatePlayer(i) = New CreatePlayer(txt, lbl, btn, i, check)
                Me.Controls.Add(objCreatePlayer(i).btn)
                Me.Controls.Add(objCreatePlayer(i).lbl)
                Me.Controls.Add(objCreatePlayer(i).tekst)
                Me.Controls.Add(objCreatePlayer(i).check)
                AddHandler objCreatePlayer(i).btn.Click, AddressOf pickColor
                AddHandler objCreatePlayer(i).check.CheckedChanged, AddressOf VeranderNaam
            Next
            loaded = True
        Loop
        For i = 0 To 5
            objCreatePlayer(i).lbl.Visible = False
            objCreatePlayer(i).tekst.Visible = False
            objCreatePlayer(i).btn.Visible = False
            objCreatePlayer(i).check.Visible = False
        Next
        For i = 0 To CType(nudPlayers.Value - 1, Int16)
            objCreatePlayer(i).lbl.Visible = True
            objCreatePlayer(i).tekst.Visible = True
            objCreatePlayer(i).btn.Visible = True
            objCreatePlayer(i).check.Visible = True
        Next
    End Sub
    Private Sub pickColor(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ColorDialog1.ShowDialog()
        Dim btnKleur As Button
        btnKleur = CType(sender, Button)
        btnKleur.BackColor = ColorDialog1.Color
        For i = 0 To 5
            If btnKleur.Bounds = objCreatePlayer(i).btn.Bounds Then
                objCreatePlayer(i).btn.BackColor = btnKleur.BackColor
            End If
        Next
    End Sub
    Private Sub VeranderNaam(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim checker As CheckBox
        Dim computplayer As Integer = 1
        checker = CType(sender, CheckBox)
        For i = 0 To CType(nudPlayers.Value - 1, Int16)
            If objCreatePlayer(i).check.Checked Then
                objCreatePlayer(i).tekst.Text = "ComputerPlayer" + computplayer.ToString
                computplayer += 1
            End If
        Next
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Form1.Show()
    End Sub
    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
   
        Openlvl.InitialDirectory = "\levels"
        Openlvl.Title = "Open a Text File"
        Openlvl.Filter = "Text files (*.txt)|*.txt|" & "All files|*.*"
        Openlvl.ShowDialog()
        Openlvl.Multiselect = False

        Dim c As Char
        Dim s As String
        Dim i As Integer
        s = ""
        i = 0

        Do
            s = c + s
            i += 1
            c = Convert.ToChar(Openlvl.FileName.Substring(Openlvl.FileName.Length - i, 1))
        Loop Until c = "\"
        c = Nothing
        i = Nothing

        TxtLevel.Text = s
        s = Nothing
    End Sub
End Class