Public Class frmGame


    Private Sub frmGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If frmMenu.txtName1.Text = "" Then
            lblPlayer1.Text = "Player1"
        Else
            lblPlayer1.Text = frmMenu.txtName1.Text
        End If
        If frmMenu.txtName2.Text = "" Then
            lblPlayer2.Text = "Player 2"
        Else
            lblPlayer2.Text = frmMenu.txtName2.Text
        End If




        If frmMenu.cmbDifficulty1.SelectedItem = "Easy" Then
            lblMoneyAmount1.Text = 2000
        ElseIf frmMenu.cmbDifficulty1.SelectedItem = "Normal" Then
            lblMoneyAmount1.Text = 1500
        ElseIf frmMenu.cmbDifficulty1.SelectedItem = "Hard" Then
            lblMoneyAmount1.Text = 1000
        Else
            lblMoneyAmount1.Text = 1500
        End If
        If frmMenu.cmbDifficulty2.SelectedItem = "Easy" Then
            lblMoneyAmount2.Text = 2000
        ElseIf frmMenu.cmbDifficulty2.SelectedItem = "Normal" Then
            lblMoneyAmount2.Text = 1500
        ElseIf frmMenu.cmbDifficulty2.SelectedItem = "Hard" Then
            lblMoneyAmount2.Text = 1000
        Else
            lblMoneyAmount2.Text = 1500
        End If



    End Sub

    Private Sub frmGame_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        picBoard.Height = Me.Height - 40
        picBoard.Width = Me.Height - 40
        Dim CloseX As Integer
        Dim CloseY As Integer
        Dim ActionX As Integer
        Dim ActionY As Integer
        CloseX = Me.Width - btnClose.Width - 30
        CloseY = Me.Height - btnClose.Height - 50
        ActionX = picBoard.Width + 30
        ActionY = Me.Height - btnAction.Height - 50

        lblScorePanel.Left = picBoard.Width + 26
        btnAction.Location = New Point(ActionX, ActionY)
        btnClose.Location = New Point(CloseX, CloseY)

        lblPlayer1.Left = picBoard.Width + 30
        picPlayer1Color.Left = lblPlayer1.Location.X + lblPlayer1.Width + 50
        lblMoney1.Left = picBoard.Width + 30
        lblMoneyAmount1.Left = lblMoney1.Location.X + lblMoney1.Width + 12
        lblProps1.Left = picBoard.Width + 30
        cmbProperties1.Left = picBoard.Width + 30
        btnSell1.Left = picBoard.Width + 30
        btnTrade1.Left = btnSell1.Location.X + btnSell1.Width + 24

        lblPlayer2.Left = picBoard.Width + 30
        picPlayer2Color.Left = lblPlayer2.Location.X + lblPlayer2.Width + 50
        lblMoney2.Left = picBoard.Width + 30
        lblMoneyAmount2.Left = lblMoney2.Location.X + lblMoney2.Width + 12
        lblProps2.Left = picBoard.Width + 30
        cmbProperties2.Left = picBoard.Width + 30
        btnSell2.Left = picBoard.Width + 30
        btnTrade2.Left = btnSell2.Location.X + btnSell2.Width + 24

    End Sub

    Private Sub btnDetach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetach.Click
        frmMenu.ScorBrdSett()
        frmScores.Show()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        End
    End Sub
End Class