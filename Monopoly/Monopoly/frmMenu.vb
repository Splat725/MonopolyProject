Public Class frmMenu
    Public Sub ComboxSett()

        'This sets all the combo boxes to their default values from the moment the Window loads, it is called in the Sub that controls Form Load
        cmbPlayers.Text = 2
        cmbColour1.Text = "Green"
        cmbColour2.Text = "Green"
        cmbColour3.Text = "Green"
        cmbColour4.Text = "Green"
        cmbDifficulty1.Text = "Normal"
        cmbDifficulty2.Text = "Normal"
        cmbDifficulty3.Text = "Normal"
        cmbDifficulty4.Text = "Normal"
    End Sub
    Public Sub ScorBrdSett()
        'This code hides all the stuff and shrinks the form, to make way for the Score Window to show and replace the Score panel

        'This sets the height and Width of the form to match the height and width of the board (it is assumed here that when this Subroutine is called, the Scores Window is shown after)
        frmGame.Height = frmGame.picBoard.Height
        frmGame.Width = frmGame.picBoard.Width

        'Hides all the labels, buttons, and comboboxes assosiated with the Score Panel on the Side of the game form
        frmGame.lblScorePanel.Visible = False
        frmGame.btnAction.Visible = False
        frmGame.btnClose.Visible = False
        frmGame.btnDetach.Visible = False
        frmGame.lblPlayer1.Visible = False
        frmGame.picPlayer1Color.Visible = False
        frmGame.lblMoney1.Visible = False
        frmGame.lblMoneyAmount1.Visible = False
        frmGame.lblProps1.Visible = False
        frmGame.cmbProperties1.Visible = False
        frmGame.btnSell1.Visible = False
        frmGame.btnTrade1.Visible = False
        frmGame.lblPlayer2.Visible = False
        frmGame.picPlayer2Color.Visible = False
        frmGame.lblMoney2.Visible = False
        frmGame.lblMoneyAmount2.Visible = False
        frmGame.lblProps2.Visible = False
        frmGame.cmbProperties2.Visible = False
        frmGame.btnSell2.Visible = False
        frmGame.btnTrade2.Visible = False
    End Sub

    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'This sets the height and width of the form the moment it loads
        Me.Width = 500
        Me.Height = 462

        'This sets the location in which the buttons for close and the buttons for begin
        btnClose.Location = New Point(12, 399)
        btnBegin.Location = New Point(407, 399)

        'This hides all the labels for Player 3 as Player 3 and Player 4 are not shown by default
        lblPlayer3.Visible = False
        lblName3.Visible = False
        lblDifficulty3.Visible = False
        lblColour3.Visible = False
        txtName3.Visible = False
        cmbColour3.Visible = False
        cmbDifficulty3.Visible = False

        'This hides all the labels for Player 4 as Player 3 and Player 4 are not shown by default
        lblPlayer4.Visible = False
        lblName4.Visible = False
        lblDifficulty4.Visible = False
        lblColour4.Visible = False
        txtName4.Visible = False
        cmbColour4.Visible = False
        cmbDifficulty4.Visible = False

        'This is a call to the subroutine above that sets all the combo boxes to their default values
        ComboxSett()
    End Sub

    Private Sub cmbPlayers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlayers.SelectedIndexChanged
        'All this code is to Hide and Show the various Player options when more or less players have been selected

        'Hides the options for players 3 and 4 when 2 is selected
        If cmbPlayers.SelectedItem = "2" Then
            'Crops the Window to the size required for only the options relating to 2 Players
            Me.MaximumSize = New Size(500, 462)
            Me.Width = 500
            Me.Height = 462


            'Sets the Close and Begin button to a new location to meet that of the new form size
            btnClose.Location = New Point(12, 399)
            btnBegin.Location = New Point(407, 399)

            'Hides all the options for Player 3
            lblPlayer3.Visible = False
            lblName3.Visible = False
            lblDifficulty3.Visible = False
            lblColour3.Visible = False
            txtName3.Visible = False
            cmbColour3.Visible = False
            cmbDifficulty3.Visible = False

            'Hides all the options for Player 4
            lblPlayer4.Visible = False
            lblName4.Visible = False
            lblDifficulty4.Visible = False
            lblColour4.Visible = False
            txtName4.Visible = False
            cmbColour4.Visible = False
            cmbDifficulty4.Visible = False

        ElseIf cmbPlayers.SelectedItem = "3" Then

            'Sets the form size to accommodate options for 3 players 
            Me.MaximumSize = New Size(500, 607)
            Me.Width = 500
            Me.Height = 607

            'Sets the location of the buttons match that of the new form size
            btnClose.Location = New Point(12, 544)
            btnBegin.Location = New Point(407, 544)

            'Shows all the options for Player 3
            lblPlayer3.Visible = True
            lblName3.Visible = True
            lblDifficulty3.Visible = True
            lblColour3.Visible = True
            txtName3.Visible = True
            cmbColour3.Visible = True
            cmbDifficulty3.Visible = True

            'Hides all the options for Player 4
            lblPlayer4.Visible = False
            lblName4.Visible = False
            lblDifficulty4.Visible = False
            lblColour4.Visible = False
            txtName4.Visible = False
            cmbColour4.Visible = False
            cmbDifficulty4.Visible = False

        ElseIf cmbPlayers.SelectedItem = "4" Then
            'Resizes the form to accommodate the new options
            Me.MaximumSize = New Size(500, 763)
            Me.Width = 500
            Me.Height = 763

            'Relocates the buttons due to the change in form size
            btnClose.Location = New Point(12, 700)
            btnBegin.Location = New Point(407, 700)

            'Shows the options for Player 3
            lblPlayer3.Visible = True
            lblName3.Visible = True
            lblDifficulty3.Visible = True
            lblColour3.Visible = True
            txtName3.Visible = True
            cmbColour3.Visible = True
            cmbDifficulty3.Visible = True

            'Shows the options for Player 4
            lblPlayer4.Visible = True
            lblName4.Visible = True
            lblDifficulty4.Visible = True
            lblColour4.Visible = True
            txtName4.Visible = True
            cmbColour4.Visible = True
            cmbDifficulty4.Visible = True
        End If
    End Sub

    Private Sub btnBegin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBegin.Click
        'Hides the Menu Window
        Me.Hide()

        If cmbPlayers.SelectedItem = "2" Then
            'If only 2 players are selected then the score panel appears attached to game window and only the game window is shown
            frmGame.Show()
        Else
            'If more than 2 players have been selected then it shows the score window and the game window seperately
            frmScores.Show()
            'This called the subroutine that will resize the game form to just include only the board
            ScorBrdSett()
            'This shows the window for the board
            frmGame.Show()
        End If
       

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        'This ends the program when close is clicked
        End
    End Sub
End Class