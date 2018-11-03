Imports CSGSI
Module mod_csgsi
    Public listener As GameStateListener = New GameStateListener(3000)
    'Animation on statusstrip
    Private a As New mod_animation.workingAnimation

    Public Function startCSGSI() As Boolean
        set_gamevariables()
        Try
            AddHandler listener.NewGameState, AddressOf OnNewGameState
            listener.Start()
        Catch ex As Exception
            Debug.Print("Error in INIT_CSGSI: " & ex.Message)
            Return False
        End Try

        Debug.Print("Active...")
        'Animation on statusstrip
        a.animationString(True, frm_main.ToolStripStatusLabel2,, "Active...")
        a.PictureBoxAnimation(True)
        frm_main.ToolStripProgressBar1.Style = ProgressBarStyle.Marquee
        '# ###
        Return True
    End Function

    Public Function stopCSGSI() As Boolean
        'Animation on statusstrip
        a.animationString(False)
        a.PictureBoxAnimation(False)
        frm_main.ToolStripProgressBar1.Style = ProgressBarStyle.Blocks
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
    Public Function restartCSGSI() As Boolean
        If stopCSGSI() = True Then
            Threading.Thread.Sleep(500)
            Debug.Print("Restarting listener...")
            startCSGSI()
            Return True
        Else
            Threading.Thread.Sleep(500)
            Debug.Print("Listener not started yet, starting listener...")
            startCSGSI()
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

    Private Sub set_gamevariables()
        If frm_main.chk_comp.Checked Then
            c4time = 40
        Else
            c4time = frm_main.NumericUpDown1.Value
        End If

        teh_announcer = frm_main.ComboBox1.SelectedIndex

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
    Private WithEvents bombTimer As New Timer
    Public WithEvents myBombtime As New on_bombtime_change
    Private initialbombtime As Integer = c4time
    Public Sub bombTimer_tick() Handles bombTimer.Tick
        mod_overlay.frm_overlay.Show()

        Debug.Print("Bombtimer ticks...")

        myBombtime.bombtime = initialbombtime - 1
        initialbombtime -= 1
        If initialbombtime <= 0 Then
            isplanted = False
        End If
    End Sub
    Private Sub on_bombtime_change() Handles myBombtime.bombtime_changed
        Dim lbl As Label = frm_overlay.Controls.Item(frm_overlay.Controls.IndexOfKey("lbl_time"))
        Dim bombtime As Integer = myBombtime.bombtime
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
    Public WithEvents watchDog As New Timer
    Private Sub watchDog_tick() Handles watchDog.Tick
        If isplanted = True Then
            If bombTimer.Enabled = False Then
                With bombTimer
                    .Enabled = True
                    .Interval = 1000
                    .Start()
                End With
                Debug.Print("Bombtimer started...")
            End If
        End If

        If isplanted = False Then
            With bombTimer
                .Enabled = False
                .Stop()
            End With
            initialbombtime = c4time
            mod_overlay.frm_overlay.Hide()
            bombTimer.Stop()
        End If
    End Sub
#End Region
End Module
