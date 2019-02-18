Public Class Frm_Overlay

    Private scr_x As Integer = My.Computer.Screen.Bounds.Width
    Private scr_y As Integer = My.Computer.Screen.Bounds.Height

    'Custom CS:GO Font
    Private ReadOnly CSGOFont As Font = Mod_CustomFont.GetInstance(24, FontStyle.Regular, My.Resources.cs_regular)

    Private Sub Frm_Overlay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .Location = New Point((scr_x / 2) - (136 / 2), 55)
        End With

        With Lbl_Time
            .Font = CSGOFont
        End With

        ' Rounded Edges
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Me.Width, Me.Height, 15, 15))
    End Sub


End Class