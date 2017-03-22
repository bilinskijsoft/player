Imports VkNet

Public Class Form1
    Dim Vars As New Vars
    Dim BassLib As New BassLib
    Dim BassLibForComercial As New BassLib
    Dim Automation As New Automation

    Private Sub btnAddFile_Click(sender As Object, e As EventArgs) Handles btnAddFile.Click
        dlgFile.ShowDialog()
    End Sub

    Private Sub dlgFile_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dlgFile.FileOk
        If TabControl1.SelectedIndex = 0 Then
            For Each Element In dlgFile.FileNames
                Vars.Files.Add(Element)
                lbPlaylist.Items.Add(Vars.GetFileName(Element))
            Next
        Else
            For Each Element In dlgFile.FileNames
                Vars.ComercialFiles.Add(Element)
                lbCommercial.Items.Add(Vars.GetFileName(Element))
                lbCommercial.SelectedIndex = 0
            Next
        End If
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click

        If lbPlaylist.Items.Count > 0 And lbPlaylist.SelectedIndex >= 0 Then
            ProgressBar1.Visible = False
            Dim current As String = Vars.Files(lbPlaylist.SelectedIndex)
            Dim spl = current.Split("//")
            If spl.Count > 1 Then
                spl = current.Split("?")
                current = spl(0)
                BassLib.Play_URL(current, BassLib.Volume)
            Else
                BassLib.Play_Stream(current, BassLib.Volume)
            End If

            lblPos.Text = TimeSpan.FromSeconds(BassLib.GetPosOfStream(BassLib.Stream)).ToString
            lblTime.Text = TimeSpan.FromSeconds(BassLib.GetTimeOfStrem(BassLib.Stream)).ToString
            slTime.Maximum = BassLib.GetTimeOfStrem(BassLib.Stream)
            slTime.Value = BassLib.GetPosOfStream(BassLib.Stream)
            Timer1.Enabled = True
            Automation.CommercialPlayed = False
            Automation.CurrentTrackNum = lbPlaylist.SelectedIndex
        End If
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        BassLib.Stop_Stream()
        Timer1.Enabled = False
        slTime.Value = 0
        lblPos.Text = "00:00:00"
        lblTime.Text = "00:00:00"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblPos.Text = TimeSpan.FromSeconds(BassLib.GetPosOfStream(BassLib.Stream)).ToString
        slTime.Value = BassLib.GetPosOfStream(BassLib.Stream)
        If BassLib.GetDownloadProgress(BassLib.Stream) > 0 Then
            ProgressBar1.Value = BassLib.GetDownloadProgress(BassLib.Stream)
        End If

        If Automation.PlayingCommercial Then
            Label2.Text = "Програвання реклами"
            If BassLib.GetTimeOfStrem(BassLib.Stream) = BassLib.GetPosOfStream(BassLib.Stream) Then
                Dim current As String = Vars.Files(lbPlaylist.SelectedIndex)
                BassLib.Play_Stream(current, BassLib.Volume)
                lblPos.Text = TimeSpan.FromSeconds(BassLib.GetPosOfStream(BassLib.Stream)).ToString
                lblTime.Text = TimeSpan.FromSeconds(BassLib.GetTimeOfStrem(BassLib.Stream)).ToString
                slTime.Maximum = BassLib.GetTimeOfStrem(BassLib.Stream)
                slTime.Value = BassLib.GetPosOfStream(BassLib.Stream)
                If lbCommercial.SelectedIndex <> lbCommercial.Items.Count - 1 Then
                    lbCommercial.SelectedIndex = lbCommercial.SelectedIndex + 1
                Else
                    lbCommercial.SelectedIndex = 0
                End If
                Automation.PlayingCommercial = False
            End If
        Else
            Label2.Text = ""
            If BassLib.GetTimeOfStrem(BassLib.Stream) = BassLib.GetPosOfStream(BassLib.Stream) Then
                If Automation.CurrentTrackNum < lbPlaylist.Items.Count - 1 Then
                    Automation.CurrentTrackNum = Automation.CurrentTrackNum + 1
                    lbPlaylist.SelectedIndex = Automation.CurrentTrackNum
                    lbPlaylist_MouseDoubleClick(Nothing, Nothing)
                Else
                    Automation.CurrentTrackNum = -1
                End If
            End If

            If Automation.NeedToPlayCommercial Then
                Automation.CommercialPlayed = True
                BassLib.Stop_Stream()
                Dim current As String = Vars.ComercialFiles(lbCommercial.SelectedIndex)
                BassLib.Play_Stream(current, BassLib.Volume)
                lblPos.Text = TimeSpan.FromSeconds(BassLib.GetPosOfStream(BassLib.Stream)).ToString
                lblTime.Text = TimeSpan.FromSeconds(BassLib.GetTimeOfStrem(BassLib.Stream)).ToString
                slTime.Maximum = BassLib.GetTimeOfStrem(BassLib.Stream)
                slTime.Value = BassLib.GetPosOfStream(BassLib.Stream)
                Automation.PlayingCommercial = True
            End If
        End If
    End Sub

    Private Sub slTime_Scroll(sender As Object, e As EventArgs) Handles slTime.Scroll
        BassLib.SetPosOfScroll(BassLib.Stream, slTime.Value)
    End Sub

    Private Sub trkVolume_Scroll(sender As Object, e As EventArgs) Handles trkVolume.Scroll
        BassLib.SetVolumeToStream(BassLib.Stream, trkVolume.Value)
    End Sub


    Private Sub lbPlaylist_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lbPlaylist.MouseDoubleClick
        btnPlay_Click(Nothing, Nothing)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BassLib.Pause_Stream()
    End Sub

    Private Sub lstVk_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        btnPlay_Click(Nothing, Nothing)
    End Sub

    Private Sub lstVkS_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        btnPlay_Click(Nothing, Nothing)
    End Sub

    Private Sub btnAddCommercial_Click(sender As Object, e As EventArgs) Handles btnAddCommercial.Click
        dlgFile.ShowDialog()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Automation.CommercialInterval = ComboBox1.SelectedItem
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Vars.Files.Remove(Vars.Files(lbPlaylist.SelectedIndex))
        lbPlaylist.Items.Remove(lbPlaylist.SelectedItem)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Vars.ComercialFiles.Remove(Vars.Files(lbCommercial.SelectedIndex))
        lbCommercial.Items.Remove(lbCommercial.SelectedItem)
    End Sub
End Class
