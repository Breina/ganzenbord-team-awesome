'Kristof
'Gemaakt op: 12/05/2011 om 14.02u + om 22.42u aanpassingen gedaan
'Aangepast op: 18/05/2011 om 10.14u
'Nieuw spel 
Public Class NewGame

    Public lvl As String

    Private previousPlayerCount As Integer = 0
    Private playerLabels As List(Of Label) = New List(Of Label)             ' "Naam:" label
    Private playerTextBoxes As List(Of TextBox) = New List(Of TextBox)      ' Name
    Private playerButtons As List(Of Button) = New List(Of Button)          ' Player colour
    Private playerCheckBoxes As List(Of CheckBox) = New List(Of CheckBox)   ' For cpu

    Public Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        For i As Integer = 1 To previousPlayerCount
            Dim j As Integer = i - 1
            player.Add(New Players(playerTextBoxes(j).Text, playerButtons(j).BackColor, playerCheckBoxes(j).Checked))
        Next

        lvl = TxtLevel.Text
        Form1.InitialiseGame()

        Me.Hide()
        Form1.Show()
    End Sub

    Public Sub AdjustPlayers(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NudPlayerCount.ValueChanged
        If NudPlayerCount.Value > 6 Then
            NudPlayerCount.Value = 6
        ElseIf NudPlayerCount.Value < 2 Then
            NudPlayerCount.Value = 2
        End If

        Dim playerNum As Integer = CType(NudPlayerCount.Value, Integer) ' DirectCast can't convert Decimal to Integer
        PlayerBox.Height += (playerNum - previousPlayerCount) * 27
        Me.Height += (playerNum - previousPlayerCount) * 27

        If NudPlayerCount.Value > previousPlayerCount Then  ' If counted up

            Dim r As Random = New Random()
            For i As Integer = previousPlayerCount + 1 To playerNum

                playerLabels.Add(New Label)
                playerTextBoxes.Add(New TextBox)
                playerButtons.Add(New Button)
                playerCheckBoxes.Add(New CheckBox)

                Dim s As String = Convert.ToString(i)
                Dim j = i - 1

                playerLabels(j).Text = "Naam:"
                playerLabels(j).Name = "LblPlayer" & s
                playerLabels(j).Width = 40
                playerLabels(j).Location = New Point(6, 27 * i - 4)
                playerLabels(j).Visible = True

                playerTextBoxes(j).Text = "Speler " & s
                playerTextBoxes(j).Name = "TextBoxPlayer" & s
                playerTextBoxes(j).Location = New Point(50, 27 * i - 7)
                playerTextBoxes(j).TabIndex = 3 * i - 1
                playerTextBoxes(j).Visible = True

                playerButtons(j).Text = ""
                playerButtons(j).Name = "BtnPlayer" & s
                playerButtons(j).Size = New Size(20, 20)
                playerButtons(j).BackColor = Color.FromArgb(Convert.ToInt32(r.NextDouble * 127) + 128, _
                                                            Convert.ToInt32(r.NextDouble * 127) + 128, _
                                                            Convert.ToInt32(r.NextDouble * 127) + 128)      ' Range 128 to 256 to produce soft colours
                playerButtons(j).Location = New Point(156, 27 * i - 7)
                playerButtons(j).TabIndex = 3 * i
                playerButtons(j).Visible = True

                playerCheckBoxes(j).Text = "Computer"
                playerCheckBoxes(j).Name = "ChkBoxPlayer" & s
                playerCheckBoxes(j).Width = 73
                playerCheckBoxes(j).Location = New Point(182, 27 * i - 8)
                playerCheckBoxes(j).TabIndex = 3 * i + 1
                playerCheckBoxes(j).Visible = True

                s = Nothing

                PlayerBox.Controls.Add(playerLabels(j))
                PlayerBox.Controls.Add(playerTextBoxes(j))
                PlayerBox.Controls.Add(playerButtons(j))
                PlayerBox.Controls.Add(playerCheckBoxes(j))

                AddHandler playerButtons(j).Click, AddressOf PickColor
            Next
        Else
            For i As Integer = previousPlayerCount To playerNum + 1 Step -1
                Dim j = i - 1

                playerLabels(j).Dispose()
                playerTextBoxes(j).Dispose()
                playerButtons(j).Dispose()
                playerCheckBoxes(j).Dispose()

                playerLabels.RemoveAt(j)
                playerTextBoxes.RemoveAt(j)
                playerButtons.RemoveAt(j)
                playerCheckBoxes.RemoveAt(j)
            Next
        End If

        previousPlayerCount = playerNum
    End Sub

    Private Sub PickColor(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ColorDialog1.ShowDialog()
        DirectCast(sender, Button).BackColor = ColorDialog1.Color
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