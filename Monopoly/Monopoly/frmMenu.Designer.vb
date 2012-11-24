<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblMonopoly = New System.Windows.Forms.Label()
        Me.lblPlayers = New System.Windows.Forms.Label()
        Me.cmbPlayers = New System.Windows.Forms.ComboBox()
        Me.lblPlayer1 = New System.Windows.Forms.Label()
        Me.lblName1 = New System.Windows.Forms.Label()
        Me.lblColour1 = New System.Windows.Forms.Label()
        Me.lblDifficulty1 = New System.Windows.Forms.Label()
        Me.txtName1 = New System.Windows.Forms.TextBox()
        Me.cmbDifficulty1 = New System.Windows.Forms.ComboBox()
        Me.cmbColour1 = New System.Windows.Forms.ComboBox()
        Me.cmbColour2 = New System.Windows.Forms.ComboBox()
        Me.cmbDifficulty2 = New System.Windows.Forms.ComboBox()
        Me.txtName2 = New System.Windows.Forms.TextBox()
        Me.lblDifficulty2 = New System.Windows.Forms.Label()
        Me.lblColour2 = New System.Windows.Forms.Label()
        Me.lblName2 = New System.Windows.Forms.Label()
        Me.lblPlayer2 = New System.Windows.Forms.Label()
        Me.cmbColour3 = New System.Windows.Forms.ComboBox()
        Me.cmbDifficulty3 = New System.Windows.Forms.ComboBox()
        Me.txtName3 = New System.Windows.Forms.TextBox()
        Me.lblDifficulty3 = New System.Windows.Forms.Label()
        Me.lblColour3 = New System.Windows.Forms.Label()
        Me.lblName3 = New System.Windows.Forms.Label()
        Me.lblPlayer3 = New System.Windows.Forms.Label()
        Me.cmbColour4 = New System.Windows.Forms.ComboBox()
        Me.cmbDifficulty4 = New System.Windows.Forms.ComboBox()
        Me.txtName4 = New System.Windows.Forms.TextBox()
        Me.lblDifficulty4 = New System.Windows.Forms.Label()
        Me.lblColour4 = New System.Windows.Forms.Label()
        Me.lblName4 = New System.Windows.Forms.Label()
        Me.lblPlayer4 = New System.Windows.Forms.Label()
        Me.btnBegin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(407, 700)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblMonopoly
        '
        Me.lblMonopoly.AutoSize = True
        Me.lblMonopoly.BackColor = System.Drawing.Color.DodgerBlue
        Me.lblMonopoly.Font = New System.Drawing.Font("Monotxt_IV25", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonopoly.Location = New System.Drawing.Point(34, 9)
        Me.lblMonopoly.Name = "lblMonopoly"
        Me.lblMonopoly.Size = New System.Drawing.Size(412, 46)
        Me.lblMonopoly.TabIndex = 1
        Me.lblMonopoly.Text = "MAT'S MONOPOLY"
        '
        'lblPlayers
        '
        Me.lblPlayers.AutoSize = True
        Me.lblPlayers.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayers.Location = New System.Drawing.Point(37, 71)
        Me.lblPlayers.Name = "lblPlayers"
        Me.lblPlayers.Size = New System.Drawing.Size(195, 25)
        Me.lblPlayers.TabIndex = 2
        Me.lblPlayers.Text = "Number of Players:"
        '
        'cmbPlayers
        '
        Me.cmbPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlayers.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPlayers.FormattingEnabled = True
        Me.cmbPlayers.Items.AddRange(New Object() {"2", "3", "4"})
        Me.cmbPlayers.Location = New System.Drawing.Point(238, 71)
        Me.cmbPlayers.Name = "cmbPlayers"
        Me.cmbPlayers.Size = New System.Drawing.Size(50, 33)
        Me.cmbPlayers.TabIndex = 3
        '
        'lblPlayer1
        '
        Me.lblPlayer1.AutoSize = True
        Me.lblPlayer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer1.ForeColor = System.Drawing.Color.Black
        Me.lblPlayer1.Location = New System.Drawing.Point(38, 132)
        Me.lblPlayer1.Name = "lblPlayer1"
        Me.lblPlayer1.Size = New System.Drawing.Size(77, 24)
        Me.lblPlayer1.TabIndex = 4
        Me.lblPlayer1.Text = "Player 1"
        '
        'lblName1
        '
        Me.lblName1.AutoSize = True
        Me.lblName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName1.Location = New System.Drawing.Point(38, 177)
        Me.lblName1.Name = "lblName1"
        Me.lblName1.Size = New System.Drawing.Size(55, 20)
        Me.lblName1.TabIndex = 5
        Me.lblName1.Text = "Name:"
        '
        'lblColour1
        '
        Me.lblColour1.AutoSize = True
        Me.lblColour1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColour1.Location = New System.Drawing.Point(38, 221)
        Me.lblColour1.Name = "lblColour1"
        Me.lblColour1.Size = New System.Drawing.Size(59, 20)
        Me.lblColour1.TabIndex = 6
        Me.lblColour1.Text = "Colour:"
        '
        'lblDifficulty1
        '
        Me.lblDifficulty1.AutoSize = True
        Me.lblDifficulty1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifficulty1.Location = New System.Drawing.Point(253, 177)
        Me.lblDifficulty1.Name = "lblDifficulty1"
        Me.lblDifficulty1.Size = New System.Drawing.Size(73, 20)
        Me.lblDifficulty1.TabIndex = 7
        Me.lblDifficulty1.Text = "Difficulty:"
        '
        'txtName1
        '
        Me.txtName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName1.Location = New System.Drawing.Point(99, 174)
        Me.txtName1.MaxLength = 10
        Me.txtName1.Name = "txtName1"
        Me.txtName1.Size = New System.Drawing.Size(123, 26)
        Me.txtName1.TabIndex = 8
        '
        'cmbDifficulty1
        '
        Me.cmbDifficulty1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDifficulty1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDifficulty1.FormattingEnabled = True
        Me.cmbDifficulty1.Items.AddRange(New Object() {"Easy", "Normal", "Hard"})
        Me.cmbDifficulty1.Location = New System.Drawing.Point(325, 174)
        Me.cmbDifficulty1.Name = "cmbDifficulty1"
        Me.cmbDifficulty1.Size = New System.Drawing.Size(121, 28)
        Me.cmbDifficulty1.TabIndex = 9
        '
        'cmbColour1
        '
        Me.cmbColour1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbColour1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbColour1.FormattingEnabled = True
        Me.cmbColour1.Location = New System.Drawing.Point(99, 218)
        Me.cmbColour1.Name = "cmbColour1"
        Me.cmbColour1.Size = New System.Drawing.Size(121, 28)
        Me.cmbColour1.TabIndex = 10
        '
        'cmbColour2
        '
        Me.cmbColour2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbColour2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbColour2.FormattingEnabled = True
        Me.cmbColour2.Location = New System.Drawing.Point(99, 359)
        Me.cmbColour2.Name = "cmbColour2"
        Me.cmbColour2.Size = New System.Drawing.Size(121, 28)
        Me.cmbColour2.TabIndex = 17
        '
        'cmbDifficulty2
        '
        Me.cmbDifficulty2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDifficulty2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDifficulty2.FormattingEnabled = True
        Me.cmbDifficulty2.Items.AddRange(New Object() {"Easy", "Normal", "Hard"})
        Me.cmbDifficulty2.Location = New System.Drawing.Point(325, 315)
        Me.cmbDifficulty2.Name = "cmbDifficulty2"
        Me.cmbDifficulty2.Size = New System.Drawing.Size(121, 28)
        Me.cmbDifficulty2.TabIndex = 16
        '
        'txtName2
        '
        Me.txtName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName2.Location = New System.Drawing.Point(99, 315)
        Me.txtName2.MaxLength = 10
        Me.txtName2.Name = "txtName2"
        Me.txtName2.Size = New System.Drawing.Size(123, 26)
        Me.txtName2.TabIndex = 15
        '
        'lblDifficulty2
        '
        Me.lblDifficulty2.AutoSize = True
        Me.lblDifficulty2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifficulty2.Location = New System.Drawing.Point(253, 318)
        Me.lblDifficulty2.Name = "lblDifficulty2"
        Me.lblDifficulty2.Size = New System.Drawing.Size(73, 20)
        Me.lblDifficulty2.TabIndex = 14
        Me.lblDifficulty2.Text = "Difficulty:"
        '
        'lblColour2
        '
        Me.lblColour2.AutoSize = True
        Me.lblColour2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColour2.Location = New System.Drawing.Point(38, 362)
        Me.lblColour2.Name = "lblColour2"
        Me.lblColour2.Size = New System.Drawing.Size(59, 20)
        Me.lblColour2.TabIndex = 13
        Me.lblColour2.Text = "Colour:"
        '
        'lblName2
        '
        Me.lblName2.AutoSize = True
        Me.lblName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName2.Location = New System.Drawing.Point(38, 318)
        Me.lblName2.Name = "lblName2"
        Me.lblName2.Size = New System.Drawing.Size(55, 20)
        Me.lblName2.TabIndex = 12
        Me.lblName2.Text = "Name:"
        '
        'lblPlayer2
        '
        Me.lblPlayer2.AutoSize = True
        Me.lblPlayer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer2.ForeColor = System.Drawing.Color.Black
        Me.lblPlayer2.Location = New System.Drawing.Point(38, 273)
        Me.lblPlayer2.Name = "lblPlayer2"
        Me.lblPlayer2.Size = New System.Drawing.Size(77, 24)
        Me.lblPlayer2.TabIndex = 11
        Me.lblPlayer2.Text = "Player 2"
        '
        'cmbColour3
        '
        Me.cmbColour3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbColour3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbColour3.FormattingEnabled = True
        Me.cmbColour3.Location = New System.Drawing.Point(99, 504)
        Me.cmbColour3.Name = "cmbColour3"
        Me.cmbColour3.Size = New System.Drawing.Size(121, 28)
        Me.cmbColour3.TabIndex = 24
        '
        'cmbDifficulty3
        '
        Me.cmbDifficulty3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDifficulty3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDifficulty3.FormattingEnabled = True
        Me.cmbDifficulty3.Items.AddRange(New Object() {"Easy", "Normal", "Hard"})
        Me.cmbDifficulty3.Location = New System.Drawing.Point(325, 460)
        Me.cmbDifficulty3.Name = "cmbDifficulty3"
        Me.cmbDifficulty3.Size = New System.Drawing.Size(121, 28)
        Me.cmbDifficulty3.TabIndex = 23
        '
        'txtName3
        '
        Me.txtName3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName3.Location = New System.Drawing.Point(99, 460)
        Me.txtName3.MaxLength = 10
        Me.txtName3.Name = "txtName3"
        Me.txtName3.Size = New System.Drawing.Size(123, 26)
        Me.txtName3.TabIndex = 22
        '
        'lblDifficulty3
        '
        Me.lblDifficulty3.AutoSize = True
        Me.lblDifficulty3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifficulty3.Location = New System.Drawing.Point(253, 463)
        Me.lblDifficulty3.Name = "lblDifficulty3"
        Me.lblDifficulty3.Size = New System.Drawing.Size(73, 20)
        Me.lblDifficulty3.TabIndex = 21
        Me.lblDifficulty3.Text = "Difficulty:"
        '
        'lblColour3
        '
        Me.lblColour3.AutoSize = True
        Me.lblColour3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColour3.Location = New System.Drawing.Point(38, 507)
        Me.lblColour3.Name = "lblColour3"
        Me.lblColour3.Size = New System.Drawing.Size(59, 20)
        Me.lblColour3.TabIndex = 20
        Me.lblColour3.Text = "Colour:"
        '
        'lblName3
        '
        Me.lblName3.AutoSize = True
        Me.lblName3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName3.Location = New System.Drawing.Point(38, 463)
        Me.lblName3.Name = "lblName3"
        Me.lblName3.Size = New System.Drawing.Size(55, 20)
        Me.lblName3.TabIndex = 19
        Me.lblName3.Text = "Name:"
        '
        'lblPlayer3
        '
        Me.lblPlayer3.AutoSize = True
        Me.lblPlayer3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer3.ForeColor = System.Drawing.Color.Black
        Me.lblPlayer3.Location = New System.Drawing.Point(38, 418)
        Me.lblPlayer3.Name = "lblPlayer3"
        Me.lblPlayer3.Size = New System.Drawing.Size(77, 24)
        Me.lblPlayer3.TabIndex = 18
        Me.lblPlayer3.Text = "Player 3"
        '
        'cmbColour4
        '
        Me.cmbColour4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbColour4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbColour4.FormattingEnabled = True
        Me.cmbColour4.Location = New System.Drawing.Point(99, 652)
        Me.cmbColour4.Name = "cmbColour4"
        Me.cmbColour4.Size = New System.Drawing.Size(121, 28)
        Me.cmbColour4.TabIndex = 31
        '
        'cmbDifficulty4
        '
        Me.cmbDifficulty4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDifficulty4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDifficulty4.FormattingEnabled = True
        Me.cmbDifficulty4.Items.AddRange(New Object() {"Easy", "Normal", "Hard"})
        Me.cmbDifficulty4.Location = New System.Drawing.Point(325, 608)
        Me.cmbDifficulty4.Name = "cmbDifficulty4"
        Me.cmbDifficulty4.Size = New System.Drawing.Size(121, 28)
        Me.cmbDifficulty4.TabIndex = 30
        '
        'txtName4
        '
        Me.txtName4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName4.Location = New System.Drawing.Point(99, 608)
        Me.txtName4.MaxLength = 10
        Me.txtName4.Name = "txtName4"
        Me.txtName4.Size = New System.Drawing.Size(123, 26)
        Me.txtName4.TabIndex = 29
        '
        'lblDifficulty4
        '
        Me.lblDifficulty4.AutoSize = True
        Me.lblDifficulty4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifficulty4.Location = New System.Drawing.Point(253, 611)
        Me.lblDifficulty4.Name = "lblDifficulty4"
        Me.lblDifficulty4.Size = New System.Drawing.Size(73, 20)
        Me.lblDifficulty4.TabIndex = 28
        Me.lblDifficulty4.Text = "Difficulty:"
        '
        'lblColour4
        '
        Me.lblColour4.AutoSize = True
        Me.lblColour4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColour4.Location = New System.Drawing.Point(38, 655)
        Me.lblColour4.Name = "lblColour4"
        Me.lblColour4.Size = New System.Drawing.Size(59, 20)
        Me.lblColour4.TabIndex = 27
        Me.lblColour4.Text = "Colour:"
        '
        'lblName4
        '
        Me.lblName4.AutoSize = True
        Me.lblName4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName4.Location = New System.Drawing.Point(38, 611)
        Me.lblName4.Name = "lblName4"
        Me.lblName4.Size = New System.Drawing.Size(55, 20)
        Me.lblName4.TabIndex = 26
        Me.lblName4.Text = "Name:"
        '
        'lblPlayer4
        '
        Me.lblPlayer4.AutoSize = True
        Me.lblPlayer4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer4.ForeColor = System.Drawing.Color.Black
        Me.lblPlayer4.Location = New System.Drawing.Point(38, 566)
        Me.lblPlayer4.Name = "lblPlayer4"
        Me.lblPlayer4.Size = New System.Drawing.Size(77, 24)
        Me.lblPlayer4.TabIndex = 25
        Me.lblPlayer4.Text = "Player 4"
        '
        'btnBegin
        '
        Me.btnBegin.Location = New System.Drawing.Point(12, 700)
        Me.btnBegin.Name = "btnBegin"
        Me.btnBegin.Size = New System.Drawing.Size(75, 23)
        Me.btnBegin.TabIndex = 32
        Me.btnBegin.Text = "Begin"
        Me.btnBegin.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(494, 735)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBegin)
        Me.Controls.Add(Me.cmbColour4)
        Me.Controls.Add(Me.cmbDifficulty4)
        Me.Controls.Add(Me.txtName4)
        Me.Controls.Add(Me.lblDifficulty4)
        Me.Controls.Add(Me.lblColour4)
        Me.Controls.Add(Me.lblName4)
        Me.Controls.Add(Me.lblPlayer4)
        Me.Controls.Add(Me.cmbColour3)
        Me.Controls.Add(Me.cmbDifficulty3)
        Me.Controls.Add(Me.txtName3)
        Me.Controls.Add(Me.lblDifficulty3)
        Me.Controls.Add(Me.lblColour3)
        Me.Controls.Add(Me.lblName3)
        Me.Controls.Add(Me.lblPlayer3)
        Me.Controls.Add(Me.cmbColour2)
        Me.Controls.Add(Me.cmbDifficulty2)
        Me.Controls.Add(Me.txtName2)
        Me.Controls.Add(Me.lblDifficulty2)
        Me.Controls.Add(Me.lblColour2)
        Me.Controls.Add(Me.lblName2)
        Me.Controls.Add(Me.lblPlayer2)
        Me.Controls.Add(Me.cmbColour1)
        Me.Controls.Add(Me.cmbDifficulty1)
        Me.Controls.Add(Me.txtName1)
        Me.Controls.Add(Me.lblDifficulty1)
        Me.Controls.Add(Me.lblColour1)
        Me.Controls.Add(Me.lblName1)
        Me.Controls.Add(Me.lblPlayer1)
        Me.Controls.Add(Me.cmbPlayers)
        Me.Controls.Add(Me.lblPlayers)
        Me.Controls.Add(Me.lblMonopoly)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 800)
        Me.MinimizeBox = False
        Me.Name = "frmMenu"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblMonopoly As System.Windows.Forms.Label
    Friend WithEvents lblPlayers As System.Windows.Forms.Label
    Friend WithEvents cmbPlayers As System.Windows.Forms.ComboBox
    Friend WithEvents lblPlayer1 As System.Windows.Forms.Label
    Friend WithEvents lblName1 As System.Windows.Forms.Label
    Friend WithEvents lblColour1 As System.Windows.Forms.Label
    Friend WithEvents lblDifficulty1 As System.Windows.Forms.Label
    Friend WithEvents txtName1 As System.Windows.Forms.TextBox
    Friend WithEvents cmbDifficulty1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbColour1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbColour2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDifficulty2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtName2 As System.Windows.Forms.TextBox
    Friend WithEvents lblDifficulty2 As System.Windows.Forms.Label
    Friend WithEvents lblColour2 As System.Windows.Forms.Label
    Friend WithEvents lblName2 As System.Windows.Forms.Label
    Friend WithEvents lblPlayer2 As System.Windows.Forms.Label
    Friend WithEvents cmbColour3 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDifficulty3 As System.Windows.Forms.ComboBox
    Friend WithEvents txtName3 As System.Windows.Forms.TextBox
    Friend WithEvents lblDifficulty3 As System.Windows.Forms.Label
    Friend WithEvents lblColour3 As System.Windows.Forms.Label
    Friend WithEvents lblName3 As System.Windows.Forms.Label
    Friend WithEvents lblPlayer3 As System.Windows.Forms.Label
    Friend WithEvents cmbColour4 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDifficulty4 As System.Windows.Forms.ComboBox
    Friend WithEvents txtName4 As System.Windows.Forms.TextBox
    Friend WithEvents lblDifficulty4 As System.Windows.Forms.Label
    Friend WithEvents lblColour4 As System.Windows.Forms.Label
    Friend WithEvents lblName4 As System.Windows.Forms.Label
    Friend WithEvents lblPlayer4 As System.Windows.Forms.Label
    Friend WithEvents btnBegin As System.Windows.Forms.Button

End Class
