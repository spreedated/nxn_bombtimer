Imports System.Drawing.Text
Imports System.Runtime.InteropServices
Module Mod_CustomFont
    'Add this to ApplictionEvents.vb
    '
    'Protected Overloads Shared ReadOnly Property UseCompatibleTextRendering() As Boolean
    '    Get
    '        ' Use the GDI+ text rendering engine.  
    '        Return True
    '    End Get
    'End Property


    'PRIVATE FONT COLLECTION TO HOLD THE DYNAMIC FONT
    Private _pfc As PrivateFontCollection = Nothing

    Public ReadOnly Property GetInstance(ByVal Size As Single, ByVal style As FontStyle, ByVal FontFromResource As Byte()) As Font
        Get
            If _pfc Is Nothing Then LoadFont(FontFromResource)
            Return New Font(_pfc.Families(0), Size, style)
        End Get
    End Property

    Private Sub LoadFont(ByVal FontFromResource As Byte())
        Try
            _pfc = New PrivateFontCollection

            'LOAD MEMORY POINTER FOR FONT RESOURCE
            Dim fontMemPointer As IntPtr =
            Marshal.AllocCoTaskMem(
            FontFromResource.Length)

            'COPY THE DATA TO THE MEMORY LOCATION
            Marshal.Copy(FontFromResource, 0, fontMemPointer, FontFromResource.Length)

            'LOAD THE MEMORY FONT INTO THE PRIVATE FONT COLLECTION
            _pfc.AddMemoryFont(fontMemPointer, FontFromResource.Length)


            'FREE UNSAFE MEMORY
            Marshal.FreeCoTaskMem(fontMemPointer)
        Catch ex As Exception
            'ERROR LOADING FONT. HANDLE EXCEPTION HERE
        End Try
    End Sub
End Module
