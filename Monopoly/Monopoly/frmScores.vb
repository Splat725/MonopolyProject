Public Class frmScores

    Private Sub frmScores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If frmMenu.cmbPlayers.SelectedItem = "2" Then
            Me.MinimumSize = New Size(329, 581)
            Me.MaximumSize = New Size(329, 581)
            btnAction.Location = New Point(225, 434)
            btnAttach.Location = New Point(225, 481)
            btnClose.Location = New Point(225, 510)

            lblPlayer3.Visible = False
            picPlayer3Color.Visible = False
            lblMoney3.Visible = False
            lblMoneyAmount3.Visible = False
            lblProps3.Visible = False
            cmbProperties3.Visible = False
            btnSell3.Visible = False
            btnTrade3.Visible = False
            lblPlayer4.Visible = False
            picPlayer4Color.Visible = False
            lblMoney4.Visible = False
            lblMoneyAmount4.Visible = False
            lblProps4.Visible = False
            cmbProperties4.Visible = False
            btnSell4.Visible = False
            btnTrade4.Visible = False
        ElseIf frmMenu.cmbPlayers.SelectedItem = "3" Then

            lblPlayer4.Visible = False
            picPlayer4Color.Visible = False
            lblMoney4.Visible = False
            lblMoneyAmount4.Visible = False
            lblProps4.Visible = False
            cmbProperties4.Visible = False
            btnSell4.Visible = False
            btnTrade4.Visible = False
        ElseIf frmMenu.cmbPlayers.SelectedItem = "4" Then

        End If

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

        If frmMenu.txtName3.Text = "" Then
            lblPlayer3.Text = "Player 3"
        Else
            lblPlayer3.Text = frmMenu.txtName2.Text
        End If

        If frmMenu.txtName4.Text = "" Then
            lblPlayer4.Text = "Player 4"
        Else
            lblPlayer4.Text = frmMenu.txtName2.Text
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
        If frmMenu.cmbDifficulty3.SelectedItem = "Easy" Then
            lblMoneyAmount3.Text = 2000
        ElseIf frmMenu.cmbDifficulty3.SelectedItem = "Normal" Then
            lblMoneyAmount3.Text = 1500
        ElseIf frmMenu.cmbDifficulty3.SelectedItem = "Hard" Then
            lblMoneyAmount3.Text = 1000
        Else
            lblMoneyAmount3.Text = 1500
        End If
        If frmMenu.cmbDifficulty4.SelectedItem = "Easy" Then
            lblMoneyAmount4.Text = 2000
        ElseIf frmMenu.cmbDifficulty4.SelectedItem = "Normal" Then
            lblMoneyAmount4.Text = 1500
        ElseIf frmMenu.cmbDifficulty4.SelectedItem = "Hard" Then
            lblMoneyAmount4.Text = 1000
        Else
            lblMoneyAmount4.Text = 1500
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        End
    End Sub
End Class