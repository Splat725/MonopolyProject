Public Class frmGame



    Public Sub PlayerColors()
        'Sets all the Colour for player one depending on what they chose in the menu.
        If frmMenu.cmbColour1.SelectedItem = "Green" Then
            picPlayer1Color.BackColor = Color.Green
            frmScores.picPlayer1Color.BackColor = Color.Green
        ElseIf frmMenu.cmbColour1.SelectedItem = "Lime" Then
            picPlayer1Color.BackColor = Color.Lime
            frmScores.lblPlayer1.BackColor = Color.Lime
        ElseIf frmMenu.cmbColour1.SelectedItem = "Maroon" Then
            picPlayer1Color.BackColor = Color.Maroon
            frmScores.lblPlayer1.BackColor = Color.Maroon
        ElseIf frmMenu.cmbColour1.SelectedItem = "Red" Then
            picPlayer1Color.BackColor = Color.Red
            frmScores.lblPlayer1.BackColor = Color.Red
        ElseIf frmMenu.cmbColour1.SelectedItem = "Orange" Then
            picPlayer1Color.BackColor = Color.Orange
            frmScores.lblPlayer1.BackColor = Color.Orange
        ElseIf frmMenu.cmbColour1.SelectedItem = "Navy" Then
            picPlayer1Color.BackColor = Color.Navy
            frmScores.lblPlayer1.BackColor = Color.Navy
        ElseIf frmMenu.cmbColour1.SelectedItem = "Lime" Then
            picPlayer1Color.BackColor = Color.Blue
            frmScores.lblPlayer1.BackColor = Color.Blue
        ElseIf frmMenu.cmbColour1.SelectedItem = "Purple" Then
            picPlayer1Color.BackColor = Color.Purple
            frmScores.lblPlayer1.BackColor = Color.Purple
        ElseIf frmMenu.cmbColour1.SelectedItem = "Pink" Then
            picPlayer1Color.BackColor = Color.Pink
            frmScores.lblPlayer1.BackColor = Color.Pink
        Else
            picPlayer1Color.BackColor = Color.Green
            frmScores.picPlayer1Color.BackColor = Color.Green
        End If
        'Sets all the Colour for player two depending on what they chose in the menu.
        If frmMenu.cmbColour2.SelectedItem = "Green" Then
            picPlayer2Color.BackColor = Color.Green
            frmScores.picPlayer2Color.BackColor = Color.Green
        ElseIf frmMenu.cmbColour2.SelectedItem = "Lime" Then
            picPlayer2Color.BackColor = Color.Lime
            frmScores.lblPlayer2.BackColor = Color.Lime
        ElseIf frmMenu.cmbColour2.SelectedItem = "Maroon" Then
            picPlayer2Color.BackColor = Color.Maroon
            frmScores.lblPlayer2.BackColor = Color.Maroon
        ElseIf frmMenu.cmbColour2.SelectedItem = "Red" Then
            picPlayer2Color.BackColor = Color.Red
            frmScores.lblPlayer2.BackColor = Color.Red
        ElseIf frmMenu.cmbColour2.SelectedItem = "Orange" Then
            picPlayer2Color.BackColor = Color.Orange
            frmScores.lblPlayer2.BackColor = Color.Orange
        ElseIf frmMenu.cmbColour2.SelectedItem = "Navy" Then
            picPlayer2Color.BackColor = Color.Navy
            frmScores.lblPlayer2.BackColor = Color.Navy
        ElseIf frmMenu.cmbColour2.SelectedItem = "Lime" Then
            picPlayer2Color.BackColor = Color.Blue
            frmScores.lblPlayer2.BackColor = Color.Blue
        ElseIf frmMenu.cmbColour2.SelectedItem = "Purple" Then
            picPlayer2Color.BackColor = Color.Purple
            frmScores.lblPlayer2.BackColor = Color.Purple
        ElseIf frmMenu.cmbColour2.SelectedItem = "Pink" Then
            picPlayer2Color.BackColor = Color.Pink
            frmScores.lblPlayer2.BackColor = Color.Pink
        Else
            picPlayer2Color.BackColor = Color.Green
            frmScores.picPlayer2Color.BackColor = Color.Green
        End If

        'Sets all the Colour for player three depending on what they chose in the menu.
        If frmMenu.cmbColour3.SelectedItem = "Green" Then
            frmScores.picPlayer3Color.BackColor = Color.Green
        ElseIf frmMenu.cmbColour3.SelectedItem = "Lime" Then
            frmScores.lblPlayer3.BackColor = Color.Lime
        ElseIf frmMenu.cmbColour3.SelectedItem = "Maroon" Then
            frmScores.lblPlayer3.BackColor = Color.Maroon
        ElseIf frmMenu.cmbColour3.SelectedItem = "Red" Then
            frmScores.lblPlayer3.BackColor = Color.Red
        ElseIf frmMenu.cmbColour3.SelectedItem = "Orange" Then
            frmScores.lblPlayer3.BackColor = Color.Orange
        ElseIf frmMenu.cmbColour3.SelectedItem = "Navy" Then
            frmScores.lblPlayer3.BackColor = Color.Navy
        ElseIf frmMenu.cmbColour3.SelectedItem = "Lime" Then
            frmScores.lblPlayer3.BackColor = Color.Blue
        ElseIf frmMenu.cmbColour3.SelectedItem = "Purple" Then
            frmScores.lblPlayer3.BackColor = Color.Purple
        ElseIf frmMenu.cmbColour3.SelectedItem = "Pink" Then
            frmScores.lblPlayer3.BackColor = Color.Pink
        Else
            frmScores.picPlayer3Color.BackColor = Color.Green
        End If
        'Sets all the Colour for player four depending on what they chose in the menu.
        If frmMenu.cmbColour4.SelectedItem = "Green" Then
            frmScores.picPlayer4Color.BackColor = Color.Green
        ElseIf frmMenu.cmbColour4.SelectedItem = "Lime" Then
            frmScores.lblPlayer4.BackColor = Color.Lime
        ElseIf frmMenu.cmbColour4.SelectedItem = "Maroon" Then
            frmScores.lblPlayer4.BackColor = Color.Maroon
        ElseIf frmMenu.cmbColour4.SelectedItem = "Red" Then
            frmScores.lblPlayer4.BackColor = Color.Red
        ElseIf frmMenu.cmbColour4.SelectedItem = "Orange" Then
            frmScores.lblPlayer4.BackColor = Color.Orange
        ElseIf frmMenu.cmbColour4.SelectedItem = "Navy" Then
            frmScores.lblPlayer4.BackColor = Color.Navy
        ElseIf frmMenu.cmbColour4.SelectedItem = "Lime" Then
            frmScores.lblPlayer4.BackColor = Color.Blue
        ElseIf frmMenu.cmbColour4.SelectedItem = "Purple" Then
            frmScores.lblPlayer4.BackColor = Color.Purple
        ElseIf frmMenu.cmbColour4.SelectedItem = "Pink" Then
            frmScores.lblPlayer4.BackColor = Color.Pink
        Else
            frmScores.picPlayer4Color.BackColor = Color.Green
        End If
    End Sub

    Public Sub PlayerNames()
        'Sets the name as selected by player 1 in the menu form
        'If no name was entered, it uses the default name 'Player 1'
        If frmMenu.txtName1.Text = "" Then
            lblPlayer1.Text = "Player1"
            frmScores.lblPlayer1.Text = "Player 1"
        Else
            lblPlayer1.Text = frmMenu.txtName1.Text
            frmScores.lblPlayer1.Text = frmMenu.txtName1.Text
        End If
        'Sets the name as selected by player 2 in the menu form
        'If no name was entered, it uses the default name 'Player 2'
        If frmMenu.txtName2.Text = "" Then
            lblPlayer2.Text = "Player 2"
            frmScores.lblPlayer2.Text = "Player2"
        Else
            lblPlayer2.Text = frmMenu.txtName2.Text
            frmScores.lblPlayer2.Text = frmMenu.txtName2.Text
        End If
        'Sets the name as selected by player 3 in the menu form
        'If no name was entered, it uses the default name 'Player 3'
        If frmMenu.txtName3.Text = "" Then
            frmScores.lblPlayer3.Text = "Player 3"
        Else
            frmScores.lblPlayer3.Text = frmMenu.txtName3.Text
        End If
        'Sets the name as selected by player 4 in the menu form
        'If no name was entered, it uses the default name 'Player 4'
        If frmMenu.txtName4.Text = "" Then
            frmScores.lblPlayer4.Text = "Player 4"
        Else
            frmScores.lblPlayer4.Text = frmMenu.txtName4.Text
        End If
    End Sub

    Public Sub PlayerDifficulties()
        'Sets the starting money for the corresponding difficulties as chosen by Player 1
        If frmMenu.cmbDifficulty1.SelectedItem = "Easy" Then
            lblMoneyAmount1.Text = 2000
            frmScores.lblMoneyAmount1.Text = 2000
        ElseIf frmMenu.cmbDifficulty1.SelectedItem = "Normal" Then
            lblMoneyAmount1.Text = 1500
            frmScores.lblMoneyAmount1.Text = 1500
        ElseIf frmMenu.cmbDifficulty1.SelectedItem = "Hard" Then
            lblMoneyAmount1.Text = 1000
            frmScores.lblMoneyAmount1.Text = 1000
        Else
            lblMoneyAmount1.Text = 1500
            frmScores.lblMoneyAmount1.Text = 1500
        End If

        'Sets the starting money for the corresponding difficulties as chosen by Player 2
        If frmMenu.cmbDifficulty2.SelectedItem = "Easy" Then
            lblMoneyAmount2.Text = 2000
            frmScores.lblMoneyAmount2.Text = 2000
        ElseIf frmMenu.cmbDifficulty2.SelectedItem = "Normal" Then
            lblMoneyAmount2.Text = 1500
            frmScores.lblMoneyAmount2.Text = 1500
        ElseIf frmMenu.cmbDifficulty2.SelectedItem = "Hard" Then
            lblMoneyAmount2.Text = 1000
            frmScores.lblMoneyAmount2.Text = 1000
        Else
            lblMoneyAmount2.Text = 1500
            frmScores.lblMoneyAmount2.Text = 1500
        End If

        'Sets the starting money for the corresponding difficulties as chosen by Player 3
        If frmMenu.cmbDifficulty3.SelectedItem = "Easy" Then
            frmScores.lblMoneyAmount3.Text = 2000
        ElseIf frmMenu.cmbDifficulty3.SelectedItem = "Normal" Then
            frmScores.lblMoneyAmount3.Text = 1500
        ElseIf frmMenu.cmbDifficulty3.SelectedItem = "Hard" Then
            frmScores.lblMoneyAmount3.Text = 1000
        Else
            frmScores.lblMoneyAmount3.Text = 1500
        End If

        'Sets the starting money for the corresponding difficulties as chosen by Player 4
        If frmMenu.cmbDifficulty4.SelectedItem = "Easy" Then
            frmScores.lblMoneyAmount4.Text = 2000
        ElseIf frmMenu.cmbDifficulty4.SelectedItem = "Normal" Then
            frmScores.lblMoneyAmount4.Text = 1500
        ElseIf frmMenu.cmbDifficulty4.SelectedItem = "Hard" Then
            frmScores.lblMoneyAmount4.Text = 1000
        Else
            frmScores.lblMoneyAmount4.Text = 1500
        End If
    End Sub


    Private Sub frmGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Calls the Subroutines above
        PlayerNames()
        PlayerDifficulties()
        PlayerColors()
    End Sub

    Private Sub frmGame_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        'All the modifications to object locations and sizes when the form size is modified are here

        'This sets the height for the picture box
        If frmScores.Visible = True Then
            'This is the dimensions for the board when the score panel is detached
            picBoard.Height = Me.Height - 40
            picBoard.Width = Me.Width - 18
        Else
            'This is the dimensions for the board when the score panel is still attached
            picBoard.Height = Me.Height - 40
            picBoard.Width = Me.Height - 50
        End If

        'These are all dimmed locations for all the X and Y values of the Control buttons on the form, Close, Action/Buy, Detach
        'I did this because having them directly inseted into code was stressing and confusing, this made it easier to fix problems bit by bit
        Dim CloseX As Integer
        Dim CloseY As Integer
        Dim ActionX As Integer
        Dim ActionY As Integer
        Dim DetachX As Integer
        Dim DetachY As Integer

        'These are all the equations and code used for all of the above, each buttons X and Y formula
        CloseX = Me.Width - btnClose.Width - 30
        CloseY = Me.Height - btnClose.Height - 50
        ActionX = picBoard.Width + 30
        ActionY = Me.Height - btnAction.Height - 50
        DetachX = btnClose.Location.X - btnDetach.Width / 3
        DetachY = btnClose.Location.Y - btnDetach.Height - 10

        'This is the location of the score panel, which is located at the very top of the form on the right hand side (when the score panel is attached)
        lblScorePanel.Left = picBoard.Width + 26

        'This is all of the locations for the control buttons (Close, Action/Buy, Detached
        'As you can also see, this is where the dimmed values above are located, you should also be able to see right away why writing in the formula here for each would get confusing
        btnAction.Location = New Point(ActionX, ActionY)
        btnClose.Location = New Point(CloseX, CloseY)
        btnDetach.Location = New Point(DetachX, DetachY)

        'Locations for all of the labels, buttons, comboboxes for Player 1
        lblPlayer1.Left = picBoard.Width + 30
        picPlayer1Color.Left = lblPlayer1.Location.X + lblPlayer1.Width + 50
        lblMoney1.Left = picBoard.Width + 30
        lblMoneyAmount1.Left = lblMoney1.Location.X + lblMoney1.Width + 12
        lblProps1.Left = picBoard.Width + 30
        cmbProperties1.Left = picBoard.Width + 30
        btnSell1.Left = picBoard.Width + 30
        btnTrade1.Left = btnSell1.Location.X + btnSell1.Width + 24

        'Locations for all the labels, buttons, comboboxes for Player 2
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
        'What happens when the 'Detach' button is clicked

        'Calls a Subroutine from the frmMenu, this is used to hide all the buttons, labels comboboxes, ect. from the Game form
        frmMenu.ScorBrdSett()
        'Shows the Score Panel Window
        frmScores.Show()
        'Sets the new size for the Board window
        Me.Size = New Size(900, 900)
        'Sets the new minimum size for the Board window
        Me.MinimumSize = New Size(895, 895)
        'Removes the maximum size of the Board window 
        ' (note to all new coders, setting to (0, 0) in this situation removes the limit and does not mean the maximum size is now 0 x 0)
        Me.MaximumSize = New Size(0, 0)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        'Ends the program once clicked
        End
    End Sub
End Class