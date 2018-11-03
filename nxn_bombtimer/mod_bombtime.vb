Module mod_bombtime
    Public Class on_bombtime_change
        Private bombtime_value As Integer = 0
        Public Event bombtime_changed(ByVal bombtime_value As Integer)
        Public Property bombtime() As Integer
            Get
                bombtime = bombtime_value
            End Get
            Set(ByVal value As Integer)
                bombtime_value = value
                RaiseEvent bombtime_changed(bombtime_value)
            End Set
        End Property


        Private bombplanted_value As Boolean = False
        Public Event bombplanted_changed(ByVal bombplanted_value As Boolean)
        Public Property bombplanted() As Boolean
            Get
                bombplanted = bombplanted_value
            End Get
            Set(ByVal value As Boolean)
                bombplanted_value = value
                RaiseEvent bombplanted_changed(bombplanted_value)
            End Set
        End Property
    End Class
End Module
