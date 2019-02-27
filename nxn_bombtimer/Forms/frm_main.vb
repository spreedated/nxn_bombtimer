Imports System.ComponentModel

Public Class Frm_Main
    Private normal_window_size As New Size(431, 269)
    Private option_window_size As New Size(431, 535)
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
        ComboBox1.SelectedIndex = My.Settings.UsingAnnouncer
        TrckBar_Volume.Value = My.Settings.Volume * 100

        With NotifyIcon1
            .Text = Mod_AppProperties.AppName()
            .Icon = My.Resources.c4_icon_white
            .ContextMenuStrip = ContextMenuStrip1
        End With

#If DEBUG Then
        Btn_Debug.Visible = True
        Btn_Debug1.Visible = True
#End If

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
        Mod_Csgsi.GameState.StopCSGSI()
        NotifyIcon1.Dispose()
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

    Private Sub Btn_Debug_Click(sender As Object, e As EventArgs) Handles Btn_Debug.Click
        Bombtimer.BombHasBeenPlanted = True
    End Sub
    Private Sub Btn_Debug1_Click(sender As Object, e As EventArgs) Handles Btn_Debug1.Click
        Bombtimer.BombHasBeenPlanted = False
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.Close()
    End Sub

#Region "Stylez"
    Private WithEvents InitializeBlockCSGSIstartButton As Timer = New Timer
    Private Sub InitializeBlockCSGSIstartButton_Tick() Handles InitializeBlockCSGSIstartButton.Tick
        Btn_Start.Enabled = True
        InitializeBlockCSGSIstartButton.Stop()
    End Sub

    Private Sub St_myState(ByVal state As Boolean)
        If state Then
            GroupBox1.Visible = False
            With Me
                .Size = normal_window_size
                .Hide()
                .ShowInTaskbar = False
            End With
            Btn_Options.Enabled = False
            Btn_Start.Text = "&Stop"
            Btn_Start.Enabled = False
            Btn_Options.Text = "&Options »"
            Mod_Csgsi.GameState.StartCSGSI()
            With InitializeBlockCSGSIstartButton
                .Enabled = True
                .Interval = 5000
                .Start()
            End With
        Else
            Btn_Options.Enabled = True
            Btn_Start.Text = "&Rock 'n' Roll"
            Mod_Csgsi.GameState.StopCSGSI()
            ToolStripStatusLabel2.Text = "[+] Ready"
            With Me
                .Show()
                .ShowInTaskbar = True
            End With
        End If
    End Sub


#End Region

#Region "Options - Timer"
    Private Sub Chk_custom_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_custom.CheckedChanged
        Dim i As RadioButton = sender
        If i.Checked Then
            NumericUpDown1.Enabled = True
            My.Settings.c4timer = NumericUpDown1.Value
        Else
            NumericUpDown1.Enabled = False
        End If
    End Sub
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If Chk_custom.Checked Then
            My.Settings.c4timer = NumericUpDown1.Value
        End If
    End Sub

    Private Sub Chk_comp_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_comp.CheckedChanged
        Dim i As RadioButton = sender
        If i.Checked Then
            My.Settings.c4timer = 40
        End If
    End Sub
#End Region

#Region "Announcer Voice"
    Private Sub TrckBar_Volume_Scroll(sender As Object, e As EventArgs) Handles TrckBar_Volume.Scroll
        My.Settings.Volume = CSng(TrckBar_Volume.Value / 100)
        My.Settings.Save()
    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        Dim i As ComboBox = sender
        My.Settings.UsingAnnouncer = i.SelectedIndex
        My.Settings.Save()
    End Sub

    Private Sub Btn_Preview_Click(sender As Object, e As EventArgs) Handles Btn_Preview.Click
        PlayPreview(ComboBox1.SelectedIndex)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PlayPreview(ComboBox1.SelectedIndex, 10)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PlayPreview(ComboBox1.SelectedIndex, 9)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PlayPreview(ComboBox1.SelectedIndex, 8)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PlayPreview(ComboBox1.SelectedIndex, 7)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PlayPreview(ComboBox1.SelectedIndex, 6)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PlayPreview(ComboBox1.SelectedIndex, 5)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        PlayPreview(ComboBox1.SelectedIndex, 4)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        PlayPreview(ComboBox1.SelectedIndex, 3)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        PlayPreview(ComboBox1.SelectedIndex, 2)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        PlayPreview(ComboBox1.SelectedIndex, 1)
    End Sub


    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        PlayPreview(ComboBox1.SelectedIndex, 0)
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

#Region "NotifyIcon Context Menu Strip"
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
            ToolStripMenuItem1.Text = "Hide"
        Else
            Me.WindowState = FormWindowState.Minimized
            ToolStripMenuItem1.Text = "Show"
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Me.Close()
    End Sub
#End Region

End Class
