Imports NAudio.Wave
Imports System.Threading
Module Mod_Sound

#Region "Properties"
    Private _volume As Single = 1.0F
    Public Property AnnouncerVolume As Single
        Set(value As Single)
            _volume = value
        End Set
        Get
            Return _volume
        End Get
    End Property
#End Region

    Public Enum AnnouncerSet
        _3D = 1
        Female = 2
        UT99 = 3
        Anologue = 4
    End Enum

    'Private Sub PlaySound(ByVal pathtofile As String)
    '    Dim audioFileReader As AudioFileReader = New AudioFileReader(pathtofile)
    '    Dim waveOutDevice As IWavePlayer = New WaveOut

    '    waveOutDevice.Init(audioFileReader)
    '    waveOutDevice.Play()

    '    While waveOutDevice.PlaybackState = PlaybackState.Playing

    '    End While

    '    waveOutDevice.Dispose()
    '    audioFileReader.Dispose()
    'End Sub

    Private Sub PlayMP3SoundRes(ByVal resource As Byte())
        Dim waveOutDevice As IWavePlayer = New WaveOut
        Dim mp3file As System.IO.MemoryStream = New IO.MemoryStream(resource)
        Dim mp3FileReader As Mp3FileReader = New Mp3FileReader(mp3file)


        waveOutDevice.Init(mp3FileReader)
        waveOutDevice.Volume = My.Settings.Volume
        waveOutDevice.Play()

        While waveOutDevice.PlaybackState = PlaybackState.Playing

        End While

        waveOutDevice.Dispose()
        mp3file.Dispose()
        mp3FileReader.Dispose()
    End Sub

    Public Sub PlayMp3SoundResAsThread(ByVal resource As Byte())
        Dim i As Thread = New Thread(Sub() PlayMP3SoundRes(resource))
        i.Start()
    End Sub

    Public Sub PlayAnnouncer(ByVal announcer As Integer)
        Select Case announcer
            Case 1
                _3D_Announcer.Start()
            Case 2
                Female_Voice.Start()
            Case 3
                UT99_Announcer.Start()
            Case 4
                Analogue_Clock.Start()
            Case Else
                'noop
        End Select
    End Sub

    Public Sub PlayPreview(ByRef Announcer As AnnouncerSet)
        Randomize()
        Dim rndNum As Random = New Random()

        Select Case Announcer
            Case 1
                PlayMp3SoundResAsThread(_3D_Announcer.SoundArray(rndNum.Next(0, 11)))
            Case 2
                PlayMp3SoundResAsThread(Female_Voice.SoundArray(rndNum.Next(0, 11)))
            Case 3
                PlayMp3SoundResAsThread(UT99_Announcer.SoundArray(rndNum.Next(0, 11)))
            Case 4
                PlayMp3SoundResAsThread(Analogue_Clock.SoundArray(0))
        End Select
    End Sub

#Region "3D Announcer"
    Public Class _3D_Announcer
        Public Shared SoundArray = {My.Resources._3d_0, My.Resources._3d_1, My.Resources._3d_2, My.Resources._3d_3, My.Resources._3d_4, My.Resources._3d_5, My.Resources._3d_6, My.Resources._3d_7, My.Resources._3d_8, My.Resources._3d_9, My.Resources._3d_10}
        Private Shared bombtime As Integer
        Public Shared Sub Start()
            bombtime = Mod_Csgsi.MyBombtime.Bombtime
            Select Case bombtime
                Case 10
                    PlayMp3SoundResAsThread(My.Resources._3d_10)
                Case 9
                    PlayMp3SoundResAsThread(My.Resources._3d_9)
                Case 8
                    PlayMp3SoundResAsThread(My.Resources._3d_8)
                Case 7
                    PlayMp3SoundResAsThread(My.Resources._3d_7)
                Case 6
                    PlayMp3SoundResAsThread(My.Resources._3d_6)
                Case 5
                    PlayMp3SoundResAsThread(My.Resources._3d_5)
                Case 4
                    PlayMp3SoundResAsThread(My.Resources._3d_4)
                Case 3
                    PlayMp3SoundResAsThread(My.Resources._3d_3)
                Case 2
                    PlayMp3SoundResAsThread(My.Resources._3d_2)
                Case 1
                    PlayMp3SoundResAsThread(My.Resources._3d_1)
                Case 0
                    PlayMp3SoundResAsThread(My.Resources._3d_0)
            End Select
        End Sub
    End Class
