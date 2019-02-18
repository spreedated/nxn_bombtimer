Imports System.ComponentModel

Public Class Frm_Main
    Private normal_window_size As New Size(431, 269)
    Private option_window_size As New Size(431, 493)
    Private Sub Frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .Text = Mod_AppProperties.AppName()
            .FormBorderStyle = FormBorderStyle.FixedSingle
            .ShowIcon = True
            .ShowInTaskbar = True
            .MaximizeBox = False
            .Size = normal_window_size
            .Icon = My.Resources.c4_icon_black
        End With
        ComboBox1.SelectedIndex = 1
        TrckBar_Volume.Value = My.Settings.Volume * 100
    End Sub

    Private Sub Btn_Start_Click(sender As Object, e As EventArgs) Handles Btn_Start.Click
        Dim i As Button = sender
        If i.Text.ToString.ToLower.Contains("rock") Then
            St_myState(True)
        Else
            St_myState(False)
        End If
    End Sub

    Private Sub Frm_Main_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Mod_Csgsi.StopCSGSI()
    End Sub

    Private Sub Btn_Options_Click(sender As Object, e As EventArgs) Handles Btn_Options.Click
        If sender.text.ToString.ToLower.Contains("»") Then
            Me.Size = option_window_size
            GroupBox1.Visible = True
            sender.text = sender.text.ToString.Replace("»", "«")
        Else
            Me.Size = normal_window_size
            GroupBox1.Visible = False
            sender.text = sender.text.ToString.Replace("«", "»")
        End If
    End Sub

#Region "Stylez"
    Private Sub St_myState(ByVal state As Boolean)
        If state Then
            GroupBox1.Visible = False
            Me.Size = normal_window_size
            Btn_Options.Enabled = False
            Btn_Licence.Enabled = False
            Btn_Start.Text = "&Stop"
            Btn_Options.Text = "&Options »"
            Debug.Print(listener.Running.ToString)
            Mod_Csgsi.StartCSGSI()
            Debug.Print(listener.Running.ToString)
            Mod_Csgsi.WatchDog.Interval = 50
            Mod_Csgsi.WatchDog.Start()
        Else
            Btn_Options.Enabled = True
            Btn_Licence.Enabled = True
            Btn_Start.Text = "&Rock 'n' Roll"
            Mod_Csgsi.StopCSGSI()
            ToolStripStatusLabel2.Text = "[+] Ready"
            Mod_Csgsi.WatchDog.Stop()
        End If
    End Sub
#End Region

#Region "Options - Timer"
    Private Sub Chk_custom_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_custom.CheckedChanged
        If sender.checked Then
            NumericUpDown1.Enabled = True
        Else
            NumericUpDown1.Enabled = False
        End If
    End Sub
#End Region


#Region "Auto-Listen"
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        With WatchCS
            .Interval = 1000
            If sender.checked = True Then
                .Enabled = True
                .Start()
            Else
                .Enabled = False
                .Stop()
            End If
        End With
    End Sub

    Private WithEvents WatchCS As New Timer
    Private Sub WatchCS_Tick() Handles WatchCS.Tick
        Dim i As Process() = Process.GetProcessesByName("csgo")
        Dim procArray As New ArrayList

        For Each item In i
            procArray.Add(item.Id & ":" & item.MainWindowTitle & ":" & item.SessionId & ":" & item.ProcessName)
        Next

        If procArray.Count >= 1 Then
            For Each item In procArray
                If item.ToString.ToLower.Contains("csgo") Then
                    If Btn_Start.Text.Contains("'n'") Then
                        Btn_Start.PerformClick()
                    End If
                End If
            Next
        Else
            If Btn_Start.Text.Contains("top") Then
                Btn_Start.PerformClick()
            End If
        End If
    End Sub
#End Region

    Private Sub Btn_Debug_Click(sender As Object, e As EventArgs) Handles Btn_Debug.Click

    End Sub
    Private Sub TrckBar_Volume_Scroll(sender As Object, e As EventArgs) Handles TrckBar_Volume.Scroll
        My.Settings.Volume = CSng(TrckBar_Volume.Value / 100)
        My.Settings.Save()
    End Sub

    Private Sub Btn_Preview_Click(sender As Object, e As EventArgs) Handles Btn_Preview.Click
        PlayPreview(ComboBox1.SelectedIndex)
    End Sub
End Class
