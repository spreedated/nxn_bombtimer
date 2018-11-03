Imports NAudio.Wave
Module mod_sound
    Private waveOutDevice As IWavePlayer
    Private audioFileReader As AudioFileReader
    Private mp3FileReader As Mp3FileReader

    Public Sub playSound(ByVal pathtofile As String)
        Try
            If waveOutDevice.PlaybackState = PlaybackState.Playing Then
                Try
                    waveOutDevice.Stop()
                Catch ex As Exception
                    'noop
                End Try
            End If
        Catch ex As Exception
            Debug.Print("object not initialized")
        End Try

        waveOutDevice = New WaveOut
        audioFileReader = New AudioFileReader(pathtofile)
        waveOutDevice.Init(audioFileReader)
        waveOutDevice.Play()
    End Sub

    Public Sub playMP3SoundRes(ByVal resource As Byte())
        Try
            If waveOutDevice.PlaybackState = PlaybackState.Playing Then
                Try
                    waveOutDevice.Stop()
                Catch ex As Exception
                    'noop
                End Try
            End If
        Catch ex As Exception
            Debug.Print("object not initialized")
        End Try

        waveOutDevice = New WaveOut
        Dim mp3file As System.IO.MemoryStream = New IO.MemoryStream(resource)

        mp3FileReader = New Mp3FileReader(mp3file)
        waveOutDevice.Init(mp3FileReader)
        waveOutDevice.Play()
    End Sub

    Public Sub playAnnouncer(ByVal announcer As Integer)
        Select Case announcer
            Case 1
                _3D_Announcer.start()
            Case 2
                Female_Voice.start()
            Case 3
                UT99_Announcer.start()
            Case 4
                Analogue_Clock.start()
            Case Else
                'noop
        End Select
    End Sub

#Region "3D Announcer"
    Public Class _3D_Announcer
        Private Shared bombtime As Integer
        Public Shared Sub start()
            bombtime = mod_csgsi.myBombtime.bombtime
            Select Case bombtime
                Case 10
                    playMP3SoundRes(My.Resources._3d_10)
                Case 9
                    playMP3SoundRes(My.Resources._3d_9)
                Case 8
                    playMP3SoundRes(My.Resources._3d_8)
                Case 7
                    playMP3SoundRes(My.Resources._3d_7)
                Case 6
                    playMP3SoundRes(My.Resources._3d_6)
                Case 5
                    playMP3SoundRes(My.Resources._3d_5)
                Case 4
                    playMP3SoundRes(My.Resources._3d_4)
                Case 3
                    playMP3SoundRes(My.Resources._3d_3)
                Case 2
                    playMP3SoundRes(My.Resources._3d_2)
                Case 1
                    playMP3SoundRes(My.Resources._3d_1)
                Case 0
                    playMP3SoundRes(My.Resources._3d_0)
            End Select
        End Sub
    End Class
#End Region

#Region "Female Voice"
    Public Class Female_Voice
        Private Shared bombtime As Integer
        Public Shared Sub start()
            bombtime = mod_csgsi.myBombtime.bombtime
            Select Case bombtime
                Case 10
                    playMP3SoundRes(My.Resources.female_10)
                Case 9
                    playMP3SoundRes(My.Resources.female_9)
                Case 8
                    playMP3SoundRes(My.Resources.female_8)
                Case 7
                    playMP3SoundRes(My.Resources.female_7)
                Case 6
                    playMP3SoundRes(My.Resources.female_6)
                Case 5
                    playMP3SoundRes(My.Resources.female_5)
                Case 4
                    playMP3SoundRes(My.Resources.female_4)
                Case 3
                    playMP3SoundRes(My.Resources.female_3)
                Case 2
                    playMP3SoundRes(My.Resources.female_2)
                Case 1
                    playMP3SoundRes(My.Resources.female_1)
                Case 0
                    playMP3SoundRes(My.Resources.female_0)
            End Select
        End Sub
    End Class
#End Region

#Region "UT99 Announcer"
    Public Class UT99_Announcer
        Private Shared bombtime As Integer
        Public Shared Sub start()
            bombtime = mod_csgsi.myBombtime.bombtime
            Select Case bombtime
                Case 10
                    playMP3SoundRes(My.Resources.ut99_10)
                Case 9
                    playMP3SoundRes(My.Resources.ut99_9)
                Case 8
                    playMP3SoundRes(My.Resources.ut99_8)
                Case 7
                    playMP3SoundRes(My.Resources.ut99_7)
                Case 6
                    playMP3SoundRes(My.Resources.ut99_6)
                Case 5
                    playMP3SoundRes(My.Resources.ut99_5)
                Case 4
                    playMP3SoundRes(My.Resources.ut99_4)
                Case 3
                    playMP3SoundRes(My.Resources.ut99_3)
                Case 2
                    playMP3SoundRes(My.Resources.ut99_2)
                Case 1
                    playMP3SoundRes(My.Resources.ut99_1)
            End Select
        End Sub
    End Class
#End Region

#Region "Analogue Clock"
    Public Class Analogue_Clock
        Private Shared bombtime As Integer
        Public Shared Sub start()
            bombtime = mod_csgsi.myBombtime.bombtime
            playMP3SoundRes(My.Resources.second_analogue)
        End Sub
    End Class
#End Region

End Module
