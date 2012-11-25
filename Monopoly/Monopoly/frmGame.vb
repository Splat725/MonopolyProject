Public Class frmGame
    
    Public Sub Locations()
        Dim loc1_1 As New Point(770, 825)
        Dim loc2_1 As New Point
        Dim loc3_1 As New Point
        Dim loc4_1 As New Point
        Dim loc5_1 As New Point
        Dim loc6_1 As New Point
        Dim loc7_1 As New Point
        Dim loc8_1 As New Point
        Dim loc9_1 As New Point
        Dim loc10_1 As New Point
        Dim loc11_1 As New Point
        Dim loc12_1 As New Point
        Dim loc13_1 As New Point
        Dim loc14_1 As New Point
        Dim loc15_1 As New Point
        Dim loc16_1 As New Point
        Dim loc17_1 As New Point
        Dim loc18_1 As New Point
        Dim loc19_1 As New Point
        Dim loc20_1 As New Point
        Dim loc21_1 As New Point
        Dim loc22_1 As New Point
        Dim loc23_1 As New Point
        Dim loc24_1 As New Point
        Dim loc25_1 As New Point
        Dim loc26_1 As New Point
        Dim loc27_1 As New Point
        Dim loc28_1 As New Point
        Dim loc29_1 As New Point
        Dim loc30_1 As New Point
        Dim loc31_1 As New Point
        Dim loc32_1 As New Point
        Dim loc33_1 As New Point
        Dim loc34_1 As New Point
        Dim loc35_1 As New Point
        Dim loc36_1 As New Point
        Dim loc37_1 As New Point
        Dim loc38_1 As New Point
        Dim loc39_1 As New Point
        Dim loc40_1 As New Point

    End Sub

    Public Sub DrawDot(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Load

        Dim mygraphics As Graphics
        mygraphics = picBoard.CreateGraphics
        Dim pen As New Drawing.Pen(System.Drawing.Color.Red, 1)
        mygraphics.DrawEllipse(pen, 0, 0, 100, 100)
        pen.Dispose()

    End Sub


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
        picBoard.Height = Me.Height - 30
        picBoard.Width = Me.Height - 30
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