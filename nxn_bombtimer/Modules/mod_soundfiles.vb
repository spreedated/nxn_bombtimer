Imports Ionic
Imports Ionic.Zip
Module Mod_Soundfiles
    Public Sub ZipFile(ByVal path As String, ByVal file As String)
        Dim b As New Ionic.Zip.ZipFile
        With b
            .Encryption = EncryptionAlgorithm.WinZipAes256
            .Password = "nxn_bombtimerpass"
            '.CompressionLevel = Zlib.CompressionLevel.BestCompression
            For i = 0 To 9
                .AddFile("C:\Users\SpReeD\Documents\Visual Studio 2017\Projects\nxn_bombtimer\resources\ut99\ut99_" & (i + 1) & ".mp3", "")
            Next
            .Save("C:\Users\SpReeD\Documents\Visual Studio 2017\Projects\nxn_bombtimer\resources\ut99\test.zip")

        End With

    End Sub

    Public Sub UnzipFile()
        Using zip As New ZipFile("C:\Users\SpReeD\Documents\Visual Studio 2017\Projects\nxn_bombtimer\resources\ut99\ut99.nxn")
            Dim e As ZipEntry
            For Each e In zip
                If (e.UsesEncryption) Then
                    e.ExtractWithPassword("C:\Users\SpReeD\Documents\Visual Studio 2017\Projects\nxn_bombtimer\resources\ut99\sound", ExtractExistingFileAction.OverwriteSilently, "nxn_bombtimerpass")
                Else
                    e.Extract("C:\Users\SpReeD\Documents\Visual Studio 2017\Projects\nxn_bombtimer\resources\ut99\sound")
                End If
            Next
        End Using
    End Sub
End Module
