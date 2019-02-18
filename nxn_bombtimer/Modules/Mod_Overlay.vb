Imports System.Runtime.InteropServices
Module Mod_Overlay
    ' Rounded Edges
    <DllImport("gdi32.dll")>
    Public Function CreateRoundRectRgn(ByVal x1 As Integer, ByVal y1 As Integer, ByVal x2 As Integer, ByVal y2 As Integer, ByVal cx As Integer, ByVal cy As Integer) As IntPtr
    End Function
    ' ###

    Private WithEvents Lbl_Time As New Label
    Public WithEvents Frm_Overlay As New Form


    Private scr_x As Integer = My.Computer.Screen.Bounds.Width
    Private scr_y As Integer = My.Computer.Screen.Bounds.Height
    Private drag As Boolean
    Private mousex As Integer
    Private mousey As Integer

    Private Sub Frm_Overlay_load() Handles Frm_Overlay.Load
        DropFont()

        With Frm_Overlay
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

        With Lbl_Time
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

        ' Rounded Edges
        Frm_Overlay.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Frm_Overlay.Width, Frm_Overlay.Height, 15, 15))

        Frm_Overlay.Controls.Add(Lbl_Time)
    End Sub

#Region "Drag Window with Mouse"
    Private Sub Frm_Overlay_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Frm_Overlay.MouseDown, Lbl_Time.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Frm_Overlay.Left
        mousey = Windows.Forms.Cursor.Position.Y - Frm_Overlay.Top
    End Sub
    Private Sub Frm_Overlay_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Frm_Overlay.MouseMove, Lbl_Time.MouseMove
        If drag Then
            Frm_Overlay.Top = Windows.Forms.Cursor.Position.Y - mousey
            Frm_Overlay.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub Frm_Overlay_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Frm_Overlay.MouseUp, Lbl_Time.MouseUp
        drag = False
    End Sub
#End Region

#Region "Drop CS Regular Font to System"
    Public pfc As New System.Drawing.Text.PrivateFontCollection()
    Public use_custom_font As Boolean = False
    Public Sub DropFont()
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
