Public Class frmScores

    Public Sub ScoreWindowConfig()
        'This configures the Score window depending on how many players are playing

        'If 2 players are selected it shrinks the window down to only show 2 players and moves the Buy/Action, Close and Re-Attach buttons
        If frmMenu.cmbPlayers.SelectedItem = "2" Then
            'This sets a new minimum size and maximum size for the score window (notice both the height and width values for MaximumSize and MinimumSize are the same, this is to disallow resizing this window)
            Me.MinimumSize = New Size(329, 581)
            Me.MaximumSize = New Size(329, 581)
            'This sets a new location for all the buttons on the form
            btnAction.Location = New Point(225, 434)
            btnAttach.Location = New Point(225, 481)
            btnClose.Location = New Point(225, 510)

            'This hides the information for Players 3 and 4
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
            'This is the information for player 3, as the Score Panel window is shown by default when the number of Players is above 2, re-sizing does not have to occur

            'This hides all the information for player 4
            lblPlayer4.Visible = False
            picPlayer4Color.Visible = False
            lblMoney4.Visible = False
            lblMoneyAmount4.Visible = False
            lblProps4.Visible = False
            cmbProperties4.Visible = False
            btnSell4.Visible = False
            btnTrade4.Visible = False

            'Hides the attach button as the score panel attached to the game window is no longer available when more than 2 players are selected
            btnAttach.Visible = False
        ElseIf frmMenu.cmbPlayers.SelectedItem = "4" Then
            '4 Players is the default for the Score Window, therefore nothing needs to be shown or hidden here.

            'Hides the attach button as the score panel attached to the game window is no longer available when more than 2 players are selected
            btnAttach.Visible = False
        End If
    End Sub
    Public Sub AttachPanel()
        'This is the code to re-attach the score panel to the game window

        'This changes the size of the game window to accommodate the score panel being re-attached
        frmGame.MaximumSize = New Size(frmGame.picBoard.Width + 337, frmGame.picBoard.Height)
        frmGame.Height = frmGame.picBoard.Height
        frmGame.Width = frmGame.picBoard.Width + 337

        'This shows all the buttons, labels and comboboxes for Players 1 and 2 (note; the option of re-attaching the score panel is unavailable when there are more than 2 players)
        frmGame.lblScorePanel.Visible = True
        frmGame.btnAction.Visible = False
        frmGame.btnClose.Visible = True
        frmGame.btnDetach.Visible = True
        frmGame.lblPlayer1.Visible = True
        frmGame.picPlayer1Color.Visible = True
        frmGame.lblMoney1.Visible = True
        frmGame.lblMoneyAmount1.Visible = True
        frmGame.lblProps1.Visible = True
        frmGame.cmbProperties1.Visible = True
        frmGame.btnSell1.Visible = True
        frmGame.btnTrade1.Visible = True
        frmGame.lblPlayer2.Visible = True
        frmGame.picPlayer2Color.Visible = True
        frmGame.lblMoney2.Visible = True
        frmGame.lblMoneyAmount2.Visible = True
        frmGame.lblProps2.Visible = True
        frmGame.cmbProperties2.Visible = True
        frmGame.btnSell2.Visible = True
        frmGame.btnTrade2.Visible = True
    End Sub

    Private Sub frmScores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'This calls the Subroutine that organizes how the Window will look under certain conditions, this is found above
        ScoreWindowConfig()
    End Sub

    Private Sub btnAttach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAttach.Click
        'This is the code to re-attach the score panel to the side of the game window

        'This sets the formula that will locate the button for detach on the game window
        Dim DetachX As Integer
        DetachX = frmGame.btnClose.Location.X - frmGame.btnDetach.Width / 3

        'This shows the detach button on the game window so the user can once again, if desired, detach the game form.
        frmGame.btnDetach.Visible = True
        'This sets the location of the detach button, DetachX being the value that was given a formula above
        frmGame.btnDetach.Location = New Point(DetachX, 793)
        'This calls the Subroutine used to re-size the Game window to accommodate the score panel being re-attached
        AttachPanel()
        'This sets the form height to + 1 to initiate all the size settings on the game form
        frmGame.Height = frmGame.Height + 1
        'and finally this hides the Score Window form
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        'This closes the program once Close is clicked
        End
    End Sub
End Class