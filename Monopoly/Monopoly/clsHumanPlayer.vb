Public Class clsHumanPlayer
    Inherits clsPlayer

    Public Sub New(Optional txtTheNewName As String = "")
        MyBase.New(EPlayerType.Human, txtTheNewName)
    End Sub
End Class
