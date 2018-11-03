Imports System.Net
Module mod_licence
    Public ReadOnly Property is_licensed As Boolean
        Get
            Return is_licensed0
        End Get
    End Property
    Private is_licensed0 As Boolean = False

    Private Function checkConnection() As Boolean
        Try
            Dim i As New WebClient
            If i.DownloadString("http://nexn.systems/licence/nxn_bombtimer/alive.nxn").Contains("alive") Then
                checkConnection = True
            Else
                checkConnection = False
            End If
        Catch ex As Exception
            checkConnection = False
        End Try
        Return checkConnection
    End Function
    Public Sub check_licence_on_startup()
        Dim d = frm_main.Label3

        'Connection
        frm_main.Label3.Text = "Checking connection..."
        If Not checkConnection() Then
            MsgBox("Licence Server not reachable!" & vbCrLf & "Check Firewall settings and internet connection." & vbCrLf & "Running in trial mode.", MsgBoxStyle.Critical, application_name)
            d.Text = "TRIAL VERSION" & vbCrLf & vbCrLf
            d.ForeColor = Color.Red
            d.Font = New Font("Arial", 9, FontStyle.Bold)
            is_licensed0 = False
            frm_main.Button5.Enabled = False
            Exit Sub
        End If
        '# ###


        frm_main.Label3.Text = "Checking licence...."
        If My.Settings.licence.Length <= 0 Then
            d.Text = "TRIAL VERSION" & vbCrLf & vbCrLf
            d.ForeColor = Color.Red
            d.Font = New Font("Arial", 9, FontStyle.Bold)
            is_licensed0 = False
            frm_main.Button5.Enabled = False
        Else
            Dim i As New mod_licence
            With i
                .licence_key = My.Settings.licence
                .Start()
            End With

            If i.is_valid Then
                is_licensed0 = True
                Dim acc() As String = My.Settings.licence.Split("-")
                frm_main.TextBox1.Text = acc(0)
                frm_main.TextBox2.Text = acc(1)
                frm_main.TextBox3.Text = acc(2)
                frm_main.Button1.Enabled = False
                frm_main.Button6.Enabled = False
                frm_main.Button4.Enabled = False
                frm_main.Button5.Enabled = True
                d.Text = String.Format("Thanks for purchase!" & vbCrLf & vbCrLf &
                    "Licensed to: {0}" & vbCrLf &
                    "Valid till: {1}" & vbCrLf, i.licensed_to, i.valid_until)
                d.ForeColor = Color.Green
                d.Font = New Font("Arial", 8, FontStyle.Regular)
            Else
                If i.is_expired = False Then
                    d.Text = "INVALID LICENCE" & vbCrLf & vbCrLf &
                    "TRIAL MODE"
                    d.ForeColor = Color.Red
                    d.Font = New Font("Arial", 9, FontStyle.Bold)
                    is_licensed0 = False
                    My.Settings.licence = Nothing
                    My.Settings.Save()
                    frm_main.Button5.Enabled = False
                    frm_main.Button1.Enabled = True
                    frm_main.Button6.Enabled = True
                    frm_main.Button4.Enabled = True
                ElseIf i.is_expired = True Then
                    d.Text = "TRIAL VERSION" & vbCrLf & vbCrLf &
                        "LICENCE EXPIRED" & vbCrLf &
                        i.valid_until
                    d.ForeColor = Color.Red
                    d.Font = New Font("Arial", 9, FontStyle.Bold)
                    is_licensed0 = False
                    Dim acc() As String = My.Settings.licence.Split("-")
                    frm_main.TextBox1.Text = acc(0)
                    frm_main.TextBox2.Text = acc(1)
                    frm_main.TextBox3.Text = acc(2)
                    frm_main.Button5.Enabled = True
                    frm_main.Button1.Enabled = True
                    frm_main.Button6.Enabled = True
                    frm_main.Button4.Enabled = True
                End If

            End If
        End If
    End Sub
    Public Class mod_licence
        Private licence_url As String = "http://nexn.systems/licence/nxn_bombtimer/"

        Private conn As New WebClient
        Private WithEvents bg0 As New System.ComponentModel.BackgroundWorker
        Private owner As String = Nothing
        Private activatedOn As DateTime = Nothing
        Private validUntil As DateTime = Nothing
        Private licence As String = Nothing
        Public WriteOnly Property licence_key As String
            Set(ByVal value As String)
                licence = value
            End Set
        End Property
        Public ReadOnly Property is_valid As Boolean
            Get
                checkValidation()
                Return is_valid0
            End Get
        End Property
        Public ReadOnly Property is_expired As Boolean
            Get
                Return is_expired0
            End Get
        End Property
        Public ReadOnly Property licensed_to As String
            Get
                If owner Is Nothing Then
                    Return "Trial User"
                Else
                    Return owner
                End If
            End Get
        End Property
        Public ReadOnly Property actiated_on As DateTime
            Get
                Return activatedOn
            End Get
        End Property
        Public ReadOnly Property valid_until As DateTime
            Get
                Return validUntil
            End Get
        End Property
        Public Sub Start()
            bg0_dowork()
        End Sub
        Private Sub bg0_dowork() Handles bg0.DoWork
            Try
                Dim returnString() As String = conn.DownloadString(New System.Uri(licence_url & licence & ".nxn")).Split(vbCrLf)
                owner = returnString(0)
                activatedOn = ConvertTimestamp(returnString(1))
                validUntil = ConvertTimestamp(returnString(2))
            Catch ex As Exception
                Debug.Print(ex.Message)
            End Try
        End Sub

        Private is_expired0 As Boolean = False
        Private is_valid0 As Boolean = False
        Private Sub checkValidation()
            If validUntil = Nothing Then
                is_valid0 = False
                is_expired0 = False
                Exit Sub
            End If
            If validUntil.Subtract(DateTime.Now) <= New TimeSpan(0) Then
                is_expired0 = True
                is_valid0 = False
            Else
                is_valid0 = True
                is_expired0 = False
            End If
        End Sub
        Private Function ConvertTimestamp(ByVal timestamp As Double) As DateTime
            Return New DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(timestamp)
        End Function
    End Class
End Module
