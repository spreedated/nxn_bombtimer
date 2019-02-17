Module Mod_Appprop
    Private version As String = "140"
    Private ReadOnly name As String = "CS:GO C4.Timer"


    Public application_name As String = name & " " & Get_versionstring()

    Private Function Get_versionstring() As String
        Get_versionstring = Nothing
        For Each i In version
            Get_versionstring += "." & i
        Next
        Get_versionstring = Get_versionstring.Substring(1, Get_versionstring.Length - 1)
        If version.Length >= 4 Then
            Dim dotcount As Short = 0
            For Each integ In version
                dotcount += 1
            Next
            For i = 0 To dotcount - 4
                Get_versionstring = Get_versionstring.Remove(Get_versionstring.IndexOf("."), 1)
            Next
        End If
        Return Get_versionstring
    End Function

End Module
