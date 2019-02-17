Imports CSGSI
Module Mod_Csgsi
    Public listener As GameStateListener = New GameStateListener(3000)
    'Animation on statusstrip
    Private a As New Mod_Animation.WorkingAnimation

    Public Function StartCSGSI() As Boolean
        Set_gamevariables()
        Try
            AddHandler listener.NewGameState, AddressOf OnNewGameState
            listener.Start()
        Catch ex As Exception
            Debug.Print("Error in INIT_CSGSI: " & ex.Message)
            Return False
        End Try

        Debug.Print("Active...")
        'Animation on statusstrip
        a.AnimationString(True, Frm_Main.ToolStripStatusLabel2,, "Active...")
        a.PictureBoxAnimation(True)
        Frm_Main.ToolStripProgressBar1.Style = ProgressBarStyle.Marquee
        '# ###
        Return True
    End Function

    Public Function StopCSGSI() As Boolean
        'Animation on statusstrip
        a.AnimationString(False)
        a.PictureBoxAnimation(False)
        Frm_Main.ToolStripProgressBar1.Style = ProgressBarStyle.Blocks
        '# ###

        If listener.Running = True Then
            Try
                listener.Stop()
            Catch ex As Exception

            End Try
            Debug.Print("Listener stopped by User")
            Return True
        Else
            Debug.Print("Listener couldn't be stopped, not running?")
            Return False
        End If
    End Function
    Public Function RestartCSGSI() As Boolean
        If StopCSGSI() = True Then
            Threading.Thread.Sleep(500)
            Debug.Print("Restarting listener...")
            StartCSGSI()
            Return True
        Else
            Threading.Thread.Sleep(500)
            Debug.Print("Listener not started yet, starting listener...")
            StartCSGSI()
            Return False
        End If
    End Function


    Private Sub OnNewGameState(ByVal gs As GameState)
        Dim curround As Integer?
        Dim prevround As Integer?

        Try
            curround = gs.Map.Round
            prevround = gs.Previously.Map.Round
        Catch ex As Exception
            Debug.Print("Error in GET objects of SUB OnNewGameState: " & ex.Message)
            Exit Sub
        End Try


        'Debug.Print("State changed")
        'Debug.Print(gs.Map.Round)

        'On fresh plant
        If gs.Round.Bomb.ToString.ToLower.Contains("planted") Then
            isplanted = True
        End If

        'If defused or exploded, new round, etc.
        If gs.Round.Bomb.ToString.ToLower.Contains("planted") = False Then
            isplanted = False
        End If


        'Debug.Print(initialbombtime.ToString)


    End Sub

    Private Sub Set_gamevariables()
        If Frm_Main.chk_comp.Checked Then
            c4time = 40
        Else
            c4time = Frm_Main.NumericUpDown1.Value
        End If

        teh_announcer = Frm_Main.ComboBox1.SelectedIndex

    End Sub
#Region "Game Variables"
    '# Vars
    Private curr_timestamp As Integer = 0
    Private round As Integer = -1
    '# #####################

    'Options
    Private c4time As Integer = 40
    Private teh_announcer As Integer = 0

#End Region

#Region "BombTimer"
    Private WithEvents BombTimer As New Timer
    Public WithEvents MyBombtime As New on_bombtime_change
    Private initialbombtime As Integer = c4time
    Public Sub BombTimer_tick() Handles BombTimer.Tick
        Mod_Overlay.Frm_Overlay.Show()

        Debug.Print("Bombtimer ticks...")

        MyBombtime.bombtime = initialbombtime - 1
        initialbombtime -= 1
        If initialbombtime <= 0 Then
            isplanted = False
        End If
    End Sub
    Private Sub On_bombtime_change() Handles MyBombtime.bombtime_changed
        Dim lbl As Label = Frm_Overlay.Controls.Item(Frm_Overlay.Controls.IndexOfKey("lbl_time"))
        Dim bombtime As Integer = MyBombtime.bombtime
        lbl.Text = bombtime

        'Sound
        If bombtime <= 10 And bombtime > 5 Then
            lbl.ForeColor = Color.Yellow
            mod_sound.playAnnouncer(teh_announcer)
        ElseIf bombtime <= 5 Then
            lbl.ForeColor = Color.Red
            mod_sound.playAnnouncer(teh_announcer)
        Else
            lbl.ForeColor = Color.White
        End If
    End Sub
#End Region

#Region "WatchDog"
    Private isplanted As Boolean = False
    Public WithEvents WatchDog As New Timer
    Private Sub WatchDog_tick() Handles WatchDog.Tick
        If isplanted = True Then
            If BombTimer.Enabled = False Then
                With BombTimer
                    .Enabled = True
                    .Interval = 1000
                    .Start()
                End With
                Debug.Print("Bombtimer started...")
            End If
        End If

        If isplanted = False Then
            With BombTimer
                .Enabled = False
                .Stop()
            End With
            initialbombtime = c4time
            Mod_Overlay.Frm_Overlay.Hide()
            BombTimer.Stop()
        End If
    End Sub
#End Region
End Module