#End Region

#Region "Female Voice"
    Public Class Female_Voice
        Public Shared SoundArray = {My.Resources.female_0, My.Resources.female_1, My.Resources.female_2, My.Resources.female_3, My.Resources.female_4, My.Resources.female_5, My.Resources.female_6, My.Resources.female_7, My.Resources.female_8, My.Resources.female_9, My.Resources.female_10}
        Private Shared bombtime As Integer
        Public Shared Sub Start()
            bombtime = Mod_Csgsi.MyBombtime.Bombtime
            Select Case bombtime
                Case 10
                    PlayMp3SoundResAsThread(My.Resources.female_10)
                Case 9
                    PlayMp3SoundResAsThread(My.Resources.female_9)
                Case 8
                    PlayMp3SoundResAsThread(My.Resources.female_8)
                Case 7
                    PlayMp3SoundResAsThread(My.Resources.female_7)
                Case 6
                    PlayMp3SoundResAsThread(My.Resources.female_6)
                Case 5
                    PlayMp3SoundResAsThread(My.Resources.female_5)
                Case 4
                    PlayMp3SoundResAsThread(My.Resources.female_4)
                Case 3
                    PlayMp3SoundResAsThread(My.Resources.female_3)
                Case 2
                    PlayMp3SoundResAsThread(My.Resources.female_2)
                Case 1
                    PlayMp3SoundResAsThread(My.Resources.female_1)
                Case 0
                    PlayMp3SoundResAsThread(My.Resources.female_0)
            End Select
        End Sub
    End Class
#End Region

#Region "UT99 Announcer"
    Public Class UT99_Announcer
        Public Shared SoundArray = {My.Resources.ut99_1, My.Resources.ut99_2, My.Resources.ut99_3, My.Resources.ut99_4, My.Resources.ut99_5, My.Resources.ut99_6, My.Resources.ut99_7, My.Resources.ut99_8, My.Resources.ut99_9, My.Resources.ut99_10}
        Private Shared bombtime As Integer
        Public Shared Sub Start()
            bombtime = Mod_Csgsi.MyBombtime.Bombtime
            Select Case bombtime
                Case 10
                    PlayMp3SoundResAsThread(My.Resources.ut99_10)
                Case 9
                    PlayMp3SoundResAsThread(My.Resources.ut99_9)
                Case 8
                    PlayMp3SoundResAsThread(My.Resources.ut99_8)
                Case 7
                    PlayMp3SoundResAsThread(My.Resources.ut99_7)
                Case 6
                    PlayMp3SoundResAsThread(My.Resources.ut99_6)
                Case 5
                    PlayMp3SoundResAsThread(My.Resources.ut99_5)
                Case 4
                    PlayMp3SoundResAsThread(My.Resources.ut99_4)
                Case 3
                    PlayMp3SoundResAsThread(My.Resources.ut99_3)
                Case 2
                    PlayMp3SoundResAsThread(My.Resources.ut99_2)
                Case 1
                    PlayMp3SoundResAsThread(My.Resources.ut99_1)
            End Select
        End Sub
    End Class
#End Region

#Region "Analogue Clock"
    Public Class Analogue_Clock
        Public Shared SoundArray = {My.Resources.second_analogue}
        Private Shared bombtime As Integer
        Public Shared Sub Start()
            bombtime = Mod_Csgsi.MyBombtime.Bombtime
            PlayMp3SoundResAsThread(SoundArray(0))
        End Sub
    End Class
#End Region

End Module
