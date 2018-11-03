Module mod_appprop
    Private version As String = "125"
    Private name As String = "CS:GO C4.Timer"


    Public application_name As String = name & " " & get_versionstring()

    Private Function get_versionstring() As String
        get_versionstring = Nothing
        For Each i In version
            get_versionstring += "." & i
        Next
        get_versionstring = get_versionstring.Substring(1, get_versionstring.Length - 1)
        If version.Length >= 4 Then
            Dim dotcount As Short = 0
            For Each integ In version
                dotcount += 1
            Next
            For i = 0 To dotcount - 4
                get_versionstring = get_versionstring.Remove(get_versionstring.IndexOf("."), 1)
            Next
        End If
        Return get_versionstring
    End Function

End Module
