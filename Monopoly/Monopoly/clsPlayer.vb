Public Class clsPlayer
    Public Enum EPlayerState
        Living
        Dead
    End Enum

    Public Enum EPlayerType
        Undefined
        Human
        Computer
        Network
    End Enum

    Protected txtName As String
    Protected lngCash As Long
    Protected enuState As EPlayerState
    Protected enuPlayerType As EPlayerType

    Public Sub New(enuNewPlayerType As EPlayerType, Optional txtNewName As String = "")
        Me.State = EPlayerState.Living
        Me.enuPlayerType = enuNewPlayerType
        Me.PlayerName = txtNewName
    End Sub

    Public Property State As EPlayerState
        Get
            Return Me.enuState
        End Get
        Set(value As EPlayerState)
            Me.enuState = value
        End Set
    End Property

    Public Property PlayerName
        Get
            Return Me.txtName
        End Get
        Set(value)
            Me.txtName = value
        End Set
    End Property

    Public ReadOnly Property PlayerType As EPlayerType
        Get
            Return EPlayerType.Undefined
        End Get
    End Property
End Class

