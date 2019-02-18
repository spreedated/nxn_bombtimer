Imports System.Reflection.Assembly
Module Mod_AppProperties
    Private ReadOnly AppVersionNum As UShort = AssemblyVersionToShort()
    Private ReadOnly AppNameWithoutVersion As String = "nXn - BombTimer"

    Public Function AppName() As String
        Return AppNameWithoutVersion & " v" & AppVersionToString()
    End Function

    Private Function AppVersionToString() As String
        Dim acc As String = Nothing
        For Each item As Char In AppVersionNum.ToString()
            acc += item & "."
        Next
        acc = acc.TrimEnd(".")
        Return acc
    End Function

    Private Function AssemblyVersionToShort() As UShort
        Dim acc As String = GetEntryAssembly.FullName
        acc = acc.Substring(acc.ToLower.IndexOf("version") + 8)
        acc = acc.Substring(0, acc.IndexOf(","))
        acc = acc.Replace(".", "")
        Dim bac As UShort = Convert.ToUInt16(acc)
        Return bac
    End Function
End Module
