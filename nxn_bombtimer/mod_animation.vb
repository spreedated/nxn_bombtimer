Module mod_animation
    Public Class workingAnimation
        Private Property aniID As String
        Private aniDict As New Dictionary(Of Integer, workingAnimation)
        Private WithEvents aniTimer As New Timer
        Private tickCount As UInteger
        Private is_running As Boolean
        Public ReadOnly Property running() As Boolean
            Get
                Return is_running
            End Get
        End Property

        Private mValue As String
        Private Event VariableChanged(ByVal mvalue As String)
        Private mylabel As ToolStripStatusLabel
        Private myTextBefore As String
        Private myTextAfter As String
        Private Property Variable() As String
            Get
                Variable = mValue
            End Get
            Set(ByVal value As String)
                mValue = value
                RaiseEvent VariableChanged(mValue)
            End Set
        End Property


        Private Sub VariableChanged_onchange() Handles Me.VariableChanged
            mylabel.Text = String.Format("{0}[{1}] {2}", myTextBefore, aniDict(tickCount).aniID, myTextAfter)
        End Sub
        Private Sub aniTime_Tick() Handles aniTimer.Tick
            If tickCount > aniDict.Count - 1 Then
                tickCount = 0
            End If
            Me.Variable = aniDict(tickCount).aniID
            tickCount += 1
        End Sub
        Public Sub animationString(ByVal toggle As Boolean, ByRef Optional labelcontrol As ToolStripStatusLabel = Nothing, ByVal Optional textBefore As String = Nothing, ByVal Optional textAfter As String = Nothing, ByVal Optional items As Array = Nothing)
            aniDict.Clear()
            If Not toggle Then
                With aniTimer
                    .Enabled = False
                    .Stop()
                End With
                is_running = False
                Exit Sub
            End If


            If aniDict.Count <= 0 And items Is Nothing Then
                With aniDict
                    .Add(0, New workingAnimation With {.aniID = "-"})
                    .Add(1, New workingAnimation With {.aniID = "\"})
                    .Add(2, New workingAnimation With {.aniID = "|"})
                    .Add(3, New workingAnimation With {.aniID = "/"})
                End With
            End If
            If Not items Is Nothing Then
                Dim c As Integer = 0
                For Each item In items
                    aniDict.Add(c, New workingAnimation With {.aniID = item})
                    c += 1
                Next
            End If

            tickCount = 0
            mylabel = labelcontrol
            myTextBefore = textBefore
            myTextAfter = textAfter

            If toggle Then
                With aniTimer
                    .Enabled = True
                    .Interval = 100
                    .Start()
                End With
                is_running = True
            End If
        End Sub

#Region "PictureBox Animation"
        Private ReadOnly PBoxAnimationImages As Array = {My.Resources.bomb_1, My.Resources.bomb_2, My.Resources.bomb_3, My.Resources.bomb_4, My.Resources.bomb_5, My.Resources.bomb_6, My.Resources.bomb_7, My.Resources.bomb_8, My.Resources.bomb_full, My.Resources.bomb_empty}
        Private PBoxAnimationImages_current As Short = 0

        Private WithEvents PBoxAnimationTimer As New Timer
        Private Sub PBoxAnimationTimer_Tick() Handles PBoxAnimationTimer.Tick

            frm_main.PictureBox1.Image = PBoxAnimationImages(PBoxAnimationImages_current)


            PBoxAnimationImages_current += 1

            If PBoxAnimationImages_current > PBoxAnimationImages.Length - 1 Then
                PBoxAnimationImages_current = 0
            End If
        End Sub

        Public Sub PictureBoxAnimation(ByVal state As Boolean)
            With PBoxAnimationTimer
                .Enabled = True
                .Interval = 200
            End With

            Select Case state
                Case True
                    PBoxAnimationTimer.Start()
                Case False
                    PBoxAnimationTimer.Stop()
                    frm_main.PictureBox1.Image = My.Resources.bomb_empty
            End Select
        End Sub

#End Region

    End Class

End Module
