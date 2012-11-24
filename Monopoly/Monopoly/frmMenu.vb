Public Class frmMenu

    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 500
        Me.Height = 462

        btnClose.Location = New Point(12, 399)
        btnBegin.Location = New Point(407, 399)

        lblPlayer3.Visible = False
        lblName3.Visible = False
        lblDifficulty3.Visible = False
        lblColour3.Visible = False
        txtName3.Visible = False
        cmbColour3.Visible = False
        cmbDifficulty3.Visible = False

        lblPlayer4.Visible = False
        lblName4.Visible = False
        lblDifficulty4.Visible = False
        lblColour4.Visible = False
        txtName4.Visible = False
        cmbColour4.Visible = False
        cmbDifficulty4.Visible = False

        cmbPlayers.Text = 2

    End Sub

    Private Sub cmbPlayers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlayers.SelectedIndexChanged

        If cmbPlayers.SelectedItem = "2" Then
            Me.MaximumSize = New Size(500, 462)
            Me.Width = 500
            Me.Height = 462



            btnClose.Location = New Point(12, 399)
            btnBegin.Location = New Point(407, 399)

            lblPlayer3.Visible = False
            lblName3.Visible = False
            lblDifficulty3.Visible = False
            lblColour3.Visible = False
            txtName3.Visible = False
            cmbColour3.Visible = False
            cmbDifficulty3.Visible = False

            lblPlayer4.Visible = False
            lblName4.Visible = False
            lblDifficulty4.Visible = False
            lblColour4.Visible = False
            txtName4.Visible = False
            cmbColour4.Visible = False
            cmbDifficulty4.Visible = False

        ElseIf cmbPlayers.SelectedItem = "3" Then
            Me.MaximumSize = New Size(500, 607)
            Me.Width = 500
            Me.Height = 607

            btnClose.Location = New Point(12, 544)
            btnBegin.Location = New Point(407, 544)

            lblPlayer3.Visible = True
            lblName3.Visible = True
            lblDifficulty3.Visible = True
            lblColour3.Visible = True
            txtName3.Visible = True
            cmbColour3.Visible = True
            cmbDifficulty3.Visible = True

            lblPlayer4.Visible = False
            lblName4.Visible = False
            lblDifficulty4.Visible = False
            lblColour4.Visible = False
            txtName4.Visible = False
            cmbColour4.Visible = False
            cmbDifficulty4.Visible = False

        ElseIf cmbPlayers.SelectedItem = "4" Then
            Me.MaximumSize = New Size(500, 763)
            Me.Width = 500
            Me.Height = 763


            btnClose.Location = New Point(12, 700)
            btnBegin.Location = New Point(407, 700)

            lblPlayer3.Visible = True
            lblName3.Visible = True
            lblDifficulty3.Visible = True
            lblColour3.Visible = True
            txtName3.Visible = True
            cmbColour3.Visible = True
            cmbDifficulty3.Visible = True

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
        Me.Hide()
        frmGame.Show()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        End
    End Sub
End Class