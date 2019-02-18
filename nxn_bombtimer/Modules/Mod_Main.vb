Imports System.Runtime.InteropServices
Module Mod_Main
    ' Rounded Edges
    <DllImport("gdi32.dll")>
    Public Function CreateRoundRectRgn(ByVal x1 As Integer, ByVal y1 As Integer, ByVal x2 As Integer, ByVal y2 As Integer, ByVal cx As Integer, ByVal cy As Integer) As IntPtr
    End Function
    ' ###
End Module
