Module mod_overlay
    Private WithEvents lbl_time As New Label
    Public WithEvents frm_overlay As New Form


    Private scr_x As Integer = My.Computer.Screen.Bounds.Width
    Private scr_y As Integer = My.Computer.Screen.Bounds.Height
    Private drag As Boolean
    Private mousex As Integer
    Private mousey As Integer

    Private Sub frm_overlay_load() Handles frm_overlay.Load
        dropFont()

        With frm_overlay
            .MinimumSize = New Size(0, 0)
            .AutoSize = False
            .ControlBox = False
            .FormBorderStyle = FormBorderStyle.None
            .Size = New Size(136, 39)
            .Location = New Point((scr_x / 2) - (136 / 2), 55)
            .MinimizeBox = False
            .ShowInTaskbar = False
            .StartPosition = FormStartPosition.Manual
            .Opacity = 0.6
            .Name = "frm_overlay"
            .BackColor = Color.Black
            .TopMost = True
        End With

        With lbl_time
            .Name = "lbl_time"
            .AutoSize = False
            .Location = New Point(0, 0)
            .Size = New Size(136, 39)
            .TextAlign = ContentAlignment.MiddleCenter
            If use_custom_font Then
                .Font = New Font(pfc.Families(0), 24, FontStyle.Regular)
            Else
                .Font = New Font("Consolas", 24, FontStyle.Bold)
            End If
            .ForeColor = Color.White
            .BackColor = Color.Transparent
            .Text = "00"
        End With

        frm_overlay.Controls.Add(lbl_time)
    End Sub
#Region "Drag Window with Mouse"
    Private Sub frm_overlay_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles frm_overlay.MouseDown, lbl_time.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - frm_overlay.Left
        mousey = Windows.Forms.Cursor.Position.Y - frm_overlay.Top
    End Sub
    Private Sub frm_overlay_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles frm_overlay.MouseMove, lbl_time.MouseMove
        If drag Then
            frm_overlay.Top = Windows.Forms.Cursor.Position.Y - mousey
            frm_overlay.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub frm_overlay_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles frm_overlay.MouseUp, lbl_time.MouseUp
        drag = False
    End Sub
#End Region

#Region "Drop CS Regular Font to System"
    Public pfc As New System.Drawing.Text.PrivateFontCollection()
    Public use_custom_font As Boolean = False
    Public Sub dropFont()
        Try
            'Drop TTF to tmp
            If Not My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.Temp & "\nxn_bombtimer.ttf") Then
                My.Computer.FileSystem.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.Temp & "\nxn_bombtimer.ttf", My.Resources.cs_regular, False)
            End If
            With pfc
                .AddFontFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\nxn_bombtimer.ttf")
            End With
            use_custom_font = True
        Catch ex As Exception
            use_custom_font = False
        End Try
    End Sub

#End Region
End Module
