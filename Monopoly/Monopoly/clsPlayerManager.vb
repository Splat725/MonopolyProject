Public Class clsPlayerManager
    Public Sub New()
        '' 
    End Sub

    Public ReadOnly Property PlayerList As Collection
        Get
            Static colPlayerList As Collection

            If colPlayerList Is Nothing Then colPlayerList = New Collection()
            Return colPlayerList
        End Get
    End Property
End Class
