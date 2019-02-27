Imports CSGSI
Module Mod_Csgsi
    Public Class GameState
        Private Shared listener As GameStateListener = New GameStateListener(3000)
        'Animation on statusstrip
        Private Shared a As New Mod_Animation.WorkingAnimation

        Public Shared Function StartCSGSI() As Boolean
            Try
                AddHandler listener.NewGameState, AddressOf OnNewGameState
                listener.Start()
            Catch ex As Exception
                Debug.Print("Error in INIT_CSGSI: " & ex.Message)
                Return False
            End Try

            With WatchDog_becauseCSGSI_is_Stupid
                .Interval = 50
                .Enabled = True
                .Start()
            End With

            Debug.Print("Active...")
            'Animation on statusstrip
            a.AnimationString(True, Frm_Main.ToolStripStatusLabel2,, "Active...")
            a.PictureBoxAnimation(True)
            Frm_Main.ToolStripProgressBar1.Style = ProgressBarStyle.Marquee
            '# ###
            Return True
        End Function

        Public Shared Function StopCSGSI() As Boolean
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

            With WatchDog_becauseCSGSI_is_Stupid
                .Enabled = False
                .Stop()
            End With
        End Function

        Private Shared Sub OnNewGameState(ByVal gs As CSGSI.GameState)
            Try
                'On fresh plant
                If gs.Round.Bomb = Nodes.BombState.Planted Then
                    triggered = True
                    Debug.Print("Bomb planted - EVENT")
                ElseIf gs.Round.Bomb = Nodes.BombState.Defused Or gs.Round.Bomb = Nodes.BombState.Exploded Then
                    'If defused or exploded, new round, etc.
                    triggered = False
                    Debug.Print("Bomb killed - EVENT")
                End If
            Catch ex As Exception
                Debug.Print("ERROR: " & ex.ToString)
            End Try
        End Sub

        Private Shared triggered As Boolean = False
        Private Shared WithEvents WatchDog_becauseCSGSI_is_Stupid As New Timer
        Private Shared Sub WatchDog_becauseCSGSI_is_Stupid_Tick() Handles WatchDog_becauseCSGSI_is_Stupid.Tick
            If triggered And Not Bombtimer.BombTimerRuns Then
                Bombtimer.BombHasBeenPlanted = True
                Exit Sub
            ElseIf triggered = False And Bombtimer.BombTimerRuns Then
                Bombtimer.BombHasBeenPlanted = False
            End If
        End Sub
    End Class

    Public Class Bombtimer
#Region "Properties"
        Private Shared _bombHasBeenPlanted As Boolean = False
        Private Shared Event BombHasBeenPlanted_Changed(ByVal bombState As Boolean)
        Public Shared Property BombHasBeenPlanted As Boolean
            Set(value As Boolean)
                _bombHasBeenPlanted = value
                RaiseEvent BombHasBeenPlanted_Changed(value)
            End Set
            Get
                Return _bombHasBeenPlanted
            End Get
        End Property

        Private Shared _remainingSecondsToExplosion As Integer = My.Settings.c4timer - 1
        Public Shared Property RemainingSecondsToExplosion As Integer
            Set(value As Integer)
                _remainingSecondsToExplosion = value
            End Set
            Get
                Return _remainingSecondsToExplosion
            End Get
        End Property

        Private Shared _bombTimerRuns As Boolean = False
        Public Shared Property BombTimerRuns As Boolean
            Set(value As Boolean)
                _bombTimerRuns = value
            End Set
            Get
                Return _bombTimerRuns
            End Get
        End Property
#End Region

        'Handle Bomb planted or defused EVENT
        Private Shared Sub BombHasBeenPlanted_Changed_EventHandle(ByVal bombState As Boolean) Handles Me.BombHasBeenPlanted_Changed
            Debug.Print("Bomb EVENT triggered - " & bombState)
            If bombState Then
                If Not CountDown.Enabled Then
                    StartTimer()
                    BombTimerRuns = True
                End If
            Else
                BombTimerRuns = False
                ResetTimer()
            End If
        End Sub

        'Timer Tick
        Private Shared WithEvents CountDown As Timer = New Timer
        Private Shared Sub CountDown_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles CountDown.Tick
            Frm_Overlay.Lbl_Time.Text = RemainingSecondsToExplosion

            If RemainingSecondsToExplosion >= 11 Then
                Frm_Overlay.Lbl_Time.ForeColor = Color.White
            End If
            If RemainingSecondsToExplosion <= 10 And RemainingSecondsToExplosion >= 6 Then
                Frm_Overlay.Lbl_Time.ForeColor = Color.Yellow
                Mod_Sound.PlayAnnouncer()
            End If
            If RemainingSecondsToExplosion <= 5 Then
                Frm_Overlay.Lbl_Time.ForeColor = Color.Red
                Mod_Sound.PlayAnnouncer()
            End If


            RemainingSecondsToExplosion -= 1


            If RemainingSecondsToExplosion <= -1 Then
                ResetTimer()
            End If
        End Sub

        'Start and Reset Bombtimer
        'Reset settings to beginning
        Private Shared Sub StartTimer()
            With CountDown
                .Enabled = True
                .Interval = 1000
                .Start()
            End With
            RemainingSecondsToExplosion = My.Settings.c4timer - 1
            With Frm_Overlay.Lbl_Time
                .Text = My.Settings.c4timer.ToString
                .ForeColor = Color.White
            End With
            Frm_Overlay.Show()
        End Sub
        Private Shared Sub ResetTimer()
            RemainingSecondsToExplosion = My.Settings.c4timer - 1
            With CountDown
                .Enabled = False
                .Stop()
            End With
            Frm_Overlay.Hide()
        End Sub
    End Class
End Module
