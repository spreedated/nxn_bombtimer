Imports System.ComponentModel

Public Class frm_main
    Private normal_window_size As New Size(431, 269)
    Private option_window_size As New Size(431, 635)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .Text = mod_appprop.application_name
            .FormBorderStyle = FormBorderStyle.FixedSingle
            .ShowIcon = True
            .ShowInTaskbar = True
            .MaximizeBox = False
            .Size = normal_window_size
            .Icon = My.Resources.c4_icon_black
        End With
        ComboBox1.SelectedIndex = 1
        mod_licence.check_licence_on_startup()
    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        If sender.text.ToString.ToLower.Contains("rock") Then
            st_myState(True)
        Else
            st_myState(False)
        End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        mod_csgsi.stopCSGSI()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If sender.text.ToString.ToLower.Contains("»") Then
            Me.Size = option_window_size
            '# LICENCE
            If Not is_licensed Then
                GroupBox1.Enabled = False
                Label4.Visible = True
            Else
                GroupBox1.Enabled = True
                Label4.Visible = False
            End If
            '# ###
            GroupBox1.Visible = True
            sender.text = sender.text.ToString.Replace("»", "«")
        Else
            Me.Size = normal_window_size
            GroupBox1.Visible = False
            sender.text = sender.text.ToString.Replace("«", "»")
        End If
    End Sub
#Region "Stylez"
    Private Sub st_myState(ByVal state As Boolean)
        If state Then
            GroupBox1.Visible = False
            Me.Size = normal_window_size
            Button2.Enabled = False
            Button3.Enabled = False
            btn_start.Text = "&Stop"
            Button2.Text = "&Options »"
            Debug.Print(listener.Running.ToString)
            mod_csgsi.startCSGSI()
            Debug.Print(listener.Running.ToString)
            mod_csgsi.watchDog.Interval = 50
            mod_csgsi.watchDog.Start()
        Else
            Button2.Enabled = True
            Button3.Enabled = True
            btn_start.Text = "&Rock 'n' Roll"
            mod_csgsi.stopCSGSI()
            ToolStripStatusLabel2.Text = "[+] Ready"
            mod_csgsi.watchDog.Stop()
        End If
    End Sub
#End Region

#Region "Options - Timer"
    Private Sub chk_custom_CheckedChanged(sender As Object, e As EventArgs) Handles chk_custom.CheckedChanged
        If sender.checked Then
            NumericUpDown1.Enabled = True
        Else
            NumericUpDown1.Enabled = False
        End If
    End Sub
#End Region

#Region "Licence GroupBox"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Length = 6 And TextBox2.Text.Length = 9 And TextBox3.Text.Length = 6 And TextBox3.Text.ToLower.StartsWith("nxn") = True Then
            My.Settings.licence = TextBox1.Text & "-" & TextBox2.Text & "-" & TextBox3.Text
            My.Settings.Save()
            check_licence_on_startup()
            Button2.PerformClick()
        Else
            MsgBox("Licence not valid", MsgBoxStyle.Information, application_name)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim i = My.Computer.Clipboard.GetText
            If i.Length = 23 And i.ToLower.Contains("-nxn") Then
                Dim d() As String = i.Split("-")
                TextBox1.Text = d(0)
                TextBox2.Text = d(1)
                TextBox3.Text = d(2)
            End If
        Catch ex As Exception
            'noop
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim i As MsgBoxResult = MsgBox("Delete licence and reset to TRIAL MODE?", MsgBoxStyle.OkCancel, application_name)

        If i = MsgBoxResult.Ok Then
            Dim d As MsgBoxResult = MsgBox("Are you sure?!", MsgBoxStyle.YesNo, application_name)
            If d = MsgBoxResult.Yes Then
                My.Settings.licence = ""
                My.Settings.Save()
                mod_licence.check_licence_on_startup()
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                Button5.Enabled = False
                Button1.Enabled = True
                Button6.Enabled = True
                Button4.Enabled = True
            Else
                MsgBox("Nothing changed", MsgBoxStyle.Information, application_name)
            End If
        Else
            MsgBox("Nothing changed", MsgBoxStyle.Information, application_name)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Length = TextBox1.MaxLength Then
            TextBox2.Select()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text.Length = TextBox2.MaxLength Then
            TextBox3.Select()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim textBoxes As Array = {TextBox1, TextBox2, TextBox3}
        For Each tBox As TextBox In textBoxes
            tBox.Clear()
        Next
    End Sub
#End Region

#Region "Auto-Listen"
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        With watchCS
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

    Private WithEvents watchCS As New Timer
    Private Sub watchCS_Tick() Handles watchCS.Tick
        Dim i As Process() = Process.GetProcessesByName("csgo")
        Dim procArray As New ArrayList

        For Each item In i
            procArray.Add(item.Id & ":" & item.MainWindowTitle & ":" & item.SessionId & ":" & item.ProcessName)
        Next

        If procArray.Count >= 1 Then
            For Each item In procArray
                If item.ToString.ToLower.Contains("csgo") Then
                    If btn_start.Text.Contains("'n'") Then
                        btn_start.PerformClick()
                    End If
                End If
            Next
        Else
            If btn_start.Text.Contains("top") Then
                btn_start.PerformClick()
            End If
        End If
    End Sub
#End Region

#If DEBUG Then
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        GenerateLicence()
    End Sub


    Private licenceArray As String = "abcdefghijklmnopqrstuvwxyz0123456789"
    Private Sub GenerateLicence()
        Randomize()
        Dim rnd As New Random
        Dim output As String = Nothing
        Dim i As Short = 0

        Do
            Dim rnd_num = rnd.Next(0, 35)

            output += licenceArray(rnd_num)

            i += 1
        Loop While i < 21

        output = output.Insert(6, "-")
        output = output.Insert(16, "-")
        Dim filename = output.ToUpper
        filename = filename.Insert(filename.LastIndexOf("-") + 1, "NXN")
        filename = filename.Substring(0, 23)

        Dim issuedTo As String = "PROMO CODE"
        Dim issueDate As UInt64 = CLng(DateTime.Now.Subtract(New DateTime(1970, 1, 1)).TotalSeconds)
        Dim expirationDate As UInt64 = CLng(DateTime.Now.AddMonths(1).Subtract(New DateTime(1970, 1, 1)).TotalSeconds)

        Dim path As String = "C:\Users\SpReeD\Documents\Visual Studio 2017\Projects\nxn_bombtimer\license\" & filename & ".nxn"

        Dim z = System.IO.File.Create(path)
        z.Close()
        System.IO.File.WriteAllText(path, issuedTo & vbCrLf & issueDate & vbCrLf & expirationDate)


    End Sub

    Private Function ConvertTimestamp(ByVal timestamp As Double) As DateTime
        Return New DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(timestamp)
    End Function
#End If
End Class
